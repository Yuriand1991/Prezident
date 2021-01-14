namespace PreziDent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("appointment")]
    public partial class appointment
    {
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }

        public int patient_id { get; set; }

        public int room_id { get; set; }

        public int shedule_id { get; set; }

        [StringLength(255)]
        public string name_patient { get; set; }

        public virtual patient patient { get; set; }

        public virtual room room { get; set; }

        public virtual shedule shedule { get; set; }
    }
}
