using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkTwo.Models
{
    class RegisteredUser
    {
        
        private string userName;
        private string password;
        private string firstName;
        private string surname;
        private Label passwordHint;
        private Button registerButton;
       // private bool loginWindowClose;

        public TextBox UserName { get; set; }
        public TextBox FirstName { get; set; }

        public TextBox Surname { get; set; }

        public TextBox Password { get; set; }



        public Button RegisterButton { get; set; }
        public void createUser()
        {
            userName = UserName.Text;
            firstName =  FirstName.Text;
            surname = Surname.Text ;
            password = Password.Text;
     

            try
            {
                SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;database=master");
                databaseConnection.Open();

                var userCreatedDatetTime = DateTime.Now;

                string userRegisterQuery = "INSERT INTO registered_user(user_name,first_name,surname,password,password_hint,created_date_time) VALUES('" + userName + "','" + firstName +
                    "','" + surname + "','" + password + "','" + passwordHint + "','" + userCreatedDatetTime + "'); ";

                SqlCommand userAddCommand = new SqlCommand(userRegisterQuery, databaseConnection);
                userAddCommand.ExecuteNonQuery();

                string checkRegisteredRecordQuery = "SELECT user_id FROM registered_user WHERE user_name='" + userName + "' ;";

                SqlCommand checkRegisteredRecordCommand = new SqlCommand(checkRegisteredRecordQuery, databaseConnection);
                SqlDataReader checkRegisteredRecordReader = checkRegisteredRecordCommand.ExecuteReader();

                //message status show if success or failed
                string addStatus = "";
                switch (checkRegisteredRecordReader.HasRows)
                {
                    case true:
                        MessageBox.Show("User : " + userName + " registered successfully. ", "Registration Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        checkRegisteredRecordReader.Close();
                        addStatus = "created successfully.";
                        break;

                    case false:
                        MessageBox.Show("User : " + userName + " registeration failed. ", "Registration Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        checkRegisteredRecordReader.Close();
                        addStatus = "creation failed.";
                        break;
                }

                //add to the Audit trace 
                string auditTraceQuery = "INSERT INTO audit_trace(description,traced_page,traced_task,created_date_time)"
                   + "VALUES('User :" + userName + "" + addStatus + "','Registration Page','Register','" + userCreatedDatetTime + "');";

                SqlCommand auditTraceAddCommand = new SqlCommand(auditTraceQuery, databaseConnection);
                auditTraceAddCommand.ExecuteNonQuery();

                string checkAuditTraceQuery = "SELECT audit_id FROM audit_trace WHERE created_date_time='" + userCreatedDatetTime + "' ;";

                SqlCommand checkAuditTraceCommand = new SqlCommand(checkAuditTraceQuery, databaseConnection);
                SqlDataReader AuditTraceReader = checkAuditTraceCommand.ExecuteReader();

                switch (AuditTraceReader.HasRows)
                {
                    case true:
                        Console.WriteLine("Auidt trace for register task created successfully.");
                        AuditTraceReader.Close();
                        break;

                    case false:
                        Console.WriteLine("Audit trace for register task creation failed.");
                        AuditTraceReader.Close();
                        break;
                }

                databaseConnection.Close();
            }
            catch (SqlException producedException)
            {
                MessageBox.Show("Registration failed." + Environment.NewLine + "Detailed Information: " + producedException.Message, "Registration Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void login()
        {
            userName = UserName.Text;
            password = Password.Text;
   
            try
            {

                SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;database=master");
                databaseConnection.Open();

                string userLoginQuery = "SELECT user_id,password_hint FROM registered_user WHERE user_name = '" + userName + "' and password = '" + password + "'";

                SqlCommand userLoginCommand = new SqlCommand(userLoginQuery, databaseConnection);
                SqlDataReader userLoginReader;

                userLoginReader = userLoginCommand.ExecuteReader();

                if (userLoginReader.Read() == false)
                {
                   // string passwordHintFromDB = userLoginReader["password_hint"].ToString();
                    //string passworHint = passwordHintFromDB;
      
                    MessageBox.Show(" User name or Password invalid. Please try again.  ", "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    userLoginReader.Close();
                }
                else
                {
                    CentralForm obj2 = new CentralForm();
                    obj2.ShowDialog();
                    

                    userLoginReader.Close();
                    var userLoginDatetTime = DateTime.Now;
                    string auditTraceQuery = "INSERT INTO audit_trace(description,traced_page,traced_task,created_date_time)"
                       + "VALUES('User attempt login to the application.','Login Page','Login','" + userLoginDatetTime + "');";

                    SqlCommand auditTraceAddCommand = new SqlCommand(auditTraceQuery, databaseConnection);
                    auditTraceAddCommand.ExecuteNonQuery();

                    string checkAuditTraceQuery = "SELECT audit_id FROM audit_trace WHERE created_date_time='" + userLoginDatetTime + "' ;";

                    SqlCommand checkAuditTraceCommand = new SqlCommand(checkAuditTraceQuery, databaseConnection);
                    SqlDataReader AuditTraceReader = checkAuditTraceCommand.ExecuteReader();

                    switch (AuditTraceReader.HasRows)
                    {
                        case true:
                            Console.WriteLine("Auidt trace for login task created successfully.");
                            AuditTraceReader.Close();
                            break;

                        case false:
                            Console.WriteLine("Audit trace for login task creation failed.");
                            AuditTraceReader.Close();
                            break;
                    }


                    databaseConnection.Close();
                }
            }
            catch (SqlException producedException)
            {
                MessageBox.Show("Login initialization failed." + Environment.NewLine + "Detailed Information: " + producedException.Message, "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void logout()
        {

        }

        public void validateRegistration()
        {
            registerButton = RegisterButton;

            try
            {

                SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;database=master");
                databaseConnection.Open();

                string registrationVlidityQuery = "SELECT user_id FROM registered_user";

                SqlCommand registrationVlidityCommand = new SqlCommand(registrationVlidityQuery, databaseConnection);
                SqlDataReader registrationVlidityReader = registrationVlidityCommand.ExecuteReader();

                
                switch (registrationVlidityReader.HasRows)
                {
                    case true:
                        registerButton.Enabled = false;
                        registrationVlidityReader.Close();
                        
                        break;

                    case false:
                        registerButton.Enabled = true;
                        registrationVlidityReader.Close();
                        
                        break;
                }
                databaseConnection.Close();
            }
            catch (SqlException producedException)
            {
                MessageBox.Show("Register validation initialization failed." + Environment.NewLine + "Detailed Information: " + producedException.Message, "Register Validation Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
