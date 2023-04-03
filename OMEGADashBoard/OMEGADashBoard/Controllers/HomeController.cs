using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using static OMEGADashBoard.Controllers.HomeController;
using static System.Net.WebRequestMethods;

using OMEGADashBoard.Models;

namespace OMEGADashBoard.Controllers
{
    public class HomeController : Controller
    {
        string accessToken = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiRUNFU0lTL1RWTS9IUi8wMDQiLCJJRCI6IjMxZDFhNzI4LTNjOGItNGFiYi1hNzk1LTU0NGRjNDUxMTM0OCIsIkVtYWlsIjoiZWNlc2lzZGV2ZWxvcGVyc3RlYW1AZ21haWwuY29tIiwiZXhwIjoxNjc3NzM3NjEzLCJpc3MiOiJPTUVHQSIsImF1ZCI6Ik9NRUdBVXNlcnMifQ.CgW8VJk4748P6vkfy7eLnjEMPnJ7bVuH-qahgQ7oKR0";
        public class Orders
        {
            public string UnassignedCount { get; set; }
            public string AssignedCount { get; set; }
            public string Total { get; set; }
            
        }

        public class APIResult
        {
            public int APIStatus { get; set; }
            public string APIStatusMessage { get; set; }
            public string Result { get; set; }

            public string Token { get; set; }
            
        }

        public ActionResult Index()
        {

            DateTime FromDate = DateTime.Today, ToDate=DateTime.Today;



            if (Session["FromDate"] != null)
            {
                FromDate = new DateTime(FromDate.Year, FromDate.Month, FromDate.Day, 0, 0, 0, 0);

                ToDate = new DateTime(ToDate.Year, ToDate.Month, ToDate.Day, 23, 59, 59, 999);

                Session["FromDate"] = FromDate;
                Session["ToDate"] = ToDate;
            }
            else
            {
                FromDate = Convert.ToDateTime(Session["FromDate"]);
                ToDate = Convert.ToDateTime(Session["ToDate"]);
            }


            Task<string> s1 = Get( FromDate,ToDate);

            Dashboard dashboard = new Dashboard();

            dashboard.UnassignedCount = ViewBag.DashboardCount.UnassignedCount;
            dashboard.AssignedCount = ViewBag.DashboardCount.AssignedCount;
            dashboard.TotalCount = ViewBag.DashboardCount.TotalCount;


            Session["UnassignedCount"]= ViewBag.DashboardCount.UnassignedCount;
            Session["AssignedCount"]= ViewBag.DashboardCount.AssignedCount;
            Session["TotalCount"]= ViewBag.DashboardCount.TotalCount;

            return View(dashboard);
        }

        

        public  async Task<string> Get(DateTime FromDate, DateTime ToDate)
        {
            var stringContent = new StringContent("{ \"FromDate\": \"2022-01-01\", \"ToDate\": \"2023-01-01\" }", System.Text.Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
               
                try
                {
                   
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);
                    //var response = await client.PostAsync(url, stringContent);
                    var task = client.PostAsync(new Uri("http://localhost:5181/listordercounts?FromDate=" + FromDate + "&ToDate=" + ToDate), stringContent);
                    var request = task.GetAwaiter().GetResult();

                    var result = await request.Content.ReadAsStringAsync();

                    Dashboard order = JsonConvert.DeserializeObject<Dashboard>(result);

                    ViewBag.DashboardCount = order;
                }
                catch (Exception ex)
                {

                }
                //var url = "http://localhost:5181/listordercounts?FromDate=2022-01-01&ToDate=2023-01-01";

                //string accessToken = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiRUNFU0lTL1RWTS9IUi8wMDQiLCJJRCI6ImVjNTUzN2FlLTA3YWEtNDNhOC05NTRiLTQzMGY0NWNiZGY3MyIsIkVtYWlsIjoiZWNlc2lzZGV2ZWxvcGVyc3RlYW1AZ21haWwuY29tIiwiZXhwIjoxNjc2NjE2NTgwLCJpc3MiOiJPTUVHQSIsImF1ZCI6Ik9NRUdBVXNlcnMifQ.45FR5-5HkNFiqkbBAv_zzZFcyZZ1lo-Vhj3JQlKlec0";

                //client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);

                //var response = client.PostAsync("http://localhost:5181/listordercounts", stringContent);

                var myName = "gf";

                return myName;
            }
        }




        [HttpPost]
        public async Task<ActionResult> Index(DateTime FromDate, DateTime ToDate , int Type,int FormType)
        {
            Dashboard dashboard = new Dashboard();

            if (FormType == 1)
            {


                FromDate = new DateTime(FromDate.Year, FromDate.Month, FromDate.Day, 0, 0, 0, 0);

                ToDate = new DateTime(ToDate.Year, ToDate.Month, ToDate.Day, 23, 59, 59, 999);

                Session["FromDate"] = FromDate;

                Session["ToDate"] = ToDate;

                Task<string> s1 = Get(FromDate, ToDate);

                

                dashboard.UnassignedCount = ViewBag.DashboardCount.UnassignedCount;
                dashboard.AssignedCount = ViewBag.DashboardCount.AssignedCount;
                dashboard.TotalCount = ViewBag.DashboardCount.TotalCount;


                Session["UnassignedCount"] = ViewBag.DashboardCount.UnassignedCount;
                Session["AssignedCount"] = ViewBag.DashboardCount.AssignedCount;
                Session["TotalCount"] = ViewBag.DashboardCount.TotalCount;
            }
            else if (FormType == 2)
            {
                 FromDate = Convert.ToDateTime(Session["FromDate"]);
                ToDate = Convert.ToDateTime(Session["ToDate"]);

                var stringContent = new StringContent("{ \"FromDate\": \"2022-01-01\", \"ToDate\": \"2023-01-01\" }", System.Text.Encoding.UTF8, "application/json");
                //var stringContent = new StringContent("FromDate:" + FromDate, "ToDate:" + ToDate, "Type:" + Type);
                //string url = "http://localhost:5181/listorderdetails?FromDate=2022-01-01&ToDate=2023-01-01&type=1";

                using (var client = new HttpClient())
                {
                    try
                    {


                        client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);

                        var task = client.PostAsync(new Uri("http://localhost:5181/listorderdetails?FromDate=" + FromDate + "&ToDate=" + ToDate + "&type=" + Type), stringContent);

                        var request = task.GetAwaiter().GetResult();

                        var result = await request.Content.ReadAsStringAsync();
                        List<OrderDetails> orderdetails = JsonConvert.DeserializeObject<List<OrderDetails>>(result);
                        ViewBag.OrderDetails = orderdetails;

                    }
                    catch (Exception ex)
                    {

                    }

                    dashboard.UnassignedCount = Convert.ToInt64(Session["UnassignedCount"]);
                    dashboard.AssignedCount = Convert.ToInt64(Session["AssignedCount"]);
                    dashboard.TotalCount = Convert.ToInt64(Session["TotalCount"]);

                  
                }

            }
            return View(dashboard);
        }


       


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Your Login page.";

            return View();
        }
    }
}