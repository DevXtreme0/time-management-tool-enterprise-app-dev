using System;
using System.Windows.Forms;
using CourseWorkTwo.Models;

namespace CourseWorkTwo.Forms
{
    public partial class AuditTraceForm : UserControl
    {
        AuditTrace alignTo = new AuditTrace();
        public AuditTraceForm()
        {
            InitializeComponent();

            alignTo.AuditTraceDataGridView = auditTraceDataGridView;
            alignTo.loadAuditTraceRecords();
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            alignTo.AuditTraceDataGridView = auditTraceDataGridView;
            alignTo.FilePath = fileSavePathText.Text;

            alignTo.refreshAuditTraceRecords();
        }
    }
}
