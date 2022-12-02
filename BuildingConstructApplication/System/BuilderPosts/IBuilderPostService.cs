using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.BuilderPosts;
using ViewModels.ContractorPost;
using ViewModels.Pagination;

namespace Application.System.BuilderPosts
{
    public interface IBuilderPostService
    {
        Task<BasePagination<List<BuilderPostDTO>>> GetPost(PaginationFilter filter);

        Task<BasePagination<List<BuilderPostDTO>>> SearchPost(PaginationFilter filter, string keyword);
    }
}
