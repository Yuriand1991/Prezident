using MaterialSkin;
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
        private user User;
        public void SetUser(user User)
        {
            this.User = User; 
        }
        public MainForm()
        {
            InitializeComponent();
            LoadDB();
        }

        public void LoadDB()
        {
            PrezidentClinicEntities db = new PrezidentClinicEntities();
            DataBase.db = db;
            //Загрузка продуктов
            DataBase.db.products.Load();
            ProductsView.DataSource = DataBase.db.products.Local.ToBindingList();
            //Загрузка услуг
            DataBase.db.services.Load();
            ServicesView.DataSource = DataBase.db.services.Local.ToBindingList();
            //Загрузка пациентов
            DataBase.db.patients.Load();
            PatientsView.DataSource = DataBase.db.patients.Local.ToBindingList();
            //Загрузка записей приема
            DateTime? NowDate = DateTime.Now.Date;
            DataBase.db.shedules.Load();
            List<shedule> Shedules = DataBase.db.shedules.Local.ToList();
            DataBase.db.appointments.Where(a => a.date == NowDate).Load();
            List<appointment> Appointments = DataBase.db.appointments.Local.ToList();

            var query = from sh in Shedules
                        join app in Appointments on sh.id equals app.shedule_id into gj
                        from subapp in gj.DefaultIfEmpty()
                        select new { sh.start_time, 
                                     sh.end_time,
                                     name_patient = subapp?.name_patient.ToString() ?? String.Empty,
                                     treatment_desc = subapp?.treatment_desc.ToString() ?? String.Empty };

            SheduleDayCabinetView.DataSource = query.ToList();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonRoom9Orders_Click(object sender, EventArgs e)
        {
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.Date.ToLongDateString();
            switch (User.role_id)
            {
                case 1:
                    MainTabControl.TabPages.Remove(Room);
                    
                break;
                case 2:
                    MainTabControl.TabPages.Remove(Rooms);
                   /* db = new PrezidentClinicEntities();
                    db.shedules.Load();
                    SheduleView.DataSource = db.shedules.Select(s => new SheduleShow
                    {
                        start_time = s.start_time,
                        end_time = s.end_time,
                        name_patient = "***"
                    }).ToList();*/
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


            product Product = new product();

            Product.name = productForm.NameProduct.Text;

            Product.price = System.Convert.ToDecimal(productForm.PriceProduct.Text);

            Product.type_id = (int)productForm.TypeProduct.SelectedValue;

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

            service Service = new service();

            Service.code_service = serviceForm.CodeService.Text;
            Service.name = serviceForm.NameService.Text;
            Service.price = System.Convert.ToDecimal(serviceForm.PriceService.Text);
            Service.group_services_id = (int)serviceForm.GroupService.SelectedValue;
            Service.description = serviceForm.DescriptionService.Text;

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

            patient Patient = new patient();
            Patient.last_name = patientForm.LastNamePatient.Text;
            Patient.first_name = patientForm.FirstNamePatient.Text;
            Patient.other_name = patientForm.OtherNamePatient.Text;
            Patient.phone = patientForm.PhonePatient.Text;
            Patient.reg_date = patientForm.RegistrationDatePatient.Value;
            Patient.birthday = patientForm.BirthDayPatient.Value;
            Patient.email = patientForm.EmailPatient.Text;
            Patient.address = patientForm.AddressPatient.Text;
            Patient.notes = patientForm.NotesPatient.Text;
            Patient.num_card = patientForm.NumberCardPatient.Text;
            Patient.status_id = (int)patientForm.StatusPatient.SelectedValue;

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
                patientForm.RegistrationDatePatient.Value = (DateTime)Patient.reg_date;
                patientForm.BirthDayPatient.Value = (DateTime)Patient.birthday;
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
                Patient.reg_date = patientForm.RegistrationDatePatient.Value;
                Patient.birthday = patientForm.BirthDayPatient.Value;
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
                patientForm.RegistrationDatePatient.Value = (DateTime)Patient.reg_date;
                patientForm.BirthDayPatient.Value = (DateTime)Patient.birthday;
                patientForm.EmailPatient.Text = Patient.email.Trim();
                patientForm.AddressPatient.Text = Patient.address.Trim();
                patientForm.NotesPatient.Text = Patient.notes.Trim();
                patientForm.NumberCardPatient.Text = Patient.num_card.Trim();
                patientForm.StatusPatient.SelectedIndex = patientForm.StatusPatient.FindStringExact(DataBase.db.statuses_patient.Find(Patient.status_id).name.ToString());

                patientForm.ShowDialog(this);
            }
        }

    }
}
