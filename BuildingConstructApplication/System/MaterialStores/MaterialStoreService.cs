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

namespace Application.System.MaterialStores
{
    public class MaterialStoreService : IMaterialStoreService
    {
        private readonly BuildingConstructDbContext _context;

        public MaterialStoreService(BuildingConstructDbContext context)
        {
            _context = context;
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
            StringBuilder PlaceSearch = new();

            if (filter.FilterRequest != null)
            {
                if (filter.FilterRequest.Places.Any())
                {
                    var count = filter.FilterRequest.Places.Count;
                    for (int i = 0; i < count; i++)
                    {
                        if (i == count - 1)
                        {
                            PlaceSearch.Append("Place=" + filter.FilterRequest.Places[i]);
                            break;
                        }
                        PlaceSearch.Append("Place=" + filter.FilterRequest.Places[i] + "|");
                    }
                    query = query.ApplyFiltering(PlaceSearch.ToString());
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
                    Data = null,
                    Pagination = null
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
                    Data = null,
                    Pagination = null
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
                    Webstie = item.Webstie

                };
                result.Add(dto);
            }
            return result;
        }
    }
}