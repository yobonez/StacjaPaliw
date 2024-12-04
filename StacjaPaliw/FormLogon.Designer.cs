namespace StacjaPaliwUI
{
    partial class FormLogon
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
            textBoxLogin = new TextBox();
            labelLogin = new Label();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(201, 40);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(446, 39);
            textBoxLogin.TabIndex = 0;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(122, 40);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(73, 32);
            labelLogin.TabIndex = 1;
            labelLogin.Text = "Login";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(121, 111);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(74, 32);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Hasło";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(201, 111);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '●';
            textBoxPassword.Size = new Size(446, 39);
            textBoxPassword.TabIndex = 2;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(201, 187);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(150, 46);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Zaloguj się";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(357, 187);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(150, 46);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Anuluj";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormLogon
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 282);
            Controls.Add(buttonCancel);
            Controls.Add(buttonLogin);
            Controls.Add(labelPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(labelLogin);
            Controls.Add(textBoxLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormLogon";
            Text = "Logowanie do panelu administracyjnego";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLogin;
        private Label labelLogin;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private Button buttonLogin;
        private Button buttonCancel;
    }
}