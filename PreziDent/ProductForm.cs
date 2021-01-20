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
        private PrezidentClinicEntities db;

        public ProductForm()
        {
            InitializeComponent();

            db = new PrezidentClinicEntities();
            db.type_product.Load();
            TypeProduct.DataSource = db.type_product.Local.ToBindingList();

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }

        private void AddTypeProductLink_Click(object sender, EventArgs e)
        {
            ControlAppForm.OpenAddTypeProductForm(this);
            db.type_product.Load();
        }
    }
}
