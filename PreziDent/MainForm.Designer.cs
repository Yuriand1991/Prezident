namespace PreziDent
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DateLabel = new MaterialSkin.Controls.MaterialLabel();
            this.MainDrawer = new MaterialSkin.Controls.MaterialDrawer();
            this.MainTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.MainPage = new System.Windows.Forms.TabPage();
            this.Room = new System.Windows.Forms.TabPage();
            this.SheduleDayCabinetViewLabel = new System.Windows.Forms.GroupBox();
            this.SheduleDayCabinetView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sheduleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namepatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatmentdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SheduleDayCabinetViewMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MyCabinetCalendar = new System.Windows.Forms.MonthCalendar();
            this.MyCabinetNumLabel = new MaterialSkin.Controls.MaterialLabel();
            this.Rooms = new System.Windows.Forms.TabPage();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Products = new System.Windows.Forms.TabPage();
            this.TypeProductButton = new MaterialSkin.Controls.MaterialButton();
            this.ChangeProductButton = new MaterialSkin.Controls.MaterialButton();
            this.DeleteProductButton = new MaterialSkin.Controls.MaterialButton();
            this.AddProductButton = new MaterialSkin.Controls.MaterialButton();
            this.ProductsView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Services = new System.Windows.Forms.TabPage();
            this.GroupServiceButton = new MaterialSkin.Controls.MaterialButton();
            this.DeleteServiceButton = new MaterialSkin.Controls.MaterialButton();
            this.ChangeServiceButton = new MaterialSkin.Controls.MaterialButton();
            this.AddServiceButton = new MaterialSkin.Controls.MaterialButton();
            this.ServicesView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeserviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupservicesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Patients = new System.Windows.Forms.TabPage();
            this.AboutPatientButton = new MaterialSkin.Controls.MaterialButton();
            this.DeletePatientButton = new MaterialSkin.Controls.MaterialButton();
            this.ChangePatientButton = new MaterialSkin.Controls.MaterialButton();
            this.AddPatientButton = new MaterialSkin.Controls.MaterialButton();
            this.PatientsView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.othernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainTabControl.SuspendLayout();
            this.Room.SuspendLayout();
            this.SheduleDayCabinetViewLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SheduleDayCabinetView)).BeginInit();
            this.SheduleDayCabinetViewMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentViewBindingSource)).BeginInit();
            this.Rooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.Services.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.Patients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DateLabel.Depth = 0;
            this.DateLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.DateLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.DateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DateLabel.Location = new System.Drawing.Point(460, 75);
            this.DateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(174, 29);
            this.DateLabel.TabIndex = 3;
            this.DateLabel.Text = "26 Ноября 2020";
            // 
            // MainDrawer
            // 
            this.MainDrawer.AutoHide = false;
            this.MainDrawer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.MainDrawer.BackgroundWithAccent = false;
            this.MainDrawer.BaseTabControl = this.MainTabControl;
            this.MainDrawer.Depth = 0;
            this.MainDrawer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MainDrawer.HighlightWithAccent = true;
            this.MainDrawer.IndicatorWidth = 0;
            this.MainDrawer.IsOpen = true;
            this.MainDrawer.Location = new System.Drawing.Point(0, 107);
            this.MainDrawer.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainDrawer.Name = "MainDrawer";
            this.MainDrawer.ShowIconsWhenHidden = false;
            this.MainDrawer.Size = new System.Drawing.Size(182, 431);
            this.MainDrawer.TabIndex = 2;
            this.MainDrawer.Text = "MainDrawer";
            this.MainDrawer.UseColors = false;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.MainPage);
            this.MainTabControl.Controls.Add(this.Room);
            this.MainTabControl.Controls.Add(this.Rooms);
            this.MainTabControl.Controls.Add(this.Products);
            this.MainTabControl.Controls.Add(this.Services);
            this.MainTabControl.Controls.Add(this.Patients);
            this.MainTabControl.Depth = 0;
            this.MainTabControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MainTabControl.Location = new System.Drawing.Point(188, 107);
            this.MainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainTabControl.Multiline = true;
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1008, 658);
            this.MainTabControl.TabIndex = 0;
            // 
            // MainPage
            // 
            this.MainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.MainPage.Location = new System.Drawing.Point(4, 22);
            this.MainPage.Name = "MainPage";
            this.MainPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainPage.Size = new System.Drawing.Size(1000, 632);
            this.MainPage.TabIndex = 0;
            this.MainPage.Text = "Главная";
            // 
            // Room
            // 
            this.Room.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Room.Controls.Add(this.SheduleDayCabinetViewLabel);
            this.Room.Controls.Add(this.MyCabinetCalendar);
            this.Room.Controls.Add(this.MyCabinetNumLabel);
            this.Room.Location = new System.Drawing.Point(4, 22);
            this.Room.Name = "Room";
            this.Room.Padding = new System.Windows.Forms.Padding(3);
            this.Room.Size = new System.Drawing.Size(1000, 632);
            this.Room.TabIndex = 2;
            this.Room.Text = "Мой кабинет";
            // 
            // SheduleDayCabinetViewLabel
            // 
            this.SheduleDayCabinetViewLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.SheduleDayCabinetViewLabel.Controls.Add(this.SheduleDayCabinetView);
            this.SheduleDayCabinetViewLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SheduleDayCabinetViewLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SheduleDayCabinetViewLabel.Location = new System.Drawing.Point(9, 183);
            this.SheduleDayCabinetViewLabel.Name = "SheduleDayCabinetViewLabel";
            this.SheduleDayCabinetViewLabel.Size = new System.Drawing.Size(984, 443);
            this.SheduleDayCabinetViewLabel.TabIndex = 4;
            this.SheduleDayCabinetViewLabel.TabStop = false;
            this.SheduleDayCabinetViewLabel.Text = "Записи на сегодня:";
            // 
            // SheduleDayCabinetView
            // 
            this.SheduleDayCabinetView.AllowUserToAddRows = false;
            this.SheduleDayCabinetView.AutoGenerateColumns = false;
            this.SheduleDayCabinetView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SheduleDayCabinetView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn3,
            this.sheduleidDataGridViewTextBoxColumn,
            this.patientidDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.roomidDataGridViewTextBoxColumn,
            this.starttimeDataGridViewTextBoxColumn,
            this.endtimeDataGridViewTextBoxColumn,
            this.namepatientDataGridViewTextBoxColumn,
            this.treatmentdescDataGridViewTextBoxColumn});
            this.SheduleDayCabinetView.ContextMenuStrip = this.SheduleDayCabinetViewMenuStrip;
            this.SheduleDayCabinetView.DataSource = this.appointmentViewBindingSource;
            this.SheduleDayCabinetView.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SheduleDayCabinetView.Location = new System.Drawing.Point(6, 23);
            this.SheduleDayCabinetView.Name = "SheduleDayCabinetView";
            this.SheduleDayCabinetView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SheduleDayCabinetView.Size = new System.Drawing.Size(972, 403);
            this.SheduleDayCabinetView.TabIndex = 0;
            this.SheduleDayCabinetView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SheduleDayCabinetView_CellMouseDown);
            this.SheduleDayCabinetView.DoubleClick += new System.EventHandler(this.SheduleDayCabinetView_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "id";
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            // 
            // sheduleidDataGridViewTextBoxColumn
            // 
            this.sheduleidDataGridViewTextBoxColumn.DataPropertyName = "shedule_id";
            this.sheduleidDataGridViewTextBoxColumn.HeaderText = "shedule_id";
            this.sheduleidDataGridViewTextBoxColumn.Name = "sheduleidDataGridViewTextBoxColumn";
            // 
            // patientidDataGridViewTextBoxColumn
            // 
            this.patientidDataGridViewTextBoxColumn.DataPropertyName = "patient_id";
            this.patientidDataGridViewTextBoxColumn.HeaderText = "patient_id";
            this.patientidDataGridViewTextBoxColumn.Name = "patientidDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Visible = false;
            // 
            // roomidDataGridViewTextBoxColumn
            // 
            this.roomidDataGridViewTextBoxColumn.DataPropertyName = "room_id";
            this.roomidDataGridViewTextBoxColumn.HeaderText = "room_id";
            this.roomidDataGridViewTextBoxColumn.Name = "roomidDataGridViewTextBoxColumn";
            this.roomidDataGridViewTextBoxColumn.Visible = false;
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
            // SheduleDayCabinetViewMenuStrip
            // 
            this.SheduleDayCabinetViewMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.SheduleDayCabinetViewMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteToolStripMenuItem});
            this.SheduleDayCabinetViewMenuStrip.Name = "SheduleDayCabinetViewMenuStrip";
            this.SheduleDayCabinetViewMenuStrip.Size = new System.Drawing.Size(119, 26);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // appointmentViewBindingSource
            // 
            this.appointmentViewBindingSource.DataSource = typeof(PreziDent.AppointmentView);
            // 
            // MyCabinetCalendar
            // 
            this.MyCabinetCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.MyCabinetCalendar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MyCabinetCalendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MyCabinetCalendar.Location = new System.Drawing.Point(9, 9);
            this.MyCabinetCalendar.MaxSelectionCount = 1;
            this.MyCabinetCalendar.Name = "MyCabinetCalendar";
            this.MyCabinetCalendar.TabIndex = 2;
            this.MyCabinetCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MyCabinetCalendar_DateChanged);
            // 
            // MyCabinetNumLabel
            // 
            this.MyCabinetNumLabel.AutoSize = true;
            this.MyCabinetNumLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.MyCabinetNumLabel.Depth = 0;
            this.MyCabinetNumLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.MyCabinetNumLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.MyCabinetNumLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MyCabinetNumLabel.Location = new System.Drawing.Point(357, 79);
            this.MyCabinetNumLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.MyCabinetNumLabel.Name = "MyCabinetNumLabel";
            this.MyCabinetNumLabel.Size = new System.Drawing.Size(126, 29);
            this.MyCabinetNumLabel.TabIndex = 1;
            this.MyCabinetNumLabel.Text = "Кабинет №";
            // 
            // Rooms
            // 
            this.Rooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Rooms.Controls.Add(this.materialButton1);
            this.Rooms.Controls.Add(this.dataGridView1);
            this.Rooms.Location = new System.Drawing.Point(4, 22);
            this.Rooms.Name = "Rooms";
            this.Rooms.Padding = new System.Windows.Forms.Padding(3);
            this.Rooms.Size = new System.Drawing.Size(1000, 632);
            this.Rooms.TabIndex = 1;
            this.Rooms.Text = "Кабинеты";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(704, 223);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(158, 36);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "materialButton1";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView1.Location = new System.Drawing.Point(426, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(255, 211);
            this.dataGridView1.TabIndex = 0;
            // 
            // Products
            // 
            this.Products.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Products.Controls.Add(this.TypeProductButton);
            this.Products.Controls.Add(this.ChangeProductButton);
            this.Products.Controls.Add(this.DeleteProductButton);
            this.Products.Controls.Add(this.AddProductButton);
            this.Products.Controls.Add(this.ProductsView);
            this.Products.Location = new System.Drawing.Point(4, 22);
            this.Products.Name = "Products";
            this.Products.Padding = new System.Windows.Forms.Padding(3);
            this.Products.Size = new System.Drawing.Size(1000, 632);
            this.Products.TabIndex = 3;
            this.Products.Text = "Товары";
            // 
            // TypeProductButton
            // 
            this.TypeProductButton.AutoSize = false;
            this.TypeProductButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TypeProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TypeProductButton.Depth = 0;
            this.TypeProductButton.DrawShadows = true;
            this.TypeProductButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TypeProductButton.HighEmphasis = true;
            this.TypeProductButton.Icon = null;
            this.TypeProductButton.Location = new System.Drawing.Point(797, 587);
            this.TypeProductButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TypeProductButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.TypeProductButton.Name = "TypeProductButton";
            this.TypeProductButton.Size = new System.Drawing.Size(185, 36);
            this.TypeProductButton.TabIndex = 4;
            this.TypeProductButton.Text = "Категории продуктов";
            this.TypeProductButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.TypeProductButton.UseAccentColor = false;
            this.TypeProductButton.UseVisualStyleBackColor = false;
            this.TypeProductButton.Click += new System.EventHandler(this.TypeProductButton_Click);
            // 
            // ChangeProductButton
            // 
            this.ChangeProductButton.AutoSize = false;
            this.ChangeProductButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChangeProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ChangeProductButton.Depth = 0;
            this.ChangeProductButton.DrawShadows = true;
            this.ChangeProductButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ChangeProductButton.HighEmphasis = true;
            this.ChangeProductButton.Icon = null;
            this.ChangeProductButton.Location = new System.Drawing.Point(797, 85);
            this.ChangeProductButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ChangeProductButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChangeProductButton.Name = "ChangeProductButton";
            this.ChangeProductButton.Size = new System.Drawing.Size(185, 36);
            this.ChangeProductButton.TabIndex = 3;
            this.ChangeProductButton.Text = "Изменить продукт";
            this.ChangeProductButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ChangeProductButton.UseAccentColor = false;
            this.ChangeProductButton.UseVisualStyleBackColor = false;
            this.ChangeProductButton.Click += new System.EventHandler(this.ChangeProductButton_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.AutoSize = false;
            this.DeleteProductButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteProductButton.Depth = 0;
            this.DeleteProductButton.DrawShadows = true;
            this.DeleteProductButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeleteProductButton.HighEmphasis = true;
            this.DeleteProductButton.Icon = null;
            this.DeleteProductButton.Location = new System.Drawing.Point(797, 150);
            this.DeleteProductButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteProductButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(185, 36);
            this.DeleteProductButton.TabIndex = 2;
            this.DeleteProductButton.Text = "Удалить продукт";
            this.DeleteProductButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeleteProductButton.UseAccentColor = false;
            this.DeleteProductButton.UseVisualStyleBackColor = false;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.AutoSize = false;
            this.AddProductButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddProductButton.Depth = 0;
            this.AddProductButton.DrawShadows = true;
            this.AddProductButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddProductButton.HighEmphasis = true;
            this.AddProductButton.Icon = null;
            this.AddProductButton.Location = new System.Drawing.Point(797, 19);
            this.AddProductButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddProductButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(185, 36);
            this.AddProductButton.TabIndex = 1;
            this.AddProductButton.Text = "Добавить продукт";
            this.AddProductButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddProductButton.UseAccentColor = false;
            this.AddProductButton.UseVisualStyleBackColor = false;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // ProductsView
            // 
            this.ProductsView.AllowUserToAddRows = false;
            this.ProductsView.AutoGenerateColumns = false;
            this.ProductsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.name,
            this.price,
            this.type_product});
            this.ProductsView.DataSource = this.productBindingSource;
            this.ProductsView.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProductsView.Location = new System.Drawing.Point(6, 6);
            this.ProductsView.Name = "ProductsView";
            this.ProductsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsView.Size = new System.Drawing.Size(769, 620);
            this.ProductsView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Наименование";
            this.name.Name = "name";
            this.name.Width = 300;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Цена";
            this.price.Name = "price";
            // 
            // type_product
            // 
            this.type_product.DataPropertyName = "type_product";
            this.type_product.HeaderText = "Категория продукта";
            this.type_product.Name = "type_product";
            this.type_product.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.type_product.Width = 300;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(PreziDent.product);
            // 
            // Services
            // 
            this.Services.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Services.Controls.Add(this.GroupServiceButton);
            this.Services.Controls.Add(this.DeleteServiceButton);
            this.Services.Controls.Add(this.ChangeServiceButton);
            this.Services.Controls.Add(this.AddServiceButton);
            this.Services.Controls.Add(this.ServicesView);
            this.Services.Location = new System.Drawing.Point(4, 22);
            this.Services.Name = "Services";
            this.Services.Padding = new System.Windows.Forms.Padding(3);
            this.Services.Size = new System.Drawing.Size(1000, 632);
            this.Services.TabIndex = 4;
            this.Services.Text = "Услуги";
            // 
            // GroupServiceButton
            // 
            this.GroupServiceButton.AutoSize = false;
            this.GroupServiceButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GroupServiceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.GroupServiceButton.Depth = 0;
            this.GroupServiceButton.DrawShadows = true;
            this.GroupServiceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GroupServiceButton.HighEmphasis = true;
            this.GroupServiceButton.Icon = null;
            this.GroupServiceButton.Location = new System.Drawing.Point(791, 587);
            this.GroupServiceButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GroupServiceButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.GroupServiceButton.Name = "GroupServiceButton";
            this.GroupServiceButton.Size = new System.Drawing.Size(185, 36);
            this.GroupServiceButton.TabIndex = 4;
            this.GroupServiceButton.Text = "Группа услуг";
            this.GroupServiceButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.GroupServiceButton.UseAccentColor = false;
            this.GroupServiceButton.UseVisualStyleBackColor = false;
            this.GroupServiceButton.Click += new System.EventHandler(this.GroupServiceButton_Click);
            // 
            // DeleteServiceButton
            // 
            this.DeleteServiceButton.AutoSize = false;
            this.DeleteServiceButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteServiceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteServiceButton.Depth = 0;
            this.DeleteServiceButton.DrawShadows = true;
            this.DeleteServiceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeleteServiceButton.HighEmphasis = true;
            this.DeleteServiceButton.Icon = null;
            this.DeleteServiceButton.Location = new System.Drawing.Point(791, 137);
            this.DeleteServiceButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteServiceButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteServiceButton.Name = "DeleteServiceButton";
            this.DeleteServiceButton.Size = new System.Drawing.Size(185, 36);
            this.DeleteServiceButton.TabIndex = 3;
            this.DeleteServiceButton.Text = "Удалить услугу";
            this.DeleteServiceButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeleteServiceButton.UseAccentColor = false;
            this.DeleteServiceButton.UseVisualStyleBackColor = false;
            this.DeleteServiceButton.Click += new System.EventHandler(this.DeleteServiceButton_Click);
            // 
            // ChangeServiceButton
            // 
            this.ChangeServiceButton.AutoSize = false;
            this.ChangeServiceButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChangeServiceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ChangeServiceButton.Depth = 0;
            this.ChangeServiceButton.DrawShadows = true;
            this.ChangeServiceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ChangeServiceButton.HighEmphasis = true;
            this.ChangeServiceButton.Icon = null;
            this.ChangeServiceButton.Location = new System.Drawing.Point(791, 78);
            this.ChangeServiceButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ChangeServiceButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChangeServiceButton.Name = "ChangeServiceButton";
            this.ChangeServiceButton.Size = new System.Drawing.Size(185, 36);
            this.ChangeServiceButton.TabIndex = 2;
            this.ChangeServiceButton.Text = "Изменить услугу";
            this.ChangeServiceButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ChangeServiceButton.UseAccentColor = false;
            this.ChangeServiceButton.UseVisualStyleBackColor = false;
            this.ChangeServiceButton.Click += new System.EventHandler(this.ChangeServiceButton_Click);
            // 
            // AddServiceButton
            // 
            this.AddServiceButton.AutoSize = false;
            this.AddServiceButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddServiceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddServiceButton.Depth = 0;
            this.AddServiceButton.DrawShadows = true;
            this.AddServiceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddServiceButton.HighEmphasis = true;
            this.AddServiceButton.Icon = null;
            this.AddServiceButton.Location = new System.Drawing.Point(791, 20);
            this.AddServiceButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddServiceButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddServiceButton.Name = "AddServiceButton";
            this.AddServiceButton.Size = new System.Drawing.Size(185, 36);
            this.AddServiceButton.TabIndex = 1;
            this.AddServiceButton.Text = "Добавить услугу";
            this.AddServiceButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddServiceButton.UseAccentColor = false;
            this.AddServiceButton.UseVisualStyleBackColor = false;
            this.AddServiceButton.Click += new System.EventHandler(this.AddServiceButton_Click);
            // 
            // ServicesView
            // 
            this.ServicesView.AllowUserToAddRows = false;
            this.ServicesView.AutoGenerateColumns = false;
            this.ServicesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServicesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.codeserviceDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.groupservicesDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.ServicesView.DataSource = this.serviceBindingSource;
            this.ServicesView.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ServicesView.Location = new System.Drawing.Point(6, 6);
            this.ServicesView.Name = "ServicesView";
            this.ServicesView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServicesView.Size = new System.Drawing.Size(769, 620);
            this.ServicesView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // codeserviceDataGridViewTextBoxColumn
            // 
            this.codeserviceDataGridViewTextBoxColumn.DataPropertyName = "code_service";
            this.codeserviceDataGridViewTextBoxColumn.HeaderText = "Код";
            this.codeserviceDataGridViewTextBoxColumn.Name = "codeserviceDataGridViewTextBoxColumn";
            this.codeserviceDataGridViewTextBoxColumn.Width = 70;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 170;
            // 
            // groupservicesDataGridViewTextBoxColumn
            // 
            this.groupservicesDataGridViewTextBoxColumn.DataPropertyName = "group_services";
            this.groupservicesDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.groupservicesDataGridViewTextBoxColumn.Name = "groupservicesDataGridViewTextBoxColumn";
            this.groupservicesDataGridViewTextBoxColumn.Width = 200;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 70;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 200;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataSource = typeof(PreziDent.service);
            // 
            // Patients
            // 
            this.Patients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Patients.Controls.Add(this.AboutPatientButton);
            this.Patients.Controls.Add(this.DeletePatientButton);
            this.Patients.Controls.Add(this.ChangePatientButton);
            this.Patients.Controls.Add(this.AddPatientButton);
            this.Patients.Controls.Add(this.PatientsView);
            this.Patients.Location = new System.Drawing.Point(4, 22);
            this.Patients.Name = "Patients";
            this.Patients.Padding = new System.Windows.Forms.Padding(3);
            this.Patients.Size = new System.Drawing.Size(1000, 632);
            this.Patients.TabIndex = 5;
            this.Patients.Text = "Пациенты";
            // 
            // AboutPatientButton
            // 
            this.AboutPatientButton.AutoSize = false;
            this.AboutPatientButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AboutPatientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AboutPatientButton.Depth = 0;
            this.AboutPatientButton.DrawShadows = true;
            this.AboutPatientButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AboutPatientButton.HighEmphasis = true;
            this.AboutPatientButton.Icon = null;
            this.AboutPatientButton.Location = new System.Drawing.Point(785, 26);
            this.AboutPatientButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AboutPatientButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AboutPatientButton.Name = "AboutPatientButton";
            this.AboutPatientButton.Size = new System.Drawing.Size(170, 36);
            this.AboutPatientButton.TabIndex = 4;
            this.AboutPatientButton.Text = "Подробно";
            this.AboutPatientButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AboutPatientButton.UseAccentColor = false;
            this.AboutPatientButton.UseVisualStyleBackColor = false;
            this.AboutPatientButton.Click += new System.EventHandler(this.AboutPatientButton_Click);
            // 
            // DeletePatientButton
            // 
            this.DeletePatientButton.AutoSize = false;
            this.DeletePatientButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeletePatientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeletePatientButton.Depth = 0;
            this.DeletePatientButton.DrawShadows = true;
            this.DeletePatientButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeletePatientButton.HighEmphasis = true;
            this.DeletePatientButton.Icon = null;
            this.DeletePatientButton.Location = new System.Drawing.Point(785, 211);
            this.DeletePatientButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeletePatientButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeletePatientButton.Name = "DeletePatientButton";
            this.DeletePatientButton.Size = new System.Drawing.Size(170, 36);
            this.DeletePatientButton.TabIndex = 3;
            this.DeletePatientButton.Text = "Удалить";
            this.DeletePatientButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeletePatientButton.UseAccentColor = false;
            this.DeletePatientButton.UseVisualStyleBackColor = false;
            this.DeletePatientButton.Click += new System.EventHandler(this.DeletePatientButton_Click);
            // 
            // ChangePatientButton
            // 
            this.ChangePatientButton.AutoSize = false;
            this.ChangePatientButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChangePatientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ChangePatientButton.Depth = 0;
            this.ChangePatientButton.DrawShadows = true;
            this.ChangePatientButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ChangePatientButton.HighEmphasis = true;
            this.ChangePatientButton.Icon = null;
            this.ChangePatientButton.Location = new System.Drawing.Point(785, 149);
            this.ChangePatientButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ChangePatientButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChangePatientButton.Name = "ChangePatientButton";
            this.ChangePatientButton.Size = new System.Drawing.Size(170, 36);
            this.ChangePatientButton.TabIndex = 2;
            this.ChangePatientButton.Text = "Изменить";
            this.ChangePatientButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ChangePatientButton.UseAccentColor = false;
            this.ChangePatientButton.UseVisualStyleBackColor = false;
            this.ChangePatientButton.Click += new System.EventHandler(this.ChangePatientButton_Click);
            // 
            // AddPatientButton
            // 
            this.AddPatientButton.AutoSize = false;
            this.AddPatientButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddPatientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddPatientButton.Depth = 0;
            this.AddPatientButton.DrawShadows = true;
            this.AddPatientButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddPatientButton.HighEmphasis = true;
            this.AddPatientButton.Icon = null;
            this.AddPatientButton.Location = new System.Drawing.Point(785, 87);
            this.AddPatientButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddPatientButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddPatientButton.Name = "AddPatientButton";
            this.AddPatientButton.Size = new System.Drawing.Size(170, 36);
            this.AddPatientButton.TabIndex = 1;
            this.AddPatientButton.Text = "Добавить";
            this.AddPatientButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddPatientButton.UseAccentColor = false;
            this.AddPatientButton.UseVisualStyleBackColor = false;
            this.AddPatientButton.Click += new System.EventHandler(this.AddPatientButton_Click);
            // 
            // PatientsView
            // 
            this.PatientsView.AllowUserToAddRows = false;
            this.PatientsView.AutoGenerateColumns = false;
            this.PatientsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.othernameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.regdateDataGridViewTextBoxColumn});
            this.PatientsView.DataSource = this.patientBindingSource;
            this.PatientsView.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PatientsView.Location = new System.Drawing.Point(6, 3);
            this.PatientsView.Name = "PatientsView";
            this.PatientsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PatientsView.Size = new System.Drawing.Size(759, 458);
            this.PatientsView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.Visible = false;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // othernameDataGridViewTextBoxColumn
            // 
            this.othernameDataGridViewTextBoxColumn.DataPropertyName = "other_name";
            this.othernameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.othernameDataGridViewTextBoxColumn.Name = "othernameDataGridViewTextBoxColumn";
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
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "День рождения";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // regdateDataGridViewTextBoxColumn
            // 
            this.regdateDataGridViewTextBoxColumn.DataPropertyName = "reg_date";
            this.regdateDataGridViewTextBoxColumn.HeaderText = "Дата регистрации";
            this.regdateDataGridViewTextBoxColumn.Name = "regdateDataGridViewTextBoxColumn";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(PreziDent.patient);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "type_product";
            this.dataGridViewTextBoxColumn1.HeaderText = "Категория продукта";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 777);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.MainDrawer);
            this.Controls.Add(this.MainTabControl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainTabControl.ResumeLayout(false);
            this.Room.ResumeLayout(false);
            this.Room.PerformLayout();
            this.SheduleDayCabinetViewLabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SheduleDayCabinetView)).EndInit();
            this.SheduleDayCabinetViewMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentViewBindingSource)).EndInit();
            this.Rooms.ResumeLayout(false);
            this.Rooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Products.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.Services.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServicesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.Patients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PatientsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl MainTabControl;
        private System.Windows.Forms.TabPage MainPage;
        private System.Windows.Forms.TabPage Rooms;
        private MaterialSkin.Controls.MaterialDrawer MainDrawer;
        private System.Windows.Forms.TabPage Room;
        private MaterialSkin.Controls.MaterialLabel DateLabel;
        private System.Windows.Forms.DataGridView SheduleDayCabinetView;
        private System.Windows.Forms.TabPage Products;
        private System.Windows.Forms.DataGridView ProductsView;
        private MaterialSkin.Controls.MaterialButton ChangeProductButton;
        private MaterialSkin.Controls.MaterialButton DeleteProductButton;
        private MaterialSkin.Controls.MaterialButton AddProductButton;
        private MaterialSkin.Controls.MaterialButton TypeProductButton;
        private System.Windows.Forms.BindingSource productBindingSource;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage Services;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_product;
        private System.Windows.Forms.DataGridView ServicesView;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeserviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupservicesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialButton GroupServiceButton;
        private MaterialSkin.Controls.MaterialButton DeleteServiceButton;
        private MaterialSkin.Controls.MaterialButton ChangeServiceButton;
        private MaterialSkin.Controls.MaterialButton AddServiceButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage Patients;
        private System.Windows.Forms.DataGridView PatientsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn othernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private MaterialSkin.Controls.MaterialButton DeletePatientButton;
        private MaterialSkin.Controls.MaterialButton ChangePatientButton;
        private MaterialSkin.Controls.MaterialButton AddPatientButton;
        private MaterialSkin.Controls.MaterialButton AboutPatientButton;
        private MaterialSkin.Controls.MaterialLabel MyCabinetNumLabel;
        private System.Windows.Forms.MonthCalendar MyCabinetCalendar;
        private System.Windows.Forms.GroupBox SheduleDayCabinetViewLabel;
        private System.Windows.Forms.BindingSource appointmentViewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn sheduleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namepatientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatmentdescDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip SheduleDayCabinetViewMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
    }
}

