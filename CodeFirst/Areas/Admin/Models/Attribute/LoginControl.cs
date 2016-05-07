using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
namespace CodeFirst.Areas.Admin.Models.Attribute
{
    public class LoginControl :  System.Web.Mvc.ActionFilterAttribute // Bu classtan türetilince adındanda anlaşılacağı gibi action filterı veriyor.
    {
        //Bu yazılan komut aslın bir attribute olmuş oldu. Şimdi gidip Home Controllerın tepesine yazıp çağıracaz.


        public override void OnActionExecuting(ActionExecutingContext filterContext) // Kullanıcı o attribute'e sahip bir alana girdiği anda çalışır.
        {
            if (!HttpContext.Current.User.Identity.IsAuthenticated)
            {
                filterContext.HttpContext.Response.Redirect("/Admin/Login/Index");
            }
        }
    }
}