
namespace PreziDent
{
    partial class GroupsServicesForm
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
            this.GroupsServicesView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupservicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddGroupServiceButton = new MaterialSkin.Controls.MaterialButton();
            this.ChangeGroupServicesButton = new MaterialSkin.Controls.MaterialButton();
            this.DeleteGroupServiceslButton = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsServicesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupservicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupsServicesView
            // 
            this.GroupsServicesView.AllowUserToAddRows = false;
            this.GroupsServicesView.AutoGenerateColumns = false;
            this.GroupsServicesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupsServicesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.GroupsServicesView.DataSource = this.groupservicesBindingSource;
            this.GroupsServicesView.Location = new System.Drawing.Point(12, 77);
            this.GroupsServicesView.Name = "GroupsServicesView";
            this.GroupsServicesView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GroupsServicesView.Size = new System.Drawing.Size(575, 361);
            this.GroupsServicesView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 512;
            // 
            // groupservicesBindingSource
            // 
            this.groupservicesBindingSource.DataSource = typeof(PreziDent.group_services);
            // 
            // AddGroupServiceButton
            // 
            this.AddGroupServiceButton.AutoSize = false;
            this.AddGroupServiceButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddGroupServiceButton.Depth = 0;
            this.AddGroupServiceButton.DrawShadows = true;
            this.AddGroupServiceButton.HighEmphasis = true;
            this.AddGroupServiceButton.Icon = null;
            this.AddGroupServiceButton.Location = new System.Drawing.Point(603, 77);
            this.AddGroupServiceButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddGroupServiceButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddGroupServiceButton.Name = "AddGroupServiceButton";
            this.AddGroupServiceButton.Size = new System.Drawing.Size(133, 36);
            this.AddGroupServiceButton.TabIndex = 1;
            this.AddGroupServiceButton.Text = "Добавить";
            this.AddGroupServiceButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddGroupServiceButton.UseAccentColor = false;
            this.AddGroupServiceButton.UseVisualStyleBackColor = true;
            this.AddGroupServiceButton.Click += new System.EventHandler(this.AddGroupServiceButton_Click);
            // 
            // ChangeGroupServicesButton
            // 
            this.ChangeGroupServicesButton.AutoSize = false;
            this.ChangeGroupServicesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChangeGroupServicesButton.Depth = 0;
            this.ChangeGroupServicesButton.DrawShadows = true;
            this.ChangeGroupServicesButton.HighEmphasis = true;
            this.ChangeGroupServicesButton.Icon = null;
            this.ChangeGroupServicesButton.Location = new System.Drawing.Point(603, 125);
            this.ChangeGroupServicesButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ChangeGroupServicesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChangeGroupServicesButton.Name = "ChangeGroupServicesButton";
            this.ChangeGroupServicesButton.Size = new System.Drawing.Size(133, 36);
            this.ChangeGroupServicesButton.TabIndex = 2;
            this.ChangeGroupServicesButton.Text = "Изменить";
            this.ChangeGroupServicesButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ChangeGroupServicesButton.UseAccentColor = false;
            this.ChangeGroupServicesButton.UseVisualStyleBackColor = true;
            this.ChangeGroupServicesButton.Click += new System.EventHandler(this.ChangeGroupServicesButton_Click);
            // 
            // DeleteGroupServiceslButton
            // 
            this.DeleteGroupServiceslButton.AutoSize = false;
            this.DeleteGroupServiceslButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteGroupServiceslButton.Depth = 0;
            this.DeleteGroupServiceslButton.DrawShadows = true;
            this.DeleteGroupServiceslButton.HighEmphasis = true;
            this.DeleteGroupServiceslButton.Icon = null;
            this.DeleteGroupServiceslButton.Location = new System.Drawing.Point(603, 173);
            this.DeleteGroupServiceslButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteGroupServiceslButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteGroupServiceslButton.Name = "DeleteGroupServiceslButton";
            this.DeleteGroupServiceslButton.Size = new System.Drawing.Size(133, 36);
            this.DeleteGroupServiceslButton.TabIndex = 3;
            this.DeleteGroupServiceslButton.Text = "Удалить";
            this.DeleteGroupServiceslButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeleteGroupServiceslButton.UseAccentColor = false;
            this.DeleteGroupServiceslButton.UseVisualStyleBackColor = true;
            this.DeleteGroupServiceslButton.Click += new System.EventHandler(this.DeleteGroupServiceslButton_Click);
            // 
            // GroupsServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 450);
            this.Controls.Add(this.DeleteGroupServiceslButton);
            this.Controls.Add(this.ChangeGroupServicesButton);
            this.Controls.Add(this.AddGroupServiceButton);
            this.Controls.Add(this.GroupsServicesView);
            this.Name = "GroupsServicesForm";
            this.Text = "Группы услуг";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GroupsServicesForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.GroupsServicesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupservicesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GroupsServicesView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource groupservicesBindingSource;
        private MaterialSkin.Controls.MaterialButton AddGroupServiceButton;
        private MaterialSkin.Controls.MaterialButton ChangeGroupServicesButton;
        private MaterialSkin.Controls.MaterialButton DeleteGroupServiceslButton;
    }
}