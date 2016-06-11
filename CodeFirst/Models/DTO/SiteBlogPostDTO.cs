using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst.Models.DTO
{
    public class SiteBlogPostDTO
    {
        public string Title { get; set; }
        public string PostImage { get; set; }
        public string Content { get; set; }
        public string Category { get; set; }
        public string PostImagePath { get; set; }
    }
}