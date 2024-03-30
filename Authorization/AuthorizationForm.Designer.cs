namespace Authorization
{
    partial class AuthorizationForm
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
            panel1 = new Panel();
            labelInfo = new Label();
            pictureBoxLogo = new PictureBox();
            buttonRegister = new Button();
            buttonLogin = new Button();
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            labelEnter = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(labelInfo);
            panel1.Controls.Add(pictureBoxLogo);
            panel1.Controls.Add(buttonRegister);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxLogin);
            panel1.Controls.Add(labelEnter);
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(508, 318);
            panel1.TabIndex = 3;
            // 
            // labelInfo
            // 
            labelInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelInfo.ForeColor = Color.Red;
            labelInfo.Location = new Point(19, 175);
            labelInfo.Margin = new Padding(7, 0, 7, 0);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(270, 21);
            labelInfo.TabIndex = 11;
            labelInfo.Text = "Введены неверные данные";
            labelInfo.Visible = false;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxLogo.Image = Properties.Resources.logo;
            pictureBoxLogo.Location = new Point(429, 10);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(60, 50);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 9;
            pictureBoxLogo.TabStop = false;
            // 
            // buttonRegister
            // 
            buttonRegister.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonRegister.BackColor = Color.Gray;
            buttonRegister.FlatStyle = FlatStyle.Popup;
            buttonRegister.Font = new Font("Bookman Old Style", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegister.ForeColor = Color.White;
            buttonRegister.Location = new Point(19, 253);
            buttonRegister.Margin = new Padding(12);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(470, 42);
            buttonRegister.TabIndex = 8;
            buttonRegister.Text = "Зарегистрироваться";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonLogin.BackColor = Color.FromArgb(255, 128, 128);
            buttonLogin.FlatStyle = FlatStyle.Popup;
            buttonLogin.Font = new Font("Bookman Old Style", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(19, 205);
            buttonLogin.Margin = new Padding(12);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(470, 42);
            buttonLogin.TabIndex = 7;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.Location = new Point(19, 124);
            textBoxPassword.Margin = new Padding(12);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Пароль";
            textBoxPassword.Size = new Size(470, 39);
            textBoxPassword.TabIndex = 6;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxLogin.Location = new Point(19, 66);
            textBoxLogin.Margin = new Padding(12);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.PlaceholderText = "Логин";
            textBoxLogin.Size = new Size(470, 39);
            textBoxLogin.TabIndex = 5;
            // 
            // labelEnter
            // 
            labelEnter.AutoSize = true;
            labelEnter.Font = new Font("Bookman Old Style", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelEnter.ForeColor = Color.FromArgb(64, 64, 64);
            labelEnter.Location = new Point(19, 19);
            labelEnter.Margin = new Padding(7, 0, 7, 0);
            labelEnter.Name = "labelEnter";
            labelEnter.Size = new Size(86, 32);
            labelEnter.TabIndex = 4;
            labelEnter.Text = "Вход";
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(17F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(103, 102, 113);
            ClientSize = new Size(552, 359);
            Controls.Add(panel1);
            Font = new Font("Bookman Old Style", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(7, 6, 7, 6);
            Name = "AuthorizationForm";
            Text = "Авторизация";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Button buttonRegister;
        private Button buttonLogin;
        private Label labelEnter;
        private PictureBox pictureBoxLogo;
        private Label labelInfo;
    }
}