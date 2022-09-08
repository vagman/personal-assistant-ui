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
            this.tstLabel = new System.Windows.Forms.Label();
            this.gbox = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.showTaskBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addBtn.Location = new System.Drawing.Point(686, 12);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(146, 30);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Προσθήκη συνήθειας +";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(12, 447);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 31);
            this.button4.TabIndex = 9;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tstLabel
            // 
            this.tstLabel.AutoSize = true;
            this.tstLabel.Location = new System.Drawing.Point(255, 27);
            this.tstLabel.Name = "tstLabel";
            this.tstLabel.Size = new System.Drawing.Size(38, 15);
            this.tstLabel.TabIndex = 10;
            this.tstLabel.Text = "label1";
            this.tstLabel.Click += new System.EventHandler(this.tstLabel_Click);
            // 
            // gbox
            // 
            this.gbox.Location = new System.Drawing.Point(579, 48);
            this.gbox.Name = "gbox";
            this.gbox.Size = new System.Drawing.Size(253, 387);
            this.gbox.TabIndex = 11;
            this.gbox.TabStop = false;
            this.gbox.Text = "groupBox1";
            this.gbox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 107);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(327, 94);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(75, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(2022, 9, 7, 1, 48, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::personal_assistant_ui.Properties.Resources.trash;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(298, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 37);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showTaskBtn
            // 
            this.showTaskBtn.Location = new System.Drawing.Point(212, 215);
            this.showTaskBtn.Name = "showTaskBtn";
            this.showTaskBtn.Size = new System.Drawing.Size(75, 23);
            this.showTaskBtn.TabIndex = 15;
            this.showTaskBtn.Text = "Show";
            this.showTaskBtn.UseVisualStyleBackColor = true;
            this.showTaskBtn.Click += new System.EventHandler(this.showTaskBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(20, 213);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 16;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // Scheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 490);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.showTaskBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gbox);
            this.Controls.Add(this.tstLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.addBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Scheduler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scheduler";
            this.Load += new System.EventHandler(this.Scheduler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addBtn;
        private Button button4;
        private Label tstLabel;
        private GroupBox gbox;
        private ListBox listBox1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button showTaskBtn;
        private Button refreshBtn;
    }
}