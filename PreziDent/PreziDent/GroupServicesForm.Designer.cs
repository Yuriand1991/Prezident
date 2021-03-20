
namespace PreziDent
{
    partial class GroupServicesForm
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
            this.NameGroupServices = new MaterialSkin.Controls.MaterialTextBox();
            this.OkButton = new MaterialSkin.Controls.MaterialButton();
            this.CnclButton = new MaterialSkin.Controls.MaterialButton();
            this.NameGroupServicesLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // NameGroupServices
            // 
            this.NameGroupServices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameGroupServices.Depth = 0;
            this.NameGroupServices.Font = new System.Drawing.Font("Roboto", 12F);
            this.NameGroupServices.Hint = "Введите наименование";
            this.NameGroupServices.Location = new System.Drawing.Point(36, 104);
            this.NameGroupServices.MaxLength = 50;
            this.NameGroupServices.MouseState = MaterialSkin.MouseState.OUT;
            this.NameGroupServices.Multiline = false;
            this.NameGroupServices.Name = "NameGroupServices";
            this.NameGroupServices.Size = new System.Drawing.Size(308, 50);
            this.NameGroupServices.TabIndex = 0;
            this.NameGroupServices.Text = "";
            // 
            // OkButton
            // 
            this.OkButton.AutoSize = false;
            this.OkButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OkButton.Depth = 0;
            this.OkButton.DrawShadows = true;
            this.OkButton.HighEmphasis = true;
            this.OkButton.Icon = null;
            this.OkButton.Location = new System.Drawing.Point(36, 174);
            this.OkButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OkButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(105, 36);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "ОК";
            this.OkButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.OkButton.UseAccentColor = false;
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CnclButton
            // 
            this.CnclButton.AutoSize = false;
            this.CnclButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CnclButton.Depth = 0;
            this.CnclButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CnclButton.DrawShadows = true;
            this.CnclButton.HighEmphasis = true;
            this.CnclButton.Icon = null;
            this.CnclButton.Location = new System.Drawing.Point(167, 174);
            this.CnclButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CnclButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CnclButton.Name = "CnclButton";
            this.CnclButton.Size = new System.Drawing.Size(177, 36);
            this.CnclButton.TabIndex = 2;
            this.CnclButton.Text = "Отмена";
            this.CnclButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CnclButton.UseAccentColor = false;
            this.CnclButton.UseVisualStyleBackColor = true;
            // 
            // NameGroupServicesLabel
            // 
            this.NameGroupServicesLabel.AutoSize = true;
            this.NameGroupServicesLabel.Depth = 0;
            this.NameGroupServicesLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NameGroupServicesLabel.Location = new System.Drawing.Point(33, 82);
            this.NameGroupServicesLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.NameGroupServicesLabel.Name = "NameGroupServicesLabel";
            this.NameGroupServicesLabel.Size = new System.Drawing.Size(174, 19);
            this.NameGroupServicesLabel.TabIndex = 3;
            this.NameGroupServicesLabel.Text = "Наименование группы:";
            // 
            // GroupServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 233);
            this.Controls.Add(this.NameGroupServicesLabel);
            this.Controls.Add(this.CnclButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.NameGroupServices);
            this.Name = "GroupServicesForm";
            this.Text = "Группа услуг";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton OkButton;
        private MaterialSkin.Controls.MaterialButton CnclButton;
        private MaterialSkin.Controls.MaterialLabel NameGroupServicesLabel;
        protected internal MaterialSkin.Controls.MaterialTextBox NameGroupServices;
    }
}