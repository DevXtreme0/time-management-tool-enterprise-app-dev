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
    class TaskManagement
    {
       // private int taskId;
        private String taskName;
        private DateTimePicker taskDueDate;

        //private DateTimePicker taskDueDateTo;
        private DateTimePicker taskTimeFrom;
        private DateTimePicker taskTimeTo;
        //private DateTime taskTime;
        //private int taskDueDateTimeUsage;
        private String taskContact;
        private String taskLocation;
        private String taskDescription;
        private String taskCategory;
        private String taskAdditionalNote;
        private String taskPriorityLevel;
        private DataGridView taskDataGridView;
        private ComboBox taskContactList;

        public TextBox TaskName { get; set; }
        public DateTimePicker TaskDueDate { get; set; }
        public DateTimePicker TaskDueDateTo { get; set; }
        public DateTimePicker TaskTimeFrom { get; set; }
        public DateTimePicker TaskTimeTo { get; set; }
        public TextBox TaskLocation { get; set; }
        public TextBox TaskDescription { get; set; }
        public RichTextBox TaskAdditionalNote { get; set; }
        public ComboBox TaskPriorityLevel { get; set; }
        public ComboBox TaskContact { get; set; }

        public ComboBox TaskContactList { get; set; }
        public string TaskCategory { get; set; }
        public DataGridView TaskDataGridView { get; set; }
        public DataGridViewCellEventArgs TaskDataGridViewSelect { get; set; }

        public void viewTask()
        {
            taskContactList = TaskContactList;
            taskDataGridView = TaskDataGridView;

            try
            {
                SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;database=master");
                databaseConnection.Open();

                //contact list select
                string getContactInfoQuery = "SELECT contact_id,first_name FROM contact_person ";

                SqlCommand getContactInfoCommand = new SqlCommand(getContactInfoQuery, databaseConnection);
                getContactInfoCommand.Connection = databaseConnection;

                DataTable dataTableContactInfo = new DataTable();
                dataTableContactInfo.Load(getContactInfoCommand.ExecuteReader());

                //load contact list to the dropdown
                taskContactList.DataSource = dataTableContactInfo;
                taskContactList.DisplayMember = "first_name";
                taskContactList.ValueMember = "contact_id";

                string refreshGridQuery = "SELECT * FROM task_record";

                SqlCommand refreshGridCommand = new SqlCommand(refreshGridQuery, databaseConnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(refreshGridCommand);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                taskDataGridView.DataSource = new BindingSource(dataTable, null);

                databaseConnection.Close();
            }
            catch (SqlException producedException)
            {
                MessageBox.Show("Failed function(s) detected." + Environment.NewLine + "Detailed Information: " + producedException.Message, "Contact List Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void addTask()
        {
            taskName = TaskName.Text;
            taskDueDate = TaskDueDate;

            taskTimeFrom = TaskTimeFrom;
            taskTimeTo = TaskTimeTo;
            taskLocation = TaskLocation.Text;
            taskDescription = TaskDescription.Text;
            taskAdditionalNote = TaskAdditionalNote.Text;
            taskPriorityLevel = TaskPriorityLevel.Text;
            taskCategory = TaskCategory;
            taskContact = TaskContact.Text;
            taskDataGridView = TaskDataGridView;

            try
            {
                SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;database=master");
                databaseConnection.Open();

                var taskCreatedTime = DateTime.Now;
                //string formattedTime = time.ToString("yyyy, MM, dd, hh, mm, ss");  

                //get differenses between hours / minutes /seconds 
                DateTime startTime = Convert.ToDateTime(taskTimeFrom.Value);
                DateTime endTime = Convert.ToDateTime(taskTimeTo.Value);

                TimeSpan span = endTime.Subtract(startTime);

                int hoursDifference = span.Hours;
                int minutesDifference = span.Minutes;
                int secondsDifference = span.Seconds;

                //check whether task exist or not
                string checkExistQuery = "SELECT task_id FROM task_record WHERE task_name ='" + taskName + "';";
                SqlCommand checkExistcommand = new SqlCommand(checkExistQuery, databaseConnection);
                SqlDataReader checkExistDataReader = checkExistcommand.ExecuteReader();


                if (checkExistDataReader.Read())
                {
                    MessageBox.Show("Record data by task name already exist", "Add Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    checkExistDataReader.Close();
                    //checkExistDataReader.Dispose();
                }
                else
                {
                    checkExistDataReader.Close();

                    string taskAddQuery = "INSERT INTO task_record(task_name,task_due_date,time_from," +
                    "time_to,location,description," +
                    "category,additional_note,priority_level,created_date_time,updated_date_time,contact_name) " +
                    "VALUES('" + taskName + "','" + taskDueDate.Text + "','" + taskTimeFrom.Text + "','"
                    + taskTimeTo.Text + "','"
                    + taskLocation + "','" + taskDescription + "','"
                    + TaskCategory.ToString() + "','" + taskAdditionalNote + "','"
                    + taskPriorityLevel + "','" + taskCreatedTime + "','"
                    + taskCreatedTime + "','" + taskContact + "');";

                    SqlCommand taskAddCommand = new SqlCommand(taskAddQuery, databaseConnection);
                    taskAddCommand.ExecuteNonQuery();

                    string checkAddedRecordQuery = "SELECT task_id FROM task_record WHERE task_name='" + taskName + "' ;";

                    SqlCommand checkAddedRecordCommand = new SqlCommand(checkAddedRecordQuery, databaseConnection);
                    SqlDataReader AddedRecordReader = checkAddedRecordCommand.ExecuteReader();

                    string addStatus = "";
                    switch (AddedRecordReader.HasRows)
                    {
                        case true:
                            MessageBox.Show("Task : " + taskName + " added successfully. ", "Add Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AddedRecordReader.Close();
                            addStatus = "created successfully.";
                            break;

                        case false:
                            MessageBox.Show("Task : " + taskName + " add failed. ", "Add Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            AddedRecordReader.Close();
                            addStatus = "creation failed.";
                            break;
                    }

                    //Audit Trace Adding part
                    string auditTraceQuery = "INSERT INTO audit_trace(description,traced_page,traced_task,created_date_time)"
                       + "VALUES('Task " + taskName + "" + addStatus + "','Task Page','Add','" + taskCreatedTime + "');";

                    SqlCommand auditTraceAddCommand = new SqlCommand(auditTraceQuery, databaseConnection);
                    auditTraceAddCommand.ExecuteNonQuery();

                    string checkAuditTraceQuery = "SELECT audit_id FROM Audit_Table WHERE created_date_time='" + taskCreatedTime + "' ;";

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

                    string refreshGridQuery = "SELECT * FROM task_record";
                    SqlCommand refreshGridCommand = new SqlCommand(refreshGridQuery, databaseConnection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(refreshGridCommand);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    taskDataGridView.DataSource = new BindingSource(dataTable, null);

                    //splitted dates
                    int taskDueDay = taskDueDate.Value.Day;
                    int taskMonth = taskDueDate.Value.Month;
                    int taskYear = taskDueDate.Value.Year;

                    //adding related data to prediction
                    string taskPredictPurposeQuery = "INSERT INTO task_prediction_purpose(task_name,task_due_date,year,month,day," +
                                                            "hours_count,minutes_count,seconds_count,created_date_time,updated_date_time)"
                                                          + "VALUES('" + taskName + "','" + taskDueDate.Text + "','"
                                                          + taskYear + "','" + taskMonth + "','" + taskDueDay + "','"
                                                          + hoursDifference + "','" + minutesDifference + "','" + secondsDifference + "','"
                                                          + taskCreatedTime + "','" + taskCreatedTime + "');";

                    SqlCommand taskPredictPurposeCommand = new SqlCommand(taskPredictPurposeQuery, databaseConnection);
                    taskPredictPurposeCommand.ExecuteNonQuery();

                    databaseConnection.Close();
                }
            }
            catch (SqlException producedException)
            {
                MessageBox.Show("Failed function(s) detected." + Environment.NewLine + "Detailed Information: " + producedException.Message, "Add Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void updateTask()
        {
            taskName = TaskName.Text;
            taskDueDate = TaskDueDate;
            
            taskTimeFrom = TaskTimeFrom;
            taskTimeTo = TaskTimeTo;
            taskLocation = TaskLocation.Text;
            taskDescription = TaskDescription.Text;
            taskAdditionalNote = TaskAdditionalNote.Text;
            taskPriorityLevel = TaskPriorityLevel.Text;
            taskCategory = TaskCategory;
            taskContact = TaskContact.Text;
            taskDataGridView = TaskDataGridView;

            try
            {
                SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;database=master");
                databaseConnection.Open();

                var taskUpdatedDateTime = DateTime.Now;
                //string formattedTime = time.ToString("yyyy, MM, dd, hh, mm, ss");

                //get values from datagrid view
                int selectedrowindex = taskDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = taskDataGridView.Rows[selectedrowindex];
                string taskIdFromGrid = Convert.ToString(selectedRow.Cells["taskidDataGridViewTextBoxColumn"].Value);

                string updateRecordQuery = " Update task_record set task_name='" + taskName + "',task_due_date='" +
                    taskDueDate.Text + "',time_from='" + taskTimeFrom.Text +
                    "',time_to='" + taskTimeTo.Text + "',location='" + taskLocation + "',description='" + taskDescription +
                    "',category='" + taskCategory + "',additional_note='" + taskAdditionalNote + "',priority_level='" + taskPriorityLevel +
                    "',contact_name='" + taskContact + "',updated_date_time='" + taskUpdatedDateTime +
                    "'Where task_id='" + taskIdFromGrid + "'";

                SqlCommand updateRecordCommand = new SqlCommand(updateRecordQuery, databaseConnection);
                updateRecordCommand.ExecuteNonQuery();

                string updateCheckQuery = "SELECT MAX(task_id) FROM task_record WHERE task_name='" + taskName + "';";

                SqlCommand updateCheckCommand = new SqlCommand(updateCheckQuery, databaseConnection);
                SqlDataReader updateCheckReader = updateCheckCommand.ExecuteReader();

                if (updateCheckReader.Read())
                {
                    MessageBox.Show("Task: " + taskName + " details updated successfully.", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    updateCheckReader.Close();

                    string auditTraceQuery = "INSERT INTO audit_trace(description,traced_page,traced_task,created_date_time)"
                    + "VALUES('Task " + taskName + " updated.','Task Page','Update','" +
                    taskUpdatedDateTime + "');";

                    SqlCommand auditTraceCommand = new SqlCommand(auditTraceQuery, databaseConnection);
                    auditTraceCommand.ExecuteNonQuery();

                    string checkAuditTraceQuery = "SELECT audit_id FROM audit_trace WHERE created_date_time='" + taskUpdatedDateTime + "' ;";

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

                    string refreshGridQuery = "SELECT * FROM task_record;";

                    SqlCommand refreshGridCommand = new SqlCommand(refreshGridQuery, databaseConnection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(refreshGridCommand);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    taskDataGridView.DataSource = new BindingSource(dataTable, null);

                    databaseConnection.Close();
                }
                else
                {
                    MessageBox.Show("Task " + taskName + " details update failed. ", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException producedException)
            {
                MessageBox.Show("Record update failed." + Environment.NewLine + " Detailed Information: " + producedException.Message, "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void deleteTask()
        {
            taskName = TaskName.Text;
            taskDueDate = TaskDueDate;

            taskTimeFrom = TaskTimeFrom;
            taskTimeTo = TaskTimeTo;
            taskLocation = TaskLocation.Text;
            taskDescription = TaskDescription.Text;
            taskAdditionalNote = TaskAdditionalNote.Text;
            taskPriorityLevel = TaskPriorityLevel.Text;
            taskCategory = TaskCategory;
            taskContact = TaskContact.Text;
            taskDataGridView = TaskDataGridView;

            int selectedrowindex1 = taskDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow4 = taskDataGridView.Rows[selectedrowindex1];
            string taskIdFromGrid = Convert.ToString(selectedRow4.Cells["taskidDataGridViewTextBoxColumn"].Value);
            string taskNameFromGrid = Convert.ToString(selectedRow4.Cells["tasknameDataGridViewTextBoxColumn"].Value);

            try
            {
                SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;database=master");
                databaseConnection.Open();

                string deleteRecordQuery = " DELETE  FROM task_record WHERE task_id='" + taskIdFromGrid + "';";

                SqlCommand deleteRecordCommand = new SqlCommand(deleteRecordQuery, databaseConnection);
                deleteRecordCommand.ExecuteNonQuery();

                string checkDeletedRecord = "SELECT task_id FROM task_record WHERE task_name='" + taskNameFromGrid + "' ;";

                SqlCommand checkDeletedRecordCommand = new SqlCommand(checkDeletedRecord, databaseConnection);
                SqlDataReader deletedRecordReader = checkDeletedRecordCommand.ExecuteReader();

                switch (deletedRecordReader.HasRows)
                {
                    case false:
                        MessageBox.Show("Task: " + taskNameFromGrid + " deleted successfully. ", "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        deletedRecordReader.Close();
                        break;

                    case true:
                        MessageBox.Show("Task: " + taskNameFromGrid + " delete failed. ", "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        deletedRecordReader.Close();
                        break;
                }

                var contactDeletedtime = DateTime.Now;
                string auditTraceQuery = "INSERT INTO audit_trace(description,traced_page,traced_task,created_date_time)"
               + "VALUES('Task " + taskNameFromGrid + " deleted.','Task Page','Delete','" +
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

                string refreshGridQuery = "SELECT * FROM task_record";

                SqlCommand refreshGridCommand = new SqlCommand(refreshGridQuery, databaseConnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(refreshGridCommand);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                taskDataGridView.DataSource = new BindingSource(dataTable, null);

                databaseConnection.Close();
            }
            catch (SqlException producedException)
            {
                MessageBox.Show("Record delete failed." + Environment.NewLine + "Detailed Information: " + producedException.Message, "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
