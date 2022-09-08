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
            tstLabel.Text = AddEvent.SetValueForTitle;
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
           




        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddEvent addEventFrm = new AddEvent();
            addEventFrm.ShowDialog();
            //this.Close();
            
        }

        private void tstLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

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

            //Create textBox for the gbox
            TextBox titleTaskBox = new TextBox();
            titleTaskBox.Location = new Point(90, 35);
            titleTaskBox.Text = listBox1.SelectedItem.ToString();
            titleTaskBox.Enabled = false;
            // Add textbox to the gbox
            gbox.Controls.Add(titleTaskBox);


            // Create button for the gbox
            Button editBtn = new Button();
            editBtn.Location = new Point(200, 40);
            editBtn.Text = "Edit";
            // Add button to the gbox
            gbox.Controls.Add(editBtn);


            // MAKE THE EDIT BUTTON FUNCTION AFTER THIRD TIME CLICKED
            editBtn.Click += (sender, args) =>
            {
                titleTaskBox.Enabled = true;
                editBtn.Text = "Submit";

                editBtn.Click += (sender, args) =>
                {
                    titleTaskBox.Enabled = false;
                    editBtn.Text = "Edit";
                };
            };
            

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            string sourceDir = projectDirectory + @"\Tasks\" + dateTimePicker1.Value.ToString("dd-MM-yyyy");
            string[] txtFiles = Directory.GetFiles(sourceDir).Select(file => Path.GetFileNameWithoutExtension(file)).ToArray();
            listBox1.Items.AddRange(txtFiles);

        }
    }
}
