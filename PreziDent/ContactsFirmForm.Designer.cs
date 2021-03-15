
namespace PreziDent
{
    partial class ContactsFirmForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ContactsFirmView = new System.Windows.Forms.DataGridView();
            this.contactsfirmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddContactButton = new MaterialSkin.Controls.MaterialButton();
            this.ChangeContactButton = new MaterialSkin.Controls.MaterialButton();
            this.DeleteContactButton = new MaterialSkin.Controls.MaterialButton();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idfirmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsFirmView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsfirmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ContactsFirmView
            // 
            this.ContactsFirmView.AllowUserToAddRows = false;
            this.ContactsFirmView.AutoGenerateColumns = false;
            this.ContactsFirmView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContactsFirmView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firmDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.postDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.idfirmDataGridViewTextBoxColumn});
            this.ContactsFirmView.DataSource = this.contactsfirmBindingSource;
            this.ContactsFirmView.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ContactsFirmView.Location = new System.Drawing.Point(12, 70);
            this.ContactsFirmView.Name = "ContactsFirmView";
            this.ContactsFirmView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ContactsFirmView.Size = new System.Drawing.Size(970, 476);
            this.ContactsFirmView.TabIndex = 1;
            // 
            // contactsfirmBindingSource
            // 
            this.contactsfirmBindingSource.DataSource = typeof(PreziDent.contacts_firm);
            // 
            // AddContactButton
            // 
            this.AddContactButton.AutoSize = false;
            this.AddContactButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddContactButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddContactButton.Depth = 0;
            this.AddContactButton.DrawShadows = true;
            this.AddContactButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddContactButton.HighEmphasis = true;
            this.AddContactButton.Icon = null;
            this.AddContactButton.Location = new System.Drawing.Point(989, 70);
            this.AddContactButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddContactButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Size = new System.Drawing.Size(158, 36);
            this.AddContactButton.TabIndex = 2;
            this.AddContactButton.Text = "Добавить";
            this.AddContactButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddContactButton.UseAccentColor = false;
            this.AddContactButton.UseVisualStyleBackColor = false;
            this.AddContactButton.Click += new System.EventHandler(this.AddContactButton_Click);
            // 
            // ChangeContactButton
            // 
            this.ChangeContactButton.AutoSize = false;
            this.ChangeContactButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChangeContactButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ChangeContactButton.Depth = 0;
            this.ChangeContactButton.DrawShadows = true;
            this.ChangeContactButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ChangeContactButton.HighEmphasis = true;
            this.ChangeContactButton.Icon = null;
            this.ChangeContactButton.Location = new System.Drawing.Point(989, 118);
            this.ChangeContactButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ChangeContactButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChangeContactButton.Name = "ChangeContactButton";
            this.ChangeContactButton.Size = new System.Drawing.Size(158, 36);
            this.ChangeContactButton.TabIndex = 3;
            this.ChangeContactButton.Text = "Изменить";
            this.ChangeContactButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ChangeContactButton.UseAccentColor = false;
            this.ChangeContactButton.UseVisualStyleBackColor = false;
            this.ChangeContactButton.Click += new System.EventHandler(this.ChangeContactButton_Click);
            // 
            // DeleteContactButton
            // 
            this.DeleteContactButton.AutoSize = false;
            this.DeleteContactButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteContactButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteContactButton.Depth = 0;
            this.DeleteContactButton.DrawShadows = true;
            this.DeleteContactButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeleteContactButton.HighEmphasis = true;
            this.DeleteContactButton.Icon = null;
            this.DeleteContactButton.Location = new System.Drawing.Point(989, 166);
            this.DeleteContactButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteContactButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteContactButton.Name = "DeleteContactButton";
            this.DeleteContactButton.Size = new System.Drawing.Size(158, 36);
            this.DeleteContactButton.TabIndex = 4;
            this.DeleteContactButton.Text = "Удалить";
            this.DeleteContactButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeleteContactButton.UseAccentColor = false;
            this.DeleteContactButton.UseVisualStyleBackColor = false;
            this.DeleteContactButton.Click += new System.EventHandler(this.DeleteContactButton_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // firmDataGridViewTextBoxColumn
            // 
            this.firmDataGridViewTextBoxColumn.DataPropertyName = "firm";
            this.firmDataGridViewTextBoxColumn.HeaderText = "Фирма";
            this.firmDataGridViewTextBoxColumn.Name = "firmDataGridViewTextBoxColumn";
            this.firmDataGridViewTextBoxColumn.Visible = false;
            this.firmDataGridViewTextBoxColumn.Width = 200;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // postDataGridViewTextBoxColumn
            // 
            this.postDataGridViewTextBoxColumn.DataPropertyName = "post";
            this.postDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.postDataGridViewTextBoxColumn.Name = "postDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Отдел";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            // 
            // idfirmDataGridViewTextBoxColumn
            // 
            this.idfirmDataGridViewTextBoxColumn.DataPropertyName = "id_firm";
            this.idfirmDataGridViewTextBoxColumn.HeaderText = "id_firm";
            this.idfirmDataGridViewTextBoxColumn.Name = "idfirmDataGridViewTextBoxColumn";
            this.idfirmDataGridViewTextBoxColumn.Visible = false;
            // 
            // ContactsFirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 601);
            this.Controls.Add(this.DeleteContactButton);
            this.Controls.Add(this.ChangeContactButton);
            this.Controls.Add(this.AddContactButton);
            this.Controls.Add(this.ContactsFirmView);
            this.Name = "ContactsFirmForm";
            this.Text = "Все контакты";
            this.Shown += new System.EventHandler(this.ContactsFirmForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ContactsFirmView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsfirmBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource contactsfirmBindingSource;
        protected internal System.Windows.Forms.DataGridView ContactsFirmView;
        private MaterialSkin.Controls.MaterialButton AddContactButton;
        private MaterialSkin.Controls.MaterialButton ChangeContactButton;
        private MaterialSkin.Controls.MaterialButton DeleteContactButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfirmDataGridViewTextBoxColumn;
    }
}