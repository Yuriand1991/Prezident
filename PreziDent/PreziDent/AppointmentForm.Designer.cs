
namespace PreziDent
{
    partial class AppointmentForm
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
            this.PatientBox = new System.Windows.Forms.GroupBox();
            this.NamePatientLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PhonePatientLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PhonePatient = new MaterialSkin.Controls.MaterialTextBox();
            this.NamePatient = new MaterialSkin.Controls.MaterialTextBox();
            this.AppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.AppointmentDateLabel = new MaterialSkin.Controls.MaterialLabel();
            this.StartTime = new MaterialSkin.Controls.MaterialComboBox();
            this.sheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EndTime = new MaterialSkin.Controls.MaterialComboBox();
            this.sheduleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.StartTimeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.EntTimeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.DateTimeBox = new System.Windows.Forms.GroupBox();
            this.TreatmentBox = new System.Windows.Forms.GroupBox();
            this.Treatment = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.OkButton = new MaterialSkin.Controls.MaterialButton();
            this.CnclButton = new MaterialSkin.Controls.MaterialButton();
            this.PatientBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheduleBindingSource1)).BeginInit();
            this.DateTimeBox.SuspendLayout();
            this.TreatmentBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PatientBox
            // 
            this.PatientBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.PatientBox.Controls.Add(this.NamePatientLabel);
            this.PatientBox.Controls.Add(this.PhonePatientLabel);
            this.PatientBox.Controls.Add(this.PhonePatient);
            this.PatientBox.Controls.Add(this.NamePatient);
            this.PatientBox.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PatientBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PatientBox.Location = new System.Drawing.Point(44, 71);
            this.PatientBox.Name = "PatientBox";
            this.PatientBox.Size = new System.Drawing.Size(678, 203);
            this.PatientBox.TabIndex = 0;
            this.PatientBox.TabStop = false;
            this.PatientBox.Text = "Пациент:";
            // 
            // NamePatientLabel
            // 
            this.NamePatientLabel.AutoSize = true;
            this.NamePatientLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.NamePatientLabel.Depth = 0;
            this.NamePatientLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NamePatientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NamePatientLabel.Location = new System.Drawing.Point(24, 36);
            this.NamePatientLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.NamePatientLabel.Name = "NamePatientLabel";
            this.NamePatientLabel.Size = new System.Drawing.Size(39, 19);
            this.NamePatientLabel.TabIndex = 3;
            this.NamePatientLabel.Text = "ФИО:";
            // 
            // PhonePatientLabel
            // 
            this.PhonePatientLabel.AutoSize = true;
            this.PhonePatientLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.PhonePatientLabel.Depth = 0;
            this.PhonePatientLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PhonePatientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PhonePatientLabel.Location = new System.Drawing.Point(24, 153);
            this.PhonePatientLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.PhonePatientLabel.Name = "PhonePatientLabel";
            this.PhonePatientLabel.Size = new System.Drawing.Size(70, 19);
            this.PhonePatientLabel.TabIndex = 2;
            this.PhonePatientLabel.Text = "Телефон:";
            // 
            // PhonePatient
            // 
            this.PhonePatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.PhonePatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhonePatient.Depth = 0;
            this.PhonePatient.Font = new System.Drawing.Font("Roboto", 12F);
            this.PhonePatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PhonePatient.Hint = "Введите номер телефона";
            this.PhonePatient.Location = new System.Drawing.Point(182, 138);
            this.PhonePatient.MaxLength = 50;
            this.PhonePatient.MouseState = MaterialSkin.MouseState.OUT;
            this.PhonePatient.Multiline = false;
            this.PhonePatient.Name = "PhonePatient";
            this.PhonePatient.Size = new System.Drawing.Size(438, 50);
            this.PhonePatient.TabIndex = 1;
            this.PhonePatient.Text = "";
            // 
            // NamePatient
            // 
            this.NamePatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.NamePatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NamePatient.Depth = 0;
            this.NamePatient.Font = new System.Drawing.Font("Roboto", 12F);
            this.NamePatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NamePatient.Hint = "Введите ФИО пациента";
            this.NamePatient.Location = new System.Drawing.Point(25, 58);
            this.NamePatient.MaxLength = 50;
            this.NamePatient.MouseState = MaterialSkin.MouseState.OUT;
            this.NamePatient.Multiline = false;
            this.NamePatient.Name = "NamePatient";
            this.NamePatient.Size = new System.Drawing.Size(595, 50);
            this.NamePatient.TabIndex = 0;
            this.NamePatient.Text = "";
            // 
            // AppointmentDate
            // 
            this.AppointmentDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AppointmentDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AppointmentDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AppointmentDate.Location = new System.Drawing.Point(27, 62);
            this.AppointmentDate.Name = "AppointmentDate";
            this.AppointmentDate.Size = new System.Drawing.Size(200, 24);
            this.AppointmentDate.TabIndex = 1;
            // 
            // AppointmentDateLabel
            // 
            this.AppointmentDateLabel.AutoSize = true;
            this.AppointmentDateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AppointmentDateLabel.Depth = 0;
            this.AppointmentDateLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AppointmentDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AppointmentDateLabel.Location = new System.Drawing.Point(24, 40);
            this.AppointmentDateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AppointmentDateLabel.Name = "AppointmentDateLabel";
            this.AppointmentDateLabel.Size = new System.Drawing.Size(103, 19);
            this.AppointmentDateLabel.TabIndex = 2;
            this.AppointmentDateLabel.Text = "Дата приема:";
            // 
            // StartTime
            // 
            this.StartTime.AutoResize = false;
            this.StartTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.StartTime.DataSource = this.sheduleBindingSource;
            this.StartTime.Depth = 0;
            this.StartTime.DisplayMember = "start_time";
            this.StartTime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.StartTime.DropDownHeight = 174;
            this.StartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartTime.DropDownWidth = 121;
            this.StartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.StartTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StartTime.FormattingEnabled = true;
            this.StartTime.IntegralHeight = false;
            this.StartTime.ItemHeight = 43;
            this.StartTime.Location = new System.Drawing.Point(270, 62);
            this.StartTime.MaxDropDownItems = 4;
            this.StartTime.MouseState = MaterialSkin.MouseState.OUT;
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(121, 49);
            this.StartTime.TabIndex = 3;
            this.StartTime.ValueMember = "id";
            this.StartTime.SelectedIndexChanged += new System.EventHandler(this.StartTime_SelectedIndexChanged);
            // 
            // sheduleBindingSource
            // 
            this.sheduleBindingSource.DataSource = typeof(PreziDent.shedule);
            // 
            // EndTime
            // 
            this.EndTime.AutoResize = false;
            this.EndTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.EndTime.DataSource = this.sheduleBindingSource1;
            this.EndTime.Depth = 0;
            this.EndTime.DisplayMember = "end_time";
            this.EndTime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.EndTime.DropDownHeight = 174;
            this.EndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EndTime.DropDownWidth = 121;
            this.EndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.EndTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EndTime.FormattingEnabled = true;
            this.EndTime.IntegralHeight = false;
            this.EndTime.ItemHeight = 43;
            this.EndTime.Location = new System.Drawing.Point(443, 61);
            this.EndTime.MaxDropDownItems = 4;
            this.EndTime.MouseState = MaterialSkin.MouseState.OUT;
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(121, 49);
            this.EndTime.TabIndex = 4;
            this.EndTime.ValueMember = "id";
            // 
            // sheduleBindingSource1
            // 
            this.sheduleBindingSource1.DataSource = typeof(PreziDent.shedule);
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.StartTimeLabel.Depth = 0;
            this.StartTimeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StartTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StartTimeLabel.Location = new System.Drawing.Point(267, 40);
            this.StartTimeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(61, 19);
            this.StartTimeLabel.TabIndex = 5;
            this.StartTimeLabel.Text = "Начало:";
            // 
            // EntTimeLabel
            // 
            this.EntTimeLabel.AutoSize = true;
            this.EntTimeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.EntTimeLabel.Depth = 0;
            this.EntTimeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EntTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EntTimeLabel.Location = new System.Drawing.Point(440, 39);
            this.EntTimeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.EntTimeLabel.Name = "EntTimeLabel";
            this.EntTimeLabel.Size = new System.Drawing.Size(87, 19);
            this.EntTimeLabel.TabIndex = 6;
            this.EntTimeLabel.Text = "Окончание:";
            // 
            // DateTimeBox
            // 
            this.DateTimeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DateTimeBox.Controls.Add(this.EndTime);
            this.DateTimeBox.Controls.Add(this.EntTimeLabel);
            this.DateTimeBox.Controls.Add(this.AppointmentDate);
            this.DateTimeBox.Controls.Add(this.StartTimeLabel);
            this.DateTimeBox.Controls.Add(this.AppointmentDateLabel);
            this.DateTimeBox.Controls.Add(this.StartTime);
            this.DateTimeBox.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DateTimeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DateTimeBox.Location = new System.Drawing.Point(44, 280);
            this.DateTimeBox.Name = "DateTimeBox";
            this.DateTimeBox.Size = new System.Drawing.Size(678, 143);
            this.DateTimeBox.TabIndex = 7;
            this.DateTimeBox.TabStop = false;
            this.DateTimeBox.Text = "Дата и время:";
            // 
            // TreatmentBox
            // 
            this.TreatmentBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TreatmentBox.Controls.Add(this.Treatment);
            this.TreatmentBox.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TreatmentBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TreatmentBox.Location = new System.Drawing.Point(44, 440);
            this.TreatmentBox.Name = "TreatmentBox";
            this.TreatmentBox.Size = new System.Drawing.Size(678, 171);
            this.TreatmentBox.TabIndex = 8;
            this.TreatmentBox.TabStop = false;
            this.TreatmentBox.Text = "Лечение:";
            // 
            // Treatment
            // 
            this.Treatment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Treatment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Treatment.Depth = 0;
            this.Treatment.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Treatment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Treatment.Hint = "";
            this.Treatment.Location = new System.Drawing.Point(6, 23);
            this.Treatment.MouseState = MaterialSkin.MouseState.HOVER;
            this.Treatment.Name = "Treatment";
            this.Treatment.Size = new System.Drawing.Size(666, 142);
            this.Treatment.TabIndex = 0;
            this.Treatment.Text = "";
            // 
            // OkButton
            // 
            this.OkButton.AutoSize = false;
            this.OkButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.OkButton.Depth = 0;
            this.OkButton.DrawShadows = true;
            this.OkButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OkButton.HighEmphasis = true;
            this.OkButton.Icon = null;
            this.OkButton.Location = new System.Drawing.Point(477, 625);
            this.OkButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OkButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 36);
            this.OkButton.TabIndex = 9;
            this.OkButton.Text = "Ок";
            this.OkButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.OkButton.UseAccentColor = false;
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CnclButton
            // 
            this.CnclButton.AutoSize = false;
            this.CnclButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CnclButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CnclButton.Depth = 0;
            this.CnclButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CnclButton.DrawShadows = true;
            this.CnclButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CnclButton.HighEmphasis = true;
            this.CnclButton.Icon = null;
            this.CnclButton.Location = new System.Drawing.Point(574, 625);
            this.CnclButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CnclButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CnclButton.Name = "CnclButton";
            this.CnclButton.Size = new System.Drawing.Size(142, 36);
            this.CnclButton.TabIndex = 10;
            this.CnclButton.Text = "Отмена";
            this.CnclButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CnclButton.UseAccentColor = false;
            this.CnclButton.UseVisualStyleBackColor = false;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 676);
            this.Controls.Add(this.CnclButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.TreatmentBox);
            this.Controls.Add(this.DateTimeBox);
            this.Controls.Add(this.PatientBox);
            this.Name = "AppointmentForm";
            this.Text = "AppointmentForm";
            this.Shown += new System.EventHandler(this.AppointmentForm_Shown);
            this.PatientBox.ResumeLayout(false);
            this.PatientBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheduleBindingSource1)).EndInit();
            this.DateTimeBox.ResumeLayout(false);
            this.DateTimeBox.PerformLayout();
            this.TreatmentBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PatientBox;
        private MaterialSkin.Controls.MaterialLabel AppointmentDateLabel;
        protected internal MaterialSkin.Controls.MaterialTextBox NamePatient;
        private System.Windows.Forms.BindingSource sheduleBindingSource;
        private MaterialSkin.Controls.MaterialComboBox EndTime;
        private System.Windows.Forms.BindingSource sheduleBindingSource1;
        private MaterialSkin.Controls.MaterialLabel StartTimeLabel;
        private MaterialSkin.Controls.MaterialLabel EntTimeLabel;
        protected internal MaterialSkin.Controls.MaterialComboBox StartTime;
        private System.Windows.Forms.GroupBox DateTimeBox;
        protected internal MaterialSkin.Controls.MaterialMultiLineTextBox Treatment;
        protected internal System.Windows.Forms.DateTimePicker AppointmentDate;
        private MaterialSkin.Controls.MaterialButton OkButton;
        private MaterialSkin.Controls.MaterialButton CnclButton;
        private MaterialSkin.Controls.MaterialLabel NamePatientLabel;
        private MaterialSkin.Controls.MaterialLabel PhonePatientLabel;
        protected internal MaterialSkin.Controls.MaterialTextBox PhonePatient;
        protected internal System.Windows.Forms.GroupBox TreatmentBox;
    }
}