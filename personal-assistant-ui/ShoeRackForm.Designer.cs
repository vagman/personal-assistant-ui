using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoeRackForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_no_shoes = new System.Windows.Forms.Label();
            this.cb_date = new System.Windows.Forms.ComboBox();
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
            this.btn_help1 = new System.Windows.Forms.Label();
            this.btn_back1 = new System.Windows.Forms.Label();
            this.pb_shoes = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_shoe_name = new System.Windows.Forms.Label();
            this.lbl_shoe_use = new System.Windows.Forms.Label();
            this.lbl_shoe_sz = new System.Windows.Forms.Label();
            this.lbl_shoe_size = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_buy_new_shoes = new System.Windows.Forms.Label();
            this.lbl_link_skroutz = new System.Windows.Forms.LinkLabel();
            this.lbl_buy_new_shoes1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_shoes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lbl_no_shoes);
            this.groupBox1.Controls.Add(this.cb_date);
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
            this.groupBox1.Size = new System.Drawing.Size(486, 397);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Smart Shoe Rack Controls";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(299, 217);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.label12.Size = new System.Drawing.Size(74, 30);
            this.label12.TabIndex = 34;
            this.label12.Text = "Previous";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(379, 217);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.label11.Size = new System.Drawing.Size(48, 30);
            this.label11.TabIndex = 33;
            this.label11.Text = "Next";
            // 
            // lbl_no_shoes
            // 
            this.lbl_no_shoes.AutoSize = true;
            this.lbl_no_shoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_no_shoes.ForeColor = System.Drawing.Color.Red;
            this.lbl_no_shoes.Location = new System.Drawing.Point(274, 136);
            this.lbl_no_shoes.Name = "lbl_no_shoes";
            this.lbl_no_shoes.Size = new System.Drawing.Size(191, 26);
            this.lbl_no_shoes.TabIndex = 33;
            this.lbl_no_shoes.Text = "You don\'t have any other shoes.\nPlease try using the other arrow.";
            this.lbl_no_shoes.Visible = false;
            // 
            // cb_date
            // 
            this.cb_date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_date.FormattingEnabled = true;
            this.cb_date.Items.AddRange(new object[] {
            "Tuesday 27/9/2022",
            "Wendsay 28/9/2022",
            "Friday 29/9/2022",
            "Saturday 30/9/2022"});
            this.cb_date.Location = new System.Drawing.Point(6, 327);
            this.cb_date.Name = "cb_date";
            this.cb_date.Size = new System.Drawing.Size(231, 24);
            this.cb_date.TabIndex = 32;
            this.cb_date.Text = "Monday 26/9/2022 (Tommorow)";
            this.cb_date.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_spray
            // 
            this.btn_spray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_spray.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_spray.Location = new System.Drawing.Point(10, 88);
            this.btn_spray.Name = "btn_spray";
            this.btn_spray.Size = new System.Drawing.Size(133, 36);
            this.btn_spray.TabIndex = 31;
            this.btn_spray.Text = "Strart spraying";
            this.btn_spray.UseVisualStyleBackColor = true;
            this.btn_spray.Click += new System.EventHandler(this.btn_spray_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(323, 32);
            this.label8.TabIndex = 30;
            this.label8.Text = "Here you will find shoe suggestions for a specific day.\nPlease select a date in t" +
    "he dropdown menu below.\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
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
            this.btn_shoe_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_shoe_right.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_shoe_right.Image = ((System.Drawing.Image)(resources.GetObject("btn_shoe_right.Image")));
            this.btn_shoe_right.Location = new System.Drawing.Point(383, 178);
            this.btn_shoe_right.Name = "btn_shoe_right";
            this.btn_shoe_right.Size = new System.Drawing.Size(36, 36);
            this.btn_shoe_right.TabIndex = 27;
            this.btn_shoe_right.UseVisualStyleBackColor = true;
            this.btn_shoe_right.Click += new System.EventHandler(this.btn_shoe_right_Click);
            // 
            // btn_shoe_left
            // 
            this.btn_shoe_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_shoe_left.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_shoe_left.Image = ((System.Drawing.Image)(resources.GetObject("btn_shoe_left.Image")));
            this.btn_shoe_left.Location = new System.Drawing.Point(319, 178);
            this.btn_shoe_left.Name = "btn_shoe_left";
            this.btn_shoe_left.Size = new System.Drawing.Size(36, 36);
            this.btn_shoe_left.TabIndex = 26;
            this.btn_shoe_left.UseVisualStyleBackColor = true;
            this.btn_shoe_left.Click += new System.EventHandler(this.btn_shoe_left_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(289, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Look through the shoes of your smart shoe rack.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(6, 158);
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "Spray your shoes with a specxial deodorant.\nNote: this may take some time, please" +
    " be patient.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Shoe deodorant";
            // 
            // btn_help1
            // 
            this.btn_help1.AutoSize = true;
            this.btn_help1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_help1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btn_help1.Location = new System.Drawing.Point(696, 422);
            this.btn_help1.Name = "btn_help1";
            this.btn_help1.Size = new System.Drawing.Size(89, 20);
            this.btn_help1.TabIndex = 19;
            this.btn_help1.Text = "Need help ?";
            this.btn_help1.Click += new System.EventHandler(this.btn_help1_Click);
            // 
            // btn_back1
            // 
            this.btn_back1.AutoSize = true;
            this.btn_back1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_back1.Location = new System.Drawing.Point(43, 9);
            this.btn_back1.Name = "btn_back1";
            this.btn_back1.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.btn_back1.Size = new System.Drawing.Size(47, 30);
            this.btn_back1.TabIndex = 18;
            this.btn_back1.Text = "Back";
            this.btn_back1.Click += new System.EventHandler(this.label8_Click);
            // 
            // pb_shoes
            // 
            this.pb_shoes.Image = ((System.Drawing.Image)(resources.GetObject("pb_shoes.Image")));
            this.pb_shoes.Location = new System.Drawing.Point(543, 61);
            this.pb_shoes.Name = "pb_shoes";
            this.pb_shoes.Size = new System.Drawing.Size(192, 234);
            this.pb_shoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_shoes.TabIndex = 20;
            this.pb_shoes.TabStop = false;
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.Location = new System.Drawing.Point(11, 9);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(30, 30);
            this.btn_back.TabIndex = 17;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(540, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Shoe name: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(540, 363);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "Suggested use: ";
            // 
            // lbl_shoe_name
            // 
            this.lbl_shoe_name.AutoSize = true;
            this.lbl_shoe_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shoe_name.Location = new System.Drawing.Point(624, 316);
            this.lbl_shoe_name.Name = "lbl_shoe_name";
            this.lbl_shoe_name.Size = new System.Drawing.Size(96, 16);
            this.lbl_shoe_name.TabIndex = 28;
            this.lbl_shoe_name.Text = "Nike Air Presto";
            // 
            // lbl_shoe_use
            // 
            this.lbl_shoe_use.AutoSize = true;
            this.lbl_shoe_use.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shoe_use.Location = new System.Drawing.Point(645, 363);
            this.lbl_shoe_use.Name = "lbl_shoe_use";
            this.lbl_shoe_use.Size = new System.Drawing.Size(90, 16);
            this.lbl_shoe_use.TabIndex = 29;
            this.lbl_shoe_use.Text = "Training & Gym";
            // 
            // lbl_shoe_sz
            // 
            this.lbl_shoe_sz.AutoSize = true;
            this.lbl_shoe_sz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shoe_sz.Location = new System.Drawing.Point(540, 339);
            this.lbl_shoe_sz.Name = "lbl_shoe_sz";
            this.lbl_shoe_sz.Size = new System.Drawing.Size(39, 16);
            this.lbl_shoe_sz.TabIndex = 30;
            this.lbl_shoe_sz.Text = "Size: ";
            // 
            // lbl_shoe_size
            // 
            this.lbl_shoe_size.AutoSize = true;
            this.lbl_shoe_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shoe_size.Location = new System.Drawing.Point(585, 339);
            this.lbl_shoe_size.Name = "lbl_shoe_size";
            this.lbl_shoe_size.Size = new System.Drawing.Size(21, 16);
            this.lbl_shoe_size.TabIndex = 31;
            this.lbl_shoe_size.Text = "49";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(787, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 32;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_buy_new_shoes
            // 
            this.lbl_buy_new_shoes.AutoSize = true;
            this.lbl_buy_new_shoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buy_new_shoes.Location = new System.Drawing.Point(563, 10);
            this.lbl_buy_new_shoes.Name = "lbl_buy_new_shoes";
            this.lbl_buy_new_shoes.Size = new System.Drawing.Size(32, 16);
            this.lbl_buy_new_shoes.TabIndex = 33;
            this.lbl_buy_new_shoes.Text = "Visit";
            this.lbl_buy_new_shoes.Visible = false;
            // 
            // lbl_link_skroutz
            // 
            this.lbl_link_skroutz.AutoSize = true;
            this.lbl_link_skroutz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_link_skroutz.Location = new System.Drawing.Point(598, 9);
            this.lbl_link_skroutz.Name = "lbl_link_skroutz";
            this.lbl_link_skroutz.Size = new System.Drawing.Size(51, 16);
            this.lbl_link_skroutz.TabIndex = 34;
            this.lbl_link_skroutz.TabStop = true;
            this.lbl_link_skroutz.Text = "Skroutz";
            this.lbl_link_skroutz.Visible = false;
            // 
            // lbl_buy_new_shoes1
            // 
            this.lbl_buy_new_shoes1.AutoSize = true;
            this.lbl_buy_new_shoes1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buy_new_shoes1.Location = new System.Drawing.Point(563, 26);
            this.lbl_buy_new_shoes1.Name = "lbl_buy_new_shoes1";
            this.lbl_buy_new_shoes1.Size = new System.Drawing.Size(157, 32);
            this.lbl_buy_new_shoes1.TabIndex = 35;
            this.lbl_buy_new_shoes1.Text = "or your local shoe shop\nto buy a pair of new ones.";
            this.lbl_buy_new_shoes1.Visible = false;
            // 
            // ShoeRackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.lbl_buy_new_shoes1);
            this.Controls.Add(this.lbl_link_skroutz);
            this.Controls.Add(this.lbl_buy_new_shoes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_shoe_size);
            this.Controls.Add(this.lbl_shoe_sz);
            this.Controls.Add(this.lbl_shoe_use);
            this.Controls.Add(this.lbl_shoe_name);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pb_shoes);
            this.Controls.Add(this.btn_help1);
            this.Controls.Add(this.btn_back1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShoeRackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Assistant - Smart Shoe Rack";
            this.Load += new System.EventHandler(this.ShoeRackForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_shoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox1;
        private Button btn_back;
        private Label btn_help1;
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
        private ComboBox cb_date;
        private PictureBox pb_shoes;
        private Label label9;
        private Label label10;
        private Label lbl_shoe_name;
        private Label lbl_shoe_use;
        private Label lbl_shoe_sz;
        private Label lbl_shoe_size;
        private Button button1;
        private Label lbl_no_shoes;
        private Label label12;
        private Label label11;
        private Label lbl_buy_new_shoes;
        private LinkLabel lbl_link_skroutz;
        private Label lbl_buy_new_shoes1;
    }
}