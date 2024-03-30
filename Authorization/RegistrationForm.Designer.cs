namespace Authorization
{
    partial class RegistrationForm
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
            textBoxMail = new TextBox();
            buttonRegister = new Button();
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            labelEnter = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(labelInfo);
            panel1.Controls.Add(textBoxMail);
            panel1.Controls.Add(buttonRegister);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxLogin);
            panel1.Controls.Add(labelEnter);
            panel1.Location = new Point(22, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(510, 336);
            panel1.TabIndex = 4;
            // 
            // labelInfo
            // 
            labelInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelInfo.ForeColor = Color.Red;
            labelInfo.Location = new Point(19, 240);
            labelInfo.Margin = new Padding(7, 0, 7, 0);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(270, 21);
            labelInfo.TabIndex = 10;
            labelInfo.Text = "Введены неверные данные";
            labelInfo.Visible = false;
            // 
            // textBoxMail
            // 
            textBoxMail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxMail.Location = new Point(19, 189);
            textBoxMail.Margin = new Padding(12);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.PlaceholderText = "Почта";
            textBoxMail.Size = new Size(472, 39);
            textBoxMail.TabIndex = 2;
            // 
            // buttonRegister
            // 
            buttonRegister.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonRegister.BackColor = Color.FromArgb(255, 128, 128);
            buttonRegister.FlatStyle = FlatStyle.Popup;
            buttonRegister.Font = new Font("Bookman Old Style", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegister.ForeColor = Color.White;
            buttonRegister.Location = new Point(19, 282);
            buttonRegister.Margin = new Padding(12);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(472, 42);
            buttonRegister.TabIndex = 3;
            buttonRegister.Text = "Зарегистрироваться";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.Location = new Point(19, 126);
            textBoxPassword.Margin = new Padding(12);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Пароль";
            textBoxPassword.Size = new Size(472, 39);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxLogin.Location = new Point(19, 63);
            textBoxLogin.Margin = new Padding(12);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.PlaceholderText = "Логин";
            textBoxLogin.Size = new Size(472, 39);
            textBoxLogin.TabIndex = 0;
            // 
            // labelEnter
            // 
            labelEnter.AutoSize = true;
            labelEnter.Font = new Font("Bookman Old Style", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelEnter.ForeColor = Color.FromArgb(64, 64, 64);
            labelEnter.Location = new Point(19, 19);
            labelEnter.Margin = new Padding(7, 0, 7, 0);
            labelEnter.Name = "labelEnter";
            labelEnter.Size = new Size(203, 32);
            labelEnter.TabIndex = 4;
            labelEnter.Text = "Регистрация";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(17F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(103, 102, 113);
            ClientSize = new Size(554, 377);
            Controls.Add(panel1);
            Font = new Font("Bookman Old Style", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(7, 6, 7, 6);
            Name = "RegistrationForm";
            Text = "Регистрация";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBoxMail;
        private Button buttonRegister;
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private Label labelEnter;
        private Label labelInfo;
    }
}