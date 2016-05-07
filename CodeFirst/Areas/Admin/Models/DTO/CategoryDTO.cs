using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst.Areas.Admin.Models.DTO
{
    public class CategoryDTO : BaseDTO
    {
        [Required(ErrorMessage="Lütfen Kategori Adını Giriniz!")]
        [Display(Name="Ad")]
        public string Name { get; set; }

        [Display(Name = "Açıklama")]
        public string Description { get; set; }
    }
}