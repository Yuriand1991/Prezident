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

namespace PreziDent
{
    public partial class TypeProductsForm : PreziDent.AppFrom
    {
        public TypeProductsForm()
        {
            InitializeComponent();
   
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (NameTypeProduct.Text.Trim() == "")
            {
                MessageBox.Show("Введите наименование категории!");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
