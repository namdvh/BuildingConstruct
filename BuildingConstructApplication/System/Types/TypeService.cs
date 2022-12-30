using Data.DataContext;
using Data.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.ContractorPost;
using ViewModels.Response;

namespace Application.System.Types
{
    public class TypeService : ITypeService
    {
        private readonly BuildingConstructDbContext _context;
        private IHttpContextAccessor _accessor;
        public TypeService(BuildingConstructDbContext context, IHttpContextAccessor accessor)
        {
            _context = context;
            _accessor = accessor;
        }
        public async Task<BaseResponse<List<TypeModels>>> GetAllTypeAndSkills()
        {
            BaseResponse<List<TypeModels>> response = new();
            response.Data = new();
            var lType = new List<TypeModels>();
            var rs =await _context.Types.Include(x=>x.Skill).ToListAsync();
            if (rs!=null)
            {
                response.Code = BaseCode.SUCCESS;
                response.Message = BaseCode.SUCCESS_MESSAGE;
                foreach(var item in rs)
                {
                    var type = new TypeModels();
                    type.id = item.Id;
                    type.name = item.Name;
                    var lSkillArr = new List<SkillArr>();
                    foreach (var i in item.Skill)
                    {
                        var skill = new SkillArr();
                        skill.id = i.Id;
                        skill.name = i.Name;
                        skill.fromSystem = i.FromSystem;
                        skill.TypeId = i.TypeId;
                        lSkillArr.Add(skill);
                    }
                    lType.Add(type);
                    type.SkillArr = lSkillArr;
                }
                response.Data = lType;

                return response;
            }
            response.Code = BaseCode.ERROR;
            response.Message = BaseCode.ERROR_MESSAGE;
            return response;
        }
    }
}
