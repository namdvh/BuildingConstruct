using ViewModels.BuilderPosts;
using ViewModels.Pagination;

namespace Application.System.BuilderPosts
{
    public interface IBuilderPostService
    {
        Task<BasePagination<List<BuilderPostDTO>>> GetPost(PaginationFilter filter);

        Task<BasePagination<List<BuilderPostDTO>>> SearchPost(PaginationFilter filter, string keyword);
    }
}