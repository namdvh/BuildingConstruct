using ViewModels.MaterialStore;
using ViewModels.Pagination;
using ViewModels.Response;

namespace Application.System.MaterialStores
{
    public interface IMaterialStoreService
    {
        Task<BasePagination<List<ViewModels.MaterialStore.MaterialStoreDTO>>> GetList(PaginationFilter filter);

        Task<BasePagination<List<ViewModels.MaterialStore.MaterialStoreDTO>>> Search(PaginationFilter filter, string keyword);
        Task<bool> CreateProduct(ProductDTO request);
        Task<BasePagination<List<ProductStoreDTO>>> GetAllProductStore(PaginationFilter filter);
        Task<BaseResponse<ProductDetailDTO>> GetProductDetail(int productId);


    }
}
