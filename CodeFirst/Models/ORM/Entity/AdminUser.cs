using CodeFirst.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst.Models.Data
{
    public class AdminUser : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        [Required]
        [StringLength(30)]
        public string EMail { get; set; }
        [Required]
        public string Password { get; set; }
    }
}