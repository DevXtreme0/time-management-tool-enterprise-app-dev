using CourseWorkTwo.Models;
using System;
using System.Windows.Forms;

namespace CourseWorkTwo
{
    public partial class CentralForm : Form
    {
        Central alignTo = new Central();
        public CentralForm()
        {
            InitializeComponent();
            contactForm.BringToFront();

            alignTo.FirstNameLabel = firstNameLabel;
            alignTo.SurnameLabel = surnameLabel;
            alignTo.LastLoginResultLabel = lastLoginResultLabel;

            alignTo.viewNotificationPanel();            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            contactForm.Hide();
            reportForm.Hide();

            eventForm.Show();
            eventForm.BringToFront();
     }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void appointment1_Load(object sender, EventArgs e)
        {

        }

        private void contactTab_Click(object sender, EventArgs e)
        {
            eventForm.Hide();
            reportForm.Hide();

            contactForm.Show();
            contactForm.BringToFront();
        }

        private void ContactView_Load(object sender, EventArgs e)
        {

        }

        private void signoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contact1_Load(object sender, EventArgs e)
        {

        }

        private void eventForm1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            eventForm.Hide();
            contactForm.Hide();

            reportForm.Show();
            reportForm.BringToFront();

        }

        private void appointmentTab_Click(object sender, EventArgs e)
        {
            eventForm.Hide();
            contactForm.Hide();
            reportForm.Hide();

            appointmentForm.Show();
            appointmentForm.BringToFront();
        }

        private void taskButton_Click(object sender, EventArgs e)
        {
            eventForm.Hide();
            contactForm.Hide();
            reportForm.Hide();
            appointmentForm.Hide();

            taskForm.Show();
            taskForm.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eventForm.Hide();
            contactForm.Hide();
            reportForm.Hide();
            appointmentForm.Hide();
            taskForm.Hide();

            predictionForm.Show();
            predictionForm.BringToFront();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            eventForm.Hide();
            contactForm.Hide();
            reportForm.Hide();
            appointmentForm.Hide();
            taskForm.Hide();
            predictionForm.Hide();

            auditTraceForm.Show();
            auditTraceForm.BringToFront();
        }

        private void predictionForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
