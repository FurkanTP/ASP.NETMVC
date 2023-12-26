//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FRKTPTUR6.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bilet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bilet()
        {
            this.BiletSatış = new HashSet<BiletSatış>();
        }
    
        public int Bilet_ID { get; set; }
        public int Müs_ID { get; set; }
        public int Sefer_ID { get; set; }
        public int Bus_ID { get; set; }
        public string KoltukNO { get; set; }
        public System.DateTime KalkısZamanı { get; set; }
    
        public virtual Müşteri Müşteri { get; set; }
        public virtual Otobüs Otobüs { get; set; }
        public virtual Sefer Sefer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BiletSatış> BiletSatış { get; set; }
    }
}
