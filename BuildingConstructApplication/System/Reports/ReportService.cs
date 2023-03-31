using Application.System.MaterialStores;
using Data.DataContext;
using Data.Entities;
using Data.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using System.Security.Claims;
using ViewModels.Categories;
using ViewModels.MaterialStore;
using ViewModels.Pagination;
using ViewModels.Response;

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
        public async Task<BasePagination<List<ReportProductDTO>>> GetAllReportProduct(PaginationFilter filter, int? storeID)
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
            IQueryable<Products> query = (IQueryable<Products>) _context.Products.Include(x => x.ProductCategories).Include(x => x.Reports).Include(x => x.MaterialStore).ThenInclude(x => x.User);
                                                                //select new
                                                                //{
                                                                //    Product=p,
                                                                //    ReportCount=p.Reports.Count()
                                                                //});


            var data = await query
                .AsNoTracking()
                .Where(x=>x.Reports.Any() && x.MaterialStoreID==storeID && x.Status==true)
               .OrderBy(filter._sortBy + " " + orderBy)
               .Skip((filter.PageNumber - 1) * filter.PageSize)
               .Take(filter.PageSize)
               .ToListAsync();


            var totalRecords = await _context.Products.Include
                (x=>x.Reports).Where(x=>x.Reports.Any()).CountAsync();

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

        public async Task<BaseResponse<bool>> ReportProduct(ReportRequestDTO report)
        {
            //Claim identifierClaim = _accessor.HttpContext.User.FindFirst("UserID");
            var response = new BaseResponse<bool>();
            //var userID = identifierClaim.Value.ToString();
            var checkrp = await _context.Reports.Where(x => x.ProductId == report.ProductId && x.CreateBy == Guid.Parse("be21b564-a044-11ed-a8fc-0242ac120002")).CountAsync();
            if (checkrp > 0)
            {
                response.Code = BaseCode.ERROR;
                response.Data = false;
                response.Message = "Bạn đã report sản phẩm này rồi";
                return response;
            }
            var rp = new Report()
            {
                ProductId=report.ProductId,
                LastModifiedAt=DateTime.Now,
                CreateBy=Guid.Parse("be21b564-a044-11ed-a8fc-0242ac120002"),
                ReportProblem=report.ReportProblem
            };
            await _context.Reports.AddAsync(rp);
            var rs = await _context.SaveChangesAsync();
            var count = await _context.Reports.Where(x => x.ProductId == report.ProductId).CountAsync();
            if (count == 5)
            {
                var pd = await _context.Products.Where(x => x.Id == report.ProductId).FirstOrDefaultAsync();
                pd.Status = false;
                _context.Products.Update(pd);
                await _context.SaveChangesAsync();
            }

            if (rs > 0)
            {
                response.Code = BaseCode.SUCCESS;
                response.Message = "Report thành công";
                response.Data = true;
            }
            else
            {
                response.Code = BaseCode.ERROR;
                response.Data = false;
                response.Message = "Report không thành công";
            }
            return response;
        }
    }
}
