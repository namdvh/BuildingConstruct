using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.BillModels;
using ViewModels.Response;

namespace Application.System.Bill
{
    public interface IBillServices
    {
        Task<bool> CreateBill(BillDTO requests);

        Task<BaseResponse<BillDetailDTO>> GetDetail(int billID);

    }
}
