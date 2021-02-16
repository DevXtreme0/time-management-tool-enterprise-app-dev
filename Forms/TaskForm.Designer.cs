namespace CourseWorkTwo.Forms
{
    partial class TaskForm
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
            this.mandatoryTimeLable = new System.Windows.Forms.Label();
            this.mandatoryCategoryLable = new System.Windows.Forms.Label();
            this.mandatoryDescLable = new System.Windows.Forms.Label();
            this.mandatoryContactLable = new System.Windows.Forms.Label();
            this.mandatoryDateLable = new System.Windows.Forms.Label();
            this.mandatoryTittleLable = new System.Windows.Forms.Label();
            this.mandatoryLabel = new System.Windows.Forms.Label();
            this.taskContactsListDropDown = new System.Windows.Forms.ComboBox();
            this.taskTimeToTBox = new System.Windows.Forms.DateTimePicker();
            this.taskTimeFromTBox = new System.Windows.Forms.DateTimePicker();
            this.taskDueDateBox = new System.Windows.Forms.DateTimePicker();
            this.taskAddButton = new System.Windows.Forms.Button();
            this.taskResetButton = new System.Windows.Forms.Button();
            this.mandatoryStar = new System.Windows.Forms.Label();
            this.taskYearlyRButton = new System.Windows.Forms.RadioButton();
            this.taskWeeklyRButton = new System.Windows.Forms.RadioButton();
            this.taskMonthlyRButton = new System.Windows.Forms.RadioButton();
            this.taskRecurringRButton = new System.Windows.Forms.RadioButton();
            this.taskOneoffRButton = new System.Windows.Forms.RadioButton();
            this.taskCategoryLabel = new System.Windows.Forms.Label();
            this.taskDeleteButton = new System.Windows.Forms.Button();
            this.taskEditButton = new System.Windows.Forms.Button();
            this.taskAdditionalText = new System.Windows.Forms.RichTextBox();
            this.taskPriorityDropDown = new System.Windows.Forms.ComboBox();
            this.taskLocationText = new System.Windows.Forms.TextBox();
            this.taskPriorityLabel = new System.Windows.Forms.Label();
            this.taskANoteLabel = new System.Windows.Forms.Label();
            this.taskRecurringTypeLabel = new System.Windows.Forms.Label();
            this.tasksDescLabel = new System.Windows.Forms.Label();
            this.taskLocationLabel = new System.Windows.Forms.Label();
            this.taskContactLabel = new System.Windows.Forms.Label();
            this.taskTimeToLabel = new System.Windows.Forms.Label();
            this.taskFromLabel = new System.Windows.Forms.Label();
            this.taskTimeLabel = new System.Windows.Forms.Label();
            this.taskDateLabel = new System.Windows.Forms.Label();
            this.taskNameLabel = new System.Windows.Forms.Label();
            this.taskHeadingLabel = new System.Windows.Forms.Label();
            this.appointmentFieldsOutline = new System.Windows.Forms.Panel();
            this.taskDescText = new System.Windows.Forms.TextBox();
            this.taskNameText = new System.Windows.Forms.TextBox();
            this.taskDescLabel = new System.Windows.Forms.Label();
            this.taskDataGridView = new System.Windows.Forms.DataGridView();
            this.createddatetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskduedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timefromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalnoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioritylevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateddatetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskrecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeMgtDB = new CourseWorkTwo.TimeMgtDB();
            this.task_recordTableAdapter = new CourseWorkTwo.TimeMgtDBTableAdapters.task_recordTableAdapter();
            this.appointmentFieldsOutline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskrecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeMgtDB)).BeginInit();
            this.SuspendLayout();
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
            // taskContactsListDropDown
            // 
            this.taskContactsListDropDown.FormattingEnabled = true;
            this.taskContactsListDropDown.Items.AddRange(new object[] {
            "",
            "None"});
            this.taskContactsListDropDown.Location = new System.Drawing.Point(28, 259);
            this.taskContactsListDropDown.Name = "taskContactsListDropDown";
            this.taskContactsListDropDown.Size = new System.Drawing.Size(236, 24);
            this.taskContactsListDropDown.TabIndex = 34;
            // 
            // taskTimeToTBox
            // 
            this.taskTimeToTBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.taskTimeToTBox.Location = new System.Drawing.Point(150, 199);
            this.taskTimeToTBox.Name = "taskTimeToTBox";
            this.taskTimeToTBox.ShowUpDown = true;
            this.taskTimeToTBox.Size = new System.Drawing.Size(114, 22);
            this.taskTimeToTBox.TabIndex = 33;
            // 
            // taskTimeFromTBox
            // 
            this.taskTimeFromTBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.taskTimeFromTBox.Location = new System.Drawing.Point(30, 198);
            this.taskTimeFromTBox.Name = "taskTimeFromTBox";
            this.taskTimeFromTBox.ShowUpDown = true;
            this.taskTimeFromTBox.Size = new System.Drawing.Size(113, 22);
            this.taskTimeFromTBox.TabIndex = 32;
            // 
            // taskDueDateBox
            // 
            this.taskDueDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.taskDueDateBox.Location = new System.Drawing.Point(28, 103);
            this.taskDueDateBox.MaxDate = new System.DateTime(2025, 12, 5, 0, 0, 0, 0);
            this.taskDueDateBox.MinDate = new System.DateTime(2019, 12, 5, 0, 0, 0, 0);
            this.taskDueDateBox.Name = "taskDueDateBox";
            this.taskDueDateBox.Size = new System.Drawing.Size(115, 22);
            this.taskDueDateBox.TabIndex = 30;
            this.taskDueDateBox.Value = new System.DateTime(2019, 12, 5, 0, 0, 0, 0);
            // 
            // taskAddButton
            // 
            this.taskAddButton.Location = new System.Drawing.Point(449, 507);
            this.taskAddButton.Name = "taskAddButton";
            this.taskAddButton.Size = new System.Drawing.Size(75, 35);
            this.taskAddButton.TabIndex = 18;
            this.taskAddButton.Text = "Add";
            this.taskAddButton.UseVisualStyleBackColor = true;
            this.taskAddButton.Click += new System.EventHandler(this.taskAddButton_Click_1);
            // 
            // taskResetButton
            // 
            this.taskResetButton.Location = new System.Drawing.Point(368, 507);
            this.taskResetButton.Name = "taskResetButton";
            this.taskResetButton.Size = new System.Drawing.Size(75, 35);
            this.taskResetButton.TabIndex = 17;
            this.taskResetButton.Text = "Reset";
            this.taskResetButton.UseVisualStyleBackColor = true;
            this.taskResetButton.Click += new System.EventHandler(this.taskResetButton_Click);
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
            // taskYearlyRButton
            // 
            this.taskYearlyRButton.AutoSize = true;
            this.taskYearlyRButton.Location = new System.Drawing.Point(513, 161);
            this.taskYearlyRButton.Name = "taskYearlyRButton";
            this.taskYearlyRButton.Size = new System.Drawing.Size(69, 21);
            this.taskYearlyRButton.TabIndex = 29;
            this.taskYearlyRButton.TabStop = true;
            this.taskYearlyRButton.Text = "Yearly";
            this.taskYearlyRButton.UseVisualStyleBackColor = true;
            // 
            // taskWeeklyRButton
            // 
            this.taskWeeklyRButton.AutoSize = true;
            this.taskWeeklyRButton.Location = new System.Drawing.Point(346, 161);
            this.taskWeeklyRButton.Name = "taskWeeklyRButton";
            this.taskWeeklyRButton.Size = new System.Drawing.Size(75, 21);
            this.taskWeeklyRButton.TabIndex = 28;
            this.taskWeeklyRButton.TabStop = true;
            this.taskWeeklyRButton.Text = "Weekly";
            this.taskWeeklyRButton.UseVisualStyleBackColor = true;
            // 
            // taskMonthlyRButton
            // 
            this.taskMonthlyRButton.AutoSize = true;
            this.taskMonthlyRButton.Location = new System.Drawing.Point(429, 161);
            this.taskMonthlyRButton.Name = "taskMonthlyRButton";
            this.taskMonthlyRButton.Size = new System.Drawing.Size(78, 21);
            this.taskMonthlyRButton.TabIndex = 27;
            this.taskMonthlyRButton.TabStop = true;
            this.taskMonthlyRButton.Text = "Monthly";
            this.taskMonthlyRButton.UseVisualStyleBackColor = true;
            // 
            // taskRecurringRButton
            // 
            this.taskRecurringRButton.AutoSize = true;
            this.taskRecurringRButton.Location = new System.Drawing.Point(429, 103);
            this.taskRecurringRButton.Name = "taskRecurringRButton";
            this.taskRecurringRButton.Size = new System.Drawing.Size(91, 21);
            this.taskRecurringRButton.TabIndex = 26;
            this.taskRecurringRButton.TabStop = true;
            this.taskRecurringRButton.Text = "Recurring";
            this.taskRecurringRButton.UseVisualStyleBackColor = true;
            this.taskRecurringRButton.CheckedChanged += new System.EventHandler(this.taskRecurringRButton_CheckedChanged);
            // 
            // taskOneoffRButton
            // 
            this.taskOneoffRButton.AutoSize = true;
            this.taskOneoffRButton.Location = new System.Drawing.Point(346, 103);
            this.taskOneoffRButton.Name = "taskOneoffRButton";
            this.taskOneoffRButton.Size = new System.Drawing.Size(77, 21);
            this.taskOneoffRButton.TabIndex = 25;
            this.taskOneoffRButton.TabStop = true;
            this.taskOneoffRButton.Text = "One-off";
            this.taskOneoffRButton.UseVisualStyleBackColor = true;
            this.taskOneoffRButton.CheckedChanged += new System.EventHandler(this.taskOneoffRButton_CheckedChanged);
            // 
            // taskCategoryLabel
            // 
            this.taskCategoryLabel.AutoSize = true;
            this.taskCategoryLabel.Location = new System.Drawing.Point(343, 83);
            this.taskCategoryLabel.Name = "taskCategoryLabel";
            this.taskCategoryLabel.Size = new System.Drawing.Size(69, 17);
            this.taskCategoryLabel.TabIndex = 12;
            this.taskCategoryLabel.Text = "Category:";
            // 
            // taskDeleteButton
            // 
            this.taskDeleteButton.Location = new System.Drawing.Point(611, 507);
            this.taskDeleteButton.Name = "taskDeleteButton";
            this.taskDeleteButton.Size = new System.Drawing.Size(75, 35);
            this.taskDeleteButton.TabIndex = 20;
            this.taskDeleteButton.Text = "Delete";
            this.taskDeleteButton.UseVisualStyleBackColor = true;
            this.taskDeleteButton.Click += new System.EventHandler(this.taskDeleteButton_Click);
            // 
            // taskEditButton
            // 
            this.taskEditButton.Location = new System.Drawing.Point(530, 507);
            this.taskEditButton.Name = "taskEditButton";
            this.taskEditButton.Size = new System.Drawing.Size(75, 35);
            this.taskEditButton.TabIndex = 19;
            this.taskEditButton.Text = "Edit";
            this.taskEditButton.UseVisualStyleBackColor = true;
            this.taskEditButton.Click += new System.EventHandler(this.taskEditButton_Click);
            // 
            // taskAdditionalText
            // 
            this.taskAdditionalText.Location = new System.Drawing.Point(346, 223);
            this.taskAdditionalText.Name = "taskAdditionalText";
            this.taskAdditionalText.Size = new System.Drawing.Size(234, 73);
            this.taskAdditionalText.TabIndex = 20;
            this.taskAdditionalText.Text = "";
            // 
            // taskPriorityDropDown
            // 
            this.taskPriorityDropDown.FormattingEnabled = true;
            this.taskPriorityDropDown.Items.AddRange(new object[] {
            "",
            "High",
            "Medium",
            "Low"});
            this.taskPriorityDropDown.Location = new System.Drawing.Point(346, 337);
            this.taskPriorityDropDown.Name = "taskPriorityDropDown";
            this.taskPriorityDropDown.Size = new System.Drawing.Size(236, 24);
            this.taskPriorityDropDown.TabIndex = 18;
            // 
            // taskLocationText
            // 
            this.taskLocationText.Location = new System.Drawing.Point(28, 337);
            this.taskLocationText.Name = "taskLocationText";
            this.taskLocationText.Size = new System.Drawing.Size(236, 22);
            this.taskLocationText.TabIndex = 17;
            // 
            // taskPriorityLabel
            // 
            this.taskPriorityLabel.AutoSize = true;
            this.taskPriorityLabel.Location = new System.Drawing.Point(343, 315);
            this.taskPriorityLabel.Name = "taskPriorityLabel";
            this.taskPriorityLabel.Size = new System.Drawing.Size(56, 17);
            this.taskPriorityLabel.TabIndex = 15;
            this.taskPriorityLabel.Text = "Priority:";
            // 
            // taskANoteLabel
            // 
            this.taskANoteLabel.AutoSize = true;
            this.taskANoteLabel.Location = new System.Drawing.Point(345, 203);
            this.taskANoteLabel.Name = "taskANoteLabel";
            this.taskANoteLabel.Size = new System.Drawing.Size(108, 17);
            this.taskANoteLabel.TabIndex = 14;
            this.taskANoteLabel.Text = "Additional Note:";
            // 
            // taskRecurringTypeLabel
            // 
            this.taskRecurringTypeLabel.AutoSize = true;
            this.taskRecurringTypeLabel.Location = new System.Drawing.Point(345, 141);
            this.taskRecurringTypeLabel.Name = "taskRecurringTypeLabel";
            this.taskRecurringTypeLabel.Size = new System.Drawing.Size(110, 17);
            this.taskRecurringTypeLabel.TabIndex = 13;
            this.taskRecurringTypeLabel.Text = "Recurring Type:";
            // 
            // tasksDescLabel
            // 
            this.tasksDescLabel.AutoSize = true;
            this.tasksDescLabel.Location = new System.Drawing.Point(343, 23);
            this.tasksDescLabel.Name = "tasksDescLabel";
            this.tasksDescLabel.Size = new System.Drawing.Size(83, 17);
            this.tasksDescLabel.TabIndex = 10;
            this.tasksDescLabel.Text = "Description:";
            // 
            // taskLocationLabel
            // 
            this.taskLocationLabel.AutoSize = true;
            this.taskLocationLabel.Location = new System.Drawing.Point(25, 315);
            this.taskLocationLabel.Name = "taskLocationLabel";
            this.taskLocationLabel.Size = new System.Drawing.Size(66, 17);
            this.taskLocationLabel.TabIndex = 9;
            this.taskLocationLabel.Text = "Location:";
            // 
            // taskContactLabel
            // 
            this.taskContactLabel.AutoSize = true;
            this.taskContactLabel.Location = new System.Drawing.Point(27, 238);
            this.taskContactLabel.Name = "taskContactLabel";
            this.taskContactLabel.Size = new System.Drawing.Size(109, 17);
            this.taskContactLabel.TabIndex = 7;
            this.taskContactLabel.Text = "Contact Person:";
            // 
            // taskTimeToLabel
            // 
            this.taskTimeToLabel.AutoSize = true;
            this.taskTimeToLabel.Location = new System.Drawing.Point(170, 178);
            this.taskTimeToLabel.Name = "taskTimeToLabel";
            this.taskTimeToLabel.Size = new System.Drawing.Size(20, 17);
            this.taskTimeToLabel.TabIndex = 6;
            this.taskTimeToLabel.Text = "to";
            // 
            // taskFromLabel
            // 
            this.taskFromLabel.AutoSize = true;
            this.taskFromLabel.Location = new System.Drawing.Point(55, 178);
            this.taskFromLabel.Name = "taskFromLabel";
            this.taskFromLabel.Size = new System.Drawing.Size(36, 17);
            this.taskFromLabel.TabIndex = 5;
            this.taskFromLabel.Text = "from";
            // 
            // taskTimeLabel
            // 
            this.taskTimeLabel.AutoSize = true;
            this.taskTimeLabel.Location = new System.Drawing.Point(25, 161);
            this.taskTimeLabel.Name = "taskTimeLabel";
            this.taskTimeLabel.Size = new System.Drawing.Size(43, 17);
            this.taskTimeLabel.TabIndex = 4;
            this.taskTimeLabel.Text = "Time:";
            // 
            // taskDateLabel
            // 
            this.taskDateLabel.AutoSize = true;
            this.taskDateLabel.Location = new System.Drawing.Point(25, 83);
            this.taskDateLabel.Name = "taskDateLabel";
            this.taskDateLabel.Size = new System.Drawing.Size(72, 17);
            this.taskDateLabel.TabIndex = 1;
            this.taskDateLabel.Text = "Due Date:";
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.AutoSize = true;
            this.taskNameLabel.Location = new System.Drawing.Point(25, 23);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(49, 17);
            this.taskNameLabel.TabIndex = 0;
            this.taskNameLabel.Text = "Name:";
            // 
            // taskHeadingLabel
            // 
            this.taskHeadingLabel.AutoSize = true;
            this.taskHeadingLabel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.taskHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskHeadingLabel.ForeColor = System.Drawing.Color.White;
            this.taskHeadingLabel.Location = new System.Drawing.Point(36, 5);
            this.taskHeadingLabel.Name = "taskHeadingLabel";
            this.taskHeadingLabel.Size = new System.Drawing.Size(191, 25);
            this.taskHeadingLabel.TabIndex = 14;
            this.taskHeadingLabel.Text = "Task Management";
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
            this.appointmentFieldsOutline.Controls.Add(this.taskContactsListDropDown);
            this.appointmentFieldsOutline.Controls.Add(this.taskTimeToTBox);
            this.appointmentFieldsOutline.Controls.Add(this.taskTimeFromTBox);
            this.appointmentFieldsOutline.Controls.Add(this.taskDueDateBox);
            this.appointmentFieldsOutline.Controls.Add(this.taskYearlyRButton);
            this.appointmentFieldsOutline.Controls.Add(this.taskWeeklyRButton);
            this.appointmentFieldsOutline.Controls.Add(this.taskMonthlyRButton);
            this.appointmentFieldsOutline.Controls.Add(this.taskRecurringRButton);
            this.appointmentFieldsOutline.Controls.Add(this.taskOneoffRButton);
            this.appointmentFieldsOutline.Controls.Add(this.taskAdditionalText);
            this.appointmentFieldsOutline.Controls.Add(this.taskDescText);
            this.appointmentFieldsOutline.Controls.Add(this.taskPriorityDropDown);
            this.appointmentFieldsOutline.Controls.Add(this.taskLocationText);
            this.appointmentFieldsOutline.Controls.Add(this.taskNameText);
            this.appointmentFieldsOutline.Controls.Add(this.taskPriorityLabel);
            this.appointmentFieldsOutline.Controls.Add(this.taskANoteLabel);
            this.appointmentFieldsOutline.Controls.Add(this.taskRecurringTypeLabel);
            this.appointmentFieldsOutline.Controls.Add(this.taskCategoryLabel);
            this.appointmentFieldsOutline.Controls.Add(this.tasksDescLabel);
            this.appointmentFieldsOutline.Controls.Add(this.taskLocationLabel);
            this.appointmentFieldsOutline.Controls.Add(this.taskContactLabel);
            this.appointmentFieldsOutline.Controls.Add(this.taskTimeToLabel);
            this.appointmentFieldsOutline.Controls.Add(this.taskFromLabel);
            this.appointmentFieldsOutline.Controls.Add(this.taskTimeLabel);
            this.appointmentFieldsOutline.Controls.Add(this.taskDateLabel);
            this.appointmentFieldsOutline.Controls.Add(this.taskNameLabel);
            this.appointmentFieldsOutline.Location = new System.Drawing.Point(52, 82);
            this.appointmentFieldsOutline.Name = "appointmentFieldsOutline";
            this.appointmentFieldsOutline.Size = new System.Drawing.Size(634, 408);
            this.appointmentFieldsOutline.TabIndex = 16;
            // 
            // taskDescText
            // 
            this.taskDescText.Location = new System.Drawing.Point(346, 43);
            this.taskDescText.Name = "taskDescText";
            this.taskDescText.Size = new System.Drawing.Size(236, 22);
            this.taskDescText.TabIndex = 19;
            // 
            // taskNameText
            // 
            this.taskNameText.Location = new System.Drawing.Point(28, 43);
            this.taskNameText.Name = "taskNameText";
            this.taskNameText.Size = new System.Drawing.Size(236, 22);
            this.taskNameText.TabIndex = 16;
            // 
            // taskDescLabel
            // 
            this.taskDescLabel.AutoSize = true;
            this.taskDescLabel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.taskDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDescLabel.ForeColor = System.Drawing.Color.White;
            this.taskDescLabel.Location = new System.Drawing.Point(38, 41);
            this.taskDescLabel.Name = "taskDescLabel";
            this.taskDescLabel.Size = new System.Drawing.Size(234, 18);
            this.taskDescLabel.TabIndex = 15;
            this.taskDescLabel.Text = "Manage your tasks from here.";
            // 
            // taskDataGridView
            // 
            this.taskDataGridView.AllowUserToAddRows = false;
            this.taskDataGridView.AllowUserToDeleteRows = false;
            this.taskDataGridView.AllowUserToOrderColumns = true;
            this.taskDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.taskDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.taskDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.createddatetimeDataGridViewTextBoxColumn,
            this.taskidDataGridViewTextBoxColumn,
            this.tasknameDataGridViewTextBoxColumn,
            this.taskduedateDataGridViewTextBoxColumn,
            this.timefromDataGridViewTextBoxColumn,
            this.timetoDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.additionalnoteDataGridViewTextBoxColumn,
            this.prioritylevelDataGridViewTextBoxColumn,
            this.contactnameDataGridViewTextBoxColumn,
            this.updateddatetimeDataGridViewTextBoxColumn});
            this.taskDataGridView.DataSource = this.taskrecordBindingSource;
            this.taskDataGridView.Location = new System.Drawing.Point(52, 561);
            this.taskDataGridView.MultiSelect = false;
            this.taskDataGridView.Name = "taskDataGridView";
            this.taskDataGridView.ReadOnly = true;
            this.taskDataGridView.RowHeadersVisible = false;
            this.taskDataGridView.RowHeadersWidth = 51;
            this.taskDataGridView.RowTemplate.Height = 24;
            this.taskDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.taskDataGridView.Size = new System.Drawing.Size(634, 211);
            this.taskDataGridView.TabIndex = 21;
            this.taskDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.taskDataGridView_CellContentClick_1);
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
            // taskidDataGridViewTextBoxColumn
            // 
            this.taskidDataGridViewTextBoxColumn.DataPropertyName = "task_id";
            this.taskidDataGridViewTextBoxColumn.HeaderText = "Task Id";
            this.taskidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.taskidDataGridViewTextBoxColumn.Name = "taskidDataGridViewTextBoxColumn";
            this.taskidDataGridViewTextBoxColumn.ReadOnly = true;
            this.taskidDataGridViewTextBoxColumn.Visible = false;
            this.taskidDataGridViewTextBoxColumn.Width = 125;
            // 
            // tasknameDataGridViewTextBoxColumn
            // 
            this.tasknameDataGridViewTextBoxColumn.DataPropertyName = "task_name";
            this.tasknameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.tasknameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tasknameDataGridViewTextBoxColumn.Name = "tasknameDataGridViewTextBoxColumn";
            this.tasknameDataGridViewTextBoxColumn.ReadOnly = true;
            this.tasknameDataGridViewTextBoxColumn.Width = 125;
            // 
            // taskduedateDataGridViewTextBoxColumn
            // 
            this.taskduedateDataGridViewTextBoxColumn.DataPropertyName = "task_due_date";
            this.taskduedateDataGridViewTextBoxColumn.HeaderText = "Due Date";
            this.taskduedateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.taskduedateDataGridViewTextBoxColumn.Name = "taskduedateDataGridViewTextBoxColumn";
            this.taskduedateDataGridViewTextBoxColumn.ReadOnly = true;
            this.taskduedateDataGridViewTextBoxColumn.Width = 125;
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
            // taskrecordBindingSource
            // 
            this.taskrecordBindingSource.DataMember = "task_record";
            this.taskrecordBindingSource.DataSource = this.timeMgtDB;
            // 
            // timeMgtDB
            // 
            this.timeMgtDB.DataSetName = "TimeMgtDB";
            this.timeMgtDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // task_recordTableAdapter
            // 
            this.task_recordTableAdapter.ClearBeforeFill = true;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Controls.Add(this.taskDataGridView);
            this.Controls.Add(this.taskAddButton);
            this.Controls.Add(this.taskResetButton);
            this.Controls.Add(this.taskDeleteButton);
            this.Controls.Add(this.taskEditButton);
            this.Controls.Add(this.taskHeadingLabel);
            this.Controls.Add(this.appointmentFieldsOutline);
            this.Controls.Add(this.taskDescLabel);
            this.Name = "TaskForm";
            this.Size = new System.Drawing.Size(720, 800);
            this.appointmentFieldsOutline.ResumeLayout(false);
            this.appointmentFieldsOutline.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskrecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeMgtDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mandatoryTimeLable;
        private System.Windows.Forms.Label mandatoryCategoryLable;
        private System.Windows.Forms.Label mandatoryDescLable;
        private System.Windows.Forms.Label mandatoryContactLable;
        private System.Windows.Forms.Label mandatoryDateLable;
        private System.Windows.Forms.Label mandatoryTittleLable;
        private System.Windows.Forms.Label mandatoryLabel;
        private System.Windows.Forms.ComboBox taskContactsListDropDown;
        private System.Windows.Forms.DateTimePicker taskTimeToTBox;
        private System.Windows.Forms.DateTimePicker taskTimeFromTBox;
        private System.Windows.Forms.DateTimePicker taskDueDateBox;
        private System.Windows.Forms.Button taskAddButton;
        private System.Windows.Forms.Button taskResetButton;
        private System.Windows.Forms.Label mandatoryStar;
        private System.Windows.Forms.RadioButton taskYearlyRButton;
        private System.Windows.Forms.RadioButton taskWeeklyRButton;
        private System.Windows.Forms.RadioButton taskMonthlyRButton;
        private System.Windows.Forms.RadioButton taskRecurringRButton;
        private System.Windows.Forms.RadioButton taskOneoffRButton;
        private System.Windows.Forms.Label taskCategoryLabel;
        private System.Windows.Forms.Button taskDeleteButton;
        private System.Windows.Forms.Button taskEditButton;
        private System.Windows.Forms.RichTextBox taskAdditionalText;
        private System.Windows.Forms.ComboBox taskPriorityDropDown;
        private System.Windows.Forms.TextBox taskLocationText;
        private System.Windows.Forms.Label taskPriorityLabel;
        private System.Windows.Forms.Label taskANoteLabel;
        private System.Windows.Forms.Label taskRecurringTypeLabel;
        private System.Windows.Forms.Label tasksDescLabel;
        private System.Windows.Forms.Label taskLocationLabel;
        private System.Windows.Forms.Label taskContactLabel;
        private System.Windows.Forms.Label taskTimeToLabel;
        private System.Windows.Forms.Label taskFromLabel;
        private System.Windows.Forms.Label taskTimeLabel;
        private System.Windows.Forms.Label taskDateLabel;
        private System.Windows.Forms.Label taskNameLabel;
        private System.Windows.Forms.Label taskHeadingLabel;
        private System.Windows.Forms.Panel appointmentFieldsOutline;
        private System.Windows.Forms.TextBox taskDescText;
        private System.Windows.Forms.TextBox taskNameText;
        private System.Windows.Forms.Label taskDescLabel;
        private System.Windows.Forms.DataGridView taskDataGridView;
        private System.Windows.Forms.BindingSource taskrecordBindingSource;
        private TimeMgtDB timeMgtDB;
        private TimeMgtDBTableAdapters.task_recordTableAdapter task_recordTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn createddatetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tasknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskduedateDataGridViewTextBoxColumn;
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
