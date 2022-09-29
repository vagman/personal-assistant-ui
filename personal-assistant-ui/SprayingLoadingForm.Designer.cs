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
            this.SuspendLayout();
            // 
            // progress_bar_spraying
            // 
            this.progress_bar_spraying.Location = new System.Drawing.Point(37, 65);
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
            this.btn_back1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_back1.Location = new System.Drawing.Point(44, 12);
            this.btn_back1.Name = "btn_back1";
            this.btn_back1.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.btn_back1.Size = new System.Drawing.Size(47, 30);
            this.btn_back1.TabIndex = 20;
            this.btn_back1.Text = "Back";
            this.btn_back1.Visible = false;
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
            this.btn_back.Visible = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_spraying_done
            // 
            this.lbl_spraying_done.AutoSize = true;
            this.lbl_spraying_done.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_spraying_done.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spraying_done.ForeColor = System.Drawing.Color.Green;
            this.lbl_spraying_done.Location = new System.Drawing.Point(90, 71);
            this.lbl_spraying_done.Name = "lbl_spraying_done";
            this.lbl_spraying_done.Size = new System.Drawing.Size(345, 26);
            this.lbl_spraying_done.TabIndex = 21;
            this.lbl_spraying_done.Text = "Spraying your shoes was succesful!";
            this.lbl_spraying_done.UseWaitCursor = true;
            this.lbl_spraying_done.Visible = false;
            // 
            // SprayingLoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(546, 176);
            this.Controls.Add(this.lbl_spraying_done);
            this.Controls.Add(this.btn_back1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.progress_bar_spraying);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SprayingLoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Assistant - Spraying Shoes";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.SprayingLoadingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgressBar progress_bar_spraying;
        private System.Windows.Forms.Timer timer_spraying;
        private Label btn_back1;
        private Button btn_back;
        private Label lbl_spraying_done;
    }
}