using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace personal_assistant_ui
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        public void changeToEnglish()
        {
            this.Text = "Smart_Quarantine - Settings";
            label_Title.Text = "SETTINGS";
            label_Theme.Text = "Theme:";
            label_Language.Text = "Language:";
            button_Help.Text = "Help";
            btn_back1.Text = "Back";

            comboBox_Theme.Items.Clear();
            comboBox_Theme.Items.Add("Light"); comboBox_Theme.Items.Add("Dark");
            var lines = File.ReadAllLines("Settings.txt");
            if (lines[1].ToLower().Equals("dark"))
            {
                comboBox_Theme.SelectedIndex = 1;
            }
            else if (lines[1].ToLower().Equals("light"))
            {
                comboBox_Theme.SelectedIndex = 0;
            }

            comboBox_Language.SelectedIndex = 0;
        }
        public void changeToGreek()
        {
            this.Text = "Smart_Quarantine - Ρυθμίσεις";
            label_Title.Text = "ΡΥΘΜΙΣΕΙΣ";
            label_Theme.Text = "Θέμα:";
            label_Language.Text = "Γλώσσα:";
            button_Help.Text = "Βοήθεια";
            btn_back1.Text = "Πίσω";

            comboBox_Theme.Items.Clear();
            comboBox_Theme.Items.Add("Φωτεινό"); comboBox_Theme.Items.Add("Σκοτεινό");
            var lines = File.ReadAllLines("Settings.txt");
            if (lines[1].ToLower().Equals("dark"))
            {
                comboBox_Theme.SelectedIndex = 1;
            }
            else if (lines[1].ToLower().Equals("light"))
            {
                comboBox_Theme.SelectedIndex = 0;
            }

            comboBox_Language.SelectedIndex = 1;
        }

        public void changeToDark()
        {
            label_Theme.ForeColor = Color.White;
            label_Language.ForeColor = Color.White;

            panel_Top.BackColor = Color.FromArgb(30, 30, 30);
            panel_Bottom.BackColor = Color.FromArgb(30, 30, 30);

            comboBox_Theme.BackColor = Color.FromArgb(45, 45, 45);
            comboBox_Language.BackColor = Color.FromArgb(45, 45, 45);

            this.BackColor = Color.FromArgb(18, 18, 18);

            comboBox_Theme.SelectedIndex = 1;
        }

        public void changeToLight()
        {
            label_Theme.ForeColor = Color.Black;
            label_Language.ForeColor = Color.Black;

            panel_Top.BackColor = Color.FromArgb(47, 62, 69);
            panel_Bottom.BackColor = Color.FromArgb(47, 62, 69);

            comboBox_Theme.BackColor = Color.FromArgb(61, 75, 84);
            comboBox_Language.BackColor = Color.FromArgb(61, 75, 84);

            this.BackColor = Color.White;

            comboBox_Theme.SelectedIndex = 0;
        }

        private void pictureBox_Back_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            var MainMenu = new MainMenu();
            MainMenu.Closed += (s, args) => Close();
            MainMenu.Show();
        }

        private void comboBox_Theme_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboBox_Theme.SelectedIndex == 0)
            {
                string text = File.ReadAllText("Settings.txt");
                text = text.Replace("Dark", "Light");
                File.WriteAllText("Settings.txt", text);
                changeToLight();
            }
            else if (comboBox_Theme.SelectedIndex == 1)
            {
                string text = File.ReadAllText("Settings.txt");
                text = text.Replace("Light", "Dark");
                File.WriteAllText("Settings.txt", text);
                changeToDark();
            }
        }

        private void comboBox_Language_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboBox_Language.SelectedIndex == 0)
            {
                string text = File.ReadAllText("Settings.txt");
                text = text.Replace("Greek", "English");
                File.WriteAllText("Settings.txt", text);
                changeToEnglish();
            }
            else if (comboBox_Language.SelectedIndex == 1)
            {
                string text = File.ReadAllText("Settings.txt");
                text = text.Replace("English", "Greek");
                File.WriteAllText("Settings.txt", text);
                changeToGreek();
            }
        }

        private void Settings_Load(object sender, EventArgs e)
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
                changeToGreek();
            }
            else if (lines[0].ToLower().Equals("english"))
            {
                comboBox_Language.SelectedIndex = 0;
            }
            if (lines[1].ToLower().Equals("dark"))
            {
                changeToDark();
            }
            else if (lines[1].ToLower().Equals("light"))
            {
                comboBox_Theme.SelectedIndex = 0;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainMenu mainmenu = new MainMenu();
            mainmenu.Closed += (s, AssemblyLoadEventArgs) => Close();
            mainmenu.Show();
            Hide();
        }

        private void btn_back1_Click(object sender, EventArgs e)
        {
            MainMenu mainmenu = new MainMenu();
            mainmenu.Closed += (s, AssemblyLoadEventArgs) => Close();
            mainmenu.Show();
            Hide();
        }
    }
}
