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
    
    public partial class Room
    {
        public int RoomId { get; set; }
        public string RoomNumber { get; set; }
        public string RoomImage { get; set; }
        public Nullable<decimal> RoomPrice { get; set; }
        public Nullable<int> BookingStatusId { get; set; }
        public Nullable<int> RoomTypeId { get; set; }
        public Nullable<int> RoomCapacity { get; set; }
        public string RoomDescription { get; set; }
        public Nullable<bool> RoomActive { get; set; }
    }
}