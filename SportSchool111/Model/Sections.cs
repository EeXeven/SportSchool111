//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SportSchool111.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sections
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sections()
        {
            this.Coaches = new HashSet<Coaches>();
            this.Competitions = new HashSet<Competitions>();
            this.Groups1 = new HashSet<Groups>();
            this.Students = new HashSet<Students>();
            this.trainigs = new HashSet<trainigs>();
        }
    
        public int section_id { get; set; }
        public string section_name { get; set; }
        public Nullable<int> coach_id { get; set; }
        public Nullable<int> student_id { get; set; }
        public Nullable<int> school_id { get; set; }
        public Nullable<int> GroupID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Coaches> Coaches { get; set; }
        public virtual Coaches Coaches1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Competitions> Competitions { get; set; }
        public virtual Groups Groups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Groups> Groups1 { get; set; }
        public virtual Schools Schools { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Students> Students { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trainigs> trainigs { get; set; }
    }
}
