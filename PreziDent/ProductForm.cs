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
    public partial class ProductForm : MaterialForm
    {
        private PrezidentClinicEntities db;

        public ProductForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Orange700, TextShade.WHITE);

            db = new PrezidentClinicEntities();
            db.type_product.Load();

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            var TypeProducs = db.type_product.ToList();

            foreach (var tp in TypeProducs)
            {
                TypeProduct.Items.Add(tp.name);
            }
        }
    }
}
