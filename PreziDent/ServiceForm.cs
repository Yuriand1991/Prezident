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
    public partial class ServiceForm : AppFrom
    {
        public ServiceForm()
        {
            InitializeComponent();
            GroupService.DataSource = DataBase.db.group_services.Local.ToBindingList();
        }
        /**************************************/
        /*Обработка кнопки добавления услуги  */
        /**************************************/
        private void OkButton_Click(object sender, EventArgs e)
        {
            String Message = "";
            Double Price;
            if (CodeService.Text.Trim() == "")
            {
                Message += "Введите код!\n";
            }
            if (NameService.Text.Trim() == "")
            {
                Message += "Введите наименование!\n";
            }

            if (PriceService.Text.Trim() == "")
            {
                Message += "Введите цену!\n";
            }
            else
            {
                try
                {
                    Price = Convert.ToDouble(PriceService.Text);
                }
                catch (FormatException)
                {
                    Message += "Не правильно введена цена!\n";
                }
            }

            if (GroupService.SelectedValue == null)
            {
                Message += "Выберете группу услуги!\n";
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
        /********************************/
        /*Метод добавления группы услуг */
        /********************************/
        private void AddGroupServiceLink_Click(object sender, EventArgs e)
        {
            ControlAppForm.OpenAddGroupServicesForm(this);
            DataBase.db.group_services.Load();
        }
    }
}
