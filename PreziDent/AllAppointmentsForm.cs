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
    public partial class AllAppointmentsForm : PreziDent.AppFrom
    {
        public AllAppointmentsForm()
        {
            InitializeComponent();
           AllAppointmentsView.DataSource = MainForm.LoadAppointments();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = AllAppointmentsView.Rows.GetRowCount(DataGridViewElementStates.Selected);

            bool FlagAsk = false;

             for (int i = 0; i < selectedRowCount; i++)
             {
                int index = AllAppointmentsView.SelectedRows[i].Index;
                int id = 0;

                bool converted = Int32.TryParse(AllAppointmentsView[0, index].Value.ToString(), out id);

                if (converted == false)
                    return;

                if (id != 0)
                {
                    if (!FlagAsk)//Если не спросили удалить записи?
                    {
                        DialogResult Result = MessageBox.Show("Вы действительно хотите удалить?",
                                      "Confirmation", MessageBoxButtons.OKCancel,
                                      MessageBoxIcon.Information);
                        if (Result == DialogResult.Cancel)
                            return;

                        FlagAsk = true;
                    }

                    appointment Appointment = DataBase.db.appointments.Find(id);
                    DataBase.db.appointments.Remove(Appointment);
                    DataBase.db.Entry(Appointment).State = EntityState.Deleted;
                    DataBase.db.SaveChanges();
                }
            }

            AllAppointmentsView.DataSource = MainForm.LoadAppointments();
            (this.Owner as MainForm).LoadAppointmentForAllRoom((this.Owner as MainForm).AllCabinetCalendar.SelectionStart);//Обновляем на главной форме
        }
    }
}
