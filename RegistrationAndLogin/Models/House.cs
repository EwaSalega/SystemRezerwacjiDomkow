//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domki_Rezerwacje.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class House
    {
        public int HouseId { get; set; }
        public string HouseName { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public int RoomSize { get; set; }
        public string Owner { get; set; }
        public int OwnerPhone { get; set; }
    }
}
