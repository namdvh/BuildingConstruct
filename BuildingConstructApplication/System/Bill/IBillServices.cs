using Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.BillModels;
using ViewModels.Pagination;
using ViewModels.Response;

namespace Application.System.Bill
{
    public interface IBillServices
    {
        Task<bool> CreateBill(List<BillDTO> requests);
        Task<BasePagination<List<BillDTO>>> GetAllBill(PaginationFilter filter);

        Task<BaseResponse<BillDetailDTO>> GetDetail(int billID);

        Task<BaseResponse<SmallBillDetailDTO>> GetDetailBySmallBill(int billID);

        Task<BaseResponse<string>> UpdateStatusBill(Status status, int billID);
    }
}
