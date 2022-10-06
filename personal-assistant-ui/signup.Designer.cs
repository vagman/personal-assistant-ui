namespace personal_assistant_ui
{
    partial class signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signup));
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_password_confirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_full_name = new System.Windows.Forms.TextBox();
            this.signupErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_back1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lbl_need_help = new System.Windows.Forms.Label();
            this.button1 = new personal_assistant_ui.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.signupErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(353, 62);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(206, 26);
            this.tb_username.TabIndex = 1;
            this.tb_username.Validating += new System.ComponentModel.CancelEventHandler(this.tb_username_Validating);
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(354, 152);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(205, 26);
            this.tb_email.TabIndex = 2;
            this.tb_email.Validating += new System.ComponentModel.CancelEventHandler(this.tb_email_Validating);
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(354, 195);
            this.tb_password.MaxLength = 14;
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(205, 26);
            this.tb_password.TabIndex = 3;
            this.tb_password.Validating += new System.ComponentModel.CancelEventHandler(this.tb_password_Validating);
            // 
            // tb_password_confirm
            // 
            this.tb_password_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password_confirm.Location = new System.Drawing.Point(354, 237);
            this.tb_password_confirm.MaxLength = 14;
            this.tb_password_confirm.Name = "tb_password_confirm";
            this.tb_password_confirm.PasswordChar = '*';
            this.tb_password_confirm.Size = new System.Drawing.Size(205, 26);
            this.tb_password_confirm.TabIndex = 4;
            this.tb_password_confirm.Validating += new System.ComponentModel.CancelEventHandler(this.tb_password_confirm_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(195, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Confirm Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(195, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Full Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tb_full_name
            // 
            this.tb_full_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_full_name.Location = new System.Drawing.Point(353, 103);
            this.tb_full_name.Name = "tb_full_name";
            this.tb_full_name.Size = new System.Drawing.Size(206, 26);
            this.tb_full_name.TabIndex = 10;
            this.tb_full_name.Validating += new System.ComponentModel.CancelEventHandler(this.tb_full_name_Validating);
            // 
            // signupErrorProvider
            // 
            this.signupErrorProvider.ContainerControl = this;
            // 
            // btn_back1
            // 
            this.btn_back1.AutoSize = true;
            this.btn_back1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back1.Location = new System.Drawing.Point(38, 10);
            this.btn_back1.Name = "btn_back1";
            this.btn_back1.Padding = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.btn_back1.Size = new System.Drawing.Size(50, 29);
            this.btn_back1.TabIndex = 20;
            this.btn_back1.Text = "Back";
            this.btn_back1.Click += new System.EventHandler(this.btn_back1_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Location = new System.Drawing.Point(10, 10);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(26, 26);
            this.btn_back.TabIndex = 19;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(596, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 35);
            this.button3.TabIndex = 13;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(596, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(787, 414);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 35);
            this.button4.TabIndex = 11;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbl_need_help
            // 
            this.lbl_need_help.AutoSize = true;
            this.lbl_need_help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_need_help.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_need_help.Location = new System.Drawing.Point(689, 419);
            this.lbl_need_help.Name = "lbl_need_help";
            this.lbl_need_help.Size = new System.Drawing.Size(92, 21);
            this.lbl_need_help.TabIndex = 21;
            this.lbl_need_help.Text = "Need help ?";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(352, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sign up now!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.lbl_need_help);
            this.Controls.Add(this.btn_back1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tb_full_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_password_confirm);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Assistant - Sign up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.signup_FormClosing);
            this.Load += new System.EventHandler(this.signup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.signupErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tb_username;
        private TextBox tb_email;
        private TextBox tb_password;
        private TextBox tb_password_confirm;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tb_full_name;
        private Button button4;
        private Button button2;
        private Button button3;
        private ErrorProvider signupErrorProvider;
        private Label btn_back1;
        private Button btn_back;
        private Label lbl_need_help;
        private RoundedButton button1;
    }
}