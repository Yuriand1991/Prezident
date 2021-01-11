namespace PreziDent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class roles
    {
        public int id { get; set; }

        [StringLength(20)]
        public string name { get; set; }
    }
}
