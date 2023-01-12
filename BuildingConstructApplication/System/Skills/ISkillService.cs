using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.ContractorPost;
using ViewModels.Pagination;

namespace Application.System.Skills
{
    public interface ISkillService
    {
        Task<BasePagination<List<Skill>>> GetAll(PaginationFilter filter);
    }
}
