//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebDatVePhim.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rap()
        {
            this.PhongChieux = new HashSet<PhongChieu>();
        }
    
        public int id_Rap { get; set; }
        public string tenRap { get; set; }
        public string diaChiRap { get; set; }
        public string sdtRap { get; set; }
        public string emailRap { get; set; }
        public Nullable<int> id_loaiRap { get; set; }
    
        public virtual LoaiRap LoaiRap { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhongChieu> PhongChieux { get; set; }
    }
}
