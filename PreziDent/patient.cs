//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PreziDent
{
    using System;
    using System.Collections.Generic;
    
    public partial class patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public patient()
        {
            this.appointments = new HashSet<appointment>();
        }
    
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string other_name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public Nullable<System.DateTime> birthday { get; set; }
        public Nullable<System.DateTime> reg_date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<appointment> appointments { get; set; }
    }
}