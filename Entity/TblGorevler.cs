//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DevExp_IsTakipProjesi.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblGorevler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblGorevler()
        {
            this.TblGorevDetay = new HashSet<TblGorevDetay>();
        }
    
        public int Id { get; set; }
        public Nullable<int> GorevVeren { get; set; }
        public Nullable<int> GörevAlan { get; set; }
        public string Aciklama { get; set; }
        public string Durum { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblGorevDetay> TblGorevDetay { get; set; }
        public virtual TblPersoneller TblPersoneller { get; set; }
        public virtual TblPersoneller TblPersoneller1 { get; set; }
    }
}
