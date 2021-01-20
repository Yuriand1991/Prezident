using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace PreziDent
{
    public partial class TypesProductsForm : PreziDent.AppFrom
    {
        PrezidentClinicEntities db;
        public TypesProductsForm()
        {
            InitializeComponent();

            db = new PrezidentClinicEntities();
            db.type_product.Load();
            TypesProductsView.DataSource = db.type_product.Local.ToBindingList();
            
        }

        /********************************/
        /*Метод добавления типа продукта*/
        /********************************/
        private void AddTypeProductButton_Click(object sender, EventArgs e)
        {
            ControlAppForm.OpenAddTypeProductForm(this);
            db.type_product.Load();
        }

        /*******************************/
        /*Метод изменения типа продукта*/
        /*******************************/
        private void ChangeTypeProductButton_Click(object sender, EventArgs e)
        {
            int index = TypesProductsView.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(TypesProductsView[0, index].Value.ToString(), out id);

            if (converted == false)
                return;



            type_product TypeProduct = db.type_product.Find(id);

            TypeProductsForm typeProductsForm = new TypeProductsForm();

            typeProductsForm.NameTypeProduct.Text = TypeProduct.name.Trim();

            DialogResult Result = typeProductsForm.ShowDialog(this);

            if (Result == DialogResult.Cancel)
                return;

            TypeProduct.name = typeProductsForm.NameTypeProduct.Text;

            db.Entry(TypeProduct).State = EntityState.Modified;

            db.SaveChanges();

            TypesProductsView.Refresh(); // обновляем грид
            MessageBox.Show("Продукт изменен");
        }

        /*******************************/
        /*Метод удаления типа продукта */
        /*******************************/
        private void DeleteTypeProductlButton_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Вы действительно хотите удалить?",
                                   "Confirmation", MessageBoxButtons.OKCancel,
                                   MessageBoxIcon.Information);
            if (Result == DialogResult.Cancel)
                return;

            int index = TypesProductsView.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(TypesProductsView[0, index].Value.ToString(), out id);

            if (converted == false)
                return;

            type_product TypeProduct = db.type_product.Find(id);
            db.type_product.Remove(TypeProduct);
            db.Entry(TypeProduct).State = EntityState.Deleted;
            db.SaveChanges();

            MessageBox.Show("Продукт удален");
        }
    }
}
