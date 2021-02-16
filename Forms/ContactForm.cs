using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CourseWorkTwo.Models;


namespace CourseWorkTwo
{
    public partial class ContactForm : UserControl
    {
        Contact alignToContact = new Contact();

        public ContactForm()
        {
            InitializeComponent();
            
            alignToContact.ContactDataGridView = contactDataGridView;
            //datagridview loading when starting window
            alignToContact.viewContact();
        }
            private void contactAddButton_Click(object sender, EventArgs e)
           {
            
            string avialableCourtesyTittles = TittleDropDown.SelectedIndex.ToString();

            if (TittleDropDown.SelectedIndex == 0) 
            { 
                MessageBox.Show("Courtesy tittle required", "Add Status - Courtesy Tittle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (firstNameText.Text == "" || surNameText.Text == "" || emailText.Text == "" || contactNumberText.Text == "" )
            {
                MessageBox.Show("Mandatory field(s) required", "Add Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }                   
            else
            {
                if (occupationText.Text == "" || occupationText.Text == null)
                {
                    occupationText.Text = "N/A";
                }
                else
                {
                    alignToContact.ContactCourtesyTittle = TittleDropDown;
                    alignToContact.FirstName = firstNameText;
                    alignToContact.Surname = surNameText;
                    alignToContact.Email = emailText;
                    alignToContact.Occupation = occupationText;
                    alignToContact.PhoneNumber = contactNumberText;
                    alignToContact.ContactDataGridView = contactDataGridView;

                    alignToContact.addContact();

                    TittleDropDown.SelectedIndex = 0;
                    firstNameText.Text = "";
                    surNameText.Text = "";
                    contactNumberText.Text = "";
                    emailText.Text = "";
                    occupationText.Text = "";
                }
            }          
        }
        private void contactEditButton_Click(object sender, EventArgs e)
        {
            //get selected row index from data grid view
            int selectedrowindex = contactDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = contactDataGridView.Rows[selectedrowindex];

            //get specific available and visible values from data grid view
            string contactTittleFromGrid = Convert.ToString(selectedRow.Cells["courtesytittleDataGridViewTextBoxColumn"].Value);
            string contactNameFromGrid = Convert.ToString(selectedRow.Cells["firstnameDataGridViewTextBoxColumn"].Value);
            string contactSurnameFromGrid = Convert.ToString(selectedRow.Cells["surnameDataGridViewTextBoxColumn"].Value);

            if (firstNameText.Text =="" || surNameText.Text == "")
            {
                MessageBox.Show("Please select a record to update.", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (contactTittleFromGrid != TittleDropDown.Text || firstNameText.Text != contactNameFromGrid || surNameText.Text != contactSurnameFromGrid)
            {
                MessageBox.Show("Please re-select the correct record. " + Environment.NewLine + Environment.NewLine + "Selected record and displayed informations are diefferent" + Environment.NewLine + Environment.NewLine + "(HINT: Try clicking different column or try double click different column)", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (emailText.Text == "" || contactNumberText.Text == "")
            {
                MessageBox.Show("Mandatory field(s) required", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (occupationText.Text == "" || occupationText.Text == null)
                {
                    occupationText.Text = "N/A";
                }
                else
                {
                    alignToContact.ContactCourtesyTittle = TittleDropDown;
                    alignToContact.FirstName = firstNameText;
                    alignToContact.Surname = surNameText;
                    alignToContact.Email = emailText;
                    alignToContact.Occupation = occupationText;
                    alignToContact.PhoneNumber = contactNumberText;
                    alignToContact.ContactDataGridView = contactDataGridView;

                    alignToContact.updateContact();
                    //reset to empty
                    TittleDropDown.Enabled = true;
                    TittleDropDown.SelectedIndex = 0;
                    firstNameText.Enabled = true;
                    firstNameText.Text = "";
                    surNameText.Enabled = true;
                    surNameText.Text = "";
                    contactNumberText.Text = "";
                    emailText.Text = "";
                    occupationText.Text = "";
                }
            }
        }        
        private void contactDeleteButton_Click(object sender, EventArgs e)
        {
            //get selected row index from data grid view
            int selectedRowIndex = contactDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = contactDataGridView.Rows[selectedRowIndex];

            //get specific available and visible values from data grid view
            string contactTittleFromGrid = Convert.ToString(selectedRow.Cells["courtesytittleDataGridViewTextBoxColumn"].Value);
            string contactNameFromGrid = Convert.ToString(selectedRow.Cells["firstnameDataGridViewTextBoxColumn"].Value);
            string contactSurnameFromGrid = Convert.ToString(selectedRow.Cells["surnameDataGridViewTextBoxColumn"].Value);

            if (firstNameText.Text == "" || surNameText.Text == "" || emailText.Text == "" || contactNumberText.Text == "")
            {
                MessageBox.Show("Please select a record to delete", "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (contactTittleFromGrid != TittleDropDown.Text || contactNameFromGrid != firstNameText.Text || contactSurnameFromGrid != surNameText.Text)
            {
                MessageBox.Show("Please re-select the correct record. " + Environment.NewLine + Environment.NewLine + "Selected record and displayed informations are diefferent" + Environment.NewLine + Environment.NewLine + "(HINT: Try clicking different column or try double click different column)", "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (contactDataGridView.Rows.Count == 1)
            {
                MessageBox.Show("At leaset one record should be in the system in oreder to mainatain the other features", "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                alignToContact.ContactCourtesyTittle = TittleDropDown;
                alignToContact.FirstName = firstNameText;
                alignToContact.Surname = surNameText;
                alignToContact.Email = emailText;
                alignToContact.Occupation = occupationText;
                alignToContact.PhoneNumber = contactNumberText;
                alignToContact.ContactDataGridView = contactDataGridView;

                alignToContact.deleteContact();

                TittleDropDown.Enabled = true;
                TittleDropDown.SelectedIndex = 0;
                firstNameText.Enabled = true;
                firstNameText.Text = "";
                surNameText.Enabled = true;
                surNameText.Text = "";
                contactNumberText.Text = "";
                emailText.Text = "";
                occupationText.Text = "";
            }
        }
        private void firstNameText_TextChanged(object sender, EventArgs e)
        {
            string allowedchar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (!firstNameText.Text.All(allowedchar.Contains))
            {
                firstNameText.Clear();
            }
        }
        private void emailText_TextChanged(object sender, EventArgs e)
        {
            string allowedchar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ@.1234567890";

            if (!emailText.Text.All(allowedchar.Contains))
            {
                emailText.Clear();
            }
        }
        private void surNameText_TextChanged(object sender, EventArgs e)
        {
            string allowedchar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (!surNameText.Text.All(allowedchar.Contains))
            {
                surNameText.Clear();
            }
        }
        private void pNumberText_TextChanged(object sender, EventArgs e)
        {
            string allowedchar = "+0123456789";

            if (!contactNumberText.Text.All(allowedchar.Contains))
            {
                contactNumberText.Clear();
            }
        }
        private void occupationText_TextChanged(object sender, EventArgs e)
        {
            string allowedchar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ/";

            if (!occupationText.Text.All(allowedchar.Contains))
            {
                occupationText.Clear();
            }
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            TittleDropDown.Enabled = true;
            TittleDropDown.SelectedIndex = 0;
            firstNameText.Enabled = true;
            firstNameText.Text = "";
            surNameText.Enabled = true;
            surNameText.Text = "";
            contactNumberText.Text = "";
            emailText.Text = "";
            occupationText.Text = "";
        }
        private void contactDataGridView_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

            alignToContact.ContactCourtesyTittle = TittleDropDown;
            alignToContact.FirstName = firstNameText;
            alignToContact.Surname = surNameText;
            alignToContact.Email = emailText;
            alignToContact.Occupation = occupationText;
            alignToContact.PhoneNumber = contactNumberText;
            alignToContact.ContactDataGridView = contactDataGridView;
            alignToContact.DataGridViewSelect = e;

            int selectedRowIndex = e.RowIndex;

            if (selectedRowIndex >= 0)
            {   //get selected table row index from data grid view
                DataGridViewRow selectedRow = contactDataGridView.Rows[selectedRowIndex];

                //set selected table row values to text fields and dropdown
                TittleDropDown.Text = selectedRow.Cells[2].Value.ToString();
                firstNameText.Text = selectedRow.Cells[3].Value.ToString();
                surNameText.Text = selectedRow.Cells[4].Value.ToString();
                contactNumberText.Text = selectedRow.Cells["phonenumberDataGridViewTextBoxColumn"].Value.ToString();
                emailText.Text = selectedRow.Cells["emailaddressDataGridViewTextBoxColumn"].Value.ToString();
                occupationText.Text = selectedRow.Cells["professionDataGridViewTextBoxColumn"].Value.ToString();
                
                //disable editing 
                TittleDropDown.Enabled = false;
                firstNameText.Enabled = false;
                surNameText.Enabled = false;

                

            }
            else
            {
                MessageBox.Show("Table column data sorted", "Sorting Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

   
        private void TittleDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

        }
    }

}
