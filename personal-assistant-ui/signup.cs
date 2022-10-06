using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter a password between 8 - 14 characters.\nYou have to use at least one special character such as: !@#$%^&*().", "Enter a password", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter a username with a maximum of 15 characters.", "Enter a username", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void signup_Load(object sender, EventArgs e)
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
            if (lines[1].ToLower().Equals("dark"))
            {
                changeToDark();
            }
        }

        public void changeToGreek()
        {
            
        }

        public void changeToDark()
        {
            BackColor = Color.DarkSlateGray;
        }

        private void tb_username_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_username.Text))
            {
                e.Cancel = true;
                signupErrorProvider.SetIconPadding(tb_username, 5);
                signupErrorProvider.SetError(tb_full_name, "Oops Error! Please enter your full name.");
            } else {
                e.Cancel = false;
                signupErrorProvider.SetError(tb_username, null);
            }
        }

        private void tb_full_name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_full_name.Text))
            {
                e.Cancel = true;
                signupErrorProvider.SetIconPadding(tb_username, 5);
                signupErrorProvider.SetError(tb_full_name, "Oops Error! Please enter your full name.");
            } else {
                e.Cancel = false;
                signupErrorProvider.SetError(tb_username, null);
            }
        }

        private void tb_email_Validating(object sender, CancelEventArgs e)
        {

        }

        private void tb_password_Validating(object sender, CancelEventArgs e)
        {

        }

        private void tb_password_confirm_Validating(object sender, CancelEventArgs e)
        {
            
        }
    }
}
