
namespace PreziDent
{
    partial class ServiceForm
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
            this.CodeService = new MaterialSkin.Controls.MaterialTextBox();
            this.CodeServiceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.NameService = new MaterialSkin.Controls.MaterialTextBox();
            this.NameServiceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.GroupService = new MaterialSkin.Controls.MaterialComboBox();
            this.groupservicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GroupServiceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PriceService = new MaterialSkin.Controls.MaterialTextBox();
            this.PriceServiceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.DescriptionService = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.DescriptionServiceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.OkButton = new MaterialSkin.Controls.MaterialButton();
            this.CnclButton = new MaterialSkin.Controls.MaterialButton();
            this.AddGroupServiceLink = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.groupservicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CodeService
            // 
            this.CodeService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CodeService.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CodeService.Depth = 0;
            this.CodeService.Font = new System.Drawing.Font("Roboto", 12F);
            this.CodeService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CodeService.Location = new System.Drawing.Point(59, 116);
            this.CodeService.MaxLength = 50;
            this.CodeService.MouseState = MaterialSkin.MouseState.OUT;
            this.CodeService.Multiline = false;
            this.CodeService.Name = "CodeService";
            this.CodeService.Size = new System.Drawing.Size(216, 50);
            this.CodeService.TabIndex = 0;
            this.CodeService.Text = "";
            // 
            // CodeServiceLabel
            // 
            this.CodeServiceLabel.AutoSize = true;
            this.CodeServiceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CodeServiceLabel.Depth = 0;
            this.CodeServiceLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CodeServiceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CodeServiceLabel.Location = new System.Drawing.Point(56, 94);
            this.CodeServiceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.CodeServiceLabel.Name = "CodeServiceLabel";
            this.CodeServiceLabel.Size = new System.Drawing.Size(34, 19);
            this.CodeServiceLabel.TabIndex = 1;
            this.CodeServiceLabel.Text = "Код:";
            // 
            // NameService
            // 
            this.NameService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.NameService.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameService.Depth = 0;
            this.NameService.Font = new System.Drawing.Font("Roboto", 12F);
            this.NameService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NameService.Location = new System.Drawing.Point(59, 212);
            this.NameService.MaxLength = 50;
            this.NameService.MouseState = MaterialSkin.MouseState.OUT;
            this.NameService.Multiline = false;
            this.NameService.Name = "NameService";
            this.NameService.Size = new System.Drawing.Size(216, 50);
            this.NameService.TabIndex = 2;
            this.NameService.Text = "";
            // 
            // NameServiceLabel
            // 
            this.NameServiceLabel.AutoSize = true;
            this.NameServiceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.NameServiceLabel.Depth = 0;
            this.NameServiceLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NameServiceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NameServiceLabel.Location = new System.Drawing.Point(56, 190);
            this.NameServiceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.NameServiceLabel.Name = "NameServiceLabel";
            this.NameServiceLabel.Size = new System.Drawing.Size(116, 19);
            this.NameServiceLabel.TabIndex = 3;
            this.NameServiceLabel.Text = "Наименование:";
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
            this.GroupService.Location = new System.Drawing.Point(59, 309);
            this.GroupService.MaxDropDownItems = 4;
            this.GroupService.MouseState = MaterialSkin.MouseState.OUT;
            this.GroupService.Name = "GroupService";
            this.GroupService.Size = new System.Drawing.Size(216, 49);
            this.GroupService.TabIndex = 4;
            this.GroupService.ValueMember = "id";
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
            this.GroupServiceLabel.Location = new System.Drawing.Point(56, 287);
            this.GroupServiceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.GroupServiceLabel.Name = "GroupServiceLabel";
            this.GroupServiceLabel.Size = new System.Drawing.Size(58, 19);
            this.GroupServiceLabel.TabIndex = 5;
            this.GroupServiceLabel.Text = "Группа:";
            // 
            // PriceService
            // 
            this.PriceService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.PriceService.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceService.Depth = 0;
            this.PriceService.Font = new System.Drawing.Font("Roboto", 12F);
            this.PriceService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PriceService.Location = new System.Drawing.Point(59, 420);
            this.PriceService.MaxLength = 50;
            this.PriceService.MouseState = MaterialSkin.MouseState.OUT;
            this.PriceService.Multiline = false;
            this.PriceService.Name = "PriceService";
            this.PriceService.Size = new System.Drawing.Size(216, 50);
            this.PriceService.TabIndex = 6;
            this.PriceService.Text = "";
            // 
            // PriceServiceLabel
            // 
            this.PriceServiceLabel.AutoSize = true;
            this.PriceServiceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.PriceServiceLabel.Depth = 0;
            this.PriceServiceLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PriceServiceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PriceServiceLabel.Location = new System.Drawing.Point(56, 398);
            this.PriceServiceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.PriceServiceLabel.Name = "PriceServiceLabel";
            this.PriceServiceLabel.Size = new System.Drawing.Size(43, 19);
            this.PriceServiceLabel.TabIndex = 7;
            this.PriceServiceLabel.Text = "Цена:";
            // 
            // DescriptionService
            // 
            this.DescriptionService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DescriptionService.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionService.Depth = 0;
            this.DescriptionService.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DescriptionService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DescriptionService.Hint = "";
            this.DescriptionService.Location = new System.Drawing.Point(343, 116);
            this.DescriptionService.MouseState = MaterialSkin.MouseState.HOVER;
            this.DescriptionService.Name = "DescriptionService";
            this.DescriptionService.Size = new System.Drawing.Size(301, 242);
            this.DescriptionService.TabIndex = 8;
            this.DescriptionService.Text = "";
            // 
            // DescriptionServiceLabel
            // 
            this.DescriptionServiceLabel.AutoSize = true;
            this.DescriptionServiceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DescriptionServiceLabel.Depth = 0;
            this.DescriptionServiceLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DescriptionServiceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DescriptionServiceLabel.Location = new System.Drawing.Point(340, 94);
            this.DescriptionServiceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.DescriptionServiceLabel.Name = "DescriptionServiceLabel";
            this.DescriptionServiceLabel.Size = new System.Drawing.Size(77, 19);
            this.DescriptionServiceLabel.TabIndex = 9;
            this.DescriptionServiceLabel.Text = "Описание:";
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
            this.OkButton.Location = new System.Drawing.Point(343, 429);
            this.OkButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OkButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(89, 36);
            this.OkButton.TabIndex = 10;
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
            this.CnclButton.Location = new System.Drawing.Point(461, 429);
            this.CnclButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CnclButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CnclButton.Name = "CnclButton";
            this.CnclButton.Size = new System.Drawing.Size(183, 36);
            this.CnclButton.TabIndex = 11;
            this.CnclButton.Text = "Отмена";
            this.CnclButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CnclButton.UseAccentColor = false;
            this.CnclButton.UseVisualStyleBackColor = false;
            // 
            // AddGroupServiceLink
            // 
            this.AddGroupServiceLink.AutoSize = true;
            this.AddGroupServiceLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddGroupServiceLink.Depth = 0;
            this.AddGroupServiceLink.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AddGroupServiceLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddGroupServiceLink.Location = new System.Drawing.Point(56, 361);
            this.AddGroupServiceLink.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddGroupServiceLink.Name = "AddGroupServiceLink";
            this.AddGroupServiceLink.Size = new System.Drawing.Size(129, 19);
            this.AddGroupServiceLink.TabIndex = 12;
            this.AddGroupServiceLink.Text = "Добавить группу";
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 514);
            this.Controls.Add(this.AddGroupServiceLink);
            this.Controls.Add(this.CnclButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.DescriptionServiceLabel);
            this.Controls.Add(this.DescriptionService);
            this.Controls.Add(this.PriceServiceLabel);
            this.Controls.Add(this.PriceService);
            this.Controls.Add(this.GroupServiceLabel);
            this.Controls.Add(this.GroupService);
            this.Controls.Add(this.NameServiceLabel);
            this.Controls.Add(this.NameService);
            this.Controls.Add(this.CodeServiceLabel);
            this.Controls.Add(this.CodeService);
            this.Name = "ServiceForm";
            this.Text = "Услуга";
            ((System.ComponentModel.ISupportInitialize)(this.groupservicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel CodeServiceLabel;
        private MaterialSkin.Controls.MaterialLabel NameServiceLabel;
        protected internal MaterialSkin.Controls.MaterialTextBox CodeService;
        protected internal MaterialSkin.Controls.MaterialTextBox NameService;
        private MaterialSkin.Controls.MaterialLabel GroupServiceLabel;
        protected internal MaterialSkin.Controls.MaterialComboBox GroupService;
        protected internal MaterialSkin.Controls.MaterialTextBox PriceService;
        private MaterialSkin.Controls.MaterialLabel PriceServiceLabel;
        private MaterialSkin.Controls.MaterialLabel DescriptionServiceLabel;
        private MaterialSkin.Controls.MaterialButton OkButton;
        private MaterialSkin.Controls.MaterialButton CnclButton;
        protected internal MaterialSkin.Controls.MaterialMultiLineTextBox DescriptionService;
        private MaterialSkin.Controls.MaterialLabel AddGroupServiceLink;
        private System.Windows.Forms.BindingSource groupservicesBindingSource;
    }
}