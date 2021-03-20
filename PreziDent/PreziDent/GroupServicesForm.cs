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
    public partial class GroupServicesForm : MaterialForm
    {
        public GroupServicesForm()
        {
            InitializeComponent();
        }

        /*********************/
        /*Обработка кнопки ОК*/
        /*********************/
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (NameGroupServices.Text.Trim() == "")
            {
                MessageBox.Show("Введите наименование группы!");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
