using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst.Models.DTO
{
    public class CommentDTO
    {
        [Display(Name="Başlık")]
        public string Title { get; set; }

        [Display(Name="İçerik")]
        public string Content { get; set; }

        public int BlogPostID { get; set; }
    }
}