using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkTwo.Models
{
    class AuditTrace
    {
        private string filePath;

        private DataGridView auditTraceDataGridView;
        public DataGridView AuditTraceDataGridView { get; set; }
        public string FilePath { get; set; }

        
        public void loadAuditTraceRecords()
        {
            auditTraceDataGridView = AuditTraceDataGridView;

            try
            {
                SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;database=master");
                databaseConnection.Open();


                string refreshGridQuery = "SELECT * FROM audit_trace ORDER BY created_date_time DESC";

                SqlCommand refreshGridCommand = new SqlCommand(refreshGridQuery, databaseConnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(refreshGridCommand);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                auditTraceDataGridView.DataSource = new BindingSource(dataTable, null);

                var auditTraceViewedDateTime = DateTime.Now;

                string auditTraceQuery = "INSERT INTO audit_trace(description,traced_page,traced_task,created_date_time)"
                      + "VALUES('Audit trace records viewed.','Audit Trace Page','View','" + auditTraceViewedDateTime + "');";

                SqlCommand auditTraceAddCommand = new SqlCommand(auditTraceQuery, databaseConnection);
                auditTraceAddCommand.ExecuteNonQuery();

                string checkAuditTraceQuery = "SELECT audit_id FROM audit_trace WHERE created_date_time='" + auditTraceViewedDateTime + "' ;";

                SqlCommand checkAuditTraceCommand = new SqlCommand(checkAuditTraceQuery, databaseConnection);
                SqlDataReader AuditTraceReader = checkAuditTraceCommand.ExecuteReader();

                switch (AuditTraceReader.HasRows)
                {
                    case true:
                        Console.WriteLine("Auidt trace for audit view task created successfully.");
                        AuditTraceReader.Close();
                        break;

                    case false:
                        Console.WriteLine("Audit trace for audit view task creation failed.");
                        AuditTraceReader.Close();
                        break;
                }

                databaseConnection.Close();
            }
            catch (SqlException producedException)
            {
                MessageBox.Show("Failed function(s) detected." + Environment.NewLine + "Detailed Information: " + producedException.Message, "Contact List Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void refreshAuditTraceRecords()
        {
            auditTraceDataGridView = AuditTraceDataGridView;

            try
            {
                SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;database=master");
                databaseConnection.Open();

                //refresh datagrid view when start the program
                string refreshGridQuery = "SELECT * FROM audit_trace ORDER BY created_date_time DESC";

                SqlCommand refreshGridCommand = new SqlCommand(refreshGridQuery, databaseConnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(refreshGridCommand);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                auditTraceDataGridView.DataSource = new BindingSource(dataTable, null);

                var auditTraceViewedDateTime = DateTime.Now;

                MessageBox.Show("Audit trace refreshed successfully.", "Refresh Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //add to the audt trace 
                string auditTraceQuery = "INSERT INTO audit_trace(description,traced_page,traced_task,created_date_time)"
                      + "VALUES('Audit trace records refreshed and viewed.','Audit Trace Page','View','" + auditTraceViewedDateTime + "');";

                SqlCommand auditTraceAddCommand = new SqlCommand(auditTraceQuery, databaseConnection);
                auditTraceAddCommand.ExecuteNonQuery();

                string checkAuditTraceQuery = "SELECT audit_id FROM audit_trace WHERE created_date_time='" + auditTraceViewedDateTime + "' ;";

                SqlCommand checkAuditTraceCommand = new SqlCommand(checkAuditTraceQuery, databaseConnection);
                SqlDataReader AuditTraceReader = checkAuditTraceCommand.ExecuteReader();

                switch (AuditTraceReader.HasRows)
                {
                    case true:
                        Console.WriteLine("Auidt trace for audit refresh task created successfully.");
                        AuditTraceReader.Close();
                        break;

                    case false:
                        Console.WriteLine("Audit trace for audit refresh task creation failed.");
                        AuditTraceReader.Close();
                        break;
                }

                

                    Thread t1 = new Thread(new ThreadStart(downloadAuditTraceReport));
                    t1.Start();



                
                databaseConnection.Close();
            }
            catch (SqlException producedException)
            {
                MessageBox.Show("Failed function(s) detected." + Environment.NewLine + "Detailed Information: " + producedException.Message, "Contact List Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void downloadAuditTraceReport()
        {
            try
            {
                SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;database=master");
                databaseConnection.Open();

                
                string reportCreatedDateTime = DateTime.Now.ToString();

                string executeQuery = " SELECT * FROM audit_trace  ORDER BY created_date_time ASC;";

                SqlCommand commandTo = new SqlCommand(executeQuery, databaseConnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(commandTo);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);


                filePath = FilePath; 
                StreamWriter textFile = new StreamWriter(filePath, true);

                textFile.Write(Environment.NewLine);
                textFile.Write("____________________Time Management Tool____________________");
                textFile.Write(Environment.NewLine);
                textFile.Write(Environment.NewLine);
                
                textFile.Write(Environment.NewLine);
                textFile.Write(Environment.NewLine);
                
                textFile.Write(Environment.NewLine);
               
                textFile.Write(Environment.NewLine);
                textFile.Write("Audit Trace Report ");
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

                textFile.Write("| Id | Description | Traced Page | Traced Task | Created Date & Time |");
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
               
                databaseConnection.Close();
            }
            catch (SqlException producedException)
            {

                MessageBox.Show("Failed function(s) detected." + Environment.NewLine + "Detailed Information: " + producedException.Message, "Download Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
