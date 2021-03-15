
namespace PreziDent
{
    partial class FirmForm
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
            this.NotesFirm = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.CnclButton = new MaterialSkin.Controls.MaterialButton();
            this.OkButton = new MaterialSkin.Controls.MaterialButton();
            this.NotesFirmLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AddressFirm = new MaterialSkin.Controls.MaterialTextBox();
            this.AddresFirmLabel = new MaterialSkin.Controls.MaterialLabel();
            this.NameFirm = new MaterialSkin.Controls.MaterialTextBox();
            this.NameFirmLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // NotesFirm
            // 
            this.NotesFirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NotesFirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotesFirm.Depth = 0;
            this.NotesFirm.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NotesFirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NotesFirm.Hint = "";
            this.NotesFirm.Location = new System.Drawing.Point(55, 300);
            this.NotesFirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.NotesFirm.Name = "NotesFirm";
            this.NotesFirm.Size = new System.Drawing.Size(287, 96);
            this.NotesFirm.TabIndex = 8;
            this.NotesFirm.Text = "";
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
            this.CnclButton.Location = new System.Drawing.Point(176, 424);
            this.CnclButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CnclButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CnclButton.Name = "CnclButton";
            this.CnclButton.Size = new System.Drawing.Size(166, 36);
            this.CnclButton.TabIndex = 7;
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
            this.OkButton.Location = new System.Drawing.Point(55, 424);
            this.OkButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OkButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(113, 36);
            this.OkButton.TabIndex = 6;
            this.OkButton.Text = "Ок";
            this.OkButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.OkButton.UseAccentColor = false;
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // NotesFirmLabel
            // 
            this.NotesFirmLabel.AutoSize = true;
            this.NotesFirmLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.NotesFirmLabel.Depth = 0;
            this.NotesFirmLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NotesFirmLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NotesFirmLabel.Location = new System.Drawing.Point(52, 278);
            this.NotesFirmLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.NotesFirmLabel.Name = "NotesFirmLabel";
            this.NotesFirmLabel.Size = new System.Drawing.Size(98, 19);
            this.NotesFirmLabel.TabIndex = 4;
            this.NotesFirmLabel.Text = "Примечание:";
            // 
            // AddressFirm
            // 
            this.AddressFirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddressFirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressFirm.Depth = 0;
            this.AddressFirm.Font = new System.Drawing.Font("Roboto", 12F);
            this.AddressFirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddressFirm.Location = new System.Drawing.Point(55, 201);
            this.AddressFirm.MaxLength = 50;
            this.AddressFirm.MouseState = MaterialSkin.MouseState.OUT;
            this.AddressFirm.Multiline = false;
            this.AddressFirm.Name = "AddressFirm";
            this.AddressFirm.Size = new System.Drawing.Size(287, 50);
            this.AddressFirm.TabIndex = 3;
            this.AddressFirm.Text = "";
            // 
            // AddresFirmLabel
            // 
            this.AddresFirmLabel.AutoSize = true;
            this.AddresFirmLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddresFirmLabel.Depth = 0;
            this.AddresFirmLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AddresFirmLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddresFirmLabel.Location = new System.Drawing.Point(52, 179);
            this.AddresFirmLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddresFirmLabel.Name = "AddresFirmLabel";
            this.AddresFirmLabel.Size = new System.Drawing.Size(50, 19);
            this.AddresFirmLabel.TabIndex = 2;
            this.AddresFirmLabel.Text = "Адрес:";
            // 
            // NameFirm
            // 
            this.NameFirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.NameFirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameFirm.Depth = 0;
            this.NameFirm.Font = new System.Drawing.Font("Roboto", 12F);
            this.NameFirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NameFirm.Location = new System.Drawing.Point(55, 112);
            this.NameFirm.MaxLength = 50;
            this.NameFirm.MouseState = MaterialSkin.MouseState.OUT;
            this.NameFirm.Multiline = false;
            this.NameFirm.Name = "NameFirm";
            this.NameFirm.Size = new System.Drawing.Size(287, 50);
            this.NameFirm.TabIndex = 1;
            this.NameFirm.Text = "";
            // 
            // NameFirmLabel
            // 
            this.NameFirmLabel.AutoSize = true;
            this.NameFirmLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.NameFirmLabel.Depth = 0;
            this.NameFirmLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NameFirmLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NameFirmLabel.Location = new System.Drawing.Point(52, 90);
            this.NameFirmLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.NameFirmLabel.Name = "NameFirmLabel";
            this.NameFirmLabel.Size = new System.Drawing.Size(116, 19);
            this.NameFirmLabel.TabIndex = 0;
            this.NameFirmLabel.Text = "Наименование:";
            // 
            // FirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 496);
            this.Controls.Add(this.NotesFirm);
            this.Controls.Add(this.CnclButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.NotesFirmLabel);
            this.Controls.Add(this.AddressFirm);
            this.Controls.Add(this.AddresFirmLabel);
            this.Controls.Add(this.NameFirm);
            this.Controls.Add(this.NameFirmLabel);
            this.Name = "FirmForm";
            this.Text = "Фирма";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel AddresFirmLabel;
        private MaterialSkin.Controls.MaterialLabel NotesFirmLabel;
        private MaterialSkin.Controls.MaterialLabel NameFirmLabel;
        private MaterialSkin.Controls.MaterialButton OkButton;
        private MaterialSkin.Controls.MaterialButton CnclButton;
        protected internal MaterialSkin.Controls.MaterialMultiLineTextBox NotesFirm;
        protected internal MaterialSkin.Controls.MaterialTextBox NameFirm;
        protected internal MaterialSkin.Controls.MaterialTextBox AddressFirm;
    }
}