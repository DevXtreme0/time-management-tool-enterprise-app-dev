using System;
using System.Windows.Forms;
using CourseWorkTwo.Models;

namespace CourseWorkTwo.Forms
{
    public partial class AppointmentForm : UserControl
    {
     
        string appointmentCategoryRButton = "";

        Appointment alignTo = new Appointment();
        public AppointmentForm()
        {
            InitializeComponent();

            //Category radio button hide
            appointmentWeeklyRButton.Visible = false;
            appointmentMonthlyRButton.Visible = false;
            appointmentYearlyRButton.Visible = false;

            alignTo.AppointmentContactList = appointmentContactsListDropDown;
            alignTo.AppointmentDataGridView = appointmentDataGridView;

            alignTo.viewAppointment();
        }
        private void appointmentAddButton_Click(object sender, EventArgs e)
        {
            if (appointmentNameText.Text == "" || appointmentDescText.Text == "" || appointmentContactsListDropDown.SelectedIndex == -1)
            {
                MessageBox.Show("Mandatory field(s) required.", "Add Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!(appointmentOneoffRButton.Checked) && !(appointmentMonthlyRButton.Checked) &&
                     !(appointmentWeeklyRButton.Checked) && !(appointmentYearlyRButton.Checked) == true)
            {
                MessageBox.Show("Please select category.", "Add Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (appointmentOneoffRButton.Checked)
                {
                    appointmentCategoryRButton = appointmentOneoffRButton.Text;
                }
                else if (appointmentMonthlyRButton.Checked)
                {
                    appointmentCategoryRButton = appointmentMonthlyRButton.Text;
                }
                else if (appointmentWeeklyRButton.Checked)
                {
                    appointmentCategoryRButton = appointmentWeeklyRButton.Text;
                }
                else if (appointmentYearlyRButton.Checked)
                {
                    appointmentCategoryRButton = appointmentYearlyRButton.Text;
                }
                else
                {
                    Console.WriteLine("Error in category selection.");
                }
                //set N/A to null values
                if (appointmentAdditionalText.Text == "" || appointmentAdditionalText.Text == null)
                {
                    appointmentAdditionalText.Text = "N/A";
                }
                else if (appointmentLocationText.Text == "" || appointmentLocationText.Text == null)
                {
                    appointmentLocationText.Text = "N/A";
                }
                else if (appointmentPriorityDropDown.Text == "" || appointmentPriorityDropDown.Text == null)
                {
                    appointmentPriorityDropDown.Text = "None";
                }
                else
                {

                    alignTo.AppointmentName = appointmentNameText;
                    alignTo.AppointmentDate = appointmentDateBox;

                    alignTo.AppointmentTimeFrom = appointmentTimeFromTBox;
                    alignTo.AppointmentTimeTo = appointmentTimeToTBox;
                    alignTo.AppointmentLocation = appointmentLocationText;
                    alignTo.AppointmentDescription = appointmentDescText;
                    alignTo.AppointmentAdditionalNote = appointmentAdditionalText;
                    alignTo.AppointmentPriorityLevel = appointmentPriorityDropDown;
                    alignTo.AppointmentContact = appointmentContactsListDropDown;
                    alignTo.AppointmentCategory = appointmentCategoryRButton;
                    alignTo.AppointmentDataGridView = appointmentDataGridView;

                    alignTo.addAppointment();

                    appointmentNameText.Text = "";
                    appointmentDateBox.Text = "";

                    appointmentTimeFromTBox.Text = "";
                    appointmentTimeToTBox.Text = "";
                    appointmentContactsListDropDown.Text = "";
                    appointmentLocationText.Text = "";
                    appointmentDescText.Text = "";
                    appointmentCategoryRButton = "";
                    appointmentAdditionalText.Text = "";
                    appointmentPriorityDropDown.Text = "";
                }
            }
        }
        private void appointmentRecurringRButton_CheckedChanged_1(object sender, EventArgs e)
        {

            appointmentWeeklyRButton.Visible = true;
            appointmentMonthlyRButton.Visible = true;
            appointmentYearlyRButton.Visible = true;

        }
        private void appointmentEditButton_Click_1(object sender, EventArgs e)
        {
            int selectedrowindex = appointmentDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = appointmentDataGridView.Rows[selectedrowindex];
            string appointmentNameFromGrid = Convert.ToString(selectedRow.Cells["appointmentnameDataGridViewTextBoxColumn"].Value);

            if (appointmentNameText.Text == "")
            {
                MessageBox.Show("Please select a record to update.", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (appointmentDescText.Text == "" || appointmentContactsListDropDown.SelectedIndex == -1)
            {
                MessageBox.Show("Mandatory field(s) required.", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (appointmentNameText.Text != appointmentNameFromGrid)
            {
                MessageBox.Show("Please re-select the correct record. " + Environment.NewLine + Environment.NewLine + "Selected record and displayed informations are diefferent" + Environment.NewLine + Environment.NewLine + "(HINT: Try clicking different column or try double click different column)", "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!(appointmentOneoffRButton.Checked) && !(appointmentMonthlyRButton.Checked) &&
                     !(appointmentWeeklyRButton.Checked) && !(appointmentYearlyRButton.Checked) == true)
            {
                MessageBox.Show("Please select category.", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (appointmentOneoffRButton.Checked)
                {
                    appointmentCategoryRButton = appointmentOneoffRButton.Text;
                }
                else if (appointmentMonthlyRButton.Checked)
                {
                    appointmentCategoryRButton = appointmentMonthlyRButton.Text;
                }
                else if (appointmentWeeklyRButton.Checked)
                {
                    appointmentCategoryRButton = appointmentWeeklyRButton.Text;
                }
                else if (appointmentYearlyRButton.Checked)
                {
                    appointmentCategoryRButton = appointmentYearlyRButton.Text;
                }
                else
                {
                    Console.WriteLine("Error in category selection.");
                }

                if (appointmentAdditionalText.Text == "" || appointmentAdditionalText.Text == null)
                {
                    appointmentAdditionalText.Text = "N/A";
                }
                else if (appointmentLocationText.Text == "" || appointmentLocationText.Text == null)
                {
                    appointmentLocationText.Text = "N/A";
                }
                else if (appointmentPriorityDropDown.Text == "" || appointmentPriorityDropDown.Text == null)
                {
                    appointmentPriorityDropDown.Text = "None";
                }
                else
                {
                    alignTo.AppointmentName = appointmentNameText;
                    alignTo.AppointmentDate = appointmentDateBox;

                    alignTo.AppointmentTimeFrom = appointmentTimeFromTBox;
                    alignTo.AppointmentTimeTo = appointmentTimeToTBox;
                    alignTo.AppointmentLocation = appointmentLocationText;
                    alignTo.AppointmentDescription = appointmentDescText;
                    alignTo.AppointmentAdditionalNote = appointmentAdditionalText;
                    alignTo.AppointmentPriorityLevel = appointmentPriorityDropDown;
                    alignTo.AppointmentContact = appointmentContactsListDropDown;
                    alignTo.AppointmentCategory = appointmentCategoryRButton;
                    alignTo.AppointmentDataGridView = appointmentDataGridView;

                    alignTo.updateAppointment();

                    appointmentNameText.Enabled = true;
                    appointmentNameText.Text = "";
                    appointmentDateBox.Text = "";

                    appointmentTimeFromTBox.Text = "";
                    appointmentTimeToTBox.Text = "";
                    appointmentContactsListDropDown.Text = "";
                    appointmentLocationText.Text = "";
                    appointmentDescText.Text = "";
                    appointmentCategoryRButton = "";
                    appointmentAdditionalText.Text = "";
                    appointmentPriorityDropDown.Text = "";
                }
            }
        }
        private void appointmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            appointmentNameText.Enabled = false;

            int selectedRowIndex = e.RowIndex;

            if (selectedRowIndex >= 0)
            {
                String selectedAppointmentCategoryRButton = "";
                //Datagrid value set to text fields
                DataGridViewRow selectedRow = appointmentDataGridView.Rows[selectedRowIndex];

                appointmentNameText.Text = selectedRow.Cells[2].Value.ToString();
                appointmentDateBox.Text = selectedRow.Cells[3].Value.ToString();
               
                appointmentTimeFromTBox.Text = selectedRow.Cells[4].Value.ToString();
                appointmentTimeToTBox.Text = selectedRow.Cells[5].Value.ToString();
                appointmentLocationText.Text = selectedRow.Cells[6].Value.ToString();
                appointmentDescText.Text = selectedRow.Cells[7].Value.ToString();
                selectedAppointmentCategoryRButton = selectedRow.Cells[8].Value.ToString();

                if (selectedAppointmentCategoryRButton == "One-off")
                {
                    appointmentOneoffRButton.Checked = true;
                }
                else if (selectedAppointmentCategoryRButton == "Weekly")
                {
                    appointmentWeeklyRButton.Checked = true;
                }
                else if (selectedAppointmentCategoryRButton == "Monthly")
                {
                    appointmentMonthlyRButton.Checked = true;
                }
                else if (selectedAppointmentCategoryRButton == "Yearly")
                {
                    appointmentYearlyRButton.Checked = true;
                }
                else
                {
                    Console.WriteLine("Radio button selection failed.");
                }
                appointmentAdditionalText.Text = selectedRow.Cells[9].Value.ToString();
                appointmentPriorityDropDown.Text = selectedRow.Cells[10].Value.ToString();
                appointmentContactsListDropDown.Text = selectedRow.Cells[11].Value.ToString();
            }
            else
            {
                MessageBox.Show("Table column data sorted", "Sort Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            int selectedrowindex = appointmentDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRowOne = appointmentDataGridView.Rows[selectedrowindex];
            string appointmentNameFromGrid = Convert.ToString(selectedRowOne.Cells["appointmentnameDataGridViewTextBoxColumn"].Value);

            if (appointmentNameFromGrid == appointmentMonthlyRButton.Text ||
                appointmentNameFromGrid == appointmentWeeklyRButton.Text || appointmentNameFromGrid == appointmentYearlyRButton.Text)
            {
                appointmentWeeklyRButton.Visible = true;
                appointmentMonthlyRButton.Visible = true;
                appointmentYearlyRButton.Visible = true;
            }
            else
            {
                appointmentWeeklyRButton.Visible = false;
                appointmentMonthlyRButton.Visible = false;
                appointmentYearlyRButton.Visible = false;
            }
        }
        private void appointmentOneoffRButton_CheckedChanged_1(object sender, EventArgs e)
        {
            appointmentWeeklyRButton.Visible = false;
            appointmentMonthlyRButton.Visible = false;
            appointmentYearlyRButton.Visible = false;
        }
        private void appointmentDeleteButton_Click_1(object sender, EventArgs e)
        {
            int selectedrowindex = appointmentDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = appointmentDataGridView.Rows[selectedrowindex];
            string appointmentNameFromGrid = Convert.ToString(selectedRow.Cells["appointmentnameDataGridViewTextBoxColumn"].Value);

            if (appointmentNameText.Text == "")
            {
                MessageBox.Show("Please select a record to delete.", "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (appointmentDescText.Text == "" )
            {
                MessageBox.Show("Please re-select the correct record to delete. " + Environment.NewLine + Environment.NewLine + "Selected record and displayed informations are diefferent" + Environment.NewLine + Environment.NewLine + "(HINT: Try clicking different column or try double click different column)", "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //else if (appointmentNameText.Text != appointmentNameFromGrid)
            //{
            //    MessageBox.Show("Please re-select the correct record to delete. " + Environment.NewLine + Environment.NewLine + "Selected record and displayed informations are diefferent" + Environment.NewLine + Environment.NewLine + "(HINT: Try clicking different column or try double click different column)", "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else if (!(appointmentOneoffRButton.Checked) && !(appointmentMonthlyRButton.Checked) &&
            //         !(appointmentWeeklyRButton.Checked) && !(appointmentYearlyRButton.Checked) == true)
            //{
            //    MessageBox.Show("Please re-select the correct record to delete. " + Environment.NewLine + Environment.NewLine + "Selected record and displayed informations are diefferent" + Environment.NewLine + Environment.NewLine + "(HINT: Try clicking different column or try double click different column)", "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            else
            {
                alignTo.AppointmentName = appointmentNameText;
                alignTo.AppointmentDate = appointmentDateBox;
          
                alignTo.AppointmentTimeFrom = appointmentTimeFromTBox;
                alignTo.AppointmentTimeTo = appointmentTimeToTBox;
                alignTo.AppointmentLocation = appointmentLocationText;
                alignTo.AppointmentDescription = appointmentDescText;
                alignTo.AppointmentAdditionalNote = appointmentAdditionalText;
                alignTo.AppointmentPriorityLevel = appointmentPriorityDropDown;
                alignTo.AppointmentContact = appointmentContactsListDropDown;
                alignTo.AppointmentCategory = appointmentCategoryRButton;
                alignTo.AppointmentDataGridView = appointmentDataGridView;

                alignTo.deleteAppointment();
                //set fields to empty
                appointmentNameText.Enabled = true;
                appointmentNameText.Text = "";
                appointmentDateBox.Text = "";
 
                appointmentTimeFromTBox.Text = "";
                appointmentTimeToTBox.Text = "";
                appointmentContactsListDropDown.Text = "";
                appointmentLocationText.Text = "";
                appointmentDescText.Text = "";
                appointmentCategoryRButton = "";
                appointmentAdditionalText.Text = "";
                appointmentPriorityDropDown.Text = "";
            }
        }
        private void appointmentResetButton_Click_1(object sender, EventArgs e)
        {
            appointmentNameText.Enabled = true;
            appointmentNameText.Text = "";
            appointmentDateBox.Text = "";
            //set fields to empty
            appointmentTimeFromTBox.Text = "";
            appointmentTimeToTBox.Text = "";
            appointmentContactsListDropDown.Text = "";
            appointmentLocationText.Text = "";
            appointmentDescText.Text = "";
            appointmentCategoryRButton = "";
            appointmentAdditionalText.Text = "";
            appointmentPriorityDropDown.Text = "";
            appointmentOneoffRButton.Checked = false;
            appointmentRecurringRButton.Checked = false;
            appointmentWeeklyRButton.Visible = false;
            appointmentMonthlyRButton.Visible = false;
            appointmentYearlyRButton.Visible = false;
        }

   
    }
}

