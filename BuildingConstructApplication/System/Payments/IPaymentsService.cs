using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Pagination;
using ViewModels.Payment;
using ViewModels.Response;
using ViewModels.Users;

namespace Application.System.Payments
{
    public interface IPaymentsService
    {
        Task<BaseResponse<RefundDTO>> CheckRefundPayment();
        Task<BaseResponse<bool>> UpdateIsRefund();
        Task<BasePagination<List<PaymentDTO>>> PaymentList();
        Task<BasePagination<List<UserPaymentDTO>>>GetTop5PaymentContractor();
        Task<BasePagination<List<UserPaymentDTO>>> GetTop5PaymentStore();

    }
}
