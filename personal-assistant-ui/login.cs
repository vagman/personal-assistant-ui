using System;
using System.IO;
using System.Windows.Forms;
using System.Speech.Synthesis;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        public void changeToGreek()
        {
            lbl_username.Text = "Όνομα χρήστη";
            lbl_username.Location = new Point(lbl_username.Location.X - 10, lbl_username.Location.Y);
            lbl_password.Text = "Κωδικός πρόσβασης";
            lbl_password.Location = new Point(lbl_password.Location.X - 35, lbl_password.Location.Y);
            lbl_new_user.Text = "Νέος χρήστης ; Πατήστε";
            lbl_new_user.Location = new Point(lbl_new_user.Location.X - 25, lbl_new_user.Location.Y);
            lbl_need_help.Text = "Χρειάζεστε βοήθεια ;";
            lbl_need_help.Location = new Point(lbl_need_help.Location.X - 70, lbl_need_help.Location.Y);
            btn_login.Text = "Είσοδος";
            btn_signup.Text = "Εδώ";
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
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string text = "Welcome to the smart personal assistant application";
                speak.SpeakAsync(text);
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

        public void changeToDark()
        {
            BackColor = Color.DarkSlateGray;
            btn_help.BackColor = Color.White;
            btn_login.ForeColor = Color.White;
            btn_signup.ForeColor = Color.White;
            lbl_username.ForeColor = Color.White;
            lbl_password.ForeColor = Color.White;
            lbl_need_help.ForeColor = Color.White;
            lbl_new_user.ForeColor = Color.White;
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