using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExultitSolution.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult aboutus()
        {

            return View();
        }

        public ActionResult contactus()
        {

            return View();
        }
        public ActionResult technologies()
        {

            return View();
        }

        [ActionName("blog")]
        public ActionResult blogs()
        {
            return View("blogs");
        }

        [ActionName("website-development")]
        public ActionResult webdesign()
        {
            return View("webdesign");
        }

        [ActionName("cloud-services")]
        public ActionResult cloudservices()
        {

            return View("cloudservices");
        }
        [ActionName("crm-software-company")]
        public ActionResult crmsoftware()
        {

            return View("crmsoftware");
        }
        [ActionName("ecommerce-web-development")]
        public ActionResult ecommercewebdevelpement()
        {

            return View("ecommercewebdevelpement");
        }
        [ActionName("effective-digital-ways-to-improve-your-business")]
        public ActionResult effectivedigitalways()
        {

            return View("effectivedigitalways");
        }
        [ActionName("mobile-app-development")]
        public ActionResult mobileapplication()
        {

            return View("mobileapplication");
        }
        public ActionResult remotestaff()
        {

            return View();
        }
        public ActionResult seo()
        {

            return View();
        }
        [ActionName("top-6-mobile-app-developement-trends-for-2021")]
        public ActionResult top6mobileview()
        {

            return View("top6mobileview");
        }
        [ActionName("top-reason-to-select-exultit")]
        public ActionResult topreasonexultit()
        {

            return View("topreasonexultit");
        }
        public ActionResult _ModelRequest ()
        {

            return View();
        }
    }
}