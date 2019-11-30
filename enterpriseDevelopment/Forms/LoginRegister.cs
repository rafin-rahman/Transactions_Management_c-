using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bcrypt = BCrypt.Net.BCrypt;

namespace enterpriseDevelopment
{
    public partial class LoginRegister : Form
    {

        private string fullNameReg, usernameReg, pwdReg, pwd2Reg;
        private string userNameLog, pwdLog;
        UserRepository userRepositoryObj;
        public LoginRegister()
        {
            InitializeComponent();
            userRepositoryObj = new UserRepository();
            // When this form in opened, main form will be hidden
            Instance.MainForm.Hide();
        }


        // function for registration validations
        private bool RegistrationValidation()
        {

            if (String.IsNullOrEmpty(fullNameReg))
            {
                MessageBox.Show("Full name cannot be empty");
                return false;
            }


            if (fullNameReg.Length < 3)
            {
                MessageBox.Show("Name is too short, please use your full name");
                return false;
            }

            if (fullNameReg.Length > 30)
            {
                MessageBox.Show("Name is too long, please try again");
                return false;
            }

            if (String.IsNullOrWhiteSpace(usernameReg))
            {
                MessageBox.Show("Username cannot have empty spaces");
                return false;
            }
            else
            {
                if (usernameReg.Contains(" "))
                {
                    MessageBox.Show("Username cannot have empty spaces");
                    return false;
                }
            }

            if (usernameReg.Length < 6)
            {
                MessageBox.Show("Username is too short, please try again");
                return false;
            }

            if (usernameReg.Length > 45)
            {
                MessageBox.Show("Username is too long, please try again");
                return false;
            }



            if (String.IsNullOrWhiteSpace(pwdReg))
            {
                MessageBox.Show("Your pasword cannot be empty or contain spaces");
                return false;
            }

            if (pwdReg.Length < 8)
            {
                MessageBox.Show("Password is too short, insert minimum 8 characters");
                return false;
            }

            if (pwdReg.Length > 100)
            {
                MessageBox.Show("Password is too long, you can use up to 100 character");
                return false;
            }


            if (!pwdReg.Equals(pwd2Reg))
            {
                MessageBox.Show("Your paswords does not match");
                return false;
            }
            return true;
        }
        private bool LoginValidation()
        {
            if (String.IsNullOrWhiteSpace(userNameLog))
            {
                MessageBox.Show("Username cannot be empty");
                return false;
            }
            if (String.IsNullOrWhiteSpace(pwdLog))
            {
                MessageBox.Show("Password cannot be empty, please insert a password");
                return false;
            }
            return true;
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            userNameLog = usernameLogTxt.Text;
            pwdLog = passwordLogTxt.Text;

            if (!LoginValidation()) return;

            UserAccount userAccount = userRepositoryObj.GetUserByUsername(userNameLog);
            if (!CheckUserForLogin(userAccount)) return;

            if (!CheckPwdForLogin(userAccount)) return;
            // if login is successful, it will store login user data into the static class
            Instance.StaticUserAccount = userAccount;
            Close();
        }
        
        private bool CheckUserForLogin(UserAccount userAccount)
        {

            if (!(userAccount.UserId > 0))
            {
                MessageBox.Show("Username or Password is incorrect, please try again", "Alert");
                return false;
            }
            return true;
        }
        private bool CheckPwdForLogin(UserAccount userAccount)

        {

            bool isMatched = bcrypt.Verify("hEllo" + pwdLog + "woRld", userAccount.UserPwd);

            if (!isMatched)
            {
                MessageBox.Show("Error, invalid credentials");
                return false;


            }
            else {
                MessageBox.Show("Logged in successfully");
            }
            return true;
        }

        private void LoginRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            // If used is not logged in, 
            if (Instance.StaticUserAccount == null)
            {
                Instance.MainForm.Close();
            }
            else
            {
                Instance.MainForm.Activate();
                Instance.MainForm.Show();
            }
            // Close the application, removes all the unnecessary data
            Dispose();
        }

        private void EncryptPwd()
        {

            pwdReg = bcrypt.HashPassword("hEllo" + pwdReg + "woRld", bcrypt.GenerateSalt());
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            // There are private string already declared at the beginning of the page
            fullNameReg = fullNameRegTxt.Text;
            usernameReg = usernameRegTxt.Text;
            pwdReg = passwordRegTxt.Text;
            pwd2Reg = password2RegTxt.Text;

            // if the RegistrationValidation not true then - >return  
            if (!RegistrationValidation()) return;
            if (!CheckIfUserExists()) return;
            EncryptPwd();



            // using an anonymus object which is not saved anywhere, is passes the values straight to method AddUserAccount
            bool check = userRepositoryObj.AddUserAccount(new UserAccount { UserFName = fullNameReg, Username = usernameReg, UserPwd = pwdReg });
            // checks if there was any error during the insertion of the user data into the database, AddUserAccount method returns tre of false 
            if (check)
            {
                MessageBox.Show("Account successfully created");
            }
            else
            {
                MessageBox.Show("Error,acount not creted. Try again.");
            }




        }
        private bool CheckIfUserExists()
        {

            UserAccount userAccount = userRepositoryObj.GetUserByUsername(usernameReg);
            // if the usernameReg already exist, it will pop up the error message
            if (userAccount.UserId > 0)
            {
                MessageBox.Show("Username already in use, please try with different name", "Alert");
                return false;
            }
            return true;
        }

        private void loginRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
