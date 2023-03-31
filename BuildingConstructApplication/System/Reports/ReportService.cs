using Application.System.MaterialStores;
using Data.DataContext;
using Data.Entities;
using Data.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using ViewModels.Categories;
using ViewModels.MaterialStore;
using ViewModels.Pagination;

namespace Application.System.Reports
{
    public class ReportService : IReportService
    {
        private readonly BuildingConstructDbContext _context;
        private IHttpContextAccessor _accessor;
        public ReportService(BuildingConstructDbContext context, IHttpContextAccessor accessor)
        {
            _context = context;
            _accessor = accessor;
        }
        public async Task<BasePagination<List<ReportProductDTO>>> GetAllReportProduct(PaginationFilter filter,Guid userId)
        {
            BasePagination<List<ReportProductDTO>> response;
            var orderBy = filter._orderBy.ToString();

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
            IQueryable<Products> query = (IQueryable<Products>) _context.Products.Include(x => x.Reports).Include(x => x.MaterialStore).ThenInclude(x => x.User);
                                                                //select new
                                                                //{
                                                                //    Product=p,
                                                                //    ReportCount=p.Reports.Count()
                                                                //});


            var data = await query
                .AsNoTracking()
                .Where(x=>x.Reports!=null)
               .OrderBy(filter._sortBy + " " + orderBy)
               .Skip((filter.PageNumber - 1) * filter.PageSize)
               .Take(filter.PageSize)
               .ToListAsync();


            var totalRecords = await _context.Products.Include
                (x=>x.Reports).Where(x=>x.Reports!=null).CountAsync();

            if (!data.Any())
            {
                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.EMPTY_MESSAGE,
                    Data = new List<ReportProductDTO>(),
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

                response = new();
                response.Data = new();
                foreach (var item in data)
                {
                    ReportProductDTO dto = new();
                    dto.Id = item.Id;
                    dto.Name = item.Name;
                    dto.Description = item.Description;
                    dto.Brand = item.Brand;
                    dto.UnitInStock = item.UnitInStock;
                    dto.UnitPrice = item.UnitPrice;
                    dto.SoldQuantities = item.SoldQuantities;
                    dto.LastModifiedAt = item.LastModifiedAt;
                    dto.ReportCount = item.Reports.Count();
                    string img = item?.Image;
                    if (img != null)
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
                    response.Data.Add(dto);
                }
                response.Code = BaseCode.SUCCESS;
                response.Message = BaseCode.SUCCESS_MESSAGE;
                response.Pagination = pagination;
            }
            return response;
        }
       
        public async Task<List<CategoryDTO>> GetCategory(List<ProductCategories> productCategories)
        {
            List<CategoryDTO> list = new();
            foreach (var c in productCategories)
            {
                var final = new CategoryDTO();
                final.Id = c.CategoriesID;
                final.CategoryName = c.Name;
                final.Name = c.Name;
                list.Add(final);
            }
            return list;
        }

        public Task<bool> ReportProduct(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
