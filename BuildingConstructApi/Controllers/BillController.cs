using Application.System.Bill;
using Data.Enum;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using ViewModels.BillModels;
using ViewModels.Pagination;
using ViewModels.Response;

namespace BuildingConstructApi.Controllers
{
    [Route("api/billController")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
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
        [HttpPost("getAll")]
        public async Task<IActionResult> GetAllBill([FromQuery] PaginationFilter request)
        {
            var validFilter = new PaginationFilter();

            if (request.FilterRequest == null)
            {
                validFilter = new PaginationFilter(request.PageNumber, request.PageSize, request._sortBy, request._orderBy);
            }
            else
            {
                validFilter = new PaginationFilter(request.PageNumber, request.PageSize, request._sortBy, request._orderBy, request.FilterRequest);

            }

            var result = await _billServices.GetAllBill(request);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBillDetail([FromRoute] int id)
        {
            var rs = await _billServices.GetDetail(id);

            return Ok(rs);
        }
    }
}
