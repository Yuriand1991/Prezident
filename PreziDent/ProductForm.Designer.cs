
namespace PreziDent
{
    partial class ProductForm
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
            this.NameProduct = new MaterialSkin.Controls.MaterialTextBox();
            this.PriceProduct = new MaterialSkin.Controls.MaterialTextBox();
            this.OkButton = new MaterialSkin.Controls.MaterialButton();
            this.CancelButton = new MaterialSkin.Controls.MaterialButton();
            this.NameProductLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ProductPriceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.TypeProduct = new MaterialSkin.Controls.MaterialComboBox();
            this.typeproductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductTypeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AddTypeProductLink = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.typeproductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NameProduct
            // 
            this.NameProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.NameProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameProduct.Depth = 0;
            this.NameProduct.Font = new System.Drawing.Font("Roboto", 12F);
            this.NameProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NameProduct.Hint = "Введите наименование";
            this.NameProduct.Location = new System.Drawing.Point(55, 120);
            this.NameProduct.MaxLength = 50;
            this.NameProduct.MouseState = MaterialSkin.MouseState.OUT;
            this.NameProduct.Multiline = false;
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.Size = new System.Drawing.Size(229, 50);
            this.NameProduct.TabIndex = 0;
            this.NameProduct.Text = "";
            // 
            // PriceProduct
            // 
            this.PriceProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.PriceProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceProduct.Depth = 0;
            this.PriceProduct.Font = new System.Drawing.Font("Roboto", 12F);
            this.PriceProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PriceProduct.Hint = "Введите цену";
            this.PriceProduct.Location = new System.Drawing.Point(55, 209);
            this.PriceProduct.MaxLength = 50;
            this.PriceProduct.MouseState = MaterialSkin.MouseState.OUT;
            this.PriceProduct.Multiline = false;
            this.PriceProduct.Name = "PriceProduct";
            this.PriceProduct.Size = new System.Drawing.Size(229, 50);
            this.PriceProduct.TabIndex = 1;
            this.PriceProduct.Text = "";
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
            this.OkButton.Location = new System.Drawing.Point(55, 423);
            this.OkButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OkButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(62, 36);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "Ок";
            this.OkButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.OkButton.UseAccentColor = false;
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSize = false;
            this.CancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CancelButton.Depth = 0;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.DrawShadows = true;
            this.CancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CancelButton.HighEmphasis = true;
            this.CancelButton.Icon = null;
            this.CancelButton.Location = new System.Drawing.Point(135, 423);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(149, 36);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CancelButton.UseAccentColor = false;
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // NameProductLabel
            // 
            this.NameProductLabel.AutoSize = true;
            this.NameProductLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.NameProductLabel.Depth = 0;
            this.NameProductLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NameProductLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NameProductLabel.Location = new System.Drawing.Point(52, 98);
            this.NameProductLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.NameProductLabel.Name = "NameProductLabel";
            this.NameProductLabel.Size = new System.Drawing.Size(116, 19);
            this.NameProductLabel.TabIndex = 4;
            this.NameProductLabel.Text = "Наименование:";
            // 
            // ProductPriceLabel
            // 
            this.ProductPriceLabel.AutoSize = true;
            this.ProductPriceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ProductPriceLabel.Depth = 0;
            this.ProductPriceLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProductPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ProductPriceLabel.Location = new System.Drawing.Point(52, 187);
            this.ProductPriceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProductPriceLabel.Name = "ProductPriceLabel";
            this.ProductPriceLabel.Size = new System.Drawing.Size(43, 19);
            this.ProductPriceLabel.TabIndex = 5;
            this.ProductPriceLabel.Text = "Цена:";
            // 
            // TypeProduct
            // 
            this.TypeProduct.AutoResize = false;
            this.TypeProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TypeProduct.DataSource = this.typeproductBindingSource;
            this.TypeProduct.Depth = 0;
            this.TypeProduct.DisplayMember = "name";
            this.TypeProduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.TypeProduct.DropDownHeight = 174;
            this.TypeProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeProduct.DropDownWidth = 121;
            this.TypeProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TypeProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TypeProduct.FormattingEnabled = true;
            this.TypeProduct.Hint = "Выберете категорию";
            this.TypeProduct.IntegralHeight = false;
            this.TypeProduct.ItemHeight = 43;
            this.TypeProduct.Location = new System.Drawing.Point(55, 315);
            this.TypeProduct.MaxDropDownItems = 4;
            this.TypeProduct.MouseState = MaterialSkin.MouseState.OUT;
            this.TypeProduct.Name = "TypeProduct";
            this.TypeProduct.Size = new System.Drawing.Size(229, 49);
            this.TypeProduct.TabIndex = 6;
            this.TypeProduct.ValueMember = "id";
            // 
            // typeproductBindingSource
            // 
            this.typeproductBindingSource.DataSource = typeof(PreziDent.type_product);
            // 
            // ProductTypeLabel
            // 
            this.ProductTypeLabel.AutoSize = true;
            this.ProductTypeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ProductTypeLabel.Depth = 0;
            this.ProductTypeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProductTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ProductTypeLabel.Location = new System.Drawing.Point(52, 283);
            this.ProductTypeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProductTypeLabel.Name = "ProductTypeLabel";
            this.ProductTypeLabel.Size = new System.Drawing.Size(83, 19);
            this.ProductTypeLabel.TabIndex = 7;
            this.ProductTypeLabel.Text = "Категория:";
            // 
            // AddTypeProductLink
            // 
            this.AddTypeProductLink.AutoSize = true;
            this.AddTypeProductLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddTypeProductLink.Depth = 0;
            this.AddTypeProductLink.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AddTypeProductLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddTypeProductLink.Location = new System.Drawing.Point(52, 367);
            this.AddTypeProductLink.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddTypeProductLink.Name = "AddTypeProductLink";
            this.AddTypeProductLink.Size = new System.Drawing.Size(160, 19);
            this.AddTypeProductLink.TabIndex = 8;
            this.AddTypeProductLink.Text = "Добавить категорию";
            this.AddTypeProductLink.Click += new System.EventHandler(this.AddTypeProductLink_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 497);
            this.Controls.Add(this.AddTypeProductLink);
            this.Controls.Add(this.ProductTypeLabel);
            this.Controls.Add(this.TypeProduct);
            this.Controls.Add(this.ProductPriceLabel);
            this.Controls.Add(this.NameProductLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.PriceProduct);
            this.Controls.Add(this.NameProduct);
            this.Name = "ProductForm";
            this.Text = "Продукт";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.typeproductBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton OkButton;
        private MaterialSkin.Controls.MaterialButton CancelButton;
        protected internal MaterialSkin.Controls.MaterialTextBox NameProduct;
        protected internal MaterialSkin.Controls.MaterialTextBox PriceProduct;
        private MaterialSkin.Controls.MaterialLabel NameProductLabel;
        private MaterialSkin.Controls.MaterialLabel ProductPriceLabel;
        private MaterialSkin.Controls.MaterialLabel ProductTypeLabel;
        protected internal MaterialSkin.Controls.MaterialComboBox TypeProduct;
        private MaterialSkin.Controls.MaterialLabel AddTypeProductLink;
        private System.Windows.Forms.BindingSource typeproductBindingSource;
    }
}