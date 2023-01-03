using Data.DataContext;
using Data.Enum;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Categories;
using ViewModels.Response;

namespace Application.System.Category
{
    public class CategoryService : ICategoryService
    {
        private readonly BuildingConstructDbContext _context;

        public CategoryService(BuildingConstructDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateCategory(CategoryDTO request)
        {
            var category = new Data.Entities.Categories();
            category.Name= request.Name;
            category.Type = request.Type;
            await _context.Categories.AddAsync(category);
            var rs =await _context.SaveChangesAsync();
            if (rs>0)
            {
                return true;
            }
            return false;
        }

        public async Task<BaseResponse<CategoryDTO>> GetCateByID(int cateID)
        {
            var response = new BaseResponse<CategoryDTO>();
            var rs = await _context.Categories.Where(x => x.ID == cateID).SingleOrDefaultAsync();
            if (rs != null)
            {
                response.Code = BaseCode.SUCCESS;
                response.Message = BaseCode.SUCCESS_MESSAGE;
                response.Data.Id = rs.ID;
                response.Data.Name = rs.Name;
                response.Data.Type = rs.Type;
            }
            else
            {
                response.Code = BaseCode.ERROR;
                response.Message = BaseCode.ERROR_MESSAGE;
                response.Data = null;
            }
            return response;
        }
    }
}
