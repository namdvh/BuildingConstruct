using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.ContractorPost;
using ViewModels.Response;

namespace Application.System.Types
{
    public interface ITypeService
    { 
        Task<BaseResponse<List<TypeModels>>> GetAllTypeAndSkills();
    }
}
