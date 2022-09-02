namespace personal_assistant_ui
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            signup signup = new signup();
            signup.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            MainMenu mainmenu = new MainMenu();
            mainmenu.Closed += (s, AssemblyLoadEventArgs) => this.Close(); //When exited from the MainMenu form the program closed too.
            mainmenu.Show();
            this.Hide(); //the Hide method putted at the bottom to hide smoothly the loginForm

        }
    }
}