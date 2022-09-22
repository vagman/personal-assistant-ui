using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace personal_assistant_ui
{
    public partial class AddEvent : Form
    {
        public static string SetValueForTitle = "";
        public static string SetValueForType = "";
        
        public static int cnt = 0;
        public static int positionX = 100;
        public static int positionY = 100;
        // Get the path of current project
        public static string workingDirectory = Environment.CurrentDirectory;
        public static string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        //Label[] taskLabel = new Label[100];

        public AddEvent()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Scheduler sch = new Scheduler();
            SetValueForTitle = titleBox.Text;

            cnt++; //To change task number: Task[cnt] (Task1, Task2, ...)


            string dir = projectDirectory + @"\Tasks\" + dateTimePicker1.Value.ToString("dd-MM-yyyy");
            if(!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            // Create .txt file for the given date with all other details
            //string path = projectDirectory + @"\Tasks\" + dateTimePicker1.Value.ToString("MM-dd-yyyy") + ".txt";
            string path = dir + @"\" + titleBox.Text + ".txt";
            if (File.Exists(path))
            {
                //TODO verification for deletation
                File.Delete(path);
            }
            using (StreamWriter sw = File.CreateText(path))
            sw.WriteLine("Title: " + titleBox.Text + "\n" + 
                "Date: " + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "\n" +
                "Time: " + hoursCB.Text + ":" + minCB.Text + " " + periodCB.Text + "\n" +
                "Type of task: ");


            
            
            //sch.Show();
            this.Hide();
            sch.refreshList();







        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TODO close the window with the cancel button
            //TODO check if any text box is not empty show message "Are you sure to cancel?"
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            periodCB.SelectedValue = "AM";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddEvent_Load(object sender, EventArgs e)
        {

        }

        private void btn_back1_Click(object sender, EventArgs e)
        {
            Scheduler scheduler = new Scheduler();
            scheduler.Closed += (s, AssemblyLoadEventArgs) => this.Close();
            scheduler.Show();
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Scheduler scheduler = new Scheduler();
            scheduler.Closed += (s, AssemblyLoadEventArgs) => this.Close();
            scheduler.Show();
            this.Hide();
        }
    }
}
