﻿namespace personal_assistant_ui
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
            this.addBtn = new System.Windows.Forms.Button();
            this.gbox = new System.Windows.Forms.GroupBox();
            this.hideBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.periodCB = new System.Windows.Forms.ComboBox();
            this.minCB = new System.Windows.Forms.ComboBox();
            this.hoursCB = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.dateTimePickerSch = new System.Windows.Forms.DateTimePicker();
            this.taskEditBtn = new System.Windows.Forms.Button();
            this.nameOfTask = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.showTaskBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.destinationSuggText = new System.Windows.Forms.Label();
            this.suggestionBox = new System.Windows.Forms.ComboBox();
            this.distanceLbl = new System.Windows.Forms.Label();
            this.durationLbl = new System.Windows.Forms.Label();
            this.distanceInKm = new System.Windows.Forms.Label();
            this.durationInMin = new System.Windows.Forms.Label();
            this.needCoffee = new System.Windows.Forms.CheckBox();
            this.gbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.addBtn.Location = new System.Drawing.Point(633, 12);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(80, 26);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add Task +";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // gbox
            // 
            this.gbox.Controls.Add(this.needCoffee);
            this.gbox.Controls.Add(this.durationInMin);
            this.gbox.Controls.Add(this.distanceInKm);
            this.gbox.Controls.Add(this.durationLbl);
            this.gbox.Controls.Add(this.distanceLbl);
            this.gbox.Controls.Add(this.suggestionBox);
            this.gbox.Controls.Add(this.destinationSuggText);
            this.gbox.Controls.Add(this.hideBtn);
            this.gbox.Controls.Add(this.cancelBtn);
            this.gbox.Controls.Add(this.label7);
            this.gbox.Controls.Add(this.label6);
            this.gbox.Controls.Add(this.label5);
            this.gbox.Controls.Add(this.button1);
            this.gbox.Controls.Add(this.timeLabel);
            this.gbox.Controls.Add(this.periodCB);
            this.gbox.Controls.Add(this.minCB);
            this.gbox.Controls.Add(this.hoursCB);
            this.gbox.Controls.Add(this.typeLabel);
            this.gbox.Controls.Add(this.dateLabel);
            this.gbox.Controls.Add(this.typeBox);
            this.gbox.Controls.Add(this.dateTimePickerSch);
            this.gbox.Controls.Add(this.taskEditBtn);
            this.gbox.Controls.Add(this.nameOfTask);
            this.gbox.Controls.Add(this.label2);
            this.gbox.Location = new System.Drawing.Point(224, 83);
            this.gbox.Name = "gbox";
            this.gbox.Size = new System.Drawing.Size(489, 341);
            this.gbox.TabIndex = 11;
            this.gbox.TabStop = false;
            this.gbox.Text = "groupBox1";
            this.gbox.Visible = false;
            this.gbox.Enter += new System.EventHandler(this.gbox_Enter);
            // 
            // hideBtn
            // 
            this.hideBtn.Location = new System.Drawing.Point(95, 299);
            this.hideBtn.Name = "hideBtn";
            this.hideBtn.Size = new System.Drawing.Size(52, 36);
            this.hideBtn.TabIndex = 21;
            this.hideBtn.Text = "Hide Details";
            this.hideBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hideBtn.UseVisualStyleBackColor = true;
            this.hideBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Red;
            this.cancelBtn.Location = new System.Drawing.Point(366, 305);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(54, 31);
            this.cancelBtn.TabIndex = 27;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Visible = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Period";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Minutes";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Hours";
            this.label5.Visible = false;
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Image = global::personal_assistant_ui.Properties.Resources.trash;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(6, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Delete Task";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(20, 113);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(33, 13);
            this.timeLabel.TabIndex = 23;
            this.timeLabel.Text = "Time:";
            this.timeLabel.Visible = false;
            // 
            // periodCB
            // 
            this.periodCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodCB.FormattingEnabled = true;
            this.periodCB.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.periodCB.Location = new System.Drawing.Point(191, 110);
            this.periodCB.Name = "periodCB";
            this.periodCB.Size = new System.Drawing.Size(40, 21);
            this.periodCB.TabIndex = 16;
            this.periodCB.Visible = false;
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
            this.minCB.Location = new System.Drawing.Point(127, 110);
            this.minCB.Name = "minCB";
            this.minCB.Size = new System.Drawing.Size(60, 21);
            this.minCB.TabIndex = 22;
            this.minCB.Visible = false;
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
            this.hoursCB.Location = new System.Drawing.Point(63, 110);
            this.hoursCB.Name = "hoursCB";
            this.hoursCB.Size = new System.Drawing.Size(60, 21);
            this.hoursCB.TabIndex = 21;
            this.hoursCB.Visible = false;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(16, 164);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(34, 13);
            this.typeLabel.TabIndex = 20;
            this.typeLabel.Text = "Type:";
            this.typeLabel.Visible = false;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(20, 81);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 19;
            this.dateLabel.Text = "Date:";
            this.dateLabel.Visible = false;
            // 
            // typeBox
            // 
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "Destination",
            "Automation",
            "Party/Event"});
            this.typeBox.Location = new System.Drawing.Point(59, 162);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(169, 21);
            this.typeBox.TabIndex = 18;
            this.typeBox.Visible = false;
            // 
            // dateTimePickerSch
            // 
            this.dateTimePickerSch.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerSch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSch.Location = new System.Drawing.Point(63, 78);
            this.dateTimePickerSch.Name = "dateTimePickerSch";
            this.dateTimePickerSch.Size = new System.Drawing.Size(169, 20);
            this.dateTimePickerSch.TabIndex = 17;
            this.dateTimePickerSch.Value = new System.DateTime(2022, 9, 22, 0, 0, 0, 0);
            this.dateTimePickerSch.Visible = false;
            this.dateTimePickerSch.ValueChanged += new System.EventHandler(this.dateTimePickerSch_ValueChanged);
            // 
            // taskEditBtn
            // 
            this.taskEditBtn.Location = new System.Drawing.Point(426, 305);
            this.taskEditBtn.Name = "taskEditBtn";
            this.taskEditBtn.Size = new System.Drawing.Size(58, 31);
            this.taskEditBtn.TabIndex = 2;
            this.taskEditBtn.Text = "Edit";
            this.taskEditBtn.UseVisualStyleBackColor = true;
            this.taskEditBtn.Visible = false;
            this.taskEditBtn.Click += new System.EventHandler(this.taskEditBtn_Click);
            // 
            // nameOfTask
            // 
            this.nameOfTask.Location = new System.Drawing.Point(63, 42);
            this.nameOfTask.Name = "nameOfTask";
            this.nameOfTask.Size = new System.Drawing.Size(169, 20);
            this.nameOfTask.TabIndex = 1;
            this.nameOfTask.Visible = false;
            this.nameOfTask.TextChanged += new System.EventHandler(this.nameOfTask_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title: ";
            this.label2.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(10, 83);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(209, 342);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(74, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(2022, 9, 7, 1, 48, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // showTaskBtn
            // 
            this.showTaskBtn.Location = new System.Drawing.Point(90, 436);
            this.showTaskBtn.Name = "showTaskBtn";
            this.showTaskBtn.Size = new System.Drawing.Size(86, 30);
            this.showTaskBtn.TabIndex = 15;
            this.showTaskBtn.Text = "Show Details";
            this.showTaskBtn.UseVisualStyleBackColor = true;
            this.showTaskBtn.Visible = false;
            this.showTaskBtn.Click += new System.EventHandler(this.showTaskBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.refreshBtn.Location = new System.Drawing.Point(10, 436);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(74, 30);
            this.refreshBtn.TabIndex = 16;
            this.refreshBtn.Text = "Refresh List";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select date to view tasks:";
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
            this.btn_back.BackgroundImage = global::personal_assistant_ui.Properties.Resources.back;
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
            this.button4.Location = new System.Drawing.Point(687, 429);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 27);
            this.button4.TabIndex = 9;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // destinationSuggText
            // 
            this.destinationSuggText.AutoSize = true;
            this.destinationSuggText.Location = new System.Drawing.Point(16, 204);
            this.destinationSuggText.Name = "destinationSuggText";
            this.destinationSuggText.Size = new System.Drawing.Size(210, 13);
            this.destinationSuggText.TabIndex = 28;
            this.destinationSuggText.Text = "How do you want to get to the destination?";
            this.destinationSuggText.Visible = false;
            // 
            // suggestionBox
            // 
            this.suggestionBox.FormattingEnabled = true;
            this.suggestionBox.Items.AddRange(new object[] {
            "Ηλεκτρικός",
            "Λεωφορείο",
            "Αυτοκίνητο",
            "Ποδήλατο",
            "Πόδια",
            "Συνδιασμός"});
            this.suggestionBox.Location = new System.Drawing.Point(19, 220);
            this.suggestionBox.Name = "suggestionBox";
            this.suggestionBox.Size = new System.Drawing.Size(207, 21);
            this.suggestionBox.TabIndex = 29;
            this.suggestionBox.Visible = false;
            // 
            // distanceLbl
            // 
            this.distanceLbl.AutoSize = true;
            this.distanceLbl.Location = new System.Drawing.Point(20, 254);
            this.distanceLbl.Name = "distanceLbl";
            this.distanceLbl.Size = new System.Drawing.Size(52, 13);
            this.distanceLbl.TabIndex = 30;
            this.distanceLbl.Text = "Distance:";
            this.distanceLbl.Visible = false;
            // 
            // durationLbl
            // 
            this.durationLbl.AutoSize = true;
            this.durationLbl.Location = new System.Drawing.Point(124, 254);
            this.durationLbl.Name = "durationLbl";
            this.durationLbl.Size = new System.Drawing.Size(50, 13);
            this.durationLbl.TabIndex = 31;
            this.durationLbl.Text = "Duration:";
            this.durationLbl.Visible = false;
            // 
            // distanceInKm
            // 
            this.distanceInKm.AutoSize = true;
            this.distanceInKm.Location = new System.Drawing.Point(78, 254);
            this.distanceInKm.Name = "distanceInKm";
            this.distanceInKm.Size = new System.Drawing.Size(35, 13);
            this.distanceInKm.TabIndex = 32;
            this.distanceInKm.Text = "label8";
            this.distanceInKm.Visible = false;
            // 
            // durationInMin
            // 
            this.durationInMin.AutoSize = true;
            this.durationInMin.Location = new System.Drawing.Point(180, 254);
            this.durationInMin.Name = "durationInMin";
            this.durationInMin.Size = new System.Drawing.Size(35, 13);
            this.durationInMin.TabIndex = 33;
            this.durationInMin.Text = "label9";
            this.durationInMin.Visible = false;
            // 
            // needCoffee
            // 
            this.needCoffee.AutoSize = true;
            this.needCoffee.Location = new System.Drawing.Point(19, 276);
            this.needCoffee.Name = "needCoffee";
            this.needCoffee.Size = new System.Drawing.Size(170, 17);
            this.needCoffee.TabIndex = 34;
            this.needCoffee.Text = "Do you want to take a coffee?";
            this.needCoffee.UseVisualStyleBackColor = true;
            // 
            // Scheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(723, 466);
            this.Controls.Add(this.btn_back1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.showTaskBtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gbox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.addBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Scheduler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scheduler";
            this.Load += new System.EventHandler(this.Scheduler_Load);
            this.gbox.ResumeLayout(false);
            this.gbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addBtn;
        private Button button4;
        private GroupBox gbox;
        private ListBox listBox1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button showTaskBtn;
        private Button refreshBtn;
        private Label label1;
        private TextBox nameOfTask;
        private Label label2;
        private Button taskEditBtn;
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
        private Button cancelBtn;
        private Label btn_back1;
        private Button btn_back;
        private Button hideBtn;
        private Label destinationSuggText;
        private ComboBox suggestionBox;
        private Label distanceLbl;
        private Label durationLbl;
        private Label distanceInKm;
        private Label durationInMin;
        private CheckBox needCoffee;
    }
}