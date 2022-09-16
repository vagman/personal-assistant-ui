namespace personal_assistant_ui
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Theme = new System.Windows.Forms.Label();
            this.label_Language = new System.Windows.Forms.Label();
            this.comboBox_Theme = new System.Windows.Forms.ComboBox();
            this.comboBox_Language = new System.Windows.Forms.ComboBox();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.button_Help = new System.Windows.Forms.Button();
            this.imageList_Buttons = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Top.SuspendLayout();
            this.panel_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.BackColor = System.Drawing.Color.Transparent;
            this.label_Title.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(141, 29);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(122, 33);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "SETTINGS";
            // 
            // label_Theme
            // 
            this.label_Theme.AutoSize = true;
            this.label_Theme.BackColor = System.Drawing.Color.Transparent;
            this.label_Theme.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Theme.Location = new System.Drawing.Point(25, 115);
            this.label_Theme.Name = "label_Theme";
            this.label_Theme.Size = new System.Drawing.Size(67, 23);
            this.label_Theme.TabIndex = 4;
            this.label_Theme.Text = "Theme:";
            // 
            // label_Language
            // 
            this.label_Language.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Language.AutoSize = true;
            this.label_Language.BackColor = System.Drawing.Color.Transparent;
            this.label_Language.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Language.Location = new System.Drawing.Point(25, 158);
            this.label_Language.Name = "label_Language";
            this.label_Language.Size = new System.Drawing.Size(88, 23);
            this.label_Language.TabIndex = 5;
            this.label_Language.Text = "Language:";
            // 
            // comboBox_Theme
            // 
            this.comboBox_Theme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Theme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.comboBox_Theme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_Theme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Theme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Theme.ForeColor = System.Drawing.Color.White;
            this.comboBox_Theme.FormattingEnabled = true;
            this.comboBox_Theme.Items.AddRange(new object[] {
            "Light",
            "Dark"});
            this.comboBox_Theme.Location = new System.Drawing.Point(123, 118);
            this.comboBox_Theme.MaxDropDownItems = 2;
            this.comboBox_Theme.Name = "comboBox_Theme";
            this.comboBox_Theme.Size = new System.Drawing.Size(161, 27);
            this.comboBox_Theme.TabIndex = 1;
            this.comboBox_Theme.TabStop = false;
            this.comboBox_Theme.SelectedIndexChanged += new System.EventHandler(this.comboBox_Theme_SelectedIndexChanged);
            // 
            // comboBox_Language
            // 
            this.comboBox_Language.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Language.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.comboBox_Language.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_Language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Language.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Language.ForeColor = System.Drawing.Color.White;
            this.comboBox_Language.FormattingEnabled = true;
            this.comboBox_Language.Items.AddRange(new object[] {
            "English",
            "Ελληνικά"});
            this.comboBox_Language.Location = new System.Drawing.Point(123, 158);
            this.comboBox_Language.MaxDropDownItems = 2;
            this.comboBox_Language.Name = "comboBox_Language";
            this.comboBox_Language.Size = new System.Drawing.Size(161, 27);
            this.comboBox_Language.TabIndex = 2;
            this.comboBox_Language.TabStop = false;
            this.comboBox_Language.SelectedIndexChanged += new System.EventHandler(this.comboBox_Language_SelectedIndexChanged);
            // 
            // panel_Top
            // 
            this.panel_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.panel_Top.Controls.Add(this.label_Title);
            this.panel_Top.Location = new System.Drawing.Point(-1, -3);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(435, 94);
            this.panel_Top.TabIndex = 8;
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.panel_Bottom.Controls.Add(this.button_Help);
            this.panel_Bottom.Controls.Add(this.pictureBox1);
            this.panel_Bottom.Location = new System.Drawing.Point(-1, 219);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(435, 105);
            this.panel_Bottom.TabIndex = 9;
            // 
            // button_Help
            // 
            this.button_Help.BackColor = System.Drawing.Color.Transparent;
            this.button_Help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Help.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Help.ForeColor = System.Drawing.Color.White;
            this.button_Help.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Help.ImageKey = "info.png";
            this.button_Help.ImageList = this.imageList_Buttons;
            this.button_Help.Location = new System.Drawing.Point(141, 26);
            this.button_Help.Name = "button_Help";
            this.button_Help.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Help.Size = new System.Drawing.Size(110, 31);
            this.button_Help.TabIndex = 10;
            this.button_Help.Text = "Help";
            this.button_Help.UseVisualStyleBackColor = false;
            // 
            // imageList_Buttons
            // 
            this.imageList_Buttons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_Buttons.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_Buttons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox_Back_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 291);
            this.Controls.Add(this.panel_Bottom);
            this.Controls.Add(this.comboBox_Language);
            this.Controls.Add(this.comboBox_Theme);
            this.Controls.Add(this.label_Language);
            this.Controls.Add(this.label_Theme);
            this.Controls.Add(this.panel_Top);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Assistant - Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.panel_Bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Theme;
        private System.Windows.Forms.Label label_Language;
        private System.Windows.Forms.ComboBox comboBox_Theme;
        private System.Windows.Forms.ComboBox comboBox_Language;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.ImageList imageList_Buttons;
    
    }
}