using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using startapplication.Models;
using System.Diagnostics;

namespace startapplication.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            Process[] processlist = Process.GetProcesses();
            var plist = processlist.ToList().Where(x => x.ProcessName == "iisexpress").ToList();
            foreach (Process theprocess in plist)
            {
                Console.WriteLine("Process: {0} ID: {1}", theprocess.ProcessName, theprocess.Id);
                if(theprocess.Id==9516)
                {
                    IISExpress.SendStopMessageToProcess(theprocess.Id);
                    theprocess.Close();
                }
            }

            IISExpress objIISExpress = new IISExpress(@"C:\Users\rrusta\Documents\IISExpress\config\applicationhost.config",
            @"mysnippets",
            @"Clr4IntegratedAppPool");

            

            return View();
        }
	}
}