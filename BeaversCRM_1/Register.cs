using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BeaversCRM_1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            // Create an instance of a worker to execute havier tasks in different thread
            initialiseBackgroundWorker();
            // Populate the drop down selection with the 5 TC interests
            string[] intentions = new string[]
            {
                "Caring",
                "Sharing",
                "Learning",
                "Happening",
                "Working"
            };
            cbIntentionReg.Items.AddRange(intentions);
            cbIntentionReg.SelectedIndex = -1; // Start of with no selection

            // Populate the drop down selection with genders
            string[] gender = new string[]
                {
                "Female",
                "Male"
                };
            cbGender.Items.AddRange(gender);
            cbGender.SelectedIndex = -1; // Start of with no selection
        }
        
        private BackgroundWorker worker;

        // Check if the first name contains only letters
        private void tbFirstNameReg_TextChanged(object sender, EventArgs e)
        {
            string firstName = tbFirstNameReg.Text.Trim();

            if (!Regex.IsMatch(firstName, @"^[a-zA-Z]+$")) // Check if non letters detected
            {
                lbFNameWarning.ForeColor = Color.Red;
                lbFNameWarning.Text = "Name can only contain letters";
                lbFNameWarning.Visible = true; // Display warning label
            }
            else
            {
                lbFNameWarning.Visible = false; // Hide warning label
            }
        }

        // Check if the last name contains only letters
        private void tbLastNameReg_TextChanged(object sender, EventArgs e)
        {
            string lastName = tbLastNameReg.Text.Trim();

            if (!Regex.IsMatch(lastName, @"^[a-zA-Z]+$")) // Check if non letters detected
            {
                lbLNameWarning.ForeColor = Color.Red;
                lbLNameWarning.Text = "Name can only contain letters";
                lbLNameWarning.Visible = true; // Display warning label
            }
            else
            {
                lbLNameWarning.Visible = false; // Hide warning label
            }
        }

        // Check if the email contains '@'
        private void tbEmailReg_TextChanged(object sender, EventArgs e)
        {
            string email = tbEmailReg.Text.Trim();

            if (!email.Contains("@")) // Check if email contains '@'
            {
                lbEmailWarning.ForeColor = Color.Red;
                lbEmailWarning.Text = "Invalid email address (missing @)";
                lbEmailWarning.Visible = true; // Display warning label
            }
            else
            {
                lbEmailWarning.Visible = false; // Hide warning label
            }
        }

        private void cbShowPassReg_CheckedChanged(object sender, EventArgs e)
        {
            tbPasswordReg.UseSystemPasswordChar = !tbPasswordReg.UseSystemPasswordChar; // Show password
        }
        private void cbConfirmPass_CheckedChanged(object sender, EventArgs e)
        {
            tbRegConfirmPass.UseSystemPasswordChar = !tbRegConfirmPass.UseSystemPasswordChar; // Show password
        }
        // This checks if the user meets the password criteria
        private void tbPasswordReg_TextChanged(object sender, EventArgs e)
        {
            string password = tbPasswordReg.Text.Trim();
            // Check for each requirement and update labels
            lbPasswordLength.ForeColor = password.Length >= 6 ? Color.Green : Color.Red; // Check for at least 6 characters
            lbCapLetter.ForeColor = Regex.IsMatch(password, "[A-Z]") ? Color.Green : Color.Red; // Check for at least one capital letter
            lbNumber.ForeColor = Regex.IsMatch(password, @"\d") ? Color.Green : Color.Red; // Check for at least one number
            lbSpChara.ForeColor = Regex.IsMatch(password, @"[@$!%*?&]") ? Color.Green : Color.Red; // Check for at least one special character
        }
        // This checks if the passwords match
        private void tbRegConfirmPass_TextChanged(object sender, EventArgs e)
        {
            string password = tbPasswordReg.Text.Trim();
            string confirmPassword = tbRegConfirmPass.Text.Trim();
            if (password != confirmPassword)
            {
                lbPasswordMatch.ForeColor = Color.Red; // Change label to red if passwords don't match
                lbPasswordMatch.Text = "Passwords do not match"; //Update label text to show error
            }
            else
            {
                lbPasswordMatch.ForeColor = Color.Green; // Change label to green if passwords match
                lbPasswordMatch.Text = "Passwords match"; // Optional: Update label text to show success
            }
        }

        // Only allows numbers to be entered and max of 16
        private void tbCardNum_TextChanged(object sender, EventArgs e)
        {
            string cardNumber = tbCardNum.Text; // Get the string entered so far
            if (!Regex.IsMatch(cardNumber, @"^\d*$"))
            {
                // Remove any non-numeric characters
                tbCardNum.Text = new string(cardNumber.Where(char.IsDigit).ToArray()); 
            }

            if (cardNumber.Length > 16) // Limit the length to 16 numbers
            {
                tbCardNum.Text = cardNumber.Substring(0, 16); // Trim to 16 digits  
            }
            tbCardNum.SelectionStart = tbCardNum.Text.Length; // Move cursor to end
        }
        // Expiry date format
        private void tbExpiry_TextChanged(object sender, EventArgs e)
        {
            string expiry = tbExpiry.Text;

            // Remove all non-numeric characters 
            expiry = new string(expiry.Where(char.IsDigit).ToArray());

            // Automatically insert `/` after the first two digits
            if (expiry.Length > 2)
            {
                expiry = expiry.Insert(2, "/");
            }

            // Limit input to 5 characters (MM/YY)
            if (expiry.Length > 5)
            {
                expiry = expiry.Substring(0, 5);
            }

            // Update the text box and maintain cursor position
            tbExpiry.Text = expiry;
            tbExpiry.SelectionStart = expiry.Length;
        }

        // Only allows 3 numbers for cvv
        private void tbCVV_TextChanged(object sender, EventArgs e)
        {
            string cvv = tbCVV.Text.Trim(); // Get the string entered so far
            if (!Regex.IsMatch(cvv, @"^\d*$"))
            {
                // Remove non-numeric characters
                tbCVV.Text = new string(cvv.Where(char.IsDigit).ToArray());  
            }

            if (cvv.Length > 3) // Allow only numbers and limit the length to 3 digits
            {
                tbCVV.Text = cvv.Substring(0, 3); // Trim to 3 digits
                tbCVV.SelectionStart = tbCVV.Text.Length; // Move cursor to the end
            }
        }
        // Go to the login page
        private void lbLogIn_Click(object sender, EventArgs e)
        {
            LogIn logInForm = new LogIn();
            logInForm.Show();
            this.Hide();

        }
        private void btCreateAccount_Click(object sender, EventArgs e)
        {
            // Get the user input from the form
            string firstName = tbFirstNameReg.Text.Trim();
            string lastName = tbLastNameReg.Text.Trim();
            string gender = cbGender.SelectedItem != null ? cbGender.SelectedItem.ToString() : string.Empty;
            string intention = cbIntentionReg.SelectedItem != null ? cbIntentionReg.SelectedItem.ToString() : string.Empty;
            string email = tbEmailReg.Text.Trim();
            string password = tbPasswordReg.Text.Trim();
            string confirmPassword = tbRegConfirmPass.Text.Trim();
            string cardNumber = tbCardNum.Text.Trim();
            string expiry = tbExpiry.Text.Trim();
            string cvv = tbCVV.Text.Trim();
            bool marketingEmails = cbMarketingEmail.Checked;

            // Check for any empty fields
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(cardNumber) || string.IsNullOrEmpty(expiry) ||
                string.IsNullOrEmpty(cvv))
            {
                MessageBox.Show("Please ensure all fields are completed", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the first or last name matches a-z letters
            if (!Regex.IsMatch(firstName, @"^[a-zA-Z]+$") || !Regex.IsMatch(lastName, @"^[a-zA-Z]+$"))
            {
                // Error message to show the name does not contain letters.
                MessageBox.Show("The first name and last name must be letters only", "Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (firstName.Length >= 50 || lastName.Length >= 50) // Check if name length is valid
            {
                MessageBox.Show("The first name and last name must be 50 characters or less", "Name Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Capitalise the first letter for first and last name.
            string Capitalize(string input)
            {
                input = input.ToLower();  // Convert entire string to lowercase
                return char.ToUpper(input[0]) + input.Substring(1);  // Capitalise the first character
            }

            firstName = Capitalize(firstName);
            lastName = Capitalize(lastName);

            // Check is email is valid
            if (!email.Contains("@"))
            {
                MessageBox.Show("Email address is invalid (missing @)", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if password meets criteria
            if (password.Length < 6 || !Regex.IsMatch(password, "[A-Z]") || !Regex.IsMatch(password, @"\d") || !Regex.IsMatch(password, @"[@$!%*?&]"))
            {
                MessageBox.Show("Password must be at least 6 characters long, contain at least one capital letter, one number, and one special character",
                                "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if passwords match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create an instance of the DbValidation class to handle back end db operations
            var dbValidation = new DbValidation();
            // Call the register method, passing in the user details to register the user into the database
            // This will return true if registration was successful, otherwise false.
            bool isSuccess = dbValidation.RegisterUser(firstName, lastName, gender, email, password,
                                                       intention, marketingEmails, cardNumber, expiry, cvv);
            // Check if registration was successful
            if (isSuccess)
            {
                MessageBox.Show("Account created successfully! Please wait for admin authorisation to fully activate your account." +
                                   " You'll receive an email once approved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Setting up the request and passing it to worker to insert it
                MembershipRequest request = new MembershipRequest();
                request.user = new User();
                request.user.Tags = new List<string>();
                request.user.Tags.Add(intention);
                request.membership = new MembershipType();
                request.user.Email = email;
                request.membership.name = "Community Membership";
                request.approvalStatus = "Pending";
                request.paymentStatus = "Pending";
                worker.RunWorkerAsync(request);
            }
            else
            {
                MessageBox.Show("An error occurred while creating the account. Please try again or contact the " +
                          "admin team for further assistance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        // Method to initialise worker with dowork handler
        private void initialiseBackgroundWorker()
        {
            worker = new BackgroundWorker
            {
                WorkerSupportsCancellation = true
            };
            worker.DoWork += workerInsertMembershipRequest;
        }
        // Dowork handler method for worker to insert membership request and user's tag into database
        private void workerInsertMembershipRequest(object sender, DoWorkEventArgs e)
        {
            // Trying to put passed request and corresponding tag into database
            try {
                MembershipRequest request = e.Argument as MembershipRequest;
                request.user.insertTag();
                request.insertIntoDb();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while executing worker method: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
