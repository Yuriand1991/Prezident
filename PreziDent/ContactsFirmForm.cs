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
    public partial class ContactsFirmForm : PreziDent.AppFrom
    {
        public int FirmID { set; get; }
        public String FirmName { set; get; }
        public ContactsFirmForm()
        {
            InitializeComponent();

        }

        private void ContactsFirmForm_Shown(object sender, EventArgs e)
        {
            if (FirmID > 0)
            {
                this.Text = FirmName;
                ContactsFirmView.DataSource = DataBase.db.contacts_firm.Local.Where(c => c.id_firm == FirmID).ToList();
            }
            else
            {
                ContactsFirmView.DataSource = DataBase.db.contacts_firm.Local.ToBindingList();
            }
        }

        /****************************/
        /*  Добавить новый контакт  */
        /****************************/
        private void AddContactButton_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm();

            if (FirmID > 0)
            {
                contactForm.FirmContact.SelectedIndex = contactForm.FirmContact.FindStringExact(FirmName);
                contactForm.FirmContact.Enabled = false;
            }
            else
            {
                int index = ContactsFirmView.SelectedRows[0].Index;
                contactForm.FirmContact.SelectedIndex = contactForm.FirmContact.FindStringExact(ContactsFirmView[1, index].Value.ToString());
            }

            DialogResult Result = contactForm.ShowDialog(this);

            if (Result == DialogResult.Cancel)
                return;

            contacts_firm Contact = new contacts_firm
            {
                name = contactForm.NameContact.Text,
                department = contactForm.DepartmentContact.Text,
                email = contactForm.EmailContact.Text,
                post = contactForm.PostContact.Text,
                notes = contactForm.NotesContact.Text,
                phone = contactForm.PhoneContact.Text,
                id_firm = (int)contactForm.FirmContact.SelectedValue
            };

            DataBase.db.contacts_firm.Add(Contact);
            DataBase.db.Entry(Contact).State = EntityState.Added;
            DataBase.db.SaveChanges();

            if (FirmID > 0)
                ContactsFirmView.DataSource = DataBase.db.contacts_firm.Local.Where(c => c.id_firm == FirmID).ToList();
            
            ContactsFirmView.Refresh(); // обновляем грид
        }

        /****************************/
        /*  Изменить  контакт       */
        /****************************/
        private void ChangeContactButton_Click(object sender, EventArgs e)
        {
            if (ContactsFirmView.SelectedRows.Count > 0)
            {
                int index = ContactsFirmView.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(ContactsFirmView[0, index].Value.ToString(), out id);

                if (converted == false)
                    return;

                contacts_firm Contact = DataBase.db.contacts_firm.Find(id);

                ContactForm contactForm = new ContactForm();

                contactForm.NameContact.Text = Contact.name.Trim();
                contactForm.DepartmentContact.Text = Contact.department.Trim();
                contactForm.EmailContact.Text = Contact.email.Trim();
                contactForm.PostContact.Text = Contact.post.Trim();
                contactForm.NotesContact.Text = Contact.notes.Trim();
                contactForm.PhoneContact.Text = Contact.phone.Trim();
                
                if (FirmID > 0)
                    contactForm.FirmContact.SelectedIndex = contactForm.FirmContact.FindStringExact(FirmName);
                else
                {
                    contactForm.FirmContact.SelectedIndex = contactForm.FirmContact.FindStringExact(ContactsFirmView[1, index].Value.ToString());
                }

                DialogResult Result = contactForm.ShowDialog(this);

                if (Result == DialogResult.Cancel)
                    return;

                Contact.name = contactForm.NameContact.Text;
                Contact.department = contactForm.DepartmentContact.Text;
                Contact.email = contactForm.EmailContact.Text;
                Contact.post = contactForm.PostContact.Text;
                Contact.notes = contactForm.NotesContact.Text;
                Contact.phone = contactForm.PhoneContact.Text;
                int IdFirm = Contact.id_firm;
                Contact.id_firm = (int)contactForm.FirmContact.SelectedValue;

                DataBase.db.Entry(Contact).State = EntityState.Modified;
                DataBase.db.SaveChanges();

                if (FirmID > 0)
                {
                    ContactsFirmView.DataSource = DataBase.db.contacts_firm.Local.Where(c => c.id_firm == FirmID).ToList();
                    if (Contact.id_firm == IdFirm)
                        MainForm.SelectRowGrid(Contact.id, ContactsFirmView, 0);
                    else
                        MessageBox.Show("Контакт перенесен в другую фирму!");
                }

                ContactsFirmView.Refresh(); // обновляем грид
            }
        }

        /************************/
        /*  Удаление контака    */
        /************************/
        private void DeleteContactButton_Click(object sender, EventArgs e)
        {
            if (ContactsFirmView.RowCount > 0)
            {
                DialogResult Result = MessageBox.Show("Вы действительно хотите удалить?",
                                                   "Confirmation", MessageBoxButtons.OKCancel,
                                                   MessageBoxIcon.Information);
                if (Result == DialogResult.Cancel)
                    return;

                int index = ContactsFirmView.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(ContactsFirmView[0, index].Value.ToString(), out id);

                if (converted == false)
                    return;

                contacts_firm Contact = DataBase.db.contacts_firm.Find(id);
                DataBase.db.contacts_firm.Remove(Contact);
                DataBase.db.Entry(Contact).State = EntityState.Deleted;
                DataBase.db.SaveChanges();

                if (FirmID > 0)
                    ContactsFirmView.DataSource = DataBase.db.contacts_firm.Local.Where(c => c.id_firm == FirmID).ToList();

                ContactsFirmView.Refresh(); // обновляем грид
            }
        }
    }
}
