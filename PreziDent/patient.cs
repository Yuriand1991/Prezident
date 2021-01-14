namespace PreziDent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public patient()
        {
            appointments = new HashSet<appointment>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(80)]
        public string first_name { get; set; }

        [Required]
        [StringLength(80)]
        public string last_name { get; set; }

        [StringLength(80)]
        public string other_name { get; set; }

        [StringLength(12)]
        public string phone { get; set; }

        [StringLength(80)]
        public string email { get; set; }

        [Column(TypeName = "date")]
        public DateTime? birthday { get; set; }

        [Column(TypeName = "date")]
        public DateTime? reg_date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<appointment> appointments { get; set; }
    }
}
