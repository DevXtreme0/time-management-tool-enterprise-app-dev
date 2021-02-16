using CourseWorkTwo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkTwo
{
    public partial class UserLoginView : Form
    {
        RegisteredUser bb = new RegisteredUser();
        public UserLoginView()
        {
            InitializeComponent();

            bb.RegisterButton = registerButton;

            bb.validateRegistration();

        }

        private void UserLoginView_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void userNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userNameText.Text=="" || passwordText.Text == "") 
            {
                MessageBox.Show(" Please enter credentials to login. ", "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bb.UserName = userNameText;
                bb.Password = passwordText;
               

                bb.login();
                this.Close();
                
            }
            
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
           Register obj = new Register();
            obj.ShowDialog();
            this.Close();
        }

       
    }
}
