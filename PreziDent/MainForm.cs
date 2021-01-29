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

        private void SheduleView_Paint(object sender, PaintEventArgs e)
        {
            foreach (DataGridViewColumn header in SheduleView.Columns)
            {
               if(header.HeaderText == "start_time")
                    header.HeaderText = "Начало";
                
                if (header.HeaderText == "end_time")
                    header.HeaderText = "Конец";
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

                productForm.NameProduct.Text = Product.name;
                productForm.PriceProduct.Text = Product.price.ToString();
                productForm.TypeProduct.SelectedIndex = productForm.TypeProduct.FindStringExact(DataBase.db.type_product.Find(Product.type_id).name.ToString());

                DialogResult Result = productForm.ShowDialog(this);

                if (Result == DialogResult.Cancel)
                    return;

                Product.name = productForm.NameProduct.Text;
                Product.price = System.Convert.ToDecimal(productForm.PriceProduct.Text);
                Product.type_id = (int)productForm.TypeProduct.SelectedValue;

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
                DataBase.db.SaveChanges();
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

                serviceForm.CodeService.Text = Service.code_service;
                serviceForm.NameService.Text = Service.name;
                serviceForm.PriceService.Text = Service.price.ToString();
                serviceForm.DescriptionService.Text = Service.description;

                serviceForm.GroupService.SelectedIndex = serviceForm.GroupService.FindStringExact(DataBase.db.group_services.Find(Service.group_services_id).name.ToString());

                DialogResult Result = serviceForm.ShowDialog(this);

                if (Result == DialogResult.Cancel)
                    return;

                Service.code_service = serviceForm.CodeService.Text;
                Service.name = serviceForm.NameService.Text;
                Service.price = System.Convert.ToDecimal(serviceForm.PriceService.Text);
                Service.group_services_id = (int)serviceForm.GroupService.SelectedValue;
                Service.description = serviceForm.DescriptionService.Text;

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
                DataBase.db.SaveChanges();
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
    }
}
