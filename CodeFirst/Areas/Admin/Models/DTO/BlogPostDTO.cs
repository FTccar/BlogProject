﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirst.Areas.Admin.Models.DTO
{
    public class BlogPostDTO : BaseDTO
    {
        public string Title { get; set; }
        public string CategoryName { get; set; }
        public string Content { get; set; }

        [Display(Name = "Resim")]
        public HttpPostedFileBase PostImage { get; set; }
        public int CategoryID { get; set; }
        public IEnumerable<SelectListItem> drpCategories { get; set; }
    }
}