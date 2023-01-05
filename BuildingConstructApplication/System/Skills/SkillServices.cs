using Data.DataContext;
using Data.Entities;
using Data.Enum;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using ViewModels.Pagination;

namespace Application.System.Skills
{
    public class SkillServices : ISkillService
    {
        private readonly BuildingConstructDbContext _context;

        public SkillServices(BuildingConstructDbContext context)
        {
            _context = context;
        }

        public async Task<BasePagination<List<Skill>>> GetAll(PaginationFilter filter)
        {
            BasePagination<List<Skill>> response;
            var orderBy = filter._orderBy.ToString();
            int totalRecord;
            orderBy = orderBy switch
            {
                "1" => "ascending",
                "-1" => "descending",
                _ => orderBy
            };

            if (string.IsNullOrEmpty(filter._sortBy))
            {
                filter._sortBy = "Id";
            }

            var result = await _context.Skills
                .AsNoTracking()
                     .Where(x => x.FromSystem == true)
                     .OrderBy(filter._sortBy + " " + orderBy)
                     .Skip((filter.PageNumber - 1) * filter.PageSize)
                     .Take(filter.PageSize)
                     .ToListAsync();


         
                totalRecord = await _context.Skills.Where(x=>x.FromSystem==true).CountAsync();

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
                    Data = result,
                    Pagination = pagination
                };
            }
            return response;
        }

    }
}
