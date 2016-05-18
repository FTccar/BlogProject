using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst.Areas.Admin.Models.DTO
{
    public class SiteMenuDTO : BaseDTO
    {
        public string Name { get; set; }
        public string URL { get; set; }
        public string CssClass { get; set; }
    }
}