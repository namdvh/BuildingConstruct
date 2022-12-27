using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.ContractorPost;
using ViewModels.Pagination;
using ViewModels.ProductSystems;
using ViewModels.Response;

namespace Application.System.ProductSystems
{
    public interface IProductSystemService
    {
        Task<BasePagination<List<ProductSystemDTO>>> GetAllProducSystems(PaginationFilter filter);
        Task<bool> CreateProductSystems(ProductSystemDTO request);

    }
}
