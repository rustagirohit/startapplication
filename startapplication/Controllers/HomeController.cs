using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using startapplication.Models;

namespace startapplication.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            IISExpress objIISExpress = new IISExpress(@"C:\Users\rrusta\Documents\IISExpress\config\applicationhost.config",
            @"mysnippets",
            @"Clr4IntegratedAppPool");
            return View();
        }
	}
}