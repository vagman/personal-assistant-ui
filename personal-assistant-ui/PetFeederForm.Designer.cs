namespace personal_assistant_ui
{
    partial class PetFeederForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetFeederForm));
            this.btn_back1 = new System.Windows.Forms.Label();
            this.btn_help1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.cb_period = new System.Windows.Forms.ComboBox();
            this.cb_mins = new System.Windows.Forms.ComboBox();
            this.cb_hours = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.bc_goof_type = new System.Windows.Forms.ComboBox();
            this.date_picker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_send_help = new System.Windows.Forms.ComboBox();
            this.timer_live_cat_video = new System.Windows.Forms.Timer(this.components);
            this.btnAddFood = new System.Windows.Forms.Button();
            this.pb_cat_water = new System.Windows.Forms.PictureBox();
            this.pb_cat = new System.Windows.Forms.PictureBox();
            this.pb_cat_food = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btnAddWater = new System.Windows.Forms.Button();
            this.food_timer = new System.Windows.Forms.Timer(this.components);
            this.water_timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_food_warning = new System.Windows.Forms.Label();
            this.lbl_water_warning = new System.Windows.Forms.Label();
            this.btn_save_feeding_schedule = new personal_assistant_ui.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cat_water)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cat_food)).BeginInit();
            this.SuspendLayout();
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
            this.btn_back1.TabIndex = 22;
            this.btn_back1.Text = "Back";
            this.btn_back1.Click += new System.EventHandler(this.btn_back1_Click);
            // 
            // btn_help1
            // 
            this.btn_help1.AutoSize = true;
            this.btn_help1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_help1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help1.Location = new System.Drawing.Point(696, 419);
            this.btn_help1.Name = "btn_help1";
            this.btn_help1.Size = new System.Drawing.Size(92, 21);
            this.btn_help1.TabIndex = 33;
            this.btn_help1.Text = "Need help ?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "Live video";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Food";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Here is a live feed of your cat.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(616, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "Water";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 25);
            this.label5.TabIndex = 39;
            this.label5.Text = "Schedule a feeding";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(206, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 50;
            this.label7.Text = "Period";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(141, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "Minutes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(88, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 48;
            this.label8.Text = "Hours";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(9, 310);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(41, 16);
            this.timeLabel.TabIndex = 47;
            this.timeLabel.Text = "Time:";
            // 
            // cb_period
            // 
            this.cb_period.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_period.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_period.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_period.FormattingEnabled = true;
            this.cb_period.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cb_period.Location = new System.Drawing.Point(209, 305);
            this.cb_period.Name = "cb_period";
            this.cb_period.Size = new System.Drawing.Size(50, 24);
            this.cb_period.TabIndex = 40;
            // 
            // cb_mins
            // 
            this.cb_mins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_mins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_mins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_mins.FormattingEnabled = true;
            this.cb_mins.Items.AddRange(new object[] {
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
            this.cb_mins.Location = new System.Drawing.Point(144, 305);
            this.cb_mins.Name = "cb_mins";
            this.cb_mins.Size = new System.Drawing.Size(60, 24);
            this.cb_mins.TabIndex = 46;
            // 
            // cb_hours
            // 
            this.cb_hours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_hours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_hours.FormattingEnabled = true;
            this.cb_hours.Items.AddRange(new object[] {
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
            this.cb_hours.Location = new System.Drawing.Point(91, 305);
            this.cb_hours.Name = "cb_hours";
            this.cb_hours.Size = new System.Drawing.Size(48, 24);
            this.cb_hours.TabIndex = 45;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(7, 369);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(71, 16);
            this.typeLabel.TabIndex = 44;
            this.typeLabel.Text = "Food type:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(9, 259);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(39, 16);
            this.dateLabel.TabIndex = 43;
            this.dateLabel.Text = "Date:";
            // 
            // bc_goof_type
            // 
            this.bc_goof_type.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bc_goof_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_goof_type.FormattingEnabled = true;
            this.bc_goof_type.Items.AddRange(new object[] {
            "Healthy gourmet",
            "Canned Pate",
            "Pouch Morsels"});
            this.bc_goof_type.Location = new System.Drawing.Point(90, 366);
            this.bc_goof_type.Name = "bc_goof_type";
            this.bc_goof_type.Size = new System.Drawing.Size(169, 24);
            this.bc_goof_type.TabIndex = 42;
            // 
            // date_picker
            // 
            this.date_picker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.date_picker.CustomFormat = "dd-MM-yyyy";
            this.date_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_picker.Location = new System.Drawing.Point(90, 259);
            this.date_picker.Name = "date_picker";
            this.date_picker.Size = new System.Drawing.Size(169, 22);
            this.date_picker.TabIndex = 41;
            this.date_picker.Value = new System.DateTime(2022, 9, 22, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(547, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 16);
            this.label9.TabIndex = 51;
            this.label9.Text = "Your cat seems to be just fine";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(547, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 32);
            this.label10.TabIndex = 52;
            this.label10.Text = "She is relaxed and walking\naround as usual.";
            // 
            // cb_send_help
            // 
            this.cb_send_help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_send_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_send_help.ForeColor = System.Drawing.Color.Red;
            this.cb_send_help.FormattingEnabled = true;
            this.cb_send_help.Items.AddRange(new object[] {
            "Call 911",
            "Call Annie",
            "Call Mom"});
            this.cb_send_help.Location = new System.Drawing.Point(550, 140);
            this.cb_send_help.Name = "cb_send_help";
            this.cb_send_help.Size = new System.Drawing.Size(169, 24);
            this.cb_send_help.TabIndex = 53;
            this.cb_send_help.Text = "Call Mom!";
            this.cb_send_help.Visible = false;
            // 
            // timer_live_cat_video
            // 
            this.timer_live_cat_video.Enabled = true;
            this.timer_live_cat_video.Interval = 2000;
            this.timer_live_cat_video.Tick += new System.EventHandler(this.timer_live_cat_video_Tick);
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFood.FlatAppearance.BorderSize = 0;
            this.btnAddFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFood.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFood.Image")));
            this.btnAddFood.Location = new System.Drawing.Point(521, 315);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(35, 35);
            this.btnAddFood.TabIndex = 54;
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // pb_cat_water
            // 
            this.pb_cat_water.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_cat_water.Image = ((System.Drawing.Image)(resources.GetObject("pb_cat_water.Image")));
            this.pb_cat_water.Location = new System.Drawing.Point(592, 275);
            this.pb_cat_water.Name = "pb_cat_water";
            this.pb_cat_water.Size = new System.Drawing.Size(110, 110);
            this.pb_cat_water.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_cat_water.TabIndex = 37;
            this.pb_cat_water.TabStop = false;
            // 
            // pb_cat
            // 
            this.pb_cat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_cat.Image = ((System.Drawing.Image)(resources.GetObject("pb_cat.Image")));
            this.pb_cat.Location = new System.Drawing.Point(284, 11);
            this.pb_cat.Name = "pb_cat";
            this.pb_cat.Size = new System.Drawing.Size(256, 171);
            this.pb_cat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_cat.TabIndex = 35;
            this.pb_cat.TabStop = false;
            // 
            // pb_cat_food
            // 
            this.pb_cat_food.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_cat_food.Image = ((System.Drawing.Image)(resources.GetObject("pb_cat_food.Image")));
            this.pb_cat_food.Location = new System.Drawing.Point(390, 275);
            this.pb_cat_food.Name = "pb_cat_food";
            this.pb_cat_food.Size = new System.Drawing.Size(125, 107);
            this.pb_cat_food.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_cat_food.TabIndex = 36;
            this.pb_cat_food.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(789, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.btn_back.TabIndex = 21;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btnAddWater
            // 
            this.btnAddWater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddWater.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddWater.FlatAppearance.BorderSize = 0;
            this.btnAddWater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWater.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWater.Image = ((System.Drawing.Image)(resources.GetObject("btnAddWater.Image")));
            this.btnAddWater.Location = new System.Drawing.Point(709, 315);
            this.btnAddWater.Name = "btnAddWater";
            this.btnAddWater.Size = new System.Drawing.Size(33, 35);
            this.btnAddWater.TabIndex = 55;
            this.btnAddWater.UseVisualStyleBackColor = true;
            this.btnAddWater.Click += new System.EventHandler(this.btnAddWater_Click);
            // 
            // food_timer
            // 
            this.food_timer.Enabled = true;
            this.food_timer.Interval = 5000;
            this.food_timer.Tick += new System.EventHandler(this.food_timer_Tick);
            // 
            // water_timer
            // 
            this.water_timer.Enabled = true;
            this.water_timer.Interval = 5000;
            this.water_timer.Tick += new System.EventHandler(this.water_timer_Tick);
            // 
            // lbl_food_warning
            // 
            this.lbl_food_warning.AutoSize = true;
            this.lbl_food_warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_food_warning.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_food_warning.Location = new System.Drawing.Point(390, 400);
            this.lbl_food_warning.Name = "lbl_food_warning";
            this.lbl_food_warning.Size = new System.Drawing.Size(0, 16);
            this.lbl_food_warning.TabIndex = 57;
            this.lbl_food_warning.Visible = false;
            // 
            // lbl_water_warning
            // 
            this.lbl_water_warning.AutoSize = true;
            this.lbl_water_warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_water_warning.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_water_warning.Location = new System.Drawing.Point(589, 400);
            this.lbl_water_warning.Name = "lbl_water_warning";
            this.lbl_water_warning.Size = new System.Drawing.Size(0, 16);
            this.lbl_water_warning.TabIndex = 58;
            this.lbl_water_warning.Visible = false;
            // 
            // btn_save_feeding_schedule
            // 
            this.btn_save_feeding_schedule.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_save_feeding_schedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_feeding_schedule.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btn_save_feeding_schedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_feeding_schedule.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_feeding_schedule.Location = new System.Drawing.Point(104, 400);
            this.btn_save_feeding_schedule.Name = "btn_save_feeding_schedule";
            this.btn_save_feeding_schedule.Size = new System.Drawing.Size(100, 50);
            this.btn_save_feeding_schedule.TabIndex = 56;
            this.btn_save_feeding_schedule.Text = "Submit";
            this.btn_save_feeding_schedule.UseVisualStyleBackColor = false;
            this.btn_save_feeding_schedule.Click += new System.EventHandler(this.btn_spray_Click);
            // 
            // PetFeederForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.lbl_water_warning);
            this.Controls.Add(this.lbl_food_warning);
            this.Controls.Add(this.btn_save_feeding_schedule);
            this.Controls.Add(this.btnAddWater);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.cb_send_help);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.cb_period);
            this.Controls.Add(this.cb_mins);
            this.Controls.Add(this.cb_hours);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.bc_goof_type);
            this.Controls.Add(this.date_picker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pb_cat_water);
            this.Controls.Add(this.pb_cat);
            this.Controls.Add(this.pb_cat_food);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_help1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back1);
            this.Controls.Add(this.btn_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PetFeederForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Assistant - Smart Pet Feeder";
            this.Load += new System.EventHandler(this.PetFeederForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_cat_water)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cat_food)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label btn_back1;
        private Button btn_back;
        private Button button1;
        private Label btn_help1;
        private PictureBox pb_cat;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pb_cat_food;
        private PictureBox pb_cat_water;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label8;
        private Label timeLabel;
        private ComboBox cb_period;
        private ComboBox cb_mins;
        private ComboBox cb_hours;
        private Label typeLabel;
        private Label dateLabel;
        private ComboBox bc_goof_type;
        private DateTimePicker date_picker;
        private Label label9;
        private Label label10;
        private ComboBox cb_send_help;
        private System.Windows.Forms.Timer timer_live_cat_video;
        private Button btnAddFood;
        private Button btnAddWater;
        private RoundedButton btn_save_feeding_schedule;
        private System.Windows.Forms.Timer food_timer;
        private System.Windows.Forms.Timer water_timer;
        private Label lbl_food_warning;
        private Label lbl_water_warning;
    }
}