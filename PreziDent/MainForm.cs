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
    public partial class MainForm : MaterialForm
    {
        private user User;
        public void SetUser(user User)
        {
            this.User = User; 
        }
        public MainForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.LightGreen200, TextShade.WHITE);

            /* materialSkinManager.ROBOTO_MEDIUM_10 = new Font("Arial", 14);
             materialSkinManager.ROBOTO_MEDIUM_11 = new Font("Arial", 14);
             materialSkinManager.ROBOTO_MEDIUM_12 = new Font("Arial", 14);
             materialSkinManager.ROBOTO_REGULAR_11 = new Font("Arial", 14);*/
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonRoom9Orders_Click(object sender, EventArgs e)
        {
        }

        private void MainForm_Load(object sender, EventArgs e)
        {   
            switch (User.role_id)
            {
                case 1:
                    MainTabControl.TabPages.Remove(Room);
                break;
                case 2:
                    MainTabControl.TabPages.Remove(Rooms);
                break;
            }
        }
    }
}
