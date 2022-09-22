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
            this.addBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.gbox = new System.Windows.Forms.GroupBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.button1 = new System.Windows.Forms.Button();
            this.showTaskBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.gbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addBtn.Location = new System.Drawing.Point(757, 60);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 30);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add Task +";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(801, 495);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 31);
            this.button4.TabIndex = 9;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // gbox
            // 
            this.gbox.Controls.Add(this.cancelBtn);
            this.gbox.Controls.Add(this.label7);
            this.gbox.Controls.Add(this.label6);
            this.gbox.Controls.Add(this.label5);
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
            this.gbox.Location = new System.Drawing.Point(261, 96);
            this.gbox.Name = "gbox";
            this.gbox.Size = new System.Drawing.Size(571, 394);
            this.gbox.TabIndex = 11;
            this.gbox.TabStop = false;
            this.gbox.Text = "groupBox1";
            this.gbox.Visible = false;
            this.gbox.Enter += new System.EventHandler(this.gbox_Enter);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Red;
            this.cancelBtn.Location = new System.Drawing.Point(425, 365);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(65, 23);
            this.cancelBtn.TabIndex = 27;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Visible = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Period";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Minutes";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Hours";
            this.label5.Visible = false;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(23, 130);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(36, 15);
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
            this.periodCB.Location = new System.Drawing.Point(223, 127);
            this.periodCB.Name = "periodCB";
            this.periodCB.Size = new System.Drawing.Size(46, 23);
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
            this.minCB.Location = new System.Drawing.Point(148, 127);
            this.minCB.Name = "minCB";
            this.minCB.Size = new System.Drawing.Size(69, 23);
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
            this.hoursCB.Location = new System.Drawing.Point(73, 127);
            this.hoursCB.Name = "hoursCB";
            this.hoursCB.Size = new System.Drawing.Size(69, 23);
            this.hoursCB.TabIndex = 21;
            this.hoursCB.Visible = false;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(23, 178);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(34, 15);
            this.typeLabel.TabIndex = 20;
            this.typeLabel.Text = "Type:";
            this.typeLabel.Visible = false;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(23, 93);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(34, 15);
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
            this.typeBox.Location = new System.Drawing.Point(73, 175);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(196, 23);
            this.typeBox.TabIndex = 18;
            this.typeBox.Visible = false;
            // 
            // dateTimePickerSch
            // 
            this.dateTimePickerSch.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerSch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSch.Location = new System.Drawing.Point(73, 90);
            this.dateTimePickerSch.Name = "dateTimePickerSch";
            this.dateTimePickerSch.Size = new System.Drawing.Size(196, 23);
            this.dateTimePickerSch.TabIndex = 17;
            this.dateTimePickerSch.Value = new System.DateTime(2022, 9, 6, 0, 0, 0, 0);
            this.dateTimePickerSch.Visible = false;
            // 
            // taskEditBtn
            // 
            this.taskEditBtn.Location = new System.Drawing.Point(496, 365);
            this.taskEditBtn.Name = "taskEditBtn";
            this.taskEditBtn.Size = new System.Drawing.Size(69, 23);
            this.taskEditBtn.TabIndex = 2;
            this.taskEditBtn.Text = "Edit";
            this.taskEditBtn.UseVisualStyleBackColor = true;
            this.taskEditBtn.Visible = false;
            this.taskEditBtn.Click += new System.EventHandler(this.taskEditBtn_Click);
            // 
            // nameOfTask
            // 
            this.nameOfTask.Location = new System.Drawing.Point(73, 49);
            this.nameOfTask.Name = "nameOfTask";
            this.nameOfTask.Size = new System.Drawing.Size(196, 23);
            this.nameOfTask.TabIndex = 1;
            this.nameOfTask.Visible = false;
            this.nameOfTask.TextChanged += new System.EventHandler(this.nameOfTask_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title: ";
            this.label2.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 96);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(243, 394);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(155, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 23);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(2022, 9, 7, 1, 48, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button1.BackgroundImage = global::personal_assistant_ui.Properties.Resources.trash;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(12, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 24);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showTaskBtn
            // 
            this.showTaskBtn.Location = new System.Drawing.Point(209, 503);
            this.showTaskBtn.Name = "showTaskBtn";
            this.showTaskBtn.Size = new System.Drawing.Size(46, 23);
            this.showTaskBtn.TabIndex = 15;
            this.showTaskBtn.Text = "Show";
            this.showTaskBtn.UseVisualStyleBackColor = true;
            this.showTaskBtn.Click += new System.EventHandler(this.showTaskBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(145, 503);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(58, 23);
            this.refreshBtn.TabIndex = 16;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select date to view tasks:";
            // 
            // btn_back1
            // 
            this.btn_back1.AutoSize = true;
            this.btn_back1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_back1.Location = new System.Drawing.Point(44, 12);
            this.btn_back1.Name = "btn_back1";
            this.btn_back1.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.btn_back1.Size = new System.Drawing.Size(47, 30);
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
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(30, 30);
            this.btn_back.TabIndex = 19;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Scheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 538);
            this.Controls.Add(this.btn_back1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.showTaskBtn);
            this.Controls.Add(this.button1);
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
    }
}