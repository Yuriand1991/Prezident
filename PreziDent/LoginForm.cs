using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreziDent
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Orange700, TextShade.WHITE);
            
          /*  materialSkinManager.ROBOTO_MEDIUM_10 = new Font("Arial", 14);
            materialSkinManager.ROBOTO_MEDIUM_11 = new Font("Arial", 14);
            materialSkinManager.ROBOTO_MEDIUM_12 = new Font("Arial", 14);
            materialSkinManager.ROBOTO_REGULAR_11 = new Font("Arial", 14);*/
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var source = PasswordField.Text;
            
            String hash;

            // Creates an instance of the default implementation of the MD5 hash algorithm.
            using (var md5Hash = MD5.Create())
            {
                // Byte array representation of source string
                var sourceBytes = Encoding.UTF8.GetBytes(source);

                // Generate hash value(Byte Array) for input data
                var hashBytes = md5Hash.ComputeHash(sourceBytes);

                // Convert hash byte array to string
                hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);

                Console.WriteLine(hash);
            }

            using (ClinicContext db = new ClinicContext())
            {
                var us = db.users.Where(u => u.login == LoginField.Text).Where(u => u.password == hash);
                if (us.Count() > 0)
                {
                    var User = us.FirstOrDefault();
                    MainForm mainform = new MainForm();
                    mainform.Text = "Здравствуйте, " + User.first_name.Trim() + "!";
                    mainform.SetUser(User);
                    this.Hide();
                    mainform.Show();
                }
                else
                {
                    MessageBox.Show("Не правильный логин или пароль");
                }
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
