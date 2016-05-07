﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirst.Areas.Admin.Models.DTO;
using System.Web.Security;
using CodeFirst.Models.ORM.Context;
using CodeFirst.Areas.Admin.Models.Attribute;

namespace CodeFirst.Areas.Admin.Controllers
{
    
    public class LoginController : Controller
    {
        private BlogContext db = new BlogContext();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            if(ModelState.IsValid)
            {
                if (db.AdminUsers.Any(x=>x.EMail == model.EMail && x.Password == model.Password && x.IsDeleted == false))
                {
                    FormsAuthentication.SetAuthCookie(model.EMail, true);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View();
                }
                
            }
            else
            {
                return View();
            }
            return View();
        }


        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }

    }
}
