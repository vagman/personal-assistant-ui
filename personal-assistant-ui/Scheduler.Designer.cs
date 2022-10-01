namespace personal_assistant_ui
{
    partial class Scheduler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scheduler));
            this.addBtn = new personal_assistant_ui.RoundedButton();
            this.needCoffee = new System.Windows.Forms.CheckBox();
            this.durationInMin = new System.Windows.Forms.Label();
            this.distanceInKm = new System.Windows.Forms.Label();
            this.durationLbl = new System.Windows.Forms.Label();
            this.distanceLbl = new System.Windows.Forms.Label();
            this.suggestionBox = new System.Windows.Forms.ComboBox();
            this.destinationSuggText = new System.Windows.Forms.Label();
            this.hideBtn = new personal_assistant_ui.RoundedButton();
            this.cancelBtn = new personal_assistant_ui.RoundedButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new personal_assistant_ui.RoundedButton();
            this.timeLabel = new System.Windows.Forms.Label();
            this.periodCB = new System.Windows.Forms.ComboBox();
            this.minCB = new System.Windows.Forms.ComboBox();
            this.hoursCB = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.dateTimePickerSch = new System.Windows.Forms.DateTimePicker();
            this.taskEditBtn = new personal_assistant_ui.RoundedButton();
            this.nameOfTask = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.showTaskBtn = new personal_assistant_ui.RoundedButton();
            this.refreshBtn = new personal_assistant_ui.RoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.gb_daily_planner_controls = new System.Windows.Forms.GroupBox();
            this.gb_daily_planner_controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(586, 53);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(185, 50);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add Task +";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // needCoffee
            // 
            this.needCoffee.AutoSize = true;
            this.needCoffee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.needCoffee.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.needCoffee.Location = new System.Drawing.Point(278, 235);
            this.needCoffee.Name = "needCoffee";
            this.needCoffee.Size = new System.Drawing.Size(252, 23);
            this.needCoffee.TabIndex = 34;
            this.needCoffee.Text = "Would you like to buy a coffee too ?";
            this.needCoffee.UseVisualStyleBackColor = true;
            // 
            // durationInMin
            // 
            this.durationInMin.AutoSize = true;
            this.durationInMin.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationInMin.Location = new System.Drawing.Point(346, 180);
            this.durationInMin.Name = "durationInMin";
            this.durationInMin.Size = new System.Drawing.Size(45, 19);
            this.durationInMin.TabIndex = 33;
            this.durationInMin.Text = "label9";
            this.durationInMin.Visible = false;
            // 
            // distanceInKm
            // 
            this.distanceInKm.AutoSize = true;
            this.distanceInKm.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceInKm.Location = new System.Drawing.Point(345, 140);
            this.distanceInKm.Name = "distanceInKm";
            this.distanceInKm.Size = new System.Drawing.Size(45, 19);
            this.distanceInKm.TabIndex = 32;
            this.distanceInKm.Text = "label8";
            this.distanceInKm.Visible = false;
            // 
            // durationLbl
            // 
            this.durationLbl.AutoSize = true;
            this.durationLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationLbl.Location = new System.Drawing.Point(274, 180);
            this.durationLbl.Name = "durationLbl";
            this.durationLbl.Size = new System.Drawing.Size(66, 19);
            this.durationLbl.TabIndex = 31;
            this.durationLbl.Text = "Duration:";
            this.durationLbl.Visible = false;
            // 
            // distanceLbl
            // 
            this.distanceLbl.AutoSize = true;
            this.distanceLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceLbl.Location = new System.Drawing.Point(274, 140);
            this.distanceLbl.Name = "distanceLbl";
            this.distanceLbl.Size = new System.Drawing.Size(65, 19);
            this.distanceLbl.TabIndex = 30;
            this.distanceLbl.Text = "Distance:";
            this.distanceLbl.Visible = false;
            // 
            // suggestionBox
            // 
            this.suggestionBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suggestionBox.FormattingEnabled = true;
            this.suggestionBox.Items.AddRange(new object[] {
            "Ηλεκτρικός",
            "Λεωφορείο",
            "Αυτοκίνητο",
            "Ποδήλατο",
            "Πόδια",
            "Συνδιασμός"});
            this.suggestionBox.Location = new System.Drawing.Point(278, 83);
            this.suggestionBox.Name = "suggestionBox";
            this.suggestionBox.Size = new System.Drawing.Size(207, 27);
            this.suggestionBox.TabIndex = 29;
            this.suggestionBox.Visible = false;
            this.suggestionBox.SelectedIndexChanged += new System.EventHandler(this.suggestionBox_SelectedIndexChanged);
            // 
            // destinationSuggText
            // 
            this.destinationSuggText.AutoSize = true;
            this.destinationSuggText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationSuggText.Location = new System.Drawing.Point(274, 33);
            this.destinationSuggText.Name = "destinationSuggText";
            this.destinationSuggText.Size = new System.Drawing.Size(156, 38);
            this.destinationSuggText.TabIndex = 28;
            this.destinationSuggText.Text = "How do you want to\nget to your destination?";
            this.destinationSuggText.Visible = false;
            // 
            // hideBtn
            // 
            this.hideBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hideBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.hideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideBtn.Location = new System.Drawing.Point(132, 348);
            this.hideBtn.Name = "hideBtn";
            this.hideBtn.Size = new System.Drawing.Size(120, 50);
            this.hideBtn.TabIndex = 21;
            this.hideBtn.Text = "Hide Details";
            this.hideBtn.UseVisualStyleBackColor = true;
            this.hideBtn.Visible = false;
            this.hideBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(310, 348);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(110, 50);
            this.cancelBtn.TabIndex = 27;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Visible = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(195, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 19);
            this.label7.TabIndex = 26;
            this.label7.Text = "Period";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(130, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "Minutes";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "Hours";
            this.label5.Visible = false;
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(6, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 50);
            this.button1.TabIndex = 14;
            this.button1.Text = "Delete Task";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(18, 143);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(41, 19);
            this.timeLabel.TabIndex = 23;
            this.timeLabel.Text = "Time:";
            this.timeLabel.Visible = false;
            // 
            // periodCB
            // 
            this.periodCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodCB.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodCB.FormattingEnabled = true;
            this.periodCB.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.periodCB.Location = new System.Drawing.Point(195, 140);
            this.periodCB.Name = "periodCB";
            this.periodCB.Size = new System.Drawing.Size(48, 27);
            this.periodCB.TabIndex = 16;
            this.periodCB.Visible = false;
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
            this.minCB.Location = new System.Drawing.Point(129, 140);
            this.minCB.Name = "minCB";
            this.minCB.Size = new System.Drawing.Size(60, 27);
            this.minCB.TabIndex = 22;
            this.minCB.Visible = false;
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
            this.hoursCB.Location = new System.Drawing.Point(65, 140);
            this.hoursCB.Name = "hoursCB";
            this.hoursCB.Size = new System.Drawing.Size(60, 27);
            this.hoursCB.TabIndex = 21;
            this.hoursCB.Visible = false;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(16, 233);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(41, 19);
            this.typeLabel.TabIndex = 20;
            this.typeLabel.Text = "Type:";
            this.typeLabel.Visible = false;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(16, 91);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(41, 19);
            this.dateLabel.TabIndex = 19;
            this.dateLabel.Text = "Date:";
            this.dateLabel.Visible = false;
            // 
            // typeBox
            // 
            this.typeBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "Destination",
            "Automation"});
            this.typeBox.Location = new System.Drawing.Point(63, 231);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(180, 27);
            this.typeBox.TabIndex = 18;
            this.typeBox.Visible = false;
            this.typeBox.SelectedIndexChanged += new System.EventHandler(this.typeBox_SelectedIndexChanged);
            // 
            // dateTimePickerSch
            // 
            this.dateTimePickerSch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerSch.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerSch.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerSch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSch.Location = new System.Drawing.Point(63, 86);
            this.dateTimePickerSch.Name = "dateTimePickerSch";
            this.dateTimePickerSch.Size = new System.Drawing.Size(178, 24);
            this.dateTimePickerSch.TabIndex = 17;
            this.dateTimePickerSch.Value = new System.DateTime(2022, 9, 22, 0, 0, 0, 0);
            this.dateTimePickerSch.Visible = false;
            this.dateTimePickerSch.ValueChanged += new System.EventHandler(this.dateTimePickerSch_ValueChanged);
            // 
            // taskEditBtn
            // 
            this.taskEditBtn.BackColor = System.Drawing.Color.LightBlue;
            this.taskEditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taskEditBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.taskEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskEditBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskEditBtn.Location = new System.Drawing.Point(426, 348);
            this.taskEditBtn.Name = "taskEditBtn";
            this.taskEditBtn.Size = new System.Drawing.Size(110, 50);
            this.taskEditBtn.TabIndex = 2;
            this.taskEditBtn.Text = "Edit";
            this.taskEditBtn.UseVisualStyleBackColor = false;
            this.taskEditBtn.Visible = false;
            this.taskEditBtn.Click += new System.EventHandler(this.taskEditBtn_Click);
            // 
            // nameOfTask
            // 
            this.nameOfTask.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOfTask.Location = new System.Drawing.Point(63, 42);
            this.nameOfTask.Name = "nameOfTask";
            this.nameOfTask.Size = new System.Drawing.Size(178, 24);
            this.nameOfTask.TabIndex = 1;
            this.nameOfTask.Visible = false;
            this.nameOfTask.TextChanged += new System.EventHandler(this.nameOfTask_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title: ";
            this.label2.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(560, 155);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(221, 212);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(651, 120);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 24);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(2022, 9, 7, 1, 48, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // showTaskBtn
            // 
            this.showTaskBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showTaskBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.showTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showTaskBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTaskBtn.Location = new System.Drawing.Point(681, 373);
            this.showTaskBtn.Name = "showTaskBtn";
            this.showTaskBtn.Size = new System.Drawing.Size(110, 50);
            this.showTaskBtn.TabIndex = 15;
            this.showTaskBtn.Text = "Show Details";
            this.showTaskBtn.UseVisualStyleBackColor = true;
            this.showTaskBtn.Visible = false;
            this.showTaskBtn.Click += new System.EventHandler(this.showTaskBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(572, 373);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(110, 50);
            this.refreshBtn.TabIndex = 16;
            this.refreshBtn.Text = "Refresh List";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(568, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "View tasks:";
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
            this.button4.Location = new System.Drawing.Point(787, 418);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 35);
            this.button4.TabIndex = 9;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // gb_daily_planner_controls
            // 
            this.gb_daily_planner_controls.Controls.Add(this.needCoffee);
            this.gb_daily_planner_controls.Controls.Add(this.durationInMin);
            this.gb_daily_planner_controls.Controls.Add(this.distanceInKm);
            this.gb_daily_planner_controls.Controls.Add(this.durationLbl);
            this.gb_daily_planner_controls.Controls.Add(this.distanceLbl);
            this.gb_daily_planner_controls.Controls.Add(this.suggestionBox);
            this.gb_daily_planner_controls.Controls.Add(this.destinationSuggText);
            this.gb_daily_planner_controls.Controls.Add(this.hideBtn);
            this.gb_daily_planner_controls.Controls.Add(this.cancelBtn);
            this.gb_daily_planner_controls.Controls.Add(this.label7);
            this.gb_daily_planner_controls.Controls.Add(this.label6);
            this.gb_daily_planner_controls.Controls.Add(this.label5);
            this.gb_daily_planner_controls.Controls.Add(this.button1);
            this.gb_daily_planner_controls.Controls.Add(this.timeLabel);
            this.gb_daily_planner_controls.Controls.Add(this.periodCB);
            this.gb_daily_planner_controls.Controls.Add(this.minCB);
            this.gb_daily_planner_controls.Controls.Add(this.hoursCB);
            this.gb_daily_planner_controls.Controls.Add(this.typeLabel);
            this.gb_daily_planner_controls.Controls.Add(this.dateLabel);
            this.gb_daily_planner_controls.Controls.Add(this.typeBox);
            this.gb_daily_planner_controls.Controls.Add(this.dateTimePickerSch);
            this.gb_daily_planner_controls.Controls.Add(this.taskEditBtn);
            this.gb_daily_planner_controls.Controls.Add(this.nameOfTask);
            this.gb_daily_planner_controls.Controls.Add(this.label2);
            this.gb_daily_planner_controls.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_daily_planner_controls.Location = new System.Drawing.Point(12, 42);
            this.gb_daily_planner_controls.Name = "gb_daily_planner_controls";
            this.gb_daily_planner_controls.Size = new System.Drawing.Size(542, 407);
            this.gb_daily_planner_controls.TabIndex = 11;
            this.gb_daily_planner_controls.TabStop = false;
            this.gb_daily_planner_controls.Text = "Daily PLanner Controls";
            this.gb_daily_planner_controls.Visible = false;
            this.gb_daily_planner_controls.Enter += new System.EventHandler(this.gbox_Enter);
            // 
            // Scheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.btn_back1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.showTaskBtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gb_daily_planner_controls);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.addBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Scheduler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scheduler";
            this.Load += new System.EventHandler(this.Scheduler_Load);
            this.gb_daily_planner_controls.ResumeLayout(false);
            this.gb_daily_planner_controls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBox listBox1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private TextBox nameOfTask;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label timeLabel;
        private ComboBox periodCB;
        private ComboBox minCB;
        private ComboBox hoursCB;
        private Label typeLabel;
        private Label dateLabel;
        private ComboBox typeBox;
        private DateTimePicker dateTimePickerSch;
        private Label btn_back1;
        private Button btn_back;
        private Label destinationSuggText;
        private ComboBox suggestionBox;
        private Label distanceLbl;
        private Label durationLbl;
        private Label distanceInKm;
        private Label durationInMin;
        private CheckBox needCoffee;
        private GroupBox gb_daily_planner_controls;
        private RoundedButton addBtn;
        private RoundedButton button1;
        private RoundedButton showTaskBtn;
        private RoundedButton refreshBtn;
        private RoundedButton taskEditBtn;
        private RoundedButton cancelBtn;
        private RoundedButton hideBtn;
        private Button button4;
    }
}