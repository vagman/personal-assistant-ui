using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace personal_assistant_ui
{
    public partial class ShoeRackForm : Form
    {
        public static string workingDirectory = Environment.CurrentDirectory;
        public ShoeRackForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu mainmenu = new MainMenu();
            mainmenu.Closed += (s, AssemblyLoadEventArgs) => Close();
            mainmenu.Show();
            Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            MainMenu mainmenu = new MainMenu();
            mainmenu.Closed += (s, AssemblyLoadEventArgs) => Close();
            mainmenu.Show();
            Hide();
        }

        private void btn_help1_Click(object sender, EventArgs e)
        {

        }
        
        private void btn_spray_Click(object sender, EventArgs e)
        {
            SprayingLoadingForm sprayForm = new SprayingLoadingForm();
            sprayForm.Closed += (s, AssemblyLoadEventArgs) => Close();
            sprayForm.Owner = this;
            Enabled = false;
            sprayForm.Show();
        }

        private void ShoeRackForm_Load(object sender, EventArgs e)
        {
        }

        int shoeCount = 0;
        int btnCount = 0;
        private void btn_shoe_right_Click(object sender, EventArgs e)
        {
            if (shoeCount < 3)
            {
                btnCount = 0;
                lbl_no_shoes.Visible = false;
                shoeCount++;
                pb_shoes.Image = (Image)Properties.Resources.ResourceManager.GetObject("shoe" + shoeCount);
            }

            if (shoeCount == 3)
            {
                btnCount++;
                if (btnCount > 1)
                {
                    lbl_no_shoes.Visible = true;
                }
            }

            switch(shoeCount)
            {
                case 0:
                    lbl_shoe_name.Text = "Nike Air Presto";
                    lbl_shoe_size.Text = "49";
                    lbl_shoe_use.Text = "Training / Gym";
                    lbl_buy_new_shoes.Visible = false;
                    lbl_buy_new_shoes1.Visible = false;
                    lbl_link_skroutz.Visible = false;
                    break;
                case 1:
                    lbl_shoe_name.Text = "Nike AirMax Old School";
                    lbl_shoe_size.Text = "46.5";
                    lbl_shoe_use.Text = "Casual";
                    lbl_buy_new_shoes.Visible = false;
                    lbl_buy_new_shoes1.Visible = false;
                    lbl_link_skroutz.Visible = false;
                    break;
                case 2:
                    lbl_shoe_name.Text = "Nike AirMax v2.0";
                    lbl_shoe_size.Text = "47.5";
                    lbl_shoe_use.Text = "Interview / Meeting";
                    lbl_buy_new_shoes.Visible = false;
                    lbl_buy_new_shoes1.Visible = false;
                    lbl_link_skroutz.Visible = false;
                    break;
                case 3:
                    pb_shoes.Image = (Image)Properties.Resources.ResourceManager.GetObject("shoe3");
                    lbl_shoe_name.Text = "Oops! Unavaialble shoe.";
                    lbl_shoe_size.Text = "Oops! Unavaialble shoe.";
                    lbl_shoe_use.Text = "Oops! Unavaialble shoe.";
                    lbl_buy_new_shoes.Visible = true;
                    lbl_buy_new_shoes1.Visible = true;
                    lbl_link_skroutz.Visible = true;
                    break;
            }
        }
         
        private void btn_shoe_left_Click(object sender, EventArgs e)
        {
            if (shoeCount > 0)
            {
                btnCount = 0;
                lbl_no_shoes.Visible = false;
                shoeCount--;
                pb_shoes.Image = (Image)Properties.Resources.ResourceManager.GetObject("shoe" + shoeCount);
            } 
            if (shoeCount == 0) 
            {
                btnCount++;
                if (btnCount > 1)
                {
                    lbl_no_shoes.Visible = true;
                }
            }

            switch (shoeCount)
            {
                case 0:
                    lbl_shoe_name.Text = "Nike Air Presto";
                    lbl_shoe_size.Text = "49";
                    lbl_shoe_use.Text = "Training / Gym";
                    lbl_buy_new_shoes.Visible = false;
                    lbl_buy_new_shoes1.Visible = false;
                    lbl_link_skroutz.Visible = false;
                    break;
                case 1:
                    lbl_shoe_name.Text = "Nike AirMax Old School";
                    lbl_shoe_size.Text = "46.5";
                    lbl_shoe_use.Text = "Casual";
                    lbl_buy_new_shoes.Visible = false;
                    lbl_buy_new_shoes1.Visible = false;
                    lbl_link_skroutz.Visible = false;
                    break;
                case 2:
                    lbl_shoe_name.Text = "Nike AirMax v2.0";
                    lbl_shoe_size.Text = "47.5";
                    lbl_shoe_use.Text = "Interview / Meeting";
                    lbl_buy_new_shoes.Visible = false;
                    lbl_buy_new_shoes1.Visible = false;
                    lbl_link_skroutz.Visible = false;
                    break;
                case 3:
                    pb_shoes.Image = (Image)Properties.Resources.ResourceManager.GetObject("shoe3");
                    lbl_shoe_name.Text = "Oops! Unavaialble shoe.";
                    lbl_shoe_size.Text = "Oops! Unavaialble shoe.";
                    lbl_shoe_use.Text = "Oops! Unavaialble shoe.";
                    lbl_buy_new_shoes.Visible = true;
                    lbl_buy_new_shoes1.Visible = true;
                    lbl_link_skroutz.Visible = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Directory.GetParent(workingDirectory).Parent.Parent.FullName + @"\HelpFiles\PersonalAssistant.chm";
            Help.ShowHelp(this, path, HelpNavigator.TopicId, "2");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_date.SelectedIndex)
            {
                case 0:
                    pb_shoes.Image = (Image)Properties.Resources.ResourceManager.GetObject("shoe1");
                    lbl_shoe_name.Text = "Nike AirMax Old School";
                    lbl_shoe_size.Text = "46.5";
                    lbl_shoe_use.Text = "Casual";
                    lbl_buy_new_shoes.Visible = false;
                    lbl_buy_new_shoes1.Visible = false;
                    lbl_link_skroutz.Visible = false;
                    break;
                case 1:
                    pb_shoes.Image = (Image)Properties.Resources.ResourceManager.GetObject("shoe0");
                    lbl_shoe_name.Text = "Nike Air Presto";
                    lbl_shoe_size.Text = "49";
                    lbl_shoe_use.Text = "Training / Gym";
                    lbl_buy_new_shoes.Visible = false;
                    lbl_buy_new_shoes1.Visible = false;
                    lbl_link_skroutz.Visible = false;
                    break;
                case 2:
                    pb_shoes.Image = (Image)Properties.Resources.ResourceManager.GetObject("shoe2");
                    lbl_shoe_name.Text = "Nike AirMax v2.0";
                    lbl_shoe_size.Text = "47.5";
                    lbl_shoe_use.Text = "Interview / Meeting";
                    lbl_buy_new_shoes.Visible = false;
                    lbl_buy_new_shoes1.Visible = false;
                    lbl_link_skroutz.Visible = false;
                    break;
                case 3:
                    pb_shoes.Image = (Image)Properties.Resources.ResourceManager.GetObject("shoe3");
                    lbl_shoe_name.Text = "Oops! Unavaialble shoe.";
                    lbl_shoe_size.Text = "Oops! Unavaialble shoe.";
                    lbl_shoe_use.Text = "Oops! Unavaialble shoe.";
                    lbl_buy_new_shoes.Visible = true;
                    lbl_buy_new_shoes1.Visible = true;
                    lbl_link_skroutz.Visible = true;
                    break;
            }
        }
    }
}
