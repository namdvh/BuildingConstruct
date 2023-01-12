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

namespace Application.System.MaterialStores
{
    public class MaterialStoreService : IMaterialStoreService
    {
        private readonly BuildingConstructDbContext _context;
        private IHttpContextAccessor _accessor;

        public MaterialStoreService(BuildingConstructDbContext context, IHttpContextAccessor accessor)
        {
            _context = context;
            _accessor = accessor;
        }

        public async Task<bool> CreateProduct(ProductDTO request)
        {
            Claim identifierClaim = _accessor.HttpContext.User.FindFirst("UserID");
            var userID = identifierClaim.Value.ToString();
            var roles = _accessor.HttpContext.User.FindFirst(ClaimTypes.Role).Value.ToString();
            if (!roles.Equals("Store"))
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
            await _context.Products.AddAsync(products);
            await _context.SaveChangesAsync();
            if (request.CategoriesId != null)
            {
                var productcate = new ProductCategories();

                foreach (var item in request.CategoriesId)
                {
                    var check = _context.Categories.Where(x => x.ID == item).SingleOrDefault();
                    if (check == null)
                    {
                        _context.Products.Remove(products);
                        await _context.SaveChangesAsync();
                        return false;
                    }
                    var id = products.Id;
                    productcate.ProductID = id;
                    productcate.CategoriesID = item;
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

        public async Task<BasePagination<List<ProductStoreDTO>>> GetAllProductStore(PaginationFilter filter)
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

            IQueryable<Products> query = _context.Products.Include(x=>x.ProductCategories);


            var data = await query
                .AsNoTracking()
               .OrderBy(filter._sortBy + " " + orderBy)
               .Skip((filter.PageNumber - 1) * filter.PageSize)
               .Take(filter.PageSize)
               .ToListAsync();
            var totalRecords = await _context.ProductSystems.Where(x => x.FromSystem == true).CountAsync();

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
                    Data = await MapListDTO(data),
                    Pagination = pagination
                };
            }

            return response;
        }
        public async Task<List<ProductStoreDTO>> MapListDTO(List<Products> list)
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
                dto.Image = item.Image;
                dto.ProductCategories = await GetCategory(item.ProductCategories);
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
                .Include(x=>x.User)
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
                    Avatar = item.User.Avatar,
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
            var rs = await _context.Products.Include(x => x.ProductCategories).SingleOrDefaultAsync(x => x.Id == productId);
            if (rs == null)
            {

                response.Code = BaseCode.ERROR;
                response.Message = "Cannot find that Product";
                return response;
            }
            ProductDetailDTO productDetail = new();
            productDetail.Id = rs.Id;
            productDetail.Name = rs.Name;
            productDetail.Image = rs.Image;
            productDetail.Description = rs.Description;
            productDetail.UnitInStock = rs.UnitInStock;
            productDetail.UnitPrice = rs.UnitPrice;
            productDetail.SoldQuantities = rs.SoldQuantities;
            productDetail.Store = await GetStore((int)rs.MaterialStoreID);
            productDetail.ProductCategories = await GetCategory(rs.ProductCategories);
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
                final.Type = results.Type;
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

        public async Task<BaseResponse<ProductStoreDTO>> UpdateProduct(ProductDTO request, int productId)
        {
            Claim identifierClaim = _accessor.HttpContext.User.FindFirst("UserID");
            var userID = identifierClaim.Value.ToString();
            var storeID = await _context.Users.Where(x => x.Id.ToString().Equals(userID)).Select(x => x.MaterialStoreID).SingleOrDefaultAsync();
            BaseResponse<ProductStoreDTO> response = new();
            var products = await _context.Products.Where(x => x.Id == productId && x.MaterialStoreID == storeID).FirstOrDefaultAsync();
            if (productId == null)
            {
                response.Message = BaseCode.ERROR_MESSAGE;
                response.Code = BaseCode.ERROR;
                response.Data = null;
                return response;
            }
            products.Name = request.Name;
            products.Description = request.Description;
            products.SoldQuantities = request.SoldQuantities;
            products.UnitPrice = request.UnitPrice;
            products.UnitInStock = request.UnitInStock;
            products.Brand = request.Brand;
            products.Image = request.Image;
            var listcate = new List<CategoryDTO>();
            if (request.CategoriesId != null && products.ProductCategories != null)
            {
                foreach (var item in request.CategoriesId)
                {
                    var cate = _context.Categories.Where(x => x.ID == item).SingleOrDefault();
                    if (cate != null)
                    {
                        var category = new CategoryDTO();
                        foreach (var i in products.ProductCategories)
                        {
                            category.Id = cate.ID;
                            category.Name = cate.Name;
                            category.Type = cate.Type;
                            i.CategoriesID = cate.ID;
                            i.ProductID = productId;
                            _context.Update(i);
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
            }
            _context.Update(products);
            var results = await _context.SaveChangesAsync();
            if (results > 0)
            {
                response.Message = BaseCode.SUCCESS_MESSAGE;
                response.Code = BaseCode.SUCCESS;
                response.Data = new();
                response.Data.Name = request.Name;
                response.Data.Description = request.Description;
                response.Data.Brand = request.Brand;
                response.Data.UnitInStock = request.UnitInStock;
                response.Data.UnitPrice = request.UnitPrice;
                response.Data.Image = request.Image;
                response.Data.SoldQuantities = request.SoldQuantities;
                response.Data.ProductCategories = listcate;
            }
            return response;
        }
    }
}