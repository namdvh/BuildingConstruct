using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Commitment;
using ViewModels.ContractorPost;
using ViewModels.Pagination;
using ViewModels.Response;

namespace Application.System.Commitments
{
    public interface ICommitmentService
    {
        Task<BasePagination<List<CommitmentDTO>>> GetCommitment(Guid UserID,PaginationFilter filter);

        Task<BaseResponse<DetailCommitmentDTO>> GetDetailCommitment(int commitmenntID );

        Task<BaseResponse<string>> UpdateCommitment(Guid userID,int commitmenntID );

        Task<BaseResponse<string>> CreateCommitment(CreateCommimentRequest request,Guid ContractorID);

        Task<BaseResponse<DetailCommitmentDTO>> GetDetailForCreate(int postID, int builderID, Guid userID);
    }
}
 