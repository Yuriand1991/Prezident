
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
            this.NameTypeProductsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.CnclButton = new MaterialSkin.Controls.MaterialButton();
            this.OkButton = new MaterialSkin.Controls.MaterialButton();
            this.NameTypeProducts = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // NameTypeProductsLabel
            // 
            this.NameTypeProductsLabel.AutoSize = true;
            this.NameTypeProductsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.NameTypeProductsLabel.Depth = 0;
            this.NameTypeProductsLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NameTypeProductsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NameTypeProductsLabel.Location = new System.Drawing.Point(12, 78);
            this.NameTypeProductsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.NameTypeProductsLabel.Name = "NameTypeProductsLabel";
            this.NameTypeProductsLabel.Size = new System.Drawing.Size(197, 19);
            this.NameTypeProductsLabel.TabIndex = 3;
            this.NameTypeProductsLabel.Text = "Наименование категории:";
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
            this.CnclButton.Location = new System.Drawing.Point(136, 171);
            this.CnclButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CnclButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CnclButton.Name = "CnclButton";
            this.CnclButton.Size = new System.Drawing.Size(184, 36);
            this.CnclButton.TabIndex = 2;
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
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // NameTypeProducts
            // 
            this.NameTypeProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.NameTypeProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTypeProducts.Depth = 0;
            this.NameTypeProducts.Font = new System.Drawing.Font("Roboto", 12F);
            this.NameTypeProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NameTypeProducts.Hint = "Введите наименование";
            this.NameTypeProducts.Location = new System.Drawing.Point(12, 100);
            this.NameTypeProducts.MaxLength = 50;
            this.NameTypeProducts.MouseState = MaterialSkin.MouseState.OUT;
            this.NameTypeProducts.Multiline = false;
            this.NameTypeProducts.Name = "NameTypeProducts";
            this.NameTypeProducts.Size = new System.Drawing.Size(308, 50);
            this.NameTypeProducts.TabIndex = 0;
            this.NameTypeProducts.Text = "";
            // 
            // TypeProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 227);
            this.Controls.Add(this.NameTypeProductsLabel);
            this.Controls.Add(this.CnclButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.NameTypeProducts);
            this.Name = "TypeProductsForm";
            this.Text = "Категория продукта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton OkButton;
        private MaterialSkin.Controls.MaterialButton CnclButton;
        private MaterialSkin.Controls.MaterialLabel NameTypeProductsLabel;
        protected internal MaterialSkin.Controls.MaterialTextBox NameTypeProducts;
    }
}