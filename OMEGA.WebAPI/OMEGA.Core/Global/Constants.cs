using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMEGA.Core.Global
{
    public static class Constants
    {
        public const int API_SUCCESS = 0;

        public const int API_ITEM_NOT_FOUND = 1;

        public const int API_FAILED = 2;

        public const int API_EXCEPTION = 3;

        public const int HTTP_REQUEST_STATUS_OK = 200;

        public static readonly string URL_FamilyID_BASE_URL = "https://localhost:5001/";

        public static readonly string URL_FamilyID_GET_CUSTOMER_LIST = "api/Customer/list";

        public static readonly string URL_FamilyID_ADD_CUSTOMER = "api/Customer/addcustomer";

        public static readonly string URL_FamilyID_UPDATE_CUSTOMER = "api/Customer/updatecustomer?id=";

        public static readonly string URL_FamilyID_DELETE_CUSTOMER = "api/Customer/delete/";
    }
}
