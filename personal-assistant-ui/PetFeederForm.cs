using personal_assistant_ui.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personal_assistant_ui
{
    public partial class PetFeederForm : Form
    {
        decimal cat = 0;
        public PetFeederForm()
        {
            InitializeComponent();
        }

        private void btn_back1_Click(object sender, EventArgs e)
        {
            MainMenu mainmenu = new MainMenu();
            mainmenu.Closed += (s, AssemblyLoadEventArgs) => Close();
            mainmenu.Show();
            Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainMenu mainmenu = new MainMenu();
            mainmenu.Closed += (s, AssemblyLoadEventArgs) => Close();
            mainmenu.Show();
            Hide();
        }

        private void timer_live_cat_video_Tick(object sender, EventArgs e)
        {
            if (cat == 0)
            {
                cat = 1;
                pb_cat.Image = (Image)Resources.ResourceManager.GetObject("calm_cat");
                timer_live_cat_video.Interval = 6000;
                label9.ForeColor = Color.Black;
                label10.ForeColor = Color.Black;
                cb_send_help.ForeColor = Color.Black;
                label9.Text = "Your cat seems to be just fine";
                cb_send_help.Text = "No need for help.";
                label10.Text = "She is relaxed and walking\naround as usual.";
            } 
            else if (cat == 1)
            {
                cat = 2;
                pb_cat.Image = (Image)Resources.ResourceManager.GetObject("groumpy_cat");
                timer_live_cat_video.Interval = 4000;
                label9.ForeColor = Color.Black;
                label10.ForeColor = Color.Black;
                cb_send_help.ForeColor = Color.Black;
                cb_send_help.Text = "No need for help.";
                label9.Text = "Your cat seems to be just fine";
                label10.Text = "He seems to be a bit groumpy.\nDont't you think ?";
            } 
            else if (cat == 2)
            {
                cat = 0;
                pb_cat.Image = (Image)Resources.ResourceManager.GetObject("cat_needs_help");
                timer_live_cat_video.Interval = 2500;
                label9.Visible = true;
                label10.Visible = true;
                cb_send_help.Visible = true;
                cb_send_help.ForeColor = Color.Red;
                label9.ForeColor = Color.Red;
                label10.ForeColor = Color.Red;
                label9.Text = "Oh no! Your cat is in trouble";
                cb_send_help.Text = "Call Mom!";
                label10.Text = "Please select the type of\r\nhelp you want us to send.";
            }
        }

        private void btn_spray_Click(object sender, EventArgs e)
        {
            var confirm_cat_feed_program = MessageBox.Show("Date: " + date_picker.Value + "\nTime: " + date_picker.Value + "\nPeriod: " + date_picker.Value, "Confirm information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (confirm_cat_feed_program == DialogResult.OK)
            {
                 
            }
            else
            {
                MessageBox.Show("Feeding shedule was succesfuly canceled.", "Schedule Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {

        }

        private void btnAddWater_Click(object sender, EventArgs e)
        {

        }
        //TODO: change food/water % images with a diffrent timer tick event
    }
}
