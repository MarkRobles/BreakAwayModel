//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BAGA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.CustomerTypeID = 1;
            this.Reservations = new HashSet<Reservation>();
        }
    
        public int ContactID { get; set; }
        public int CustomerTypeID { get; set; }
        public Nullable<System.DateTime> InitialDate { get; set; }
        public Nullable<int> PrimaryDesintationID { get; set; }
        public Nullable<int> SecondaryDestinationID { get; set; }
        public Nullable<int> PrimaryActivityID { get; set; }
        public Nullable<int> SecondaryActivityID { get; set; }
        public string Notes { get; set; }
        public byte[] RowVersion { get; set; }
    
        public virtual Activity PrimaryActivity { get; set; }
        public virtual Activity SecondaryActivity { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual CustomerType CustomerType { get; set; }
        public virtual Destination PrimaryDestination { get; set; }
        public virtual Destination SecondaryDestination { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}