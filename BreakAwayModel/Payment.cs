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
    
    public partial class Payment
    {
        public int PaymentID { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public int ReservationID { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public byte[] RowVersion { get; set; }
    
        public virtual Reservation Reservation { get; set; }
    }
}
