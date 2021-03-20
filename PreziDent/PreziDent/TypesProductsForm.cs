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
        public TypesProductsForm()
        {
            InitializeComponent();

            DataBase.db.type_product.Load();
            TypesProductsView.DataSource = DataBase.db.type_product.Local.ToBindingList();
            
        }

        /********************************/
        /*Метод добавления типа продукта*/
        /********************************/
        private void AddTypeProductButton_Click(object sender, EventArgs e)
        {
            ControlAppForm.OpenAddTypeProductForm(this);
            DataBase.db.type_product.Load();
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



            type_product TypeProduct = DataBase.db.type_product.Find(id);

            TypeProductsForm typeProductsForm = new TypeProductsForm();

            typeProductsForm.NameTypeProducts.Text = TypeProduct.name.Trim();

            DialogResult Result = typeProductsForm.ShowDialog(this);

            if (Result == DialogResult.Cancel)
                return;

            TypeProduct.name = typeProductsForm.NameTypeProducts.Text;

            DataBase.db.Entry(TypeProduct).State = EntityState.Modified;

            DataBase.db.SaveChanges();

            TypesProductsView.Refresh(); // обновляем грид
        }

        /*******************************/
        /*Метод удаления типа продукта */
        /*******************************/
        private void DeleteTypeProductlButton_Click(object sender, EventArgs e)
        {

            if (TypesProductsView.RowCount > 0)
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

                type_product TypeProduct = DataBase.db.type_product.Find(id);
                DataBase.db.type_product.Remove(TypeProduct);
                DataBase.db.Entry(TypeProduct).State = EntityState.Deleted;
                DataBase.db.SaveChanges();
            }
            else
                MessageBox.Show("Таблица пуста!");
        }

        /********************/
        /*Закрытие формы    */
        /********************/
        private void TypesProductsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;//Чтобы обновить грид продуктов на главной форме
        }
    }
}
