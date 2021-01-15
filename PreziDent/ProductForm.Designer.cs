
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
            this.NameProduct = new MaterialSkin.Controls.MaterialTextBox();
            this.PriceProduct = new MaterialSkin.Controls.MaterialTextBox();
            this.OkButton = new MaterialSkin.Controls.MaterialButton();
            this.CancelButton = new MaterialSkin.Controls.MaterialButton();
            this.NameProductLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ProductPriceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // NameProduct
            // 
            this.NameProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameProduct.Depth = 0;
            this.NameProduct.Font = new System.Drawing.Font("Roboto", 12F);
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
            this.PriceProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceProduct.Depth = 0;
            this.PriceProduct.Font = new System.Drawing.Font("Roboto", 12F);
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
            this.OkButton.Depth = 0;
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.DrawShadows = true;
            this.OkButton.HighEmphasis = true;
            this.OkButton.Icon = null;
            this.OkButton.Location = new System.Drawing.Point(55, 356);
            this.OkButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OkButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(62, 36);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "Ок";
            this.OkButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.OkButton.UseAccentColor = false;
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSize = false;
            this.CancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton.Depth = 0;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.DrawShadows = true;
            this.CancelButton.HighEmphasis = true;
            this.CancelButton.Icon = null;
            this.CancelButton.Location = new System.Drawing.Point(135, 356);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(149, 36);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CancelButton.UseAccentColor = false;
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // NameProductLabel
            // 
            this.NameProductLabel.AutoSize = true;
            this.NameProductLabel.Depth = 0;
            this.NameProductLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.ProductPriceLabel.Depth = 0;
            this.ProductPriceLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProductPriceLabel.Location = new System.Drawing.Point(52, 187);
            this.ProductPriceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProductPriceLabel.Name = "ProductPriceLabel";
            this.ProductPriceLabel.Size = new System.Drawing.Size(43, 19);
            this.ProductPriceLabel.TabIndex = 5;
            this.ProductPriceLabel.Text = "Цена:";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 441);
            this.Controls.Add(this.ProductPriceLabel);
            this.Controls.Add(this.NameProductLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.PriceProduct);
            this.Controls.Add(this.NameProduct);
            this.Name = "ProductForm";
            this.Text = "Продукт";
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
    }
}