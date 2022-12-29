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
using Data.Enum;
using ViewModels.ProductSystems;

namespace Application.System.ProductSystems
{
    public class ProductSystemService : IProductSystemService
    {
        private readonly BuildingConstructDbContext _context;

        public ProductSystemService(BuildingConstructDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateProductSystems(ProductSystemDTO request)
        {
            ProductSystem pSystem = new();
            ProductSystemCategories productSystemCategories = new ProductSystemCategories();
            pSystem.Name = request.Name;
            pSystem.Description = request.Description;
            pSystem.FromSystem = request.FromSystem;
            pSystem.Image = request.Image;
            pSystem.Brand = request.Brand;
            pSystem.Description = request.Description;
            foreach(var item in request.ProductSystemCategories)
            {
                productSystemCategories.CategoriesID = item.ProductSystemID;
                productSystemCategories.ProductSystemID = item.ProductSystemID;
            }
            await _context.AddAsync(pSystem);
            var rs=await _context.SaveChangesAsync();
            if (rs > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<BasePagination<List<ProductSystemDTO>>> GetAllProducSystems(PaginationFilter filter)
        {
            BasePagination<List<ProductSystemDTO>> response;
            var orderBy = filter._orderBy.ToString();
            int totalRecord;
            orderBy = orderBy switch
            {
                "1" => "ascending",
                "-1" => "descending",
                _ => orderBy
            };

            IQueryable<ProductSystem> query = _context.ProductSystems;
            StringBuilder placeSearch = new();
            StringBuilder categoriesSearch = new();

            var data = await query
                .Include(x => x.ProductSystemCategories).ThenInclude(x=>x.Categories)
                .AsNoTracking()
                .Where(x => x.FromSystem == true)
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
                    Data = new List<ProductSystemDTO>(),
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
                    Data = MapListDTO(data),
                    Pagination = pagination
                };
            }

            return response;
        }
        public List<ProductSystemDTO> MapListDTO(List<ProductSystem> list)
        {
            List<ProductSystemDTO> result = new();

            foreach (var item in list)
            {
                ProductSystemDTO dto = new();
                dto.Id = item.Id;
                dto.Name = item.Name;
                dto.Description = item.Description;
                dto.FromSystem = item.FromSystem;
                dto.Brand = item.Brand;
                dto.Image = item.Image;
                dto.Categories = new();
                foreach(var i in item.ProductSystemCategories)
                {
                    dto.Categories.Add(i.Categories);
                }
                result.Add(dto);
            }
            return result;
        }
        public List<ProducSystemCategoriesDTO> MapListDTO(List<Data.Entities.ProductSystemCategories> list)
        {
            List<ProducSystemCategoriesDTO> result = new();

            foreach (var item in list)
            {
                ProducSystemCategoriesDTO dto = new();
                dto.CategoriesID = item.CategoriesID;
                dto.ProductSystemID = item.ProductSystemID;
                result.Add(dto);
            }
            return result;
        }
    }
}
