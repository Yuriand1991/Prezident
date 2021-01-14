namespace PreziDent
{
    partial class LoginForm
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
            this.LoginButton = new MaterialSkin.Controls.MaterialButton();
            this.LoginField = new MaterialSkin.Controls.MaterialTextBox();
            this.PasswordField = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.AutoSize = false;
            this.LoginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginButton.Depth = 0;
            this.LoginButton.DrawShadows = true;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.HighEmphasis = true;
            this.LoginButton.Icon = null;
            this.LoginButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LoginButton.Location = new System.Drawing.Point(102, 281);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(110, 38);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Войти";
            this.LoginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.LoginButton.UseAccentColor = false;
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginField
            // 
            this.LoginField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginField.Depth = 0;
            this.LoginField.Font = new System.Drawing.Font("Roboto", 12F);
            this.LoginField.Hint = "Введите логин";
            this.LoginField.Location = new System.Drawing.Point(61, 134);
            this.LoginField.MaxLength = 50;
            this.LoginField.MouseState = MaterialSkin.MouseState.OUT;
            this.LoginField.Multiline = false;
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(191, 50);
            this.LoginField.TabIndex = 1;
            this.LoginField.Text = "";
            // 
            // PasswordField
            // 
            this.PasswordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordField.Depth = 0;
            this.PasswordField.Font = new System.Drawing.Font("Roboto", 12F);
            this.PasswordField.Hint = "Введите пароль";
            this.PasswordField.Location = new System.Drawing.Point(61, 206);
            this.PasswordField.MaxLength = 50;
            this.PasswordField.MouseState = MaterialSkin.MouseState.OUT;
            this.PasswordField.Multiline = false;
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Password = true;
            this.PasswordField.Size = new System.Drawing.Size(191, 50);
            this.PasswordField.TabIndex = 2;
            this.PasswordField.Text = "";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 372);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.LoginField);
            this.Controls.Add(this.LoginButton);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton LoginButton;
        private MaterialSkin.Controls.MaterialTextBox LoginField;
        private MaterialSkin.Controls.MaterialTextBox PasswordField;
    }
}