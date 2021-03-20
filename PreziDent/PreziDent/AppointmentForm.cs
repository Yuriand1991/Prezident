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
        private int AppointmentID;
        private int RoomID;
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

        /*******************************/
        /*Установка ид записи на прием*/
        /******************************/
        public void SetAppointmentID(int AppointmentID)
        {
            this.AppointmentID = AppointmentID;
        }

        /***************************/
        /*Установка ид пользователя*/
        /***************************/
        public void SetRoomID(int RoomID)
        {
            this.RoomID = RoomID;
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

            if (Message != "")
            {
                MessageBox.Show(Message);
            }
            else
            {
                //Проверяем, есть ли запись на данное время
                if (DataBase.db.appointments.Where(a => a.date == (DateTime)AppointmentDate.Value)
                                                    .Where(a => a.shedule_id == (int)StartTime.SelectedValue)
                                                    .Where(a => a.id != AppointmentID)
                                                    .Where(a => a.room_id == RoomID).FirstOrDefault() != null)
                {
                    MessageBox.Show("На данное время уже записан пациент!");
                    return;
                }

                this.DialogResult = DialogResult.OK;
            }

        }
    }
}
