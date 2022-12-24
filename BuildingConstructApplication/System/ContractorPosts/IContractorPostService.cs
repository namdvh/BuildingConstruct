using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.ContractorPost;
using ViewModels.Pagination;
using ViewModels.Response;

namespace Application.System.ContractorPosts
{
    public interface IContractorPostService
    {
        Task<BasePagination<List<ContractorPostDTO>>> GetPost(PaginationFilter filter);

        Task<BasePagination<List<ContractorPostDTO>>> GetPostByViews(PaginationFilter filter);

        Task<BasePagination<List<ContractorPostDTO>>> SearchPost(PaginationFilter filter, string keyword);
        Task<bool>CreateContractorPost(ContractorPostModels contractorPostDTO);
        Task<BaseResponse<ContractorPostDetailDTO>> GetDetailPost(int cPostid);
    }
}
