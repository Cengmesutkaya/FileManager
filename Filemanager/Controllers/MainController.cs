using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filemanager.Controllers
{
    public class MainController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.user_id = "123";            
            ViewBag.fileRoot = "\"/files/\"";         
            ViewBag.serverRoot = "true";
            ViewBag.serverMode = "false";
            ViewBag.useFileTable = "false";
            return View();
        }
    }
}
