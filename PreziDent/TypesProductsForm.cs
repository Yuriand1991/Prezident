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
        private PrezidentClinicEntities db;
        public TypesProductsForm()
        {
            InitializeComponent();
            
            db = new PrezidentClinicEntities();
            db.type_product.Load();
            TypesProductsView.DataSource = db.type_product.Local.ToBindingList();
        }

        private void AddTypeProductButton_Click(object sender, EventArgs e)
        {
            TypeProductsForm typeProductsForm = new TypeProductsForm();
            DialogResult Result = typeProductsForm.ShowDialog(this);

            if (Result == DialogResult.Cancel)
                return;

            type_product TypeProducts = new type_product();
            TypeProducts.name = typeProductsForm.NameTypeProduct.Text;
            db.type_product.Add(TypeProducts);
            db.SaveChanges();
        }

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

            db.SaveChanges();

            TypesProductsView.Refresh(); // обновляем грид
            MessageBox.Show("Продукт изменен");
        }

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
            db.SaveChanges();

            MessageBox.Show("Продукт удален");
        }
    }
}
