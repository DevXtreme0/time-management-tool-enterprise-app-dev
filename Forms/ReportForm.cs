using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using CourseWorkTwo.Models;

namespace CourseWorkTwo.Forms
{
    public partial class ReportForm : UserControl
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void reportDownloadButton_Click(object sender, EventArgs e)
        {

            Report use = new Report();

            use.fromDateInModel = reportFromDatePicker.Text;
            use.toDateInModel = reportToDatePicker.Text;
            use.reportTypeInModel = reportTypeComboBox.Text;
            use.filePathInModel = fileSavePathText.Text;

            
                       
               if (reportTypeComboBox.Text == "Event Report")
                {
                          use.createEventReport();    
                }
                else if (reportTypeComboBox.Text == "Appointment Report")
                {
                use.createAppointmentReport();
                }
                else if (reportTypeComboBox.Text == "Task Report")
                {
                use.createTaskReport(); 
                }
                else if (reportTypeComboBox.SelectedIndex == -1 || reportTypeComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Report Type Rrquired.", "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
              else if (fileSavePathText.Text.Length==0)
            {
                MessageBox.Show("File Save Path Required.", "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                else
                {
                    MessageBox.Show("Report save failed.", "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }           
        }

      
    }
}
