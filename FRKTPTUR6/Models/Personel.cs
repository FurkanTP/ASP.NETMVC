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
    
    public partial class Personel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personel()
        {
            this.Otobüs = new HashSet<Otobüs>();
        }
    
        public int Pers_ID { get; set; }
        public int Sube_ID { get; set; }
        public string PersAd { get; set; }
        public string PersSoyad { get; set; }
        public string PersTelNO { get; set; }
        public string KullanıcıAd { get; set; }
        public string Sifre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Otobüs> Otobüs { get; set; }
        public virtual Subeler Subeler { get; set; }
    }
}
