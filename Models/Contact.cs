
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkTwo.Models
{
    class Contact
    {
        private int contactId;
        private ComboBox contactCourtesyTittle;
        private TextBox contactFirstName;
        private TextBox contactSurname;
        private TextBox contactPhoneNumber;
        private TextBox contactEmail;
        private TextBox contactOccupation;
        private DataGridView contactDataGridView;
        private DataGridViewCellEventArgs contactDataGridViewSelect;

        public ComboBox ContactCourtesyTittle { get; set; }
        public TextBox FirstName { get; set; }
        public TextBox Surname { get; set; }
        public TextBox PhoneNumber { get; set; }
        public TextBox Email { get; set; }
        public TextBox Occupation { get; set; }
        public DataGridView ContactDataGridView { get; set; }
        public DataGridViewCellEventArgs DataGridViewSelect { get; set; }

        public void viewContact()
        {
            contactCourtesyTittle = ContactCourtesyTittle;
            contactFirstName = FirstName;
            contactSurname = Surname;
            contactEmail = Email;
            contactPhoneNumber = PhoneNumber;
            contactOccupation = Occupation;
            contactDataGridView = ContactDataGridView;
            contactDataGridViewSelect = DataGridViewSelect;

            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;database=master");
            
                string str2 = "SELECT * FROM contact_person";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                contactDataGridView.DataSource = new BindingSource(dt, null);
        }
        public void addContact()
        {
            contactCourtesyTittle = ContactCourtesyTittle;
            contactFirstName = FirstName;
            contactSurname = Surname;
            contactEmail = Email;
            contactPhoneNumber = PhoneNumber;
            contactOccupation = Occupation;
            contactDataGridView = ContactDataGridView;       

            try
            {
                SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;database=master");
                databaseConnection.Open();

                string checkFirstName = contactFirstName.Text;

                //check contact exist or not
                string checkExistQuery = "SELECT first_name FROM contact_person WHERE first_name ='" + checkFirstName + "';";
                SqlCommand checkExistcommand = new SqlCommand(checkExistQuery, databaseConnection);
                SqlDataReader checkExistDataReader = checkExistcommand.ExecuteReader();

                if (checkExistDataReader.Read())
                {
                    MessageBox.Show("Data already exist", "Add Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    checkExistDataReader.Close();
                    //checkExistDataReader.Dispose();
                }
                else
                {
                    checkExistDataReader.Close();

                    var contactCreatedtime = DateTime.Now;
                    string addRecordQuery = "INSERT INTO contact_person(courtesy_tittle,first_name,surname,phone_number,email_address,profession,created_date_time) " +
                        "VALUES('" + contactCourtesyTittle.Text + "','" + contactFirstName.Text + "','" + contactSurname.Text + "','" + contactPhoneNumber.Text + "','" + contactEmail.Text +
                        "','" + contactOccupation.Text + "','" + contactCreatedtime + "'); ";

                    SqlCommand addRecordCommand = new SqlCommand(addRecordQuery, databaseConnection);
                    addRecordCommand.ExecuteNonQuery();

                    string checkAddedRecordQuery = "SELECT contact_id FROM contact_person WHERE first_name='" + contactFirstName.Text + "' ;";

                    SqlCommand checkAddedRecordCommand = new SqlCommand(checkAddedRecordQuery, databaseConnection);
                    SqlDataReader AddedRecordReader = checkAddedRecordCommand.ExecuteReader();

                    string addStatus = "";
                    switch (AddedRecordReader.HasRows)
                    {
                        case true:
                            MessageBox.Show("Contact: " + contactCourtesyTittle.Text + contactFirstName.Text + " added successfully. ", "Add Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AddedRecordReader.Close();
                            addStatus = "created successfully.";
                            break;

                        case false:
                            MessageBox.Show("Contact: " + contactCourtesyTittle.Text + contactFirstName.Text + " add failed. ", "Add Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            AddedRecordReader.Close();
                            addStatus = "creation failed.";
                            break;
                    }
                    
                    string auditTraceQuery = "INSERT INTO audit_trace(description,traced_page,traced_task,created_date_time)"
                       + "VALUES('contact " + contactCourtesyTittle.Text + " " + contactFirstName.Text + ""+ addStatus + "','Contact Page','Add','" + contactCreatedtime + "');";

                    SqlCommand auditTraceAddCommand = new SqlCommand(auditTraceQuery, databaseConnection);
                    auditTraceAddCommand.ExecuteNonQuery();

                    string checkAuditTraceQuery = "SELECT audit_id FROM audit_trace WHERE created_date_time='" + contactCreatedtime + "' ;";

                    SqlCommand checkAuditTraceCommand = new SqlCommand(checkAddedRecordQuery, databaseConnection);
                    SqlDataReader AuditTraceReader = checkAuditTraceCommand.ExecuteReader();

                    switch (AuditTraceReader.HasRows)
                    {
                        case true:
                            Console.WriteLine("Auidt trace for add task created successfully.");
                            AuditTraceReader.Close();                        
                            break;

                        case false:
                            Console.WriteLine("Audit trace for add task creation failed.");
                            AuditTraceReader.Close();                          
                            break;
                    }

                    string refreshGridQuery = "SELECT * FROM contact_person";

                    SqlCommand refreshGridCommand = new SqlCommand(refreshGridQuery, databaseConnection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(refreshGridCommand);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    contactDataGridView.DataSource = new BindingSource(dataTable, null);

                    databaseConnection.Close();
                }
            }
            catch (SqlException producedException)
            {
                MessageBox.Show("Record Add Failed, Database Disconnected" + Environment.NewLine + "Detailed Information: " + producedException.Message, "Add Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void updateContact()
        {
            contactCourtesyTittle = ContactCourtesyTittle;
            contactFirstName = FirstName;
            contactSurname = Surname;
            contactEmail = Email;
            contactPhoneNumber = PhoneNumber;
            contactOccupation = Occupation;
            contactDataGridView = ContactDataGridView;
            
            try
            {
                SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;database=master");
                databaseConnection.Open();

                int selectedrowindex = contactDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = contactDataGridView.Rows[selectedrowindex];
                string contactIdFromGrid = Convert.ToString(selectedRow.Cells["contactidDataGridViewTextBoxColumn"].Value);

                var contactCreatedtime = DateTime.Now;
                string updateRecordQuery = " Update contact_person set surname='" + contactSurname.Text + "',phone_number='" +
                    contactPhoneNumber.Text + "',email_address='" + contactEmail.Text + "',profession='" + contactOccupation.Text +
                    "'Where contact_id='" + contactIdFromGrid + "'";

                SqlCommand updateRecordCommand = new SqlCommand(updateRecordQuery, databaseConnection);
                updateRecordCommand.ExecuteNonQuery();

                string updateCheckQuery = "SELECT MAX(contact_id) FROM contact_person WHERE first_name='" + contactFirstName.Text + "' " +
                    "AND surname='" + contactSurname.Text + "';";

                SqlCommand updateCheckCommand = new SqlCommand(updateCheckQuery, databaseConnection);
                SqlDataReader updateCheckReader = updateCheckCommand.ExecuteReader();

                if (updateCheckReader.Read())
                {
                    MessageBox.Show(contactCourtesyTittle.Text + contactFirstName.Text + "'s details updated successfully. ", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    updateCheckReader.Close();

                    string auditTraceQuery = "INSERT INTO audit_trace(description,traced_page,traced_task,created_date_time)"
                    + "VALUES('contact " + contactCourtesyTittle.Text + contactFirstName.Text + " updated.','Contact Page','Update','" +
                    contactCreatedtime + "');";

                    SqlCommand auditTraceCommand = new SqlCommand(auditTraceQuery, databaseConnection);
                    auditTraceCommand.ExecuteNonQuery();

                    string checkAuditTraceQuery = "SELECT audit_id FROM audit_trace WHERE created_date_time='" + contactCreatedtime + "' ;";
                   
                    SqlCommand checkAuditTraceCommand = new SqlCommand(checkAuditTraceQuery, databaseConnection);
                    SqlDataReader AuditTraceReader = checkAuditTraceCommand.ExecuteReader();

                    switch (AuditTraceReader.HasRows)
                    {
                        case true:
                            Console.WriteLine("Auidt trace for update task created successfully.");
                            AuditTraceReader.Close();
                            break;

                        case false:
                            Console.WriteLine("Audit trace for update task creation failed.");
                            AuditTraceReader.Close();
                            break;
                    }
                   
                    string refreshGridQuery = "SELECT * FROM contact_person";

                    SqlCommand refreshGridCommand = new SqlCommand(refreshGridQuery, databaseConnection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(refreshGridCommand);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    contactDataGridView.DataSource = new BindingSource(dataTable, null);

                    //updateCheckReader.Dispose(); // For Free up memmory
                    databaseConnection.Close();
                }
                else
                {
                    MessageBox.Show(contactCourtesyTittle.Text + contactFirstName.Text + "'s details update failed. ", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException producedException)
            {
                MessageBox.Show("Record update failed." + Environment.NewLine + "Detailed Information: " + producedException.Message, "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void deleteContact()
        {
            contactCourtesyTittle = ContactCourtesyTittle;
            contactFirstName = FirstName;
            contactSurname = Surname;
            contactEmail = Email;
            contactPhoneNumber = PhoneNumber;
            contactOccupation = Occupation;
            contactDataGridView = ContactDataGridView;

            try
            {
                SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;database=master");
                databaseConnection.Open();

                int selectedRowIndex = contactDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = contactDataGridView.Rows[selectedRowIndex];
                string contactNameFromGrid = Convert.ToString(selectedRow.Cells["firstnameDataGridViewTextBoxColumn"].Value);

                string deleteValidityCheckQuery = "SELECT contact_name FROM event_record WHERE contact_name ='" + contactNameFromGrid + "'";

                SqlCommand validityCheckCommand = new SqlCommand(deleteValidityCheckQuery, databaseConnection);
                validityCheckCommand.ExecuteNonQuery();

                SqlDataReader validityCheckReader = validityCheckCommand.ExecuteReader();

                if (validityCheckReader.HasRows)
                {
                    MessageBox.Show("You can not delete assigened contact.", "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    validityCheckReader.Close();

                    string deleteValidityCheckQuery2 = "SELECT contact_name FROM appointment_record WHERE contact_name ='" + contactNameFromGrid + "'";

                    SqlCommand validityCheckCommand2 = new SqlCommand(deleteValidityCheckQuery2, databaseConnection);
                    validityCheckCommand2.ExecuteNonQuery();

                    SqlDataReader validityCheckReader2 = validityCheckCommand2.ExecuteReader();

                    if (validityCheckReader2.HasRows)
                    {
                        MessageBox.Show("You can not delete assigened contact.", "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        validityCheckReader2.Close();

                        string deleteValidityCheckQuery3 = "SELECT contact_name FROM task_record WHERE contact_name ='" + contactNameFromGrid + "'";

                        SqlCommand validityCheckCommand3 = new SqlCommand(deleteValidityCheckQuery3, databaseConnection);
                        validityCheckCommand3.ExecuteNonQuery();

                        SqlDataReader validityCheckReader3 = validityCheckCommand3.ExecuteReader();

                        if (validityCheckReader3.HasRows)
                        {
                            MessageBox.Show("You can not delete assigened contact.", "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            validityCheckReader3.Close();

                            int selectedrowindex = contactDataGridView.SelectedCells[0].RowIndex;
                            DataGridViewRow selectedRow1 = contactDataGridView.Rows[selectedrowindex];
                            string contactIdFromGrid = Convert.ToString(selectedRow1.Cells["contactidDataGridViewTextBoxColumn"].Value);
                            //string contactNameFromGrid = Convert.ToString(selectedRow1.Cells["contactnameDataGridViewTextBoxColumn"].Value);

                            string deleteRecordQuery = " DELETE  FROM contact_person WHERE contact_id='" + contactIdFromGrid + "';";

                            SqlCommand deleteRecordCommand = new SqlCommand(deleteRecordQuery, databaseConnection);
                            deleteRecordCommand.ExecuteNonQuery();

                            string checkDeletedRecord = "SELECT contact_id FROM contact_person WHERE first_name='" + contactNameFromGrid + "' ;";

                            SqlCommand checkDeletedRecordCommand = new SqlCommand(checkDeletedRecord, databaseConnection);
                            SqlDataReader deletedRecordReader = checkDeletedRecordCommand.ExecuteReader();

                            switch (deletedRecordReader.HasRows)
                            {
                                case false:
                                    MessageBox.Show("Contact: " + contactCourtesyTittle.Text + contactFirstName.Text + " deleted successfully. ", "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    deletedRecordReader.Close();
                                    break;

                                case true:
                                    MessageBox.Show("Contact: " + contactCourtesyTittle.Text + contactFirstName.Text + " delete failed. ", "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    deletedRecordReader.Close();
                                    break;
                            }

                            var contactDeletedtime = DateTime.Now;
                            string auditTraceQuery = "INSERT INTO audit_trace(description,traced_page,traced_task,created_date_time)"
                           + "VALUES('contact " + contactCourtesyTittle.Text + contactFirstName.Text + " deleted.','Contact Page','Delete','" +
                           contactDeletedtime + "');";

                            SqlCommand auditTraceCommand = new SqlCommand(auditTraceQuery, databaseConnection);
                            auditTraceCommand.ExecuteNonQuery();

                            string checkAuditTraceQuery = "SELECT audit_id FROM audit_trace WHERE created_date_time='" + contactDeletedtime + "' ;";

                            SqlCommand checkAuditTraceCommand = new SqlCommand(checkAuditTraceQuery, databaseConnection);
                            SqlDataReader AuditTraceReader = checkAuditTraceCommand.ExecuteReader();

                            switch (AuditTraceReader.HasRows)
                            {
                                case true:
                                    Console.WriteLine("Auidt trace for delete task created successfully.");
                                    AuditTraceReader.Close();
                                    break;

                                case false:
                                    Console.WriteLine("Audit trace for delete task creation failed.");
                                    AuditTraceReader.Close();
                                    break;
                            }

                            string refreshGridQuery = "SELECT * FROM contact_person";

                            SqlCommand refreshGridCommand = new SqlCommand(refreshGridQuery, databaseConnection);
                            SqlDataAdapter dataAdapter = new SqlDataAdapter(refreshGridCommand);
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);
                            contactDataGridView.DataSource = new BindingSource(dataTable, null);

                            databaseConnection.Close();
                        }
                    }
                }
            }
            catch (SqlException producedException)
            {
                MessageBox.Show("Record delete failed." + Environment.NewLine + "Detailed Information: " + producedException.Message, "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }
        }
    }        
    

