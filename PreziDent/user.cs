namespace PreziDent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user
    {
        public int id { get; set; }

        [Required]
        [StringLength(30)]
        public string login { get; set; }

        [StringLength(80)]
        public string password { get; set; }

        [StringLength(40)]
        public string first_name { get; set; }

        public int role_id { get; set; }
    }
}
