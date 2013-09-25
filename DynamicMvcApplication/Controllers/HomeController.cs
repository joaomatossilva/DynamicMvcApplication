using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicMvcApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return AjaxView();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return AjaxView();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return AjaxView();
        }

        private ActionResult AjaxView()
        {
            System.Threading.Thread.Sleep(2000);
            return Request.IsAjaxRequest() ? PartialView() : (ActionResult)View("_BlankView");
        }
    }
}
