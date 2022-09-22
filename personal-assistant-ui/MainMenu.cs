
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Resources;
using personal_assistant_ui.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Reflection;

namespace personal_assistant_ui

{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Scheduler scheduler = new Scheduler();
            scheduler.Closed += (s, AssemblyLoadEventArgs) => this.Close(); //When exited from the Scheduler form the program closed too.
            scheduler.Show();
            this.Hide(); //the Hide method putted at the bottom to hide smoothly the loginForm
        }

        int btnWasClicked = 1;
        Color green = ColorTranslator.FromHtml("#09e84c");
        Color red = ColorTranslator.FromHtml("#e84509");
        private void button5_Click(object sender, EventArgs e)
        {
            // Turn on/off sound of lamp
            Assembly assembly;
            Stream soundStream;
            assembly = Assembly.GetExecutingAssembly();
            SoundPlayer sp = new SoundPlayer(Resources.turn_on_off_lamp);
            sp.Play();

            btnWasClicked *= -1;
            if(btnWasClicked == -1)
            {
                button5.BackgroundImage = Resources.lights_on;
                label6.Font = new Font(label6.Font.Name, 9, FontStyle.Bold);
                label6.Text = "On";
                label6.ForeColor = green;
                label6.Refresh();
                
            }
            else
            {
                button5.BackgroundImage = Resources.lights_off;
                label6.Text = "Off";
                label6.ForeColor = red;
                label6.Refresh();
            }        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PetFeederForm petFeeder = new PetFeederForm();
            petFeeder.Closed += (s, AssemblyLoadEventArgs) => this.Close();
            petFeeder.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShoeRackForm shoerack = new ShoeRackForm();
            shoerack.Closed += (s, AssemblyLoadEventArgs) => this.Close();
            shoerack.Show();
            this.Hide(); 
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Scheduler scheduler = new Scheduler();            
            scheduler.Closed += (s, AssemblyLoadEventArgs) => this.Close();
            scheduler.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            btnWasClicked *= -1;
            if (btnWasClicked == -1)
            {
                button5.BackgroundImage = Properties.Resources.lights_on;
                label6.Font = new Font(label6.Font.Name, 9, FontStyle.Bold);
                label6.Text = "On";
                label6.ForeColor = green;
                label6.Refresh();

            }
            else
            {
                button5.BackgroundImage = Properties.Resources.lights_off;
                label6.Text = "Off";
                label6.ForeColor = red;
                label6.Refresh();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to log out ?", "Log out", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                login login = new login();
                login.Closed += (s, AssemblyLoadEventArgs) => this.Close();
                login.Show();
                this.Hide();
            }
            else {
                return;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to log out ?", "Log out", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                login login = new login();
                login.Closed += (s, AssemblyLoadEventArgs) => this.Close();
                login.Show();
                this.Hide();
            }
            else{
                return;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ShoeRackForm shoerack = new ShoeRackForm();
            shoerack.Closed += (s, AssemblyLoadEventArgs) => this.Close();
            shoerack.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            PetFeederForm petFeeder = new PetFeederForm();
            petFeeder.Closed += (s, AssemblyLoadEventArgs) => this.Close();
            petFeeder.Show();
            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            string path = "Settings.txt";
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();

                using (TextWriter tw = new StreamWriter(path))
                {
                    tw.WriteLine("English");
                    tw.WriteLine("Light");
                    tw.Close();
                }
            }
            var lines = File.ReadAllLines("Settings.txt");
            if (lines[0].ToLower().Equals("greek"))
            {
                // changeToGreek();
                return;
            }
            if (lines[1].ToLower().Equals("dark"))
            {
                // changeToDark();
                return;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.Closed += (s, AssemblyLoadEventArgs) => Close();
            sf.Show();
            this.Hide();
        }

        private void lbl_logout_MouseEnter(object sender, EventArgs e)
        {
            btn_logout.ForeColor = red;
            lbl_logout.ForeColor = red;
        }

        private void btn_logout_MouseEnter(object sender, EventArgs e)
        {
            btn_logout.ForeColor = red;
            lbl_logout.ForeColor = red;
        }

        private void lbl_logout_MouseLeave(object sender, EventArgs e)
        {
            btn_logout.ForeColor = Color.Black;
            lbl_logout.ForeColor = Color.Black;
        }

        private void btn_logout_MouseLeave(object sender, EventArgs e)
        {
            btn_logout.ForeColor = Color.Black;
            lbl_logout.ForeColor = Color.Black;
        }
    }
}
