﻿using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class MainForm : PreziDent.AppFrom
    {
        public const int ADMIN = 1;
        public const int DOCTOR = 2;
        public const int FIRST_ROOM = 1;
        public const int TWO_ROOM = 2;
        public const int NINE_ROOM = 9;
        public const int NONE_APPOINTMENT = 0;

        private user User;
        private room Cabinet;
        public void SetUser(user User)
        {
            this.User = User; 
        }
        public MainForm()
        {
            InitializeComponent();
        }
        /***********************************************/
        /*Метод загрузки данных из бд для главной формы*/
        /***********************************************/
        public void LoadDB()
        {
            PrezidentClinicEntities db = new PrezidentClinicEntities();
            DataBase.db = db;
            //Загрузка продуктов
            DataBase.db.products.Load();
            ProductsView.DataSource = DataBase.db.products.Local.ToBindingList();

            //Загрузка категорий продуктов
            DataBase.db.type_product.Load();
            List<type_product> GroupProductList = DataBase.db.type_product.Local.ToList();
            type_product gp = new type_product();
            gp.name = "Все";
            GroupProductList.Insert(0, gp);
            GroupsProduct.DataSource = GroupProductList;

            //Загрузка услуг
            DataBase.db.services.Load();
            ServicesView.DataSource = DataBase.db.services.Local.ToBindingList();
           
            //Загрузка категорий услуг
            DataBase.db.group_services.Load();
            List<group_services> GroupServiceList = DataBase.db.group_services.Local.ToList();
            group_services gs = new group_services();
            gs.name = "Все";
            GroupServiceList.Insert(0, gs);
            GroupService.DataSource = GroupServiceList;

            //Загрузка пациентов
            DataBase.db.patients.Where(p => p.id != 0 /*не загружаем безымянного пациента*/).Load();
            PatientsView.DataSource = DataBase.db.patients.Local.ToBindingList();

            //Загрузка фирм
            DataBase.db.firms.Load();
            FirmsView.DataSource = DataBase.db.firms.Local.ToBindingList();

            //Загрузка контактов фирм
            DataBase.db.contacts_firm.Load();

            //Загрузка расписания (просто таблицы из бд)
            DataBase.db.appointments.Load();

            //Загрузка операций
            DataBase.db.surgeries.Load();
            SurgeriesView.DataSource = DataBase.db.surgeries.Local.ToBindingList();

            //Загрузка кабинетов
            DataBase.db.rooms.Load();
            DateTime NowDate = DateTime.Now.Date;
            if (this.User.role_id != ADMIN)//Если пользователь не администратор, а врач
            {
                //Загрузка записей приема
                int UserId = this.User.id;
                // MessageBox.Show(UserId.ToString());
                this.Cabinet = DataBase.db.rooms.Local.Where(r => r.user_id == UserId).FirstOrDefault();
                if (Cabinet != null)
                {
                    MyCabinetNumLabel.Text = "Кабинет № " + this.Cabinet.number.ToString();
                    SheduleDayCabinetView.Tag = this.Cabinet.number;
                    MyCabinetRefresh(NowDate);
                }
                else
                    MessageBox.Show("Не удалось загрузить расписание!");
            }

            LoadAppointmentForAllRoom(NowDate);
        }

        /************************************************************/
        /*Метод загрузки расписания и записей на прием для кабинета */
        /************************************************************/
        public static object LoadAppointments(DateTime? date = null, int? RoomID = null)
        {
            using (PrezidentClinicEntities db = new PrezidentClinicEntities())
            {
                db.shedules.Load();
                List<shedule> Shedules = db.shedules.Local.ToList();
                
                if((date == null) && (RoomID == null))
                    db.appointments.Load();
                else
                    db.appointments.Where(a => a.date == date).Where(a => a.room_id == RoomID).Load();

                BindingList<appointment> Appointments = db.appointments.Local.ToBindingList();
                var query = from sh in Shedules
                            join app in Appointments on sh.id equals app.shedule_id into gj
                            from subapp in gj.DefaultIfEmpty()
                            select new
                            {
                                shedule_id = sh.id,
                                sh.start_time,
                                sh.end_time,
                                id = subapp?.id ?? NONE_APPOINTMENT,
                                name_patient = subapp?.name_patient.ToString() ?? String.Empty,
                                treatment_desc = subapp?.treatment_desc.ToString() ?? String.Empty,
                                patient_id = subapp?.patient_id ?? null,
                                phone_patient = subapp?.phone_patient.ToString() ?? String.Empty,
                                room_num = subapp?.room.number ?? 0,
                                date = subapp?.date.ToString() ?? String.Empty
                            };
                object DataSource = query.ToList();

                return DataSource;
            }
        }

        /*******************************************************************/
        /*Метод загрузки расписания и записей на прием для  всех кабинетов */
        /*******************************************************************/
        public void LoadAppointmentForAllRoom(DateTime date)
        {
            List<room> Rooms;
           
            using (PrezidentClinicEntities db = new PrezidentClinicEntities())
            {
                db.rooms.Load();
                Rooms = db.rooms.Local.ToList();
            }
            

            foreach (room r in Rooms)
            {
                switch (r.number)
                {
                    case FIRST_ROOM:
                         SheduleDayCabinetOneView.DataSource = LoadAppointments(date, r.id);
                         SheduleDayCabinetOneLabel.Text = "Кабинет № " + r.number.ToString();
                         OpenOneRoomButton.Tag = r.id;
                    break;
                    case TWO_ROOM:
                         SheduleDayCabinetTwoView.DataSource = LoadAppointments(date, r.id);
                         SheduleDayCabinetTwoLabel.Text = "Кабинет № " + r.number.ToString();
                         OpenTwoRoomButton.Tag = r.id;
                    break;
                    case NINE_ROOM:
                         SheduleDayCabinetNineView.DataSource = LoadAppointments(date, r.id);
                         SheduleDayCabinetNineLabel.Text = "Кабинет № " + r.number.ToString();
                         OpenNineRoomButton.Tag = r.id;
                    break;
                }
            }
        }

        /************************************/
        /*Обновление записей в моем кабинете*/
        /************************************/
        public void MyCabinetRefresh(DateTime date)
        {
            SheduleDayCabinetView.DataSource = LoadAppointments(date, this.Cabinet.id);
            SheduleDayCabinetViewLabel.Text = GenerateDateCaption(date);
            SheduleDayCabinetView.Refresh();
        }

        /************************************/
        /*Обновление записей во всех кабинах*/
        /************************************/
        public void AllCabinetRefresh()
        {
            LoadAppointmentForAllRoom(AllCabinetCalendar.SelectionStart);
            SheduleDayAllCabinetViewLabel.Text = GenerateDateCaption(AllCabinetCalendar.SelectionRange.Start);
        }
        /*************************************************/
        /*Генерация заголовка с датой для таблицы записей*/
        /*************************************************/
        public string GenerateDateCaption(DateTime date)
        {
            if (date == DateTime.Now.Date)
            {
                return "Записи на сегодня:";
            }
            else
            {
                return "Записи на " + date.ToLongDateString() + ":";
            }
        }

        /*****************************************/
        /*Метод выделения записи в гриде по id   */
        /*****************************************/
        static public void SelectRowGrid(int id, DataGridView Grid, int PosFieldIdInGrid)
        {
            Grid.Rows[0].Selected = false;

            int rowIndex = -1;

            String Name = Grid.Columns[PosFieldIdInGrid].Name;

            DataGridViewRow row = Grid.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells[Name].Value.ToString().Equals(id.ToString()))
                .First();

            rowIndex = row.Index;

            Grid.Rows[rowIndex].Selected = true;
        }

        /********************************/
        /*  Метод записи на операцию    */
        /********************************/
        public void AddSurgery(SurgeryForm surgeryForm)
        {
            if (Convert.ToInt32(surgeryForm.Patient.Tag) == 0)//созаем нового пациента
            {
                statuses_patient StatusPatient = DataBase.db.statuses_patient.Where(sp => sp.name == "Первичный").FirstOrDefault();

                using (var transaction = DataBase.db.Database.BeginTransaction())//создаем транзакцию
                {
                    try
                    {
                        patient Patient = new patient
                        {
                            last_name = surgeryForm.FullName[0],
                            first_name = surgeryForm.FullName[1],
                            other_name = surgeryForm.FullName[2],
                            phone = "",
                            email = "",
                            num_card = "",
                            status_id = StatusPatient.id,
                            address = "",
                            notes = ""
                        };

                        DataBase.db.patients.Add(Patient);
                        DataBase.db.Entry(Patient).State = EntityState.Added;
                        DataBase.db.SaveChanges();

                        surgery Surgery = new surgery
                        {
                            patient_id = Patient.id,
                            date = surgeryForm.SurgeryData.Value,
                            date_call = surgeryForm.SurgeryDateCall.Value,
                            date_pay = surgeryForm.SurgeryDatePay.Value,
                            date_test = surgeryForm.SurgeryDateTest.Value,
                            status = surgeryForm.Status,
                            room_id = (int)surgeryForm.SurgeryCabinetNum.SelectedValue,
                            name = surgeryForm.SurgeryName.Text
                        };

                        DataBase.db.surgeries.Add(Surgery);
                        DataBase.db.Entry(Surgery).State = EntityState.Added;
                        DataBase.db.SaveChanges();

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                    }
                }

            }
            else//привязываем к существующему пациенту
            {
                surgery Surgery = new surgery
                {
                    patient_id = Convert.ToInt32(surgeryForm.Patient.Tag),
                    date = surgeryForm.SurgeryData.Value,
                    date_call = surgeryForm.SurgeryDateCall.Value,
                    date_pay = surgeryForm.SurgeryDatePay.Value,
                    date_test = surgeryForm.SurgeryDateTest.Value,
                    status = surgeryForm.Status,
                    room_id = (int)surgeryForm.SurgeryCabinetNum.SelectedValue,
                    name = surgeryForm.SurgeryName.Text
                };

                DataBase.db.surgeries.Add(Surgery);
                DataBase.db.Entry(Surgery).State = EntityState.Added;
                DataBase.db.SaveChanges();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DateLabel.Text = "Сегодня " + DateTime.Now.Date.ToLongDateString();
            LoadDB();
            switch (User.role_id)
            {
                case ADMIN:
                    MainTabControl.TabPages.Remove(Room);
                break;
                case DOCTOR:
                    //MainTabControl.TabPages.Remove(Rooms);
                break;
            }
        }

        /**************************************/
        /*Метод добавления продукта           */
        /**************************************/
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            DialogResult Result = productForm.ShowDialog(this);
            
            if (Result == DialogResult.Cancel)
                return;


            product Product = new product
            {
                name = productForm.NameProduct.Text,

                price = System.Convert.ToDecimal(productForm.PriceProduct.Text),

                type_id = (int)productForm.TypeProduct.SelectedValue
            };

            DataBase.db.products.Add(Product);
            DataBase.db.Entry(Product).State = EntityState.Added;
            DataBase.db.SaveChanges();
            ProductsView.Refresh(); // обновляем грид
        }

        /**************************************/
        /*Метод изменения продукта            */
        /**************************************/
        private void ChangeProductButton_Click(object sender, EventArgs e)
        {
            if(ProductsView.SelectedRows.Count > 0)
            {
                int index = ProductsView.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(ProductsView[0, index].Value.ToString(), out id);
                
                if (converted == false)
                    return;

                product Product = DataBase.db.products.Find(id);

                ProductForm productForm = new ProductForm();

                productForm.NameProduct.Text = Product.name.Trim();
                productForm.PriceProduct.Text = Product.price.ToString();
                productForm.TypeProduct.SelectedIndex = productForm.TypeProduct.FindStringExact(DataBase.db.type_product.Find(Product.type_id).name.ToString());

                DialogResult Result = productForm.ShowDialog(this);

                if (Result == DialogResult.Cancel)
                    return;

                Product.name = productForm.NameProduct.Text.Trim();
                Product.price = System.Convert.ToDecimal(productForm.PriceProduct.Text);
                Product.type_id = (int)productForm.TypeProduct.SelectedValue;

                DataBase.db.Entry(Product).State = EntityState.Modified;
                DataBase.db.SaveChanges();
                ProductsView.Refresh(); // обновляем грид
            }
        }

        /**************************************/
        /*Метод удаления продукта             */
        /**************************************/
        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            if (ProductsView.RowCount > 0)
            {
                DialogResult Result = MessageBox.Show("Вы действительно хотите удалить?",
                                                   "Confirmation", MessageBoxButtons.OKCancel,
                                                   MessageBoxIcon.Information);
                if (Result == DialogResult.Cancel)
                    return;

                int index = ProductsView.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(ProductsView[0, index].Value.ToString(), out id);

                if (converted == false)
                    return;

                product Product = DataBase.db.products.Find(id);
                DataBase.db.products.Remove(Product);
                DataBase.db.Entry(Product).State = EntityState.Deleted;
                DataBase.db.SaveChanges();
                ProductsView.Refresh(); // обновляем грид
            }
        }

        /***********************************/
        /*Метод отображения типов продуктов*/
        /***********************************/
        private void TypeProductButton_Click(object sender, EventArgs e)
        {
            TypesProductsForm typesProductsForm = new TypesProductsForm();

            DialogResult Result = typesProductsForm.ShowDialog(this);
            if (Result == DialogResult.OK)
                ProductsView.Refresh();

        }

        /**************************************/
        /*Метод добавления услуги             */
        /**************************************/
        private void AddServiceButton_Click(object sender, EventArgs e)
        {
            ServiceForm serviceForm = new ServiceForm();
            DialogResult Result = serviceForm.ShowDialog(this);

            if (Result == DialogResult.Cancel)
                return;

            service Service = new service
            {
                code_service = serviceForm.CodeService.Text,
                name = serviceForm.NameService.Text,
                price = System.Convert.ToDecimal(serviceForm.PriceService.Text),
                group_services_id = (int)serviceForm.GroupService.SelectedValue,
                description = serviceForm.DescriptionService.Text
            };

            DataBase.db.services.Add(Service);
            DataBase.db.Entry(Service).State = EntityState.Added;
            DataBase.db.SaveChanges();
            ServicesView.Refresh(); // обновляем грид
        }

        /**************************************/
        /*Метод изменения услуги              */
        /**************************************/
        private void ChangeServiceButton_Click(object sender, EventArgs e)
        {
            if (ServicesView.SelectedRows.Count > 0)
            {
                int index = ServicesView.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(ServicesView[0, index].Value.ToString(), out id);

                if (converted == false)
                    return;

                service Service = DataBase.db.services.Find(id);

                ServiceForm serviceForm = new ServiceForm();

                serviceForm.CodeService.Text = Service.code_service.Trim();
                serviceForm.NameService.Text = Service.name.Trim();
                serviceForm.PriceService.Text = Service.price.ToString();
                serviceForm.DescriptionService.Text = Service.description.Trim();

                serviceForm.GroupService.SelectedIndex = serviceForm.GroupService.FindStringExact(DataBase.db.group_services.Find(Service.group_services_id).name.ToString());

                DialogResult Result = serviceForm.ShowDialog(this);

                if (Result == DialogResult.Cancel)
                    return;

                Service.code_service = serviceForm.CodeService.Text.Trim();
                Service.name = serviceForm.NameService.Text.Trim();
                Service.price = System.Convert.ToDecimal(serviceForm.PriceService.Text);
                Service.group_services_id = (int)serviceForm.GroupService.SelectedValue;
                Service.description = serviceForm.DescriptionService.Text.Trim();

                DataBase.db.Entry(Service).State = EntityState.Modified;
                DataBase.db.SaveChanges();

                ServicesView.Refresh(); // обновляем грид
            }
        }

        /**************************************/
        /*Метод удаления услуги               */
        /**************************************/
        private void DeleteServiceButton_Click(object sender, EventArgs e)
        {
            if (ServicesView.RowCount > 0)
            {
                DialogResult Result = MessageBox.Show("Вы действительно хотите удалить?",
                                                   "Confirmation", MessageBoxButtons.OKCancel,
                                                   MessageBoxIcon.Information);
                if (Result == DialogResult.Cancel)
                    return;

                int index = ServicesView.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(ServicesView[0, index].Value.ToString(), out id);

                if (converted == false)
                    return;

                service Service = DataBase.db.services.Find(id);
                DataBase.db.services.Remove(Service);
                DataBase.db.Entry(Service).State = EntityState.Deleted;
                DataBase.db.SaveChanges();
                ServicesView.Refresh(); // обновляем грид
            }
        }

        /***********************************/
        /*Метод отображения групп услуг    */
        /***********************************/
        private void GroupServiceButton_Click(object sender, EventArgs e)
        {
            GroupsServicesForm groupsProductsForm = new GroupsServicesForm();
            DialogResult Result = groupsProductsForm.ShowDialog(this);

            if (Result == DialogResult.OK)
                ServicesView.Refresh();
                
        }

        /*******************************/
        /*Метод добавления пациента    */
        /*******************************/
        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            PatientForm patientForm = new PatientForm();
            DialogResult Result = patientForm.ShowDialog(this);

            if (Result == DialogResult.Cancel)
                return;

            patient Patient = new patient
            {
                last_name = patientForm.LastNamePatient.Text,
                first_name = patientForm.FirstNamePatient.Text,
                other_name = patientForm.OtherNamePatient.Text,
                phone = patientForm.PhonePatient.Text,
                email = patientForm.EmailPatient.Text,
                address = patientForm.AddressPatient.Text,
                notes = patientForm.NotesPatient.Text,
                num_card = patientForm.NumberCardPatient.Text,
                status_id = (int)patientForm.StatusPatient.SelectedValue
            };

            DataBase.db.patients.Add(Patient);
            DataBase.db.Entry(Patient).State = EntityState.Added;
            DataBase.db.SaveChanges();
            PatientsView.Refresh(); // обновляем грид
        }

        /*******************************/
        /*Метод изменения пациента     */
        /*******************************/
        private void ChangePatientButton_Click(object sender, EventArgs e)
        {
            if (PatientsView.SelectedRows.Count > 0)
            {
                int index = PatientsView.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(PatientsView[0, index].Value.ToString(), out id);

                if (converted == false)
                    return;

                patient Patient = DataBase.db.patients.Find(id);

                PatientForm patientForm = new PatientForm();

                patientForm.LastNamePatient.Text = Patient.last_name.Trim();
                patientForm.FirstNamePatient.Text = Patient.first_name.Trim();
                patientForm.OtherNamePatient.Text = Patient.other_name.Trim();
                patientForm.PhonePatient.Text = Patient.phone.Trim();
                patientForm.EmailPatient.Text = Patient.email.Trim();
                patientForm.AddressPatient.Text = Patient.address.Trim();
                patientForm.NotesPatient.Text = Patient.notes.Trim();
                patientForm.NumberCardPatient.Text = Patient.num_card.Trim();
                patientForm.StatusPatient.SelectedIndex = patientForm.StatusPatient.FindStringExact(DataBase.db.statuses_patient.Find(Patient.status_id).name.ToString()); 

                DialogResult Result = patientForm.ShowDialog(this);

                if (Result == DialogResult.Cancel)
                    return;

                Patient.last_name = patientForm.LastNamePatient.Text.Trim();
                Patient.first_name = patientForm.FirstNamePatient.Text.Trim();
                Patient.other_name = patientForm.OtherNamePatient.Text.Trim();
                Patient.phone = patientForm.PhonePatient.Text.Trim();
                Patient.email = patientForm.EmailPatient.Text.Trim();
                Patient.address = patientForm.AddressPatient.Text.Trim();
                Patient.notes = patientForm.NotesPatient.Text.Trim();
                Patient.num_card = patientForm.NumberCardPatient.Text.Trim();
                Patient.status_id = (int)patientForm.StatusPatient.SelectedValue;

                DataBase.db.Entry(Patient).State = EntityState.Modified;
                DataBase.db.SaveChanges();
                PatientsView.Refresh(); // обновляем грид
            }
        }

        /*******************************/
        /*Метод удаления пациента      */
        /*******************************/
        private void DeletePatientButton_Click(object sender, EventArgs e)
        {
            if (PatientsView.RowCount > 0)
            {
                DialogResult Result = MessageBox.Show("Вы действительно хотите удалить?",
                                                   "Confirmation", MessageBoxButtons.OKCancel,
                                                   MessageBoxIcon.Information);
                if (Result == DialogResult.Cancel)
                    return;

                int index = PatientsView.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(PatientsView[0, index].Value.ToString(), out id);

                if (converted == false)
                    return;

                patient Patient = DataBase.db.patients.Find(id);
                DataBase.db.patients.Remove(Patient);
                DataBase.db.Entry(Patient).State = EntityState.Deleted;
                DataBase.db.SaveChanges();
                PatientsView.Refresh(); // обновляем грид
            }
        }

        /************************/
        /*Метод о пациенте      */
        /************************/
        private void AboutPatientButton_Click(object sender, EventArgs e)
        {
            if (PatientsView.SelectedRows.Count > 0)
            {
                int index = PatientsView.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(PatientsView[0, index].Value.ToString(), out id);

                if (converted == false)
                    return;

                patient Patient = DataBase.db.patients.Find(id);

                PatientForm patientForm = new PatientForm();

                patientForm.LastNamePatient.Text = Patient.last_name.Trim();
                patientForm.FirstNamePatient.Text = Patient.first_name.Trim();
                patientForm.OtherNamePatient.Text = Patient.other_name.Trim();
                patientForm.PhonePatient.Text = Patient.phone.Trim();
                patientForm.EmailPatient.Text = Patient.email.Trim();
                patientForm.AddressPatient.Text = Patient.address.Trim();
                patientForm.NotesPatient.Text = Patient.notes.Trim();
                patientForm.NumberCardPatient.Text = Patient.num_card.Trim();
                patientForm.StatusPatient.SelectedIndex = patientForm.StatusPatient.FindStringExact(DataBase.db.statuses_patient.Find(Patient.status_id).name.ToString());

                patientForm.ShowDialog(this);
            }
        }

        /*********************************************************************/
        /*Навигация по календарю записей кабинета и загрузка записей на прием*/
        /*********************************************************************/
        private void MyCabinetCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            MyCabinetRefresh(MyCabinetCalendar.SelectionRange.Start);
        }

        /******************************************************/
        /*Добавление/изменение записи на прием в моем кабинете*/
        /******************************************************/
        private void SheduleDayCabinetView_DoubleClick(object sender, EventArgs e)
        {
            
            if ((sender as DataGridView).SelectedRows.Count > 0)
            {
                int index = (sender as DataGridView).SelectedRows[0].Index;
                int id = 0;

                DateTime AppDate;
                int ShId;
                int CbId;

                bool converted = Int32.TryParse((sender as DataGridView)[0, index].Value.ToString(), out id);

                if (converted == false)
                    return;

                AppointmentForm appointmentForm = new AppointmentForm();
                
                if (id != NONE_APPOINTMENT)//редактируем запись
                {
                    
                    appointment Appointment = DataBase.db.appointments.Find(id);
                    appointmentForm.SetAppointmentID(id);

                    appointmentForm.NamePatient.Text = Appointment.name_patient.Trim();
                    appointmentForm.StartTime.SelectedIndex = appointmentForm.StartTime.FindStringExact(DataBase.db.shedules.Find(Appointment.shedule_id).start_time.ToString());
                    appointmentForm.AppointmentDate.Value = (DateTime)Appointment.date;
                    appointmentForm.Treatment.Text = Appointment.treatment_desc.Trim();
                    appointmentForm.SetPatientID(Appointment.patient_id);
                    appointmentForm.PhonePatient.Text = Appointment.phone_patient.Trim();
                    appointmentForm.SetRoomID(Appointment.room_id);

                    CbId = Appointment.room_id;

                    //не показывать поле лечение, если не из моего кабинета
                    if ((sender as DataGridView).Name != "SheduleDayCabinetView")
                        appointmentForm.TreatmentBox.Visible = false;
                    else
                        appointmentForm.TreatmentBox.Visible = true;

                    DialogResult Result = appointmentForm.ShowDialog(this);

                    if (Result == DialogResult.Cancel)
                        return;

                    Appointment.name_patient = appointmentForm.NamePatient.Text;
                    Appointment.shedule_id = (int)appointmentForm.StartTime.SelectedValue;
                    Appointment.date = appointmentForm.AppointmentDate.Value;
                    Appointment.patient_id = appointmentForm.GetPatientID();
                    Appointment.treatment_desc = appointmentForm.Treatment.Text;
                    Appointment.phone_patient = appointmentForm.PhonePatient.Text;

                    ShId = Appointment.shedule_id;
                    AppDate = (DateTime)Appointment.date;

                    DataBase.db.Entry(Appointment).State = EntityState.Modified;
                    DataBase.db.SaveChanges();

                }
                else//Добавляем запись
                {
                    int idShedule = 0;

                    bool convertedIdShedule = Int32.TryParse((sender as DataGridView)[1, index].Value.ToString(), out idShedule);

                    if (convertedIdShedule == false)
                        return;

                    int CbNum = Convert.ToInt32((sender as DataGridView).Tag);/*В Tag грида храним номер кабинета*/

                    CbId = DataBase.db.rooms.Where(r => r.number == CbNum).FirstOrDefault().id;

                    shedule Shedule = DataBase.db.shedules.Find(idShedule);
                    appointmentForm.StartTime.SelectedIndex = appointmentForm.StartTime.FindStringExact(DataBase.db.shedules.Find(idShedule).start_time.ToString());
                    appointmentForm.SetPatientID(0);
                    appointmentForm.SetAppointmentID(0);
                    appointmentForm.SetRoomID(CbId);

                    //не показывать поле лечение, если не из моего кабинета
                    if ((sender as DataGridView).Name != "SheduleDayCabinetView")
                    {
                        appointmentForm.AppointmentDate.Value = AllCabinetCalendar.SelectionRange.Start;
                        appointmentForm.TreatmentBox.Visible = false;
                    }
                    else
                    {
                        appointmentForm.AppointmentDate.Value = MyCabinetCalendar.SelectionRange.Start;
                        appointmentForm.TreatmentBox.Visible = true;
                    }


                    DialogResult Result = appointmentForm.ShowDialog(this);

                    if (Result == DialogResult.Cancel)
                        return;

                    appointment Appointment = new appointment
                    {
                        patient_id = appointmentForm.GetPatientID(),
                        name_patient = appointmentForm.NamePatient.Text,
                        shedule_id = (int)appointmentForm.StartTime.SelectedValue,
                        date = appointmentForm.AppointmentDate.Value,
                        treatment_desc = appointmentForm.Treatment.Text,
                        room_id = Convert.ToInt32(CbId),
                        phone_patient = appointmentForm.PhonePatient.Text
                    };

                    ShId = Appointment.shedule_id;
                    AppDate = (DateTime)Appointment.date;

                    DataBase.db.Entry(Appointment).State = EntityState.Added;
                    DataBase.db.SaveChanges();
                }
    
                //Обновление таблицы
                if ((sender as DataGridView).Name == "SheduleDayCabinetView")//Если свой кабинет
                {
                    if (MyCabinetCalendar.SelectionStart == AppDate)//Если дату не изменили в форме записи
                    {
                        (sender as DataGridView).DataSource = LoadAppointments(MyCabinetCalendar.SelectionRange.Start, CbId);
                        (sender as DataGridView).Refresh();
                    }
                    else
                    {
                        MyCabinetCalendar.SelectionStart = AppDate;
                    }
                }
                else//если из вкладки все кабинеты
                {
                    
                    if (AllCabinetCalendar.SelectionStart == AppDate)//Если дату не изменили в форме записи
                    {
                        (sender as DataGridView).DataSource = LoadAppointments(AllCabinetCalendar.SelectionRange.Start, CbId);
                        (sender as DataGridView).Refresh();
                    }
                    else
                    {
                        AllCabinetCalendar.SelectionStart = AppDate;
                    }
                }
                SelectRowGrid(ShId, (sender as DataGridView), 1);
            }

        }

        /*******************************************************************************/
        /*Выделение строки записей на прием при нажатии правой кнопкой мыши на таблицы */
        /*******************************************************************************/
        private void SheduleDayCabinetView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowSelected = e.RowIndex;
                if (e.RowIndex != -1)
                {
                    (sender as DataGridView).ClearSelection();
                    (sender as DataGridView).Rows[rowSelected].Selected = true;
                }
            }
        }

        /**************************/
        /*Удаление записи на прием*/
        /**************************/
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((SheduleDayCabinetViewMenuStrip.SourceControl as DataGridView).SelectedRows.Count > 0)
            {
                int index = (SheduleDayCabinetViewMenuStrip.SourceControl as DataGridView).SelectedRows[0].Index;
                int id = 0;
                int CbId;

                bool converted = Int32.TryParse((SheduleDayCabinetViewMenuStrip.SourceControl as DataGridView)[0, index].Value.ToString(), out id);

                if (converted == false)
                    return;

                if (id != NONE_APPOINTMENT)
                {
                    DialogResult Result = MessageBox.Show("Вы действительно хотите удалить?",
                                                   "Confirmation", MessageBoxButtons.OKCancel,
                                                   MessageBoxIcon.Information);
                    if (Result == DialogResult.Cancel)
                        return;

                    appointment Appointment = DataBase.db.appointments.Find(id);
                    CbId = Appointment.room_id;
                    DataBase.db.appointments.Remove(Appointment);
                    DataBase.db.Entry(Appointment).State = EntityState.Deleted;
                    DataBase.db.SaveChanges();
                    
                    //если из своего кабинета
                    if ((SheduleDayCabinetViewMenuStrip.SourceControl as DataGridView).Name == "SheduleDayCabinetView")
                    {
                        (SheduleDayCabinetViewMenuStrip.SourceControl as DataGridView).DataSource = LoadAppointments(MyCabinetCalendar.SelectionRange.Start, this.Cabinet.id);
                    }
                    else//из адмистрации
                    {
                        (SheduleDayCabinetViewMenuStrip.SourceControl as DataGridView).DataSource = LoadAppointments(AllCabinetCalendar.SelectionRange.Start, CbId);
                        this.LoadAppointmentForAllRoom(AllCabinetCalendar.SelectionStart);//чтобы обновилось на главной форме при удалении в форме кабинета
                    }
                    (SheduleDayCabinetViewMenuStrip.SourceControl as DataGridView).Refresh();
                }
            }
        }

        /**************************/
        /*Переключение по вкладкам*/
        /**************************/
        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        { 

            switch (MainTabControl.TabPages[MainTabControl.SelectedIndex].Name)
            {
                case "Room":
                   MyCabinetRefresh(MyCabinetCalendar.SelectionRange.Start);
                break;
                case "Rooms":
                    LoadAppointmentForAllRoom(AllCabinetCalendar.SelectionStart);
                break;
            }      
        }

        /***************************************************************************/
        /*Навигация по календарю записей всех кабинетов и загрузка записей на прием*/
        /***************************************************************************/
        private void AllCabinetCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            AllCabinetRefresh();
        }

        /*************************/
        /*Обработка кнопки заказа*/
        /*************************/
        private void OrderButton_Click(object sender, EventArgs e)
        {
            CabinetOrderForm MyCabinetOrderForm = new CabinetOrderForm();
            MyCabinetOrderForm.ShowDialog(this);
        }

        /*******************************/
        /*Сортировка товаров по группам*/
        /*******************************/
        private void GroupsProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            int GroupID = Convert.ToInt32(GroupsProduct.SelectedValue);
            if (GroupID != 0)
                ProductsView.DataSource = DataBase.db.products.Local.Where(p => p.type_id == GroupID).ToList();
            else
                ProductsView.DataSource = DataBase.db.products.Local.ToBindingList();
        }

        /*******************************/
        /*Сортировка услуг по группам  */
        /*******************************/
        private void GroupService_SelectedIndexChanged(object sender, EventArgs e)
        {
            int GroupID = Convert.ToInt32(GroupService.SelectedValue);
            if (GroupID != 0)
                ServicesView.DataSource = DataBase.db.services.Local.Where(s => s.group_services_id == GroupID).ToList();
            else
                ServicesView.DataSource = DataBase.db.services.Local.ToBindingList();
        }

        /*******************************/
        /* Открыть все записи на прием */
        /*******************************/
        private void AllAppointmentsButton_Click(object sender, EventArgs e)
        {
            AllAppointmentsForm allAppointmentsForm = new AllAppointmentsForm();
            allAppointmentsForm.ShowDialog(this);
        }

        /****************************/
        /* Открыть все контакты фирм*/
        /****************************/
        private void AllContactFirmButton_Click(object sender, EventArgs e)
        {
            ContactsFirmForm allContactsFirmForm = new ContactsFirmForm();
            allContactsFirmForm.ContactsFirmView.Columns[1].Visible = true;
            allContactsFirmForm.ShowDialog(this);
        }


        /****************************/
        /* Открыть контакты фирмы   */
        /****************************/
        private void FirmsView_DoubleClick(object sender, EventArgs e)
        {

            if (FirmsView.SelectedRows.Count > 0)
            {
                int index = FirmsView.SelectedRows[0].Index;
                int id = 0;

                bool converted = Int32.TryParse(FirmsView[0, index].Value.ToString(), out id);

                if (converted == false)
                    return;

                String FirmName = FirmsView[1, index].Value.ToString();

                ContactsFirmForm contactsFirmForm = new ContactsFirmForm();
                contactsFirmForm.FirmID = id;
                contactsFirmForm.FirmName = FirmName;
                contactsFirmForm.ShowDialog(this);
            }
        }

        /**************************/
        /* Добавление новой фирмы */
        /**************************/
        private void AddFirmButton_Click(object sender, EventArgs e)
        {
            FirmForm firmForm = new FirmForm();
            DialogResult Result = firmForm.ShowDialog(this);

            if (Result == DialogResult.Cancel)
                return;

            firm Firm = new firm
            {
                name = firmForm.NameFirm.Text,
                address = firmForm.AddressFirm.Text,
                notes = firmForm.NotesFirm.Text
            };

            DataBase.db.firms.Add(Firm);
            DataBase.db.Entry(Firm).State = EntityState.Added;
            DataBase.db.SaveChanges();
            FirmsView.Refresh(); // обновляем грид
        }

        /*******************/
        /* Изменение фирмы */
        /*******************/
        private void ChangeFirmButton_Click(object sender, EventArgs e)
        {
            if (FirmsView.SelectedRows.Count > 0)
            {
                int index = FirmsView.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(FirmsView[0, index].Value.ToString(), out id);

                if (converted == false)
                    return;

                firm Firm = DataBase.db.firms.Find(id);

                FirmForm firmForm = new FirmForm();

                firmForm.NameFirm.Text = Firm.name.Trim();
                firmForm.AddressFirm.Text = Firm.address.Trim();
                firmForm.NotesFirm.Text = Firm.notes.Trim();

                DialogResult Result = firmForm.ShowDialog(this);

                if (Result == DialogResult.Cancel)
                    return;

                Firm.name = firmForm.NameFirm.Text;
                Firm.address = firmForm.AddressFirm.Text;
                Firm.notes = firmForm.NotesFirm.Text;

                DataBase.db.Entry(Firm).State = EntityState.Modified;
                DataBase.db.SaveChanges();

                FirmsView.Refresh(); // обновляем грид
            }
        }
        
        /******************/
        /* Удаление фирмы */
        /******************/
        private void DeleteFirmButton_Click(object sender, EventArgs e)
        {
            if (FirmsView.RowCount > 0)
            {
                DialogResult Result = MessageBox.Show("Вы действительно хотите удалить?",
                                                   "Confirmation", MessageBoxButtons.OKCancel,
                                                   MessageBoxIcon.Information);
                if (Result == DialogResult.Cancel)
                    return;

                int index = FirmsView.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(FirmsView[0, index].Value.ToString(), out id);

                if (converted == false)
                    return;

                firm Firm = DataBase.db.firms.Find(id);
                DataBase.db.firms.Remove(Firm);
                DataBase.db.Entry(Firm).State = EntityState.Deleted;
                DataBase.db.SaveChanges();
                FirmsView.Refresh(); // обновляем грид
            }
        }

        /*****************************/
        /*  Открытие формы кабинета  */
        /*****************************/
        private void OpenCabinetButton_Click(object sender, EventArgs e)
        {
            CabinetForm cabinetForm = new CabinetForm();
            cabinetForm.CabinetID = Convert.ToInt32((sender as MaterialButton).Tag);
            cabinetForm.SelectDate = AllCabinetCalendar.SelectionStart;
            cabinetForm.CabinetView.DoubleClick += this.SheduleDayCabinetView_DoubleClick;
            cabinetForm.CabinetView.ContextMenuStrip = this.SheduleDayCabinetViewMenuStrip;
            cabinetForm.Show(this);
        }

        /************************/
        /*  Запись на операцию  */
        /************************/
        private void SurgeryButton_Click(object sender, EventArgs e)
        {
            SurgeryForm surgeryForm = new SurgeryForm();
            
            surgeryForm.SurgeryCabinetNum.SelectedIndex = surgeryForm.SurgeryCabinetNum.FindStringExact(DataBase.db.rooms.Find(this.Cabinet.id).number.ToString());
            DialogResult result = surgeryForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            AddSurgery(surgeryForm);

            idPatientColumn.Visible = false;
            idSurgeryColumn.Visible = false;

            SurgeriesView.Refresh();
            PatientsView.Refresh();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            DataBase.db.SaveChanges();
        }

        /********************************************************************************/
        /*  Обработка ошибок при редактировании недопустимых полей в таблице  Операции  */
        /********************************************************************************/
        private void SurgeriesView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Из этой таблицы нельзя изменить данный столбец!\nДля изменения данного столбца нажмите кнопку ИЗМЕНИТЬ.");
            SurgeriesView.CancelEdit();
        }

        /*******************************************/
        /*  Запись на операцию  из вкладки операции*/
        /*******************************************/
        private void AddSurgeryButton_Click(object sender, EventArgs e)
        {
            SurgeryForm surgeryForm = new SurgeryForm();
            DialogResult result = surgeryForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            AddSurgery(surgeryForm);

            SurgeriesView.Refresh();
            PatientsView.Refresh();
        }

        /****************************************/
        /*  Метод изменения записи об операции  */
        /****************************************/
        private void ChangeSurgeryButton_Click(object sender, EventArgs e)
        {
            if (SurgeriesView.SelectedRows.Count > 0)
            {
                int index = SurgeriesView.SelectedRows[0].Index;
                int id = 0, patientId = 0;
               
                //id операции
                bool converted = Int32.TryParse(SurgeriesView[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                //id пациента
                converted = Int32.TryParse(SurgeriesView[1, index].Value.ToString(), out patientId);
                if (converted == false)
                    return;

                surgery Surgery = DataBase.db.surgeries.Find(id);
                patient Patient = DataBase.db.patients.Find(patientId);

                SurgeryForm surgeryForm = new SurgeryForm();

                surgeryForm.Patient.Tag = patientId;
                surgeryForm.Patient.Text = Patient.full_name;
                surgeryForm.SurgeryData.Value = (DateTime)Surgery.date;
                surgeryForm.SurgeryDateCall.Value = (DateTime)Surgery.date_call;
                surgeryForm.SurgeryDatePay.Value = (DateTime)Surgery.date_pay;
                surgeryForm.SurgeryDateTest.Value = (DateTime)Surgery.date_test;
                surgeryForm.Status = Surgery.status;
                surgeryForm.SurgeryCabinetNum.SelectedIndex = surgeryForm.SurgeryCabinetNum.FindStringExact(DataBase.db.rooms.Find(Surgery.room_id).number.ToString());
                surgeryForm.SurgeryName.Text = Surgery.name;
               
                if (Surgery.status == 1)
                    surgeryForm.SurgeryIsClose.Checked = true;
                else
                    surgeryForm.SurgeryIsClose.Checked = false;

                DialogResult Result = surgeryForm.ShowDialog(this);

                if (Result == DialogResult.Cancel)
                    return;

               /* Firm.name = firmForm.NameFirm.Text;
                Firm.address = firmForm.AddressFirm.Text;
                Firm.notes = firmForm.NotesFirm.Text;

                DataBase.db.Entry(Firm).State = EntityState.Modified;
                DataBase.db.SaveChanges();

                FirmsView.Refresh(); // обновляем грид*/
            }
        }

    }
}
