using OMEGA.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMEGA.Core.Repositories
{
    public interface IOrderRepository
    {
        public int GetOrders(DateTime FromDate, DateTime ToDate, APIResult apiResult);

        public int GetOrderDetails(DateTime FromDate, DateTime ToDate, int type, APIResult apiResult);
    }
}
