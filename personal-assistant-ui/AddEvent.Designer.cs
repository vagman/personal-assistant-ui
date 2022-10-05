namespace personal_assistant_ui
{
    partial class AddEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEvent));
            this.titleBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_submit = new personal_assistant_ui.RoundedButton();
            this.btn_cancel = new personal_assistant_ui.RoundedButton();
            this.hoursCB = new System.Windows.Forms.ComboBox();
            this.minCB = new System.Windows.Forms.ComboBox();
            this.periodCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_back1 = new System.Windows.Forms.Label();
            this.distanceLbl = new System.Windows.Forms.Label();
            this.suggestionBox = new System.Windows.Forms.ComboBox();
            this.destinationSuggText = new System.Windows.Forms.Label();
            this.needCoffee = new System.Windows.Forms.CheckBox();
            this.mapImage = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.distanceInKm = new System.Windows.Forms.Label();
            this.durationLbl = new System.Windows.Forms.Label();
            this.durationInMin = new System.Windows.Forms.Label();
            this.readyToPickDestinations = new System.Windows.Forms.ComboBox();
            this.recommendShoe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mapImage)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBox.Location = new System.Drawing.Point(92, 50);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(128, 24);
            this.titleBox.TabIndex = 0;
            this.titleBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(92, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 24);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2022, 9, 22, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Destination",
            "Automation"});
            this.comboBox1.Location = new System.Drawing.Point(92, 206);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 27);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Title:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_submit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(130, 249);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(123, 50);
            this.btn_submit.TabIndex = 6;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.LightBlue;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(34, 249);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(82, 50);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // hoursCB
            // 
            this.hoursCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hoursCB.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursCB.FormattingEnabled = true;
            this.hoursCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.hoursCB.Location = new System.Drawing.Point(92, 139);
            this.hoursCB.Name = "hoursCB";
            this.hoursCB.Size = new System.Drawing.Size(42, 27);
            this.hoursCB.TabIndex = 10;
            // 
            // minCB
            // 
            this.minCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minCB.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minCB.FormattingEnabled = true;
            this.minCB.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.minCB.Location = new System.Drawing.Point(144, 139);
            this.minCB.Name = "minCB";
            this.minCB.Size = new System.Drawing.Size(43, 27);
            this.minCB.TabIndex = 11;
            // 
            // periodCB
            // 
            this.periodCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodCB.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodCB.FormattingEnabled = true;
            this.periodCB.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.periodCB.Location = new System.Drawing.Point(203, 138);
            this.periodCB.Name = "periodCB";
            this.periodCB.Size = new System.Drawing.Size(40, 27);
            this.periodCB.TabIndex = 1;
            this.periodCB.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hours";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(140, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Minutes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(205, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Period";
            // 
            // btn_back1
            // 
            this.btn_back1.AutoSize = true;
            this.btn_back1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_back1.Location = new System.Drawing.Point(38, 10);
            this.btn_back1.Name = "btn_back1";
            this.btn_back1.Padding = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.btn_back1.Size = new System.Drawing.Size(46, 28);
            this.btn_back1.TabIndex = 20;
            this.btn_back1.Text = "Back";
            this.btn_back1.Click += new System.EventHandler(this.btn_back1_Click);
            // 
            // distanceLbl
            // 
            this.distanceLbl.AutoSize = true;
            this.distanceLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceLbl.Location = new System.Drawing.Point(281, 121);
            this.distanceLbl.Name = "distanceLbl";
            this.distanceLbl.Size = new System.Drawing.Size(65, 19);
            this.distanceLbl.TabIndex = 22;
            this.distanceLbl.Text = "Distance:";
            this.distanceLbl.Visible = false;
            // 
            // suggestionBox
            // 
            this.suggestionBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suggestionBox.FormattingEnabled = true;
            this.suggestionBox.Location = new System.Drawing.Point(279, 91);
            this.suggestionBox.Name = "suggestionBox";
            this.suggestionBox.Size = new System.Drawing.Size(207, 27);
            this.suggestionBox.TabIndex = 23;
            this.suggestionBox.Visible = false;
            this.suggestionBox.SelectedIndexChanged += new System.EventHandler(this.suggestionBox_SelectedIndexChanged);
            // 
            // destinationSuggText
            // 
            this.destinationSuggText.AutoSize = true;
            this.destinationSuggText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationSuggText.Location = new System.Drawing.Point(281, 46);
            this.destinationSuggText.Name = "destinationSuggText";
            this.destinationSuggText.Size = new System.Drawing.Size(159, 38);
            this.destinationSuggText.TabIndex = 24;
            this.destinationSuggText.Text = "How do you want to get\nto the destination?";
            this.destinationSuggText.Visible = false;
            // 
            // needCoffee
            // 
            this.needCoffee.AutoSize = true;
            this.needCoffee.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.needCoffee.Location = new System.Drawing.Point(279, 180);
            this.needCoffee.Name = "needCoffee";
            this.needCoffee.Size = new System.Drawing.Size(214, 23);
            this.needCoffee.TabIndex = 25;
            this.needCoffee.Text = "Do you want to take a coffee?";
            this.needCoffee.UseVisualStyleBackColor = true;
            this.needCoffee.Visible = false;
            this.needCoffee.CheckedChanged += new System.EventHandler(this.needCoffee_CheckedChanged);
            // 
            // mapImage
            // 
            this.mapImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mapImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mapImage.ErrorImage = null;
            this.mapImage.InitialImage = null;
            this.mapImage.Location = new System.Drawing.Point(564, 46);
            this.mapImage.Name = "mapImage";
            this.mapImage.Size = new System.Drawing.Size(213, 182);
            this.mapImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapImage.TabIndex = 26;
            this.mapImage.TabStop = false;
            this.mapImage.Visible = false;
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
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(787, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 35);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // distanceInKm
            // 
            this.distanceInKm.AutoSize = true;
            this.distanceInKm.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceInKm.Location = new System.Drawing.Point(355, 121);
            this.distanceInKm.Name = "distanceInKm";
            this.distanceInKm.Size = new System.Drawing.Size(45, 19);
            this.distanceInKm.TabIndex = 27;
            this.distanceInKm.Text = "label8";
            this.distanceInKm.Visible = false;
            // 
            // durationLbl
            // 
            this.durationLbl.AutoSize = true;
            this.durationLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationLbl.Location = new System.Drawing.Point(281, 149);
            this.durationLbl.Name = "durationLbl";
            this.durationLbl.Size = new System.Drawing.Size(66, 19);
            this.durationLbl.TabIndex = 28;
            this.durationLbl.Text = "Duration:";
            this.durationLbl.Visible = false;
            // 
            // durationInMin
            // 
            this.durationInMin.AutoSize = true;
            this.durationInMin.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationInMin.Location = new System.Drawing.Point(355, 148);
            this.durationInMin.Name = "durationInMin";
            this.durationInMin.Size = new System.Drawing.Size(45, 19);
            this.durationInMin.TabIndex = 29;
            this.durationInMin.Text = "label9";
            this.durationInMin.Visible = false;
            // 
            // readyToPickDestinations
            // 
            this.readyToPickDestinations.BackColor = System.Drawing.SystemColors.HotTrack;
            this.readyToPickDestinations.DropDownWidth = 70;
            this.readyToPickDestinations.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readyToPickDestinations.ForeColor = System.Drawing.SystemColors.Menu;
            this.readyToPickDestinations.FormattingEnabled = true;
            this.readyToPickDestinations.Items.AddRange(new object[] {
            "University",
            "Home",
            "Coffee Shop",
            "Gym",
            "Party/Event"});
            this.readyToPickDestinations.Location = new System.Drawing.Point(224, 47);
            this.readyToPickDestinations.Name = "readyToPickDestinations";
            this.readyToPickDestinations.Size = new System.Drawing.Size(19, 27);
            this.readyToPickDestinations.TabIndex = 30;
            this.readyToPickDestinations.SelectedIndexChanged += new System.EventHandler(this.readyToPickDestinations_SelectedIndexChanged);
            // 
            // recommendShoe
            // 
            this.recommendShoe.AutoSize = true;
            this.recommendShoe.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recommendShoe.Location = new System.Drawing.Point(275, 214);
            this.recommendShoe.Name = "recommendShoe";
            this.recommendShoe.Size = new System.Drawing.Size(227, 19);
            this.recommendShoe.TabIndex = 31;
            this.recommendShoe.Text = "Recommended shoe for this task is:";
            this.recommendShoe.Visible = false;
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(834, 311);
            this.Controls.Add(this.recommendShoe);
            this.Controls.Add(this.readyToPickDestinations);
            this.Controls.Add(this.durationInMin);
            this.Controls.Add(this.durationLbl);
            this.Controls.Add(this.distanceInKm);
            this.Controls.Add(this.mapImage);
            this.Controls.Add(this.needCoffee);
            this.Controls.Add(this.destinationSuggText);
            this.Controls.Add(this.suggestionBox);
            this.Controls.Add(this.distanceLbl);
            this.Controls.Add(this.btn_back1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.periodCB);
            this.Controls.Add(this.minCB);
            this.Controls.Add(this.hoursCB);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.titleBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create an Event";
            this.Load += new System.EventHandler(this.AddEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mapImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button4;
        private ComboBox hoursCB;
        private ComboBox minCB;
        private ComboBox periodCB;
        private Label label4;
        private TextBox titleBox;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label btn_back1;
        private Button btn_back;
        private Label distanceLbl;
        private ComboBox suggestionBox;
        private Label destinationSuggText;
        private CheckBox needCoffee;
        private PictureBox mapImage;
        private Label distanceInKm;
        private Label durationLbl;
        private Label durationInMin;
        private ComboBox readyToPickDestinations;
        private Label recommendShoe;
        private RoundedButton btn_submit;
        private RoundedButton btn_cancel;
    }
}