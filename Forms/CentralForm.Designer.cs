namespace CourseWorkTwo
{
    partial class CentralForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.signoutButton = new System.Windows.Forms.Button();
            this.contactTabButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.lastLoginDateAndTime = new System.Windows.Forms.Label();
            this.lastLoginResultLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.welcomeHeadingLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.taskButton = new System.Windows.Forms.Button();
            this.appointmentTab = new System.Windows.Forms.Button();
            this.eventTabButton = new System.Windows.Forms.Button();
            this.contactForm = new CourseWorkTwo.ContactForm();
            this.eventForm = new CourseWorkTwo.EventForm();
            this.appointmentForm = new CourseWorkTwo.Forms.AppointmentForm();
            this.auditTraceForm = new CourseWorkTwo.Forms.AuditTraceForm();
            this.predictionForm = new CourseWorkTwo.Forms.PredictionForm();
            this.reportForm = new CourseWorkTwo.Forms.ReportForm();
            this.taskForm = new CourseWorkTwo.Forms.TaskForm();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // signoutButton
            // 
            this.signoutButton.BackColor = System.Drawing.Color.LimeGreen;
            this.signoutButton.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.signoutButton.FlatAppearance.BorderSize = 2;
            this.signoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.signoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signoutButton.Location = new System.Drawing.Point(73, 727);
            this.signoutButton.Name = "signoutButton";
            this.signoutButton.Size = new System.Drawing.Size(103, 52);
            this.signoutButton.TabIndex = 0;
            this.signoutButton.Text = "Sign Out";
            this.signoutButton.UseVisualStyleBackColor = false;
            this.signoutButton.Click += new System.EventHandler(this.signoutButton_Click);
            // 
            // contactTabButton
            // 
            this.contactTabButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.contactTabButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.contactTabButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.contactTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.contactTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactTabButton.Location = new System.Drawing.Point(0, 138);
            this.contactTabButton.Name = "contactTabButton";
            this.contactTabButton.Size = new System.Drawing.Size(254, 77);
            this.contactTabButton.TabIndex = 1;
            this.contactTabButton.Text = "Contact";
            this.contactTabButton.UseVisualStyleBackColor = false;
            this.contactTabButton.Click += new System.EventHandler(this.contactTab_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.signoutButton);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.taskButton);
            this.panel1.Controls.Add(this.appointmentTab);
            this.panel1.Controls.Add(this.eventTabButton);
            this.panel1.Controls.Add(this.contactTabButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 803);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.surnameLabel);
            this.panel2.Controls.Add(this.lastLoginDateAndTime);
            this.panel2.Controls.Add(this.lastLoginResultLabel);
            this.panel2.Controls.Add(this.firstNameLabel);
            this.panel2.Controls.Add(this.welcomeHeadingLabel);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 132);
            this.panel2.TabIndex = 3;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.BackColor = System.Drawing.Color.PaleGreen;
            this.surnameLabel.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameLabel.Location = new System.Drawing.Point(113, 54);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(49, 24);
            this.surnameLabel.TabIndex = 10;
            this.surnameLabel.Text = "label3";
            // 
            // lastLoginDateAndTime
            // 
            this.lastLoginDateAndTime.AutoSize = true;
            this.lastLoginDateAndTime.BackColor = System.Drawing.Color.PaleGreen;
            this.lastLoginDateAndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastLoginDateAndTime.Location = new System.Drawing.Point(3, 78);
            this.lastLoginDateAndTime.Name = "lastLoginDateAndTime";
            this.lastLoginDateAndTime.Size = new System.Drawing.Size(221, 18);
            this.lastLoginDateAndTime.TabIndex = 11;
            this.lastLoginDateAndTime.Text = "Your last Login Date and Time is";
            // 
            // lastLoginResultLabel
            // 
            this.lastLoginResultLabel.AutoSize = true;
            this.lastLoginResultLabel.BackColor = System.Drawing.Color.PaleGreen;
            this.lastLoginResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastLoginResultLabel.Location = new System.Drawing.Point(3, 110);
            this.lastLoginResultLabel.Name = "lastLoginResultLabel";
            this.lastLoginResultLabel.Size = new System.Drawing.Size(46, 18);
            this.lastLoginResultLabel.TabIndex = 12;
            this.lastLoginResultLabel.Text = "label5";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.BackColor = System.Drawing.Color.PaleGreen;
            this.firstNameLabel.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(58, 37);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(49, 24);
            this.firstNameLabel.TabIndex = 9;
            this.firstNameLabel.Text = "label2";
            // 
            // welcomeHeadingLabel
            // 
            this.welcomeHeadingLabel.AutoSize = true;
            this.welcomeHeadingLabel.BackColor = System.Drawing.Color.PaleGreen;
            this.welcomeHeadingLabel.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeHeadingLabel.Location = new System.Drawing.Point(19, 6);
            this.welcomeHeadingLabel.Name = "welcomeHeadingLabel";
            this.welcomeHeadingLabel.Size = new System.Drawing.Size(190, 31);
            this.welcomeHeadingLabel.TabIndex = 8;
            this.welcomeHeadingLabel.Text = "...WELCOME...";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 624);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(254, 74);
            this.button3.TabIndex = 7;
            this.button3.Text = "Audit Trace";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 74);
            this.button1.TabIndex = 6;
            this.button1.Text = "Prediction";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 544);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 74);
            this.button2.TabIndex = 6;
            this.button2.Text = "Reports";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // taskButton
            // 
            this.taskButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.taskButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.taskButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.taskButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.taskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskButton.Location = new System.Drawing.Point(0, 384);
            this.taskButton.Name = "taskButton";
            this.taskButton.Size = new System.Drawing.Size(254, 74);
            this.taskButton.TabIndex = 6;
            this.taskButton.Text = "Task";
            this.taskButton.UseVisualStyleBackColor = false;
            this.taskButton.Click += new System.EventHandler(this.taskButton_Click);
            // 
            // appointmentTab
            // 
            this.appointmentTab.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.appointmentTab.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.appointmentTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.appointmentTab.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.appointmentTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentTab.Location = new System.Drawing.Point(0, 304);
            this.appointmentTab.Name = "appointmentTab";
            this.appointmentTab.Size = new System.Drawing.Size(254, 74);
            this.appointmentTab.TabIndex = 3;
            this.appointmentTab.Text = "Appointment";
            this.appointmentTab.UseVisualStyleBackColor = false;
            this.appointmentTab.Click += new System.EventHandler(this.appointmentTab_Click);
            // 
            // eventTabButton
            // 
            this.eventTabButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.eventTabButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.eventTabButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.eventTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eventTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventTabButton.Location = new System.Drawing.Point(0, 221);
            this.eventTabButton.Name = "eventTabButton";
            this.eventTabButton.Size = new System.Drawing.Size(254, 77);
            this.eventTabButton.TabIndex = 3;
            this.eventTabButton.Text = "Event";
            this.eventTabButton.UseVisualStyleBackColor = false;
            this.eventTabButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // contactForm
            // 
            this.contactForm.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.contactForm.Location = new System.Drawing.Point(257, 0);
            this.contactForm.Name = "contactForm";
            this.contactForm.Size = new System.Drawing.Size(730, 808);
            this.contactForm.TabIndex = 3;
            // 
            // eventForm
            // 
            this.eventForm.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.eventForm.Location = new System.Drawing.Point(257, 0);
            this.eventForm.Name = "eventForm";
            this.eventForm.Size = new System.Drawing.Size(730, 808);
            this.eventForm.TabIndex = 4;
            // 
            // appointmentForm
            // 
            this.appointmentForm.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.appointmentForm.Location = new System.Drawing.Point(257, 0);
            this.appointmentForm.Name = "appointmentForm";
            this.appointmentForm.Size = new System.Drawing.Size(730, 808);
            this.appointmentForm.TabIndex = 5;
            // 
            // auditTraceForm
            // 
            this.auditTraceForm.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.auditTraceForm.Location = new System.Drawing.Point(257, 0);
            this.auditTraceForm.Name = "auditTraceForm";
            this.auditTraceForm.Size = new System.Drawing.Size(730, 808);
            this.auditTraceForm.TabIndex = 6;
            // 
            // predictionForm
            // 
            this.predictionForm.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.predictionForm.Location = new System.Drawing.Point(257, 0);
            this.predictionForm.Name = "predictionForm";
            this.predictionForm.Size = new System.Drawing.Size(730, 808);
            this.predictionForm.TabIndex = 7;
            // 
            // reportForm
            // 
            this.reportForm.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.reportForm.Location = new System.Drawing.Point(257, 0);
            this.reportForm.Name = "reportForm";
            this.reportForm.Size = new System.Drawing.Size(730, 808);
            this.reportForm.TabIndex = 8;
            // 
            // taskForm
            // 
            this.taskForm.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.taskForm.Location = new System.Drawing.Point(257, 0);
            this.taskForm.Name = "taskForm";
            this.taskForm.Size = new System.Drawing.Size(730, 808);
            this.taskForm.TabIndex = 9;
            // 
            // CentralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 803);
            this.Controls.Add(this.taskForm);
            this.Controls.Add(this.reportForm);
            this.Controls.Add(this.predictionForm);
            this.Controls.Add(this.auditTraceForm);
            this.Controls.Add(this.appointmentForm);
            this.Controls.Add(this.eventForm);
            this.Controls.Add(this.contactForm);
            this.Controls.Add(this.panel1);
            this.Name = "CentralForm";
            this.Text = " Time Management Tool";
            this.Load += new System.EventHandler(this.ContactView_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button signoutButton;
        private System.Windows.Forms.Button contactTabButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button eventTabButton;
        private System.Windows.Forms.Button appointmentTab;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button taskButton;
        private System.Windows.Forms.Label lastLoginResultLabel;
        private System.Windows.Forms.Label lastLoginDateAndTime;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label welcomeHeadingLabel;
        private System.Windows.Forms.Panel panel2;
        private ContactForm contactForm;
        private EventForm eventForm;
        private Forms.AppointmentForm appointmentForm;
        private Forms.AuditTraceForm auditTraceForm;
        private Forms.PredictionForm predictionForm;
        private Forms.ReportForm reportForm;
        private Forms.TaskForm taskForm;
    }
}