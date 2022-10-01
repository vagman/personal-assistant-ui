namespace personal_assistant_ui
{
    partial class SprayingLoadingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SprayingLoadingForm));
            this.progress_bar_spraying = new System.Windows.Forms.ProgressBar();
            this.timer_spraying = new System.Windows.Forms.Timer(this.components);
            this.btn_back1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_spraying_done = new System.Windows.Forms.Label();
            this.lbl_spraying_time = new System.Windows.Forms.Label();
            this.checkMarkImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.checkMarkImage)).BeginInit();
            this.SuspendLayout();
            // 
            // progress_bar_spraying
            // 
            this.progress_bar_spraying.Location = new System.Drawing.Point(124, 68);
            this.progress_bar_spraying.Name = "progress_bar_spraying";
            this.progress_bar_spraying.Size = new System.Drawing.Size(462, 38);
            this.progress_bar_spraying.TabIndex = 0;
            this.progress_bar_spraying.UseWaitCursor = true;
            // 
            // timer_spraying
            // 
            this.timer_spraying.Enabled = true;
            this.timer_spraying.Interval = 1000;
            this.timer_spraying.Tick += new System.EventHandler(this.timer_spraying_Tick);
            // 
            // btn_back1
            // 
            this.btn_back1.AutoSize = true;
            this.btn_back1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back1.Location = new System.Drawing.Point(44, 12);
            this.btn_back1.Name = "btn_back1";
            this.btn_back1.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.btn_back1.Size = new System.Drawing.Size(51, 31);
            this.btn_back1.TabIndex = 20;
            this.btn_back1.Text = "Back";
            this.btn_back1.Visible = false;
            this.btn_back1.Click += new System.EventHandler(this.btn_back1_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(30, 30);
            this.btn_back.TabIndex = 19;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Visible = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_spraying_done
            // 
            this.lbl_spraying_done.AutoSize = true;
            this.lbl_spraying_done.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_spraying_done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_spraying_done.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spraying_done.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbl_spraying_done.Location = new System.Drawing.Point(124, 55);
            this.lbl_spraying_done.Name = "lbl_spraying_done";
            this.lbl_spraying_done.Size = new System.Drawing.Size(440, 31);
            this.lbl_spraying_done.TabIndex = 21;
            this.lbl_spraying_done.Text = "Spraying your shoes was succesful!";
            this.lbl_spraying_done.Visible = false;
            // 
            // lbl_spraying_time
            // 
            this.lbl_spraying_time.AutoSize = true;
            this.lbl_spraying_time.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lbl_spraying_time.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spraying_time.Location = new System.Drawing.Point(122, 23);
            this.lbl_spraying_time.Name = "lbl_spraying_time";
            this.lbl_spraying_time.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.lbl_spraying_time.Size = new System.Drawing.Size(499, 32);
            this.lbl_spraying_time.TabIndex = 22;
            this.lbl_spraying_time.Text = "Please wait! Your shoes are being spraying with deodorant.";
            this.lbl_spraying_time.UseWaitCursor = true;
            // 
            // checkMarkImage
            // 
            this.checkMarkImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkMarkImage.BackgroundImage")));
            this.checkMarkImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkMarkImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkMarkImage.Location = new System.Drawing.Point(583, 43);
            this.checkMarkImage.Name = "checkMarkImage";
            this.checkMarkImage.Size = new System.Drawing.Size(50, 50);
            this.checkMarkImage.TabIndex = 23;
            this.checkMarkImage.TabStop = false;
            this.checkMarkImage.Visible = false;
            // 
            // SprayingLoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(684, 141);
            this.Controls.Add(this.checkMarkImage);
            this.Controls.Add(this.lbl_spraying_time);
            this.Controls.Add(this.lbl_spraying_done);
            this.Controls.Add(this.btn_back1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.progress_bar_spraying);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SprayingLoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Assistant - Spraying Shoes";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.SprayingLoadingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkMarkImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgressBar progress_bar_spraying;
        private System.Windows.Forms.Timer timer_spraying;
        private Label btn_back1;
        private Button btn_back;
        private Label lbl_spraying_done;
        private Label lbl_spraying_time;
        private PictureBox checkMarkImage;
    }
}