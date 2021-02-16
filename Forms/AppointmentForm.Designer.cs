namespace CourseWorkTwo.Forms
{
    partial class AppointmentForm
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
            this.appointmentDeleteButton = new System.Windows.Forms.Button();
            this.appointmentAddButton = new System.Windows.Forms.Button();
            this.appointmentResetButton = new System.Windows.Forms.Button();
            this.mandatoryTimeLable = new System.Windows.Forms.Label();
            this.mandatoryDescLable = new System.Windows.Forms.Label();
            this.mandatoryTittleLable = new System.Windows.Forms.Label();
            this.mandatoryStar = new System.Windows.Forms.Label();
            this.mandatoryLabel = new System.Windows.Forms.Label();
            this.appointmentContactsListDropDown = new System.Windows.Forms.ComboBox();
            this.appointmentTimeToTBox = new System.Windows.Forms.DateTimePicker();
            this.appointmentTimeFromTBox = new System.Windows.Forms.DateTimePicker();
            this.appointmentEditButton = new System.Windows.Forms.Button();
            this.mandatoryCategoryLable = new System.Windows.Forms.Label();
            this.mandatoryDateLable = new System.Windows.Forms.Label();
            this.appointmentDateBox = new System.Windows.Forms.DateTimePicker();
            this.appointmentYearlyRButton = new System.Windows.Forms.RadioButton();
            this.appointmentHeadingLabel = new System.Windows.Forms.Label();
            this.appointmentWeeklyRButton = new System.Windows.Forms.RadioButton();
            this.appointmentMonthlyRButton = new System.Windows.Forms.RadioButton();
            this.appointmentRecurringRButton = new System.Windows.Forms.RadioButton();
            this.appointmentFieldsOutline = new System.Windows.Forms.Panel();
            this.mandatoryContactLable = new System.Windows.Forms.Label();
            this.appointmentOneoffRButton = new System.Windows.Forms.RadioButton();
            this.appointmentAdditionalText = new System.Windows.Forms.RichTextBox();
            this.appointmentDescText = new System.Windows.Forms.TextBox();
            this.appointmentPriorityDropDown = new System.Windows.Forms.ComboBox();
            this.appointmentLocationText = new System.Windows.Forms.TextBox();
            this.appointmentNameText = new System.Windows.Forms.TextBox();
            this.appointmentPriorityLabel = new System.Windows.Forms.Label();
            this.appointmentANoteLabel = new System.Windows.Forms.Label();
            this.appointmentRecurringTypeLabel = new System.Windows.Forms.Label();
            this.appointmentCategoryLabel = new System.Windows.Forms.Label();
            this.appointmentsDescLabel = new System.Windows.Forms.Label();
            this.appointmentLocationLabel = new System.Windows.Forms.Label();
            this.appointmentContactLabel = new System.Windows.Forms.Label();
            this.appointmentTimeToLabel = new System.Windows.Forms.Label();
            this.appointmentFromLabel = new System.Windows.Forms.Label();
            this.appointmentTimeLabel = new System.Windows.Forms.Label();
            this.appointmentDateLabel = new System.Windows.Forms.Label();
            this.appointmentNameLabel = new System.Windows.Forms.Label();
            this.appointmentDescLabel = new System.Windows.Forms.Label();
            this.appointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.createddatetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timefromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalnoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioritylevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateddatetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentrecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeMgtDB = new CourseWorkTwo.TimeMgtDB();
            this.appointment_recordTableAdapter = new CourseWorkTwo.TimeMgtDBTableAdapters.appointment_recordTableAdapter();
            this.appointmentFieldsOutline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentrecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeMgtDB)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentDeleteButton
            // 
            this.appointmentDeleteButton.Location = new System.Drawing.Point(597, 502);
            this.appointmentDeleteButton.Name = "appointmentDeleteButton";
            this.appointmentDeleteButton.Size = new System.Drawing.Size(75, 35);
            this.appointmentDeleteButton.TabIndex = 13;
            this.appointmentDeleteButton.Text = "Delete";
            this.appointmentDeleteButton.UseVisualStyleBackColor = true;
            this.appointmentDeleteButton.Click += new System.EventHandler(this.appointmentDeleteButton_Click_1);
            // 
            // appointmentAddButton
            // 
            this.appointmentAddButton.Location = new System.Drawing.Point(435, 502);
            this.appointmentAddButton.Name = "appointmentAddButton";
            this.appointmentAddButton.Size = new System.Drawing.Size(75, 35);
            this.appointmentAddButton.TabIndex = 11;
            this.appointmentAddButton.Text = "Add";
            this.appointmentAddButton.UseVisualStyleBackColor = true;
            this.appointmentAddButton.Click += new System.EventHandler(this.appointmentAddButton_Click);
            // 
            // appointmentResetButton
            // 
            this.appointmentResetButton.Location = new System.Drawing.Point(354, 502);
            this.appointmentResetButton.Name = "appointmentResetButton";
            this.appointmentResetButton.Size = new System.Drawing.Size(75, 35);
            this.appointmentResetButton.TabIndex = 10;
            this.appointmentResetButton.Text = "Reset";
            this.appointmentResetButton.UseVisualStyleBackColor = true;
            this.appointmentResetButton.Click += new System.EventHandler(this.appointmentResetButton_Click_1);
            // 
            // mandatoryTimeLable
            // 
            this.mandatoryTimeLable.AutoSize = true;
            this.mandatoryTimeLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.mandatoryTimeLable.ForeColor = System.Drawing.Color.Red;
            this.mandatoryTimeLable.Location = new System.Drawing.Point(12, 159);
            this.mandatoryTimeLable.Name = "mandatoryTimeLable";
            this.mandatoryTimeLable.Size = new System.Drawing.Size(14, 18);
            this.mandatoryTimeLable.TabIndex = 41;
            this.mandatoryTimeLable.Text = "*";
            // 
            // mandatoryDescLable
            // 
            this.mandatoryDescLable.AutoSize = true;
            this.mandatoryDescLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.mandatoryDescLable.ForeColor = System.Drawing.Color.Red;
            this.mandatoryDescLable.Location = new System.Drawing.Point(331, 21);
            this.mandatoryDescLable.Name = "mandatoryDescLable";
            this.mandatoryDescLable.Size = new System.Drawing.Size(14, 18);
            this.mandatoryDescLable.TabIndex = 39;
            this.mandatoryDescLable.Text = "*";
            // 
            // mandatoryTittleLable
            // 
            this.mandatoryTittleLable.AutoSize = true;
            this.mandatoryTittleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.mandatoryTittleLable.ForeColor = System.Drawing.Color.Red;
            this.mandatoryTittleLable.Location = new System.Drawing.Point(12, 21);
            this.mandatoryTittleLable.Name = "mandatoryTittleLable";
            this.mandatoryTittleLable.Size = new System.Drawing.Size(14, 18);
            this.mandatoryTittleLable.TabIndex = 23;
            this.mandatoryTittleLable.Text = "*";
            // 
            // mandatoryStar
            // 
            this.mandatoryStar.AutoSize = true;
            this.mandatoryStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mandatoryStar.ForeColor = System.Drawing.Color.Red;
            this.mandatoryStar.Location = new System.Drawing.Point(28, 375);
            this.mandatoryStar.Name = "mandatoryStar";
            this.mandatoryStar.Size = new System.Drawing.Size(37, 20);
            this.mandatoryStar.TabIndex = 36;
            this.mandatoryStar.Text = "( * )";
            // 
            // mandatoryLabel
            // 
            this.mandatoryLabel.AutoSize = true;
            this.mandatoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mandatoryLabel.ForeColor = System.Drawing.Color.Red;
            this.mandatoryLabel.Location = new System.Drawing.Point(71, 380);
            this.mandatoryLabel.Name = "mandatoryLabel";
            this.mandatoryLabel.Size = new System.Drawing.Size(95, 15);
            this.mandatoryLabel.TabIndex = 35;
            this.mandatoryLabel.Text = "Mandatory Field";
            // 
            // appointmentContactsListDropDown
            // 
            this.appointmentContactsListDropDown.FormattingEnabled = true;
            this.appointmentContactsListDropDown.Items.AddRange(new object[] {
            "",
            "None"});
            this.appointmentContactsListDropDown.Location = new System.Drawing.Point(28, 259);
            this.appointmentContactsListDropDown.Name = "appointmentContactsListDropDown";
            this.appointmentContactsListDropDown.Size = new System.Drawing.Size(236, 24);
            this.appointmentContactsListDropDown.TabIndex = 34;
            // 
            // appointmentTimeToTBox
            // 
            this.appointmentTimeToTBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.appointmentTimeToTBox.Location = new System.Drawing.Point(150, 199);
            this.appointmentTimeToTBox.Name = "appointmentTimeToTBox";
            this.appointmentTimeToTBox.ShowUpDown = true;
            this.appointmentTimeToTBox.Size = new System.Drawing.Size(114, 22);
            this.appointmentTimeToTBox.TabIndex = 33;
            // 
            // appointmentTimeFromTBox
            // 
            this.appointmentTimeFromTBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.appointmentTimeFromTBox.Location = new System.Drawing.Point(30, 198);
            this.appointmentTimeFromTBox.Name = "appointmentTimeFromTBox";
            this.appointmentTimeFromTBox.ShowUpDown = true;
            this.appointmentTimeFromTBox.Size = new System.Drawing.Size(113, 22);
            this.appointmentTimeFromTBox.TabIndex = 32;
            // 
            // appointmentEditButton
            // 
            this.appointmentEditButton.Location = new System.Drawing.Point(516, 502);
            this.appointmentEditButton.Name = "appointmentEditButton";
            this.appointmentEditButton.Size = new System.Drawing.Size(75, 35);
            this.appointmentEditButton.TabIndex = 12;
            this.appointmentEditButton.Text = "Edit";
            this.appointmentEditButton.UseVisualStyleBackColor = true;
            this.appointmentEditButton.Click += new System.EventHandler(this.appointmentEditButton_Click_1);
            // 
            // mandatoryCategoryLable
            // 
            this.mandatoryCategoryLable.AutoSize = true;
            this.mandatoryCategoryLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.mandatoryCategoryLable.ForeColor = System.Drawing.Color.Red;
            this.mandatoryCategoryLable.Location = new System.Drawing.Point(330, 81);
            this.mandatoryCategoryLable.Name = "mandatoryCategoryLable";
            this.mandatoryCategoryLable.Size = new System.Drawing.Size(14, 18);
            this.mandatoryCategoryLable.TabIndex = 40;
            this.mandatoryCategoryLable.Text = "*";
            // 
            // mandatoryDateLable
            // 
            this.mandatoryDateLable.AutoSize = true;
            this.mandatoryDateLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.mandatoryDateLable.ForeColor = System.Drawing.Color.Red;
            this.mandatoryDateLable.Location = new System.Drawing.Point(12, 81);
            this.mandatoryDateLable.Name = "mandatoryDateLable";
            this.mandatoryDateLable.Size = new System.Drawing.Size(14, 18);
            this.mandatoryDateLable.TabIndex = 37;
            this.mandatoryDateLable.Text = "*";
            // 
            // appointmentDateBox
            // 
            this.appointmentDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.appointmentDateBox.Location = new System.Drawing.Point(28, 103);
            this.appointmentDateBox.MaxDate = new System.DateTime(2025, 12, 5, 0, 0, 0, 0);
            this.appointmentDateBox.MinDate = new System.DateTime(2019, 12, 5, 0, 0, 0, 0);
            this.appointmentDateBox.Name = "appointmentDateBox";
            this.appointmentDateBox.Size = new System.Drawing.Size(115, 22);
            this.appointmentDateBox.TabIndex = 30;
            this.appointmentDateBox.Value = new System.DateTime(2019, 12, 5, 0, 0, 0, 0);
            // 
            // appointmentYearlyRButton
            // 
            this.appointmentYearlyRButton.AutoSize = true;
            this.appointmentYearlyRButton.Location = new System.Drawing.Point(513, 161);
            this.appointmentYearlyRButton.Name = "appointmentYearlyRButton";
            this.appointmentYearlyRButton.Size = new System.Drawing.Size(69, 21);
            this.appointmentYearlyRButton.TabIndex = 29;
            this.appointmentYearlyRButton.TabStop = true;
            this.appointmentYearlyRButton.Text = "Yearly";
            this.appointmentYearlyRButton.UseVisualStyleBackColor = true;
            // 
            // appointmentHeadingLabel
            // 
            this.appointmentHeadingLabel.AutoSize = true;
            this.appointmentHeadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.appointmentHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentHeadingLabel.ForeColor = System.Drawing.Color.White;
            this.appointmentHeadingLabel.Location = new System.Drawing.Point(26, 11);
            this.appointmentHeadingLabel.Name = "appointmentHeadingLabel";
            this.appointmentHeadingLabel.Size = new System.Drawing.Size(264, 25);
            this.appointmentHeadingLabel.TabIndex = 7;
            this.appointmentHeadingLabel.Text = "Appointment Management";
            // 
            // appointmentWeeklyRButton
            // 
            this.appointmentWeeklyRButton.AutoSize = true;
            this.appointmentWeeklyRButton.Location = new System.Drawing.Point(346, 161);
            this.appointmentWeeklyRButton.Name = "appointmentWeeklyRButton";
            this.appointmentWeeklyRButton.Size = new System.Drawing.Size(75, 21);
            this.appointmentWeeklyRButton.TabIndex = 28;
            this.appointmentWeeklyRButton.TabStop = true;
            this.appointmentWeeklyRButton.Text = "Weekly";
            this.appointmentWeeklyRButton.UseVisualStyleBackColor = true;
            // 
            // appointmentMonthlyRButton
            // 
            this.appointmentMonthlyRButton.AutoSize = true;
            this.appointmentMonthlyRButton.Location = new System.Drawing.Point(429, 161);
            this.appointmentMonthlyRButton.Name = "appointmentMonthlyRButton";
            this.appointmentMonthlyRButton.Size = new System.Drawing.Size(78, 21);
            this.appointmentMonthlyRButton.TabIndex = 27;
            this.appointmentMonthlyRButton.TabStop = true;
            this.appointmentMonthlyRButton.Text = "Monthly";
            this.appointmentMonthlyRButton.UseVisualStyleBackColor = true;
            // 
            // appointmentRecurringRButton
            // 
            this.appointmentRecurringRButton.AutoSize = true;
            this.appointmentRecurringRButton.Location = new System.Drawing.Point(429, 103);
            this.appointmentRecurringRButton.Name = "appointmentRecurringRButton";
            this.appointmentRecurringRButton.Size = new System.Drawing.Size(91, 21);
            this.appointmentRecurringRButton.TabIndex = 26;
            this.appointmentRecurringRButton.TabStop = true;
            this.appointmentRecurringRButton.Text = "Recurring";
            this.appointmentRecurringRButton.UseVisualStyleBackColor = true;
            this.appointmentRecurringRButton.CheckedChanged += new System.EventHandler(this.appointmentRecurringRButton_CheckedChanged_1);
            // 
            // appointmentFieldsOutline
            // 
            this.appointmentFieldsOutline.BackColor = System.Drawing.SystemColors.Control;
            this.appointmentFieldsOutline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.appointmentFieldsOutline.Controls.Add(this.mandatoryTimeLable);
            this.appointmentFieldsOutline.Controls.Add(this.mandatoryCategoryLable);
            this.appointmentFieldsOutline.Controls.Add(this.mandatoryDescLable);
            this.appointmentFieldsOutline.Controls.Add(this.mandatoryContactLable);
            this.appointmentFieldsOutline.Controls.Add(this.mandatoryDateLable);
            this.appointmentFieldsOutline.Controls.Add(this.mandatoryTittleLable);
            this.appointmentFieldsOutline.Controls.Add(this.mandatoryStar);
            this.appointmentFieldsOutline.Controls.Add(this.mandatoryLabel);
            this.appointmentFieldsOutline.Controls.Add(this.appointmentContactsListDropDown);
            this.appointmentFieldsOutline.Controls.Add(this.appointmentTimeToTBox);
            this.appointmentFieldsOutline.Controls.Add(this.appointmentTimeFromTBox);
            this.appointmentFieldsOutline.Controls.Add(this.appointmentDateBox);
            this.appointmentFieldsOutline.Controls.Add(this.appointmentYearlyRButton);
            this.appointmentFieldsOutline.Controls.Add(this.appointmentWeeklyRButton);
            this.appointmentFieldsOutline.Controls.Add(this.appointmentMonthlyRButton);
            this.appointmentFieldsOutline.Controls.Add(this.appointmentRecurringRButton);
            this.appointmentFieldsOutline.Controls.Add(this.appointmentOneoffRButton);
            this.appointmentFieldsOutline.Controls.Add(this.appointmentAdditionalText);
            this.appointmentFieldsOutline.Controls.Add(this.appointmentDescText);
            this.appointmentFieldsOutline.Controls.Add(this.appointmentPriorityDropDown);
            this.appointmentFieldsOutline.Controls.Add(this.appointmentLocationText);
            this.appointmentFieldsOutline.Controls.Add(this.appointmentNameText);
            this.appointmentFieldsOutline.Controls.Add(this.appointmentPriorityLabel);
            this.appointmentFieldsOutline.Controls.Add(this.appointmentANoteLabel);
            this.appointmentFieldsOutline.Controls.Add(this.appointmentRecurringTypeLabel);
            this.appointmentFieldsOutline.Controls.Add(this.appointmentCategoryLabel);
            this.appointmentFieldsOutline.Controls.Add(this.appointmentsDescLabel);
            this.appointmentFieldsOutline.Controls.Add(this.appointmentLocationLabel);
            this.appointmentFieldsOutline.Controls.Add(this.appointmentContactLabel);
            this.appointmentFieldsOutline.Controls.Add(this.appointmentTimeToLabel);
            this.appointmentFieldsOutline.Controls.Add(this.appointmentFromLabel);
            this.appointmentFieldsOutline.Controls.Add(this.appointmentTimeLabel);
            this.appointmentFieldsOutline.Controls.Add(this.appointmentDateLabel);
            this.appointmentFieldsOutline.Controls.Add(this.appointmentNameLabel);
            this.appointmentFieldsOutline.Location = new System.Drawing.Point(40, 78);
            this.appointmentFieldsOutline.Name = "appointmentFieldsOutline";
            this.appointmentFieldsOutline.Size = new System.Drawing.Size(634, 408);
            this.appointmentFieldsOutline.TabIndex = 9;
            // 
            // mandatoryContactLable
            // 
            this.mandatoryContactLable.AutoSize = true;
            this.mandatoryContactLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.mandatoryContactLable.ForeColor = System.Drawing.Color.Red;
            this.mandatoryContactLable.Location = new System.Drawing.Point(12, 236);
            this.mandatoryContactLable.Name = "mandatoryContactLable";
            this.mandatoryContactLable.Size = new System.Drawing.Size(14, 18);
            this.mandatoryContactLable.TabIndex = 38;
            this.mandatoryContactLable.Text = "*";
            // 
            // appointmentOneoffRButton
            // 
            this.appointmentOneoffRButton.AutoSize = true;
            this.appointmentOneoffRButton.Location = new System.Drawing.Point(346, 103);
            this.appointmentOneoffRButton.Name = "appointmentOneoffRButton";
            this.appointmentOneoffRButton.Size = new System.Drawing.Size(77, 21);
            this.appointmentOneoffRButton.TabIndex = 25;
            this.appointmentOneoffRButton.TabStop = true;
            this.appointmentOneoffRButton.Text = "One-off";
            this.appointmentOneoffRButton.UseVisualStyleBackColor = true;
            this.appointmentOneoffRButton.CheckedChanged += new System.EventHandler(this.appointmentOneoffRButton_CheckedChanged_1);
            // 
            // appointmentAdditionalText
            // 
            this.appointmentAdditionalText.Location = new System.Drawing.Point(346, 223);
            this.appointmentAdditionalText.Name = "appointmentAdditionalText";
            this.appointmentAdditionalText.Size = new System.Drawing.Size(234, 73);
            this.appointmentAdditionalText.TabIndex = 20;
            this.appointmentAdditionalText.Text = "";
            // 
            // appointmentDescText
            // 
            this.appointmentDescText.Location = new System.Drawing.Point(346, 43);
            this.appointmentDescText.Name = "appointmentDescText";
            this.appointmentDescText.Size = new System.Drawing.Size(236, 22);
            this.appointmentDescText.TabIndex = 19;
            // 
            // appointmentPriorityDropDown
            // 
            this.appointmentPriorityDropDown.FormattingEnabled = true;
            this.appointmentPriorityDropDown.Items.AddRange(new object[] {
            "",
            "High",
            "Medium",
            "Low"});
            this.appointmentPriorityDropDown.Location = new System.Drawing.Point(346, 337);
            this.appointmentPriorityDropDown.Name = "appointmentPriorityDropDown";
            this.appointmentPriorityDropDown.Size = new System.Drawing.Size(236, 24);
            this.appointmentPriorityDropDown.TabIndex = 18;
            // 
            // appointmentLocationText
            // 
            this.appointmentLocationText.Location = new System.Drawing.Point(28, 337);
            this.appointmentLocationText.Name = "appointmentLocationText";
            this.appointmentLocationText.Size = new System.Drawing.Size(236, 22);
            this.appointmentLocationText.TabIndex = 17;
            // 
            // appointmentNameText
            // 
            this.appointmentNameText.Location = new System.Drawing.Point(28, 43);
            this.appointmentNameText.Name = "appointmentNameText";
            this.appointmentNameText.Size = new System.Drawing.Size(236, 22);
            this.appointmentNameText.TabIndex = 16;
            // 
            // appointmentPriorityLabel
            // 
            this.appointmentPriorityLabel.AutoSize = true;
            this.appointmentPriorityLabel.Location = new System.Drawing.Point(343, 315);
            this.appointmentPriorityLabel.Name = "appointmentPriorityLabel";
            this.appointmentPriorityLabel.Size = new System.Drawing.Size(56, 17);
            this.appointmentPriorityLabel.TabIndex = 15;
            this.appointmentPriorityLabel.Text = "Priority:";
            // 
            // appointmentANoteLabel
            // 
            this.appointmentANoteLabel.AutoSize = true;
            this.appointmentANoteLabel.Location = new System.Drawing.Point(345, 203);
            this.appointmentANoteLabel.Name = "appointmentANoteLabel";
            this.appointmentANoteLabel.Size = new System.Drawing.Size(108, 17);
            this.appointmentANoteLabel.TabIndex = 14;
            this.appointmentANoteLabel.Text = "Additional Note:";
            // 
            // appointmentRecurringTypeLabel
            // 
            this.appointmentRecurringTypeLabel.AutoSize = true;
            this.appointmentRecurringTypeLabel.Location = new System.Drawing.Point(345, 141);
            this.appointmentRecurringTypeLabel.Name = "appointmentRecurringTypeLabel";
            this.appointmentRecurringTypeLabel.Size = new System.Drawing.Size(110, 17);
            this.appointmentRecurringTypeLabel.TabIndex = 13;
            this.appointmentRecurringTypeLabel.Text = "Recurring Type:";
            // 
            // appointmentCategoryLabel
            // 
            this.appointmentCategoryLabel.AutoSize = true;
            this.appointmentCategoryLabel.Location = new System.Drawing.Point(343, 83);
            this.appointmentCategoryLabel.Name = "appointmentCategoryLabel";
            this.appointmentCategoryLabel.Size = new System.Drawing.Size(69, 17);
            this.appointmentCategoryLabel.TabIndex = 12;
            this.appointmentCategoryLabel.Text = "Category:";
            // 
            // appointmentsDescLabel
            // 
            this.appointmentsDescLabel.AutoSize = true;
            this.appointmentsDescLabel.Location = new System.Drawing.Point(343, 23);
            this.appointmentsDescLabel.Name = "appointmentsDescLabel";
            this.appointmentsDescLabel.Size = new System.Drawing.Size(83, 17);
            this.appointmentsDescLabel.TabIndex = 10;
            this.appointmentsDescLabel.Text = "Description:";
            // 
            // appointmentLocationLabel
            // 
            this.appointmentLocationLabel.AutoSize = true;
            this.appointmentLocationLabel.Location = new System.Drawing.Point(25, 315);
            this.appointmentLocationLabel.Name = "appointmentLocationLabel";
            this.appointmentLocationLabel.Size = new System.Drawing.Size(66, 17);
            this.appointmentLocationLabel.TabIndex = 9;
            this.appointmentLocationLabel.Text = "Location:";
            // 
            // appointmentContactLabel
            // 
            this.appointmentContactLabel.AutoSize = true;
            this.appointmentContactLabel.Location = new System.Drawing.Point(27, 238);
            this.appointmentContactLabel.Name = "appointmentContactLabel";
            this.appointmentContactLabel.Size = new System.Drawing.Size(109, 17);
            this.appointmentContactLabel.TabIndex = 7;
            this.appointmentContactLabel.Text = "Contact Person:";
            // 
            // appointmentTimeToLabel
            // 
            this.appointmentTimeToLabel.AutoSize = true;
            this.appointmentTimeToLabel.Location = new System.Drawing.Point(170, 178);
            this.appointmentTimeToLabel.Name = "appointmentTimeToLabel";
            this.appointmentTimeToLabel.Size = new System.Drawing.Size(20, 17);
            this.appointmentTimeToLabel.TabIndex = 6;
            this.appointmentTimeToLabel.Text = "to";
            // 
            // appointmentFromLabel
            // 
            this.appointmentFromLabel.AutoSize = true;
            this.appointmentFromLabel.Location = new System.Drawing.Point(55, 178);
            this.appointmentFromLabel.Name = "appointmentFromLabel";
            this.appointmentFromLabel.Size = new System.Drawing.Size(36, 17);
            this.appointmentFromLabel.TabIndex = 5;
            this.appointmentFromLabel.Text = "from";
            // 
            // appointmentTimeLabel
            // 
            this.appointmentTimeLabel.AutoSize = true;
            this.appointmentTimeLabel.Location = new System.Drawing.Point(25, 161);
            this.appointmentTimeLabel.Name = "appointmentTimeLabel";
            this.appointmentTimeLabel.Size = new System.Drawing.Size(43, 17);
            this.appointmentTimeLabel.TabIndex = 4;
            this.appointmentTimeLabel.Text = "Time:";
            // 
            // appointmentDateLabel
            // 
            this.appointmentDateLabel.AutoSize = true;
            this.appointmentDateLabel.Location = new System.Drawing.Point(25, 83);
            this.appointmentDateLabel.Name = "appointmentDateLabel";
            this.appointmentDateLabel.Size = new System.Drawing.Size(42, 17);
            this.appointmentDateLabel.TabIndex = 1;
            this.appointmentDateLabel.Text = "Date:";
            // 
            // appointmentNameLabel
            // 
            this.appointmentNameLabel.AutoSize = true;
            this.appointmentNameLabel.Location = new System.Drawing.Point(25, 23);
            this.appointmentNameLabel.Name = "appointmentNameLabel";
            this.appointmentNameLabel.Size = new System.Drawing.Size(49, 17);
            this.appointmentNameLabel.TabIndex = 0;
            this.appointmentNameLabel.Text = "Name:";
            // 
            // appointmentDescLabel
            // 
            this.appointmentDescLabel.AutoSize = true;
            this.appointmentDescLabel.BackColor = System.Drawing.Color.Transparent;
            this.appointmentDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDescLabel.ForeColor = System.Drawing.Color.White;
            this.appointmentDescLabel.Location = new System.Drawing.Point(28, 48);
            this.appointmentDescLabel.Name = "appointmentDescLabel";
            this.appointmentDescLabel.Size = new System.Drawing.Size(294, 18);
            this.appointmentDescLabel.TabIndex = 8;
            this.appointmentDescLabel.Text = "Manage your appointments from here.";
            // 
            // appointmentDataGridView
            // 
            this.appointmentDataGridView.AllowUserToAddRows = false;
            this.appointmentDataGridView.AllowUserToDeleteRows = false;
            this.appointmentDataGridView.AllowUserToOrderColumns = true;
            this.appointmentDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.appointmentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.appointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.createddatetimeDataGridViewTextBoxColumn,
            this.appointmentidDataGridViewTextBoxColumn,
            this.appointmentnameDataGridViewTextBoxColumn,
            this.appointmentdateDataGridViewTextBoxColumn,
            this.timefromDataGridViewTextBoxColumn,
            this.timetoDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.additionalnoteDataGridViewTextBoxColumn,
            this.prioritylevelDataGridViewTextBoxColumn,
            this.contactnameDataGridViewTextBoxColumn,
            this.updateddatetimeDataGridViewTextBoxColumn});
            this.appointmentDataGridView.DataSource = this.appointmentrecordBindingSource;
            this.appointmentDataGridView.Location = new System.Drawing.Point(40, 552);
            this.appointmentDataGridView.MultiSelect = false;
            this.appointmentDataGridView.Name = "appointmentDataGridView";
            this.appointmentDataGridView.ReadOnly = true;
            this.appointmentDataGridView.RowHeadersVisible = false;
            this.appointmentDataGridView.RowHeadersWidth = 51;
            this.appointmentDataGridView.RowTemplate.Height = 24;
            this.appointmentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentDataGridView.Size = new System.Drawing.Size(634, 211);
            this.appointmentDataGridView.TabIndex = 14;
            this.appointmentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentDataGridView_CellContentClick);
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
            // appointmentidDataGridViewTextBoxColumn
            // 
            this.appointmentidDataGridViewTextBoxColumn.DataPropertyName = "appointment_id";
            this.appointmentidDataGridViewTextBoxColumn.HeaderText = "Appointment Id";
            this.appointmentidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.appointmentidDataGridViewTextBoxColumn.Name = "appointmentidDataGridViewTextBoxColumn";
            this.appointmentidDataGridViewTextBoxColumn.ReadOnly = true;
            this.appointmentidDataGridViewTextBoxColumn.Visible = false;
            this.appointmentidDataGridViewTextBoxColumn.Width = 125;
            // 
            // appointmentnameDataGridViewTextBoxColumn
            // 
            this.appointmentnameDataGridViewTextBoxColumn.DataPropertyName = "appointment_name";
            this.appointmentnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.appointmentnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.appointmentnameDataGridViewTextBoxColumn.Name = "appointmentnameDataGridViewTextBoxColumn";
            this.appointmentnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.appointmentnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // appointmentdateDataGridViewTextBoxColumn
            // 
            this.appointmentdateDataGridViewTextBoxColumn.DataPropertyName = "appointment_date";
            this.appointmentdateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.appointmentdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.appointmentdateDataGridViewTextBoxColumn.Name = "appointmentdateDataGridViewTextBoxColumn";
            this.appointmentdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.appointmentdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // timefromDataGridViewTextBoxColumn
            // 
            this.timefromDataGridViewTextBoxColumn.DataPropertyName = "time_from";
            this.timefromDataGridViewTextBoxColumn.HeaderText = "Time from";
            this.timefromDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timefromDataGridViewTextBoxColumn.Name = "timefromDataGridViewTextBoxColumn";
            this.timefromDataGridViewTextBoxColumn.ReadOnly = true;
            this.timefromDataGridViewTextBoxColumn.Width = 125;
            // 
            // timetoDataGridViewTextBoxColumn
            // 
            this.timetoDataGridViewTextBoxColumn.DataPropertyName = "time_to";
            this.timetoDataGridViewTextBoxColumn.HeaderText = "Time to";
            this.timetoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timetoDataGridViewTextBoxColumn.Name = "timetoDataGridViewTextBoxColumn";
            this.timetoDataGridViewTextBoxColumn.ReadOnly = true;
            this.timetoDataGridViewTextBoxColumn.Width = 125;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // additionalnoteDataGridViewTextBoxColumn
            // 
            this.additionalnoteDataGridViewTextBoxColumn.DataPropertyName = "additional_note";
            this.additionalnoteDataGridViewTextBoxColumn.HeaderText = "Additional Note";
            this.additionalnoteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.additionalnoteDataGridViewTextBoxColumn.Name = "additionalnoteDataGridViewTextBoxColumn";
            this.additionalnoteDataGridViewTextBoxColumn.ReadOnly = true;
            this.additionalnoteDataGridViewTextBoxColumn.Width = 125;
            // 
            // prioritylevelDataGridViewTextBoxColumn
            // 
            this.prioritylevelDataGridViewTextBoxColumn.DataPropertyName = "priority_level";
            this.prioritylevelDataGridViewTextBoxColumn.HeaderText = "Priority Level";
            this.prioritylevelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prioritylevelDataGridViewTextBoxColumn.Name = "prioritylevelDataGridViewTextBoxColumn";
            this.prioritylevelDataGridViewTextBoxColumn.ReadOnly = true;
            this.prioritylevelDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactnameDataGridViewTextBoxColumn
            // 
            this.contactnameDataGridViewTextBoxColumn.DataPropertyName = "contact_name";
            this.contactnameDataGridViewTextBoxColumn.HeaderText = "Contact Name";
            this.contactnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactnameDataGridViewTextBoxColumn.Name = "contactnameDataGridViewTextBoxColumn";
            this.contactnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // updateddatetimeDataGridViewTextBoxColumn
            // 
            this.updateddatetimeDataGridViewTextBoxColumn.DataPropertyName = "updated_date_time";
            this.updateddatetimeDataGridViewTextBoxColumn.HeaderText = "Updated Date & Time";
            this.updateddatetimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.updateddatetimeDataGridViewTextBoxColumn.Name = "updateddatetimeDataGridViewTextBoxColumn";
            this.updateddatetimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.updateddatetimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // appointmentrecordBindingSource
            // 
            this.appointmentrecordBindingSource.DataMember = "appointment_record";
            this.appointmentrecordBindingSource.DataSource = this.timeMgtDB;
            // 
            // timeMgtDB
            // 
            this.timeMgtDB.DataSetName = "TimeMgtDB";
            this.timeMgtDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointment_recordTableAdapter
            // 
            this.appointment_recordTableAdapter.ClearBeforeFill = true;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Controls.Add(this.appointmentDataGridView);
            this.Controls.Add(this.appointmentDeleteButton);
            this.Controls.Add(this.appointmentAddButton);
            this.Controls.Add(this.appointmentResetButton);
            this.Controls.Add(this.appointmentEditButton);
            this.Controls.Add(this.appointmentHeadingLabel);
            this.Controls.Add(this.appointmentFieldsOutline);
            this.Controls.Add(this.appointmentDescLabel);
            this.Name = "AppointmentForm";
            this.Size = new System.Drawing.Size(720, 800);
            this.appointmentFieldsOutline.ResumeLayout(false);
            this.appointmentFieldsOutline.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentrecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeMgtDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button appointmentDeleteButton;
        private System.Windows.Forms.Button appointmentAddButton;
        private System.Windows.Forms.Button appointmentResetButton;
        private System.Windows.Forms.Label mandatoryTimeLable;
        private System.Windows.Forms.Label mandatoryDescLable;
        private System.Windows.Forms.Label mandatoryTittleLable;
        private System.Windows.Forms.Label mandatoryStar;
        private System.Windows.Forms.Label mandatoryLabel;
        private System.Windows.Forms.ComboBox appointmentContactsListDropDown;
        private System.Windows.Forms.DateTimePicker appointmentTimeToTBox;
        private System.Windows.Forms.DateTimePicker appointmentTimeFromTBox;
        private System.Windows.Forms.Button appointmentEditButton;
        private System.Windows.Forms.Label mandatoryCategoryLable;
        private System.Windows.Forms.Label mandatoryDateLable;
        private System.Windows.Forms.DateTimePicker appointmentDateBox;
        private System.Windows.Forms.RadioButton appointmentYearlyRButton;
        private System.Windows.Forms.Label appointmentHeadingLabel;
        private System.Windows.Forms.RadioButton appointmentWeeklyRButton;
        private System.Windows.Forms.RadioButton appointmentMonthlyRButton;
        private System.Windows.Forms.RadioButton appointmentRecurringRButton;
        private System.Windows.Forms.Panel appointmentFieldsOutline;
        private System.Windows.Forms.Label mandatoryContactLable;
        private System.Windows.Forms.RadioButton appointmentOneoffRButton;
        private System.Windows.Forms.RichTextBox appointmentAdditionalText;
        private System.Windows.Forms.TextBox appointmentDescText;
        private System.Windows.Forms.ComboBox appointmentPriorityDropDown;
        private System.Windows.Forms.TextBox appointmentLocationText;
        private System.Windows.Forms.TextBox appointmentNameText;
        private System.Windows.Forms.Label appointmentPriorityLabel;
        private System.Windows.Forms.Label appointmentANoteLabel;
        private System.Windows.Forms.Label appointmentRecurringTypeLabel;
        private System.Windows.Forms.Label appointmentCategoryLabel;
        private System.Windows.Forms.Label appointmentsDescLabel;
        private System.Windows.Forms.Label appointmentLocationLabel;
        private System.Windows.Forms.Label appointmentContactLabel;
        private System.Windows.Forms.Label appointmentTimeToLabel;
        private System.Windows.Forms.Label appointmentFromLabel;
        private System.Windows.Forms.Label appointmentTimeLabel;
        private System.Windows.Forms.Label appointmentDateLabel;
        private System.Windows.Forms.Label appointmentNameLabel;
        private System.Windows.Forms.Label appointmentDescLabel;
        private System.Windows.Forms.DataGridView appointmentDataGridView;
        private System.Windows.Forms.BindingSource appointmentrecordBindingSource;
        private TimeMgtDB timeMgtDB;
        private TimeMgtDBTableAdapters.appointment_recordTableAdapter appointment_recordTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn createddatetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timefromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalnoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioritylevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateddatetimeDataGridViewTextBoxColumn;
    }
}
