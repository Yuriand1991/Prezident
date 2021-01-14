namespace PreziDent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class orders_services
    {
        public int id { get; set; }

        public int order_id { get; set; }

        public int service_id { get; set; }

        public virtual order order { get; set; }

        public virtual service service { get; set; }
    }
}
