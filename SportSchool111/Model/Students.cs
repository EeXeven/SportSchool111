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
    
    public partial class Students
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Students()
        {
            this.Attendance = new HashSet<Attendance>();
        }
    
        public int student_id { get; set; }
        public string FIO { get; set; }
        public Nullable<int> gender { get; set; }
        public Nullable<int> age { get; set; }
        public Nullable<int> section_id { get; set; }
        public string passport { get; set; }
        public string policy { get; set; }
        public string inn { get; set; }
        public string snils { get; set; }
        public byte[] Photo { get; set; }
        public string birth_certificate { get; set; }
        public Nullable<int> GroupID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attendance> Attendance { get; set; }
        public virtual Genders Genders { get; set; }
        public virtual Groups Groups { get; set; }
        public virtual Groups Groups1 { get; set; }
        public virtual Sections Sections { get; set; }
    }
}
