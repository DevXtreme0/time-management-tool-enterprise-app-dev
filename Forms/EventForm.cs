using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CourseWorkTwo.Models;

namespace CourseWorkTwo
{
    public partial class EventForm : UserControl
    {
        Event alignTo = new Event(); 
      

        string eventCategoryRButton = "";
        public EventForm()
        {
            InitializeComponent();

            eventWeeklyRButton.Visible = false;
            eventMonthlyRButton.Visible = false;
            eventYearlyRButton.Visible = false;

            alignTo.EventContactList = eventContactsListDropDown;
            alignTo.EventDataGridView = eventDataGridView;

            alignTo.viewEvent();
       
        }
        private void eventAddButton_Click(object sender, EventArgs e)
        {
            if (eventNameText.Text == "" || eventDescText.Text == "" || eventContactsListDropDown.SelectedIndex == -1 )
            {
                MessageBox.Show("Mandatory field(s) required.", "Add Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
            else if (!(eventOneoffRButton.Checked) && !(eventMonthlyRButton.Checked)  && 
                     !(eventWeeklyRButton.Checked) && !(eventYearlyRButton.Checked) == true)
            {
                MessageBox.Show("Please select category.", "Add Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
            }
            else
            {
                if (eventOneoffRButton.Checked)
                {
                    eventCategoryRButton = eventOneoffRButton.Text;
                }
                else if (eventMonthlyRButton.Checked)
                {
                    eventCategoryRButton = eventMonthlyRButton.Text;
                }
                else if (eventWeeklyRButton.Checked)
                {
                    eventCategoryRButton = eventWeeklyRButton.Text;
                }
                else if (eventYearlyRButton.Checked)
                {
                    eventCategoryRButton = eventYearlyRButton.Text;
                }
                else
                {
                    Console.WriteLine("Error in category selection.");
                }


                if (eventAdditionalText.Text == "" || eventAdditionalText.Text == null)
                {
                    eventAdditionalText.Text = "N/A";
                }
                else if (eventLocationText.Text == "" || eventLocationText.Text == null)
                {
                    eventLocationText.Text = "N/A";
                }
                else if (eventPriorityDropDown.Text == "" || eventPriorityDropDown.Text == null)
                {
                    eventPriorityDropDown.Text = "None";
                }
                else
                {

                    alignTo.EventName = eventNameText;
                    alignTo.EventDateFrom = eventDateFromDBox;
                    alignTo.EventDateTo = eventDateToDBox;
                    alignTo.EventTimeFrom = eventTimeFromTBox;
                    alignTo.EventTimeTo = eventTimeToTBox;
                    alignTo.EventLocation = eventLocationText;
                    alignTo.EventDescription = eventDescText;
                    alignTo.EventAdditionalNote = eventAdditionalText;
                    alignTo.EventPriorityLevel = eventPriorityDropDown;
                    alignTo.EventContact = eventContactsListDropDown;
                    alignTo.EventCategory = eventCategoryRButton;
                    alignTo.EventDataGridView = eventDataGridView;

                    alignTo.addEvent();

                    eventNameText.Text = "";
                    eventDateFromDBox.Text = "";
                    eventDateToDBox.Text = "";
                    eventTimeFromTBox.Text = "";
                    eventTimeToTBox.Text = "";
                    eventContactsListDropDown.Text = "";
                    eventLocationText.Text = "";
                    eventDescText.Text = "";
                    eventCategoryRButton = "";
                    eventAdditionalText.Text = "";
                    eventPriorityDropDown.Text = "";
                }
            }                                                   
        }
        private void eventRecurringRButton_CheckedChanged(object sender, EventArgs e)
        {

            eventWeeklyRButton.Visible = true;
            eventMonthlyRButton.Visible = true;
            eventYearlyRButton.Visible = true;

        }
        private void eventEditButton_Click(object sender, EventArgs e)
        {
            int selectedrowindex = eventDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = eventDataGridView.Rows[selectedrowindex];
            string eventNameFromGrid = Convert.ToString(selectedRow.Cells["dataGridViewTextBoxColumn2"].Value);

             if (eventNameText.Text == "")
            {
                MessageBox.Show("Please select a record to update.", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ( eventDescText.Text == "" || eventContactsListDropDown.SelectedIndex == -1)
            {
                MessageBox.Show("Mandatory field(s) required.", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }          
            else if (eventNameText.Text != eventNameFromGrid)
            {
                MessageBox.Show("Please re-select the correct record. " + Environment.NewLine + Environment.NewLine + "Selected record and displayed informations are diefferent" + Environment.NewLine + Environment.NewLine + "(HINT: Try clicking different column or try double click different column)", "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!(eventOneoffRButton.Checked) && !(eventMonthlyRButton.Checked) &&
                     !(eventWeeklyRButton.Checked) && !(eventYearlyRButton.Checked) == true)
            {
                MessageBox.Show("Please select category.", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (eventOneoffRButton.Checked)
                {
                    eventCategoryRButton = eventOneoffRButton.Text;
                }
                else if (eventMonthlyRButton.Checked)
                {
                    eventCategoryRButton = eventMonthlyRButton.Text;
                }
                else if (eventWeeklyRButton.Checked)
                {
                    eventCategoryRButton = eventWeeklyRButton.Text;
                }
                else if (eventYearlyRButton.Checked)
                {
                    eventCategoryRButton = eventYearlyRButton.Text;
                }
                else
                {
                    Console.WriteLine("Error in category selection.");
                }

                if (eventAdditionalText.Text == "" || eventAdditionalText.Text == null)
                {
                    eventAdditionalText.Text = "N/A";
                }
                else if (eventLocationText.Text == "" || eventLocationText.Text == null)
                {
                    eventLocationText.Text = "N/A";
                }
                else if (eventPriorityDropDown.Text == "" || eventPriorityDropDown.Text == null)
                {
                    eventPriorityDropDown.Text = "None";
                }
                else
                {

                    alignTo.EventName = eventNameText;
                    alignTo.EventDateFrom = eventDateFromDBox;
                    alignTo.EventDateTo = eventDateToDBox;
                    alignTo.EventTimeFrom = eventTimeFromTBox;
                    alignTo.EventTimeTo = eventTimeToTBox;
                    alignTo.EventLocation = eventLocationText;
                    alignTo.EventDescription = eventDescText;
                    alignTo.EventAdditionalNote = eventAdditionalText;
                    alignTo.EventPriorityLevel = eventPriorityDropDown;
                    alignTo.EventContact = eventContactsListDropDown;
                    alignTo.EventCategory = eventCategoryRButton;
                    alignTo.EventDataGridView = eventDataGridView;

                    alignTo.updateEvent();

                    eventNameText.Enabled = true;
                    eventNameText.Text = "";
                    eventDateFromDBox.Text = "";
                    eventDateToDBox.Text = "";
                    eventTimeFromTBox.Text = "";
                    eventTimeToTBox.Text = "";
                    eventContactsListDropDown.Text = "";
                    eventLocationText.Text = "";
                    eventDescText.Text = "";
                    eventCategoryRButton = "";
                    eventAdditionalText.Text = "";
                    eventPriorityDropDown.Text = "";

                }
            }
        }
        private void eventDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            eventNameText.Enabled = false;
   
            int selectedRowIndex = e.RowIndex;

            if (selectedRowIndex >= 0)
            {
                String selectedEventCategoryRButton ;

                DataGridViewRow selectedRow = eventDataGridView.Rows[selectedRowIndex];

                eventNameText.Text = selectedRow.Cells["dataGridViewTextBoxColumn2"].Value.ToString();
                eventDateFromDBox.Text = selectedRow.Cells["dataGridViewTextBoxColumn13"].Value.ToString();
                eventDateToDBox.Text = selectedRow.Cells["dataGridViewTextBoxColumn14"].Value.ToString();
                eventTimeFromTBox.Text = selectedRow.Cells["dataGridViewTextBoxColumn15"].Value.ToString();
                eventTimeToTBox.Text = selectedRow.Cells["dataGridViewTextBoxColumn16"].Value.ToString();
                eventLocationText.Text = selectedRow.Cells["dataGridViewTextBoxColumn17"].Value.ToString();
                eventDescText.Text = selectedRow.Cells["dataGridViewTextBoxColumn18"].Value.ToString();
                selectedEventCategoryRButton = selectedRow.Cells["dataGridViewTextBoxColumn19"].Value.ToString();

                
                if (selectedEventCategoryRButton == "One-off")
                {                  
                    eventWeeklyRButton.Visible = false;
                    eventMonthlyRButton.Visible = false;
                    eventYearlyRButton.Visible = false;
                    
                    eventOneoffRButton.Checked = true;

                    eventWeeklyRButton.Checked = false;
                    eventMonthlyRButton.Checked = false;
                    eventYearlyRButton.Checked = false;
                }
                else if (selectedEventCategoryRButton == "Weekly")
                {
                    eventWeeklyRButton.Visible = true;
                    eventMonthlyRButton.Visible = true;
                    eventYearlyRButton.Visible = true;
                    eventWeeklyRButton.Checked = true;
                }
                else if (selectedEventCategoryRButton == "Monthly")
                {
                    eventWeeklyRButton.Visible = true;
                    eventMonthlyRButton.Visible = true;
                    eventYearlyRButton.Visible = true;
                    eventMonthlyRButton.Checked = true;
                }
                else if (selectedEventCategoryRButton == "Yearly")
                {
                    eventWeeklyRButton.Visible = true;
                    eventMonthlyRButton.Visible = true;
                    eventYearlyRButton.Visible = true;
                    eventYearlyRButton.Checked = true;
                }
                else
                {
                    Console.WriteLine("Radio button selection failed.");
                }
                eventAdditionalText.Text = selectedRow.Cells["dataGridViewTextBoxColumn20"].Value.ToString();
                eventPriorityDropDown.Text = selectedRow.Cells["dataGridViewTextBoxColumn21"].Value.ToString();
                eventContactsListDropDown.Text = selectedRow.Cells["dataGridViewTextBoxColumn24"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Table column data sorted", "Sort Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void eventOneoffRButton_CheckedChanged(object sender, EventArgs e)
        {
            eventWeeklyRButton.Visible = false;
            eventMonthlyRButton.Visible = false;
            eventYearlyRButton.Visible = false;
        }
        private void eventDeleteButton_Click(object sender, EventArgs e)
        {
            int selectedrowindex = eventDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = eventDataGridView.Rows[selectedrowindex];
            string eventNameFromGrid = Convert.ToString(selectedRow.Cells["dataGridViewTextBoxColumn2"].Value);

            if (eventNameText.Text == "")
            {
                MessageBox.Show("Please select a record to delete.", "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (eventDescText.Text == "" )
            {
                MessageBox.Show("Please re-select the correct record to delete. " + Environment.NewLine + Environment.NewLine + "Selected record and displayed informations are diefferent" + Environment.NewLine + Environment.NewLine + "(HINT: Try clicking different column or try double click different column)", "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (eventNameText.Text != eventNameFromGrid)
            {
                MessageBox.Show("Please re-select the correct record to delete. " + Environment.NewLine + Environment.NewLine + "Selected record and displayed informations are diefferent" + Environment.NewLine + Environment.NewLine + "(HINT: Try clicking different column or try double click different column)", "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //else if (!(eventOneoffRButton.Checked) || !(eventMonthlyRButton.Checked) &&
            //         !(eventWeeklyRButton.Checked) || !(eventYearlyRButton.Checked) == true)
            //{
            //    MessageBox.Show("Please re-select the correct record to delete. " + Environment.NewLine + Environment.NewLine + "Selected record and displayed informations are diefferent" + Environment.NewLine + Environment.NewLine + "(HINT: Try clicking different column or try double click different column)", "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            else
            {
                alignTo.EventName = eventNameText;
                alignTo.EventDateFrom = eventDateFromDBox;
                alignTo.EventDateTo = eventDateToDBox;
                alignTo.EventTimeFrom = eventTimeFromTBox;
                alignTo.EventTimeTo = eventTimeToTBox;
                alignTo.EventLocation = eventLocationText;
                alignTo.EventDescription = eventDescText;
                alignTo.EventAdditionalNote = eventAdditionalText;
                alignTo.EventPriorityLevel = eventPriorityDropDown;
                alignTo.EventContact = eventContactsListDropDown;
                alignTo.EventCategory = eventCategoryRButton;
                alignTo.EventDataGridView = eventDataGridView;

                alignTo.deleteEvent();

                eventNameText.Enabled = true;
                eventNameText.Text = "";
                eventDateFromDBox.Text = "";
                eventDateToDBox.Text = "";
                eventTimeFromTBox.Text = "";
                eventTimeToTBox.Text = "";
                eventContactsListDropDown.Text = "";
                eventLocationText.Text = "";
                eventDescText.Text = "";
                eventCategoryRButton = "";
                eventAdditionalText.Text = "";
                eventPriorityDropDown.Text = "";
            }
        }
        private void eventResetButton_Click(object sender, EventArgs e)
        { //reset to empty
            eventNameText.Enabled = true;
            eventNameText.Text = "";
            eventDateFromDBox.Text = "";
            eventDateToDBox.Text = "";
            eventTimeFromTBox.Text = "";
            eventTimeToTBox.Text = "";
            eventContactsListDropDown.Text = "";
            eventLocationText.Text = "";
            eventDescText.Text = "";
            eventCategoryRButton = "";
            eventAdditionalText.Text = "";
            eventPriorityDropDown.Text = "";
            eventOneoffRButton.Checked = false;
            eventRecurringRButton.Checked = false;
            eventWeeklyRButton.Visible = false;
            eventMonthlyRButton.Visible = false;
            eventYearlyRButton.Visible = false;
        }

       
    }
}         
    

