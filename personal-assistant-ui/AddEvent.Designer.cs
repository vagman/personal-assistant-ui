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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.titleBox.Location = new System.Drawing.Point(106, 63);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(108, 20);
            this.titleBox.TabIndex = 0;
            this.titleBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(106, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2022, 9, 22, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Destination",
            "Automation"});
            this.comboBox1.Location = new System.Drawing.Point(106, 172);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Title:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LawnGreen;
            this.button1.Location = new System.Drawing.Point(149, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(86, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // hoursCB
            // 
            this.hoursCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.hoursCB.Location = new System.Drawing.Point(106, 121);
            this.hoursCB.Name = "hoursCB";
            this.hoursCB.Size = new System.Drawing.Size(36, 21);
            this.hoursCB.TabIndex = 10;
            // 
            // minCB
            // 
            this.minCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.minCB.Location = new System.Drawing.Point(146, 121);
            this.minCB.Name = "minCB";
            this.minCB.Size = new System.Drawing.Size(43, 21);
            this.minCB.TabIndex = 11;
            // 
            // periodCB
            // 
            this.periodCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodCB.FormattingEnabled = true;
            this.periodCB.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.periodCB.Location = new System.Drawing.Point(194, 121);
            this.periodCB.Name = "periodCB";
            this.periodCB.Size = new System.Drawing.Size(40, 21);
            this.periodCB.TabIndex = 1;
            this.periodCB.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hours";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Minutes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
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
            this.distanceLbl.Location = new System.Drawing.Point(283, 91);
            this.distanceLbl.Name = "distanceLbl";
            this.distanceLbl.Size = new System.Drawing.Size(52, 13);
            this.distanceLbl.TabIndex = 22;
            this.distanceLbl.Text = "Distance:";
            this.distanceLbl.Visible = false;
            // 
            // suggestionBox
            // 
            this.suggestionBox.FormattingEnabled = true;
            this.suggestionBox.Location = new System.Drawing.Point(286, 63);
            this.suggestionBox.Name = "suggestionBox";
            this.suggestionBox.Size = new System.Drawing.Size(207, 21);
            this.suggestionBox.TabIndex = 23;
            this.suggestionBox.Visible = false;
            this.suggestionBox.SelectedIndexChanged += new System.EventHandler(this.suggestionBox_SelectedIndexChanged);
            // 
            // destinationSuggText
            // 
            this.destinationSuggText.AutoSize = true;
            this.destinationSuggText.Location = new System.Drawing.Point(283, 47);
            this.destinationSuggText.Name = "destinationSuggText";
            this.destinationSuggText.Size = new System.Drawing.Size(210, 13);
            this.destinationSuggText.TabIndex = 24;
            this.destinationSuggText.Text = "How do you want to get to the destination?";
            this.destinationSuggText.Visible = false;
            // 
            // needCoffee
            // 
            this.needCoffee.AutoSize = true;
            this.needCoffee.Location = new System.Drawing.Point(286, 176);
            this.needCoffee.Name = "needCoffee";
            this.needCoffee.Size = new System.Drawing.Size(170, 17);
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
            this.mapImage.Location = new System.Drawing.Point(537, 34);
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
            this.button4.Location = new System.Drawing.Point(42, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 27);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // distanceInKm
            // 
            this.distanceInKm.AutoSize = true;
            this.distanceInKm.Location = new System.Drawing.Point(357, 91);
            this.distanceInKm.Name = "distanceInKm";
            this.distanceInKm.Size = new System.Drawing.Size(35, 13);
            this.distanceInKm.TabIndex = 27;
            this.distanceInKm.Text = "label8";
            this.distanceInKm.Visible = false;
            // 
            // durationLbl
            // 
            this.durationLbl.AutoSize = true;
            this.durationLbl.Location = new System.Drawing.Point(283, 129);
            this.durationLbl.Name = "durationLbl";
            this.durationLbl.Size = new System.Drawing.Size(50, 13);
            this.durationLbl.TabIndex = 28;
            this.durationLbl.Text = "Duration:";
            this.durationLbl.Visible = false;
            // 
            // durationInMin
            // 
            this.durationInMin.AutoSize = true;
            this.durationInMin.Location = new System.Drawing.Point(357, 128);
            this.durationInMin.Name = "durationInMin";
            this.durationInMin.Size = new System.Drawing.Size(35, 13);
            this.durationInMin.TabIndex = 29;
            this.durationInMin.Text = "label9";
            this.durationInMin.Visible = false;
            // 
            // readyToPickDestinations
            // 
            this.readyToPickDestinations.BackColor = System.Drawing.SystemColors.HotTrack;
            this.readyToPickDestinations.DropDownWidth = 70;
            this.readyToPickDestinations.FormattingEnabled = true;
            this.readyToPickDestinations.Items.AddRange(new object[] {
            "University",
            "Home",
            "Coffee Shop",
            "Gym",
            "Party/Event"});
            this.readyToPickDestinations.Location = new System.Drawing.Point(215, 62);
            this.readyToPickDestinations.Name = "readyToPickDestinations";
            this.readyToPickDestinations.Size = new System.Drawing.Size(19, 21);
            this.readyToPickDestinations.TabIndex = 30;
            this.readyToPickDestinations.SelectedIndexChanged += new System.EventHandler(this.readyToPickDestinations_SelectedIndexChanged);
            // 
            // recommendShoe
            // 
            this.recommendShoe.AutoSize = true;
            this.recommendShoe.Location = new System.Drawing.Point(286, 214);
            this.recommendShoe.Name = "recommendShoe";
            this.recommendShoe.Size = new System.Drawing.Size(175, 13);
            this.recommendShoe.TabIndex = 31;
            this.recommendShoe.Text = "Recommended shoe for this task is:";
            this.recommendShoe.Visible = false;
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 287);
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
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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

        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
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
    }
}