using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Domki_Rezerwacje.Models
{
    public class HouseInsert
    {
        [Display(Name = "Nazwa domku")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Wymagana nazwa")]
        public string HouseName { get; set; }

        [Display(Name = "Lokalizacja")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Wymagana lokalizacja")]
        public string Location { get; set; }

        [Display(Name = "Opis")]
        public string Description { get; set; }

        [Display(Name = "Ilość miejsc")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Wymagana ilość miejsc")]
        public int RoomSize { get; set; }

        [Display(Name = "Właściciel")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Wymagane nazwisko właściciela")]
        public string Owner { get; set; }

        [Display(Name = "Nr telefonu")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Wymagany nr telefonu")]
        public int OwnerPhone { get; set; }

        
    }
}