using MaterialSkin.Controls;
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
    public partial class GroupsServicesForm : MaterialForm
    {
        public GroupsServicesForm()
        {
            InitializeComponent();

            DataBase.db.group_services.Load();
            GroupsServicesView.DataSource = DataBase.db.group_services.Local.ToBindingList();
        }

        /********************************/
        /*Метод добавления группы услуг */
        /********************************/
        private void AddGroupServiceButton_Click(object sender, EventArgs e)
        {
            ControlAppForm.OpenAddGroupServicesForm(this);
            DataBase.db.group_services.Load();
        }

        /********************************/
        /*Метод изменения группы услуг  */
        /********************************/
        private void ChangeGroupServicesButton_Click(object sender, EventArgs e)
        {
            int index = GroupsServicesView.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(GroupsServicesView[0, index].Value.ToString(), out id);

            if (converted == false)
                return;

            group_services GroupServices = DataBase.db.group_services.Find(id);

            GroupServicesForm groupServicesForm = new GroupServicesForm();

            groupServicesForm.NameGroupServices.Text = GroupServices.name.Trim();

            DialogResult Result = groupServicesForm.ShowDialog(this);

            if (Result == DialogResult.Cancel)
                return;

            GroupServices.name = groupServicesForm.NameGroupServices.Text;

            DataBase.db.Entry(GroupServices).State = EntityState.Modified;

            DataBase.db.SaveChanges();

            GroupsServicesView.Refresh(); // обновляем грид*/
        }

        /********************************/
        /*Метод удаления группы услуг   */
        /********************************/
        private void DeleteGroupServiceslButton_Click(object sender, EventArgs e)
        {

            if (GroupsServicesView.RowCount > 0)
            {
                DialogResult Result = MessageBox.Show("Вы действительно хотите удалить?",
                                   "Confirmation", MessageBoxButtons.OKCancel,
                                   MessageBoxIcon.Information);
                if (Result == DialogResult.Cancel)
                    return;

                int index = GroupsServicesView.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(GroupsServicesView[0, index].Value.ToString(), out id);

                if (converted == false)
                    return;

                group_services GroupServices = DataBase.db.group_services.Find(id);
                DataBase.db.group_services.Remove(GroupServices);
                DataBase.db.Entry(GroupServices).State = EntityState.Deleted;
                DataBase.db.SaveChanges();
            }
            else
                MessageBox.Show("Таблица пуста!");
        }

        /********************/
        /*Закрытие формы    */
        /********************/
        private void GroupsServicesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;//Чтобы обновить грид услуг на главной форме
        }
    }
}
