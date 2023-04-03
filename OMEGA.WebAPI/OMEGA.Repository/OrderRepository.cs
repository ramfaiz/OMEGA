using AutoMapper;
using OMEGA.Core.Models;
using OMEGA.DAL.DBContext;
using OMEGA.Core.Repositories;
using OMEGA.Core.Models.DTOs;
using static OMEGA.Core.Global.Constants;
using static OMEGA.Core.Global.Variables;
using OMEGA.DAL.Models.Entities;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace OMEGA.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OMEGADBContext _OMEGADBContext;
        private readonly IMapper _mapper;

        public OrderRepository(OMEGADBContext OMEGADBContext,
                IMapper mapper)
        {
            _OMEGADBContext = OMEGADBContext;

            _mapper = mapper;
        }
        
        public int GetOrders(DateTime FromDate, DateTime ToDate, APIResult apiResult)
		{
			int iReturn = API_SUCCESS;

			try
			{
				var dbListUnassigned = _OMEGADBContext.OmVwOrderlists.Where(x => x.DeleteStatus == 0 && x.OrderDate >= (FromDate) && x.OrderDate <= (ToDate)&& x.StatusId == 1)
                                                         .ToList();
                //.OrderByDescending(x => x.Displayorder)
                //.ToList();
                var dbListAssigned = _OMEGADBContext.OmVwOrderlists.Where(x => x.DeleteStatus == 0 && x.OrderDate >= (FromDate) && x.OrderDate <= (ToDate) && x.StatusId != 1)
                                                         .ToList();
                var dbListTotal = _OMEGADBContext.OmVwOrderlists.Where(x => x.DeleteStatus == 0 && x.OrderDate >= (FromDate) && x.OrderDate <= (ToDate)&& x.StatusId != 12)
                                                         .ToList();

                //var UnassignedOrders = ListOfOrders.FindAll(x => x.OrderDate >= (FromDate) && x.OrderDate <= (ToDate) && x.StatusId == 1 && x.StatusReasonId == 11);
                //var AssignedOrders = ListOfOrders.FindAll(x => x.OrderDate >= (FromDate) && x.OrderDate <= (ToDate) && x.StatusId != 1 && x.StatusId != 12);
                //var Total = ListOfOrders.FindAll(x => x.OrderDate >= (FromDate) && x.OrderDate <= (ToDate) && x.StatusId != 12);

                var UnassignedCount = dbListUnassigned.Count();
                var AssignedCount = dbListAssigned.Count();
                var TotalCount = dbListTotal.Count();

                Dashboard dashboard = new Dashboard();

                dashboard.AssignedCount = AssignedCount;
                dashboard.TotalCount = TotalCount;
                dashboard.UnassignedCount = UnassignedCount;

				apiResult.APIStatusMessage = "List of Orders retrieved successfully";

				apiResult.Result = JsonSerializer.Serialize(dashboard);
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

        public int GetOrderDetails(DateTime FromDate, DateTime ToDate,int type, APIResult apiResult)
        {
            int iReturn = API_SUCCESS;

            try
            {
                
                if(type == 1)
                {
                    var orderdetails = _OMEGADBContext.OmVwOrderlists.Where(x => x.DeleteStatus == 0 && x.OrderDate >= FromDate && x.OrderDate <= ToDate && x.StatusId == 1 && x.StatusReasonId == 11)
                        //.Select(p => new { p.OrderId, p.OrderDate, p.SubjectAddress, p.FullName, p.Subclient, p.PortalName, p.Ordertypename, p.StatusDesc, p.StatusReasonDesc, p.PhotoReqStatusDesc }).ToList();
                        .Select(x => new {
                            x.OrderId, 
                            x.OrderDate, 
                            x.SubjectAddress, 
                            x.FullName, 
                            x.PortalName, 
                            x.Ordertypename, 
                            x.StatusDesc, 
                            x.StatusReasonDesc, 
                            x.PhotoReqStatusDesc,
                            x.Subclient
                        }).ToList();

                    //var ResultList = _mapper.Map<OmVwOrderlist>(orderdetails);

                    apiResult.APIStatusMessage = "List of Orders retrieved successfully";

                    apiResult.Result = JsonSerializer.Serialize(orderdetails);
                }
                else if (type == 2)
                {
                    var orderdetails = _OMEGADBContext.OmVwOrderlists.Where(x => x.DeleteStatus == 0 && x.OrderDate >= FromDate && x.OrderDate <= ToDate && x.StatusId != 1 && x.StatusId != 12)
                          .Select(x => new {
                              x.OrderId,
                              x.OrderDate,
                              x.SubjectAddress,
                              x.FullName,
                              x.PortalName,
                              x.Ordertypename,
                              x.StatusDesc,
                              x.StatusReasonDesc,
                              x.PhotoReqStatusDesc,
                              x.Subclient
                          })
                           .ToList();

                    //var ResultList = _mapper.Map<List<OrderDetails>>(orderdetails);

                    apiResult.APIStatusMessage = "List of Orders retrieved successfully";

                    apiResult.Result = JsonSerializer.Serialize(orderdetails);
                }
                if (type == 3)
                {
                    var orderdetails = _OMEGADBContext.OmVwOrderlists.Where(x => x.DeleteStatus == 0 && x.OrderDate >= FromDate && x.OrderDate <= ToDate && x.StatusId != 12)

                         .Select(x => new {
                             x.OrderId,
                             x.OrderDate,
                             x.SubjectAddress,
                             x.FullName,
                             x.PortalName,
                             x.Ordertypename,
                             x.StatusDesc,
                             x.StatusReasonDesc,
                             x.PhotoReqStatusDesc,
                             x.Subclient
                         })
                                                         .ToList();

                    //var ResultList = _mapper.Map<List<OrderDetails>>(orderdetails);

                    apiResult.APIStatusMessage = "List of Orders retrieved successfully";

                    apiResult.Result = JsonSerializer.Serialize(orderdetails);
                }


                //.OrderByDescending(x => x.Displayorder)
                //.ToList();

                
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
