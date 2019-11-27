using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enterpriseDevelopment
{
    public partial class LoginRegister : Form
    {
        // 
        private string fullName, username, pwd, pwd2;

        public LoginRegister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            // There are privat string already declared at the beginning of the page
            fullName = fullNameRegTxt.Text;
            username = usernameRegTxt.Text;
            pwd = passwordRegTxt.Text;
            pwd2 = password2RegTxt.Text;


            private bool registrationValidation()
            {

                if (String.IsNullOrEmpty(fullName))
                {
                    MessageBox.Show("Full name cannot be empty");
                    return false;
                }


                if (fullName.Length < 3)
                {
                    MessageBox.Show("Name is too short, please use your full name");
                    return false;
                }

                if (String.IsNullOrWhiteSpace(username))
                {
                    MessageBox.Show("Username cannot have empty spaces");
                    return false;
                }
                else
                {
                    if (username.Contains(" "))
                    {
                        MessageBox.Show("Username cannot have empty spaces");
                        return false;
                    }
                }

                if (username.Length < 6)
                {
                    MessageBox.Show("Username is too short, please try again");
                    return false;
                }

                if (String.IsNullOrWhiteSpace(pwd))
                {
                    MessageBox.Show("Your pasword cannot be empty or contain spaces");
                    return false;
                }

                if (pwd.Length < 8)
                {
                    MessageBox.Show("Password is too short, insert minimum 8 characters");
                    return false;
                }

                if (!pwd.Equals(pwd2))
                {
                    MessageBox.Show("Your paswords does not match");
                    return false;
                }
                return true;
            }
            


            UserAccount userObj = new UserAccount();
            userObj.UserFName = fullName;
            userObj.Username = username;
            userObj.UserPwd = pwd;

            // create instance of UserRepository [[user account]]
            UserRepository userRepositoryObj = new UserRepository();
            // checks if there was any error during the insertion of the user data into the database, AddUserAccount method returns tre of false values
            bool check = userRepositoryObj.AddUserAccount(userObj);
            if (check)
            {
                MessageBox.Show("Acount successfully created");

            }
            else
            {
                MessageBox.Show("Error, try again.");

            }




        }

        private void loginRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
