using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkTwo.Models
{
    class Central
    {
        private Label firstNameLabel;

        private Label surnameLabel;

        private Label lastLoginResultLabel;
        public Label FirstNameLabel { get; set; }
        public Label SurnameLabel { get; set; }

        public Label LastLoginResultLabel { get; set; }
        public void viewNotificationPanel()
        {
            firstNameLabel = FirstNameLabel;
            surnameLabel = SurnameLabel;
            lastLoginResultLabel = LastLoginResultLabel;

            try
            {
                SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;database=master");
                databaseConnection.Open();

                //add first name to the notification panel
                string firstNameQuery = "SELECT first_name FROM registered_user ";

                SqlCommand firstNameCommand = new SqlCommand(firstNameQuery, databaseConnection);
                SqlDataReader firstNameReader = null;

                firstNameReader = firstNameCommand.ExecuteReader();

                while (firstNameReader.Read())
                {
                    string firstName = firstNameReader["first_name"].ToString();
                    firstNameLabel.Text = firstName;
                }
                firstNameReader.Close();

                //add surname to the notification panel
                string surnameQuery = "SELECT surname FROM registered_user ";

                SqlCommand surnameCommand = new SqlCommand(surnameQuery, databaseConnection);
                SqlDataReader surnameReader = null;

                surnameReader = surnameCommand.ExecuteReader();

                while (surnameReader.Read())
                {
                    string surname = surnameReader["surname"].ToString();
                    surnameLabel.Text = surname;
                }
                surnameReader.Close();

                //add last date and time to the notification panel
                string lastLoginQuery = "SELECT created_date_time,description,traced_page FROM audit_trace WHERE traced_page = 'Login Page' ORDER BY created_date_time DESC";

                SqlCommand lastLoginCommand = new SqlCommand(lastLoginQuery, databaseConnection);
                SqlDataReader lastLoginReader = null;

                lastLoginReader = lastLoginCommand.ExecuteReader();

                while (lastLoginReader.Read())
                {
                    string lastLoginDateTime = lastLoginReader["created_date_time"].ToString();
                    lastLoginResultLabel.Text = lastLoginDateTime;
                }
                lastLoginReader.Close();
            }
            catch(SqlException producedException)
            {
                MessageBox.Show("Failed function(s) detected." + Environment.NewLine + "Detailed Information: " + producedException.Message, "Notification Panel Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
