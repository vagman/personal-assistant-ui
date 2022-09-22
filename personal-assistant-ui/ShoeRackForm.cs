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

        private void btn_shoe_right_Click(object sender, EventArgs e)
        {
            pb_shoes.Load(Resource);
        }

        private void btn_shoe_left_Click(object sender, EventArgs e)
        {

        }
    }
}
