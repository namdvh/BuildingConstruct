﻿using Application.System.Notifies;
using Application.System.Payments;
using BuildingConstructApi.Hubs;
using Data.DataContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using ViewModels.Pagination;

namespace BuildingConstructApi.Controllers
{
    [Route("api/payment")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = "Bearer")]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentsService _paymentService;
        private readonly IHubContext<NotificationUserHub> _notificationUserHubContext;
        private readonly IUserConnectionManager _userConnectionManager;
        private readonly BuildingConstructDbContext _context;

        public PaymentController(IPaymentsService paymentService, IHubContext<NotificationUserHub> notificationUserHubContext, IUserConnectionManager userConnectionManager, BuildingConstructDbContext context)
        {
            _paymentService = paymentService;
            _notificationUserHubContext = notificationUserHubContext;
            _userConnectionManager = userConnectionManager;
            _context = context;
        }
        [HttpPost("checkRefund")]
        public async Task<IActionResult> CheckPayment() {
            var result = await _paymentService.CheckRefundPayment();
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> PaymentList()
        {
            var result = await _paymentService.PaymentList();
            return Ok(result);
        }
        [HttpPost("UpdateRefund")]
        public async Task<IActionResult> UpdateRefund()
        {
            var result = await _paymentService.UpdateIsRefund();
            return Ok(result);
        }
        [HttpGet("getTop5Payment")]
        public async Task<IActionResult> GetTop5Payment()
        {
            var result = await _paymentService.GetTop5PaymentContractor();
            return Ok(result);
        }
    }
}
