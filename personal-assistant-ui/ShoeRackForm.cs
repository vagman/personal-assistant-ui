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

        private void button4_Click(object sender, EventArgs e)
        {

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

        }

        private void ShoeRackForm_Load(object sender, EventArgs e)
        {
           

        }

        int shoeCount = 0;
        private void btn_shoe_right_Click(object sender, EventArgs e)
        {
            if (shoeCount < 2)
            {
                shoeCount++;
                string imgName = "shoe" + shoeCount;
                lbl_shoe_use.Text = imgName;
                pb_shoes.Image = (Image)Properties.Resources.ResourceManager.GetObject(imgName);
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
                shoeCount--;
                string imgName = "shoe" + shoeCount; 
                lbl_shoe_use.Text = imgName;
                pb_shoes.Image = (Image)Properties.Resources.ResourceManager.GetObject(imgName);
            }
            
        }
    }
}
