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
    public partial class AppointmentForm : PreziDent.AppFrom
    {
        private int PatientID;
        public AppointmentForm()
        {
            InitializeComponent();

            DataBase.db.shedules.Load();
            StartTime.DataSource = DataBase.db.shedules.Local.ToBindingList();
        }

        /***************************/
        /*Установка ид пользователя*/
        /***************************/
        public void SetPatientID(int PatientID)
        {
            this.PatientID = PatientID;
        }

        /***************************/
        /*Получение ид пользователя*/
        /***************************/
        public int GetPatientID()
        {
            return this.PatientID;
        }

        /**************************************/
        /*Метод навигации по времени окончания*/
        /**************************************/
        public void NavigateEndTime()
        {
            using (PrezidentClinicEntities db = new PrezidentClinicEntities())
            {
                db.shedules.Load();
                EndTime.DataSource = db.shedules.Local.Where(s => s.id == Convert.ToInt32(StartTime.SelectedValue)).ToList();
            }
        }

        private void AppointmentForm_Shown(object sender, EventArgs e)
        {
            NavigateEndTime();
        }

        private void StartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            NavigateEndTime();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            String Message = "";

            if (NamePatient.Text.Trim() == "")
            {
                Message += "Введите ФИО пациента" +
                    "!\n";
            }

            if (PhonePatient.Text.Trim() == "")
            {
                Message += "Введите телефон пациента" +
                    "!\n";
            }

            if (Message != "")
            {
                MessageBox.Show(Message);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }

        }
    }
}
