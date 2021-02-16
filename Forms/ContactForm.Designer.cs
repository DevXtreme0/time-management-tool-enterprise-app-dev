using System;

namespace CourseWorkTwo
{
    partial class ContactForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contactHeadingLabel = new System.Windows.Forms.Label();
            this.occupationText = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.surNameText = new System.Windows.Forms.TextBox();
            this.contactNumberText = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.occupationLabel = new System.Windows.Forms.Label();
            this.contactNumberLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.tittleLabel = new System.Windows.Forms.Label();
            this.contactAddButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.contactEditButton = new System.Windows.Forms.Button();
            this.contactDeleteButton = new System.Windows.Forms.Button();
            this.mandatoryLabel = new System.Windows.Forms.Label();
            this.mandatoryStar = new System.Windows.Forms.Label();
            this.outline = new System.Windows.Forms.Panel();
            this.TittleDropDown = new System.Windows.Forms.ComboBox();
            this.mandatoryContactNLabel = new System.Windows.Forms.Label();
            this.mandatoryEmailLabel = new System.Windows.Forms.Label();
            this.mandatoryFNLabel = new System.Windows.Forms.Label();
            this.mandatorySurNLabel = new System.Windows.Forms.Label();
            this.mandatoryTittleLable = new System.Windows.Forms.Label();
            this.contactDescLabel = new System.Windows.Forms.Label();
            this.contactTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeMgtDB1 = new CourseWorkTwo.TimeMgtDB();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeMgtDB = new CourseWorkTwo.TimeMgtDB();
            this.contactpersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contact_personTableAdapter = new CourseWorkTwo.TimeMgtDBTableAdapters.contact_personTableAdapter();
            this.contactDataGridView = new System.Windows.Forms.DataGridView();
            this.contactidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createddatetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courtesytittleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactpersonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.outline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeMgtDB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeMgtDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactpersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactpersonBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // contactHeadingLabel
            // 
            this.contactHeadingLabel.AutoSize = true;
            this.contactHeadingLabel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.contactHeadingLabel.CausesValidation = false;
            this.contactHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactHeadingLabel.ForeColor = System.Drawing.Color.White;
            this.contactHeadingLabel.Location = new System.Drawing.Point(36, 5);
            this.contactHeadingLabel.Name = "contactHeadingLabel";
            this.contactHeadingLabel.Size = new System.Drawing.Size(218, 25);
            this.contactHeadingLabel.TabIndex = 0;
            this.contactHeadingLabel.Text = "Contact Management";
            // 
            // occupationText
            // 
            this.occupationText.Location = new System.Drawing.Point(417, 170);
            this.occupationText.Name = "occupationText";
            this.occupationText.Size = new System.Drawing.Size(200, 22);
            this.occupationText.TabIndex = 1;
            this.occupationText.TextChanged += new System.EventHandler(this.occupationText_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(335, 26);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(80, 17);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "First Name:";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(417, 23);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(200, 22);
            this.firstNameText.TabIndex = 3;
            this.firstNameText.TextChanged += new System.EventHandler(this.firstNameText_TextChanged);
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(417, 97);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(200, 22);
            this.emailText.TabIndex = 4;
            this.emailText.TextChanged += new System.EventHandler(this.emailText_TextChanged);
            // 
            // surNameText
            // 
            this.surNameText.Location = new System.Drawing.Point(89, 97);
            this.surNameText.Name = "surNameText";
            this.surNameText.Size = new System.Drawing.Size(200, 22);
            this.surNameText.TabIndex = 5;
            this.surNameText.TextChanged += new System.EventHandler(this.surNameText_TextChanged);
            // 
            // contactNumberText
            // 
            this.contactNumberText.Location = new System.Drawing.Point(89, 170);
            this.contactNumberText.Name = "contactNumberText";
            this.contactNumberText.Size = new System.Drawing.Size(200, 22);
            this.contactNumberText.TabIndex = 6;
            this.contactNumberText.TextChanged += new System.EventHandler(this.pNumberText_TextChanged);
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(18, 100);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(69, 17);
            this.surnameLabel.TabIndex = 8;
            this.surnameLabel.Text = "Surname:";
            // 
            // occupationLabel
            // 
            this.occupationLabel.AutoSize = true;
            this.occupationLabel.Location = new System.Drawing.Point(339, 173);
            this.occupationLabel.Name = "occupationLabel";
            this.occupationLabel.Size = new System.Drawing.Size(79, 17);
            this.occupationLabel.TabIndex = 9;
            this.occupationLabel.Text = "Profession:";
            // 
            // contactNumberLabel
            // 
            this.contactNumberLabel.AutoSize = true;
            this.contactNumberLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.contactNumberLabel.Location = new System.Drawing.Point(25, 156);
            this.contactNumberLabel.Name = "contactNumberLabel";
            this.contactNumberLabel.Size = new System.Drawing.Size(62, 34);
            this.contactNumberLabel.TabIndex = 10;
            this.contactNumberLabel.Text = "Contact\nNumber:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(369, 100);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(46, 17);
            this.emailLabel.TabIndex = 11;
            this.emailLabel.Text = "Email:";
            // 
            // tittleLabel
            // 
            this.tittleLabel.AutoSize = true;
            this.tittleLabel.Location = new System.Drawing.Point(23, 14);
            this.tittleLabel.Name = "tittleLabel";
            this.tittleLabel.Size = new System.Drawing.Size(64, 34);
            this.tittleLabel.TabIndex = 12;
            this.tittleLabel.Text = "Courtesy\n  Tittle:";
            // 
            // contactAddButton
            // 
            this.contactAddButton.Location = new System.Drawing.Point(449, 337);
            this.contactAddButton.Name = "contactAddButton";
            this.contactAddButton.Size = new System.Drawing.Size(75, 35);
            this.contactAddButton.TabIndex = 14;
            this.contactAddButton.Text = "Add";
            this.contactAddButton.UseVisualStyleBackColor = true;
            this.contactAddButton.Click += new System.EventHandler(this.contactAddButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(368, 337);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 35);
            this.resetButton.TabIndex = 15;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // contactEditButton
            // 
            this.contactEditButton.Location = new System.Drawing.Point(530, 337);
            this.contactEditButton.Name = "contactEditButton";
            this.contactEditButton.Size = new System.Drawing.Size(75, 35);
            this.contactEditButton.TabIndex = 18;
            this.contactEditButton.Text = "Edit";
            this.contactEditButton.UseVisualStyleBackColor = true;
            this.contactEditButton.Click += new System.EventHandler(this.contactEditButton_Click);
            // 
            // contactDeleteButton
            // 
            this.contactDeleteButton.Location = new System.Drawing.Point(611, 337);
            this.contactDeleteButton.Name = "contactDeleteButton";
            this.contactDeleteButton.Size = new System.Drawing.Size(75, 35);
            this.contactDeleteButton.TabIndex = 19;
            this.contactDeleteButton.Text = "Delete";
            this.contactDeleteButton.UseVisualStyleBackColor = true;
            this.contactDeleteButton.Click += new System.EventHandler(this.contactDeleteButton_Click);
            // 
            // mandatoryLabel
            // 
            this.mandatoryLabel.AutoSize = true;
            this.mandatoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mandatoryLabel.ForeColor = System.Drawing.Color.Red;
            this.mandatoryLabel.Location = new System.Drawing.Point(131, 220);
            this.mandatoryLabel.Name = "mandatoryLabel";
            this.mandatoryLabel.Size = new System.Drawing.Size(95, 15);
            this.mandatoryLabel.TabIndex = 20;
            this.mandatoryLabel.Text = "Mandatory Field";
            // 
            // mandatoryStar
            // 
            this.mandatoryStar.AutoSize = true;
            this.mandatoryStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mandatoryStar.ForeColor = System.Drawing.Color.Red;
            this.mandatoryStar.Location = new System.Drawing.Point(88, 215);
            this.mandatoryStar.Name = "mandatoryStar";
            this.mandatoryStar.Size = new System.Drawing.Size(37, 20);
            this.mandatoryStar.TabIndex = 21;
            this.mandatoryStar.Text = "( * )";
            // 
            // outline
            // 
            this.outline.BackColor = System.Drawing.SystemColors.Control;
            this.outline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outline.Controls.Add(this.TittleDropDown);
            this.outline.Controls.Add(this.mandatoryContactNLabel);
            this.outline.Controls.Add(this.mandatoryEmailLabel);
            this.outline.Controls.Add(this.mandatoryFNLabel);
            this.outline.Controls.Add(this.mandatorySurNLabel);
            this.outline.Controls.Add(this.mandatoryTittleLable);
            this.outline.Controls.Add(this.mandatoryStar);
            this.outline.Controls.Add(this.mandatoryLabel);
            this.outline.Controls.Add(this.occupationText);
            this.outline.Controls.Add(this.nameLabel);
            this.outline.Controls.Add(this.tittleLabel);
            this.outline.Controls.Add(this.firstNameText);
            this.outline.Controls.Add(this.occupationLabel);
            this.outline.Controls.Add(this.emailLabel);
            this.outline.Controls.Add(this.emailText);
            this.outline.Controls.Add(this.contactNumberLabel);
            this.outline.Controls.Add(this.surNameText);
            this.outline.Controls.Add(this.contactNumberText);
            this.outline.Controls.Add(this.surnameLabel);
            this.outline.Location = new System.Drawing.Point(52, 73);
            this.outline.Name = "outline";
            this.outline.Size = new System.Drawing.Size(634, 248);
            this.outline.TabIndex = 22;
            // 
            // TittleDropDown
            // 
            this.TittleDropDown.FormattingEnabled = true;
            this.TittleDropDown.Items.AddRange(new object[] {
            "None",
            "Dr.",
            "Prof.",
            "Rev.",
            "Sir.",
            "Madam.",
            "Mr.",
            "Ms.",
            "Studunt.",
            "Friend."});
            this.TittleDropDown.Location = new System.Drawing.Point(89, 19);
            this.TittleDropDown.Name = "TittleDropDown";
            this.TittleDropDown.Size = new System.Drawing.Size(200, 24);
            this.TittleDropDown.TabIndex = 28;
            // 
            // mandatoryContactNLabel
            // 
            this.mandatoryContactNLabel.AutoSize = true;
            this.mandatoryContactNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.mandatoryContactNLabel.ForeColor = System.Drawing.Color.Red;
            this.mandatoryContactNLabel.Location = new System.Drawing.Point(12, 156);
            this.mandatoryContactNLabel.Name = "mandatoryContactNLabel";
            this.mandatoryContactNLabel.Size = new System.Drawing.Size(14, 18);
            this.mandatoryContactNLabel.TabIndex = 26;
            this.mandatoryContactNLabel.Text = "*";
            // 
            // mandatoryEmailLabel
            // 
            this.mandatoryEmailLabel.AutoSize = true;
            this.mandatoryEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.mandatoryEmailLabel.ForeColor = System.Drawing.Color.Red;
            this.mandatoryEmailLabel.Location = new System.Drawing.Point(357, 97);
            this.mandatoryEmailLabel.Name = "mandatoryEmailLabel";
            this.mandatoryEmailLabel.Size = new System.Drawing.Size(14, 18);
            this.mandatoryEmailLabel.TabIndex = 25;
            this.mandatoryEmailLabel.Text = "*";
            // 
            // mandatoryFNLabel
            // 
            this.mandatoryFNLabel.AutoSize = true;
            this.mandatoryFNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.mandatoryFNLabel.ForeColor = System.Drawing.Color.Red;
            this.mandatoryFNLabel.Location = new System.Drawing.Point(322, 24);
            this.mandatoryFNLabel.Name = "mandatoryFNLabel";
            this.mandatoryFNLabel.Size = new System.Drawing.Size(14, 18);
            this.mandatoryFNLabel.TabIndex = 23;
            this.mandatoryFNLabel.Text = "*";
            // 
            // mandatorySurNLabel
            // 
            this.mandatorySurNLabel.AutoSize = true;
            this.mandatorySurNLabel.BackColor = System.Drawing.Color.Transparent;
            this.mandatorySurNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.mandatorySurNLabel.ForeColor = System.Drawing.Color.Red;
            this.mandatorySurNLabel.Location = new System.Drawing.Point(6, 97);
            this.mandatorySurNLabel.Name = "mandatorySurNLabel";
            this.mandatorySurNLabel.Size = new System.Drawing.Size(14, 18);
            this.mandatorySurNLabel.TabIndex = 24;
            this.mandatorySurNLabel.Text = "*";
            // 
            // mandatoryTittleLable
            // 
            this.mandatoryTittleLable.AutoSize = true;
            this.mandatoryTittleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.mandatoryTittleLable.ForeColor = System.Drawing.Color.Red;
            this.mandatoryTittleLable.Location = new System.Drawing.Point(10, 12);
            this.mandatoryTittleLable.Name = "mandatoryTittleLable";
            this.mandatoryTittleLable.Size = new System.Drawing.Size(14, 18);
            this.mandatoryTittleLable.TabIndex = 22;
            this.mandatoryTittleLable.Text = "*";
            // 
            // contactDescLabel
            // 
            this.contactDescLabel.AutoSize = true;
            this.contactDescLabel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.contactDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactDescLabel.ForeColor = System.Drawing.Color.White;
            this.contactDescLabel.Location = new System.Drawing.Point(38, 42);
            this.contactDescLabel.Name = "contactDescLabel";
            this.contactDescLabel.Size = new System.Drawing.Size(258, 18);
            this.contactDescLabel.TabIndex = 23;
            this.contactDescLabel.Text = "Manage your contacts from here.";
            // 
            // contactTableBindingSource
            // 
            this.contactTableBindingSource.DataMember = "contact_person";
            this.contactTableBindingSource.DataSource = this.timeMgtDB1;
            // 
            // timeMgtDB1
            // 
            this.timeMgtDB1.DataSetName = "TimeMgtDB";
            this.timeMgtDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataMember = "contact_person";
            this.contactBindingSource.DataSource = this.timeMgtDB;
            // 
            // timeMgtDB
            // 
            this.timeMgtDB.DataSetName = "TimeMgtDB";
            this.timeMgtDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactpersonBindingSource
            // 
            this.contactpersonBindingSource.DataMember = "contact_person";
            this.contactpersonBindingSource.DataSource = this.timeMgtDB1;
            // 
            // contact_personTableAdapter
            // 
            this.contact_personTableAdapter.ClearBeforeFill = true;
            // 
            // contactDataGridView
            // 
            this.contactDataGridView.AllowUserToAddRows = false;
            this.contactDataGridView.AllowUserToDeleteRows = false;
            this.contactDataGridView.AllowUserToOrderColumns = true;
            this.contactDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contactDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.contactDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contactidDataGridViewTextBoxColumn,
            this.createddatetimeDataGridViewTextBoxColumn,
            this.courtesytittleDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.emailaddressDataGridViewTextBoxColumn,
            this.professionDataGridViewTextBoxColumn});
            this.contactDataGridView.DataSource = this.contactpersonBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = "N/A";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.contactDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.contactDataGridView.Location = new System.Drawing.Point(52, 389);
            this.contactDataGridView.MultiSelect = false;
            this.contactDataGridView.Name = "contactDataGridView";
            this.contactDataGridView.ReadOnly = true;
            this.contactDataGridView.RowHeadersVisible = false;
            this.contactDataGridView.RowHeadersWidth = 51;
            this.contactDataGridView.RowTemplate.Height = 24;
            this.contactDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contactDataGridView.Size = new System.Drawing.Size(634, 372);
            this.contactDataGridView.TabIndex = 24;
            this.contactDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contactDataGridView_CellContentClick_2);
            // 
            // contactidDataGridViewTextBoxColumn
            // 
            this.contactidDataGridViewTextBoxColumn.DataPropertyName = "contact_id";
            this.contactidDataGridViewTextBoxColumn.HeaderText = "Contact Id";
            this.contactidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactidDataGridViewTextBoxColumn.Name = "contactidDataGridViewTextBoxColumn";
            this.contactidDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.contactidDataGridViewTextBoxColumn.Visible = false;
            this.contactidDataGridViewTextBoxColumn.Width = 125;
            // 
            // createddatetimeDataGridViewTextBoxColumn
            // 
            this.createddatetimeDataGridViewTextBoxColumn.DataPropertyName = "created_date_time";
            this.createddatetimeDataGridViewTextBoxColumn.HeaderText = "Created Date & Time";
            this.createddatetimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createddatetimeDataGridViewTextBoxColumn.Name = "createddatetimeDataGridViewTextBoxColumn";
            this.createddatetimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.createddatetimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.createddatetimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // courtesytittleDataGridViewTextBoxColumn
            // 
            this.courtesytittleDataGridViewTextBoxColumn.DataPropertyName = "courtesy_tittle";
            this.courtesytittleDataGridViewTextBoxColumn.HeaderText = "Courtesy Tittle";
            this.courtesytittleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courtesytittleDataGridViewTextBoxColumn.Name = "courtesytittleDataGridViewTextBoxColumn";
            this.courtesytittleDataGridViewTextBoxColumn.ReadOnly = true;
            this.courtesytittleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.courtesytittleDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstnameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.firstnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.surnameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.surnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phonenumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phonenumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.phonenumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailaddressDataGridViewTextBoxColumn
            // 
            this.emailaddressDataGridViewTextBoxColumn.DataPropertyName = "email_address";
            this.emailaddressDataGridViewTextBoxColumn.HeaderText = "Email Address";
            this.emailaddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailaddressDataGridViewTextBoxColumn.Name = "emailaddressDataGridViewTextBoxColumn";
            this.emailaddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailaddressDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.emailaddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // professionDataGridViewTextBoxColumn
            // 
            this.professionDataGridViewTextBoxColumn.DataPropertyName = "profession";
            this.professionDataGridViewTextBoxColumn.HeaderText = "Profession";
            this.professionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.professionDataGridViewTextBoxColumn.Name = "professionDataGridViewTextBoxColumn";
            this.professionDataGridViewTextBoxColumn.ReadOnly = true;
            this.professionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.professionDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactpersonBindingSource1
            // 
            this.contactpersonBindingSource1.DataMember = "contact_person";
            this.contactpersonBindingSource1.DataSource = this.timeMgtDB1;
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Controls.Add(this.contactDataGridView);
            this.Controls.Add(this.contactDescLabel);
            this.Controls.Add(this.outline);
            this.Controls.Add(this.contactDeleteButton);
            this.Controls.Add(this.contactEditButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.contactAddButton);
            this.Controls.Add(this.contactHeadingLabel);
            this.Name = "ContactForm";
            this.Size = new System.Drawing.Size(720, 800);
            this.outline.ResumeLayout(false);
            this.outline.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeMgtDB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeMgtDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactpersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactpersonBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label contactHeadingLabel;
        private System.Windows.Forms.TextBox occupationText;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox surNameText;
        private System.Windows.Forms.TextBox contactNumberText;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label occupationLabel;
        private System.Windows.Forms.Label contactNumberLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label tittleLabel;
        private System.Windows.Forms.Button contactAddButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private TimeMgtDB timeMgtDB;
        private System.Windows.Forms.Button contactEditButton;
        private System.Windows.Forms.Button contactDeleteButton;
        private TimeMgtDB timeMgtDB1;
        private System.Windows.Forms.Label mandatoryLabel;
        private System.Windows.Forms.Label mandatoryStar;
        private System.Windows.Forms.Panel outline;
        private System.Windows.Forms.Label contactDescLabel;
        private System.Windows.Forms.Label mandatoryFNLabel;
        private System.Windows.Forms.Label mandatorySurNLabel;
        private System.Windows.Forms.Label mandatoryTittleLable;
        private System.Windows.Forms.Label mandatoryEmailLabel;
        private System.Windows.Forms.Label mandatoryContactNLabel;
        private System.Windows.Forms.BindingSource contactTableBindingSource;
        private System.Windows.Forms.BindingSource contactpersonBindingSource;
        private TimeMgtDBTableAdapters.contact_personTableAdapter contact_personTableAdapter;
        private System.Windows.Forms.DataGridView contactDataGridView;
        private System.Windows.Forms.BindingSource contactpersonBindingSource1;
        private System.Windows.Forms.ComboBox TittleDropDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createddatetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courtesytittleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professionDataGridViewTextBoxColumn;
    }
}
