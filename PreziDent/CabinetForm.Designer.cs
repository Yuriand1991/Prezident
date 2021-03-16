
namespace PreziDent
{
    partial class CabinetForm
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
            this.CabinetView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sheduleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namepatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonepatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatmentdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.CabinetView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CabinetView
            // 
            this.CabinetView.AllowUserToAddRows = false;
            this.CabinetView.AutoGenerateColumns = false;
            this.CabinetView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CabinetView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.sheduleidDataGridViewTextBoxColumn,
            this.starttimeDataGridViewTextBoxColumn,
            this.endtimeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.patientidDataGridViewTextBoxColumn,
            this.roomidDataGridViewTextBoxColumn,
            this.roomnumDataGridViewTextBoxColumn,
            this.namepatientDataGridViewTextBoxColumn,
            this.phonepatientDataGridViewTextBoxColumn,
            this.treatmentdescDataGridViewTextBoxColumn});
            this.CabinetView.DataSource = this.appointmentViewBindingSource;
            this.CabinetView.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CabinetView.Location = new System.Drawing.Point(12, 120);
            this.CabinetView.Name = "CabinetView";
            this.CabinetView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CabinetView.Size = new System.Drawing.Size(844, 428);
            this.CabinetView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // sheduleidDataGridViewTextBoxColumn
            // 
            this.sheduleidDataGridViewTextBoxColumn.DataPropertyName = "shedule_id";
            this.sheduleidDataGridViewTextBoxColumn.HeaderText = "shedule_id";
            this.sheduleidDataGridViewTextBoxColumn.Name = "sheduleidDataGridViewTextBoxColumn";
            this.sheduleidDataGridViewTextBoxColumn.Visible = false;
            // 
            // starttimeDataGridViewTextBoxColumn
            // 
            this.starttimeDataGridViewTextBoxColumn.DataPropertyName = "start_time";
            this.starttimeDataGridViewTextBoxColumn.HeaderText = "Начало";
            this.starttimeDataGridViewTextBoxColumn.Name = "starttimeDataGridViewTextBoxColumn";
            // 
            // endtimeDataGridViewTextBoxColumn
            // 
            this.endtimeDataGridViewTextBoxColumn.DataPropertyName = "end_time";
            this.endtimeDataGridViewTextBoxColumn.HeaderText = "Окончание";
            this.endtimeDataGridViewTextBoxColumn.Name = "endtimeDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Visible = false;
            // 
            // patientidDataGridViewTextBoxColumn
            // 
            this.patientidDataGridViewTextBoxColumn.DataPropertyName = "patient_id";
            this.patientidDataGridViewTextBoxColumn.HeaderText = "patient_id";
            this.patientidDataGridViewTextBoxColumn.Name = "patientidDataGridViewTextBoxColumn";
            this.patientidDataGridViewTextBoxColumn.Visible = false;
            // 
            // roomidDataGridViewTextBoxColumn
            // 
            this.roomidDataGridViewTextBoxColumn.DataPropertyName = "room_id";
            this.roomidDataGridViewTextBoxColumn.HeaderText = "room_id";
            this.roomidDataGridViewTextBoxColumn.Name = "roomidDataGridViewTextBoxColumn";
            this.roomidDataGridViewTextBoxColumn.Visible = false;
            // 
            // roomnumDataGridViewTextBoxColumn
            // 
            this.roomnumDataGridViewTextBoxColumn.DataPropertyName = "room_num";
            this.roomnumDataGridViewTextBoxColumn.HeaderText = "room_num";
            this.roomnumDataGridViewTextBoxColumn.Name = "roomnumDataGridViewTextBoxColumn";
            this.roomnumDataGridViewTextBoxColumn.Visible = false;
            // 
            // namepatientDataGridViewTextBoxColumn
            // 
            this.namepatientDataGridViewTextBoxColumn.DataPropertyName = "name_patient";
            this.namepatientDataGridViewTextBoxColumn.HeaderText = "Пациент";
            this.namepatientDataGridViewTextBoxColumn.Name = "namepatientDataGridViewTextBoxColumn";
            this.namepatientDataGridViewTextBoxColumn.Width = 200;
            // 
            // phonepatientDataGridViewTextBoxColumn
            // 
            this.phonepatientDataGridViewTextBoxColumn.DataPropertyName = "phone_patient";
            this.phonepatientDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phonepatientDataGridViewTextBoxColumn.Name = "phonepatientDataGridViewTextBoxColumn";
            this.phonepatientDataGridViewTextBoxColumn.Width = 150;
            // 
            // treatmentdescDataGridViewTextBoxColumn
            // 
            this.treatmentdescDataGridViewTextBoxColumn.DataPropertyName = "treatment_desc";
            this.treatmentdescDataGridViewTextBoxColumn.HeaderText = "Лечение";
            this.treatmentdescDataGridViewTextBoxColumn.Name = "treatmentdescDataGridViewTextBoxColumn";
            this.treatmentdescDataGridViewTextBoxColumn.Width = 250;
            // 
            // appointmentViewBindingSource
            // 
            this.appointmentViewBindingSource.DataSource = typeof(PreziDent.AppointmentView);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dateTimePicker.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dateTimePicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dateTimePicker.Location = new System.Drawing.Point(319, 81);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker.TabIndex = 2;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // CabinetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 560);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.CabinetView);
            this.Name = "CabinetForm";
            this.Text = "CabinetForm";
            this.Shown += new System.EventHandler(this.CabinetForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.CabinetView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource appointmentViewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sheduleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namepatientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonepatientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatmentdescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        protected internal System.Windows.Forms.DataGridView CabinetView;
    }
}