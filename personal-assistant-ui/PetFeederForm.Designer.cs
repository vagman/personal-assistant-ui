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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetFeederForm));
            this.btn_back1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.group_box_pet_feeder_controls = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_help1 = new System.Windows.Forms.Label();
            this.group_box_pet_feeder_controls.SuspendLayout();
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
            // group_box_pet_feeder_controls
            // 
            this.group_box_pet_feeder_controls.Controls.Add(this.label1);
            this.group_box_pet_feeder_controls.Location = new System.Drawing.Point(12, 52);
            this.group_box_pet_feeder_controls.Name = "group_box_pet_feeder_controls";
            this.group_box_pet_feeder_controls.Size = new System.Drawing.Size(486, 387);
            this.group_box_pet_feeder_controls.TabIndex = 23;
            this.group_box_pet_feeder_controls.TabStop = false;
            this.group_box_pet_feeder_controls.Text = "Smart Pet Feeder Controls";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Take a look from the camera";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(787, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_help1
            // 
            this.btn_help1.AutoSize = true;
            this.btn_help1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_help1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help1.Location = new System.Drawing.Point(689, 418);
            this.btn_help1.Name = "btn_help1";
            this.btn_help1.Size = new System.Drawing.Size(92, 21);
            this.btn_help1.TabIndex = 33;
            this.btn_help1.Text = "Need help ?";
            // 
            // PetFeederForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_help1);
            this.Controls.Add(this.group_box_pet_feeder_controls);
            this.Controls.Add(this.btn_back1);
            this.Controls.Add(this.btn_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PetFeederForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Assistant - Smart Pet Feeder";
            this.group_box_pet_feeder_controls.ResumeLayout(false);
            this.group_box_pet_feeder_controls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label btn_back1;
        private Button btn_back;
        private GroupBox group_box_pet_feeder_controls;
        private Label label1;
        private Button button1;
        private Label btn_help1;
    }
}