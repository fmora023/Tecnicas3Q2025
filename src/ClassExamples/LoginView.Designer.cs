namespace ClassExamples
{
    partial class LoginView
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
            btn_Login = new Button();
            label1 = new Label();
            label2 = new Label();
            txt_UserName = new TextBox();
            txt_Password = new TextBox();
            txt_RegisterUser = new Button();
            SuspendLayout();
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(95, 373);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(151, 65);
            btn_Login.TabIndex = 0;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += BtnLoginClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 70);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 139);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(162, 70);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(174, 27);
            txt_UserName.TabIndex = 3;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(162, 139);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(174, 27);
            txt_Password.TabIndex = 4;
            // 
            // txt_RegisterUser
            // 
            txt_RegisterUser.Location = new Point(285, 373);
            txt_RegisterUser.Name = "txt_RegisterUser";
            txt_RegisterUser.Size = new Size(151, 65);
            txt_RegisterUser.TabIndex = 5;
            txt_RegisterUser.Text = "Register User";
            txt_RegisterUser.UseVisualStyleBackColor = true;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 512);
            Controls.Add(txt_RegisterUser);
            Controls.Add(txt_Password);
            Controls.Add(txt_UserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Login);
            Name = "LoginView";
            Text = "LoginView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Login;
        private Label label1;
        private Label label2;
        private TextBox txt_UserName;
        private TextBox txt_Password;
        private Button txt_RegisterUser;
    }
}