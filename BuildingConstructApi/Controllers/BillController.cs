using Application.System.Bill;
using Data.Enum;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> CreateBill([FromBody] List<BillDTO> request)
        {
            BaseResponse<List<BillDTO>> response = new();
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

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetBillDetail([FromRoute] int id)
        //{
        //    var rs = await _billServices.GetDetail(id);

        //    return Ok(rs);
        //}

        [HttpGet("small/{id}")]
        public async Task<IActionResult> GetSmallBill([FromRoute] int id)
        {
            var rs = await _billServices.GetDetailBySmallBill(id);

            return Ok(rs);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBillStatus([FromRoute] int id, Status status)
        {
            var rs = await _billServices.UpdateStatusBill(status, id);

            return Ok(rs);
        }


        [HttpGet("history")]
        public async Task<IActionResult> GetHistoryProductBill([FromQuery] PaginationFilter request)
        {
            var userID = User.FindFirst("UserID").Value;
            var validFilter = new PaginationFilter();


            if (userID == null)
            {
                return BadRequest();
            }

            if (request.FilterRequest == null)
            {
                validFilter = new PaginationFilter(request.PageNumber, request.PageSize, request._sortBy, request._orderBy);
            }
            else
            {
                validFilter = new PaginationFilter(request.PageNumber, request.PageSize, request._sortBy, request._orderBy, request.FilterRequest);

            }


            var rs = await _billServices.GetHistoryProductBill(Guid.Parse(userID), validFilter);

            return Ok(rs);
        }

    }
}
