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
            this.PlanCard = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.OrdersOfRoomsCard = new MaterialSkin.Controls.MaterialCard();
            this.ButtonRoom2Orders = new MaterialSkin.Controls.MaterialButton();
            this.ButtonRoom1Orders = new MaterialSkin.Controls.MaterialButton();
            this.ButtonRoom9Orders = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Rooms = new System.Windows.Forms.TabPage();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Room = new System.Windows.Forms.TabPage();
            this.SheduleView = new System.Windows.Forms.DataGridView();
            this.Products = new System.Windows.Forms.TabPage();
            this.TypeProductButton = new MaterialSkin.Controls.MaterialButton();
            this.ChangeProductButton = new MaterialSkin.Controls.MaterialButton();
            this.DeleteProductButton = new MaterialSkin.Controls.MaterialButton();
            this.AddProductButton = new MaterialSkin.Controls.MaterialButton();
            this.ProductsView = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeproductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeproductBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainTabControl.SuspendLayout();
            this.MainPage.SuspendLayout();
            this.PlanCard.SuspendLayout();
            this.OrdersOfRoomsCard.SuspendLayout();
            this.Rooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.Room.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SheduleView)).BeginInit();
            this.Products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeproductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeproductBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
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
            this.MainDrawer.Size = new System.Drawing.Size(250, 431);
            this.MainDrawer.TabIndex = 2;
            this.MainDrawer.Text = "MainDrawer";
            this.MainDrawer.UseColors = false;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.MainPage);
            this.MainTabControl.Controls.Add(this.Rooms);
            this.MainTabControl.Controls.Add(this.Room);
            this.MainTabControl.Controls.Add(this.Products);
            this.MainTabControl.Depth = 0;
            this.MainTabControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MainTabControl.Location = new System.Drawing.Point(256, 107);
            this.MainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainTabControl.Multiline = true;
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(926, 658);
            this.MainTabControl.TabIndex = 0;
            // 
            // MainPage
            // 
            this.MainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.MainPage.Controls.Add(this.PlanCard);
            this.MainPage.Controls.Add(this.OrdersOfRoomsCard);
            this.MainPage.Location = new System.Drawing.Point(4, 22);
            this.MainPage.Name = "MainPage";
            this.MainPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainPage.Size = new System.Drawing.Size(918, 632);
            this.MainPage.TabIndex = 0;
            this.MainPage.Text = "Главная";
            // 
            // PlanCard
            // 
            this.PlanCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PlanCard.Controls.Add(this.materialLabel2);
            this.PlanCard.Depth = 0;
            this.PlanCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PlanCard.Location = new System.Drawing.Point(335, 70);
            this.PlanCard.Margin = new System.Windows.Forms.Padding(14);
            this.PlanCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.PlanCard.Name = "PlanCard";
            this.PlanCard.Padding = new System.Windows.Forms.Padding(14);
            this.PlanCard.Size = new System.Drawing.Size(294, 209);
            this.PlanCard.TabIndex = 1;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(108, 14);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(64, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Планинг";
            // 
            // OrdersOfRoomsCard
            // 
            this.OrdersOfRoomsCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OrdersOfRoomsCard.Controls.Add(this.ButtonRoom2Orders);
            this.OrdersOfRoomsCard.Controls.Add(this.ButtonRoom1Orders);
            this.OrdersOfRoomsCard.Controls.Add(this.ButtonRoom9Orders);
            this.OrdersOfRoomsCard.Controls.Add(this.materialLabel1);
            this.OrdersOfRoomsCard.Depth = 0;
            this.OrdersOfRoomsCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OrdersOfRoomsCard.Location = new System.Drawing.Point(53, 70);
            this.OrdersOfRoomsCard.Margin = new System.Windows.Forms.Padding(14);
            this.OrdersOfRoomsCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.OrdersOfRoomsCard.Name = "OrdersOfRoomsCard";
            this.OrdersOfRoomsCard.Padding = new System.Windows.Forms.Padding(14);
            this.OrdersOfRoomsCard.Size = new System.Drawing.Size(176, 209);
            this.OrdersOfRoomsCard.TabIndex = 0;
            // 
            // ButtonRoom2Orders
            // 
            this.ButtonRoom2Orders.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonRoom2Orders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ButtonRoom2Orders.Depth = 0;
            this.ButtonRoom2Orders.DrawShadows = true;
            this.ButtonRoom2Orders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonRoom2Orders.HighEmphasis = true;
            this.ButtonRoom2Orders.Icon = null;
            this.ButtonRoom2Orders.Location = new System.Drawing.Point(33, 147);
            this.ButtonRoom2Orders.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonRoom2Orders.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonRoom2Orders.Name = "ButtonRoom2Orders";
            this.ButtonRoom2Orders.Size = new System.Drawing.Size(115, 36);
            this.ButtonRoom2Orders.TabIndex = 3;
            this.ButtonRoom2Orders.Text = "Кабинет №2";
            this.ButtonRoom2Orders.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonRoom2Orders.UseAccentColor = false;
            this.ButtonRoom2Orders.UseVisualStyleBackColor = false;
            // 
            // ButtonRoom1Orders
            // 
            this.ButtonRoom1Orders.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonRoom1Orders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ButtonRoom1Orders.Depth = 0;
            this.ButtonRoom1Orders.DrawShadows = true;
            this.ButtonRoom1Orders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonRoom1Orders.HighEmphasis = true;
            this.ButtonRoom1Orders.Icon = null;
            this.ButtonRoom1Orders.Location = new System.Drawing.Point(33, 99);
            this.ButtonRoom1Orders.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonRoom1Orders.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonRoom1Orders.Name = "ButtonRoom1Orders";
            this.ButtonRoom1Orders.Size = new System.Drawing.Size(115, 36);
            this.ButtonRoom1Orders.TabIndex = 2;
            this.ButtonRoom1Orders.Text = "Кабинет №1";
            this.ButtonRoom1Orders.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonRoom1Orders.UseAccentColor = false;
            this.ButtonRoom1Orders.UseVisualStyleBackColor = false;
            // 
            // ButtonRoom9Orders
            // 
            this.ButtonRoom9Orders.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonRoom9Orders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ButtonRoom9Orders.Depth = 0;
            this.ButtonRoom9Orders.DrawShadows = true;
            this.ButtonRoom9Orders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonRoom9Orders.HighEmphasis = true;
            this.ButtonRoom9Orders.Icon = null;
            this.ButtonRoom9Orders.Location = new System.Drawing.Point(33, 51);
            this.ButtonRoom9Orders.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonRoom9Orders.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonRoom9Orders.Name = "ButtonRoom9Orders";
            this.ButtonRoom9Orders.Size = new System.Drawing.Size(115, 36);
            this.ButtonRoom9Orders.TabIndex = 1;
            this.ButtonRoom9Orders.Text = "Кабинет №9";
            this.ButtonRoom9Orders.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonRoom9Orders.UseAccentColor = false;
            this.ButtonRoom9Orders.UseVisualStyleBackColor = false;
            this.ButtonRoom9Orders.Click += new System.EventHandler(this.ButtonRoom9Orders_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(17, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(58, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Заказы";
            // 
            // Rooms
            // 
            this.Rooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Rooms.Controls.Add(this.materialButton1);
            this.Rooms.Controls.Add(this.dataGridView1);
            this.Rooms.Location = new System.Drawing.Point(4, 22);
            this.Rooms.Name = "Rooms";
            this.Rooms.Padding = new System.Windows.Forms.Padding(3);
            this.Rooms.Size = new System.Drawing.Size(918, 632);
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
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.numberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.roomBindingSource;
            this.dataGridView1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView1.Location = new System.Drawing.Point(426, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(255, 211);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(PreziDent.room);
            // 
            // Room
            // 
            this.Room.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Room.Controls.Add(this.SheduleView);
            this.Room.Location = new System.Drawing.Point(4, 22);
            this.Room.Name = "Room";
            this.Room.Padding = new System.Windows.Forms.Padding(3);
            this.Room.Size = new System.Drawing.Size(918, 632);
            this.Room.TabIndex = 2;
            this.Room.Text = "Мой кабинет";
            // 
            // SheduleView
            // 
            this.SheduleView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SheduleView.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SheduleView.Location = new System.Drawing.Point(59, 45);
            this.SheduleView.Name = "SheduleView";
            this.SheduleView.Size = new System.Drawing.Size(518, 364);
            this.SheduleView.TabIndex = 0;
            this.SheduleView.Paint += new System.Windows.Forms.PaintEventHandler(this.SheduleView_Paint);
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
            this.Products.Size = new System.Drawing.Size(918, 632);
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
            this.TypeProductButton.Location = new System.Drawing.Point(717, 423);
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
            this.ChangeProductButton.Location = new System.Drawing.Point(717, 85);
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
            this.DeleteProductButton.Location = new System.Drawing.Point(717, 142);
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
            this.AddProductButton.Location = new System.Drawing.Point(717, 24);
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
            this.ProductsView.Size = new System.Drawing.Size(704, 430);
            this.ProductsView.TabIndex = 0;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(PreziDent.product);
            // 
            // typeproductBindingSource
            // 
            this.typeproductBindingSource.DataSource = typeof(PreziDent.type_product);
            // 
            // typeproductBindingSource1
            // 
            this.typeproductBindingSource1.DataSource = typeof(PreziDent.type_product);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(PreziDent.user);
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(PreziDent.product);
            // 
            // productBindingSource2
            // 
            this.productBindingSource2.DataSource = typeof(PreziDent.product);
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
            this.name.Width = 256;
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
            this.type_product.Width = 256;
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
            this.MainPage.ResumeLayout(false);
            this.PlanCard.ResumeLayout(false);
            this.PlanCard.PerformLayout();
            this.OrdersOfRoomsCard.ResumeLayout(false);
            this.OrdersOfRoomsCard.PerformLayout();
            this.Rooms.ResumeLayout(false);
            this.Rooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.Room.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SheduleView)).EndInit();
            this.Products.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeproductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeproductBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl MainTabControl;
        private System.Windows.Forms.TabPage MainPage;
        private System.Windows.Forms.TabPage Rooms;
        private MaterialSkin.Controls.MaterialDrawer MainDrawer;
        private MaterialSkin.Controls.MaterialCard OrdersOfRoomsCard;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton ButtonRoom9Orders;
        private MaterialSkin.Controls.MaterialButton ButtonRoom2Orders;
        private MaterialSkin.Controls.MaterialButton ButtonRoom1Orders;
        private System.Windows.Forms.TabPage Room;
        private MaterialSkin.Controls.MaterialCard PlanCard;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel DateLabel;
        private System.Windows.Forms.DataGridView SheduleView;
        private System.Windows.Forms.TabPage Products;
        private System.Windows.Forms.DataGridView ProductsView;
        private MaterialSkin.Controls.MaterialButton ChangeProductButton;
        private MaterialSkin.Controls.MaterialButton DeleteProductButton;
        private MaterialSkin.Controls.MaterialButton AddProductButton;
        private MaterialSkin.Controls.MaterialButton TypeProductButton;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource typeproductBindingSource;
        private System.Windows.Forms.BindingSource typeproductBindingSource1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_product;
    }
}

