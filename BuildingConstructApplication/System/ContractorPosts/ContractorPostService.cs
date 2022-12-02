using Data.DataContext;
using Data.Entities;
using Data.Enum;
using Gridify;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using ViewModels.ContractorPost;
using ViewModels.Pagination;
using Microsoft.EntityFrameworkCore;

namespace Application.System.ContractorPosts
{
    public class ContractorPostService : IContractorPostService
    {
        private readonly BuildingConstructDbContext _context;

        public ContractorPostService(BuildingConstructDbContext context)
        {
            _context = context;
        }



        public async Task<BasePagination<List<ContractorPostDTO>>> GetPost(PaginationFilter filter)
        {
            BasePagination<List<ContractorPostDTO>> response;
            var orderBy = filter._orderBy.ToString();

            orderBy = orderBy switch
            {
                "1" => "ascending",
                "-1" => "descending",
                _ => orderBy
            };


            IQueryable<ContractorPost> query = _context.ContractorPosts;
            StringBuilder SalariesSearch = new();
            StringBuilder PlaceSearch = new();
            StringBuilder CategoriesSearch = new();

            if (filter.FilterRequest != null)
            {
                if (filter.FilterRequest.Salary.Any())
                {
                    var count = filter.FilterRequest.Salary.Count;
                    for (int i = 0; i < count; i++)
                    {
                        if (i == count - 1)
                        {
                            SalariesSearch.Append("Salaries=*" + filter.FilterRequest.Salary[i] + "|");
                            break;
                        }
                        SalariesSearch.Append("Salaries=*" + filter.FilterRequest.Salary[i]);
                        query = query.ApplyFiltering(SalariesSearch.ToString());
                    }
                }

                if (filter.FilterRequest.Places.Any())
                {
                    var count = filter.FilterRequest.Places.Count;
                    for (int i = 0; i < count; i++)
                    {
                        if (i == count - 1)
                        {
                            PlaceSearch.Append("Place=" + filter.FilterRequest.Places[i] + "|");
                            break;
                        }
                        PlaceSearch.Append("Place=" + filter.FilterRequest.Places[i]);
                        query = query.ApplyFiltering(PlaceSearch.ToString());
                    }
                }

                if (filter.FilterRequest.Categories.Any())
                {
                    var count = filter.FilterRequest.Categories.Count;
                    for (int i = 0; i < count; i++)
                    {
                        if (i == count - 1)
                        {
                            PlaceSearch.Append("PostCategories=" + filter.FilterRequest.Categories[i] + "|");
                            break;
                        }
                        PlaceSearch.Append("PostCategories=" + filter.FilterRequest.Categories[i]);
                        query = query.ApplyFiltering(CategoriesSearch.ToString());
                    }
                }

                if (filter.FilterRequest.Participant.HasValue)
                {
                    query = query.Where(x => x.NumberPeople == filter.FilterRequest.Participant);
                }
            }

            var result = await query
               .OrderBy(filter._orderBy + " " + orderBy)
               .Skip((filter.PageNumber - 1) * filter.PageSize)
               .Take(filter.PageSize)
               .ToListAsync();

            var totalRecord = await query.CountAsync();



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
                    Message = BaseCode.EMPTY_MESSAGE,
                    Data = MapListDTO(result),
                    Pagination = pagination
                };
            }
            return response;
        }




        private List<ContractorPostDTO> MapListDTO(List<ContractorPost> list)
        {
            List<ContractorPostDTO> result = new();

            foreach (var item in list) {

                var user = _context.Users.Where(x => x.ContractorId == item.ContractorID).FirstOrDefault();


                ContractorPostDTO dto = new()
                {
                    Avatar = user.Avatar,
                    ContractorID = item.ContractorID,
                    Description = item.Description,
                    EndDate = item.EndDate,
                    Id = item.Id,
                    NumberPeople = item.NumberPeople,
                    Place = item.Place,
                    PostCategories = item.PostCategories,
                    ProjectName = item.ProjectName,
                    Salaries = item.Salaries,
                    StarDate = item.StarDate,
                    Title = item.Title,
                    ViewCount = item.ViewCount,
                };
                result.Add(dto);    
            
            }
            return result;
        }

    }
}
