using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreziDent
{
    public partial class PatientForm : PreziDent.AppFrom
    {
        public PatientForm()
        {
            InitializeComponent();
            DataBase.db.statuses_patient.Load();
            StatusPatient.DataSource = DataBase.db.statuses_patient.Local.ToBindingList();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
