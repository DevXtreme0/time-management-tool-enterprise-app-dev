namespace CourseWorkTwo
{
    partial class EventForm
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
            this.eventHeadingLabel = new System.Windows.Forms.Label();
            this.eventDescLabel = new System.Windows.Forms.Label();
            this.eventFieldsOutline = new System.Windows.Forms.Panel();
            this.mandatoryTimeLable = new System.Windows.Forms.Label();
            this.mandatoryCategoryLable = new System.Windows.Forms.Label();
            this.mandatoryDescLable = new System.Windows.Forms.Label();
            this.mandatoryContactLable = new System.Windows.Forms.Label();
            this.mandatoryDateLable = new System.Windows.Forms.Label();
            this.mandatoryTittleLable = new System.Windows.Forms.Label();
            this.mandatoryStar = new System.Windows.Forms.Label();
            this.mandatoryLabel = new System.Windows.Forms.Label();
            this.eventContactsListDropDown = new System.Windows.Forms.ComboBox();
            this.eventTimeToTBox = new System.Windows.Forms.DateTimePicker();
            this.eventTimeFromTBox = new System.Windows.Forms.DateTimePicker();
            this.eventDateToDBox = new System.Windows.Forms.DateTimePicker();
            this.eventDateFromDBox = new System.Windows.Forms.DateTimePicker();
            this.eventYearlyRButton = new System.Windows.Forms.RadioButton();
            this.eventWeeklyRButton = new System.Windows.Forms.RadioButton();
            this.eventMonthlyRButton = new System.Windows.Forms.RadioButton();
            this.eventRecurringRButton = new System.Windows.Forms.RadioButton();
            this.eventOneoffRButton = new System.Windows.Forms.RadioButton();
            this.eventAdditionalText = new System.Windows.Forms.RichTextBox();
            this.eventDescText = new System.Windows.Forms.TextBox();
            this.eventPriorityDropDown = new System.Windows.Forms.ComboBox();
            this.eventLocationText = new System.Windows.Forms.TextBox();
            this.eventNameText = new System.Windows.Forms.TextBox();
            this.eventPriorityLabel = new System.Windows.Forms.Label();
            this.eventANoteLabel = new System.Windows.Forms.Label();
            this.eventRecurringTypeLabel = new System.Windows.Forms.Label();
            this.eventCategoryLabel = new System.Windows.Forms.Label();
            this.evenetDescLabel = new System.Windows.Forms.Label();
            this.eventLocationLabel = new System.Windows.Forms.Label();
            this.eventContactLabel = new System.Windows.Forms.Label();
            this.eventTimeToLabel = new System.Windows.Forms.Label();
            this.timeFromLabel = new System.Windows.Forms.Label();
            this.eventTimeLabel = new System.Windows.Forms.Label();
            this.evenetDateToLabel = new System.Windows.Forms.Label();
            this.eventDateFromLabel = new System.Windows.Forms.Label();
            this.eventDateLabel = new System.Windows.Forms.Label();
            this.eventNameLabel = new System.Windows.Forms.Label();
            this.eventResetButton = new System.Windows.Forms.Button();
            this.eventAddButton = new System.Windows.Forms.Button();
            this.eventEditButton = new System.Windows.Forms.Button();
            this.eventDeleteButton = new System.Windows.Forms.Button();
            this.event_recordTableAdapter = new CourseWorkTwo.TimeMgtDBTableAdapters.event_recordTableAdapter();
            this.eventDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventrecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeMgtDB = new CourseWorkTwo.TimeMgtDB();
            this.eventFieldsOutline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventrecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeMgtDB)).BeginInit();
            this.SuspendLayout();
            // 
            // eventHeadingLabel
            // 
            this.eventHeadingLabel.AutoSize = true;
            this.eventHeadingLabel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.eventHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventHeadingLabel.ForeColor = System.Drawing.Color.White;
            this.eventHeadingLabel.Location = new System.Drawing.Point(36, 5);
            this.eventHeadingLabel.Name = "eventHeadingLabel";
            this.eventHeadingLabel.Size = new System.Drawing.Size(198, 25);
            this.eventHeadingLabel.TabIndex = 0;
            this.eventHeadingLabel.Text = "Event Management";
            // 
            // eventDescLabel
            // 
            this.eventDescLabel.AutoSize = true;
            this.eventDescLabel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.eventDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDescLabel.ForeColor = System.Drawing.Color.White;
            this.eventDescLabel.Location = new System.Drawing.Point(38, 42);
            this.eventDescLabel.Name = "eventDescLabel";
            this.eventDescLabel.Size = new System.Drawing.Size(242, 18);
            this.eventDescLabel.TabIndex = 1;
            this.eventDescLabel.Text = "Manage your events from here.";
            // 
            // eventFieldsOutline
            // 
            this.eventFieldsOutline.BackColor = System.Drawing.SystemColors.Control;
            this.eventFieldsOutline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventFieldsOutline.Controls.Add(this.mandatoryTimeLable);
            this.eventFieldsOutline.Controls.Add(this.mandatoryCategoryLable);
            this.eventFieldsOutline.Controls.Add(this.mandatoryDescLable);
            this.eventFieldsOutline.Controls.Add(this.mandatoryContactLable);
            this.eventFieldsOutline.Controls.Add(this.mandatoryDateLable);
            this.eventFieldsOutline.Controls.Add(this.mandatoryTittleLable);
            this.eventFieldsOutline.Controls.Add(this.mandatoryStar);
            this.eventFieldsOutline.Controls.Add(this.mandatoryLabel);
            this.eventFieldsOutline.Controls.Add(this.eventContactsListDropDown);
            this.eventFieldsOutline.Controls.Add(this.eventTimeToTBox);
            this.eventFieldsOutline.Controls.Add(this.eventTimeFromTBox);
            this.eventFieldsOutline.Controls.Add(this.eventDateToDBox);
            this.eventFieldsOutline.Controls.Add(this.eventDateFromDBox);
            this.eventFieldsOutline.Controls.Add(this.eventYearlyRButton);
            this.eventFieldsOutline.Controls.Add(this.eventWeeklyRButton);
            this.eventFieldsOutline.Controls.Add(this.eventMonthlyRButton);
            this.eventFieldsOutline.Controls.Add(this.eventRecurringRButton);
            this.eventFieldsOutline.Controls.Add(this.eventOneoffRButton);
            this.eventFieldsOutline.Controls.Add(this.eventAdditionalText);
            this.eventFieldsOutline.Controls.Add(this.eventDescText);
            this.eventFieldsOutline.Controls.Add(this.eventPriorityDropDown);
            this.eventFieldsOutline.Controls.Add(this.eventLocationText);
            this.eventFieldsOutline.Controls.Add(this.eventNameText);
            this.eventFieldsOutline.Controls.Add(this.eventPriorityLabel);
            this.eventFieldsOutline.Controls.Add(this.eventANoteLabel);
            this.eventFieldsOutline.Controls.Add(this.eventRecurringTypeLabel);
            this.eventFieldsOutline.Controls.Add(this.eventCategoryLabel);
            this.eventFieldsOutline.Controls.Add(this.evenetDescLabel);
            this.eventFieldsOutline.Controls.Add(this.eventLocationLabel);
            this.eventFieldsOutline.Controls.Add(this.eventContactLabel);
            this.eventFieldsOutline.Controls.Add(this.eventTimeToLabel);
            this.eventFieldsOutline.Controls.Add(this.timeFromLabel);
            this.eventFieldsOutline.Controls.Add(this.eventTimeLabel);
            this.eventFieldsOutline.Controls.Add(this.evenetDateToLabel);
            this.eventFieldsOutline.Controls.Add(this.eventDateFromLabel);
            this.eventFieldsOutline.Controls.Add(this.eventDateLabel);
            this.eventFieldsOutline.Controls.Add(this.eventNameLabel);
            this.eventFieldsOutline.Location = new System.Drawing.Point(50, 71);
            this.eventFieldsOutline.Name = "eventFieldsOutline";
            this.eventFieldsOutline.Size = new System.Drawing.Size(634, 408);
            this.eventFieldsOutline.TabIndex = 2;
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
            this.mandatoryDescLable.Location = new System.Drawing.Point(332, 21);
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
            // eventContactsListDropDown
            // 
            this.eventContactsListDropDown.FormattingEnabled = true;
            this.eventContactsListDropDown.Items.AddRange(new object[] {
            "",
            "None"});
            this.eventContactsListDropDown.Location = new System.Drawing.Point(28, 259);
            this.eventContactsListDropDown.Name = "eventContactsListDropDown";
            this.eventContactsListDropDown.Size = new System.Drawing.Size(236, 24);
            this.eventContactsListDropDown.TabIndex = 34;
            // 
            // eventTimeToTBox
            // 
            this.eventTimeToTBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.eventTimeToTBox.Location = new System.Drawing.Point(150, 199);
            this.eventTimeToTBox.Name = "eventTimeToTBox";
            this.eventTimeToTBox.ShowUpDown = true;
            this.eventTimeToTBox.Size = new System.Drawing.Size(114, 22);
            this.eventTimeToTBox.TabIndex = 33;
            // 
            // eventTimeFromTBox
            // 
            this.eventTimeFromTBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.eventTimeFromTBox.Location = new System.Drawing.Point(30, 198);
            this.eventTimeFromTBox.Name = "eventTimeFromTBox";
            this.eventTimeFromTBox.ShowUpDown = true;
            this.eventTimeFromTBox.Size = new System.Drawing.Size(113, 22);
            this.eventTimeFromTBox.TabIndex = 32;
            // 
            // eventDateToDBox
            // 
            this.eventDateToDBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.eventDateToDBox.Location = new System.Drawing.Point(149, 121);
            this.eventDateToDBox.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.eventDateToDBox.MinDate = new System.DateTime(2019, 12, 5, 0, 0, 0, 0);
            this.eventDateToDBox.Name = "eventDateToDBox";
            this.eventDateToDBox.Size = new System.Drawing.Size(115, 22);
            this.eventDateToDBox.TabIndex = 31;
            // 
            // eventDateFromDBox
            // 
            this.eventDateFromDBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.eventDateFromDBox.Location = new System.Drawing.Point(28, 121);
            this.eventDateFromDBox.MaxDate = new System.DateTime(2025, 12, 5, 0, 0, 0, 0);
            this.eventDateFromDBox.MinDate = new System.DateTime(2019, 12, 5, 0, 0, 0, 0);
            this.eventDateFromDBox.Name = "eventDateFromDBox";
            this.eventDateFromDBox.Size = new System.Drawing.Size(115, 22);
            this.eventDateFromDBox.TabIndex = 30;
            this.eventDateFromDBox.Value = new System.DateTime(2019, 12, 5, 0, 0, 0, 0);
            // 
            // eventYearlyRButton
            // 
            this.eventYearlyRButton.AutoSize = true;
            this.eventYearlyRButton.Location = new System.Drawing.Point(513, 161);
            this.eventYearlyRButton.Name = "eventYearlyRButton";
            this.eventYearlyRButton.Size = new System.Drawing.Size(69, 21);
            this.eventYearlyRButton.TabIndex = 29;
            this.eventYearlyRButton.TabStop = true;
            this.eventYearlyRButton.Text = "Yearly";
            this.eventYearlyRButton.UseVisualStyleBackColor = true;
            // 
            // eventWeeklyRButton
            // 
            this.eventWeeklyRButton.AutoSize = true;
            this.eventWeeklyRButton.Location = new System.Drawing.Point(346, 161);
            this.eventWeeklyRButton.Name = "eventWeeklyRButton";
            this.eventWeeklyRButton.Size = new System.Drawing.Size(75, 21);
            this.eventWeeklyRButton.TabIndex = 28;
            this.eventWeeklyRButton.TabStop = true;
            this.eventWeeklyRButton.Text = "Weekly";
            this.eventWeeklyRButton.UseVisualStyleBackColor = true;
            // 
            // eventMonthlyRButton
            // 
            this.eventMonthlyRButton.AutoSize = true;
            this.eventMonthlyRButton.Location = new System.Drawing.Point(429, 161);
            this.eventMonthlyRButton.Name = "eventMonthlyRButton";
            this.eventMonthlyRButton.Size = new System.Drawing.Size(78, 21);
            this.eventMonthlyRButton.TabIndex = 27;
            this.eventMonthlyRButton.TabStop = true;
            this.eventMonthlyRButton.Text = "Monthly";
            this.eventMonthlyRButton.UseVisualStyleBackColor = true;
            // 
            // eventRecurringRButton
            // 
            this.eventRecurringRButton.AutoSize = true;
            this.eventRecurringRButton.Location = new System.Drawing.Point(429, 103);
            this.eventRecurringRButton.Name = "eventRecurringRButton";
            this.eventRecurringRButton.Size = new System.Drawing.Size(91, 21);
            this.eventRecurringRButton.TabIndex = 26;
            this.eventRecurringRButton.TabStop = true;
            this.eventRecurringRButton.Text = "Recurring";
            this.eventRecurringRButton.UseVisualStyleBackColor = true;
            this.eventRecurringRButton.CheckedChanged += new System.EventHandler(this.eventRecurringRButton_CheckedChanged);
            // 
            // eventOneoffRButton
            // 
            this.eventOneoffRButton.AutoSize = true;
            this.eventOneoffRButton.Location = new System.Drawing.Point(346, 103);
            this.eventOneoffRButton.Name = "eventOneoffRButton";
            this.eventOneoffRButton.Size = new System.Drawing.Size(77, 21);
            this.eventOneoffRButton.TabIndex = 25;
            this.eventOneoffRButton.TabStop = true;
            this.eventOneoffRButton.Text = "One-off";
            this.eventOneoffRButton.UseVisualStyleBackColor = true;
            this.eventOneoffRButton.CheckedChanged += new System.EventHandler(this.eventOneoffRButton_CheckedChanged);
            // 
            // eventAdditionalText
            // 
            this.eventAdditionalText.Location = new System.Drawing.Point(346, 223);
            this.eventAdditionalText.Name = "eventAdditionalText";
            this.eventAdditionalText.Size = new System.Drawing.Size(234, 73);
            this.eventAdditionalText.TabIndex = 20;
            this.eventAdditionalText.Text = "";
            // 
            // eventDescText
            // 
            this.eventDescText.Location = new System.Drawing.Point(346, 43);
            this.eventDescText.Name = "eventDescText";
            this.eventDescText.Size = new System.Drawing.Size(236, 22);
            this.eventDescText.TabIndex = 19;
            // 
            // eventPriorityDropDown
            // 
            this.eventPriorityDropDown.FormattingEnabled = true;
            this.eventPriorityDropDown.Items.AddRange(new object[] {
            "",
            "High",
            "Medium",
            "Low"});
            this.eventPriorityDropDown.Location = new System.Drawing.Point(346, 337);
            this.eventPriorityDropDown.Name = "eventPriorityDropDown";
            this.eventPriorityDropDown.Size = new System.Drawing.Size(236, 24);
            this.eventPriorityDropDown.TabIndex = 18;
            // 
            // eventLocationText
            // 
            this.eventLocationText.Location = new System.Drawing.Point(28, 337);
            this.eventLocationText.Name = "eventLocationText";
            this.eventLocationText.Size = new System.Drawing.Size(236, 22);
            this.eventLocationText.TabIndex = 17;
            // 
            // eventNameText
            // 
            this.eventNameText.Location = new System.Drawing.Point(28, 43);
            this.eventNameText.Name = "eventNameText";
            this.eventNameText.Size = new System.Drawing.Size(236, 22);
            this.eventNameText.TabIndex = 16;
            // 
            // eventPriorityLabel
            // 
            this.eventPriorityLabel.AutoSize = true;
            this.eventPriorityLabel.Location = new System.Drawing.Point(343, 315);
            this.eventPriorityLabel.Name = "eventPriorityLabel";
            this.eventPriorityLabel.Size = new System.Drawing.Size(56, 17);
            this.eventPriorityLabel.TabIndex = 15;
            this.eventPriorityLabel.Text = "Priority:";
            // 
            // eventANoteLabel
            // 
            this.eventANoteLabel.AutoSize = true;
            this.eventANoteLabel.Location = new System.Drawing.Point(345, 203);
            this.eventANoteLabel.Name = "eventANoteLabel";
            this.eventANoteLabel.Size = new System.Drawing.Size(108, 17);
            this.eventANoteLabel.TabIndex = 14;
            this.eventANoteLabel.Text = "Additional Note:";
            // 
            // eventRecurringTypeLabel
            // 
            this.eventRecurringTypeLabel.AutoSize = true;
            this.eventRecurringTypeLabel.Location = new System.Drawing.Point(345, 141);
            this.eventRecurringTypeLabel.Name = "eventRecurringTypeLabel";
            this.eventRecurringTypeLabel.Size = new System.Drawing.Size(110, 17);
            this.eventRecurringTypeLabel.TabIndex = 13;
            this.eventRecurringTypeLabel.Text = "Recurring Type:";
            // 
            // eventCategoryLabel
            // 
            this.eventCategoryLabel.AutoSize = true;
            this.eventCategoryLabel.Location = new System.Drawing.Point(343, 83);
            this.eventCategoryLabel.Name = "eventCategoryLabel";
            this.eventCategoryLabel.Size = new System.Drawing.Size(69, 17);
            this.eventCategoryLabel.TabIndex = 12;
            this.eventCategoryLabel.Text = "Category:";
            // 
            // evenetDescLabel
            // 
            this.evenetDescLabel.AutoSize = true;
            this.evenetDescLabel.Location = new System.Drawing.Point(343, 23);
            this.evenetDescLabel.Name = "evenetDescLabel";
            this.evenetDescLabel.Size = new System.Drawing.Size(83, 17);
            this.evenetDescLabel.TabIndex = 10;
            this.evenetDescLabel.Text = "Description:";
            // 
            // eventLocationLabel
            // 
            this.eventLocationLabel.AutoSize = true;
            this.eventLocationLabel.Location = new System.Drawing.Point(25, 315);
            this.eventLocationLabel.Name = "eventLocationLabel";
            this.eventLocationLabel.Size = new System.Drawing.Size(66, 17);
            this.eventLocationLabel.TabIndex = 9;
            this.eventLocationLabel.Text = "Location:";
            // 
            // eventContactLabel
            // 
            this.eventContactLabel.AutoSize = true;
            this.eventContactLabel.Location = new System.Drawing.Point(27, 238);
            this.eventContactLabel.Name = "eventContactLabel";
            this.eventContactLabel.Size = new System.Drawing.Size(109, 17);
            this.eventContactLabel.TabIndex = 7;
            this.eventContactLabel.Text = "Contact Person:";
            // 
            // eventTimeToLabel
            // 
            this.eventTimeToLabel.AutoSize = true;
            this.eventTimeToLabel.Location = new System.Drawing.Point(170, 178);
            this.eventTimeToLabel.Name = "eventTimeToLabel";
            this.eventTimeToLabel.Size = new System.Drawing.Size(20, 17);
            this.eventTimeToLabel.TabIndex = 6;
            this.eventTimeToLabel.Text = "to";
            // 
            // timeFromLabel
            // 
            this.timeFromLabel.AutoSize = true;
            this.timeFromLabel.Location = new System.Drawing.Point(55, 178);
            this.timeFromLabel.Name = "timeFromLabel";
            this.timeFromLabel.Size = new System.Drawing.Size(36, 17);
            this.timeFromLabel.TabIndex = 5;
            this.timeFromLabel.Text = "from";
            // 
            // eventTimeLabel
            // 
            this.eventTimeLabel.AutoSize = true;
            this.eventTimeLabel.Location = new System.Drawing.Point(25, 161);
            this.eventTimeLabel.Name = "eventTimeLabel";
            this.eventTimeLabel.Size = new System.Drawing.Size(43, 17);
            this.eventTimeLabel.TabIndex = 4;
            this.eventTimeLabel.Text = "Time:";
            // 
            // evenetDateToLabel
            // 
            this.evenetDateToLabel.AutoSize = true;
            this.evenetDateToLabel.Location = new System.Drawing.Point(170, 103);
            this.evenetDateToLabel.Name = "evenetDateToLabel";
            this.evenetDateToLabel.Size = new System.Drawing.Size(20, 17);
            this.evenetDateToLabel.TabIndex = 3;
            this.evenetDateToLabel.Text = "to";
            // 
            // eventDateFromLabel
            // 
            this.eventDateFromLabel.AutoSize = true;
            this.eventDateFromLabel.Location = new System.Drawing.Point(55, 103);
            this.eventDateFromLabel.Name = "eventDateFromLabel";
            this.eventDateFromLabel.Size = new System.Drawing.Size(36, 17);
            this.eventDateFromLabel.TabIndex = 2;
            this.eventDateFromLabel.Text = "from";
            // 
            // eventDateLabel
            // 
            this.eventDateLabel.AutoSize = true;
            this.eventDateLabel.Location = new System.Drawing.Point(25, 83);
            this.eventDateLabel.Name = "eventDateLabel";
            this.eventDateLabel.Size = new System.Drawing.Size(42, 17);
            this.eventDateLabel.TabIndex = 1;
            this.eventDateLabel.Text = "Date:";
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.Location = new System.Drawing.Point(25, 23);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(49, 17);
            this.eventNameLabel.TabIndex = 0;
            this.eventNameLabel.Text = "Name:";
            // 
            // eventResetButton
            // 
            this.eventResetButton.Location = new System.Drawing.Point(365, 501);
            this.eventResetButton.Name = "eventResetButton";
            this.eventResetButton.Size = new System.Drawing.Size(75, 35);
            this.eventResetButton.TabIndex = 3;
            this.eventResetButton.Text = "Reset";
            this.eventResetButton.UseVisualStyleBackColor = true;
            this.eventResetButton.Click += new System.EventHandler(this.eventResetButton_Click);
            // 
            // eventAddButton
            // 
            this.eventAddButton.Location = new System.Drawing.Point(446, 501);
            this.eventAddButton.Name = "eventAddButton";
            this.eventAddButton.Size = new System.Drawing.Size(75, 35);
            this.eventAddButton.TabIndex = 4;
            this.eventAddButton.Text = "Add";
            this.eventAddButton.UseVisualStyleBackColor = true;
            this.eventAddButton.Click += new System.EventHandler(this.eventAddButton_Click);
            // 
            // eventEditButton
            // 
            this.eventEditButton.Location = new System.Drawing.Point(527, 501);
            this.eventEditButton.Name = "eventEditButton";
            this.eventEditButton.Size = new System.Drawing.Size(75, 35);
            this.eventEditButton.TabIndex = 5;
            this.eventEditButton.Text = "Edit";
            this.eventEditButton.UseVisualStyleBackColor = true;
            this.eventEditButton.Click += new System.EventHandler(this.eventEditButton_Click);
            // 
            // eventDeleteButton
            // 
            this.eventDeleteButton.Location = new System.Drawing.Point(608, 501);
            this.eventDeleteButton.Name = "eventDeleteButton";
            this.eventDeleteButton.Size = new System.Drawing.Size(75, 35);
            this.eventDeleteButton.TabIndex = 6;
            this.eventDeleteButton.Text = "Delete";
            this.eventDeleteButton.UseVisualStyleBackColor = true;
            this.eventDeleteButton.Click += new System.EventHandler(this.eventDeleteButton_Click);
            // 
            // event_recordTableAdapter
            // 
            this.event_recordTableAdapter.ClearBeforeFill = true;
            // 
            // eventDataGridView
            // 
            this.eventDataGridView.AllowUserToAddRows = false;
            this.eventDataGridView.AllowUserToDeleteRows = false;
            this.eventDataGridView.AllowUserToOrderColumns = true;
            this.eventDataGridView.AllowUserToResizeRows = false;
            this.eventDataGridView.AutoGenerateColumns = false;
            this.eventDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn23});
            this.eventDataGridView.DataSource = this.eventrecordBindingSource;
            this.eventDataGridView.Location = new System.Drawing.Point(50, 562);
            this.eventDataGridView.MultiSelect = false;
            this.eventDataGridView.Name = "eventDataGridView";
            this.eventDataGridView.ReadOnly = true;
            this.eventDataGridView.RowHeadersVisible = false;
            this.eventDataGridView.RowHeadersWidth = 51;
            this.eventDataGridView.RowTemplate.Height = 24;
            this.eventDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eventDataGridView.Size = new System.Drawing.Size(634, 199);
            this.eventDataGridView.TabIndex = 7;
            this.eventDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "created_date_time";
            this.dataGridViewTextBoxColumn22.HeaderText = "created_date_time";
            this.dataGridViewTextBoxColumn22.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "event_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "event_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "event_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "event_name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "date_from";
            this.dataGridViewTextBoxColumn13.HeaderText = "date_from";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "date_to";
            this.dataGridViewTextBoxColumn14.HeaderText = "date_to";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "time_from";
            this.dataGridViewTextBoxColumn15.HeaderText = "time_from";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "time_to";
            this.dataGridViewTextBoxColumn16.HeaderText = "time_to";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "location";
            this.dataGridViewTextBoxColumn17.HeaderText = "location";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 125;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn18.HeaderText = "description";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 125;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "category";
            this.dataGridViewTextBoxColumn19.HeaderText = "category";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 125;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "additional_note";
            this.dataGridViewTextBoxColumn20.HeaderText = "additional_note";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 125;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "priority_level";
            this.dataGridViewTextBoxColumn21.HeaderText = "priority_level";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Width = 125;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "contact_name";
            this.dataGridViewTextBoxColumn24.HeaderText = "contact_name";
            this.dataGridViewTextBoxColumn24.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Width = 125;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "updated_date_time";
            this.dataGridViewTextBoxColumn23.HeaderText = "updated_date_time";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Width = 125;
            // 
            // eventrecordBindingSource
            // 
            this.eventrecordBindingSource.DataMember = "event_record";
            this.eventrecordBindingSource.DataSource = this.timeMgtDB;
            // 
            // timeMgtDB
            // 
            this.timeMgtDB.DataSetName = "TimeMgtDB";
            this.timeMgtDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Controls.Add(this.eventDataGridView);
            this.Controls.Add(this.eventDeleteButton);
            this.Controls.Add(this.eventEditButton);
            this.Controls.Add(this.eventAddButton);
            this.Controls.Add(this.eventResetButton);
            this.Controls.Add(this.eventFieldsOutline);
            this.Controls.Add(this.eventDescLabel);
            this.Controls.Add(this.eventHeadingLabel);
            this.Name = "EventForm";
            this.Size = new System.Drawing.Size(720, 800);
            this.eventFieldsOutline.ResumeLayout(false);
            this.eventFieldsOutline.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventrecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeMgtDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eventHeadingLabel;
        private System.Windows.Forms.Label eventDescLabel;
        private System.Windows.Forms.Panel eventFieldsOutline;
        private System.Windows.Forms.Label eventDateLabel;
        private System.Windows.Forms.Label eventNameLabel;
        private System.Windows.Forms.Label evenetDescLabel;
        private System.Windows.Forms.Label eventLocationLabel;
        private System.Windows.Forms.Label eventContactLabel;
        private System.Windows.Forms.Label eventTimeToLabel;
        private System.Windows.Forms.Label timeFromLabel;
        private System.Windows.Forms.Label eventTimeLabel;
        private System.Windows.Forms.Label evenetDateToLabel;
        private System.Windows.Forms.Label eventDateFromLabel;
        private System.Windows.Forms.TextBox eventDescText;
        private System.Windows.Forms.ComboBox eventPriorityDropDown;
        private System.Windows.Forms.TextBox eventLocationText;
        private System.Windows.Forms.TextBox eventNameText;
        private System.Windows.Forms.Label eventPriorityLabel;
        private System.Windows.Forms.Label eventANoteLabel;
        private System.Windows.Forms.Label eventRecurringTypeLabel;
        private System.Windows.Forms.Label eventCategoryLabel;
        private System.Windows.Forms.RichTextBox eventAdditionalText;
        private System.Windows.Forms.RadioButton eventOneoffRButton;
        private System.Windows.Forms.RadioButton eventRecurringRButton;
        private System.Windows.Forms.DateTimePicker eventDateFromDBox;
        private System.Windows.Forms.RadioButton eventYearlyRButton;
        private System.Windows.Forms.RadioButton eventWeeklyRButton;
        private System.Windows.Forms.RadioButton eventMonthlyRButton;
        private System.Windows.Forms.DateTimePicker eventDateToDBox;
        private System.Windows.Forms.DateTimePicker eventTimeToTBox;
        private System.Windows.Forms.DateTimePicker eventTimeFromTBox;
        private System.Windows.Forms.Button eventResetButton;
        private System.Windows.Forms.Button eventAddButton;
        private System.Windows.Forms.Button eventEditButton;
        private System.Windows.Forms.Button eventDeleteButton;

        private System.Windows.Forms.ComboBox eventContactsListDropDown;
   
        private System.Windows.Forms.Label mandatoryStar;
        private System.Windows.Forms.Label mandatoryLabel;
        private System.Windows.Forms.Label mandatoryTimeLable;
        private System.Windows.Forms.Label mandatoryCategoryLable;
        private System.Windows.Forms.Label mandatoryDescLable;
        private System.Windows.Forms.Label mandatoryContactLable;
        private System.Windows.Forms.Label mandatoryDateLable;
        private System.Windows.Forms.Label mandatoryTittleLable;
  
        private TimeMgtDBTableAdapters.event_recordTableAdapter event_recordTableAdapter;
        private System.Windows.Forms.DataGridView eventDataGridView;
        private System.Windows.Forms.BindingSource eventrecordBindingSource;
        private TimeMgtDB timeMgtDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
    }
}
