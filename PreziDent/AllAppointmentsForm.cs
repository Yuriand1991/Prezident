using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreziDent
{
    public partial class AllAppointmentsForm : PreziDent.AppFrom
    {
        public AllAppointmentsForm()
        {
            InitializeComponent();
            AllAppointmentsView.DataSource = MainForm.LoadAppointmentForRoom(DateTime.Now, 3);
        }
    }
}
