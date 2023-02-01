using Application.System.Bill;
using Data.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewModels.BillModels;
using ViewModels.Response;

namespace BuildingConstructApi.Controllers
{
    [Route("api/billController")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private readonly IBillServices _billServices;

        public BillController(IBillServices billServices)
        {
            _billServices = billServices;
        }
        [HttpPost("createBill")]
        public async Task<IActionResult> CreateBill([FromBody] BillDTO request)
        {
            BaseResponse<BillDTO> response = new();
            var rs = await _billServices.CreateBill(request);
            if (rs)
            {
                response.Code = BaseCode.SUCCESS;
                response.Message = "Create Bill success";
                response.Data = request;
            }
            else
            {
                response.Code = BaseCode.ERROR;
                response.Message = "Create Bill fail";
            }
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBillDetail([FromRoute] int id )
        {
            var rs = await _billServices.GetDetail(id);

            return Ok(rs);
        }
    }
}
