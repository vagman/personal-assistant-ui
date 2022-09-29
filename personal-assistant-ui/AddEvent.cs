//TODO: on 'Back' close AddEvent form and open a single form of scheduler
//TODO: make the cancel button works

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

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
        

        public AddEvent()
        {
            InitializeComponent();
            this.dateTimePicker1.Value = DateTime.Now;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        /*Submit Button*/
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
            using (StreamWriter sw = File.CreateText(path)) { 
                sw.WriteLine(titleBox.Text);
                sw.WriteLine(dateTimePicker1.Value.ToString("dd-MM-yyyy"));
                sw.WriteLine(hoursCB.Text);
                sw.WriteLine(minCB.Text);
                sw.WriteLine(periodCB.Text);
                sw.WriteLine(comboBox1.Text);
                sw.WriteLine(suggestionBox.Text);
                sw.WriteLine(distanceInKm.Text);
                sw.WriteLine(durationInMin.Text);
                sw.WriteLine(needCoffee.Checked.ToString());
                

            }

            
            sch.refreshList();
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
            Size = new Size(300, 326);
            FormBorderStyle = FormBorderStyle.FixedSingle; //dont allow the user to change size of the window form
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get user's choice from comboBox (Type of task)
            object curItem = comboBox1.SelectedItem;
            object curItemText = comboBox1.GetItemText(curItem);

            int index = comboBox1.FindString(comboBox1.Text);
            comboBox1.SelectedIndex = index;

            mapImage.Visible = false;
            needCoffee.Visible = false;
            distanceLbl.Visible = false;
            distanceInKm.Visible = false;
            durationInMin.Visible = false;
            durationLbl.Visible = false;
            switch (index)
            {
                case 0:
                    MessageBox.Show("First option");
                    Size = new Size(600, 326); //Grow size of window if the user select first option of the combobox
                                               //the new location will be 449,233
                    if (button1.Location != new Point(449, 233))
                    {
                        button1.Location = new Point(button1.Location.X + 300, button1.Location.Y); // move submit button
                        button2.Location = new Point(button2.Location.X + 300, button2.Location.Y); // move cancel button
                    }

                    suggestionBox.Items.Clear();
                    suggestionBox.ResetText(); //Clear text from the suggestion box (if the user selected destination first and selected an item from there)
                    suggestionBox.SelectedIndex = -1;
                    suggestionBox.Items.Add("Ηλεκτρικός");
                    suggestionBox.Items.Add("Λεωφορείο");
                    suggestionBox.Items.Add("Αυτοκίνητο");
                    suggestionBox.Items.Add("Ποδήλατο");
                    suggestionBox.Items.Add("Πόδια");
                    suggestionBox.Items.Add("Συνδιασμός");

                    suggestionBox.Visible = true;
                    destinationSuggText.Visible = true;
                    destinationSuggText.Text = "How do you want to get to the destination?";
                    break;
                case 1:
                    Size = new Size(600, 326);
                    MessageBox.Show("Second option");
                    if (button1.Location != new Point(449, 233))
                    {
                        button1.Location = new Point(button1.Location.X + 300, button1.Location.Y); // move submit button
                        button2.Location = new Point(button2.Location.X + 300, button2.Location.Y); // move cancel button
                    }

                    suggestionBox.Items.Clear();
                    suggestionBox.ResetText(); //Clear text from the suggestion box (if the user selected destination first and selected an item from there)
                    suggestionBox.SelectedIndex = -1;
                    suggestionBox.Items.Add("Smart Lamp");
                    suggestionBox.Items.Add("Shoe rack");
                    suggestionBox.Items.Add("Pet feeder");

                    destinationSuggText.Text = "What automation you want to set?";
                    destinationSuggText.Visible = true;
                    suggestionBox.Visible = true;
                    
                    break;
                
            }
        }

        private void suggestionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            object currentSuggestion = suggestionBox.SelectedItem;
            object currentSuggestionText = suggestionBox.GetItemText(currentSuggestion);

            int indexSuggestion = suggestionBox.FindString(suggestionBox.Text);
            suggestionBox.SelectedIndex = indexSuggestion;


            switch(indexSuggestion)
            {
                case 0:
                    Random rnd = new Random();
                    float kilometers = 0f;
                    float minutes = 0f;

                    if (suggestionBox.Text == "Smart Lamp")
                    {
                        MessageBox.Show("SMART LAMP");
                    }
                    else
                    {
                        MessageBox.Show("ilektrikos");
                        distanceLbl.Visible = true;
                        Size = new Size(791, 326);
                        if (button1.Location != new Point(640, 233)) //if the location of one of the two buttons is 640,233 then dont change any button location
                        {
                            button1.Location = new Point(button1.Location.X + 191, button1.Location.Y); // move submit button
                            button2.Location = new Point(button2.Location.X + 191, button2.Location.Y); // move cancel button
                        }

                        //Generate a random distance (double number)

                        rnd = new Random();
                        kilometers = (float)(rnd.NextDouble() * 5);
                        distanceInKm.Text = kilometers.ToString("0.0") + " Km";
                        distanceInKm.Visible = true;
                        distanceLbl.Visible = true;

                        //Generate a random duration (double number)

                        minutes = (float)(rnd.NextDouble() * 100);
                        durationInMin.Text = minutes.ToString("0.0") + " Min";
                        durationLbl.Visible = true;
                        durationInMin.Visible = true;
                        needCoffee.Visible = true;
                    }
                    
                    break;


                case 1:
                    if (suggestionBox.Text == "Shoe rack")
                    {
                        MessageBox.Show("SMART shoe");
                    }
                    else
                    {
                        MessageBox.Show("ilektrikos");
                        distanceLbl.Visible = true;
                        Size = new Size(791, 326);
                        if (button1.Location != new Point(640, 233)) //if the location of one of the two buttons is 640,233 then dont change any button location
                        {
                            button1.Location = new Point(button1.Location.X + 191, button1.Location.Y); // move submit button
                            button2.Location = new Point(button2.Location.X + 191, button2.Location.Y); // move cancel button
                        }

                        //Generate a random distance (double number)

                        rnd = new Random();
                        kilometers = (float)(rnd.NextDouble() * 5);
                        distanceInKm.Text = kilometers.ToString("0.0") + " Km";
                        distanceInKm.Visible = true;
                        distanceLbl.Visible = true;

                        //Generate a random duration (double number)

                        minutes = (float)(rnd.NextDouble() * 100);
                        durationInMin.Text = minutes.ToString("0.0") + " Min";
                        durationLbl.Visible = true;
                        durationInMin.Visible = true;
                        
                        needCoffee.Visible = true;
                    }
                    break;
                case 2:
                    if (suggestionBox.Text == "Pet feeder")
                    {
                        MessageBox.Show("SMART feeder");
                    }
                    else
                    {
                        MessageBox.Show("ilektrikos");
                        distanceLbl.Visible = true;
                        Size = new Size(791, 326);
                        if (button1.Location != new Point(640, 233)) //if the location of one of the two buttons is 640,233 then dont change any button location
                        {
                            button1.Location = new Point(button1.Location.X + 191, button1.Location.Y); // move submit button
                            button2.Location = new Point(button2.Location.X + 191, button2.Location.Y); // move cancel button
                        }
                        mapImage.Image = (Image)Properties.Resources.ResourceManager.GetObject("car");
                        mapImage.Visible = true;
                        mapImage.BackgroundImageLayout = ImageLayout.Stretch;
                        //Generate a random distance (double number)

                        rnd = new Random();
                        kilometers = (float)(rnd.NextDouble() * 5);
                        distanceInKm.Text = kilometers.ToString("0.0") + " Km";
                        distanceInKm.Visible = true;
                        distanceLbl.Visible = true;

                        //Generate a random duration (double number)

                        minutes = (float)(rnd.NextDouble() * 100);
                        durationInMin.Text = minutes.ToString("0.0") + " Min";
                        durationLbl.Visible = true;
                        durationInMin.Visible = true;

                        needCoffee.Visible = true;
                    }
                    break;
                case 3:
                    Size = new Size(791, 326);
                    if (button1.Location != new Point(640, 233))
                    {
                        button1.Location = new Point(button1.Location.X + 191, button1.Location.Y); // move submit button
                        button2.Location = new Point(button2.Location.X + 191, button2.Location.Y); // move cancel button
                    }
                    needCoffee.Visible = true;
                    //Generate a random distance (double number)

                    rnd = new Random();
                    kilometers = (float)(rnd.NextDouble() * 5);
                    distanceInKm.Text = kilometers.ToString("0.0") + " Km";
                    distanceInKm.Visible = true;
                    distanceLbl.Visible = true;

                    //Generate a random duration (double number)

                    minutes = (float)(rnd.NextDouble() * 100);
                    durationInMin.Text = minutes.ToString("0.0") + " Min";
                    durationLbl.Visible = true;
                    durationInMin.Visible = true;

                    break;
                case 4:
                    Size = new Size(791, 326);
                    if (button1.Location != new Point(640, 233))
                    {
                        button1.Location = new Point(button1.Location.X + 191, button1.Location.Y); // move submit button
                        button2.Location = new Point(button2.Location.X + 191, button2.Location.Y); // move cancel button
                    }
                    needCoffee.Visible = true;

                    //Generate a random distance (double number)

                    rnd = new Random();
                    kilometers = (float)(rnd.NextDouble() * 5);
                    distanceInKm.Text = kilometers.ToString("0.0") + " Km";
                    distanceInKm.Visible = true;
                    distanceLbl.Visible = true;

                    //Generate a random duration (double number)

                    minutes = (float)(rnd.NextDouble() * 100);
                    durationInMin.Text = minutes.ToString("0.0") + " Min";
                    durationLbl.Visible = true;
                    durationInMin.Visible = true;
                    break;
                case 5:
                    Size = new Size(791, 326);
                    if (button1.Location != new Point(640, 233))
                    {
                        button1.Location = new Point(button1.Location.X + 191, button1.Location.Y); // move submit button
                        button2.Location = new Point(button2.Location.X + 191, button2.Location.Y); // move cancel button
                    }
                    needCoffee.Visible = true;
                    //Generate a random distance (double number)

                    rnd = new Random();
                    kilometers = (float)(rnd.NextDouble() * 5);
                    distanceInKm.Text = kilometers.ToString("0.0") + " Km";
                    distanceInKm.Visible = true;
                    distanceLbl.Visible = true;

                    //Generate a random duration (double number)

                    minutes = (float)(rnd.NextDouble() * 100);
                    durationInMin.Text = minutes.ToString("0.0") + " Min";
                    durationLbl.Visible = true;
                    durationInMin.Visible = true;

                    break;
            }
            
        }

        private void readyToPickDestinations_SelectedIndexChanged(object sender, EventArgs e)
        {
            object curItem = readyToPickDestinations.SelectedItem;
            object curItemText = readyToPickDestinations.GetItemText(curItem);

            int index = readyToPickDestinations.FindString(readyToPickDestinations.Text);
            readyToPickDestinations.SelectedIndex = index;

            switch(index) {
                case 0:
                    titleBox.Text = "University";
                    break;
                case 1:
                    titleBox.Text = "Home";
                    break;
                case 2:
                    titleBox.Text = "Coffee Shop";
                    break;
                case 3:
                    titleBox.Text = "Gym";
                    break;
            }
        }

        private void needCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (needCoffee.Checked)
            {
                mapImage.Image = (Image)Properties.Resources.ResourceManager.GetObject("carCoffee");
            }
            else
            {
                mapImage.Image = (Image)Properties.Resources.ResourceManager.GetObject("car");
            }
        }
    }
}
