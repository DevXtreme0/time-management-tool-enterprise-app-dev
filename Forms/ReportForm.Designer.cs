namespace CourseWorkTwo.Forms
{
    partial class ReportForm
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
            this.reportHeadingLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportFieldsOutline = new System.Windows.Forms.Panel();
            this.sampleFileSavePathLabel = new System.Windows.Forms.Label();
            this.fileSavePathLabel = new System.Windows.Forms.Label();
            this.fileSavePathText = new System.Windows.Forms.TextBox();
            this.reportTypeComboBox = new System.Windows.Forms.ComboBox();
            this.reportTypeLabel = new System.Windows.Forms.Label();
            this.reportFromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.reportToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.reportToDLabel = new System.Windows.Forms.Label();
            this.reportFromDLabel = new System.Windows.Forms.Label();
            this.reportDownloadButton = new System.Windows.Forms.Button();
            this.reportFieldsOutline.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportHeadingLabel
            // 
            this.reportHeadingLabel.AutoSize = true;
            this.reportHeadingLabel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.reportHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportHeadingLabel.ForeColor = System.Drawing.Color.White;
            this.reportHeadingLabel.Location = new System.Drawing.Point(36, 5);
            this.reportHeadingLabel.Name = "reportHeadingLabel";
            this.reportHeadingLabel.Size = new System.Drawing.Size(176, 25);
            this.reportHeadingLabel.TabIndex = 0;
            this.reportHeadingLabel.Text = "Report Download";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage your reports from here.";
            // 
            // reportFieldsOutline
            // 
            this.reportFieldsOutline.BackColor = System.Drawing.SystemColors.Control;
            this.reportFieldsOutline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportFieldsOutline.Controls.Add(this.sampleFileSavePathLabel);
            this.reportFieldsOutline.Controls.Add(this.fileSavePathLabel);
            this.reportFieldsOutline.Controls.Add(this.fileSavePathText);
            this.reportFieldsOutline.Controls.Add(this.reportTypeComboBox);
            this.reportFieldsOutline.Controls.Add(this.reportTypeLabel);
            this.reportFieldsOutline.Controls.Add(this.reportFromDatePicker);
            this.reportFieldsOutline.Controls.Add(this.reportToDatePicker);
            this.reportFieldsOutline.Controls.Add(this.reportToDLabel);
            this.reportFieldsOutline.Controls.Add(this.reportFromDLabel);
            this.reportFieldsOutline.Location = new System.Drawing.Point(53, 83);
            this.reportFieldsOutline.Name = "reportFieldsOutline";
            this.reportFieldsOutline.Size = new System.Drawing.Size(634, 281);
            this.reportFieldsOutline.TabIndex = 2;
            // 
            // sampleFileSavePathLabel
            // 
            this.sampleFileSavePathLabel.AutoSize = true;
            this.sampleFileSavePathLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sampleFileSavePathLabel.Location = new System.Drawing.Point(25, 218);
            this.sampleFileSavePathLabel.Name = "sampleFileSavePathLabel";
            this.sampleFileSavePathLabel.Size = new System.Drawing.Size(252, 17);
            this.sampleFileSavePathLabel.TabIndex = 10;
            this.sampleFileSavePathLabel.Text = "C:/Users/user name/folder/file name.txt";
            // 
            // fileSavePathLabel
            // 
            this.fileSavePathLabel.AutoSize = true;
            this.fileSavePathLabel.Location = new System.Drawing.Point(25, 163);
            this.fileSavePathLabel.Name = "fileSavePathLabel";
            this.fileSavePathLabel.Size = new System.Drawing.Size(100, 17);
            this.fileSavePathLabel.TabIndex = 9;
            this.fileSavePathLabel.Text = "File save path:";
            // 
            // fileSavePathText
            // 
            this.fileSavePathText.Location = new System.Drawing.Point(28, 183);
            this.fileSavePathText.Name = "fileSavePathText";
            this.fileSavePathText.Size = new System.Drawing.Size(553, 22);
            this.fileSavePathText.TabIndex = 8;
            this.fileSavePathText.Text = "C:/Users/Planet Saturn/Documents/aa6.txt";
            // 
            // reportTypeComboBox
            // 
            this.reportTypeComboBox.FormattingEnabled = true;
            this.reportTypeComboBox.Items.AddRange(new object[] {
            "-- Select Report Type --",
            "Event Report",
            "Appointment Report",
            "Task Report"});
            this.reportTypeComboBox.Location = new System.Drawing.Point(28, 113);
            this.reportTypeComboBox.Name = "reportTypeComboBox";
            this.reportTypeComboBox.Size = new System.Drawing.Size(200, 24);
            this.reportTypeComboBox.TabIndex = 7;
            // 
            // reportTypeLabel
            // 
            this.reportTypeLabel.AutoSize = true;
            this.reportTypeLabel.Location = new System.Drawing.Point(25, 93);
            this.reportTypeLabel.Name = "reportTypeLabel";
            this.reportTypeLabel.Size = new System.Drawing.Size(146, 17);
            this.reportTypeLabel.TabIndex = 6;
            this.reportTypeLabel.Text = "General Report Type:";
            // 
            // reportFromDatePicker
            // 
            this.reportFromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.reportFromDatePicker.Location = new System.Drawing.Point(28, 43);
            this.reportFromDatePicker.Name = "reportFromDatePicker";
            this.reportFromDatePicker.Size = new System.Drawing.Size(200, 22);
            this.reportFromDatePicker.TabIndex = 5;
            // 
            // reportToDatePicker
            // 
            this.reportToDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.reportToDatePicker.Location = new System.Drawing.Point(381, 43);
            this.reportToDatePicker.Name = "reportToDatePicker";
            this.reportToDatePicker.Size = new System.Drawing.Size(200, 22);
            this.reportToDatePicker.TabIndex = 4;
            // 
            // reportToDLabel
            // 
            this.reportToDLabel.AutoSize = true;
            this.reportToDLabel.Location = new System.Drawing.Point(378, 23);
            this.reportToDLabel.Name = "reportToDLabel";
            this.reportToDLabel.Size = new System.Drawing.Size(63, 17);
            this.reportToDLabel.TabIndex = 2;
            this.reportToDLabel.Text = "To Date:";
            // 
            // reportFromDLabel
            // 
            this.reportFromDLabel.AutoSize = true;
            this.reportFromDLabel.Location = new System.Drawing.Point(25, 23);
            this.reportFromDLabel.Name = "reportFromDLabel";
            this.reportFromDLabel.Size = new System.Drawing.Size(78, 17);
            this.reportFromDLabel.TabIndex = 0;
            this.reportFromDLabel.Text = "From Date:";
            // 
            // reportDownloadButton
            // 
            this.reportDownloadButton.Location = new System.Drawing.Point(563, 388);
            this.reportDownloadButton.Name = "reportDownloadButton";
            this.reportDownloadButton.Size = new System.Drawing.Size(124, 35);
            this.reportDownloadButton.TabIndex = 3;
            this.reportDownloadButton.Text = "Save File";
            this.reportDownloadButton.UseVisualStyleBackColor = true;
            this.reportDownloadButton.Click += new System.EventHandler(this.reportDownloadButton_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Controls.Add(this.reportDownloadButton);
            this.Controls.Add(this.reportFieldsOutline);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportHeadingLabel);
            this.Name = "ReportForm";
            this.Size = new System.Drawing.Size(720, 800);
            this.reportFieldsOutline.ResumeLayout(false);
            this.reportFieldsOutline.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reportHeadingLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel reportFieldsOutline;
        private System.Windows.Forms.Label reportTypeLabel;
        private System.Windows.Forms.DateTimePicker reportFromDatePicker;
        private System.Windows.Forms.DateTimePicker reportToDatePicker;
        private System.Windows.Forms.Label reportToDLabel;
        private System.Windows.Forms.Label reportFromDLabel;
        private System.Windows.Forms.ComboBox reportTypeComboBox;
        private System.Windows.Forms.Button reportDownloadButton;
        private System.Windows.Forms.TextBox fileSavePathText;
        private System.Windows.Forms.Label sampleFileSavePathLabel;
        private System.Windows.Forms.Label fileSavePathLabel;
    }
}
