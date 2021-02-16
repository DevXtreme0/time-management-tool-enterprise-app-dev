namespace CourseWorkTwo.Forms
{
    partial class AuditTraceForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.auditTraceDescLabel = new System.Windows.Forms.Label();
            this.auditTraceHeadingLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.auditTraceDataGridView = new System.Windows.Forms.DataGridView();
            this.auditidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tracedpageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tracedtaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createddatetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.audittraceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeMgtDB = new CourseWorkTwo.TimeMgtDB();
            this.audit_traceTableAdapter = new CourseWorkTwo.TimeMgtDBTableAdapters.audit_traceTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sampleFileSavePathLabel = new System.Windows.Forms.Label();
            this.fileSavePathText = new System.Windows.Forms.TextBox();
            this.fileSavePathLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.auditTraceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.audittraceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeMgtDB)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // auditTraceDescLabel
            // 
            this.auditTraceDescLabel.AutoSize = true;
            this.auditTraceDescLabel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.auditTraceDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auditTraceDescLabel.ForeColor = System.Drawing.Color.White;
            this.auditTraceDescLabel.Location = new System.Drawing.Point(38, 42);
            this.auditTraceDescLabel.Name = "auditTraceDescLabel";
            this.auditTraceDescLabel.Size = new System.Drawing.Size(301, 18);
            this.auditTraceDescLabel.TabIndex = 3;
            this.auditTraceDescLabel.Text = "View you system audit trace from here.";
            // 
            // auditTraceHeadingLabel
            // 
            this.auditTraceHeadingLabel.AutoSize = true;
            this.auditTraceHeadingLabel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.auditTraceHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auditTraceHeadingLabel.ForeColor = System.Drawing.Color.White;
            this.auditTraceHeadingLabel.Location = new System.Drawing.Point(36, 5);
            this.auditTraceHeadingLabel.Name = "auditTraceHeadingLabel";
            this.auditTraceHeadingLabel.Size = new System.Drawing.Size(202, 25);
            this.auditTraceHeadingLabel.TabIndex = 2;
            this.auditTraceHeadingLabel.Text = "System Audit Trace";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(546, 209);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(115, 46);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh and Download";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // auditTraceDataGridView
            // 
            this.auditTraceDataGridView.AllowUserToAddRows = false;
            this.auditTraceDataGridView.AllowUserToDeleteRows = false;
            this.auditTraceDataGridView.AllowUserToOrderColumns = true;
            this.auditTraceDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.auditTraceDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.auditTraceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.auditTraceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.auditidDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.tracedpageDataGridViewTextBoxColumn,
            this.tracedtaskDataGridViewTextBoxColumn,
            this.createddatetimeDataGridViewTextBoxColumn});
            this.auditTraceDataGridView.DataSource = this.audittraceBindingSource;
            this.auditTraceDataGridView.Location = new System.Drawing.Point(50, 279);
            this.auditTraceDataGridView.MultiSelect = false;
            this.auditTraceDataGridView.Name = "auditTraceDataGridView";
            this.auditTraceDataGridView.ReadOnly = true;
            this.auditTraceDataGridView.RowHeadersVisible = false;
            this.auditTraceDataGridView.RowHeadersWidth = 51;
            this.auditTraceDataGridView.RowTemplate.Height = 24;
            this.auditTraceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.auditTraceDataGridView.Size = new System.Drawing.Size(611, 482);
            this.auditTraceDataGridView.TabIndex = 5;
            // 
            // auditidDataGridViewTextBoxColumn
            // 
            this.auditidDataGridViewTextBoxColumn.DataPropertyName = "audit_id";
            this.auditidDataGridViewTextBoxColumn.HeaderText = "Audit Id";
            this.auditidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.auditidDataGridViewTextBoxColumn.Name = "auditidDataGridViewTextBoxColumn";
            this.auditidDataGridViewTextBoxColumn.ReadOnly = true;
            this.auditidDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 280;
            // 
            // tracedpageDataGridViewTextBoxColumn
            // 
            this.tracedpageDataGridViewTextBoxColumn.DataPropertyName = "traced_page";
            this.tracedpageDataGridViewTextBoxColumn.HeaderText = "Traced Page";
            this.tracedpageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tracedpageDataGridViewTextBoxColumn.Name = "tracedpageDataGridViewTextBoxColumn";
            this.tracedpageDataGridViewTextBoxColumn.ReadOnly = true;
            this.tracedpageDataGridViewTextBoxColumn.Width = 125;
            // 
            // tracedtaskDataGridViewTextBoxColumn
            // 
            this.tracedtaskDataGridViewTextBoxColumn.DataPropertyName = "traced_task";
            this.tracedtaskDataGridViewTextBoxColumn.HeaderText = "Traced Task";
            this.tracedtaskDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tracedtaskDataGridViewTextBoxColumn.Name = "tracedtaskDataGridViewTextBoxColumn";
            this.tracedtaskDataGridViewTextBoxColumn.ReadOnly = true;
            this.tracedtaskDataGridViewTextBoxColumn.Width = 125;
            // 
            // createddatetimeDataGridViewTextBoxColumn
            // 
            this.createddatetimeDataGridViewTextBoxColumn.DataPropertyName = "created_date_time";
            this.createddatetimeDataGridViewTextBoxColumn.HeaderText = "Created Date & Time";
            this.createddatetimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createddatetimeDataGridViewTextBoxColumn.Name = "createddatetimeDataGridViewTextBoxColumn";
            this.createddatetimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.createddatetimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // audittraceBindingSource
            // 
            this.audittraceBindingSource.DataMember = "audit_trace";
            this.audittraceBindingSource.DataSource = this.timeMgtDB;
            // 
            // timeMgtDB
            // 
            this.timeMgtDB.DataSetName = "TimeMgtDB";
            this.timeMgtDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // audit_traceTableAdapter
            // 
            this.audit_traceTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.sampleFileSavePathLabel);
            this.panel1.Controls.Add(this.fileSavePathText);
            this.panel1.Controls.Add(this.fileSavePathLabel);
            this.panel1.Location = new System.Drawing.Point(50, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 100);
            this.panel1.TabIndex = 6;
            // 
            // sampleFileSavePathLabel
            // 
            this.sampleFileSavePathLabel.AutoSize = true;
            this.sampleFileSavePathLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sampleFileSavePathLabel.Location = new System.Drawing.Point(24, 65);
            this.sampleFileSavePathLabel.Name = "sampleFileSavePathLabel";
            this.sampleFileSavePathLabel.Size = new System.Drawing.Size(252, 17);
            this.sampleFileSavePathLabel.TabIndex = 13;
            this.sampleFileSavePathLabel.Text = "C:/Users/user name/folder/file name.txt";
            // 
            // fileSavePathText
            // 
            this.fileSavePathText.Location = new System.Drawing.Point(27, 30);
            this.fileSavePathText.Name = "fileSavePathText";
            this.fileSavePathText.Size = new System.Drawing.Size(553, 22);
            this.fileSavePathText.TabIndex = 11;
            this.fileSavePathText.Text = "C:/Users/Planet Saturn/Documents/aa6.txt";
            // 
            // fileSavePathLabel
            // 
            this.fileSavePathLabel.AutoSize = true;
            this.fileSavePathLabel.Location = new System.Drawing.Point(24, 10);
            this.fileSavePathLabel.Name = "fileSavePathLabel";
            this.fileSavePathLabel.Size = new System.Drawing.Size(100, 17);
            this.fileSavePathLabel.TabIndex = 12;
            this.fileSavePathLabel.Text = "File save path:";
            // 
            // AuditTraceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.auditTraceDataGridView);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.auditTraceDescLabel);
            this.Controls.Add(this.auditTraceHeadingLabel);
            this.Name = "AuditTraceForm";
            this.Size = new System.Drawing.Size(720, 800);
            ((System.ComponentModel.ISupportInitialize)(this.auditTraceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.audittraceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeMgtDB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label auditTraceDescLabel;
        private System.Windows.Forms.Label auditTraceHeadingLabel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridView auditTraceDataGridView;
        private System.Windows.Forms.BindingSource audittraceBindingSource;
        private TimeMgtDB timeMgtDB;
        private TimeMgtDBTableAdapters.audit_traceTableAdapter audit_traceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tracedpageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tracedtaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createddatetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label sampleFileSavePathLabel;
        private System.Windows.Forms.TextBox fileSavePathText;
        private System.Windows.Forms.Label fileSavePathLabel;
    }
}
