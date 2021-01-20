
namespace PreziDent
{
    partial class TypesProductsForm
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
            this.TypesProductsView = new System.Windows.Forms.DataGridView();
            this.AddTypeProductButton = new MaterialSkin.Controls.MaterialButton();
            this.ChangeTypeProductButton = new MaterialSkin.Controls.MaterialButton();
            this.DeleteTypeProductlButton = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.TypesProductsView)).BeginInit();
            this.SuspendLayout();
            // 
            // TypesProductsView
            // 
            this.TypesProductsView.AllowUserToAddRows = false;
            this.TypesProductsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TypesProductsView.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TypesProductsView.Location = new System.Drawing.Point(7, 77);
            this.TypesProductsView.Name = "TypesProductsView";
            this.TypesProductsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TypesProductsView.Size = new System.Drawing.Size(462, 274);
            this.TypesProductsView.TabIndex = 0;
            // 
            // AddTypeProductButton
            // 
            this.AddTypeProductButton.AutoSize = false;
            this.AddTypeProductButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddTypeProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddTypeProductButton.Depth = 0;
            this.AddTypeProductButton.DrawShadows = true;
            this.AddTypeProductButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddTypeProductButton.HighEmphasis = true;
            this.AddTypeProductButton.Icon = null;
            this.AddTypeProductButton.Location = new System.Drawing.Point(13, 374);
            this.AddTypeProductButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddTypeProductButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddTypeProductButton.Name = "AddTypeProductButton";
            this.AddTypeProductButton.Size = new System.Drawing.Size(136, 36);
            this.AddTypeProductButton.TabIndex = 1;
            this.AddTypeProductButton.Text = "Добавить";
            this.AddTypeProductButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddTypeProductButton.UseAccentColor = false;
            this.AddTypeProductButton.UseVisualStyleBackColor = false;
            this.AddTypeProductButton.Click += new System.EventHandler(this.AddTypeProductButton_Click);
            // 
            // ChangeTypeProductButton
            // 
            this.ChangeTypeProductButton.AutoSize = false;
            this.ChangeTypeProductButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChangeTypeProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ChangeTypeProductButton.Depth = 0;
            this.ChangeTypeProductButton.DrawShadows = true;
            this.ChangeTypeProductButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ChangeTypeProductButton.HighEmphasis = true;
            this.ChangeTypeProductButton.Icon = null;
            this.ChangeTypeProductButton.Location = new System.Drawing.Point(168, 374);
            this.ChangeTypeProductButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ChangeTypeProductButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChangeTypeProductButton.Name = "ChangeTypeProductButton";
            this.ChangeTypeProductButton.Size = new System.Drawing.Size(136, 36);
            this.ChangeTypeProductButton.TabIndex = 2;
            this.ChangeTypeProductButton.Text = "Изменить";
            this.ChangeTypeProductButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ChangeTypeProductButton.UseAccentColor = false;
            this.ChangeTypeProductButton.UseVisualStyleBackColor = false;
            this.ChangeTypeProductButton.Click += new System.EventHandler(this.ChangeTypeProductButton_Click);
            // 
            // DeleteTypeProductlButton
            // 
            this.DeleteTypeProductlButton.AutoSize = false;
            this.DeleteTypeProductlButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteTypeProductlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteTypeProductlButton.Depth = 0;
            this.DeleteTypeProductlButton.DrawShadows = true;
            this.DeleteTypeProductlButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeleteTypeProductlButton.HighEmphasis = true;
            this.DeleteTypeProductlButton.Icon = null;
            this.DeleteTypeProductlButton.Location = new System.Drawing.Point(324, 374);
            this.DeleteTypeProductlButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteTypeProductlButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteTypeProductlButton.Name = "DeleteTypeProductlButton";
            this.DeleteTypeProductlButton.Size = new System.Drawing.Size(136, 36);
            this.DeleteTypeProductlButton.TabIndex = 3;
            this.DeleteTypeProductlButton.Text = "Удалить";
            this.DeleteTypeProductlButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeleteTypeProductlButton.UseAccentColor = false;
            this.DeleteTypeProductlButton.UseVisualStyleBackColor = false;
            this.DeleteTypeProductlButton.Click += new System.EventHandler(this.DeleteTypeProductlButton_Click);
            // 
            // TypesProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 437);
            this.Controls.Add(this.DeleteTypeProductlButton);
            this.Controls.Add(this.ChangeTypeProductButton);
            this.Controls.Add(this.AddTypeProductButton);
            this.Controls.Add(this.TypesProductsView);
            this.Name = "TypesProductsForm";
            this.Text = "Категории продуктов";
            ((System.ComponentModel.ISupportInitialize)(this.TypesProductsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TypesProductsView;
        private MaterialSkin.Controls.MaterialButton AddTypeProductButton;
        private MaterialSkin.Controls.MaterialButton ChangeTypeProductButton;
        private MaterialSkin.Controls.MaterialButton DeleteTypeProductlButton;
    }
}