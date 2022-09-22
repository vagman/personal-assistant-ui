// TODOS:
// 1) on submit from AddEvent form refresh the current listbox (on specific date)
// 2) fix edit button on third time clicked.
// 3) fix edit button to edit name of the .txt file and its content



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
using System.IO;
using System.Drawing.Printing;

namespace personal_assistant_ui
{
    public partial class Scheduler : Form
    {
        public static string workingDirectory = Environment.CurrentDirectory;
        public static string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;





        public Scheduler()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            showDayTasks();
        }

        public bool IsDirectoryEmpty(string path)
        {
            try
            {
                return !Directory.EnumerateFileSystemEntries(path).Any();
            }
            catch
            {
                return false;
            }

        }
        public void showDayTasks()
        {

            string sourceDir = projectDirectory + @"\Tasks\" + dateTimePicker1.Value.ToString("dd-MM-yyyy");
            if (IsDirectoryEmpty(sourceDir))
            {
                string message = "There is no task that day!";
                string title = "Error";
                MessageBox.Show(message, title);
            }
            else
            {
                if (Directory.Exists(sourceDir))
                {
                    listBox1.Items.Clear();
                    string[] txtFiles = Directory.GetFiles(sourceDir).Select(file => Path.GetFileNameWithoutExtension(file)).ToArray();
                    listBox1.Items.AddRange(txtFiles);
                }
                else
                {
                    string message = "Never created task for that day";
                    string title = "Error";
                    MessageBox.Show(message, title);
                }
                try
                {

                }
                catch
                {


                    // show message if there is no task 
                    //string message = "There is no task that day! Click on the help icon to learn more";
                    //string title = "Error";
                    //MessageBox.Show(message, title);
                }
            }



        }
        private void Scheduler_Load(object sender, EventArgs e)
        {
            // Show on form load, all the existed tasks
            listBox1.Items.Clear();
            string sourceDir = projectDirectory + @"\Tasks\" + dateTimePicker1.Value.ToString("dd-MM-yyyy");
            string[] txtFiles = Directory.GetFiles(sourceDir).Select(file => Path.GetFileNameWithoutExtension(file)).ToArray();
            listBox1.Items.AddRange(txtFiles);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddEvent addEventFrm = new AddEvent();
            addEventFrm.ShowDialog();
            //this.Close();

        }


        private void gbox_Enter(object sender, EventArgs e)
        {



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Show trash bin icon when item selected from the listbox
            if (listBox1.SelectedIndex != -1)
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
                button1.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listBox1);
            selectedItems = listBox1.SelectedItems;

            string fileToDelete = listBox1.SelectedItem.ToString() + ".txt";
            string sourceFolder = projectDirectory + @"\Tasks\" + dateTimePicker1.Value.ToString("dd-MM-yyyy");


            if (listBox1.SelectedIndex != -1)
            {
                //TODO VERIFICATION FOR DELETATION
                MessageBox.Show("Are you sure do you want to delete: " + listBox1.SelectedItem.ToString());


                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    listBox1.Items.Remove(selectedItems[i]);
                File.Delete(Path.Combine(sourceFolder, fileToDelete));

            }
            else
                MessageBox.Show("error");
        }

        private void showTaskBtn_Click(object sender, EventArgs e)
        {
            string sourceFolder = projectDirectory + @"\Tasks\" + dateTimePicker1.Value.ToString("dd-MM-yyyy");
            string fileToRead = sourceFolder + @"\" + listBox1.SelectedItem.ToString() + ".txt";

            string text = File.ReadAllText(fileToRead);




            // GroupBox

            gbox.Text = "Task: " + listBox1.SelectedItem.ToString() + " / " + "(" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + ")";
            gbox.Name = "My Task";
            gbox.Visible = true;
            gbox.AutoSize = true;
            gbox.AutoSizeMode = AutoSizeMode.GrowAndShrink;


            // OnClick "Show" button enable these tools:
            label2.Visible = true;

            nameOfTask.Text = listBox1.SelectedItem.ToString();
            
            nameOfTask.Visible = true;
            nameOfTask.Enabled = false;

            dateLabel.Visible = true;

            dateTimePickerSch.Visible = true;
            dateTimePickerSch.Enabled = false;

            timeLabel.Visible = true;

            hoursCB.Visible = true;
            hoursCB.Enabled = false;

            minCB.Visible = true;
            minCB.Enabled = false;

            periodCB.Visible = true;
            periodCB.Enabled = false;

            typeLabel.Visible = true;

            typeBox.Visible = true;
            typeBox.Enabled = false;





            // Display my task edit button
            taskEditBtn.Visible = true;

        }



        /* METHOD TO REFRESH LISTBOX */
        public void refreshList()
        {
            listBox1.Items.Clear();
            string sourceDir = projectDirectory + @"\Tasks\" + dateTimePicker1.Value.ToString("dd-MM-yyyy");
            string[] txtFiles = Directory.GetFiles(sourceDir).Select(file => Path.GetFileNameWithoutExtension(file)).ToArray();
            listBox1.Items.AddRange(txtFiles);
        }
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            refreshList();
        }


        /* TASK EDIT BUTTON */
        int editBtnWasClicked = 1;
        
        private void taskEditBtn_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listBox1);
            selectedItems = listBox1.SelectedItems;

            string sourceFolder = projectDirectory + @"\Tasks\" + dateTimePicker1.Value.ToString("dd-MM-yyyy");

            string fileToRename = sourceFolder + @"\" + listBox1.SelectedItem.ToString() + ".txt";
            string newFilePath = sourceFolder + @"\";

            string nameOfTaskText = nameOfTask.Text;


            editBtnWasClicked *= -1;
            
            if (editBtnWasClicked == -1)
            {
                //TODO if the button clicked twice, the third time it will give an error. 
                taskEditBtn.Text = "Submit";
                taskEditBtn.BackColor = Color.LawnGreen;
                nameOfTask.Enabled = true;
                dateTimePickerSch.Enabled = true;
                hoursCB.Enabled = true;
                minCB.Enabled = true;
                periodCB.Enabled = true;
                typeBox.Enabled = true;
                cancelBtn.Visible = true; // Cancel Button be visible after EditButton clicked.
                
            }
            else
            {
                File.Move(fileToRename, (newFilePath + nameOfTask.Text + ".txt"));
                MessageBox.Show("File renamed.");
                refreshList();
        
                
                //TODO change the title of the gbox after the rename
                //gbox.Text = listBox1.SelectedItem.ToString();
                taskEditBtn.Text = "Edit";
                nameOfTask.Enabled = false;
            }

            using (StreamWriter sw = File.CreateText(sourceFolder + @"\" + listBox1.SelectedItem.ToString() + ".txt"))
            sw.WriteLine("Title: " + nameOfTask.Text + "\n" +
                "Date: " + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "\n" +
                "Time: " + hoursCB.Text + ":" + minCB.Text + " " + periodCB.Text + "\n" +
                "Type of task: ");
        }

        private void nameOfTask_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            refreshList();
            gbox.Visible = false;
            
            // Turn edit button like the time before clicked.
            editBtnWasClicked = 1;
            taskEditBtn.Text = "Edit";
            taskEditBtn.BackColor = Color.White;
            cancelBtn.Visible = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Closed += (s, AssemblyLoadEventArgs) => this.Close();
            mainMenu.Show();
            this.Hide();
        }

        private void btn_back1_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Closed += (s, AssemblyLoadEventArgs) => this.Close();
            mainMenu.Show();
            this.Hide();
        }
    }
}
