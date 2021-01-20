
namespace PreziDent
{
    partial class TypeProductsForm
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.CancelButton = new MaterialSkin.Controls.MaterialButton();
            this.OkButton = new MaterialSkin.Controls.MaterialButton();
            this.NameTypeProduct = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 78);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(133, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Новая категория:";
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
            this.CancelButton.Location = new System.Drawing.Point(136, 171);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(184, 36);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CancelButton.UseAccentColor = false;
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // OkButton
            // 
            this.OkButton.AutoSize = false;
            this.OkButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.OkButton.Depth = 0;
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.DrawShadows = true;
            this.OkButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OkButton.HighEmphasis = true;
            this.OkButton.Icon = null;
            this.OkButton.Location = new System.Drawing.Point(12, 171);
            this.OkButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OkButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(106, 36);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.OkButton.UseAccentColor = false;
            this.OkButton.UseVisualStyleBackColor = false;
            // 
            // NameTypeProduct
            // 
            this.NameTypeProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.NameTypeProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTypeProduct.Depth = 0;
            this.NameTypeProduct.Font = new System.Drawing.Font("Roboto", 12F);
            this.NameTypeProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NameTypeProduct.Hint = "Введите наименование";
            this.NameTypeProduct.Location = new System.Drawing.Point(12, 100);
            this.NameTypeProduct.MaxLength = 50;
            this.NameTypeProduct.MouseState = MaterialSkin.MouseState.OUT;
            this.NameTypeProduct.Multiline = false;
            this.NameTypeProduct.Name = "NameTypeProduct";
            this.NameTypeProduct.Size = new System.Drawing.Size(308, 50);
            this.NameTypeProduct.TabIndex = 0;
            this.NameTypeProduct.Text = "";
            // 
            // TypeProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 227);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.NameTypeProduct);
            this.Name = "TypeProductsForm";
            this.Text = "Категория продукта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton OkButton;
        private MaterialSkin.Controls.MaterialButton CancelButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        protected internal MaterialSkin.Controls.MaterialTextBox NameTypeProduct;
    }
}