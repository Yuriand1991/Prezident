namespace PreziDent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            rooms = new HashSet<room>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(30)]
        public string login { get; set; }

        [Required]
        [StringLength(32)]
        public string password { get; set; }

        [Required]
        [StringLength(80)]
        public string first_name { get; set; }

        public int role_id { get; set; }

        public virtual role role { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<room> rooms { get; set; }
    }
}
