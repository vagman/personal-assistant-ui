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
        public static string workingDirectory = Environment.CurrentDirectory;
        decimal cat = 0;
        int food_percentage = 20; // default food displayed percentage: 20% image
        int water_percentage = 90; // default water displayed percentage: 90% image
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
                MessageBox.Show("Feeding shedule was succesfuly saved.", "Schedule Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Feeding shedule was succesfuly canceled.", "Schedule Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(Resources.dog_food);
            switch (food_percentage)
            {
                case 0:
                    pb_cat_food.Image = (Image)Resources.ResourceManager.GetObject("10percent");
                    food_percentage = 10;
                    sp.Play();
                    break;
                case 10:
                    pb_cat_food.Image = (Image)Resources.ResourceManager.GetObject("20percent");
                    food_percentage = 20;
                    sp.Play();
                    break;
                case 20:
                    pb_cat_food.Image = (Image)Resources.ResourceManager.GetObject("30percent");
                    food_percentage = 30;
                    sp.Play();
                    break;
                case 30:
                    pb_cat_food.Image = (Image)Resources.ResourceManager.GetObject("40percent");
                    food_percentage = 40;
                    sp.Play();
                    break;
                case 40:
                    pb_cat_food.Image = (Image)Resources.ResourceManager.GetObject("50percent");
                    food_percentage = 50;
                    sp.Play();
                    break;
                case 50:
                    pb_cat_food.Image = (Image)Resources.ResourceManager.GetObject("60percent");
                    food_percentage = 60;
                    sp.Play();
                    break;
                case 60:
                    pb_cat_food.Image = (Image)Resources.ResourceManager.GetObject("70percent");
                    food_percentage = 70;
                    sp.Play();
                    break;
                case 70:
                    pb_cat_food.Image = (Image)Resources.ResourceManager.GetObject("80percent");
                    food_percentage = 80;
                    sp.Play();
                    break;
                case 80:
                    pb_cat_food.Image = (Image)Resources.ResourceManager.GetObject("90percent");
                    food_percentage = 90;
                    sp.Play();
                    break;
                case 90:
                    pb_cat_food.Image = (Image)Resources.ResourceManager.GetObject("100percent");
                    food_percentage = 100;
                    sp.Play();
                    break;
                case 100:
                    MessageBox.Show("Your cat's food is already full.\nPlease try again later.", "Food: 100%", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    break;
            }
        }

        private void btnAddWater_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(Resources.water);
            switch (water_percentage)
            {
                case 0:
                    pb_cat_water.Image = (Image)Resources.ResourceManager.GetObject("10percent");
                    water_percentage = 10;
                    sp.Play();
                    break;
                case 10:
                    pb_cat_water.Image = (Image)Resources.ResourceManager.GetObject("20percent");
                    water_percentage = 20;
                    sp.Play();
                    break;
                case 20:
                    pb_cat_water.Image = (Image)Resources.ResourceManager.GetObject("30percent");
                    water_percentage = 30;
                    sp.Play();
                    break;
                case 30:
                    pb_cat_water.Image = (Image)Resources.ResourceManager.GetObject("40percent");
                    water_percentage = 40;
                    sp.Play();
                    break;
                case 40:
                    pb_cat_water.Image = (Image)Resources.ResourceManager.GetObject("50percent");
                    water_percentage = 50;
                    sp.Play();
                    break;
                case 50:
                    pb_cat_water.Image = (Image)Resources.ResourceManager.GetObject("60percent");
                    water_percentage = 60;
                    sp.Play();
                    break;
                case 60:
                    pb_cat_water.Image = (Image)Resources.ResourceManager.GetObject("70percent");
                    water_percentage = 70;
                    sp.Play();
                    break;
                case 70:
                    pb_cat_water.Image = (Image)Resources.ResourceManager.GetObject("80percent");
                    water_percentage = 80;
                    sp.Play();
                    break;
                case 80:
                    pb_cat_water.Image = (Image)Resources.ResourceManager.GetObject("90percent");
                    water_percentage = 90;
                    sp.Play();
                    break;
                case 90:
                    pb_cat_water.Image = (Image)Resources.ResourceManager.GetObject("100percent");
                    water_percentage = 100;
                    sp.Play();
                    break;
                case 100:
                    MessageBox.Show("Your cat's water is already full.\nPlease try again later.", "Water: 100%", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    break;
            }
        }

        private void food_timer_Tick(object sender, EventArgs e)
        {
            switch (food_percentage)
            {
                case 100:
                    pb_cat_food.Image = (Image)Resources.ResourceManager.GetObject("90percent");
                    food_percentage = 90;
                    lbl_food_warning.Visible = false;
                    break;
                case 90:
                    pb_cat_food.Image = (Image)Resources.ResourceManager.GetObject("80percent");
                    food_percentage = 80;
                    lbl_food_warning.Visible = false;
                    break;
                case 80:
                    pb_cat_food.Image = (Image)Resources.ResourceManager.GetObject("70percent");
                    food_percentage = 70;
                    lbl_food_warning.Visible = false;
                    break;
                case 70:
                    pb_cat_food.Image = (Image)Resources.ResourceManager.GetObject("60percent");
                    food_percentage = 60;
                    lbl_food_warning.Visible = false;
                    break;
                case 60:
                    pb_cat_food.Image = (Image)Resources.ResourceManager.GetObject("50percent");
                    food_percentage = 50;
                    lbl_food_warning.Visible = false;
                    break;
                case 50:
                    pb_cat_food.Image = (Image)Resources.ResourceManager.GetObject("40percent");
                    food_percentage = 40;
                    lbl_food_warning.Visible = false;
                    break;
                case 40:
                    pb_cat_food.Image = (Image)Resources.ResourceManager.GetObject("30percent");
                    food_percentage = 30;
                    lbl_food_warning.Visible = false;
                    break;
                case 30:
                    pb_cat_food.Image = (Image)Resources.ResourceManager.GetObject("20percent");
                    food_percentage = 20;
                    lbl_food_warning.Visible = false;
                    break;
                case 20:
                    pb_cat_food.Image = (Image)Resources.ResourceManager.GetObject("10percent");
                    food_percentage = 10;
                    lbl_food_warning.Text = "Your pet will soon need more food.";
                    lbl_food_warning.Visible = true;
                    lbl_food_warning.ForeColor = Color.OrangeRed;
                    break;
                case 10:
                    pb_cat_food.Image = (Image)Resources.ResourceManager.GetObject("0percent");
                    food_percentage = 0;
                    lbl_food_warning.Text = "Your pet needs food!";
                    lbl_food_warning.Visible = true;
                    lbl_food_warning.ForeColor = Color.Red;
                    break;
                case 0:
                    break;
                default:
                    break;
            }
        }

        private void water_timer_Tick(object sender, EventArgs e)
        {
            switch (water_percentage)
            {
                case 100:
                    pb_cat_water.Image = (Image)Resources.ResourceManager.GetObject("90percent");
                    water_percentage = 90;
                    lbl_water_warning.Visible = false;
                    break;
                case 90:
                    pb_cat_water.Image = (Image)Resources.ResourceManager.GetObject("80percent");
                    water_percentage = 80;
                    lbl_water_warning.Visible = false;
                    break;
                case 80:
                    pb_cat_water.Image = (Image)Resources.ResourceManager.GetObject("70percent");
                    water_percentage = 70;
                    lbl_water_warning.Visible = false;
                    break;
                case 70:
                    pb_cat_water.Image = (Image)Resources.ResourceManager.GetObject("60percent");
                    water_percentage = 60;
                    lbl_water_warning.Visible = false;
                    break;
                case 60:
                    pb_cat_water.Image = (Image)Resources.ResourceManager.GetObject("50percent");
                    water_percentage = 50;
                    lbl_water_warning.Visible = false;
                    break;
                case 50:
                    pb_cat_water.Image = (Image)Resources.ResourceManager.GetObject("40percent");
                    water_percentage = 40;
                    lbl_water_warning.Visible = false;
                    break;
                case 40:
                    pb_cat_water.Image = (Image)Resources.ResourceManager.GetObject("30percent");
                    water_percentage = 30;
                    lbl_water_warning.Visible = false;
                    break;
                case 30:
                    pb_cat_water.Image = (Image)Resources.ResourceManager.GetObject("20percent");
                    water_percentage = 20;
                    lbl_water_warning.Visible = false;
                    break;
                case 20:
                    pb_cat_water.Image = (Image)Resources.ResourceManager.GetObject("10percent");
                    water_percentage = 10;
                    lbl_water_warning.Text = "Your pet will soon need more water.";
                    lbl_food_warning.Visible = true;
                    lbl_water_warning.ForeColor = Color.OrangeRed;
                    break;
                case 10:
                    pb_cat_water.Image = (Image)Resources.ResourceManager.GetObject("0percent");
                    water_percentage = 0;
                    lbl_water_warning.Text = "Your pet needs water!";
                    lbl_food_warning.Visible = true;
                    lbl_water_warning.ForeColor = Color.Red;
                    break;
                case 0:

                    break;
                default:
                    break;
            }
        }

        private void PetFeederForm_Load(object sender, EventArgs e)
        {
            food_percentage = 20;
            water_percentage = 90;
            food_timer.Enabled = true;
            water_timer.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Directory.GetParent(workingDirectory).Parent.Parent.FullName + @"\HelpFiles\PersonalAssistant.chm";
            Help.ShowHelp(this, path, HelpNavigator.TopicId, "9");
        }
    }
}
