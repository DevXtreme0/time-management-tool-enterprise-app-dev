namespace CourseWorkTwo
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.userNameText = new System.Windows.Forms.TextBox();
            this.userPasswordText = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.eventDescLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mandatoryDateLable = new System.Windows.Forms.Label();
            this.mandatoryStar = new System.Windows.Forms.Label();
            this.registerHeadingLabel = new System.Windows.Forms.Label();
            this.mandatoryLabel = new System.Windows.Forms.Label();
            this.surnameText = new System.Windows.Forms.TextBox();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNameText
            // 
            this.userNameText.Location = new System.Drawing.Point(176, 108);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(200, 22);
            this.userNameText.TabIndex = 0;
            // 
            // userPasswordText
            // 
            this.userPasswordText.Location = new System.Drawing.Point(176, 245);
            this.userPasswordText.Name = "userPasswordText";
            this.userPasswordText.Size = new System.Drawing.Size(200, 22);
            this.userPasswordText.TabIndex = 1;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(73, 108);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(83, 17);
            this.userNameLabel.TabIndex = 3;
            this.userNameLabel.Text = "User Name:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(83, 248);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(73, 17);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password:";
            // 
            // registerButton
            // 
            this.registerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.registerButton.FlatAppearance.BorderSize = 4;
            this.registerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerButton.Location = new System.Drawing.Point(596, 568);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(116, 65);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.eventDescLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mandatoryDateLable);
            this.panel1.Controls.Add(this.mandatoryStar);
            this.panel1.Controls.Add(this.registerHeadingLabel);
            this.panel1.Controls.Add(this.mandatoryLabel);
            this.panel1.Controls.Add(this.surnameText);
            this.panel1.Controls.Add(this.firstNameText);
            this.panel1.Controls.Add(this.surnameLabel);
            this.panel1.Controls.Add(this.firstNameLabel);
            this.panel1.Controls.Add(this.userPasswordText);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Controls.Add(this.userNameLabel);
            this.panel1.Controls.Add(this.userNameText);
            this.panel1.Location = new System.Drawing.Point(251, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 417);
            this.panel1.TabIndex = 7;
            // 
            // eventDescLabel
            // 
            this.eventDescLabel.AutoSize = true;
            this.eventDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDescLabel.Location = new System.Drawing.Point(69, 57);
            this.eventDescLabel.Name = "eventDescLabel";
            this.eventDescLabel.Size = new System.Drawing.Size(318, 20);
            this.eventDescLabel.TabIndex = 8;
            this.eventDescLabel.Text = "Enter your regisration information in here.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(74, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(63, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(70, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "*";
            // 
            // mandatoryDateLable
            // 
            this.mandatoryDateLable.AutoSize = true;
            this.mandatoryDateLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.mandatoryDateLable.ForeColor = System.Drawing.Color.Red;
            this.mandatoryDateLable.Location = new System.Drawing.Point(60, 106);
            this.mandatoryDateLable.Name = "mandatoryDateLable";
            this.mandatoryDateLable.Size = new System.Drawing.Size(14, 18);
            this.mandatoryDateLable.TabIndex = 39;
            this.mandatoryDateLable.Text = "*";
            // 
            // mandatoryStar
            // 
            this.mandatoryStar.AutoSize = true;
            this.mandatoryStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mandatoryStar.ForeColor = System.Drawing.Color.Red;
            this.mandatoryStar.Location = new System.Drawing.Point(12, 351);
            this.mandatoryStar.Name = "mandatoryStar";
            this.mandatoryStar.Size = new System.Drawing.Size(37, 20);
            this.mandatoryStar.TabIndex = 38;
            this.mandatoryStar.Text = "( * )";
            // 
            // registerHeadingLabel
            // 
            this.registerHeadingLabel.AutoSize = true;
            this.registerHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerHeadingLabel.Location = new System.Drawing.Point(49, 9);
            this.registerHeadingLabel.Name = "registerHeadingLabel";
            this.registerHeadingLabel.Size = new System.Drawing.Size(355, 36);
            this.registerHeadingLabel.TabIndex = 11;
            this.registerHeadingLabel.Text = "Registration Information";
            // 
            // mandatoryLabel
            // 
            this.mandatoryLabel.AutoSize = true;
            this.mandatoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mandatoryLabel.ForeColor = System.Drawing.Color.Red;
            this.mandatoryLabel.Location = new System.Drawing.Point(55, 356);
            this.mandatoryLabel.Name = "mandatoryLabel";
            this.mandatoryLabel.Size = new System.Drawing.Size(95, 15);
            this.mandatoryLabel.TabIndex = 37;
            this.mandatoryLabel.Text = "Mandatory Field";
            // 
            // surnameText
            // 
            this.surnameText.Location = new System.Drawing.Point(176, 201);
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(200, 22);
            this.surnameText.TabIndex = 9;
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(176, 155);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(200, 22);
            this.firstNameText.TabIndex = 8;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(87, 204);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(69, 17);
            this.surnameLabel.TabIndex = 6;
            this.surnameLabel.Text = "Surname:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(76, 158);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(80, 17);
            this.firstNameLabel.TabIndex = 5;
            this.firstNameLabel.Text = "First Name:";
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitButton.FlatAppearance.BorderSize = 4;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Location = new System.Drawing.Point(251, 568);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(116, 65);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CourseWorkTwo.Properties.Resources.registration_background;
            this.ClientSize = new System.Drawing.Size(982, 803);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.registerButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.TextBox userPasswordText;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox surnameText;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label registerHeadingLabel;
        private System.Windows.Forms.Label mandatoryStar;
        private System.Windows.Forms.Label mandatoryLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mandatoryDateLable;
        private System.Windows.Forms.Label eventDescLabel;
        private System.Windows.Forms.Button exitButton;
    }
}