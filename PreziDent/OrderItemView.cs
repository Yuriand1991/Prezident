using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreziDent
{
    class OrderItemView
    {
        public int id { get; set; }
        public int order_id { get; set; }
        public int service_id { get; set; }
        public string name_service { get; set; }
        public Nullable<decimal> price_service { get; set; }

        public Nullable<int> number_tooth { get; set; }
        public int count { get; set; }
        public Nullable<decimal> total_price_service { get; set; }
    }
}
