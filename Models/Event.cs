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
    class Event
    {
        //private int eventId;
        private String eventName;
        //private DateTime eventDate;
        private DateTimePicker eventDateFrom;
        private DateTimePicker eventDateTo;
        private DateTimePicker eventTimeFrom;
        private DateTimePicker eventTimeTo;
        //private DateTime eventTime;
        private int eventDateTimeUsage;
        private String eventContact;
        private String eventLocation;
        private String eventDescription;
        private String eventCategory;
        private String eventAdditionalNote;
        private String eventPriorityLevel;
        private DataGridView eventDataGridView; 
        private ComboBox eventContactList;

        public TextBox EventName { get; set; }
        public DateTimePicker EventDateFrom { get; set; }
        public DateTimePicker EventDateTo { get; set; }
        public DateTimePicker EventTimeFrom { get; set; }
        public DateTimePicker EventTimeTo { get; set; }
        public TextBox EventLocation { get; set; }
        public TextBox EventDescription { get; set; }
        public RichTextBox EventAdditionalNote { get; set; }
        public ComboBox EventPriorityLevel { get; set; }
        public ComboBox EventContact { get; set; }

        public ComboBox EventContactList { get; set; }
        public string EventCategory { get; set; }
        public DataGridView EventDataGridView { get; set; }
        public DataGridViewCellEventArgs EventDataGridViewSelect { get; set; }
    
        public void viewEvent()
        {
            eventContactList = EventContactList;
            eventDataGridView = EventDataGridView;

            try
            {
                SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;database=master");
                databaseConnection.Open();

                //load data to contact list
                string getContactInfoQuery = "SELECT contact_id,first_name FROM contact_person ";

                SqlCommand getContactInfoCommand = new SqlCommand(getContactInfoQuery, databaseConnection);
                getContactInfoCommand.Connection = databaseConnection;

                DataTable dataTableContactInfo = new DataTable();
                dataTableContactInfo.Load(getContactInfoCommand.ExecuteReader());
                

                eventContactList.DataSource = dataTableContactInfo;
                eventContactList.DisplayMember = "first_name";
                eventContactList.ValueMember = "contact_id";

                string refreshGridQuery = "SELECT * FROM event_record";

                SqlCommand refreshGridCommand = new SqlCommand(refreshGridQuery, databaseConnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(refreshGridCommand);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                eventDataGridView.DataSource = new BindingSource(dataTable, null);

                databaseConnection.Close();
            }
            catch (SqlException producedException)
            {
                MessageBox.Show("Contact load failed." + Environment.NewLine + "Detailed Information: " + producedException.Message, "Contact List Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void addEvent()
        {
            eventName = EventName.Text;
            eventDateFrom = EventDateFrom;
            eventDateTo = EventDateTo;
            eventTimeFrom = EventTimeFrom;
            eventTimeTo = EventTimeTo;
            eventLocation = EventLocation.Text;
            eventDescription = EventDescription.Text;
            eventAdditionalNote = EventAdditionalNote.Text;
            eventPriorityLevel = EventPriorityLevel.Text;
            eventCategory = EventCategory;
            eventContact = EventContact.Text;
            eventDataGridView = EventDataGridView;

                try
                {
                    SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;database=master");
                    databaseConnection.Open();

                    var eventCreatedTime = DateTime.Now;
                    //string formattedTime = time.ToString("yyyy, MM, dd, hh, mm, ss");  

                    DateTime startTime = Convert.ToDateTime(eventTimeFrom.Value);
                    DateTime endTime = Convert.ToDateTime(eventTimeTo.Value);

                    TimeSpan span = endTime.Subtract(startTime);

                    int hoursDifference = span.Hours;
                    int minutesDifference = span.Minutes;
                    int secondsDifference = span.Seconds;


                    string checkExistQuery = "SELECT event_id FROM event_record WHERE event_name ='" + eventName + "';";
                    SqlCommand checkExistcommand = new SqlCommand(checkExistQuery, databaseConnection);
                    SqlDataReader checkExistDataReader = checkExistcommand.ExecuteReader();


                    if (checkExistDataReader.Read())
                    {
                        MessageBox.Show("Record data by event name already exist", "Add Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        checkExistDataReader.Close();
                        //checkExistDataReader.Dispose();
                    }
                    else
                    {
                        checkExistDataReader.Close();

                        string eventAddQuery = "INSERT INTO event_record(event_name,date_from,date_to," +
                        "time_from,time_to,location,description," +
                        "category,additional_note,priority_level,created_date_time,updated_date_time,contact_name) " +
                        "VALUES('" + eventName + "','" + eventDateFrom.Text + "','"
                        + eventDateTo.Text + "','" + eventTimeFrom.Text + "','"
                        + eventTimeTo.Text + "','"
                        + eventLocation + "','" + eventDescription + "','"
                        + EventCategory.ToString() + "','" + eventAdditionalNote + "','"
                        + eventPriorityLevel + "','" + eventCreatedTime + "','"
                        + eventCreatedTime + "','" + eventContact + "');";

                        SqlCommand eventAddCommand = new SqlCommand(eventAddQuery, databaseConnection);
                        eventAddCommand.ExecuteNonQuery();

                        string checkAddedRecordQuery = "SELECT event_id FROM event_record WHERE event_name='" + eventName + "' ;";

                        SqlCommand checkAddedRecordCommand = new SqlCommand(checkAddedRecordQuery, databaseConnection);
                        SqlDataReader AddedRecordReader = checkAddedRecordCommand.ExecuteReader();

                        string addStatus = "";
                        switch (AddedRecordReader.HasRows)
                        {
                            case true:
                                MessageBox.Show("Event : " + eventName + " added successfully. ", "Add Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                AddedRecordReader.Close();
                                addStatus = "created successfully.";
                                break;

                            case false:
                                MessageBox.Show("Event : " + eventName + " add failed. ", "Add Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                AddedRecordReader.Close();
                                addStatus = "creation failed.";
                                break;
                        }

                        string auditTraceQuery = "INSERT INTO audit_trace(description,traced_page,traced_task,created_date_time)"
                           + "VALUES('Event " + eventName + "" + addStatus + "','Event Page','Add','" + eventCreatedTime + "');";

                        SqlCommand auditTraceAddCommand = new SqlCommand(auditTraceQuery, databaseConnection);
                        auditTraceAddCommand.ExecuteNonQuery();

                        string checkAuditTraceQuery = "SELECT audit_id FROM audit_trace WHERE created_date_time='" + eventCreatedTime + "' ;";

                        SqlCommand checkAuditTraceCommand = new SqlCommand(checkAuditTraceQuery, databaseConnection);
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

                        string refreshGridQuery = "SELECT * FROM event_record";
                        SqlCommand refreshGridCommand = new SqlCommand(refreshGridQuery, databaseConnection);
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(refreshGridCommand);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        eventDataGridView.DataSource = new BindingSource(dataTable, null);

                        int day = eventDateFrom.Value.Day;
                        int month = eventDateFrom.Value.Month;
                        int year = eventDateFrom.Value.Year;


                        string eventPredictPurposeQuery = "INSERT INTO event_prediction_purpose(event_name,date_from,year,month,day,hours_count,minutes_count,seconds_count,created_date_time,updated_date_time)"
                           + "VALUES('" + eventName + "','" + eventDateFrom.Text + "','" + year + "','" + month + "','" + day + "','" + hoursDifference + "','" + minutesDifference + "','" + secondsDifference + "','" + eventCreatedTime + "','" + eventCreatedTime + "');";

                        SqlCommand eventPredictPurposeCommand = new SqlCommand(eventPredictPurposeQuery, databaseConnection);
                        eventPredictPurposeCommand.ExecuteNonQuery();

                        databaseConnection.Close();
                    }
                }

                catch (SqlException producedException)
                {
                    MessageBox.Show("Failed function(s) detected." + Environment.NewLine + "Detailed Information: " + producedException.Message, "Add Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }
        public void updateEvent()
        {
            eventName = EventName.Text;
            eventDateFrom = EventDateFrom;
            eventDateTo = EventDateTo;
            eventTimeFrom = EventTimeFrom;
            eventTimeTo = EventTimeTo;
            eventLocation = EventLocation.Text;
            eventDescription = EventDescription.Text;
            eventAdditionalNote = EventAdditionalNote.Text;
            eventPriorityLevel = EventPriorityLevel.Text;
            eventCategory = EventCategory;
            eventContact = EventContact.Text;
            eventDataGridView = EventDataGridView;


                try
                {
                    SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;database=master");
                    databaseConnection.Open();

                    var eventUpdatedDateTime = DateTime.Now;
                    //string formattedTime = time.ToString("yyyy, MM, dd, hh, mm, ss");

                    int selectedrowindex = eventDataGridView.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = eventDataGridView.Rows[selectedrowindex];
                    string eventIdFromGrid = Convert.ToString(selectedRow.Cells["dataGridViewTextBoxColumn1"].Value);

                    string updateRecordQuery = " Update event_record set event_name='" + eventName + "',date_from='" +
                        eventDateFrom.Text + "',date_to='" + eventDateTo.Text + "',time_from='" + eventTimeFrom.Text +
                        "',time_to='" + eventTimeTo.Text + "',location='" + eventLocation + "',description='" + eventDescription +
                        "',category='" + eventCategory + "',additional_note='" + eventAdditionalNote + "',priority_level='" + eventPriorityLevel +
                        "',contact_name='" + eventContact + "',updated_date_time='" + eventUpdatedDateTime +
                        "'Where event_id='" + eventIdFromGrid + "'";

                    SqlCommand updateRecordCommand = new SqlCommand(updateRecordQuery, databaseConnection);
                    updateRecordCommand.ExecuteNonQuery();

                    string updateCheckQuery = "SELECT MAX(event_id) FROM event_record WHERE event_name='" + eventName + "';";

                    SqlCommand updateCheckCommand = new SqlCommand(updateCheckQuery, databaseConnection);
                    SqlDataReader updateCheckReader = updateCheckCommand.ExecuteReader();

                    if (updateCheckReader.Read())
                    {
                        MessageBox.Show("Event: " + eventName + " details updated successfully.", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        updateCheckReader.Close();

                        string auditTraceQuery = "INSERT INTO audit_trace(description,traced_page,traced_task,created_date_time)"
                        + "VALUES('Event " + eventName + " updated.','Event Page','Update','" +
                        eventUpdatedDateTime + "');";

                        SqlCommand auditTraceCommand = new SqlCommand(auditTraceQuery, databaseConnection);
                        auditTraceCommand.ExecuteNonQuery();

                        string checkAuditTraceQuery = "SELECT audit_id FROM audit_trace WHERE created_date_time='" + eventUpdatedDateTime + "' ;";

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

                        string refreshGridQuery = "SELECT * FROM event_record;";

                        SqlCommand refreshGridCommand = new SqlCommand(refreshGridQuery, databaseConnection);
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(refreshGridCommand);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        eventDataGridView.DataSource = new BindingSource(dataTable, null);

                        databaseConnection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Event " + eventName + " details update failed. ", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException producedException)
                {
                    MessageBox.Show("Record update failed." + Environment.NewLine + "Detailed Information: " + producedException.Message, "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }
        public void deleteEvent()
        {
            eventName = EventName.Text;
            eventDateFrom = EventDateFrom;
            eventDateTo = EventDateTo;
            eventTimeFrom = EventTimeFrom;
            eventTimeTo = EventTimeTo;
            eventLocation = EventLocation.Text;
            eventDescription = EventDescription.Text;
            eventAdditionalNote = EventAdditionalNote.Text;
            eventPriorityLevel = EventPriorityLevel.Text;
            eventCategory = EventCategory;
            eventContact = EventContact.Text;
            eventDataGridView = EventDataGridView;

            int selectedrowindex1 = eventDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow4 = eventDataGridView.Rows[selectedrowindex1];
            string eventIdFromGrid = Convert.ToString(selectedRow4.Cells["dataGridViewTextBoxColumn1"].Value);
            string eventNameFromGrid = Convert.ToString(selectedRow4.Cells["dataGridViewTextBoxColumn2"].Value);

            try
            {
                SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;database=master");
                databaseConnection.Open();

                string deleteRecordQuery = " DELETE  FROM event_record WHERE event_id='" + eventIdFromGrid + "';";

                SqlCommand deleteRecordCommand = new SqlCommand(deleteRecordQuery, databaseConnection);
                deleteRecordCommand.ExecuteNonQuery();

                string checkDeletedRecord = "SELECT event_id FROM event_record WHERE event_name='" + eventNameFromGrid + "' ;";

                SqlCommand checkDeletedRecordCommand = new SqlCommand(checkDeletedRecord, databaseConnection);
                SqlDataReader deletedRecordReader = checkDeletedRecordCommand.ExecuteReader();

                switch (deletedRecordReader.HasRows)
                {
                    case false:
                        MessageBox.Show("Event: " + eventNameFromGrid + " deleted successfully. ", "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        deletedRecordReader.Close();
                        break;

                    case true:
                        MessageBox.Show("Event: " + eventNameFromGrid + " delete failed. ", "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        deletedRecordReader.Close();
                        break;
                }

                var contactDeletedtime = DateTime.Now;
                string auditTraceQuery = "INSERT INTO audit_trace(description,traced_page,traced_task,created_date_time)"
               + "VALUES('Event " + eventNameFromGrid + " deleted.','Event Page','Delete','" +
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

                string refreshGridQuery = "SELECT * FROM event_record";

                SqlCommand refreshGridCommand = new SqlCommand(refreshGridQuery, databaseConnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(refreshGridCommand);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                eventDataGridView.DataSource = new BindingSource(dataTable, null);

                databaseConnection.Close();
            }
            catch (SqlException producedException)
            {
                MessageBox.Show("Record delete failed." + Environment.NewLine + "Detailed Information: " + producedException.Message, "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
    }
}
