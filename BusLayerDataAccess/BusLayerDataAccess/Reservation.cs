//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusLayerDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservation
    {
        public decimal ReservationsId { get; set; }
        public string Id { get; set; }
        public decimal CopyId { get; set; }
        public Nullable<int> Priority { get; set; }
        public Nullable<System.DateTime> ReservationDate { get; set; }
        public Nullable<System.DateTime> LastModified { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Copy Copy { get; set; }
    }
}
