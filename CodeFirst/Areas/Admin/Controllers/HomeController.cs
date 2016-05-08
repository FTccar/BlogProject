using CodeFirst.Areas.Admin.Models.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirst.Areas.Admin.Controllers
{
    
    public class HomeController : Controller
    {
        //
        // GET: /Admin/Home/

        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Logoff()
        {
            return RedirectToAction("Logoff", "Login");
        }

    }
}
