using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KTGK.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Trang chính";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Form liên hệ";

            return View();
        }
    }
}