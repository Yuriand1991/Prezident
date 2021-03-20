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
    public partial class LoginForm : PreziDent.AppFrom
    {
        public LoginForm()
        {
            InitializeComponent();
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

            using (PrezidentClinicEntities db = new PrezidentClinicEntities())
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
