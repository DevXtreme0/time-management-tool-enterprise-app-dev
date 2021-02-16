using CourseWorkTwo.Models;
using System;
using System.Windows.Forms;

namespace CourseWorkTwo
{
    public partial class Register : Form
    {
        RegisteredUser nn = new RegisteredUser();
        UserLoginView pp = new UserLoginView();
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nn.UserName = userNameText ;
            nn.FirstName = firstNameText;
            nn.Surname = surnameText;
            nn.Password = userPasswordText;
           

            nn.createUser();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close(); 
            
            
        }
    }
}
