using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.ContractorPost;
using ViewModels.Pagination;
using ViewModels.Response;

namespace Application.System.ProductSystem
{
    public interface IProductSystemService
    {
        Task<BasePagination<List<ContractorPostProductDTO>>> GetAllProducSystems(PaginationFilter filter);
    }
}
