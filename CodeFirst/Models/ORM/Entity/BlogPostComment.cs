using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models.ORM.Entity
{
    public class BlogPostComment : BaseEntity
    {
        public string Title { get; set; }
        [StringLength(200)]
        public string Content { get; set; }

        private bool _isActive = false;
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }
        public int BlogPostID { get; set; }


        [ForeignKey("BlogPostID")]
        public virtual BlogPost BlogPost { get; set; }
    }
}