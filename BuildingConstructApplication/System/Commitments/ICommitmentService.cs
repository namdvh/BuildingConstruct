using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Commitment;
using ViewModels.ContractorPost;
using ViewModels.Pagination;

namespace Application.System.Commitments
{
    public interface ICommitmentService
    {
        Task<BasePagination<List<CommitmentDTO>>> GetCommitment(Guid UserID,PaginationFilter filter);

        Task<BasePagination<List<DetailCommitmentDTO>>> GetDetailCommitment(int commitmenntID );
    }
}
