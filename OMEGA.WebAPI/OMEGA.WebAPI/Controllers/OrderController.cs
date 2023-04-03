using log4net;
using Microsoft.AspNetCore.Mvc;
using OMEGA.Core.Models;
using OMEGA.Core.Services;
using static OMEGA.Core.Global.Variables;
using static OMEGA.Core.Global.Constants;
using static OMEGA.Core.Global.Functions;
using System.Text.Json;
using System.Collections.Generic;
using OMEGA.Services;
using OMEGA.Core.Models.DTOs;
using Microsoft.AspNetCore.Authorization;
using OMEGA.DAL.Models.Entities;

namespace OMEGA.WebAPI.Controllers
{
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _OrderService;

        private APIResult apiResult = new APIResult();

        public OrderController(IOrderService OrderService)
        {
            _OrderService = OrderService;
        }

        [HttpPost("listordercounts")]
        [Authorize]
        public IActionResult GetOrderCounts(DateTime FromDate, DateTime ToDate)
            {

            LogRequest(Request);

            try
            {
                //List<QuizQuestionWithCategoryNameDTO> QuestionDTOs = null;

                int iRC = _OrderService.ListOrderCount(FromDate, ToDate, apiResult);

                if (iRC != API_SUCCESS)
                {
                    return BadRequest(apiResult);
                }

                Dashboard Order = new Dashboard();

                Order = JsonSerializer.Deserialize<Dashboard>(apiResult.Result);
                return Ok(Order);
            }
            catch (System.Exception ex)
            {
                apiResult.APIStatusMessage = ex.Message;

                apiResult.APIStatus = (int)Core.Enums.APIStatus.Exception;

                log.Error($"Exception caught. Exception: {ex.Message}");

                if (ex.InnerException != null)
                {
                    log.Error($"Details: {ex.InnerException.Message}");

                    apiResult.APIStatusMessage = apiResult.APIStatusMessage + "\r\n" + ex.InnerException.Message;
                }

                return BadRequest(apiResult);
            }
        }
        [HttpPost("listorderdetails")]
        [Authorize]
        public IActionResult GetOrderDetails(DateTime FromDate, DateTime ToDate,int type)
        {

            LogRequest(Request);

            try
            {
                //List<QuizQuestionWithCategoryNameDTO> QuestionDTOs = null;

                int iRC = _OrderService.ListOrderDetails(FromDate, ToDate, type, apiResult);

                if (iRC != API_SUCCESS)
                {
                    return BadRequest(apiResult);
                }

                //List<OmVwOrderlist> orderlist = new List<OmVwOrderlist>();

                //orderlist = JsonSerializer.Deserialize<List<OmVwOrderlist>>(apiResult.Result);

                List<OrderDetails> orderlist = new List<OrderDetails>();

                orderlist = JsonSerializer.Deserialize<List<OrderDetails>>(apiResult.Result);
                return Ok(orderlist);
            }
            catch (System.Exception ex)
            {
                apiResult.APIStatusMessage = ex.Message;

                apiResult.APIStatus = (int)Core.Enums.APIStatus.Exception;

                log.Error($"Exception caught. Exception: {ex.Message}");

                if (ex.InnerException != null)
                {
                    log.Error($"Details: {ex.InnerException.Message}");

                    apiResult.APIStatusMessage = apiResult.APIStatusMessage + "\r\n" + ex.InnerException.Message;
                }

                return BadRequest(apiResult);
            }
        }

    }
}
