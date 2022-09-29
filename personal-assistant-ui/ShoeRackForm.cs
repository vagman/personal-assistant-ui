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
            this.Enabled = false;
            sprayForm.Show();
        }

        private void ShoeRackForm_Load(object sender, EventArgs e)
        {
        }

        int shoeCount = 0;
        int btnCount = 0;
        private void btn_shoe_right_Click(object sender, EventArgs e)
        {
            if (shoeCount < 2)
            {
                btnCount = 0;
                lbl_no_shoes.Visible = false;
                shoeCount++;
                pb_shoes.Image = (Image)Properties.Resources.ResourceManager.GetObject("shoe" + shoeCount);
            }

            if (shoeCount == 2)
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
                    lbl_shoe_use.Text = "Training & Gym";
                    break;
                case 1:
                    lbl_shoe_name.Text = "Nike AirMax Old School";
                    lbl_shoe_size.Text = "46.5";
                    lbl_shoe_use.Text = "Casual";
                    break;
                case 2:
                    lbl_shoe_name.Text = "Nike AirMax v2.0";
                    lbl_shoe_size.Text = "47.5";
                    lbl_shoe_use.Text = "Interview/Meeting";
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
                    lbl_shoe_use.Text = "Training & Gym";
                    break;
                case 1:
                    lbl_shoe_name.Text = "Nike AirMax Old School";
                    lbl_shoe_size.Text = "46.5";
                    lbl_shoe_use.Text = "Casual";
                    break;
                case 2:
                    lbl_shoe_name.Text = "Nike AirMax v2.0";
                    lbl_shoe_size.Text = "47.5";
                    lbl_shoe_use.Text = "Interview/Meeting";
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
