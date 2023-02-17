using Data.DataContext;
using Data.Entities;
using Data.Enum;
using Gridify;
using System.Text;
using System.Linq.Dynamic.Core;
using ViewModels.Pagination;
using Microsoft.EntityFrameworkCore;
using ViewModels.ContractorPost;
using ViewModels.Response;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using ViewModels.Categories;
using ViewModels.MaterialStore;
using AutoMapper;

namespace Application.System.MaterialStores
{
    public class MaterialStoreService : IMaterialStoreService
    {
        private readonly BuildingConstructDbContext _context;
        private IHttpContextAccessor _accessor;
        private readonly IMapper _mapper;

        public MaterialStoreService(BuildingConstructDbContext context, IHttpContextAccessor accessor, IMapper mapper)
        {
            _context = context;
            _accessor = accessor;
            _mapper = mapper;
        }

        public async Task<bool> CreateProduct(ProductDTO request)
        {
            Claim identifierClaim = _accessor.HttpContext.User.FindFirst("UserID");
            var userID = identifierClaim.Value.ToString();
            var roles = _accessor.HttpContext.User.FindFirst(ClaimTypes.Role).Value.ToString();
            if (!roles.ToLower().Equals(("store")))
            {
                return false;
            }
            var storeID = await _context.Users.Where(x => x.Id.ToString().Equals(userID)).Select(x => x.MaterialStoreID).FirstOrDefaultAsync();
            Products products = new();
            products.Name = request.Name;
            products.Description = request.Description;
            products.Brand = request.Brand;
            products.UnitPrice = request.UnitPrice;
            products.UnitInStock = request.UnitInStock;
            products.Image = request.Image;
            products.SoldQuantities = 0;
            products.MaterialStoreID = storeID;
            products.Unit = request.Unit;
            products.CreatedBy = Guid.Parse(userID);
            await _context.Products.AddAsync(products);
            await _context.SaveChangesAsync();
            if (request.ProductTypes != null)
            {
                List<ProductType> list = new();
                foreach(var item in request.ProductTypes)
                {
                    var productType = new ProductType();
                    productType.ProductID = products.Id;
                    productType.Quantity = item.Quantity;
                    productType.Name = item.TypeName;
                    list.Add(productType);
                    
                }
                await _context.AddRangeAsync(list);
                var rs=await _context.SaveChangesAsync();
                if (rs < 0)
                {
                     _context.Remove(products);
                    return false;
                }
            }
            if (request.Categories != null)
            {
                var productcate = new ProductCategories();

                foreach (var item in request.Categories)
                {
                    var check = _context.Categories.Where(x => x.ID == item.CategoryID).SingleOrDefault();
                    if (check == null)
                    {
                        _context.Products.Remove(products);
                        await _context.SaveChangesAsync();
                        return false;
                    }
                    var id = products.Id;
                    productcate.ProductID = id;
                    productcate.CategoriesID = item.CategoryID;
                    productcate.Name = item.Name;
                    await _context.AddAsync(productcate);
                    var rs = await _context.SaveChangesAsync();
                    if (rs < 0)
                    {
                        _context.Products.Remove(products);
                        await _context.SaveChangesAsync();
                        return false;
                    }

                }

            }
            return true;
        }

        public async Task<BasePagination<List<ProductStoreDTO>>> GetAllProductStore(PaginationFilter filter, bool isAll,int? storeID)
        {
            BasePagination<List<ProductStoreDTO>> response;
            var orderBy = filter._orderBy.ToString();
            int totalRecord;
           
            if (string.IsNullOrEmpty(filter._sortBy))
            {
                filter._sortBy = "Id";
            }
            orderBy = orderBy switch
            {
                "1" => "ascending",
                "-1" => "descending",
                _ => orderBy
            };

            IQueryable<Products> query = _context.Products.Include(x => x.ProductCategories).Include(x => x.MaterialStore).ThenInclude(x => x.User);


            var data = await query
                .AsNoTracking()
               .OrderBy(filter._sortBy + " " + orderBy)
               .Skip((filter.PageNumber - 1) * filter.PageSize)
               .Take(filter.PageSize)
               .ToListAsync();
            if (isAll==false)
            {
                data = await query
                .AsNoTracking().Where(x => x.MaterialStoreID == storeID)
               .OrderBy(filter._sortBy + " " + orderBy)
               .Skip((filter.PageNumber - 1) * filter.PageSize)
               .Take(filter.PageSize)
               .ToListAsync();
            }
            var totalRecords = await _context.Products.CountAsync();

            if (!data.Any())
            {
                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.EMPTY_MESSAGE,
                    Data = new List<ProductStoreDTO>(),
                };
            }
            else
            {
                double totalPages;

                totalPages = totalRecords / (double)filter.PageSize;

                var roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));
                Pagination pagination = new()
                {
                    CurrentPage = filter.PageNumber,
                    PageSize = filter.PageSize,
                    TotalPages = roundedTotalPages,
                    TotalRecords = totalRecords
                };

                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.SUCCESS_MESSAGE,
                    Data = await MapListDTO(data,isAll),
                    Pagination = pagination
                };
            }

            return response;
        }
        public async Task<List<ProductStoreDTO>> MapListDTO(List<Products> list,bool? isAll)
        {
            List<ProductStoreDTO> result = new();

            foreach (var item in list)
            {
                ProductStoreDTO dto = new();
                dto.Id = item.Id;
                dto.Name = item.Name;
                dto.Description = item.Description;
                dto.Brand = item.Brand;
                dto.UnitInStock = item.UnitInStock;
                dto.UnitPrice = item.UnitPrice;
                dto.SoldQuantities = item.SoldQuantities;
                
                string img = item?.Image;
                if(img != null)
                {
                    string[] firstImg = img.Split(",");
                    dto.Image = firstImg[0].Trim();
                }
                else
                {
                    dto.Image = "";
                }
                dto.StoreName = item.MaterialStore?.User?.FirstName + item.MaterialStore?.User?.LastName;
                dto.StoreID = item.MaterialStoreID;
                dto.StoreImage = item.MaterialStore?.Image;
                dto.ProductCategories = await GetCategory(item.ProductCategories);
                dto.isAll = isAll;
                result.Add(dto);
            }
            return result;
        }

        public async Task<BasePagination<List<MaterialStoreDTO>>> GetList(PaginationFilter filter)
        {
            BasePagination<List<MaterialStoreDTO>> response;
            var orderBy = filter._orderBy.ToString();
            int totalRecord;
            orderBy = orderBy switch
            {
                "1" => "ascending",
                "-1" => "descending",
                _ => orderBy
            };

            IQueryable<MaterialStore> query = _context.MaterialStores;
            StringBuilder placeSearch = new();

            if (filter.FilterRequest != null)
            {
                if (filter.FilterRequest.Places.Any())
                {
                    var count = filter.FilterRequest.Places.Count;
                    for (int i = 0; i < count; i++)
                    {
                        if (i == count - 1)
                        {
                            placeSearch.Append("Place=" + filter.FilterRequest.Places[i]);
                            break;
                        }
                        placeSearch.Append("Place=" + filter.FilterRequest.Places[i] + "|");
                    }
                    query = query.ApplyFiltering(placeSearch.ToString());
                }
            }

            var result = await query
                .Include(x => x.User)
               .OrderBy(filter._orderBy + " " + orderBy)
               .Skip((filter.PageNumber - 1) * filter.PageSize)
               .Take(filter.PageSize)
               .ToListAsync();

            if (filter.FilterRequest != null)
            {
                totalRecord = result.Count;
            }
            else
            {
                totalRecord = await _context.MaterialStores.CountAsync();
            }

            if (!result.Any())
            {
                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.EMPTY_MESSAGE,
                    Data = new()
                };
            }
            else
            {
                double totalPages;

                totalPages = ((double)totalRecord / (double)filter.PageSize);

                var roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));
                Pagination pagination = new()
                {
                    CurrentPage = filter.PageNumber,
                    PageSize = filter.PageSize,
                    TotalPages = roundedTotalPages,
                    TotalRecords = totalRecord
                };

                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.SUCCESS_MESSAGE,
                    Data = MapListDTO(result),
                    Pagination = pagination
                };
            }
            return response;
        }

        public async Task<BasePagination<List<MaterialStoreDTO>>> Search(PaginationFilter filter, string keyword)
        {
            BasePagination<List<MaterialStoreDTO>> response;

            var result = await _context.MaterialStores.Include(x => x.User).Where(x => x.User.LastName.Contains(keyword)).ToListAsync();
            var totalRecord = result.Count;

            if (!result.Any())
            {
                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.EMPTY_MESSAGE,
                    Data = new()
                };
            }
            else
            {
                double totalPages;

                totalPages = ((double)totalRecord / (double)filter.PageSize);

                var roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));
                Pagination pagination = new()
                {
                    CurrentPage = filter.PageNumber,
                    PageSize = filter.PageSize,
                    TotalPages = roundedTotalPages,
                    TotalRecords = totalRecord
                };

                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.SUCCESS_MESSAGE,
                    Data = MapListDTO(result),
                    Pagination = pagination
                };
            }
            return response;
        }

        private List<MaterialStoreDTO> MapListDTO(List<MaterialStore> list)
        {
            List<MaterialStoreDTO> result = new();

            foreach (var item in list)
            {

                MaterialStoreDTO dto = new()
                {

                    //Avatar = item.User.Avatar,
                    FirstName=item.User.FirstName,
                    LastName=item.User.LastName,
                    Description = item.Description,
                    Id = item.Id,
                    Place = item.Place,
                    Experience = item.Experience,
                    Image = item.Image,
                    TaxCode = item.TaxCode,
                    Webstie = item.Website

                };
                result.Add(dto);
            }
            return result;
        }

        public async Task<BaseResponse<ProductDetailDTO>> GetProductDetail(int productId)
        {
            BaseResponse<ProductDetailDTO> response = new();
            var rs = await _context.Products.Include(x => x.ProductCategories).Include(x=>x.ProductTypes).SingleOrDefaultAsync(x => x.Id == productId);
            if (rs == null)
            {

                response.Code = BaseCode.ERROR;
                response.Message = "Cannot find that Product";
                return response;
            }
            ProductDetailDTO productDetail = new();
            productDetail.Id = rs.Id;
            productDetail.Name = rs.Name;
           
            if (rs.Image != null)
            {
                string[] img = rs.Image.Split(",");
                productDetail.Image = new();
                foreach (var item in img)
                {

                    productDetail.Image.Add(item);
                }
            }
            productDetail.Description = rs.Description;
            productDetail.UnitInStock = rs.UnitInStock;
            productDetail.UnitPrice = rs.UnitPrice;
            productDetail.Brand = rs.Brand;
            productDetail.SoldQuantities = rs.SoldQuantities;
            productDetail.ProductType = await GetProductType(rs.ProductTypes);
            productDetail.Store = await GetStore((int)rs.MaterialStoreID);
            productDetail.ProductCategories = await GetCategory(rs.ProductCategories);
            productDetail.CreatedBy=rs.CreatedBy;
            response.Data = productDetail;
            response.Code = BaseCode.SUCCESS;
            response.Message = "SUCCESS";
            return response;
        }
        public async Task<MaterialStoreDTO> GetStore(int storeID)
        {
            var results = await _context.MaterialStores.Where(x => x.Id == storeID).SingleOrDefaultAsync();
            var final = new MaterialStoreDTO();
            final.Id = storeID;
            final.Webstie = results.Website;
            final.Description = results.Description;
            final.Image = results.Image;
            final.Experience = results.Experience;
            final.TaxCode = results.TaxCode;
            final.Place = results.Place;
            return final;
        }
        public async Task<List<CategoryDTO>> GetCategory(List<ProductCategories> productCategories)
        {
            List<CategoryDTO> list = new();
            foreach (var c in productCategories)
            {
                var results = await _context.Categories.Where(x => x.ID == c.CategoriesID).SingleOrDefaultAsync();
                var final = new CategoryDTO();
                final.Id = results.ID;
                final.Name = results.Name;
                list.Add(final);
            }
            return list;
        }
        public async Task<List<ProductTypeDTO>> GetProductType(List<ProductType> productType)
        {
            List<ProductTypeDTO> list = new();
            foreach (var c in productType)
            {
                var results = await _context.ProductTypes.Where(x => x.Id == c.Id).SingleOrDefaultAsync();
                var final = new ProductTypeDTO();
                final.Id = results.Id;
                final.TypeName = results.Name;
                final.Quantity = results.Quantity;
                list.Add(final);
            }
            return list;
        }

        public async Task<bool> DeleteProduct(int productID)
        {
            Claim identifierClaim = _accessor.HttpContext.User.FindFirst(ClaimTypes.Role);
            var role = identifierClaim.Value.ToString();
            if (!role.Equals("Store"))
            {
                return false;
            }
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == productID);
            if (product == null)
            {
                return false;
            }
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<BaseResponse<ProductStoreDTO>> UpdateProduct(UpdateProductDTO request, int productId)
        {
            Claim identifierClaim = _accessor.HttpContext.User.FindFirst("UserID");
            var userID = identifierClaim.Value.ToString();
            var storeID = await _context.Users.Where(x => x.Id.ToString().Equals(userID)).Select(x => x.MaterialStoreID).SingleOrDefaultAsync();
            BaseResponse<ProductStoreDTO> response = new();
            var products = await _context.Products.Include("ProductCategories").Where(x => x.Id == productId && x.MaterialStoreID == storeID).FirstOrDefaultAsync();
            if (productId == null)
            {
                response.Message = BaseCode.ERROR_MESSAGE;
                response.Code = BaseCode.ERROR;
                response.Data = null;
                return response;
            }
            if (!string.IsNullOrEmpty(request.Name.ToString()))
            {
                products.Name = request.Name;
            }
            if (!string.IsNullOrEmpty(request.Unit.ToString()))
            {
                products.Unit = request.Unit;
            }
            if (!string.IsNullOrEmpty(request.UnitPrice.ToString()))
            {
                products.UnitPrice = request.UnitPrice;

            }
            if (!string.IsNullOrEmpty(request.UnitInStock.ToString()))
            {
                products.UnitInStock = request.UnitInStock;

            }
            if (!string.IsNullOrEmpty(request.Description.ToString()))
            {
                products.Description = request.Description;

            }
            if (!string.IsNullOrEmpty(request.Brand.ToString()))
            {
                products.Brand = request.Brand;

            }
            if (!string.IsNullOrEmpty(request.Image.ToString()))
            {
                products.Image = request.Image;

            }
            _context.Entry<Products>(products).State = EntityState.Modified;

            var listcate = new List<CategoryDTO>();
            if (request.ProductTypes != null)
            {
                foreach(var i in request.ProductTypes)
                {
                    var type = _context.ProductTypes.AsNoTracking().FirstOrDefault(x=>x.Id==i.Id);
                    if (type != null)
                    {
                        type.ProductID = productId;
                        type.Name = i.Name;
                        type.Quantity = i.Quantity;
                        _context.Entry<ProductType>(type).State = EntityState.Modified;
                    }
                    else
                    {
                        var productType = new ProductType();
                        productType.ProductID = products.Id;
                        productType.Name = i.Name;
                        productType.Quantity = i.Quantity;
                        _context.Add(productType);
                    }
                }
                await _context.SaveChangesAsync();
            }
            if (request.Categories != null)
            {
                foreach (var i in products.ProductCategories)
                {
                    _context.ProductCategories.Remove(i);
                }
                foreach (var item in request.Categories)
                {
                    var cate = _context.Categories.Where(x => x.ID == item.CategoryID).SingleOrDefault();
                    if (cate != null)
                    {
                        var category = new CategoryDTO();
                        var productcate = new ProductCategories();

                        category.Id = cate.ID;
                        category.Name = cate.Name;
                        productcate.CategoriesID = cate.ID;
                        productcate.ProductID = productId;
                        productcate.Name = item.Name;
                        await _context.ProductCategories.AddAsync(productcate);

                        var rs = _context.SaveChanges();
                        if (rs < 0)
                        {
                            response.Message = BaseCode.ERROR_MESSAGE;
                            response.Code = BaseCode.ERROR;
                            response.Data = null;
                            return response;
                        }
                        listcate.Add(category);

                    }
                }
            }
             _context.Update(products);
            var results = await _context.SaveChangesAsync();
            if (results > 0)
            {
                response.Message = BaseCode.SUCCESS_MESSAGE;
                response.Code = BaseCode.SUCCESS;
            }
            return response;
        }
    }
}