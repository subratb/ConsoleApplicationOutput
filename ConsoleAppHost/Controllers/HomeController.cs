using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConsoleAppHost.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var path = Server.MapPath(@"ConsoleApplication.exe");
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo(path, @"Subrat");            
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            Process p = Process.Start(startInfo);
            string output = p.StandardOutput.ReadToEnd();
            ViewData["output"] = string.Format("Output from original program: {0}", output);
            p.WaitForExit();

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