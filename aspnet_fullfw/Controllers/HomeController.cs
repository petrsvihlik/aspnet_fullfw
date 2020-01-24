using Kentico.Kontent.Delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace aspnet_fullfw.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            IDeliveryClient c = DeliveryClientBuilder.WithProjectId("975bf280-fd91-488c-994c-2f04416e5ee3").Build();
            var i = await c.GetItemAsync("on_roasts");

            return View();
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
    }
}