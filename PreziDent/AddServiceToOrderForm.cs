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
    public partial class AddServiceToOrderForm : PreziDent.AppFrom
    {
        public int SelectServiceID {get; set;}
        public AddServiceToOrderForm()
        {
            InitializeComponent();
            GroupService.DataSource = DataBase.db.group_services.Local.ToBindingList();
            ServicesView.DataSource = DataBase.db.services.Local.Where(s => s.group_services_id == Convert.ToInt32(GroupService.SelectedValue)).ToList();
        }

        private void GroupService_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServicesView.DataSource = DataBase.db.services.Local.Where(s => s.group_services_id == Convert.ToInt32(GroupService.SelectedValue)).ToList();
        }

        private void ServicesView_DoubleClick(object sender, EventArgs e)
        {
            if (ServicesView.SelectedRows.Count > 0)
            {
                int index = ServicesView.SelectedRows[0].Index;
                int id = 0;

                bool converted = Int32.TryParse(ServicesView[0, index].Value.ToString(), out id);

                if (converted == false)
                    return;

                service Service = DataBase.db.services.Find(id);

                ServiceName.Text = Service.name.Trim(); 
                Price.Text = Service.price.ToString();
                SelectServiceID = Service.id;

                int count;
                float totalPrice;
                try
                {
                    count = Convert.ToInt32(Count.Text);
                }
                catch (FormatException)
                {
                    Count.Text = "1";
                    count = 1;
                }

                totalPrice = count * (float)Service.price;

                TotalPrice.Text = totalPrice.ToString();

                OkButton.Enabled = true;
            }
        }

        private void Count_TextChanged(object sender, EventArgs e)
        {
            int count;
            double price, totalPrice;
            try
            {
                count = Convert.ToInt32(Count.Text);
                price = Convert.ToDouble(Price.Text);
            }
            catch (FormatException)
            {
                return;
            }
            
            totalPrice = count * price;

            TotalPrice.Text = totalPrice.ToString();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(Count.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите целое цисло в поле количество!");
                return;
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
