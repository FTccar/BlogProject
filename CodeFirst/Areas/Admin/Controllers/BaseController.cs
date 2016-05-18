using CodeFirst.Areas.Admin.Models.Attribute;
using CodeFirst.Models.ORM.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirst.Areas.Admin.Controllers
{
    [LoginControl]
    public class BaseController : Controller
    {
        public BlogContext db;

        public BaseController()
        {
            //ViewBag.Username = HttpContext.User.Identity.Name;
            db = new BlogContext();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
    }
}