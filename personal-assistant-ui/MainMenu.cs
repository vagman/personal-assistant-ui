
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
using System.Net.NetworkInformation;

namespace personal_assistant_ui
{
    public partial class MainMenu : Form
    {
        public static string workingDirectory = Environment.CurrentDirectory;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Scheduler scheduler = new Scheduler();
            scheduler.Closed += (s, AssemblyLoadEventArgs) => Close(); //When exited from the Scheduler form the program closed too.
            scheduler.Show();
            Hide(); //the Hide method putted at the bottom to hide smoothly the loginForm
        }

        int btnWasClicked = 1;
        Color green = ColorTranslator.FromHtml("#09e84c");
        Color red = ColorTranslator.FromHtml("#e84509");
        private void button5_Click(object sender, EventArgs e)
        {
            // Lamp turn on/off sound
            SoundPlayer sp = new SoundPlayer(Resources.turn_on_off_lamp);
            sp.Play();

            btnWasClicked *= -1;
            if(btnWasClicked == -1)
            {
                btn_smart_lamp.BackgroundImage = Resources.lights_on;
                label6.Font = new Font(label6.Font.Name, 12, FontStyle.Bold);
                label6.Text = "On";
                label6.ForeColor = green;
                label6.Refresh();
            }
            else
            {
                btn_smart_lamp.BackgroundImage = Resources.lights_off;
                label6.Font = new Font(label6.Font.Name, 12, FontStyle.Bold);
                label6.Text = "Off";
                label6.ForeColor = red;
                label6.Refresh();
            }        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PetFeederForm petFeeder = new PetFeederForm();
            petFeeder.Closed += (s, AssemblyLoadEventArgs) => Close();
            petFeeder.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShoeRackForm shoerack = new ShoeRackForm();
            shoerack.Closed += (s, AssemblyLoadEventArgs) => Close();
            shoerack.Show();
            Hide(); 
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Scheduler scheduler = new Scheduler();            
            scheduler.Closed += (s, AssemblyLoadEventArgs) => Close();
            scheduler.Show();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            btnWasClicked *= -1;
            if (btnWasClicked == -1)
            {
                btn_smart_lamp.BackgroundImage = Properties.Resources.lights_on;
                label6.Font = new Font(label6.Font.Name, 9, FontStyle.Bold);
                label6.Text = "On";
                label6.ForeColor = green;
                label6.Refresh();
            }
            else
            {
                btn_smart_lamp.BackgroundImage = Properties.Resources.lights_off;
                label6.Text = "Off";
                label6.ForeColor = red;
                label6.Refresh();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to log out ?", "Log out", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (confirmResult == DialogResult.OK)
            {
                login login = new login();
                login.Closed += (s, AssemblyLoadEventArgs) => Close();
                login.Show();
                Hide();
            }
            else {
                return;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to log out ?", "Log out", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (confirmResult == DialogResult.OK)
            {
                login login = new login();
                login.Closed += (s, AssemblyLoadEventArgs) => Close();
                login.Show();
                Hide();
            }
            else{
                return;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ShoeRackForm shoerack = new ShoeRackForm();
            shoerack.Closed += (s, AssemblyLoadEventArgs) => Close();
            shoerack.Show();
            Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            PetFeederForm petFeeder = new PetFeederForm();
            petFeeder.Closed += (s, AssemblyLoadEventArgs) => Close();
            petFeeder.Show();
            Hide();
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
            Hide();
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

        private void btn_help_Click(object sender, EventArgs e)
        {
            string path = Directory.GetParent(workingDirectory).Parent.Parent.FullName + @"\HelpFiles\Personal Assistant (User Manual).chm";
            Help.ShowHelp(this, path, HelpNavigator.TopicId, "13");
        }
    }
}
