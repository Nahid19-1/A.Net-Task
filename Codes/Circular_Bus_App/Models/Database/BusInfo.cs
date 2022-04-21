//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Circular_Bus_App.Models.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class BusInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BusInfo()
        {
            this.BusRoutes = new HashSet<BusRoute>();
            this.SoldTickets = new HashSet<SoldTicket>();
            this.Carts = new HashSet<Cart>();
        }
    
        public int B_Id { get; set; }
        public string B_Name { get; set; }
        public string B_NoPlate { get; set; }
        public string B_Type { get; set; }
        public string B_Route { get; set; }
        public string B_Time { get; set; }
        public Nullable<int> B_Fair { get; set; }
        public Nullable<int> B_AvailableSeat { get; set; }
        public Nullable<int> B_OwnedBy { get; set; }
        public Nullable<int> B_SId { get; set; }
        public string B_Status { get; set; }
    
        public virtual BusOwner BusOwner { get; set; }
        public virtual Supervisor Supervisor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusRoute> BusRoutes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SoldTicket> SoldTickets { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
