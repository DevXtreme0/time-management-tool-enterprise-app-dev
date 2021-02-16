using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkTwo.Models
{
    class Report
    {
        //private DateTime dateDuration;
        //private String reportType;
        //private DateTime reportCreateTime;
        //private String reportName;

        public String fromDateInModel;
        public String toDateInModel;
        public String reportTypeInModel;
        public String filePathInModel;


        public void createEventReport()
        {
            try
            {
                SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;database=master");
                databaseConnection.Open();

                string fromDate = fromDateInModel;
                string toDate = toDateInModel;
                string reportCreatedDateTime = DateTime.Now.ToString();

                string executeQuery = " SELECT * FROM event_record WHERE created_date_time BETWEEN '" + fromDate + "' AND '" + toDate + "' ORDER BY created_date_time ASC;";
                
                SqlCommand commandTo = new SqlCommand(executeQuery, databaseConnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(commandTo);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                String filePath = filePathInModel;
                StreamWriter textFile = new StreamWriter(filePath, true);

                textFile.Write(Environment.NewLine);
                textFile.Write("____________________Time Management Tool____________________");
                textFile.Write(Environment.NewLine);
                textFile.Write(Environment.NewLine);
                textFile.Write("Filtered Information ");
                textFile.Write(Environment.NewLine);
                textFile.Write(Environment.NewLine);
                textFile.Write("From Date: " + fromDate);
                textFile.Write(Environment.NewLine);
                textFile.Write("To Date: " + toDate);
                textFile.Write(Environment.NewLine);
                textFile.Write("Selected Report Type: " + reportTypeInModel);
                textFile.Write(Environment.NewLine);
                textFile.Write(Environment.NewLine);
                textFile.Write("____________________________________________________________");
                textFile.Write(Environment.NewLine);
                textFile.Write(Environment.NewLine);
                textFile.Write("Report Created Date & Time is: " + DateTime.Now.ToString());
                textFile.Write(Environment.NewLine);
                textFile.Write(Environment.NewLine);
                textFile.Write("____________________________________________________________");
                textFile.Write(Environment.NewLine);
                textFile.Write(Environment.NewLine);

                textFile.Write("| Id | Name | Date From | Date to | Time from | Time to | Location | Description " +
                    "| Category | Additional Note | Priority Level |  Created Date & Time | Updated Date &  Time | Hours Count " +
                    "| Minutes Count | Seconds Count|");
                textFile.Write(Environment.NewLine);
                foreach (DataRow row in dataTable.Rows)
                {
                    
                    textFile.Write(Environment.NewLine);
                    object[] availableRows = row.ItemArray;
                    int i;
                    for (i = 0; i < availableRows.Length - 1; i++)
                    {
                        textFile.Write(availableRows[i].ToString() + " | ");
                    }
                    textFile.WriteLine(availableRows[i].ToString() + Environment.NewLine);
                }


                textFile.Write(Environment.NewLine);
                textFile.Write(Environment.NewLine);
                textFile.Write("____________________End of contents____________________");
                textFile.Write(Environment.NewLine);

                textFile.Flush();
                textFile.Close();
               
                MessageBox.Show(" Event report downloaded successfully.", "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string auditTraceQuery = "INSERT INTO audit_trace(description,traced_page,traced_task,created_date_time)"
                       + "VALUES('Event report downloaded','Reports Page','Download','" + reportCreatedDateTime + "');";

                SqlCommand auditTraceAddCommand = new SqlCommand(auditTraceQuery, databaseConnection);
                auditTraceAddCommand.ExecuteNonQuery();

                string checkAuditTraceQuery = "SELECT audit_id FROM audit_trace WHERE created_date_time='" + reportCreatedDateTime + "' ;";

                SqlCommand checkAuditTraceCommand = new SqlCommand(checkAuditTraceQuery, databaseConnection);
                SqlDataReader AuditTraceReader = checkAuditTraceCommand.ExecuteReader();

                switch (AuditTraceReader.HasRows)
                {
                    case true:
                        Console.WriteLine("Auidt trace for download task created successfully.");
                        AuditTraceReader.Close();
                        break;

                    case false:
                        Console.WriteLine("Audit trace for download task creation failed.");
                        AuditTraceReader.Close();
                        break;

                }
                        databaseConnection.Close();
            }
            catch (SqlException producedException)
            {

                MessageBox.Show("Failed function(s) detected." + Environment.NewLine + "Detailed Information: " + producedException.Message, "Download Status", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void createAppointmentReport()
        {

            try
            {
                SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;database=master");
                databaseConnection.Open();

                //get filtered dates
                string fromDate = fromDateInModel;
                string toDate = toDateInModel;
                string reportCreatedDateTime = DateTime.Now.ToString();

                string executeQuery = " SELECT * FROM appointment_record WHERE created_date_time BETWEEN '" + fromDate + "' AND '" + toDate + "' ORDER BY created_date_time ASC;";

                SqlCommand commandTo = new SqlCommand(executeQuery, databaseConnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(commandTo);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                //filepath cheks here
                String filePath = filePathInModel;
                StreamWriter textFile = new StreamWriter(filePath, true);

                //write ti file
                textFile.Write(Environment.NewLine);
                textFile.Write("____________________Time Management Tool____________________");
                textFile.Write(Environment.NewLine);
                textFile.Write(Environment.NewLine);
                textFile.Write("Filtered Information ");
                textFile.Write(Environment.NewLine);
                textFile.Write(Environment.NewLine);
                textFile.Write("From Date: " + fromDate);
                textFile.Write(Environment.NewLine);
                textFile.Write("To Date: " + toDate);
                textFile.Write(Environment.NewLine);
                textFile.Write("Selected Report Type: " + reportTypeInModel);
                textFile.Write(Environment.NewLine);
                textFile.Write(Environment.NewLine);
                textFile.Write("____________________________________________________________");
                textFile.Write(Environment.NewLine);
                textFile.Write(Environment.NewLine);
                textFile.Write("Report Created Date & Time is: " + DateTime.Now.ToString());
                textFile.Write(Environment.NewLine);
                textFile.Write(Environment.NewLine);
                textFile.Write("____________________________________________________________");
                textFile.Write(Environment.NewLine);
                textFile.Write(Environment.NewLine);

                textFile.Write("| Id | Name | Date | Time from | Time to | Location | Description " +
                    "| Category | Additional Note | Priority Level |  Created Date & Time | Updated Date &  Time | Hours Count " +
                    "| Minutes Count | Seconds Count|");
                textFile.Write(Environment.NewLine);
                foreach (DataRow row in dataTable.Rows)
                {

                    textFile.Write(Environment.NewLine);
                    object[] availableRows = row.ItemArray;
                    int i;
                    for (i = 0; i < availableRows.Length - 1; i++)
                    {
                        textFile.Write(availableRows[i].ToString() + " | ");
                    }
                    textFile.WriteLine(availableRows[i].ToString() + Environment.NewLine);
                }


                textFile.Write(Environment.NewLine);
                textFile.Write(Environment.NewLine);
                textFile.Write("____________________End of contents____________________");
                textFile.Write(Environment.NewLine);

                textFile.Flush();
                textFile.Close();

                MessageBox.Show(" Appointment report downloaded successfully.", "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string auditTraceQuery = "INSERT INTO audit_trace(description,traced_page,traced_task,created_date_time)"
                       + "VALUES('Appointment report downloaded','Reports Page','Download','" + reportCreatedDateTime + "');";

                SqlCommand auditTraceAddCommand = new SqlCommand(auditTraceQuery, databaseConnection);
                auditTraceAddCommand.ExecuteNonQuery();

                string checkAuditTraceQuery = "SELECT audit_id FROM audit_trace WHERE created_date_time='" + reportCreatedDateTime + "' ;";

                SqlCommand checkAuditTraceCommand = new SqlCommand(checkAuditTraceQuery, databaseConnection);
                SqlDataReader AuditTraceReader = checkAuditTraceCommand.ExecuteReader();

                switch (AuditTraceReader.HasRows)
                {
                    case true:
                        Console.WriteLine("Auidt trace for download task created successfully.");
                        AuditTraceReader.Close();
                        break;

                    case false:
                        Console.WriteLine("Audit trace for download task creation failed.");
                        AuditTraceReader.Close();
                        break;

                }
                databaseConnection.Close();
            }
            catch (SqlException producedException)
            {

                MessageBox.Show("Failed function(s) detected." + Environment.NewLine + "Detailed Information: " + producedException.Message, "Download Status", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void createTaskReport()
        {

            try
            {
                SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;database=master");
                databaseConnection.Open();

                string fromDate = fromDateInModel;
                string toDate = toDateInModel;
                string reportCreatedDateTime = DateTime.Now.ToString();

                string executeQuery = " SELECT * FROM task_record WHERE created_date_time BETWEEN '" + fromDate + "' AND '" + toDate + "' ORDER BY created_date_time ASC;";

                SqlCommand commandTo = new SqlCommand(executeQuery, databaseConnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(commandTo);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                String filePath = filePathInModel;
                StreamWriter textFile = new StreamWriter(filePath, true);

                textFile.Write(Environment.NewLine);
                textFile.Write("____________________Time Management Tool____________________");
                textFile.Write(Environment.NewLine);
                textFile.Write(Environment.NewLine);
                textFile.Write("Filtered Information ");
                textFile.Write(Environment.NewLine);
                textFile.Write(Environment.NewLine);
                textFile.Write("From Date: " + fromDate);
                textFile.Write(Environment.NewLine);
                textFile.Write("To Date: " + toDate);
                textFile.Write(Environment.NewLine);
                textFile.Write("Selected Report Type: " + reportTypeInModel);
                textFile.Write(Environment.NewLine);
                textFile.Write(Environment.NewLine);
                textFile.Write("____________________________________________________________");
                textFile.Write(Environment.NewLine);
                textFile.Write(Environment.NewLine);
                textFile.Write("Report Created Date & Time is: " + DateTime.Now.ToString());
                textFile.Write(Environment.NewLine);
                textFile.Write(Environment.NewLine);
                textFile.Write("____________________________________________________________");
                textFile.Write(Environment.NewLine);
                textFile.Write(Environment.NewLine);

                textFile.Write("| Id | Name | Due Date | Time from | Time to | Location | Description " +
                    "| Category | Additional Note | Priority Level |  Created Date & Time | Updated Date & Time | Hours Count " +
                    "| Minutes Count | Seconds Count |");
                textFile.Write(Environment.NewLine);
                foreach (DataRow row in dataTable.Rows)
                {

                    textFile.Write(Environment.NewLine);
                    object[] availableRows = row.ItemArray;
                    int i;
                    for (i = 0; i < availableRows.Length - 1; i++)
                    {
                        textFile.Write(availableRows[i].ToString() + " | ");
                    }
                    textFile.WriteLine(availableRows[i].ToString() + Environment.NewLine);
                }


                textFile.Write(Environment.NewLine);
                textFile.Write(Environment.NewLine);
                textFile.Write("____________________End of contents____________________");
                textFile.Write(Environment.NewLine);

                textFile.Flush();
                textFile.Close();

                MessageBox.Show(" Task report downloaded successfully.", "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string auditTraceQuery = "INSERT INTO audit_trace(description,traced_page,traced_task,created_date_time)"
                       + "VALUES('Task report downloaded','Reports Page','Download','" + reportCreatedDateTime + "');";

                SqlCommand auditTraceAddCommand = new SqlCommand(auditTraceQuery, databaseConnection);
                auditTraceAddCommand.ExecuteNonQuery();

                string checkAuditTraceQuery = "SELECT audit_id FROM audit_trace WHERE created_date_time='" + reportCreatedDateTime + "' ;";

                SqlCommand checkAuditTraceCommand = new SqlCommand(checkAuditTraceQuery, databaseConnection);
                SqlDataReader AuditTraceReader = checkAuditTraceCommand.ExecuteReader();

                switch (AuditTraceReader.HasRows)
                {
                    case true:
                        Console.WriteLine("Auidt trace for download task created successfully.");
                        AuditTraceReader.Close();
                        break;

                    case false:
                        Console.WriteLine("Audit trace for download task creation failed.");
                        AuditTraceReader.Close();
                        break;

                }
                databaseConnection.Close();
            }
            catch (SqlException producedException)
            {

                MessageBox.Show("Failed function(s) detected." + Environment.NewLine + "Detailed Information: " + producedException.Message, "Download Status", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
