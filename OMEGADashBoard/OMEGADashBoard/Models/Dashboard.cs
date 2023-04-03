using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OMEGADashBoard.Models
{
    public class Dashboard
    {
        public Int64 UnassignedCount { get; set; }

        public Int64 TotalCount { get; set; }

        public Int64 AssignedCount { get; set; }
    }
}