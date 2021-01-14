namespace PreziDent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public service()
        {
            orders_services = new HashSet<orders_services>();
        }

        public int id { get; set; }

        [StringLength(80)]
        public string name { get; set; }

        [Column(TypeName = "money")]
        public decimal? price { get; set; }

        public int group_services_id { get; set; }

        public virtual group_services group_services { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orders_services> orders_services { get; set; }
    }
}
