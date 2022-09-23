﻿namespace personal_assistant_ui
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_signup = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_help = new System.Windows.Forms.Button();
            this.lbl_new_user = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loginErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_need_help = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Location = new System.Drawing.Point(279, 167);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(91, 34);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.login_Click);
            // 
            // btn_signup
            // 
            this.btn_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_signup.Location = new System.Drawing.Point(356, 267);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(62, 30);
            this.btn_signup.TabIndex = 1;
            this.btn_signup.Text = "here";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(200, 104);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(55, 13);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(200, 136);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 13);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Password";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(279, 101);
            this.tb_username.MaxLength = 30;
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(155, 20);
            this.tb_username.TabIndex = 4;
            this.tb_username.Validating += new System.ComponentModel.CancelEventHandler(this.tb_username_Validating);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(279, 133);
            this.tb_password.MaxLength = 14;
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(155, 20);
            this.tb_password.TabIndex = 5;
            this.tb_password.Validating += new System.ComponentModel.CancelEventHandler(this.tb_password_Validating);
            // 
            // btn_help
            // 
            this.btn_help.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_help.BackgroundImage")));
            this.btn_help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_help.Location = new System.Drawing.Point(647, 351);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(27, 27);
            this.btn_help.TabIndex = 7;
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbl_new_user
            // 
            this.lbl_new_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_new_user.AutoSize = true;
            this.lbl_new_user.Location = new System.Drawing.Point(241, 276);
            this.lbl_new_user.Name = "lbl_new_user";
            this.lbl_new_user.Size = new System.Drawing.Size(100, 26);
            this.lbl_new_user.TabIndex = 8;
            this.lbl_new_user.Text = "New user ? Sign up\r\n\r\n";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // loginErrorProvider
            // 
            this.loginErrorProvider.BlinkRate = 0;
            this.loginErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.loginErrorProvider.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 20);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbl_need_help
            // 
            this.lbl_need_help.AutoSize = true;
            this.lbl_need_help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_need_help.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lbl_need_help.Location = new System.Drawing.Point(552, 351);
            this.lbl_need_help.Name = "lbl_need_help";
            this.lbl_need_help.Size = new System.Drawing.Size(89, 20);
            this.lbl_need_help.TabIndex = 15;
            this.lbl_need_help.Text = "Need help ?";
            this.lbl_need_help.Click += new System.EventHandler(this.label5_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_need_help);
            this.Controls.Add(this.lbl_new_user);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.btn_login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Assistant - Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_login;
        private Button btn_signup;
        private Label lbl_username;
        private Label lbl_password;
        private TextBox tb_username;
        private TextBox tb_password;
        private Button btn_help;
        private Label lbl_new_user;
        private ContextMenuStrip contextMenuStrip1;
        private ErrorProvider loginErrorProvider;
        private Button button1;
        private Label lbl_need_help;
    }
}