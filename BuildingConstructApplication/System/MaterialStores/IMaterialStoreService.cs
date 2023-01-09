using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.ContractorPost;
using ViewModels.MaterialStore;
using ViewModels.Pagination;
using ViewModels.Response;

namespace Application.System.MaterialStores
{
    public interface IMaterialStoreService
    {
        Task<BasePagination<List<MaterialStoreDTO>>> GetList(PaginationFilter filter);

        Task<BasePagination<List<MaterialStoreDTO>>> Search(PaginationFilter filter, string keyword);
        Task<bool> CreateProduct(ProductDTO request);
    }
}
