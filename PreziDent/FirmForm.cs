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
    public partial class FirmForm : PreziDent.AppFrom
    {
        public FirmForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (NameFirm.Text != "")
                this.DialogResult = DialogResult.OK;
            else
                MessageBox.Show("Введите наименование фирмы!");
        }
    }
}
