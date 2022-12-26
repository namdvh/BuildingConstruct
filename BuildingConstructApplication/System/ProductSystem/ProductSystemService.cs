using Data.DataContext;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.ContractorPost;
using System.Linq.Dynamic.Core;
using ViewModels.Pagination;
using Gridify;
using Microsoft.EntityFrameworkCore;

namespace Application.System.ProductSystem
{
    public class ProductSystemService : IProductSystemService
    {
        private readonly BuildingConstructDbContext _context;

        public ProductSystemService(BuildingConstructDbContext context)
        {
            _context = context;
        }

        public async Task<BasePagination<List<ContractorPostProductDTO>>> GetAllProducSystems(PaginationFilter filter)
        {
            BasePagination<List<ContractorPostProductDTO>> response;
            var orderBy = filter._orderBy.ToString();
            int totalRecord;
            orderBy = orderBy switch
            {
                "1" => "ascending",
                "-1" => "descending",
                _ => orderBy
            };

            IQueryable<Data.Entities.ProductSystem> query = _context.ProductSystems;
            StringBuilder placeSearch = new();
            StringBuilder categoriesSearch = new();
         
            var result = await query
                .Where(x=>x.FromSystem==true)
               .OrderBy(filter._sortBy + " " + orderBy)
               .Skip((filter.PageNumber - 1) * filter.PageSize)
               .Take(filter.PageSize)
               .ToListAsync();
        }
    }
}
