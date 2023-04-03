using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OMEGADashBoard.Models
{
    public class OrderDetails
    {
        public long OrderId { get; set; }
        public string FullName { get; set; }
        public DateTime OrderDate { get; set; }
        public short? StatusId { get; set; }
        public short? StatusReasonId { get; set; }

        public string StatusReasonDesc { get; set;}
        public string StatusDesc { get; set; }
        public string Ordertypename { get; set; }
        public string Subjectaddress { get; set; }
        public string PhotoReqStatusDesc { get; set;}
        public string Portalname { get; set; }
        public string Subclient { get; set;}

    }
}