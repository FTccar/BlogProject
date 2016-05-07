using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst.Areas.Admin.Models.DTO
{
    public class LoginModel
    {
        [Required(ErrorMessage="Lütfen Emailinizi giriniz.")]
        [EmailAddress(ErrorMessage="Uyumlu bir email adresi giriniz.")]
        public string EMail { get; set; }


        [Required(ErrorMessage = "Lütfen parolanızı giriniz.")]
        public string Password { get; set; }
    }
}