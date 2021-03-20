
namespace PreziDent
{
    partial class SurgeryForm
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
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PatientList = new System.Windows.Forms.ListBox();
            this.Patient = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SurgeryDateCall = new System.Windows.Forms.DateTimePicker();
            this.SurgeryDateCallLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SurgeryDataLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SurgeryData = new System.Windows.Forms.DateTimePicker();
            this.SurgeryDatePayLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SurgeryDatePay = new System.Windows.Forms.DateTimePicker();
            this.SurgeryDateTestLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SurgeryDateTest = new System.Windows.Forms.DateTimePicker();
            this.SurgeryIsOpen = new MaterialSkin.Controls.MaterialRadioButton();
            this.SurgeryIsClose = new MaterialSkin.Controls.MaterialRadioButton();
            this.OkButton = new MaterialSkin.Controls.MaterialButton();
            this.CnclButton = new MaterialSkin.Controls.MaterialButton();
            this.SurgeryName = new MaterialSkin.Controls.MaterialTextBox();
            this.SurgeryNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SurgeryCabinetNum = new MaterialSkin.Controls.MaterialComboBox();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(PreziDent.patient);
            // 
            // PatientList
            // 
            this.PatientList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.PatientList.DataSource = this.patientBindingSource;
            this.PatientList.DisplayMember = "full_name";
            this.PatientList.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PatientList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PatientList.FormattingEnabled = true;
            this.PatientList.ItemHeight = 17;
            this.PatientList.Location = new System.Drawing.Point(27, 149);
            this.PatientList.Name = "PatientList";
            this.PatientList.Size = new System.Drawing.Size(319, 89);
            this.PatientList.TabIndex = 3;
            this.PatientList.ValueMember = "id";
            this.PatientList.Visible = false;
            this.PatientList.Click += new System.EventHandler(this.PatientList_Click);
            this.PatientList.SelectedIndexChanged += new System.EventHandler(this.PatientList_SelectedIndexChanged);
            // 
            // Patient
            // 
            this.Patient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Patient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Patient.Depth = 0;
            this.Patient.Font = new System.Drawing.Font("Roboto", 12F);
            this.Patient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Patient.Hint = "Введите ФИО пациента";
            this.Patient.Location = new System.Drawing.Point(27, 95);
            this.Patient.MaxLength = 50;
            this.Patient.MouseState = MaterialSkin.MouseState.OUT;
            this.Patient.Multiline = false;
            this.Patient.Name = "Patient";
            this.Patient.Size = new System.Drawing.Size(319, 50);
            this.Patient.TabIndex = 4;
            this.Patient.Tag = "0";
            this.Patient.Text = "";
            this.Patient.TextChanged += new System.EventHandler(this.Patient_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(24, 73);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(68, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Пациент:";
            // 
            // SurgeryDateCall
            // 
            this.SurgeryDateCall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.SurgeryDateCall.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SurgeryDateCall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SurgeryDateCall.Location = new System.Drawing.Point(27, 346);
            this.SurgeryDateCall.Name = "SurgeryDateCall";
            this.SurgeryDateCall.Size = new System.Drawing.Size(171, 24);
            this.SurgeryDateCall.TabIndex = 6;
            // 
            // SurgeryDateCallLabel
            // 
            this.SurgeryDateCallLabel.AutoSize = true;
            this.SurgeryDateCallLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.SurgeryDateCallLabel.Depth = 0;
            this.SurgeryDateCallLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SurgeryDateCallLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SurgeryDateCallLabel.Location = new System.Drawing.Point(24, 324);
            this.SurgeryDateCallLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.SurgeryDateCallLabel.Name = "SurgeryDateCallLabel";
            this.SurgeryDateCallLabel.Size = new System.Drawing.Size(131, 19);
            this.SurgeryDateCallLabel.TabIndex = 7;
            this.SurgeryDateCallLabel.Text = "Дата обращения:";
            // 
            // SurgeryDataLabel
            // 
            this.SurgeryDataLabel.AutoSize = true;
            this.SurgeryDataLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.SurgeryDataLabel.Depth = 0;
            this.SurgeryDataLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SurgeryDataLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SurgeryDataLabel.Location = new System.Drawing.Point(24, 380);
            this.SurgeryDataLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.SurgeryDataLabel.Name = "SurgeryDataLabel";
            this.SurgeryDataLabel.Size = new System.Drawing.Size(118, 19);
            this.SurgeryDataLabel.TabIndex = 9;
            this.SurgeryDataLabel.Text = "Дата операции:";
            // 
            // SurgeryData
            // 
            this.SurgeryData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.SurgeryData.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SurgeryData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SurgeryData.Location = new System.Drawing.Point(27, 402);
            this.SurgeryData.Name = "SurgeryData";
            this.SurgeryData.Size = new System.Drawing.Size(171, 24);
            this.SurgeryData.TabIndex = 8;
            // 
            // SurgeryDatePayLabel
            // 
            this.SurgeryDatePayLabel.AutoSize = true;
            this.SurgeryDatePayLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.SurgeryDatePayLabel.Depth = 0;
            this.SurgeryDatePayLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SurgeryDatePayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SurgeryDatePayLabel.Location = new System.Drawing.Point(24, 445);
            this.SurgeryDatePayLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.SurgeryDatePayLabel.Name = "SurgeryDatePayLabel";
            this.SurgeryDatePayLabel.Size = new System.Drawing.Size(103, 19);
            this.SurgeryDatePayLabel.TabIndex = 11;
            this.SurgeryDatePayLabel.Text = "Дата оплаты:";
            // 
            // SurgeryDatePay
            // 
            this.SurgeryDatePay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.SurgeryDatePay.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SurgeryDatePay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SurgeryDatePay.Location = new System.Drawing.Point(27, 467);
            this.SurgeryDatePay.Name = "SurgeryDatePay";
            this.SurgeryDatePay.Size = new System.Drawing.Size(171, 24);
            this.SurgeryDatePay.TabIndex = 10;
            // 
            // SurgeryDateTestLabel
            // 
            this.SurgeryDateTestLabel.AutoSize = true;
            this.SurgeryDateTestLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.SurgeryDateTestLabel.Depth = 0;
            this.SurgeryDateTestLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SurgeryDateTestLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SurgeryDateTestLabel.Location = new System.Drawing.Point(24, 506);
            this.SurgeryDateTestLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.SurgeryDateTestLabel.Name = "SurgeryDateTestLabel";
            this.SurgeryDateTestLabel.Size = new System.Drawing.Size(118, 19);
            this.SurgeryDateTestLabel.TabIndex = 13;
            this.SurgeryDateTestLabel.Text = "Дата анализов:";
            // 
            // SurgeryDateTest
            // 
            this.SurgeryDateTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.SurgeryDateTest.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SurgeryDateTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SurgeryDateTest.Location = new System.Drawing.Point(27, 528);
            this.SurgeryDateTest.Name = "SurgeryDateTest";
            this.SurgeryDateTest.Size = new System.Drawing.Size(171, 24);
            this.SurgeryDateTest.TabIndex = 12;
            // 
            // SurgeryIsOpen
            // 
            this.SurgeryIsOpen.AutoSize = true;
            this.SurgeryIsOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.SurgeryIsOpen.Checked = true;
            this.SurgeryIsOpen.Depth = 0;
            this.SurgeryIsOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SurgeryIsOpen.Location = new System.Drawing.Point(27, 555);
            this.SurgeryIsOpen.Margin = new System.Windows.Forms.Padding(0);
            this.SurgeryIsOpen.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SurgeryIsOpen.MouseState = MaterialSkin.MouseState.HOVER;
            this.SurgeryIsOpen.Name = "SurgeryIsOpen";
            this.SurgeryIsOpen.Ripple = true;
            this.SurgeryIsOpen.Size = new System.Drawing.Size(101, 37);
            this.SurgeryIsOpen.TabIndex = 14;
            this.SurgeryIsOpen.TabStop = true;
            this.SurgeryIsOpen.Text = "Открыта";
            this.SurgeryIsOpen.UseVisualStyleBackColor = false;
            this.SurgeryIsOpen.CheckedChanged += new System.EventHandler(this.SurgeryIsOpen_CheckedChanged);
            this.SurgeryIsOpen.Click += new System.EventHandler(this.SurgeryIsOpen_Click);
            // 
            // SurgeryIsClose
            // 
            this.SurgeryIsClose.AutoSize = true;
            this.SurgeryIsClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.SurgeryIsClose.Depth = 0;
            this.SurgeryIsClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SurgeryIsClose.Location = new System.Drawing.Point(152, 555);
            this.SurgeryIsClose.Margin = new System.Windows.Forms.Padding(0);
            this.SurgeryIsClose.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SurgeryIsClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.SurgeryIsClose.Name = "SurgeryIsClose";
            this.SurgeryIsClose.Ripple = true;
            this.SurgeryIsClose.Size = new System.Drawing.Size(101, 37);
            this.SurgeryIsClose.TabIndex = 15;
            this.SurgeryIsClose.TabStop = true;
            this.SurgeryIsClose.Text = "Закрыта";
            this.SurgeryIsClose.UseVisualStyleBackColor = false;
            this.SurgeryIsClose.CheckedChanged += new System.EventHandler(this.SurgeryIsClose_CheckedChanged);
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
            this.OkButton.Location = new System.Drawing.Point(27, 613);
            this.OkButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OkButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(86, 36);
            this.OkButton.TabIndex = 16;
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
            this.CnclButton.Location = new System.Drawing.Point(132, 613);
            this.CnclButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CnclButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CnclButton.Name = "CnclButton";
            this.CnclButton.Size = new System.Drawing.Size(146, 36);
            this.CnclButton.TabIndex = 17;
            this.CnclButton.Text = "Отмена";
            this.CnclButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CnclButton.UseAccentColor = false;
            this.CnclButton.UseVisualStyleBackColor = false;
            // 
            // SurgeryName
            // 
            this.SurgeryName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.SurgeryName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SurgeryName.Depth = 0;
            this.SurgeryName.Font = new System.Drawing.Font("Roboto", 12F);
            this.SurgeryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SurgeryName.Hint = "Введите наименование операции";
            this.SurgeryName.Location = new System.Drawing.Point(27, 188);
            this.SurgeryName.MaxLength = 50;
            this.SurgeryName.MouseState = MaterialSkin.MouseState.OUT;
            this.SurgeryName.Multiline = false;
            this.SurgeryName.Name = "SurgeryName";
            this.SurgeryName.Size = new System.Drawing.Size(319, 50);
            this.SurgeryName.TabIndex = 18;
            this.SurgeryName.Text = "";
            // 
            // SurgeryNameLabel
            // 
            this.SurgeryNameLabel.AutoSize = true;
            this.SurgeryNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.SurgeryNameLabel.Depth = 0;
            this.SurgeryNameLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SurgeryNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SurgeryNameLabel.Location = new System.Drawing.Point(23, 166);
            this.SurgeryNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.SurgeryNameLabel.Name = "SurgeryNameLabel";
            this.SurgeryNameLabel.Size = new System.Drawing.Size(191, 19);
            this.SurgeryNameLabel.TabIndex = 19;
            this.SurgeryNameLabel.Text = "Наименование операции:";
            // 
            // SurgeryCabinetNum
            // 
            this.SurgeryCabinetNum.AutoResize = false;
            this.SurgeryCabinetNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.SurgeryCabinetNum.DataSource = this.roomBindingSource;
            this.SurgeryCabinetNum.Depth = 0;
            this.SurgeryCabinetNum.DisplayMember = "number";
            this.SurgeryCabinetNum.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.SurgeryCabinetNum.DropDownHeight = 174;
            this.SurgeryCabinetNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SurgeryCabinetNum.DropDownWidth = 121;
            this.SurgeryCabinetNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SurgeryCabinetNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SurgeryCabinetNum.FormattingEnabled = true;
            this.SurgeryCabinetNum.IntegralHeight = false;
            this.SurgeryCabinetNum.ItemHeight = 43;
            this.SurgeryCabinetNum.Location = new System.Drawing.Point(23, 263);
            this.SurgeryCabinetNum.MaxDropDownItems = 4;
            this.SurgeryCabinetNum.MouseState = MaterialSkin.MouseState.OUT;
            this.SurgeryCabinetNum.Name = "SurgeryCabinetNum";
            this.SurgeryCabinetNum.Size = new System.Drawing.Size(128, 49);
            this.SurgeryCabinetNum.TabIndex = 20;
            this.SurgeryCabinetNum.ValueMember = "id";
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(PreziDent.room);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(23, 241);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(128, 19);
            this.materialLabel2.TabIndex = 21;
            this.materialLabel2.Text = "Номер кабинета:";
            // 
            // SurgeryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 671);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.SurgeryCabinetNum);
            this.Controls.Add(this.PatientList);
            this.Controls.Add(this.CnclButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.SurgeryIsClose);
            this.Controls.Add(this.SurgeryIsOpen);
            this.Controls.Add(this.SurgeryDateTestLabel);
            this.Controls.Add(this.SurgeryDateTest);
            this.Controls.Add(this.SurgeryDatePayLabel);
            this.Controls.Add(this.SurgeryDatePay);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.Patient);
            this.Controls.Add(this.SurgeryDateCallLabel);
            this.Controls.Add(this.SurgeryDateCall);
            this.Controls.Add(this.SurgeryDataLabel);
            this.Controls.Add(this.SurgeryData);
            this.Controls.Add(this.SurgeryName);
            this.Controls.Add(this.SurgeryNameLabel);
            this.Name = "SurgeryForm";
            this.Text = "Запись на операцию";
            this.Shown += new System.EventHandler(this.SurgeryForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.ListBox PatientList;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel SurgeryDateCallLabel;
        private MaterialSkin.Controls.MaterialLabel SurgeryDataLabel;
        private MaterialSkin.Controls.MaterialLabel SurgeryDatePayLabel;
        private MaterialSkin.Controls.MaterialLabel SurgeryDateTestLabel;
        private MaterialSkin.Controls.MaterialButton OkButton;
        private MaterialSkin.Controls.MaterialButton CnclButton;
        protected internal MaterialSkin.Controls.MaterialTextBox Patient;
        protected internal System.Windows.Forms.DateTimePicker SurgeryDateCall;
        protected internal System.Windows.Forms.DateTimePicker SurgeryData;
        protected internal System.Windows.Forms.DateTimePicker SurgeryDatePay;
        protected internal System.Windows.Forms.DateTimePicker SurgeryDateTest;
        protected internal MaterialSkin.Controls.MaterialRadioButton SurgeryIsOpen;
        protected internal MaterialSkin.Controls.MaterialRadioButton SurgeryIsClose;
        protected internal MaterialSkin.Controls.MaterialTextBox SurgeryName;
        private MaterialSkin.Controls.MaterialLabel SurgeryNameLabel;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        protected internal MaterialSkin.Controls.MaterialComboBox SurgeryCabinetNum;
    }
}