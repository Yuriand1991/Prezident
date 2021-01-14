namespace PreziDent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class product
    {
        public int id { get; set; }

        [Required]
        [StringLength(80)]
        public string name { get; set; }

        [Column(TypeName = "money")]
        public decimal price { get; set; }
    }
}
