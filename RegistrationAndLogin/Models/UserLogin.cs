using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Domki_Rezerwacje.Models
{
    public class UserLogin
    {
        [Display(Name ="Adres e-mail")]
        [Required(AllowEmptyStrings =false, ErrorMessage ="Wymagany adres-email")]
        public string EmailID { get; set; }

        [Display(Name = "Hasło")]
        [Required(AllowEmptyStrings =false, ErrorMessage ="Wymagane hasło")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name ="Zapamiętaj mnie")]
        public bool RememberMe { get; set; }
    }
}