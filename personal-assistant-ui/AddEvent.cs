using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPF_ClockPicker;
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
            dateTimePicker1.CustomFormat = "MM-dd-yyyy";
            
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Scheduler sch = new Scheduler();
            SetValueForTitle = titleBox.Text;

            Label taskLabel = new Label();

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
            sw.WriteLine("Title: " + titleBox.Text);

            //sch.showDayTasks();
            //taskLabel.Text = "Task " + cnt;
            taskLabel.Text = dateTimePicker1.Value.ToString("MM-dd-yyyy");
            taskLabel.Location = new Point(200, positionY);
            positionY += 100;
            sch.Controls.Add(taskLabel);
            
            
            //sch.Show();
            this.Hide();
            
            





        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.SelectedValue = "AM";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddEvent_Load(object sender, EventArgs e)
        {

        }
    }
}
