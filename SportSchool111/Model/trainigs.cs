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
    
    public partial class trainigs
    {
        public int id { get; set; }
        public string day { get; set; }
        public int group_id { get; set; }
        public int cocahe_id { get; set; }
        public int section_id { get; set; }
        public System.TimeSpan time { get; set; }
    
        public virtual Coaches Coaches { get; set; }
        public virtual Groups Groups { get; set; }
        public virtual Sections Sections { get; set; }
    }
}
