using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWorkTwo.Models;

namespace CourseWorkTwo.Forms
{
    public partial class TaskForm : UserControl
    {


        string taskCategoryRButton = "";

        TaskManagement cc = new TaskManagement();
        public TaskForm()
        {
            InitializeComponent();

            taskWeeklyRButton.Visible = false;
            taskMonthlyRButton.Visible = false;
            taskYearlyRButton.Visible = false;

            cc.TaskContactList = taskContactsListDropDown;
            cc.TaskDataGridView = taskDataGridView;

            cc.viewTask();

        }
        private void taskAddButton_Click_1(object sender, EventArgs e)
        {
            if (taskNameText.Text == "" || taskDescText.Text == "" || taskContactsListDropDown.SelectedIndex == -1)
            {
                MessageBox.Show("Mandatory field(s) required.", "Add Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!(taskOneoffRButton.Checked) && !(taskMonthlyRButton.Checked) &&
                     !(taskWeeklyRButton.Checked) && !(taskYearlyRButton.Checked) == true)
            {
                MessageBox.Show("Please select category.", "Add Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (taskOneoffRButton.Checked)
                {
                    taskCategoryRButton = taskOneoffRButton.Text;
                }
                else if (taskMonthlyRButton.Checked)
                {
                    taskCategoryRButton = taskMonthlyRButton.Text;
                }
                else if (taskWeeklyRButton.Checked)
                {
                    taskCategoryRButton = taskWeeklyRButton.Text;
                }
                else if (taskYearlyRButton.Checked)
                {
                    taskCategoryRButton = taskYearlyRButton.Text;
                }
                else
                {
                    Console.WriteLine("Error in category selection.");
                }

                if (taskAdditionalText.Text == "" || taskAdditionalText.Text == null)
                {
                    taskAdditionalText.Text = "N/A";
                }
                else if (taskLocationText.Text == "" || taskLocationText.Text == null)
                {
                    taskLocationText.Text = "N/A";
                }
                else if (taskPriorityDropDown.Text == "" || taskPriorityDropDown.Text == null)
                {
                    taskPriorityDropDown.Text = "None";
                }
                else
                {

                    cc.TaskName = taskNameText;
                    cc.TaskDueDate = taskDueDateBox;

                    cc.TaskTimeFrom = taskTimeFromTBox;
                    cc.TaskTimeTo = taskTimeToTBox;
                    cc.TaskLocation = taskLocationText;
                    cc.TaskDescription = taskDescText;
                    cc.TaskAdditionalNote = taskAdditionalText;
                    cc.TaskPriorityLevel = taskPriorityDropDown;
                    cc.TaskContact = taskContactsListDropDown;
                    cc.TaskCategory = taskCategoryRButton;
                    cc.TaskDataGridView = taskDataGridView;

                    cc.addTask();

                    taskNameText.Text = "";
                    taskDueDateBox.Text = "";

                    taskTimeFromTBox.Text = "";
                    taskTimeToTBox.Text = "";
                    taskContactsListDropDown.Text = "";
                    taskLocationText.Text = "";
                    taskDescText.Text = "";
                    taskCategoryRButton = "";
                    taskAdditionalText.Text = "";
                    taskPriorityDropDown.Text = "";
                }
            }
        }
        private void taskRecurringRButton_CheckedChanged(object sender, EventArgs e)
        {

            taskWeeklyRButton.Visible = true;
            taskMonthlyRButton.Visible = true;
            taskYearlyRButton.Visible = true;

        }
        private void taskEditButton_Click(object sender, EventArgs e)
        {
            int selectedrowindex = taskDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = taskDataGridView.Rows[selectedrowindex];
            string taskNameFromGrid = Convert.ToString(selectedRow.Cells["tasknameDataGridViewTextBoxColumn"].Value);

            if (taskNameText.Text == "")
            {
                MessageBox.Show("Please select a record to update.", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (taskDescText.Text == "" || taskContactsListDropDown.SelectedIndex == -1)
            {
                MessageBox.Show("Mandatory field(s) required.", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (taskNameText.Text != taskNameFromGrid)
            {
                MessageBox.Show("Please re-select the correct record. " + Environment.NewLine + Environment.NewLine + "Selected record and displayed informations are diefferent" + Environment.NewLine + Environment.NewLine + "(HINT: Try clicking different column or try double click different column)", "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!(taskOneoffRButton.Checked) && !(taskMonthlyRButton.Checked) &&
                     !(taskWeeklyRButton.Checked) && !(taskYearlyRButton.Checked) == true)
            {
                MessageBox.Show("Please select category.", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (taskOneoffRButton.Checked)
                {
                    taskCategoryRButton = taskOneoffRButton.Text;
                }
                else if (taskMonthlyRButton.Checked)
                {
                    taskCategoryRButton = taskMonthlyRButton.Text;
                }
                else if (taskWeeklyRButton.Checked)
                {
                    taskCategoryRButton = taskWeeklyRButton.Text;
                }
                else if (taskYearlyRButton.Checked)
                {
                    taskCategoryRButton = taskYearlyRButton.Text;
                }
                else
                {
                    Console.WriteLine("Error in category selection.");
                }


                if (taskAdditionalText.Text == "" || taskAdditionalText.Text == null)
                {
                    taskAdditionalText.Text = "N/A";
                }
                else if (taskLocationText.Text == "" || taskLocationText.Text == null)
                {
                    taskLocationText.Text = "N/A";
                }
                else if (taskPriorityDropDown.Text == "" || taskPriorityDropDown.Text == null)
                {
                    taskPriorityDropDown.Text = "None";
                }
                else
                {

                    cc.TaskName = taskNameText;
                    cc.TaskDueDate = taskDueDateBox;

                    cc.TaskTimeFrom = taskTimeFromTBox;
                    cc.TaskTimeTo = taskTimeToTBox;
                    cc.TaskLocation = taskLocationText;
                    cc.TaskDescription = taskDescText;
                    cc.TaskAdditionalNote = taskAdditionalText;
                    cc.TaskPriorityLevel = taskPriorityDropDown;
                    cc.TaskContact = taskContactsListDropDown;
                    cc.TaskCategory = taskCategoryRButton;
                    cc.TaskDataGridView = taskDataGridView;

                    cc.updateTask();

                    taskNameText.Enabled = true;
                    taskNameText.Text = "";
                    taskDueDateBox.Text = "";

                    taskTimeFromTBox.Text = "";
                    taskTimeToTBox.Text = "";
                    taskContactsListDropDown.Text = "";
                    taskLocationText.Text = "";
                    taskDescText.Text = "";
                    taskCategoryRButton = "";
                    taskAdditionalText.Text = "";
                    taskPriorityDropDown.Text = "";
                }
            }
        }
        private void taskDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            taskNameText.Enabled = false;

            int selectedRowIndex = e.RowIndex;

            if (selectedRowIndex >= 0)
            {
                String selectedTaskCategoryRButton = "";

                DataGridViewRow selectedRow = taskDataGridView.Rows[selectedRowIndex];

                taskNameText.Text = selectedRow.Cells[2].Value.ToString();
                taskDueDateBox.Text = selectedRow.Cells[3].Value.ToString();

                taskTimeFromTBox.Text = selectedRow.Cells[4].Value.ToString();
                taskTimeToTBox.Text = selectedRow.Cells[5].Value.ToString();
                taskLocationText.Text = selectedRow.Cells[6].Value.ToString();
                taskDescText.Text = selectedRow.Cells[7].Value.ToString();
                selectedTaskCategoryRButton = selectedRow.Cells[8].Value.ToString();

                if (selectedTaskCategoryRButton == "One-off")
                {
                    taskOneoffRButton.Checked = true;
                }
                else if (selectedTaskCategoryRButton == "Weekly")
                {
                    taskWeeklyRButton.Checked = true;
                }
                else if (selectedTaskCategoryRButton == "Monthly")
                {
                    taskMonthlyRButton.Checked = true;
                }
                else if (selectedTaskCategoryRButton == "Yearly")
                {
                    taskYearlyRButton.Checked = true;
                }
                else
                {
                    Console.WriteLine("Radio button selection failed.");
                }
                taskAdditionalText.Text = selectedRow.Cells[9].Value.ToString();
                taskPriorityDropDown.Text = selectedRow.Cells[10].Value.ToString();
                taskContactsListDropDown.Text = selectedRow.Cells[11].Value.ToString();
            }
            else
            {
                MessageBox.Show("Table column data sorted", "Sort Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            int selectedrowindex = taskDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRowOne = taskDataGridView.Rows[selectedrowindex];
            string taskNameFromGrid = Convert.ToString(selectedRowOne.Cells["tasknameDataGridViewTextBoxColumn"].Value);

            if (taskNameFromGrid == taskMonthlyRButton.Text ||
                taskNameFromGrid == taskWeeklyRButton.Text || taskNameFromGrid == taskYearlyRButton.Text)
            {
                taskWeeklyRButton.Visible = true;
                taskMonthlyRButton.Visible = true;
                taskYearlyRButton.Visible = true;
            }
            else
            {
                taskWeeklyRButton.Visible = false;
                taskMonthlyRButton.Visible = false;
                taskYearlyRButton.Visible = false;
            }
        }
        private void taskOneoffRButton_CheckedChanged(object sender, EventArgs e)
        {
            taskWeeklyRButton.Visible = false;
            taskMonthlyRButton.Visible = false;
            taskYearlyRButton.Visible = false;
        }
        private void taskDeleteButton_Click(object sender, EventArgs e)
        {
            int selectedrowindex = taskDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = taskDataGridView.Rows[selectedrowindex];
            string taskNameFromGrid = Convert.ToString(selectedRow.Cells["tasknameDataGridViewTextBoxColumn"].Value);

            if (taskNameText.Text == "")
            {
                MessageBox.Show("Please select a record to delete.", "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (taskDescText.Text == "" )
            {
                MessageBox.Show("Please re-select the correct record to delete. " + Environment.NewLine + Environment.NewLine + "Selected record and displayed informations are diefferent" + Environment.NewLine + Environment.NewLine + "(HINT: Try clicking different column or try double click different column)", "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //else if (taskNameText.Text != taskNameFromGrid)
            //{
            //    MessageBox.Show("Please re-select the correct record to delete. " + Environment.NewLine + Environment.NewLine + "Selected record and displayed informations are diefferent" + Environment.NewLine + Environment.NewLine + "(HINT: Try clicking different column or try double click different column)", "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else if (!(taskoneoffrbutton.checked) && !(taskmonthlyrbutton.checked) &&
            //         !(taskweeklyrbutton.checked) && !(taskyearlyrbutton.checked) == true)
            //{
            //    messagebox.show("please re-select the correct record to delete. " + environment.newline + environment.newline + "selected record and displayed informations are diefferent" + environment.newline + environment.newline + "(hint: try clicking different column or try double click different column)", "delete status", messageboxbuttons.ok, messageboxicon.warning);
            //}
            else
            {
                cc.TaskName = taskNameText;
                cc.TaskDueDate = taskDueDateBox;

                cc.TaskTimeFrom = taskTimeFromTBox;
                cc.TaskTimeTo = taskTimeToTBox;
                cc.TaskLocation = taskLocationText;
                cc.TaskDescription = taskDescText;
                cc.TaskAdditionalNote = taskAdditionalText;
                cc.TaskPriorityLevel = taskPriorityDropDown;
                cc.TaskContact = taskContactsListDropDown;
                cc.TaskCategory = taskCategoryRButton;
                cc.TaskDataGridView = taskDataGridView;

                cc.deleteTask();

                taskNameText.Enabled = true;
                taskNameText.Text = "";
                taskDueDateBox.Text = "";

                taskTimeFromTBox.Text = "";
                taskTimeToTBox.Text = "";
                taskContactsListDropDown.Text = "";
                taskLocationText.Text = "";
                taskDescText.Text = "";
                taskCategoryRButton = "";
                taskAdditionalText.Text = "";
                taskPriorityDropDown.Text = "";
            }
        }
        private void taskResetButton_Click(object sender, EventArgs e)
        {
            taskNameText.Enabled = true;
            taskNameText.Text = "";
            taskDueDateBox.Text = "";

            taskTimeFromTBox.Text = "";
            taskTimeToTBox.Text = "";
            taskContactsListDropDown.Text = "";
            taskLocationText.Text = "";
            taskDescText.Text = "";
            taskCategoryRButton = "";
            taskAdditionalText.Text = "";
            taskPriorityDropDown.Text = "";
            taskOneoffRButton.Checked = false;
            taskRecurringRButton.Checked = false;
            taskWeeklyRButton.Visible = false;
            taskMonthlyRButton.Visible = false;
            taskYearlyRButton.Visible = false;
        }

    }
}
