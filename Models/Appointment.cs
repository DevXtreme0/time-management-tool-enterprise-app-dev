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
    class Appointment
    {
        private int appointmentId;
        private String appointmentName;
        private DateTimePicker appointmentDate;
        
        private DateTimePicker appointmentDateTo;
        private DateTimePicker appointmentTimeFrom;
        private DateTimePicker appointmentTimeTo;
        private DateTime appointmentTime;
        private int appointmentDateTimeUsage;
        private String appointmentContact;
        private String appointmentLocation;
        private String appointmentDescription;
        private String appointmentCategory;
        private String appointmentAdditionalNote;
        private String appointmentPriorityLevel;
        private DataGridView appointmentDataGridView;
        private ComboBox appointmentContactList;

        public TextBox AppointmentName { get; set; }
        public DateTimePicker AppointmentDate { get; set; }
        public DateTimePicker AppointmentDateTo { get; set; }
        public DateTimePicker AppointmentTimeFrom { get; set; }
        public DateTimePicker AppointmentTimeTo { get; set; }
        public TextBox AppointmentLocation { get; set; }
        public TextBox AppointmentDescription { get; set; }
        public RichTextBox AppointmentAdditionalNote { get; set; }
        public ComboBox AppointmentPriorityLevel { get; set; }
        public ComboBox AppointmentContact { get; set; }

        public ComboBox AppointmentContactList { get; set; }
        public string AppointmentCategory { get; set; }
        public DataGridView AppointmentDataGridView { get; set; }
        public DataGridViewCellEventArgs AppointmentDataGridViewSelect { get; set; }

        public void viewAppointment()
        {
            appointmentContactList = AppointmentContactList;
            appointmentDataGridView = AppointmentDataGridView;

            try
            {
                SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;database=master");
                databaseConnection.Open();

                //load contact list to the dropdown
                string getContactInfoQuery = "SELECT contact_id,first_name FROM contact_person ";

                SqlCommand getContactInfoCommand = new SqlCommand(getContactInfoQuery, databaseConnection);
                getContactInfoCommand.Connection = databaseConnection;

                DataTable dataTableContactInfo = new DataTable();
                dataTableContactInfo.Load(getContactInfoCommand.ExecuteReader());


                appointmentContactList.DataSource = dataTableContactInfo;
                appointmentContactList.DisplayMember = "first_name";
                appointmentContactList.ValueMember = "contact_id";

                string refreshGridQuery = "SELECT * FROM appointment_record";

                SqlCommand refreshGridCommand = new SqlCommand(refreshGridQuery, databaseConnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(refreshGridCommand);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                appointmentDataGridView.DataSource = new BindingSource(dataTable, null);

                databaseConnection.Close();
            }
            catch (SqlException producedException)
            {
                MessageBox.Show("Contact load failed." + Environment.NewLine + "Detailed Information: " + producedException.Message, "Contact List Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void addAppointment()
        {
            appointmentName = AppointmentName.Text;
            appointmentDate = AppointmentDate;
            
            appointmentTimeFrom = AppointmentTimeFrom;
            appointmentTimeTo = AppointmentTimeTo;
            appointmentLocation = AppointmentLocation.Text;
            appointmentDescription = AppointmentDescription.Text;
            appointmentAdditionalNote = AppointmentAdditionalNote.Text;
            appointmentPriorityLevel = AppointmentPriorityLevel.Text;
            appointmentCategory = AppointmentCategory;
            appointmentContact = AppointmentContact.Text;
            appointmentDataGridView = AppointmentDataGridView;

            try
            {
                SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;database=master");
                databaseConnection.Open();

                var appointmentCreatedTime = DateTime.Now;
                //string formattedTime = time.ToString("yyyy, MM, dd, hh, mm, ss");                

                //get hours,minutes, seconds counted
                DateTime startTime = Convert.ToDateTime(appointmentTimeFrom.Value);
                DateTime endTime = Convert.ToDateTime(appointmentTimeTo.Value);

                TimeSpan span = endTime.Subtract(startTime);

                int hoursDifference = span.Hours;
                int minutesDifference = span.Minutes;
                int secondsDifference = span.Seconds;

                string checkExistQuery = "SELECT appointment_id FROM appointment_record WHERE appointment_name ='" + appointmentName + "';";
                SqlCommand checkExistcommand = new SqlCommand(checkExistQuery, databaseConnection);
                SqlDataReader checkExistDataReader = checkExistcommand.ExecuteReader();


                if (checkExistDataReader.Read())
                {
                    MessageBox.Show("Record data by appointment name already exist", "Add Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    checkExistDataReader.Close();
                    //checkExistDataReader.Dispose();
                }
                else
                {
                    checkExistDataReader.Close();

                    string appointmentAddQuery = "INSERT INTO appointment_record(appointment_name,appointment_date," +
                    "time_from,time_to,location,description," +
                    "category,additional_note,priority_level,created_date_time,updated_date_time,contact_name) " +
                    "VALUES('" + appointmentName + "','" + appointmentDate.Text + "','"+ appointmentTimeFrom.Text + "','"
                    + appointmentTimeTo.Text + "','"
                    + appointmentLocation + "','" + appointmentDescription + "','"
                    + AppointmentCategory.ToString() + "','" + appointmentAdditionalNote + "','"
                    + appointmentPriorityLevel + "','" + appointmentCreatedTime + "','"
                    + appointmentCreatedTime + "','" + appointmentContact + "');";

                    SqlCommand appointmentAddCommand = new SqlCommand(appointmentAddQuery, databaseConnection);
                    appointmentAddCommand.ExecuteNonQuery();

                    string checkAddedRecordQuery = "SELECT appointment_id FROM appointment_record WHERE appointment_name='" + appointmentName + "' ;";

                    SqlCommand checkAddedRecordCommand = new SqlCommand(checkAddedRecordQuery, databaseConnection);
                    SqlDataReader AddedRecordReader = checkAddedRecordCommand.ExecuteReader();

                    string addStatus = "";
                    switch (AddedRecordReader.HasRows)
                    {
                        case true:
                            MessageBox.Show("Appointment : " + appointmentName + " added successfully. ", "Add Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AddedRecordReader.Close();
                            addStatus = "created successfully.";
                            break;

                        case false:
                            MessageBox.Show("Appointment : " + appointmentName + " add failed. ", "Add Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            AddedRecordReader.Close();
                            addStatus = "creation failed.";
                            break;
                    }

                    string auditTraceQuery = "INSERT INTO audit_trace(description,traced_page,traced_task,created_date_time)"
                       + "VALUES('Appointment " + appointmentName + "" + addStatus + "','Appointment Page','Add','" + appointmentCreatedTime + "');";

                    SqlCommand auditTraceAddCommand = new SqlCommand(auditTraceQuery, databaseConnection);
                    auditTraceAddCommand.ExecuteNonQuery();

                    string checkAuditTraceQuery = "SELECT audit_id FROM Audit_Table WHERE created_date_time='" + appointmentCreatedTime + "' ;";

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

                    string refreshGridQuery = "SELECT * FROM appointment_record";
                    SqlCommand refreshGridCommand = new SqlCommand(refreshGridQuery, databaseConnection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(refreshGridCommand);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    appointmentDataGridView.DataSource = new BindingSource(dataTable, null);

                    int appointmentDay = appointmentDate.Value.Day;
                    int appointmentMonth = appointmentDate.Value.Month;
                    int appointmentYear = appointmentDate.Value.Year;

                    string appointmentPredictPurposeQuery = "INSERT INTO appointment_prediction_purpose(appointment_name,date_from,year,month,day," +
                                                            "hours_count,minutes_count,seconds_count,created_date_time,updated_date_time)"
                                                          + "VALUES('" + appointmentName + "','" + appointmentDate.Text + "','" 
                                                          + appointmentYear + "','" + appointmentMonth + "','" + appointmentDay + "','" 
                                                          + hoursDifference + "','" + minutesDifference + "','" + secondsDifference + "','" 
                                                          + appointmentCreatedTime + "','" + appointmentCreatedTime + "');";

                    SqlCommand appointmentPredictPurposeCommand = new SqlCommand(appointmentPredictPurposeQuery, databaseConnection);
                    appointmentPredictPurposeCommand.ExecuteNonQuery();

                    databaseConnection.Close();
                }
            }
            catch (SqlException producedException)
            {
                MessageBox.Show("Failed function(s) detected." + Environment.NewLine + "Detailed Information: " + producedException.Message, "Add Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void updateAppointment()
        {
            appointmentName = AppointmentName.Text;
            appointmentDate = AppointmentDate;
            appointmentDateTo = AppointmentDateTo;
            appointmentTimeFrom = AppointmentTimeFrom;
            appointmentTimeTo = AppointmentTimeTo;
            appointmentLocation = AppointmentLocation.Text;
            appointmentDescription = AppointmentDescription.Text;
            appointmentAdditionalNote = AppointmentAdditionalNote.Text;
            appointmentPriorityLevel = AppointmentPriorityLevel.Text;
            appointmentCategory = AppointmentCategory;
            appointmentContact = AppointmentContact.Text;
            appointmentDataGridView = AppointmentDataGridView;

            try
            {
                SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;database=master");
                databaseConnection.Open();

                var appointmentUpdatedDateTime = DateTime.Now;
                //string formattedTime = time.ToString("yyyy, MM, dd, hh, mm, ss");

                int selectedrowindex = appointmentDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = appointmentDataGridView.Rows[selectedrowindex];
                string appointmentIdFromGrid = Convert.ToString(selectedRow.Cells["appointmentidDataGridViewTextBoxColumn"].Value);

                string updateRecordQuery = " Update appointment_record set appointment_name='" + appointmentName + "',appointment_date='" +
                    appointmentDate.Text +  "',time_from='" + appointmentTimeFrom.Text +
                    "',time_to='" + appointmentTimeTo.Text + "',location='" + appointmentLocation + "',description='" + appointmentDescription +
                    "',category='" + appointmentCategory + "',additional_note='" + appointmentAdditionalNote + "',priority_level='" + appointmentPriorityLevel +
                    "',contact_name='" + appointmentContact + "',updated_date_time='" + appointmentUpdatedDateTime +
                    "'Where appointment_id='" + appointmentIdFromGrid + "'";

                SqlCommand updateRecordCommand = new SqlCommand(updateRecordQuery, databaseConnection);
                updateRecordCommand.ExecuteNonQuery();

                string updateCheckQuery = "SELECT MAX(appointment_id) FROM appointment_record WHERE appointment_name='" + appointmentName + "';";

                SqlCommand updateCheckCommand = new SqlCommand(updateCheckQuery, databaseConnection);
                SqlDataReader updateCheckReader = updateCheckCommand.ExecuteReader();

                if (updateCheckReader.Read())
                {
                    MessageBox.Show("Appointment: " + appointmentName + "details updated successfully.", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    updateCheckReader.Close();

                    string auditTraceQuery = "INSERT INTO audit_trace(description,traced_page,traced_task,created_date_time)"
                    + "VALUES('Appointment " + appointmentName + " updated.','Appointment Page','Update','" +
                    appointmentUpdatedDateTime + "');";

                    SqlCommand auditTraceCommand = new SqlCommand(auditTraceQuery, databaseConnection);
                    auditTraceCommand.ExecuteNonQuery();

                    string checkAuditTraceQuery = "SELECT audit_id FROM audit_trace WHERE created_date_time='" + appointmentUpdatedDateTime + "' ;";

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

                    string refreshGridQuery = "SELECT * FROM appointment_record;";

                    SqlCommand refreshGridCommand = new SqlCommand(refreshGridQuery, databaseConnection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(refreshGridCommand);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    appointmentDataGridView.DataSource = new BindingSource(dataTable, null);

                    databaseConnection.Close();
                }
                else
                {
                    MessageBox.Show("Appointment " + appointmentName + " details update failed. ", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException producedException)
            {
                MessageBox.Show("Record update failed." + Environment.NewLine + "Detailed Information: " + producedException.Message, "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void deleteAppointment()
        {
            appointmentName = AppointmentName.Text;
            appointmentDate = AppointmentDate;
            
            appointmentTimeFrom = AppointmentTimeFrom;
            appointmentTimeTo = AppointmentTimeTo;
            appointmentLocation = AppointmentLocation.Text;
            appointmentDescription = AppointmentDescription.Text;
            appointmentAdditionalNote = AppointmentAdditionalNote.Text;
            appointmentPriorityLevel = AppointmentPriorityLevel.Text;
            appointmentCategory = AppointmentCategory;
            appointmentContact = AppointmentContact.Text;
            appointmentDataGridView = AppointmentDataGridView;

            int selectedrowindex1 = appointmentDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow4 = appointmentDataGridView.Rows[selectedrowindex1];
            string appointmentIdFromGrid = Convert.ToString(selectedRow4.Cells["appointmentidDataGridViewTextBoxColumn"].Value);
            string appointmentNameFromGrid = Convert.ToString(selectedRow4.Cells["appointmentnameDataGridViewTextBoxColumn"].Value);

            try
            {
                SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;database=master");
                databaseConnection.Open();

                string deleteRecordQuery = " DELETE  FROM appointment_record WHERE appointment_id='" + appointmentIdFromGrid + "';";

                SqlCommand deleteRecordCommand = new SqlCommand(deleteRecordQuery, databaseConnection);
                deleteRecordCommand.ExecuteNonQuery();

                string checkDeletedRecord = "SELECT appointment_id FROM appointment_record WHERE appointment_name='" + appointmentNameFromGrid + "' ;";

                SqlCommand checkDeletedRecordCommand = new SqlCommand(checkDeletedRecord, databaseConnection);
                SqlDataReader deletedRecordReader = checkDeletedRecordCommand.ExecuteReader();

                switch (deletedRecordReader.HasRows)
                {
                    case false:
                        MessageBox.Show("Appointment: " + appointmentNameFromGrid + " deleted successfully. ", "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        deletedRecordReader.Close();
                        break;

                    case true:
                        MessageBox.Show("Appointment: " + appointmentNameFromGrid + " delete failed. ", "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        deletedRecordReader.Close();
                        break;
                }

                var contactDeletedtime = DateTime.Now;
                string auditTraceQuery = "INSERT INTO audit_trace(description,traced_page,traced_task,created_date_time)"
               + "VALUES('Appointment " + appointmentNameFromGrid + " deleted.','Appointment Page','Delete','" +
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

                string refreshGridQuery = "SELECT * FROM appointment_record";

                SqlCommand refreshGridCommand = new SqlCommand(refreshGridQuery, databaseConnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(refreshGridCommand);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                appointmentDataGridView.DataSource = new BindingSource(dataTable, null);

                databaseConnection.Close();
            }
            catch (SqlException producedException)
            {
                MessageBox.Show("Record delete failed." + Environment.NewLine + "Detailed Information: " + producedException.Message, "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
