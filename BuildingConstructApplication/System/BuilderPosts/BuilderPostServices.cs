using Data.DataContext;
using Data.Entities;
using Data.Enum;
using Gridify;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using System.Text;
using ViewModels.BuilderPosts;
using ViewModels.Pagination;

namespace Application.System.BuilderPosts
{
    public class BuilderPostServices : IBuilderPostService
    {
        private readonly BuildingConstructDbContext _context;

        public BuilderPostServices(BuildingConstructDbContext context)
        {
            _context = context;
        }

        public async Task<BasePagination<List<BuilderPostDTO>>> GetPost(PaginationFilter filter)
        {
            BasePagination<List<BuilderPostDTO>> response;
            var orderBy = filter._orderBy.ToString();
            int totalRecord;

            orderBy = orderBy switch
            {
                "1" => "ascending",
                "-1" => "descending",
                _ => orderBy
            };

            IQueryable<BuilderPost> query = _context.BuilderPosts;
            StringBuilder PlaceSearch = new();
            StringBuilder CategoriesSearch = new();

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

                if (filter.FilterRequest.Categories.Any())
                {
                    var count = filter.FilterRequest.Categories.Count;
                    for (int i = 0; i < count; i++)
                    {
                        if (i == count - 1)
                        {
                            CategoriesSearch.Append("PostCategories=" + filter.FilterRequest.Categories[i]);
                            break;
                        }
                        CategoriesSearch.Append("PostCategories=" + filter.FilterRequest.Categories[i] + "|");
                    }
                    query = query.ApplyFiltering(CategoriesSearch.ToString());
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
                totalRecord = await _context.BuilderPosts.CountAsync();
            }

            if (!result.Any())
            {
                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.EMPTY_MESSAGE,
                    Data = new List<BuilderPostDTO>(),
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

        public async Task<BasePagination<List<BuilderPostDTO>>> SearchPost(PaginationFilter filter, string keyword)
        {
            BasePagination<List<BuilderPostDTO>> response;

            var result = await _context.BuilderPosts.Where(x => x.Title.Contains(keyword)).ToListAsync();
            var totalRecord = result.Count;

            if (!result.Any())
            {
                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.EMPTY_MESSAGE,
                    Data = new(),
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

        private List<BuilderPostDTO> MapListDTO(List<BuilderPost> list)
        {
            List<BuilderPostDTO> result = new();

            foreach (var item in list)
            {
                var user = _context.Users.Where(x => x.BuilderId == item.BuilderID).FirstOrDefault();

                BuilderPostDTO dto = new()
                {
                    //Avatar = user.Avatar,
                    Description = item.Description,
                    Id = item.Id,
                    Place = item.Place,
                    PostCategories = item.PostCategories,
                    Title = item.Title,
                    LastModifiedAt = item.LastModifiedAt,
                    BuilderID = item.BuilderID,
                    Field = item.Field,
                };
                result.Add(dto);
            }
            return result;
        }
    }
}