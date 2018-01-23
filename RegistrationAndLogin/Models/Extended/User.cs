using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Domki_Rezerwacje.Models
{
    [MetadataType(typeof(UserMetadata))]
    public partial class User
    {
        public string ConfirmPassword { get; set; }
    }

    public class UserMetadata
    {
        [Display(Name ="Imię")]
        [Required(AllowEmptyStrings = false, ErrorMessage ="Wymagane imię")]
        public string FirstName { get; set; }

        [Display(Name = "Nazwisko")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Wymagane nazwisko")]
        public string LastName { get; set; }

        [Display(Name ="Adres e-mail")]
        [Required(AllowEmptyStrings =false, ErrorMessage ="Wymagany adres e-mail")]
        [DataType(DataType.EmailAddress)]
        public string EmailID { get; set; }

        [Display(Name ="Data urodzenia")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Hasło")]
        [Required(AllowEmptyStrings =false, ErrorMessage ="Wymagane hasło")]
        [DataType(DataType.Password)]
        [MinLength(6,ErrorMessage ="Hasło powinno się składać z minimum 6 znaków.")]
        public string Password { get; set; }

        [Display(Name = "Potwierdź hasło")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Podane hasła są różne")]
        public string ConfirmPassword { get; set; }
                
    }
}