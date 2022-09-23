using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace personal_assistant_ui
{
    public partial class signup : Form
    {
        SpeechSynthesizer speak;
        public signup()
        {
            InitializeComponent();
            speak = new SpeechSynthesizer();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "Welcome to the personal assistant application";
            speak.SpeakAsync(text);

            MainMenu mainmenu = new MainMenu();
            mainmenu.Closed += (s, AssemblyLoadEventArgs) => Close();
            mainmenu.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void signup_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Closed += (s, AssemblyLoadEventArgs) => this.Close();
            login.Show();
            this.Hide();
        }

        private void btn_back1_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Closed += (s, AssemblyLoadEventArgs) => this.Close();
            login.Show();
            this.Hide();
        }
    }
}
