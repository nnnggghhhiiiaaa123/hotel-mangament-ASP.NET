//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelTest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Booking
    {
        //nghia
        public int BookingId { get; set; }
        public string CustomerName { get; set; }
        public Nullable<System.DateTime> BookingFrom { get; set; }
        public Nullable<System.DateTime> BookingTo { get; set; }
        public Nullable<int> AssignRoomId { get; set; }
        public Nullable<int> NoOfMembers { get; set; }
        public Nullable<decimal> ToTalAmount { get; set; }
    }
}
