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
    public partial class SurgeryForm : PreziDent.AppFrom
    {
        public String[] FullName { get; set; }
        public int Status { get; set; }
        public SurgeryForm()
        {
            InitializeComponent();
            PatientList.DataSource = DataBase.db.patients.Local.ToBindingList();
            FullName = Patient.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            SurgeryCabinetNum.DataSource = DataBase.db.rooms.Local.ToBindingList();
        }

        /********************/
        /*  Поиск пациента  */
        /********************/
        private void Patient_TextChanged(object sender, EventArgs e)
        {
            Patient.Tag = 0;
            FullName = Patient.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string FirstName = "";
            string LastName = "";
            string OtherName = "";
            List<patient> Patients = new List<patient>();

            //Если ввели Фамилию Имя Отчество
            if (FullName.Length == 3)
            {
                FirstName = string.Format("%{0}%", FullName[1]);
                LastName = string.Format("%{0}%", FullName[0]);
                OtherName = string.Format("%{0}%", FullName[2]);

                Patients = DataBase.db.patients.Where(p => DbFunctions.Like(p.first_name, FirstName)).Where(p => DbFunctions.Like(p.last_name, LastName)).Where(p => DbFunctions.Like(p.other_name, OtherName)).ToList();

            }

            //Если ввели Фамилию Имя
            if (FullName.Length == 2)
            {
                FirstName = string.Format("%{0}%", FullName[1]);
                LastName = string.Format("%{0}%", FullName[0]);

                Patients = DataBase.db.patients.Where(p => DbFunctions.Like(p.first_name, FirstName)).Where(p => DbFunctions.Like(p.last_name, LastName)).ToList();

            }

            //Если ввели Фамилию или Имя или Отчество
            if (FullName.Length == 1)
            {
                FirstName = string.Format("%{0}%", FullName[0]);

                Patients = DataBase.db.patients.Where(p => DbFunctions.Like(p.first_name, FirstName) || DbFunctions.Like(p.last_name, FirstName) || DbFunctions.Like(p.other_name, FirstName)).ToList();
        
            }

            if (Patients.Count != 0)
            {
                PatientList.DataSource = Patients;
                PatientList.Visible = true;
            }
            else
                PatientList.Visible = false;
        }

        private void PatientList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /********************************/
        /*  Выбор пациента из списка    */
        /********************************/
        private void PatientList_Click(object sender, EventArgs e)
        {
            Patient.Text = PatientList.Text;
            PatientList.Visible = false;
            Patient.Tag = PatientList.SelectedValue;//id
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            String msg = "";
            
            if (FullName.Length != 3)
                msg += "Введите ФИО пациента\n";
            if (SurgeryName.Text == "")
                msg += "Введите наименование операции\n";
             
            if(msg != "")
                MessageBox.Show(msg);
            else
                this.DialogResult = DialogResult.OK;
        }

        private void SurgeryIsOpen_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void SurgeryIsClose_CheckedChanged(object sender, EventArgs e)
        {
            Status = 1;
        }

        private void SurgeryIsOpen_Click(object sender, EventArgs e)
        {
            Status = 0;
        }

        private void SurgeryForm_Shown(object sender, EventArgs e)
        {
        }
    }
}
