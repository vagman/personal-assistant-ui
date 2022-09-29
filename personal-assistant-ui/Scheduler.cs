// TODOS:
// 1) on submit from AddEvent form refresh the current listbox (on specific date)
// 2) fix edit button on third time clicked.
// 3) fix edit button to edit name of the .txt file and its content
// 4) change pick a date (dateTimePicker1) to current day, and create that folder to the Tasks's folder on app first run
// 5) after dateTime changed


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
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.LinkLabel;

namespace personal_assistant_ui
{
    public partial class Scheduler : Form
    {
        public static string workingDirectory = Environment.CurrentDirectory;
        public static string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;






        public Scheduler()
        {
            InitializeComponent();

            this.dateTimePicker1.Value = DateTime.Now; //Give dateTimePicker1 today's value of date
            string todaysTaskFolder = projectDirectory + @"\Tasks\" + dateTimePicker1.Value.ToString("dd-MM-yyyy");
            if (!Directory.Exists(todaysTaskFolder)) //If todaysTaskFolder doesnt exist then create it
            {
                Directory.CreateDirectory(todaysTaskFolder);
            }
            
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
            //MUST EXIST A FOLDER WITH DATE'S NAME IN TASK'S FOLDER
            string[] txtFiles = Directory.GetFiles(sourceDir).Select(file => Path.GetFileNameWithoutExtension(file)).ToArray();   //folder named from dateTimePicker1's value is required for the app to run
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
                showTaskBtn.Visible = true;
            }
            else
            {
                button1.Visible = false;
                showTaskBtn.Visible = false;
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
                gbox.Visible = false; //Hide the groupbox after deletation
                refreshList(); //Refresh task list after the delete
                showTaskBtn.Text = "Show Details";
            }
            else
                MessageBox.Show("error");
        }

        int isShowBtnClicked = 1;
        private void showTaskBtn_Click(object sender, EventArgs e)
        {
            
            isShowBtnClicked *= -1;

            if(isShowBtnClicked == -1)
            {
                showTaskBtn.Text = "Hide Details"; // When the 'Show Details Button' is clicked it renamed to 'Hide Details'
                string sourceFolder = projectDirectory + @"\Tasks\" + dateTimePicker1.Value.ToString("dd-MM-yyyy");
                //string newSourceFolder = projectDirectory + @"\Tasks\" + dateTimePickerSch.Value.ToString("dd-MM-yyyy"); //the path takes the value from dateTimePickerSch not from dateTimePicker1

                string fileToRead = sourceFolder + @"\" + listBox1.SelectedItem.ToString() + ".txt";
                string text = File.ReadAllText(fileToRead);


                /* READ FROM TASK.TXT FILE AND PASS THE VALUES FROM LINES TO TOOLS ON SCHEDULER*/

                //Create array to store each line's value to an index
                string[] lines = File.ReadAllLines(fileToRead);
                //First line of .txt file is for Title of task

                //Second line of .txt file is for Datetime
                string date = lines[1];
                //Pass value from second line (from .txt) to dateTimePickerSch
                dateTimePickerSch.Value = DateTime.ParseExact(date, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                //MessageBox.Show(dateTimePickerSch.Value.ToString("dd-MM-yyyy"));

                //Third line of .txt file is for Hours
                hoursCB.Text = lines[2];
                //Fourth line of .txt file is for Minutes
                minCB.Text = lines[3];
                //Fifth line of .txt file is for Period of time
                periodCB.Text = lines[4];

                //Sixth line of .txt file is for Type of task
                typeBox.Text = lines[5];

                //Seventh line is for 
                suggestionBox.Text = lines[6];

                //8th line
                distanceInKm.Text = lines[7];

                //9th
                durationInMin.Text = lines[8];

                //10th
                
                needCoffee.Checked = Convert.ToBoolean(lines[9]);



                // GroupBox

                gbox.Text = "Task: " + listBox1.SelectedItem.ToString() + " / " + "(" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + ")";
                gbox.Name = "My Task";
                gbox.Visible = true;
                gbox.AutoSize = false;



                /* OnClick "Show" button enable these tools: */

                //Title of task
                label2.Visible = true;
                //TextBox of task
                nameOfTask.Text = listBox1.SelectedItem.ToString();
                nameOfTask.Visible = true;
                nameOfTask.Enabled = false;

                //Date of task
                dateLabel.Visible = true;
                dateTimePickerSch.Visible = true;
                dateTimePickerSch.Enabled = false;

                //Time of task
                timeLabel.Visible = true;
                //Hours
                hoursCB.Visible = true;
                hoursCB.Enabled = false;
                //Minutes
                minCB.Visible = true;
                minCB.Enabled = false;
                //Period
                periodCB.Visible = true;
                periodCB.Enabled = false;

                //Type of task
                typeLabel.Visible = true;
                typeBox.Visible = true;
                typeBox.Enabled = false;

                //
                suggestionBox.Visible = true;
                suggestionBox.Enabled = false;
                destinationSuggText.Visible = true;
                //
                distanceLbl.Visible = true;
                distanceInKm.Visible = true;
                distanceInKm.Enabled = false;

                //
                durationInMin.Visible = true;
                durationInMin.Enabled = false;
                durationLbl.Visible = true;

                //
                needCoffee.Visible = true;
                needCoffee.Enabled = false;


                // Display my task edit button
                taskEditBtn.Visible = true;
            }
            else
            {
                showTaskBtn.Text = "Show Details";

                refreshList();
                gbox.Visible = false;

                // Turn edit button like the time before clicked.
                editBtnWasClicked = 1;
                taskEditBtn.Text = "Edit";
                taskEditBtn.BackColor = Color.White;
                cancelBtn.Visible = false;
            }

            

        }



        /* METHOD TO REFRESH LISTBOX */
        public void refreshList()
        {
            listBox1.Items.Clear();
            string sourceDir = projectDirectory + @"\Tasks\" + dateTimePicker1.Value.ToString("dd-MM-yyyy");
            string[] txtFiles = Directory.GetFiles(sourceDir).Select(file => Path.GetFileNameWithoutExtension(file)).ToArray();
            listBox1.Items.AddRange(txtFiles);
        }
        // Refresh Button
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

            string sourceFolder = projectDirectory + @"\Tasks\" + dateTimePicker1.Value.ToString("dd-MM-yyyy"); //Source folder before any change
            string newSourceFolder = projectDirectory + @"\Tasks\" + dateTimePickerSch.Value.ToString("dd-MM-yyyy"); //Take the value of dateTimePickerSch instead of dateTimePicker1

            string fileToRename = sourceFolder + @"\" + listBox1.SelectedItem.ToString() + ".txt"; //Old(current) file path
            string newFile = newSourceFolder + @"\" + listBox1.SelectedItem.ToString() + ".txt"; //New file path, if dateTimePickerSch changed and not equals to dateTimePicker1 value

            string newFilePath = newSourceFolder + @"\"; //takes the new datetime from dateTimePickerSch 

            string nameOfTaskText = nameOfTask.Text;


            editBtnWasClicked *= -1;
            
            if (editBtnWasClicked == -1) //Edit button renamed to 'Submit' after clicked
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

                suggestionBox.Enabled = true;
                needCoffee.Enabled = true;
                cancelBtn.Visible = true; // Cancel Button be visible after EditButton clicked.

                hideBtn.Visible = false; //When 'Edit' button clicked the clearBtn dissappear and the work of this button goes to 'Cancel' Button


            }
            else
            {
                //Read all lines from .txt file of the task
                string[] lines = File.ReadAllLines(fileToRename);


                //Change title,datetime,hours,min,period,type if changed
                
                lines[2] = hoursCB.Text; //Hours
                lines[3] = minCB.Text; //Minutes
                lines[4] = periodCB.Text; //Period
                lines[5] = typeBox.Text; //Type of task
                lines[6] = suggestionBox.Text;
                lines[9] = needCoffee.Checked.ToString();
                File.WriteAllLines(fileToRename, lines); //Write the changes

                //If the user change datetime:
                if (lines[1] != dateTimePickerSch.Value.ToString("dd-MM-yyyy")) //If dateTimePicker1 != dateTimePickerSch
                {

                    //Create folder with name the datetime user typed
                    if (!Directory.Exists(newSourceFolder)) //if the path "projectDirectory...("dd-MM-yyyy"))) doesnt exist then:
                    {
                        //Change datetime
                        
                        lines[1] = dateTimePickerSch.Value.ToString("dd-MM-yyyy"); //Date
                        
                        MessageBox.Show(dateTimePickerSch.Value.ToString("dd-MM-yyyy"));
                        File.WriteAllLines(fileToRename, lines); //Write the changes
                        Directory.CreateDirectory(newSourceFolder);

                        //Move file after the changes to the new folder
                        File.Move(fileToRename, (newFilePath + nameOfTask.Text + ".txt"));
                        gbox.Visible = false;
                        showTaskBtn.Text = "Show Details";
                        showTaskBtn.Visible = false;

                    }
                    else
                    {
                        //Change datetime
                        
                        lines[1] = dateTimePickerSch.Value.ToString("dd-MM-yyyy"); //Date
                        
                        MessageBox.Show(dateTimePickerSch.Value.ToString("dd-MM-yyyy"));
                        File.WriteAllLines(fileToRename, lines); //Write the changes
                        MessageBox.Show("Directory is exists");
                        //TODO
                        //Move file after the changes to the new folder

                        File.Move(fileToRename, (newFilePath + nameOfTask.Text + ".txt"));
                        gbox.Visible = false;
                        showTaskBtn.Text = "Show Details";
                        showTaskBtn.Visible = false;


                    }


                }
                






                try
                {
                    //At the end, Rename the file of the task (also renamed the title of task)
                    File.Move(newFile, (newFilePath + nameOfTask.Text + ".txt"));
                }
                catch
                {
                    MessageBox.Show("Task moved to: " + dateTimePickerSch.Value.ToString("dd-MM-yyyy"));
                }
                


                MessageBox.Show("File renamed." + listBox1.SelectedItem.ToString() + nameOfTask.Text);

                //update current file name (after rename) 
                fileToRename = newFilePath + nameOfTask.Text + ".txt";
                gbox.Text = "Task: " + nameOfTask.Text + " / " + "(" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + ")";

                

                refreshList();

                //select the listbox's renamed, right after rename
                int index = listBox1.FindString(nameOfTask.Text);
                listBox1.SelectedIndex = index;
                






                //TODO change the title of the gbox after the rename
                //gbox.Text = listBox1.SelectedItem.ToString();
                taskEditBtn.Text = "Edit";
                
                

                nameOfTask.Enabled = false;
                taskEditBtn.BackColor = Color.White;
                cancelBtn.Visible = false;
                dateTimePickerSch.Enabled = false;
                hoursCB.Enabled = false;
                minCB.Enabled = false;
                periodCB.Enabled = false;
                typeBox.Enabled = false;
                suggestionBox.Enabled = false;
                needCoffee.Enabled = false;

            }
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

            showTaskBtn.Text = "Show Details";
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

        private void dateTimePickerSch_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerSch.Format = DateTimePickerFormat.Custom;
            dateTimePickerSch.CustomFormat = "dd-MM-yyyy";
        }

        private void clearBtn_Click(object sender, EventArgs e) //its the hideBtn
        {
            //todo: delete Hide Button
            refreshList();
            gbox.Visible = false;

            // Turn edit button like the time before clicked.
            editBtnWasClicked = 1;
            taskEditBtn.Text = "Edit";
            taskEditBtn.BackColor = Color.White;
            cancelBtn.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string path = Directory.GetParent(workingDirectory).Parent.Parent.FullName + @"\HelpFiles\PersonalAssistant.chm";
            MessageBox.Show(path);
            Help.ShowHelp(this, path, HelpNavigator.TopicId, "1");
        }
    }
}
