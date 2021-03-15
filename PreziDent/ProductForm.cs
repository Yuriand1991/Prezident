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
    public partial class ProductForm : PreziDent.AppFrom
    {
        public ProductForm()
        {
            InitializeComponent();
            
            TypeProduct.DataSource = DataBase.db.type_product.Local.ToBindingList();

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }
        /**************************************/
        /*Метод добавления нового типа товаров*/
        /**************************************/
        private void AddTypeProductLink_Click(object sender, EventArgs e)
        {
            ControlAppForm.OpenAddTypeProductForm(this);
            DataBase.db.type_product.Load();
        }
        /**************************************/
        /*Обработка кнопки добавления продукта*/
        /**************************************/
        private void OkButton_Click(object sender, EventArgs e)
        {
            String Message = "";
            Double Price;

            if(NameProduct.Text.Trim() == "")
            {
                Message += "Введите наименование!\n";
            }

            if (PriceProduct.Text.Trim() == "")
            {
                Message += "Введите цену!\n";
            }
            else
            {
                try
                {
                    Price = Convert.ToDouble(PriceProduct.Text);
                }
                catch (FormatException)
                {
                    Message += "Не правильно введена цена!\n";
                }
            }

            if (TypeProduct.SelectedValue == null)
            {
                Message += "Выберете категорию продукта!\n";
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
