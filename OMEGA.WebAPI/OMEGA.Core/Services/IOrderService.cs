using OMEGA.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMEGA.Core.Services
{
    public interface IOrderService
    {
        public int ListOrderCount(DateTime FromDate, DateTime ToDate, APIResult apiResult);
        public int ListOrderDetails(DateTime FromDate, DateTime ToDate, int type, APIResult apiResult);
    }
}
