using Data.DataContext;
using Data.Entities;
using Data.Enum;
using Gridify;
using System.Text;
using ViewModels.MaterialStore;
using System.Linq.Dynamic.Core;
using ViewModels.Pagination;
using Microsoft.EntityFrameworkCore;
using ViewModels.ContractorPost;
using ViewModels.Response;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using ViewModels.Categories;

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
                var user = _context.Users.Where(x => x.MaterialStoreID == item.Id).FirstOrDefault();

                MaterialStoreDTO dto = new()
                {
                    //Avatar = user.Avatar,
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
    }
}