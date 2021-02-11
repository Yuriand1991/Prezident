
namespace PreziDent
{
    partial class AddServiceToOrderForm
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
            this.ServicesViewBox = new System.Windows.Forms.GroupBox();
            this.ServicesView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupservicesidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeserviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedatDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupservicesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersservicesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GroupService = new MaterialSkin.Controls.MaterialComboBox();
            this.groupservicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GroupServiceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ServiceName = new MaterialSkin.Controls.MaterialTextBox();
            this.ServiceNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.NumberTooth = new MaterialSkin.Controls.MaterialTextBox();
            this.NumberToothLabel = new MaterialSkin.Controls.MaterialLabel();
            this.CountLabel = new MaterialSkin.Controls.MaterialLabel();
            this.Count = new MaterialSkin.Controls.MaterialTextBox();
            this.PriceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.Price = new MaterialSkin.Controls.MaterialTextBox();
            this.TotalPriceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.TotalPrice = new MaterialSkin.Controls.MaterialTextBox();
            this.OkButton = new MaterialSkin.Controls.MaterialButton();
            this.CnclButton = new MaterialSkin.Controls.MaterialButton();
            this.ServicesViewBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupservicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ServicesViewBox
            // 
            this.ServicesViewBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ServicesViewBox.Controls.Add(this.ServicesView);
            this.ServicesViewBox.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ServicesViewBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ServicesViewBox.Location = new System.Drawing.Point(12, 77);
            this.ServicesViewBox.Name = "ServicesViewBox";
            this.ServicesViewBox.Size = new System.Drawing.Size(517, 330);
            this.ServicesViewBox.TabIndex = 0;
            this.ServicesViewBox.TabStop = false;
            this.ServicesViewBox.Text = "Услуги:";
            // 
            // ServicesView
            // 
            this.ServicesView.AllowUserToAddRows = false;
            this.ServicesView.AutoGenerateColumns = false;
            this.ServicesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServicesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.groupservicesidDataGridViewTextBoxColumn,
            this.codeserviceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.deletedatDataGridViewImageColumn,
            this.groupservicesDataGridViewTextBoxColumn,
            this.ordersservicesDataGridViewTextBoxColumn});
            this.ServicesView.DataSource = this.serviceBindingSource;
            this.ServicesView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServicesView.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ServicesView.Location = new System.Drawing.Point(3, 20);
            this.ServicesView.Name = "ServicesView";
            this.ServicesView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServicesView.Size = new System.Drawing.Size(511, 307);
            this.ServicesView.TabIndex = 0;
            this.ServicesView.DoubleClick += new System.EventHandler(this.ServicesView_DoubleClick);
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
            this.nameDataGridViewTextBoxColumn.Width = 400;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Visible = false;
            // 
            // groupservicesidDataGridViewTextBoxColumn
            // 
            this.groupservicesidDataGridViewTextBoxColumn.DataPropertyName = "group_services_id";
            this.groupservicesidDataGridViewTextBoxColumn.HeaderText = "group_services_id";
            this.groupservicesidDataGridViewTextBoxColumn.Name = "groupservicesidDataGridViewTextBoxColumn";
            this.groupservicesidDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeserviceDataGridViewTextBoxColumn
            // 
            this.codeserviceDataGridViewTextBoxColumn.DataPropertyName = "code_service";
            this.codeserviceDataGridViewTextBoxColumn.HeaderText = "code_service";
            this.codeserviceDataGridViewTextBoxColumn.Name = "codeserviceDataGridViewTextBoxColumn";
            this.codeserviceDataGridViewTextBoxColumn.Visible = false;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Visible = false;
            // 
            // deletedatDataGridViewImageColumn
            // 
            this.deletedatDataGridViewImageColumn.DataPropertyName = "deleted_at";
            this.deletedatDataGridViewImageColumn.HeaderText = "deleted_at";
            this.deletedatDataGridViewImageColumn.Name = "deletedatDataGridViewImageColumn";
            this.deletedatDataGridViewImageColumn.Visible = false;
            // 
            // groupservicesDataGridViewTextBoxColumn
            // 
            this.groupservicesDataGridViewTextBoxColumn.DataPropertyName = "group_services";
            this.groupservicesDataGridViewTextBoxColumn.HeaderText = "group_services";
            this.groupservicesDataGridViewTextBoxColumn.Name = "groupservicesDataGridViewTextBoxColumn";
            this.groupservicesDataGridViewTextBoxColumn.Visible = false;
            // 
            // ordersservicesDataGridViewTextBoxColumn
            // 
            this.ordersservicesDataGridViewTextBoxColumn.DataPropertyName = "orders_services";
            this.ordersservicesDataGridViewTextBoxColumn.HeaderText = "orders_services";
            this.ordersservicesDataGridViewTextBoxColumn.Name = "ordersservicesDataGridViewTextBoxColumn";
            this.ordersservicesDataGridViewTextBoxColumn.Visible = false;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataSource = typeof(PreziDent.service);
            // 
            // GroupService
            // 
            this.GroupService.AutoResize = false;
            this.GroupService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.GroupService.DataSource = this.groupservicesBindingSource;
            this.GroupService.Depth = 0;
            this.GroupService.DisplayMember = "name";
            this.GroupService.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.GroupService.DropDownHeight = 174;
            this.GroupService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupService.DropDownWidth = 121;
            this.GroupService.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.GroupService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GroupService.FormattingEnabled = true;
            this.GroupService.IntegralHeight = false;
            this.GroupService.ItemHeight = 43;
            this.GroupService.Location = new System.Drawing.Point(558, 97);
            this.GroupService.MaxDropDownItems = 4;
            this.GroupService.MouseState = MaterialSkin.MouseState.OUT;
            this.GroupService.Name = "GroupService";
            this.GroupService.Size = new System.Drawing.Size(289, 49);
            this.GroupService.TabIndex = 1;
            this.GroupService.ValueMember = "id";
            this.GroupService.SelectedIndexChanged += new System.EventHandler(this.GroupService_SelectedIndexChanged);
            // 
            // groupservicesBindingSource
            // 
            this.groupservicesBindingSource.DataSource = typeof(PreziDent.group_services);
            // 
            // GroupServiceLabel
            // 
            this.GroupServiceLabel.AutoSize = true;
            this.GroupServiceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.GroupServiceLabel.Depth = 0;
            this.GroupServiceLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GroupServiceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GroupServiceLabel.Location = new System.Drawing.Point(555, 75);
            this.GroupServiceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.GroupServiceLabel.Name = "GroupServiceLabel";
            this.GroupServiceLabel.Size = new System.Drawing.Size(58, 19);
            this.GroupServiceLabel.TabIndex = 2;
            this.GroupServiceLabel.Text = "Группа:";
            // 
            // ServiceName
            // 
            this.ServiceName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ServiceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServiceName.Depth = 0;
            this.ServiceName.Font = new System.Drawing.Font("Roboto", 12F);
            this.ServiceName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ServiceName.Location = new System.Drawing.Point(15, 511);
            this.ServiceName.MaxLength = 50;
            this.ServiceName.MouseState = MaterialSkin.MouseState.OUT;
            this.ServiceName.Multiline = false;
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            this.ServiceName.Size = new System.Drawing.Size(255, 50);
            this.ServiceName.TabIndex = 3;
            this.ServiceName.Text = "";
            // 
            // ServiceNameLabel
            // 
            this.ServiceNameLabel.AutoSize = true;
            this.ServiceNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ServiceNameLabel.Depth = 0;
            this.ServiceNameLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ServiceNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ServiceNameLabel.Location = new System.Drawing.Point(12, 489);
            this.ServiceNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ServiceNameLabel.Name = "ServiceNameLabel";
            this.ServiceNameLabel.Size = new System.Drawing.Size(116, 19);
            this.ServiceNameLabel.TabIndex = 4;
            this.ServiceNameLabel.Text = "Наименование:";
            // 
            // NumberTooth
            // 
            this.NumberTooth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.NumberTooth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumberTooth.Depth = 0;
            this.NumberTooth.Font = new System.Drawing.Font("Roboto", 12F);
            this.NumberTooth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NumberTooth.Location = new System.Drawing.Point(293, 511);
            this.NumberTooth.MaxLength = 2;
            this.NumberTooth.MouseState = MaterialSkin.MouseState.OUT;
            this.NumberTooth.Multiline = false;
            this.NumberTooth.Name = "NumberTooth";
            this.NumberTooth.Size = new System.Drawing.Size(100, 50);
            this.NumberTooth.TabIndex = 5;
            this.NumberTooth.Text = "";
            // 
            // NumberToothLabel
            // 
            this.NumberToothLabel.AutoSize = true;
            this.NumberToothLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.NumberToothLabel.Depth = 0;
            this.NumberToothLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NumberToothLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NumberToothLabel.Location = new System.Drawing.Point(290, 489);
            this.NumberToothLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.NumberToothLabel.Name = "NumberToothLabel";
            this.NumberToothLabel.Size = new System.Drawing.Size(59, 19);
            this.NumberToothLabel.TabIndex = 6;
            this.NumberToothLabel.Text = "№ зуба:";
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CountLabel.Depth = 0;
            this.CountLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CountLabel.Location = new System.Drawing.Point(414, 489);
            this.CountLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(93, 19);
            this.CountLabel.TabIndex = 8;
            this.CountLabel.Text = "Количество:";
            // 
            // Count
            // 
            this.Count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Count.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Count.Depth = 0;
            this.Count.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Count.Location = new System.Drawing.Point(417, 511);
            this.Count.MaxLength = 50;
            this.Count.MouseState = MaterialSkin.MouseState.OUT;
            this.Count.Multiline = false;
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(100, 50);
            this.Count.TabIndex = 7;
            this.Count.Text = "1";
            this.Count.TextChanged += new System.EventHandler(this.Count_TextChanged);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.PriceLabel.Depth = 0;
            this.PriceLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PriceLabel.Location = new System.Drawing.Point(534, 489);
            this.PriceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(43, 19);
            this.PriceLabel.TabIndex = 10;
            this.PriceLabel.Text = "Цена:";
            // 
            // Price
            // 
            this.Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Price.Depth = 0;
            this.Price.Font = new System.Drawing.Font("Roboto", 12F);
            this.Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Price.Location = new System.Drawing.Point(537, 511);
            this.Price.MaxLength = 50;
            this.Price.MouseState = MaterialSkin.MouseState.OUT;
            this.Price.Multiline = false;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Size = new System.Drawing.Size(146, 50);
            this.Price.TabIndex = 9;
            this.Price.Text = "";
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TotalPriceLabel.Depth = 0;
            this.TotalPriceLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TotalPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TotalPriceLabel.Location = new System.Drawing.Point(698, 489);
            this.TotalPriceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(56, 19);
            this.TotalPriceLabel.TabIndex = 12;
            this.TotalPriceLabel.Text = "Сумма:";
            // 
            // TotalPrice
            // 
            this.TotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalPrice.Depth = 0;
            this.TotalPrice.Font = new System.Drawing.Font("Roboto", 12F);
            this.TotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TotalPrice.Location = new System.Drawing.Point(701, 511);
            this.TotalPrice.MaxLength = 50;
            this.TotalPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.TotalPrice.Multiline = false;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Size = new System.Drawing.Size(146, 50);
            this.TotalPrice.TabIndex = 11;
            this.TotalPrice.Text = "";
            // 
            // OkButton
            // 
            this.OkButton.AutoSize = false;
            this.OkButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.OkButton.Depth = 0;
            this.OkButton.DrawShadows = true;
            this.OkButton.Enabled = false;
            this.OkButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OkButton.HighEmphasis = true;
            this.OkButton.Icon = null;
            this.OkButton.Location = new System.Drawing.Point(15, 628);
            this.OkButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OkButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(88, 36);
            this.OkButton.TabIndex = 13;
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
            this.CnclButton.Location = new System.Drawing.Point(120, 628);
            this.CnclButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CnclButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CnclButton.Name = "CnclButton";
            this.CnclButton.Size = new System.Drawing.Size(150, 36);
            this.CnclButton.TabIndex = 14;
            this.CnclButton.Text = "Отмена";
            this.CnclButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CnclButton.UseAccentColor = false;
            this.CnclButton.UseVisualStyleBackColor = false;
            // 
            // AddServiceToOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 713);
            this.Controls.Add(this.CnclButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.TotalPriceLabel);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.NumberToothLabel);
            this.Controls.Add(this.NumberTooth);
            this.Controls.Add(this.ServiceNameLabel);
            this.Controls.Add(this.ServiceName);
            this.Controls.Add(this.GroupServiceLabel);
            this.Controls.Add(this.GroupService);
            this.Controls.Add(this.ServicesViewBox);
            this.Name = "AddServiceToOrderForm";
            this.Text = "Добавление услуги в заказ";
            this.ServicesViewBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServicesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupservicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ServicesViewBox;
        private System.Windows.Forms.DataGridView ServicesView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupservicesidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeserviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn deletedatDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupservicesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordersservicesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private MaterialSkin.Controls.MaterialComboBox GroupService;
        private MaterialSkin.Controls.MaterialLabel GroupServiceLabel;
        private System.Windows.Forms.BindingSource groupservicesBindingSource;
        private MaterialSkin.Controls.MaterialLabel ServiceNameLabel;
        private MaterialSkin.Controls.MaterialLabel NumberToothLabel;
        private MaterialSkin.Controls.MaterialLabel CountLabel;
        private MaterialSkin.Controls.MaterialLabel PriceLabel;
        private MaterialSkin.Controls.MaterialLabel TotalPriceLabel;
        private MaterialSkin.Controls.MaterialButton OkButton;
        private MaterialSkin.Controls.MaterialButton CnclButton;
        protected internal MaterialSkin.Controls.MaterialTextBox ServiceName;
        protected internal MaterialSkin.Controls.MaterialTextBox NumberTooth;
        protected internal MaterialSkin.Controls.MaterialTextBox Count;
        protected internal MaterialSkin.Controls.MaterialTextBox Price;
        protected internal MaterialSkin.Controls.MaterialTextBox TotalPrice;
    }
}