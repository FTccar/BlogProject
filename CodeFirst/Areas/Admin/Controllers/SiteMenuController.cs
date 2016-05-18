using CodeFirst.Areas.Admin.Models.DTO;
using CodeFirst.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirst.Areas.Admin.Controllers
{
    public class SiteMenuController : BaseController
    {
        public ActionResult AddSiteMenu(SiteMenuDTO model)
        {
            SiteMenu siteMenu = new SiteMenu();
            siteMenu.Name = model.Name;
            siteMenu.URL = model.CssClass;
            siteMenu.CssClass = model.CssClass;

            db.SiteMenus.Add(siteMenu);
            db.SaveChanges();
            ViewBag.IslemDurum = 1;

            return View();
        }


        
        public ActionResult AddSiteMenuJSON()
        {
            return View();
        }

        
        public JsonResult AddSiteMenuJSON(SiteMenuDTO model)
        {
            SiteMenu siteMenu = new SiteMenu();
            siteMenu.Name = model.Name;
            siteMenu.URL = model.CssClass;
            siteMenu.CssClass = model.CssClass;

            db.SiteMenus.Add(siteMenu);
            db.SaveChanges();
            ViewBag.IslemDurum = 1;

            return Json("");
        }
    }
}