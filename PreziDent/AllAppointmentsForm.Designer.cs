
namespace PreziDent
{
    partial class AllAppointmentsForm
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
            this.AllAppointmentsView = new System.Windows.Forms.DataGridView();
            this.appointmentViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DeleteAppointmentButton = new MaterialSkin.Controls.MaterialButton();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sheduleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namepatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatmentdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonepatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AllAppointmentsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AllAppointmentsView
            // 
            this.AllAppointmentsView.AllowUserToAddRows = false;
            this.AllAppointmentsView.AutoGenerateColumns = false;
            this.AllAppointmentsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllAppointmentsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.patientidDataGridViewTextBoxColumn,
            this.roomidDataGridViewTextBoxColumn,
            this.sheduleidDataGridViewTextBoxColumn,
            this.starttimeDataGridViewTextBoxColumn,
            this.endtimeDataGridViewTextBoxColumn,
            this.namepatientDataGridViewTextBoxColumn,
            this.treatmentdescDataGridViewTextBoxColumn,
            this.phonepatientDataGridViewTextBoxColumn});
            this.AllAppointmentsView.DataSource = this.appointmentViewBindingSource;
            this.AllAppointmentsView.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AllAppointmentsView.Location = new System.Drawing.Point(12, 70);
            this.AllAppointmentsView.Name = "AllAppointmentsView";
            this.AllAppointmentsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllAppointmentsView.Size = new System.Drawing.Size(836, 448);
            this.AllAppointmentsView.TabIndex = 0;
            // 
            // appointmentViewBindingSource
            // 
            this.appointmentViewBindingSource.DataSource = typeof(PreziDent.AppointmentView);
            // 
            // DeleteAppointmentButton
            // 
            this.DeleteAppointmentButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteAppointmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteAppointmentButton.Depth = 0;
            this.DeleteAppointmentButton.DrawShadows = true;
            this.DeleteAppointmentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeleteAppointmentButton.HighEmphasis = true;
            this.DeleteAppointmentButton.Icon = null;
            this.DeleteAppointmentButton.Location = new System.Drawing.Point(750, 527);
            this.DeleteAppointmentButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteAppointmentButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteAppointmentButton.Name = "DeleteAppointmentButton";
            this.DeleteAppointmentButton.Size = new System.Drawing.Size(91, 36);
            this.DeleteAppointmentButton.TabIndex = 1;
            this.DeleteAppointmentButton.Text = "Удалить";
            this.DeleteAppointmentButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeleteAppointmentButton.UseAccentColor = false;
            this.DeleteAppointmentButton.UseVisualStyleBackColor = false;
            this.DeleteAppointmentButton.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
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
            this.starttimeDataGridViewTextBoxColumn.Width = 70;
            // 
            // endtimeDataGridViewTextBoxColumn
            // 
            this.endtimeDataGridViewTextBoxColumn.DataPropertyName = "end_time";
            this.endtimeDataGridViewTextBoxColumn.HeaderText = "Конец";
            this.endtimeDataGridViewTextBoxColumn.Name = "endtimeDataGridViewTextBoxColumn";
            this.endtimeDataGridViewTextBoxColumn.Width = 70;
            // 
            // namepatientDataGridViewTextBoxColumn
            // 
            this.namepatientDataGridViewTextBoxColumn.DataPropertyName = "name_patient";
            this.namepatientDataGridViewTextBoxColumn.HeaderText = "Пациент";
            this.namepatientDataGridViewTextBoxColumn.Name = "namepatientDataGridViewTextBoxColumn";
            this.namepatientDataGridViewTextBoxColumn.Width = 200;
            // 
            // treatmentdescDataGridViewTextBoxColumn
            // 
            this.treatmentdescDataGridViewTextBoxColumn.DataPropertyName = "treatment_desc";
            this.treatmentdescDataGridViewTextBoxColumn.HeaderText = "Лечение";
            this.treatmentdescDataGridViewTextBoxColumn.Name = "treatmentdescDataGridViewTextBoxColumn";
            this.treatmentdescDataGridViewTextBoxColumn.Width = 200;
            // 
            // phonepatientDataGridViewTextBoxColumn
            // 
            this.phonepatientDataGridViewTextBoxColumn.DataPropertyName = "phone_patient";
            this.phonepatientDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phonepatientDataGridViewTextBoxColumn.Name = "phonepatientDataGridViewTextBoxColumn";
            this.phonepatientDataGridViewTextBoxColumn.Width = 150;
            // 
            // AllAppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 624);
            this.Controls.Add(this.DeleteAppointmentButton);
            this.Controls.Add(this.AllAppointmentsView);
            this.Name = "AllAppointmentsForm";
            this.Text = "Все записи на прием";
            ((System.ComponentModel.ISupportInitialize)(this.AllAppointmentsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AllAppointmentsView;
        private System.Windows.Forms.BindingSource appointmentViewBindingSource;
        private MaterialSkin.Controls.MaterialButton DeleteAppointmentButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sheduleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namepatientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatmentdescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonepatientDataGridViewTextBoxColumn;
    }
}