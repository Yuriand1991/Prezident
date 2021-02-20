
namespace PreziDent
{
    partial class CabinetOrderForm
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
            this.FunctionalPlanLabel = new System.Windows.Forms.GroupBox();
            this.FunctionalPlan = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.TotalPriceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.TotalPrice = new MaterialSkin.Controls.MaterialTextBox();
            this.AddServiceButton = new MaterialSkin.Controls.MaterialButton();
            this.OrdersServicesView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameserviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceserviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbertoothDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpriceserviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderItemViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PrintDocsButton = new MaterialSkin.Controls.MaterialButton();
            this.SaveButton = new MaterialSkin.Controls.MaterialButton();
            this.DateOrderLabel = new MaterialSkin.Controls.MaterialLabel();
            this.DateOrder = new System.Windows.Forms.DateTimePicker();
            this.PatientNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PatientName = new MaterialSkin.Controls.MaterialTextBox();
            this.FunctionalPlanLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersServicesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FunctionalPlanLabel
            // 
            this.FunctionalPlanLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.FunctionalPlanLabel.Controls.Add(this.FunctionalPlan);
            this.FunctionalPlanLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FunctionalPlanLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FunctionalPlanLabel.Location = new System.Drawing.Point(25, 498);
            this.FunctionalPlanLabel.Name = "FunctionalPlanLabel";
            this.FunctionalPlanLabel.Size = new System.Drawing.Size(643, 196);
            this.FunctionalPlanLabel.TabIndex = 11;
            this.FunctionalPlanLabel.TabStop = false;
            this.FunctionalPlanLabel.Text = "Функциональный план:";
            // 
            // FunctionalPlan
            // 
            this.FunctionalPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FunctionalPlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FunctionalPlan.Depth = 0;
            this.FunctionalPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FunctionalPlan.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FunctionalPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FunctionalPlan.Hint = "";
            this.FunctionalPlan.Location = new System.Drawing.Point(3, 20);
            this.FunctionalPlan.MouseState = MaterialSkin.MouseState.HOVER;
            this.FunctionalPlan.Name = "FunctionalPlan";
            this.FunctionalPlan.Size = new System.Drawing.Size(637, 173);
            this.FunctionalPlan.TabIndex = 10;
            this.FunctionalPlan.Text = "";
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TotalPriceLabel.Depth = 0;
            this.TotalPriceLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TotalPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TotalPriceLabel.Location = new System.Drawing.Point(469, 219);
            this.TotalPriceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(49, 19);
            this.TotalPriceLabel.TabIndex = 9;
            this.TotalPriceLabel.Text = "Итого:";
            // 
            // TotalPrice
            // 
            this.TotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalPrice.Depth = 0;
            this.TotalPrice.Font = new System.Drawing.Font("Roboto", 12F);
            this.TotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TotalPrice.Location = new System.Drawing.Point(524, 209);
            this.TotalPrice.MaxLength = 50;
            this.TotalPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.TotalPrice.Multiline = false;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(144, 36);
            this.TotalPrice.TabIndex = 8;
            this.TotalPrice.Text = "";
            this.TotalPrice.UseTallSize = false;
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
            this.AddServiceButton.Location = new System.Drawing.Point(25, 219);
            this.AddServiceButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddServiceButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddServiceButton.Name = "AddServiceButton";
            this.AddServiceButton.Size = new System.Drawing.Size(146, 23);
            this.AddServiceButton.TabIndex = 7;
            this.AddServiceButton.Text = "Добавить услугу";
            this.AddServiceButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddServiceButton.UseAccentColor = false;
            this.AddServiceButton.UseVisualStyleBackColor = false;
            this.AddServiceButton.Click += new System.EventHandler(this.AddServiceButton_Click);
            // 
            // OrdersServicesView
            // 
            this.OrdersServicesView.AllowUserToAddRows = false;
            this.OrdersServicesView.AutoGenerateColumns = false;
            this.OrdersServicesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersServicesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.orderidDataGridViewTextBoxColumn,
            this.serviceidDataGridViewTextBoxColumn,
            this.nameserviceDataGridViewTextBoxColumn,
            this.priceserviceDataGridViewTextBoxColumn,
            this.numbertoothDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.totalpriceserviceDataGridViewTextBoxColumn});
            this.OrdersServicesView.DataSource = this.orderItemViewBindingSource;
            this.OrdersServicesView.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.OrdersServicesView.Location = new System.Drawing.Point(25, 251);
            this.OrdersServicesView.Name = "OrdersServicesView";
            this.OrdersServicesView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersServicesView.Size = new System.Drawing.Size(643, 228);
            this.OrdersServicesView.TabIndex = 6;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // orderidDataGridViewTextBoxColumn
            // 
            this.orderidDataGridViewTextBoxColumn.DataPropertyName = "order_id";
            this.orderidDataGridViewTextBoxColumn.HeaderText = "order_id";
            this.orderidDataGridViewTextBoxColumn.Name = "orderidDataGridViewTextBoxColumn";
            this.orderidDataGridViewTextBoxColumn.Visible = false;
            // 
            // serviceidDataGridViewTextBoxColumn
            // 
            this.serviceidDataGridViewTextBoxColumn.DataPropertyName = "service_id";
            this.serviceidDataGridViewTextBoxColumn.HeaderText = "service_id";
            this.serviceidDataGridViewTextBoxColumn.Name = "serviceidDataGridViewTextBoxColumn";
            this.serviceidDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameserviceDataGridViewTextBoxColumn
            // 
            this.nameserviceDataGridViewTextBoxColumn.DataPropertyName = "name_service";
            this.nameserviceDataGridViewTextBoxColumn.HeaderText = "Наименование услуги";
            this.nameserviceDataGridViewTextBoxColumn.Name = "nameserviceDataGridViewTextBoxColumn";
            this.nameserviceDataGridViewTextBoxColumn.Width = 200;
            // 
            // priceserviceDataGridViewTextBoxColumn
            // 
            this.priceserviceDataGridViewTextBoxColumn.DataPropertyName = "price_service";
            this.priceserviceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceserviceDataGridViewTextBoxColumn.Name = "priceserviceDataGridViewTextBoxColumn";
            // 
            // numbertoothDataGridViewTextBoxColumn
            // 
            this.numbertoothDataGridViewTextBoxColumn.DataPropertyName = "number_tooth";
            this.numbertoothDataGridViewTextBoxColumn.HeaderText = "№ зуба";
            this.numbertoothDataGridViewTextBoxColumn.Name = "numbertoothDataGridViewTextBoxColumn";
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            // 
            // totalpriceserviceDataGridViewTextBoxColumn
            // 
            this.totalpriceserviceDataGridViewTextBoxColumn.DataPropertyName = "total_price_service";
            this.totalpriceserviceDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.totalpriceserviceDataGridViewTextBoxColumn.Name = "totalpriceserviceDataGridViewTextBoxColumn";
            // 
            // orderItemViewBindingSource
            // 
            this.orderItemViewBindingSource.DataSource = typeof(PreziDent.OrderItemView);
            // 
            // PrintDocsButton
            // 
            this.PrintDocsButton.AutoSize = false;
            this.PrintDocsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PrintDocsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.PrintDocsButton.Depth = 0;
            this.PrintDocsButton.DrawShadows = true;
            this.PrintDocsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PrintDocsButton.HighEmphasis = true;
            this.PrintDocsButton.Icon = null;
            this.PrintDocsButton.Location = new System.Drawing.Point(735, 149);
            this.PrintDocsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PrintDocsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.PrintDocsButton.Name = "PrintDocsButton";
            this.PrintDocsButton.Size = new System.Drawing.Size(189, 36);
            this.PrintDocsButton.TabIndex = 5;
            this.PrintDocsButton.Text = "Печать документов";
            this.PrintDocsButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.PrintDocsButton.UseAccentColor = false;
            this.PrintDocsButton.UseVisualStyleBackColor = false;
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSize = false;
            this.SaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.SaveButton.Depth = 0;
            this.SaveButton.DrawShadows = true;
            this.SaveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SaveButton.HighEmphasis = true;
            this.SaveButton.Icon = null;
            this.SaveButton.Location = new System.Drawing.Point(735, 101);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(189, 36);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SaveButton.UseAccentColor = false;
            this.SaveButton.UseVisualStyleBackColor = false;
            // 
            // DateOrderLabel
            // 
            this.DateOrderLabel.AutoSize = true;
            this.DateOrderLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DateOrderLabel.Depth = 0;
            this.DateOrderLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DateOrderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DateOrderLabel.Location = new System.Drawing.Point(430, 91);
            this.DateOrderLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.DateOrderLabel.Name = "DateOrderLabel";
            this.DateOrderLabel.Size = new System.Drawing.Size(43, 19);
            this.DateOrderLabel.TabIndex = 3;
            this.DateOrderLabel.Text = "Дата:";
            // 
            // DateOrder
            // 
            this.DateOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DateOrder.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DateOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DateOrder.Location = new System.Drawing.Point(433, 113);
            this.DateOrder.Name = "DateOrder";
            this.DateOrder.Size = new System.Drawing.Size(235, 24);
            this.DateOrder.TabIndex = 2;
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.AutoSize = true;
            this.PatientNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.PatientNameLabel.Depth = 0;
            this.PatientNameLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PatientNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PatientNameLabel.Location = new System.Drawing.Point(22, 91);
            this.PatientNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.PatientNameLabel.Name = "PatientNameLabel";
            this.PatientNameLabel.Size = new System.Drawing.Size(68, 19);
            this.PatientNameLabel.TabIndex = 1;
            this.PatientNameLabel.Text = "Пациент:";
            // 
            // PatientName
            // 
            this.PatientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.PatientName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientName.Depth = 0;
            this.PatientName.Font = new System.Drawing.Font("Roboto", 12F);
            this.PatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PatientName.Hint = "Введите ФИО";
            this.PatientName.Location = new System.Drawing.Point(25, 113);
            this.PatientName.MaxLength = 50;
            this.PatientName.MouseState = MaterialSkin.MouseState.OUT;
            this.PatientName.Multiline = false;
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(373, 36);
            this.PatientName.TabIndex = 0;
            this.PatientName.Text = "";
            this.PatientName.UseTallSize = false;
            // 
            // CabinetOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 718);
            this.Controls.Add(this.FunctionalPlanLabel);
            this.Controls.Add(this.TotalPriceLabel);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.AddServiceButton);
            this.Controls.Add(this.OrdersServicesView);
            this.Controls.Add(this.PrintDocsButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DateOrderLabel);
            this.Controls.Add(this.DateOrder);
            this.Controls.Add(this.PatientNameLabel);
            this.Controls.Add(this.PatientName);
            this.Name = "CabinetOrderForm";
            this.Text = "Заказ";
            this.FunctionalPlanLabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersServicesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox PatientName;
        private MaterialSkin.Controls.MaterialLabel PatientNameLabel;
        private System.Windows.Forms.DateTimePicker DateOrder;
        private MaterialSkin.Controls.MaterialLabel DateOrderLabel;
        private MaterialSkin.Controls.MaterialButton SaveButton;
        private MaterialSkin.Controls.MaterialButton PrintDocsButton;
        private System.Windows.Forms.DataGridView OrdersServicesView;
        private MaterialSkin.Controls.MaterialButton AddServiceButton;
        private MaterialSkin.Controls.MaterialTextBox TotalPrice;
        private MaterialSkin.Controls.MaterialLabel TotalPriceLabel;
        private MaterialSkin.Controls.MaterialMultiLineTextBox FunctionalPlan;
        private System.Windows.Forms.GroupBox FunctionalPlanLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameserviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceserviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbertoothDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpriceserviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderItemViewBindingSource;
    }
}