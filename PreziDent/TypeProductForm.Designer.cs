
namespace PreziDent
{
    partial class TypeProductForm
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
            this.TypeProductView = new System.Windows.Forms.DataGridView();
            this.AddTypeProductButton = new MaterialSkin.Controls.MaterialButton();
            this.ChangeTypeProductButton = new MaterialSkin.Controls.MaterialButton();
            this.DeleteTypeProductlButton = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.TypeProductView)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeProductView
            // 
            this.TypeProductView.AllowUserToAddRows = false;
            this.TypeProductView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TypeProductView.Location = new System.Drawing.Point(7, 77);
            this.TypeProductView.Name = "TypeProductView";
            this.TypeProductView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TypeProductView.Size = new System.Drawing.Size(462, 274);
            this.TypeProductView.TabIndex = 0;
            // 
            // AddTypeProductButton
            // 
            this.AddTypeProductButton.AutoSize = false;
            this.AddTypeProductButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddTypeProductButton.Depth = 0;
            this.AddTypeProductButton.DrawShadows = true;
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
            this.AddTypeProductButton.UseVisualStyleBackColor = true;
            // 
            // ChangeTypeProductButton
            // 
            this.ChangeTypeProductButton.AutoSize = false;
            this.ChangeTypeProductButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChangeTypeProductButton.Depth = 0;
            this.ChangeTypeProductButton.DrawShadows = true;
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
            this.ChangeTypeProductButton.UseVisualStyleBackColor = true;
            // 
            // DeleteTypeProductlButton
            // 
            this.DeleteTypeProductlButton.AutoSize = false;
            this.DeleteTypeProductlButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteTypeProductlButton.Depth = 0;
            this.DeleteTypeProductlButton.DrawShadows = true;
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
            this.DeleteTypeProductlButton.UseVisualStyleBackColor = true;
            // 
            // TypeProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 437);
            this.Controls.Add(this.DeleteTypeProductlButton);
            this.Controls.Add(this.ChangeTypeProductButton);
            this.Controls.Add(this.AddTypeProductButton);
            this.Controls.Add(this.TypeProductView);
            this.Name = "TypeProductForm";
            this.Text = "Категории продуктов";
            ((System.ComponentModel.ISupportInitialize)(this.TypeProductView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TypeProductView;
        private MaterialSkin.Controls.MaterialButton AddTypeProductButton;
        private MaterialSkin.Controls.MaterialButton ChangeTypeProductButton;
        private MaterialSkin.Controls.MaterialButton DeleteTypeProductlButton;
    }
}