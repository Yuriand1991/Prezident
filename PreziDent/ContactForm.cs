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
    public partial class ContactForm : PreziDent.AppFrom
    {
        public ContactForm()
        {
            InitializeComponent();
            FirmContact.DataSource = DataBase.db.firms.Local.ToBindingList();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
