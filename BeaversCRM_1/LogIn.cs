using MySql.Data.MySqlClient;
using Mysqlx.Expr;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BeaversCRM_1
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            
            // Implemented by Viktor
            // Multiple error messages will be shown if not connected to database
            // Create an instance of a worker to execute heavier tasks in different thread
            initialiseBackgroundWorker();
        }
        
        private BackgroundWorker worker;

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            // Show password
            tbPassword.UseSystemPasswordChar = !tbPassword.UseSystemPasswordChar;
        }

        private void btSignUp_Click(object sender, EventArgs e)
        {
            // Move to create account page
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }

        private void lbForgotPass_Click(object sender, EventArgs e)
        {
            // Send reset password to the email
            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("Please enter your email address to reset " +
                    "your password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Reset password email sent to \"" + tbEmail.Text.Trim() + "\"", 
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Event handler for when newsletter sign up button is clicked
        private void btNewsSignUp_Click(object sender, EventArgs e)
        {
            string newsFName = tbNewsFName.Text.Trim();
            string newsLName = tbNewsLName.Text.Trim();
            string newsEmail = tbNewsEmail.Text.Trim();

            if (string.IsNullOrEmpty(newsFName) || string.IsNullOrEmpty(newsLName) || string.IsNullOrEmpty(newsEmail))
            {
                MessageBox.Show("Please ensure all newsletter fields are completed", "Empty Field",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (newsFName.Length >= 50 || newsLName.Length >= 50 || newsEmail.Length >= 50)
            {
                MessageBox.Show("Please ensure characters in newsletter field are 50 or below", "Length Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create an instance of the DbValidation class to handle back end db operations
            var dbValidation = new DbValidation();
            bool isSuccess = dbValidation.NewsletterSignUp(newsFName, newsLName, newsEmail);
            // Check if registration was successful
            if (isSuccess)
            {
                MessageBox.Show("You have successfully signed up for our newsletter.", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("An error occurred while signing up for the newsletter. Please contact an administrator.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Event handler for when the login button is clicked
        private void btLogIn_Click(object sender, EventArgs e)
        {
            // Get the email and password from the text box input without spaces
            string email = tbEmail.Text.Trim();
            string password = tbPassword.Text.Trim();

            // Check if imput is empty
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter an email or password", 
                    "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {



                // Create an instance of the DbValidation class to check credentials
                DbValidation dbValidation = new DbValidation();

                // Get the database connection from MySQLdb
                var dbConn = MySQLDB.Instance();
                // Check connection
                if (!dbConn.IsConnect())
                {
                    MessageBox.Show("Could not connect to the database.", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // If the user's credentials return true
                if (dbValidation.ValidateUserCredentials(email, password))
                {
                    // Fetch the user's data using the email
                    User currentUser = dbValidation.GetUserDataByEmail(email);

                    // Store the current logged-in user in the session
                    Session.CurrentUser = currentUser;
                    
                    // Show the status of the user to the application forms
                    Session.isLoggedIn = true;

                    // Check that data is found
                    if (currentUser != null)
                    {
                        // If the user is an admin, take them to admin dashboard
                        if (currentUser.IsAdmin)
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);
                            AdminDashboard adminDashboard = new AdminDashboard();
                            adminDashboard.Show();
                            this.Hide();
                        }
                        // If the user is yet to be verified, notify them
                        else if (!currentUser.IsVerified)
                        {
                            MessageBox.Show("Please allow time for the admin to approve your membership.", 
                                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        // If the user is not an admin but is verified, go to member dashboard
                        else
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            UserDashboard userdashboard = new UserDashboard();
                            userdashboard.Show();
                            this.Hide();
                        }
                    }                  
                }
                else
                {
                    // Show error if password or email didn't match
                    MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Method to initialise worker with dowork handler
        private void initialiseBackgroundWorker()
        {
            worker = new BackgroundWorker
            {
                WorkerSupportsCancellation = true
            };
            worker.DoWork += workerUpdateEvents;
        }
        // Handler method for worker to update events in database
        private void workerUpdateEvents(object sender, DoWorkEventArgs e)
        {
            try {
                Event.updateDbEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while executing worker method: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Run worker with task to update events when login form is shown
        private void LogIn_Shown(object sender, EventArgs e)
        {
            worker.RunWorkerAsync();
        }


    }
}

