using System;
using System.IO;
using System.Windows.Forms;
using System.Speech.Synthesis;
namespace personal_assistant_ui
{
    public partial class login : Form
    {
        SpeechSynthesizer speak;
        public login()
        {
            InitializeComponent();
            speak = new SpeechSynthesizer();
        }

        private void button1_Click(object sender, EventArgs e)
        { }
        private void button2_Click(object sender, EventArgs e)
        {
            signup signup = new signup();
            signup.Closed += (s, AssemblyLoadEventArgs) => this.Close();
            signup.Show();
            this.Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string text = "Welcome to the personal assistant application";
            speak.SpeakAsync(text);

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Welcome back " + tb_username.Text + "!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainMenu mainmenu = new MainMenu();
                mainmenu.Closed += (s, AssemblyLoadEventArgs) => Close();
                mainmenu.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void tb_password_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_password.Text))
            {
                e.Cancel = true;
                loginErrorProvider.SetIconPadding(tb_password, 5);
                loginErrorProvider.SetError(tb_password, "Oops Error! Please enter a password.");
            }
            else if (tb_password.Text != "admin")
            {
                e.Cancel = true;
                loginErrorProvider.SetIconPadding(tb_password, 5);
                loginErrorProvider.SetError(tb_password, "Oops Error! You didn't enter a valid password.\nPlease try again.");
            }
            else
            {
                e.Cancel = false;
                loginErrorProvider.SetError(tb_password, null);
            }
        }

        private void tb_username_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_username.Text))
            {
                e.Cancel = true;
                loginErrorProvider.SetIconPadding(tb_username, 5);
                loginErrorProvider.SetError(tb_username, "Oops Error! Please enter a username.");
            }
            else if (tb_username.Text != "admin")
            {
                e.Cancel = true;
                loginErrorProvider.SetIconPadding(tb_username, 5);
                loginErrorProvider.SetError(tb_username, "Oops Error! You didn't enter a valid username.\nPlease try again.");
            }
            else
            {
                e.Cancel = false;
                loginErrorProvider.SetError(tb_username, null);
            }
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Scheduler sch = new Scheduler();
            this.Hide();
            sch.Show();
        }
        private void label5_Click(object sender, EventArgs e)
        {
        }
    }
}