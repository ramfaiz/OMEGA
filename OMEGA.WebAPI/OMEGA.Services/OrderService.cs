using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using OMEGA.Core.Services;
using OMEGA.Core.Repositories;
using static OMEGA.Core.Global.Constants;
using static OMEGA.Core.Global.Variables;
using OMEGA.Core.Models;
using OMEGA.Core.Model.DTOs;
using OMEGA.Core.Models.DTOs;

namespace OMEGA.Services
{
    public class OrderService: IOrderService
    {
        private readonly IOrderRepository _repo;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository repo,
                           IMapper mapper)
        {
            _repo = repo;

            _mapper = mapper;
        }
        public int ListOrderCount(DateTime FromDate,DateTime ToDate, APIResult apiResult)
        {
            int iReturn = API_SUCCESS;

            try
            {
                iReturn = _repo.GetOrders(FromDate, ToDate,apiResult);

                if (iReturn == API_SUCCESS)
                {
                    var ListOfOrders = JsonSerializer.Deserialize<Dashboard>(apiResult.Result);
                    //var OrderDate = "2022-01-01";
                    //var UnassignedOrders = ListOfOrders.FindAll(x => x.OrderDate >= (FromDate) && x.OrderDate<=(ToDate) && x.StatusId == 1 && x.StatusReasonId == 11);
                    //var AssignedOrders = ListOfOrders.FindAll(x => x.OrderDate >=(FromDate) && x.OrderDate<=(ToDate) && x.StatusId != 1 && x.StatusId != 12);
                    //var Total = ListOfOrders.FindAll(x => x.OrderDate>=(FromDate)&& x.OrderDate<=(ToDate) && x.StatusId !=12);
                    
                    //var UnassignedCount = UnassignedOrders.Count();
                    //var AssignedCount=AssignedOrders.Count();
                    //var TotalCount = Total.Count();


                    //Dashboard dashboard = new Dashboard();

                    //dashboard.AssignedCount = AssignedCount;
                    //dashboard.TotalCount = TotalCount;
                    //dashboard.UnassignedCount = UnassignedCount;

                    apiResult.APIStatusMessage = "List of Counts Retrieved Successfully";

                    apiResult.Result = JsonSerializer.Serialize(ListOfOrders);
                }


            }
            catch (Exception ex)
            {
                iReturn = API_FAILED;

                apiResult.Reset();

                apiResult.APIStatusMessage = ex.Message;

                apiResult.APIStatus = (int)Core.Enums.APIStatus.Exception;

                log.Error($"Exception caught. Exception: {ex.Message}");

                if (ex.InnerException != null)
                {
                    log.Error($"Details: {ex.InnerException.Message}");
                }
            }

            return iReturn;
        }

        public int ListOrderDetails(DateTime FromDate, DateTime ToDate, int type, APIResult apiResult)
        {
            int iReturn = API_SUCCESS;

            try
            {
                iReturn = _repo.GetOrderDetails(FromDate, ToDate, type, apiResult);

                if (iReturn == API_SUCCESS)
                {
                    var TypeWiseOrderDetails = JsonSerializer.Deserialize<List<OrderDetails>>(apiResult.Result);

                    apiResult.APIStatusMessage = "Order Retrieved Successfully ";

                    apiResult.Result = JsonSerializer.Serialize(TypeWiseOrderDetails);
                }


            }
            catch (Exception ex)
            {
                iReturn = API_FAILED;

                apiResult.Reset();

                apiResult.APIStatusMessage = ex.Message;

                apiResult.APIStatus = (int)Core.Enums.APIStatus.Exception;

                log.Error($"Exception caught. Exception: {ex.Message}");

                if (ex.InnerException != null)
                {
                    log.Error($"Details: {ex.InnerException.Message}");
                }
            }

            return iReturn;
        }




    }
}
