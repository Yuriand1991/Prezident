
namespace PreziDent
{
    partial class PatientForm
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
            this.CnclButton = new MaterialSkin.Controls.MaterialButton();
            this.OkButton = new MaterialSkin.Controls.MaterialButton();
            this.StatusPatientLabel = new MaterialSkin.Controls.MaterialLabel();
            this.StatusPatient = new MaterialSkin.Controls.MaterialComboBox();
            this.statusespatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NotesPatientLabel = new MaterialSkin.Controls.MaterialLabel();
            this.NotesPatient = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.AddressPatientLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AddressPatient = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.NumberCardPatientLabel = new MaterialSkin.Controls.MaterialLabel();
            this.NumberCardPatient = new MaterialSkin.Controls.MaterialTextBox();
            this.RegistrationDatePatientLabel = new MaterialSkin.Controls.MaterialLabel();
            this.BirthDayPatientLabel = new MaterialSkin.Controls.MaterialLabel();
            this.EmailPatient = new MaterialSkin.Controls.MaterialTextBox();
            this.EmailPatientLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PhonePatientLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PhonePatient = new MaterialSkin.Controls.MaterialTextBox();
            this.OtherNamePatientLabel = new MaterialSkin.Controls.MaterialLabel();
            this.FirstPatientLabel = new MaterialSkin.Controls.MaterialLabel();
            this.LastNamePatientLabel = new MaterialSkin.Controls.MaterialLabel();
            this.RegistrationDatePatient = new System.Windows.Forms.DateTimePicker();
            this.BirthDayPatient = new System.Windows.Forms.DateTimePicker();
            this.OtherNamePatient = new MaterialSkin.Controls.MaterialTextBox();
            this.LastNamePatient = new MaterialSkin.Controls.MaterialTextBox();
            this.FirstNamePatient = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.statusespatientBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.CnclButton.Location = new System.Drawing.Point(106, 498);
            this.CnclButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CnclButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CnclButton.Name = "CnclButton";
            this.CnclButton.Size = new System.Drawing.Size(95, 36);
            this.CnclButton.TabIndex = 23;
            this.CnclButton.Text = "Отмена";
            this.CnclButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CnclButton.UseAccentColor = false;
            this.CnclButton.UseVisualStyleBackColor = false;
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
            this.OkButton.Location = new System.Drawing.Point(23, 498);
            this.OkButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OkButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(67, 36);
            this.OkButton.TabIndex = 22;
            this.OkButton.Text = "ОК";
            this.OkButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.OkButton.UseAccentColor = false;
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // StatusPatientLabel
            // 
            this.StatusPatientLabel.AutoSize = true;
            this.StatusPatientLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.StatusPatientLabel.Depth = 0;
            this.StatusPatientLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StatusPatientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StatusPatientLabel.Location = new System.Drawing.Point(258, 418);
            this.StatusPatientLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.StatusPatientLabel.Name = "StatusPatientLabel";
            this.StatusPatientLabel.Size = new System.Drawing.Size(56, 19);
            this.StatusPatientLabel.TabIndex = 21;
            this.StatusPatientLabel.Text = "Статус:";
            // 
            // StatusPatient
            // 
            this.StatusPatient.AutoResize = false;
            this.StatusPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.StatusPatient.DataSource = this.statusespatientBindingSource;
            this.StatusPatient.Depth = 0;
            this.StatusPatient.DisplayMember = "name";
            this.StatusPatient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.StatusPatient.DropDownHeight = 174;
            this.StatusPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusPatient.DropDownWidth = 121;
            this.StatusPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.StatusPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StatusPatient.FormattingEnabled = true;
            this.StatusPatient.IntegralHeight = false;
            this.StatusPatient.ItemHeight = 43;
            this.StatusPatient.Location = new System.Drawing.Point(261, 440);
            this.StatusPatient.MaxDropDownItems = 4;
            this.StatusPatient.MouseState = MaterialSkin.MouseState.OUT;
            this.StatusPatient.Name = "StatusPatient";
            this.StatusPatient.Size = new System.Drawing.Size(217, 49);
            this.StatusPatient.TabIndex = 20;
            this.StatusPatient.ValueMember = "id";
            // 
            // statusespatientBindingSource
            // 
            this.statusespatientBindingSource.DataSource = typeof(PreziDent.statuses_patient);
            // 
            // NotesPatientLabel
            // 
            this.NotesPatientLabel.AutoSize = true;
            this.NotesPatientLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.NotesPatientLabel.Depth = 0;
            this.NotesPatientLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NotesPatientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NotesPatientLabel.Location = new System.Drawing.Point(495, 294);
            this.NotesPatientLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.NotesPatientLabel.Name = "NotesPatientLabel";
            this.NotesPatientLabel.Size = new System.Drawing.Size(99, 19);
            this.NotesPatientLabel.TabIndex = 19;
            this.NotesPatientLabel.Text = "Примечания:";
            // 
            // NotesPatient
            // 
            this.NotesPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NotesPatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotesPatient.Depth = 0;
            this.NotesPatient.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NotesPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NotesPatient.Hint = "";
            this.NotesPatient.Location = new System.Drawing.Point(498, 316);
            this.NotesPatient.MouseState = MaterialSkin.MouseState.HOVER;
            this.NotesPatient.Name = "NotesPatient";
            this.NotesPatient.Size = new System.Drawing.Size(217, 218);
            this.NotesPatient.TabIndex = 18;
            this.NotesPatient.Text = "";
            // 
            // AddressPatientLabel
            // 
            this.AddressPatientLabel.AutoSize = true;
            this.AddressPatientLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddressPatientLabel.Depth = 0;
            this.AddressPatientLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AddressPatientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddressPatientLabel.Location = new System.Drawing.Point(258, 294);
            this.AddressPatientLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddressPatientLabel.Name = "AddressPatientLabel";
            this.AddressPatientLabel.Size = new System.Drawing.Size(50, 19);
            this.AddressPatientLabel.TabIndex = 17;
            this.AddressPatientLabel.Text = "Адрес:";
            // 
            // AddressPatient
            // 
            this.AddressPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddressPatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressPatient.Depth = 0;
            this.AddressPatient.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AddressPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddressPatient.Hint = "";
            this.AddressPatient.Location = new System.Drawing.Point(261, 316);
            this.AddressPatient.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddressPatient.Name = "AddressPatient";
            this.AddressPatient.Size = new System.Drawing.Size(217, 88);
            this.AddressPatient.TabIndex = 16;
            this.AddressPatient.Text = "";
            // 
            // NumberCardPatientLabel
            // 
            this.NumberCardPatientLabel.AutoSize = true;
            this.NumberCardPatientLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.NumberCardPatientLabel.Depth = 0;
            this.NumberCardPatientLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NumberCardPatientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NumberCardPatientLabel.Location = new System.Drawing.Point(495, 195);
            this.NumberCardPatientLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.NumberCardPatientLabel.Name = "NumberCardPatientLabel";
            this.NumberCardPatientLabel.Size = new System.Drawing.Size(185, 19);
            this.NumberCardPatientLabel.TabIndex = 15;
            this.NumberCardPatientLabel.Text = "№ амбулаторной карты:";
            // 
            // NumberCardPatient
            // 
            this.NumberCardPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.NumberCardPatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumberCardPatient.Depth = 0;
            this.NumberCardPatient.Font = new System.Drawing.Font("Roboto", 12F);
            this.NumberCardPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NumberCardPatient.Hint = "Введите № карты";
            this.NumberCardPatient.Location = new System.Drawing.Point(498, 217);
            this.NumberCardPatient.MaxLength = 50;
            this.NumberCardPatient.MouseState = MaterialSkin.MouseState.OUT;
            this.NumberCardPatient.Multiline = false;
            this.NumberCardPatient.Name = "NumberCardPatient";
            this.NumberCardPatient.Size = new System.Drawing.Size(217, 50);
            this.NumberCardPatient.TabIndex = 14;
            this.NumberCardPatient.Text = "";
            // 
            // RegistrationDatePatientLabel
            // 
            this.RegistrationDatePatientLabel.AutoSize = true;
            this.RegistrationDatePatientLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.RegistrationDatePatientLabel.Depth = 0;
            this.RegistrationDatePatientLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.RegistrationDatePatientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RegistrationDatePatientLabel.Location = new System.Drawing.Point(20, 418);
            this.RegistrationDatePatientLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegistrationDatePatientLabel.Name = "RegistrationDatePatientLabel";
            this.RegistrationDatePatientLabel.Size = new System.Drawing.Size(141, 19);
            this.RegistrationDatePatientLabel.TabIndex = 13;
            this.RegistrationDatePatientLabel.Text = "Дата регистрации:";
            // 
            // BirthDayPatientLabel
            // 
            this.BirthDayPatientLabel.AutoSize = true;
            this.BirthDayPatientLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BirthDayPatientLabel.Depth = 0;
            this.BirthDayPatientLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BirthDayPatientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BirthDayPatientLabel.Location = new System.Drawing.Point(20, 299);
            this.BirthDayPatientLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BirthDayPatientLabel.Name = "BirthDayPatientLabel";
            this.BirthDayPatientLabel.Size = new System.Drawing.Size(122, 19);
            this.BirthDayPatientLabel.TabIndex = 12;
            this.BirthDayPatientLabel.Text = "День рождения:";
            // 
            // EmailPatient
            // 
            this.EmailPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.EmailPatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailPatient.Depth = 0;
            this.EmailPatient.Font = new System.Drawing.Font("Roboto", 12F);
            this.EmailPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EmailPatient.Hint = "Введите E-mail";
            this.EmailPatient.Location = new System.Drawing.Point(261, 217);
            this.EmailPatient.MaxLength = 50;
            this.EmailPatient.MouseState = MaterialSkin.MouseState.OUT;
            this.EmailPatient.Multiline = false;
            this.EmailPatient.Name = "EmailPatient";
            this.EmailPatient.Size = new System.Drawing.Size(217, 50);
            this.EmailPatient.TabIndex = 11;
            this.EmailPatient.Text = "";
            // 
            // EmailPatientLabel
            // 
            this.EmailPatientLabel.AutoSize = true;
            this.EmailPatientLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.EmailPatientLabel.Depth = 0;
            this.EmailPatientLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EmailPatientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EmailPatientLabel.Location = new System.Drawing.Point(258, 195);
            this.EmailPatientLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.EmailPatientLabel.Name = "EmailPatientLabel";
            this.EmailPatientLabel.Size = new System.Drawing.Size(49, 19);
            this.EmailPatientLabel.TabIndex = 10;
            this.EmailPatientLabel.Text = "E-mail:";
            // 
            // PhonePatientLabel
            // 
            this.PhonePatientLabel.AutoSize = true;
            this.PhonePatientLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.PhonePatientLabel.Depth = 0;
            this.PhonePatientLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PhonePatientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PhonePatientLabel.Location = new System.Drawing.Point(20, 195);
            this.PhonePatientLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.PhonePatientLabel.Name = "PhonePatientLabel";
            this.PhonePatientLabel.Size = new System.Drawing.Size(70, 19);
            this.PhonePatientLabel.TabIndex = 9;
            this.PhonePatientLabel.Text = "Телефон:";
            // 
            // PhonePatient
            // 
            this.PhonePatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.PhonePatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhonePatient.Depth = 0;
            this.PhonePatient.Font = new System.Drawing.Font("Roboto", 12F);
            this.PhonePatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PhonePatient.Hint = "Введите телефон";
            this.PhonePatient.Location = new System.Drawing.Point(23, 217);
            this.PhonePatient.MaxLength = 50;
            this.PhonePatient.MouseState = MaterialSkin.MouseState.OUT;
            this.PhonePatient.Multiline = false;
            this.PhonePatient.Name = "PhonePatient";
            this.PhonePatient.Size = new System.Drawing.Size(217, 50);
            this.PhonePatient.TabIndex = 8;
            this.PhonePatient.Text = "";
            // 
            // OtherNamePatientLabel
            // 
            this.OtherNamePatientLabel.AutoSize = true;
            this.OtherNamePatientLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.OtherNamePatientLabel.Depth = 0;
            this.OtherNamePatientLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.OtherNamePatientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OtherNamePatientLabel.Location = new System.Drawing.Point(495, 91);
            this.OtherNamePatientLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.OtherNamePatientLabel.Name = "OtherNamePatientLabel";
            this.OtherNamePatientLabel.Size = new System.Drawing.Size(75, 19);
            this.OtherNamePatientLabel.TabIndex = 7;
            this.OtherNamePatientLabel.Text = "Отчество:";
            // 
            // FirstPatientLabel
            // 
            this.FirstPatientLabel.AutoSize = true;
            this.FirstPatientLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.FirstPatientLabel.Depth = 0;
            this.FirstPatientLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FirstPatientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FirstPatientLabel.Location = new System.Drawing.Point(258, 91);
            this.FirstPatientLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.FirstPatientLabel.Name = "FirstPatientLabel";
            this.FirstPatientLabel.Size = new System.Drawing.Size(37, 19);
            this.FirstPatientLabel.TabIndex = 6;
            this.FirstPatientLabel.Text = "Имя:";
            // 
            // LastNamePatientLabel
            // 
            this.LastNamePatientLabel.AutoSize = true;
            this.LastNamePatientLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LastNamePatientLabel.Depth = 0;
            this.LastNamePatientLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LastNamePatientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LastNamePatientLabel.Location = new System.Drawing.Point(20, 91);
            this.LastNamePatientLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.LastNamePatientLabel.Name = "LastNamePatientLabel";
            this.LastNamePatientLabel.Size = new System.Drawing.Size(74, 19);
            this.LastNamePatientLabel.TabIndex = 5;
            this.LastNamePatientLabel.Text = "Фамилия:";
            // 
            // RegistrationDatePatient
            // 
            this.RegistrationDatePatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.RegistrationDatePatient.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.RegistrationDatePatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RegistrationDatePatient.Location = new System.Drawing.Point(23, 440);
            this.RegistrationDatePatient.Name = "RegistrationDatePatient";
            this.RegistrationDatePatient.Size = new System.Drawing.Size(178, 24);
            this.RegistrationDatePatient.TabIndex = 4;
            // 
            // BirthDayPatient
            // 
            this.BirthDayPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BirthDayPatient.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BirthDayPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BirthDayPatient.Location = new System.Drawing.Point(23, 321);
            this.BirthDayPatient.Name = "BirthDayPatient";
            this.BirthDayPatient.Size = new System.Drawing.Size(178, 24);
            this.BirthDayPatient.TabIndex = 3;
            // 
            // OtherNamePatient
            // 
            this.OtherNamePatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.OtherNamePatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OtherNamePatient.Depth = 0;
            this.OtherNamePatient.Font = new System.Drawing.Font("Roboto", 12F);
            this.OtherNamePatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OtherNamePatient.Hint = "Введите отчество";
            this.OtherNamePatient.Location = new System.Drawing.Point(498, 113);
            this.OtherNamePatient.MaxLength = 50;
            this.OtherNamePatient.MouseState = MaterialSkin.MouseState.OUT;
            this.OtherNamePatient.Multiline = false;
            this.OtherNamePatient.Name = "OtherNamePatient";
            this.OtherNamePatient.Size = new System.Drawing.Size(217, 50);
            this.OtherNamePatient.TabIndex = 2;
            this.OtherNamePatient.Text = "";
            // 
            // LastNamePatient
            // 
            this.LastNamePatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LastNamePatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastNamePatient.Depth = 0;
            this.LastNamePatient.Font = new System.Drawing.Font("Roboto", 12F);
            this.LastNamePatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LastNamePatient.Hint = "Введите фамилию";
            this.LastNamePatient.Location = new System.Drawing.Point(23, 113);
            this.LastNamePatient.MaxLength = 50;
            this.LastNamePatient.MouseState = MaterialSkin.MouseState.OUT;
            this.LastNamePatient.Multiline = false;
            this.LastNamePatient.Name = "LastNamePatient";
            this.LastNamePatient.Size = new System.Drawing.Size(217, 50);
            this.LastNamePatient.TabIndex = 1;
            this.LastNamePatient.Text = "";
            // 
            // FirstNamePatient
            // 
            this.FirstNamePatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.FirstNamePatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstNamePatient.Depth = 0;
            this.FirstNamePatient.Font = new System.Drawing.Font("Roboto", 12F);
            this.FirstNamePatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FirstNamePatient.Hint = "Введите имя";
            this.FirstNamePatient.Location = new System.Drawing.Point(261, 113);
            this.FirstNamePatient.MaxLength = 50;
            this.FirstNamePatient.MouseState = MaterialSkin.MouseState.OUT;
            this.FirstNamePatient.Multiline = false;
            this.FirstNamePatient.Name = "FirstNamePatient";
            this.FirstNamePatient.Size = new System.Drawing.Size(217, 50);
            this.FirstNamePatient.TabIndex = 0;
            this.FirstNamePatient.Text = "";
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 572);
            this.Controls.Add(this.CnclButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.StatusPatientLabel);
            this.Controls.Add(this.StatusPatient);
            this.Controls.Add(this.NotesPatientLabel);
            this.Controls.Add(this.NotesPatient);
            this.Controls.Add(this.AddressPatientLabel);
            this.Controls.Add(this.AddressPatient);
            this.Controls.Add(this.NumberCardPatientLabel);
            this.Controls.Add(this.NumberCardPatient);
            this.Controls.Add(this.RegistrationDatePatientLabel);
            this.Controls.Add(this.BirthDayPatientLabel);
            this.Controls.Add(this.EmailPatient);
            this.Controls.Add(this.EmailPatientLabel);
            this.Controls.Add(this.PhonePatientLabel);
            this.Controls.Add(this.PhonePatient);
            this.Controls.Add(this.OtherNamePatientLabel);
            this.Controls.Add(this.FirstPatientLabel);
            this.Controls.Add(this.LastNamePatientLabel);
            this.Controls.Add(this.RegistrationDatePatient);
            this.Controls.Add(this.BirthDayPatient);
            this.Controls.Add(this.OtherNamePatient);
            this.Controls.Add(this.LastNamePatient);
            this.Controls.Add(this.FirstNamePatient);
            this.Name = "PatientForm";
            this.Text = "Пациент";
            ((System.ComponentModel.ISupportInitialize)(this.statusespatientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel LastNamePatientLabel;
        private MaterialSkin.Controls.MaterialLabel FirstPatientLabel;
        private MaterialSkin.Controls.MaterialLabel OtherNamePatientLabel;
        private MaterialSkin.Controls.MaterialLabel PhonePatientLabel;
        private MaterialSkin.Controls.MaterialLabel EmailPatientLabel;
        private MaterialSkin.Controls.MaterialLabel BirthDayPatientLabel;
        private MaterialSkin.Controls.MaterialLabel RegistrationDatePatientLabel;
        private MaterialSkin.Controls.MaterialLabel NumberCardPatientLabel;
        private MaterialSkin.Controls.MaterialLabel AddressPatientLabel;
        private MaterialSkin.Controls.MaterialLabel NotesPatientLabel;
        private MaterialSkin.Controls.MaterialLabel StatusPatientLabel;
        private MaterialSkin.Controls.MaterialButton OkButton;
        private MaterialSkin.Controls.MaterialButton CnclButton;
        private System.Windows.Forms.BindingSource statusespatientBindingSource;
        protected internal MaterialSkin.Controls.MaterialTextBox FirstNamePatient;
        protected internal MaterialSkin.Controls.MaterialTextBox LastNamePatient;
        protected internal MaterialSkin.Controls.MaterialTextBox OtherNamePatient;
        protected internal System.Windows.Forms.DateTimePicker BirthDayPatient;
        protected internal System.Windows.Forms.DateTimePicker RegistrationDatePatient;
        protected internal MaterialSkin.Controls.MaterialTextBox PhonePatient;
        protected internal MaterialSkin.Controls.MaterialTextBox EmailPatient;
        protected internal MaterialSkin.Controls.MaterialTextBox NumberCardPatient;
        protected internal MaterialSkin.Controls.MaterialMultiLineTextBox AddressPatient;
        protected internal MaterialSkin.Controls.MaterialMultiLineTextBox NotesPatient;
        protected internal MaterialSkin.Controls.MaterialComboBox StatusPatient;
    }
}