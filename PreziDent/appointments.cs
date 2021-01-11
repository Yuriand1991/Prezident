namespace PreziDent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class appointments
    {
        public int id { get; set; }

        public int? patient_id { get; set; }

        public int? room_id { get; set; }

        public int? schedule_id { get; set; }

        [StringLength(200)]
        public string patient_name { get; set; }

        public virtual patients patients { get; set; }

        public virtual rooms rooms { get; set; }

        public virtual schedule schedule { get; set; }
    }
}
