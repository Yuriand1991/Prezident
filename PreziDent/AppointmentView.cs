using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreziDent
{
    class AppointmentView
    {
        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public int patient_id { get; set; }
        public int room_id { get; set; }
        public int shedule_id { get; set; }
        public string name_patient { get; set; }
        public string treatment_desc { get; set; }

        public Nullable<System.TimeSpan> start_time { get; set; }
        public Nullable<System.TimeSpan> end_time { get; set; } 
    }
}
