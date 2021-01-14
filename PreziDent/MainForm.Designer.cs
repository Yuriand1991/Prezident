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
            this.Room = new System.Windows.Forms.TabPage();
            this.SheduleView = new System.Windows.Forms.DataGridView();
            this.MainDrawer = new MaterialSkin.Controls.MaterialDrawer();
            this.DateLabel = new MaterialSkin.Controls.MaterialLabel();
            this.MainTabControl.SuspendLayout();
            this.MainPage.SuspendLayout();
            this.PlanCard.SuspendLayout();
            this.OrdersOfRoomsCard.SuspendLayout();
            this.Room.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SheduleView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.MainPage);
            this.MainTabControl.Controls.Add(this.Rooms);
            this.MainTabControl.Controls.Add(this.Room);
            this.MainTabControl.Depth = 0;
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
            this.MainPage.Controls.Add(this.PlanCard);
            this.MainPage.Controls.Add(this.OrdersOfRoomsCard);
            this.MainPage.Location = new System.Drawing.Point(4, 22);
            this.MainPage.Name = "MainPage";
            this.MainPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainPage.Size = new System.Drawing.Size(918, 632);
            this.MainPage.TabIndex = 0;
            this.MainPage.Text = "Главная";
            this.MainPage.UseVisualStyleBackColor = true;
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
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(108, 14);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(64, 20);
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
            this.ButtonRoom2Orders.Depth = 0;
            this.ButtonRoom2Orders.DrawShadows = true;
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
            this.ButtonRoom2Orders.UseVisualStyleBackColor = true;
            // 
            // ButtonRoom1Orders
            // 
            this.ButtonRoom1Orders.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonRoom1Orders.Depth = 0;
            this.ButtonRoom1Orders.DrawShadows = true;
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
            this.ButtonRoom1Orders.UseVisualStyleBackColor = true;
            // 
            // ButtonRoom9Orders
            // 
            this.ButtonRoom9Orders.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonRoom9Orders.Depth = 0;
            this.ButtonRoom9Orders.DrawShadows = true;
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
            this.ButtonRoom9Orders.UseVisualStyleBackColor = true;
            this.ButtonRoom9Orders.Click += new System.EventHandler(this.ButtonRoom9Orders_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(57, 20);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Заказы";
            // 
            // Rooms
            // 
            this.Rooms.Location = new System.Drawing.Point(4, 22);
            this.Rooms.Name = "Rooms";
            this.Rooms.Padding = new System.Windows.Forms.Padding(3);
            this.Rooms.Size = new System.Drawing.Size(918, 632);
            this.Rooms.TabIndex = 1;
            this.Rooms.Text = "Кабинеты";
            this.Rooms.UseVisualStyleBackColor = true;
            // 
            // Room
            // 
            this.Room.Controls.Add(this.SheduleView);
            this.Room.Location = new System.Drawing.Point(4, 22);
            this.Room.Name = "Room";
            this.Room.Padding = new System.Windows.Forms.Padding(3);
            this.Room.Size = new System.Drawing.Size(918, 632);
            this.Room.TabIndex = 2;
            this.Room.Text = "Мой кабинет";
            this.Room.UseVisualStyleBackColor = true;
            // 
            // SheduleView
            // 
            this.SheduleView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SheduleView.Location = new System.Drawing.Point(59, 45);
            this.SheduleView.Name = "SheduleView";
            this.SheduleView.Size = new System.Drawing.Size(234, 364);
            this.SheduleView.TabIndex = 0;
            this.SheduleView.Paint += new System.Windows.Forms.PaintEventHandler(this.SheduleView_Paint);
            // 
            // MainDrawer
            // 
            this.MainDrawer.AutoHide = false;
            this.MainDrawer.BackgroundWithAccent = false;
            this.MainDrawer.BaseTabControl = this.MainTabControl;
            this.MainDrawer.Depth = 0;
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
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DateLabel.Depth = 0;
            this.DateLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.DateLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.DateLabel.Location = new System.Drawing.Point(460, 75);
            this.DateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(174, 29);
            this.DateLabel.TabIndex = 3;
            this.DateLabel.Text = "26 Ноября 2020";
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
            this.Room.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SheduleView)).EndInit();
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
    }
}

