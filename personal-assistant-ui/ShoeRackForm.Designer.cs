namespace personal_assistant_ui
{
    partial class ShoeRackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoeRackForm));
            this.btn_help = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_spray = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_shoe_right = new System.Windows.Forms.Button();
            this.btn_shoe_left = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_help1 = new System.Windows.Forms.Label();
            this.imagelist_shoerack = new System.Windows.Forms.ImageList(this.components);
            this.btn_back1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_help
            // 
            this.btn_help.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_help.BackgroundImage")));
            this.btn_help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_help.Location = new System.Drawing.Point(757, 407);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(31, 31);
            this.btn_help.TabIndex = 4;
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btn_spray);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_shoe_right);
            this.groupBox1.Controls.Add(this.btn_shoe_left);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 393);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Smart Shoe Rack Controls";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tuesday 27/9/2022",
            "Wendsay 28/9/2022",
            "Friday 29/9/2022"});
            this.comboBox1.Location = new System.Drawing.Point(6, 318);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 23);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.Text = "Monday 26/9/2022 (Tommorow)";
            // 
            // btn_spray
            // 
            this.btn_spray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_spray.Location = new System.Drawing.Point(6, 81);
            this.btn_spray.Name = "btn_spray";
            this.btn_spray.Size = new System.Drawing.Size(120, 28);
            this.btn_spray.TabIndex = 31;
            this.btn_spray.Text = "Strart spraying";
            this.btn_spray.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(289, 30);
            this.label8.TabIndex = 30;
            this.label8.Text = "Here you will find shoe suggestions for a specific day.\nPlease select a date in t" +
    "he dropdown menu below.\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Suggest shoes";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(6, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 1);
            this.label6.TabIndex = 28;
            // 
            // btn_shoe_right
            // 
            this.btn_shoe_right.BackgroundImage = global::personal_assistant_ui.Properties.Resources.right;
            this.btn_shoe_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_shoe_right.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_shoe_right.Location = new System.Drawing.Point(331, 175);
            this.btn_shoe_right.Name = "btn_shoe_right";
            this.btn_shoe_right.Size = new System.Drawing.Size(36, 36);
            this.btn_shoe_right.TabIndex = 27;
            this.btn_shoe_right.UseVisualStyleBackColor = true;
            // 
            // btn_shoe_left
            // 
            this.btn_shoe_left.BackgroundImage = global::personal_assistant_ui.Properties.Resources.left;
            this.btn_shoe_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_shoe_left.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_shoe_left.Location = new System.Drawing.Point(279, 175);
            this.btn_shoe_left.Name = "btn_shoe_left";
            this.btn_shoe_left.Size = new System.Drawing.Size(36, 36);
            this.btn_shoe_left.TabIndex = 26;
            this.btn_shoe_left.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Look through the shoes of your smart shoe rack.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "My shoes";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(6, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 1);
            this.label3.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 30);
            this.label2.TabIndex = 22;
            this.label2.Text = "Spray your shoes with a specxial deodorant.\nNote: this may take some time, please" +
    " be patient.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Shoe deodorant";
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = global::personal_assistant_ui.Properties.Resources.back;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Location = new System.Drawing.Point(11, 9);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(30, 30);
            this.btn_back.TabIndex = 17;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_help1
            // 
            this.btn_help1.AutoSize = true;
            this.btn_help1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_help1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_help1.Location = new System.Drawing.Point(662, 411);
            this.btn_help1.Name = "btn_help1";
            this.btn_help1.Size = new System.Drawing.Size(89, 20);
            this.btn_help1.TabIndex = 19;
            this.btn_help1.Text = "Need help ?";
            this.btn_help1.Click += new System.EventHandler(this.btn_help1_Click);
            // 
            // imagelist_shoerack
            // 
            this.imagelist_shoerack.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imagelist_shoerack.ImageSize = new System.Drawing.Size(16, 16);
            this.imagelist_shoerack.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn_back1
            // 
            this.btn_back1.AutoSize = true;
            this.btn_back1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_back1.Location = new System.Drawing.Point(43, 9);
            this.btn_back1.Name = "btn_back1";
            this.btn_back1.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.btn_back1.Size = new System.Drawing.Size(47, 30);
            this.btn_back1.TabIndex = 18;
            this.btn_back1.Text = "Back";
            this.btn_back1.Click += new System.EventHandler(this.label8_Click);
            // 
            // ShoeRackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_help1);
            this.Controls.Add(this.btn_back1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_help);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShoeRackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Assistant - Smart Shoe Rack";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_help;
        private GroupBox groupBox1;
        private Button btn_back;
        private Label btn_help1;
        private ImageList imagelist_shoerack;
        private Label btn_back1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private Button btn_shoe_right;
        private Button btn_shoe_left;
        private Button btn_spray;
        private Label label8;
        private Label label7;
        private Label label6;
        private ComboBox comboBox1;
    }
}