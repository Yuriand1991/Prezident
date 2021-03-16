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
    public partial class CabinetForm : PreziDent.AppFrom
    {
        public int CabinetID { get; set; }
        public DateTime SelectDate { get; set; }
        public CabinetForm()
        {
            InitializeComponent();
        }

        private void CabinetForm_Shown(object sender, EventArgs e)
        {
            CabinetView.DataSource = MainForm.LoadAppointments(SelectDate, CabinetID);
            int NumberRoom = DataBase.db.rooms.Find(CabinetID).number;
            CabinetView.Tag = NumberRoom;/*В Tag грида храним номер кабинета*/
            this.Text = "Записи на прием кабинета №" + NumberRoom.ToString();
            dateTimePicker.Value = SelectDate;
            CabinetView.DoubleClick += CabinetView_DoubleClick;//Добавляем делегат, который выполнится после добавленного в главной форме
        }

        /********************/
        /*  Выбор по дате   */
        /********************/
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            CabinetView.DataSource = MainForm.LoadAppointments(dateTimePicker.Value, CabinetID);
        }

        /**************************************************/
        /*  Метод для обновления записей на главной форме */
        /**************************************************/
        private void CabinetView_DoubleClick(object sender, EventArgs e)
        {
            (this.Owner as MainForm).LoadAppointmentForAllRoom((this.Owner as MainForm).AllCabinetCalendar.SelectionStart);//Обновляем на главной форме
        }
    }
}
