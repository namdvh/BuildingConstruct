using ViewModels.BuilderPosts;
using ViewModels.Pagination;
using ViewModels.Response;

namespace Application.System.BuilderPosts
{
    public interface IBuilderPostService
    {
        Task<BasePagination<List<BuilderPostDTO>>> GetPost(PaginationFilter filter,Guid id);

        Task<BasePagination<List<BuilderPostDTO>>> GetPostByViews(PaginationFilter filter);

        Task<BasePagination<List<BuilderPostDTO>>> SearchPost(PaginationFilter filter, string keyword);
        Task<bool> CreateBuilderPost(BuilderPostRequestDTO builderPostDTO);
        Task<BaseResponse<BuilderPostDetailDTO>> GetDetailPost(int bPostid);


    }
}