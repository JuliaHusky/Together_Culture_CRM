using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BeaversCRM_1
{
    public partial class AccountSetting : Form
    {
        public AccountSetting()
        {
            InitializeComponent();

            // Gets the path for the image location as it differs on different computers
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images\\");
            // Calls method with the specified path
            setProfilePic(path);

            lbName.AutoSize = true;
            lbName.Text = Session.CurrentUser.FirstName + " " + Session.CurrentUser.LastName;
        }

        // Private field for the new password text box used in changing the password
        private TextBox tbNewPassword;

        // Change personal details event handler
        private void btChangeDetails_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "Change details";
            FlowPanel.Controls.Clear(); // Clear any previous content from the panel
            lbTitle.Visible = true;
            FlowPanel.Visible = true;

            // Create a label to display user's email 
            Label userEmail = new Label
            {
                AutoSize = true,
                Text = $"Email: {Session.CurrentUser.Email}",
                Padding = new Padding(5)
            };

            // Create a label for the new password
            Label userPassword = new Label
            {
                Width = 300,
                Height = 30,
                Text = "Enter a new password:",
                Padding = new Padding(5)
            };

            // Create a textbox for the user to input a new password
            tbNewPassword = new TextBox
            {
                UseSystemPasswordChar = true,
                Width = 300,
                Padding = new Padding(5)
            };

            // Create a button for submitting the password change
            Button btChangePassword = new Button
            {
                Text = "Change Password",
                BackColor = Color.LightGray,
                Cursor = Cursors.Hand,
                Margin = new Padding(80, 10, 0, 0),
                Width = 150,
                Height = 30
            };

            // Attach the event handler for the password change button
            btChangePassword.Click += btChangePassword_Click; // Attach event handler

            // Add the created controls to the FlowPanel
            FlowPanel.Controls.Add(userEmail);
            FlowPanel.Controls.Add(userPassword);
            FlowPanel.Controls.Add(tbNewPassword);
            FlowPanel.Controls.Add(btChangePassword);
        }

        

        // Handles changing the user's password 
        private void btChangePassword_Click(object sender, EventArgs e)
        {
            string newPassword = tbNewPassword.Text.Trim();

            // Check if new password is empty
            if (string.IsNullOrEmpty(tbNewPassword.Text))
            {
                MessageBox.Show("Enter a new password.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        
            // Check if the new password is different from the current one *(DOES NOT WORK CURRENTLY DUE TO PASSWORD HASHING BUT STILL CHANGES PASSWORD IN DB)*
            if (Session.CurrentUser.Password != newPassword)
            {
                // Update the password
                Session.CurrentUser.Password = newPassword;

                // Create an instance of DbValidation to handle database operations
                var dbValidation = new DbValidation();
                bool isSuccess = dbValidation.ChangePassword(Session.CurrentUser.UserId, Session.CurrentUser.Password);

                // Display a success or failure message 
                if (isSuccess)
                {
                    MessageBox.Show("Password changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error changing password. Please contact administrators if error persists.", 
                        "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Notify the user if the new password matches the current password
                MessageBox.Show("Please ensure you enter a different password.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        // Event handler for viewing the user's documents and interests
        private void btDocuments_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "Documents";
            lbTitle.Visible = true;
            FlowPanel.Visible = true;
            FlowPanel.Controls.Clear();  // Clear any previous content from the panel

            // Get the user interest and userID
            string currentUserInterest = Session.CurrentUser.Intention;
            int currentUserId = Session.CurrentUser.UserId;

            try
            {
                DbValidation dbValidation = new DbValidation();  // Create an instance of DbValidation
                List<string> documents = dbValidation.GetUserDocuments(currentUserId);  // Fetch the documents

                // Display current interest label
                Label userInterest = new Label
                {
                    AutoSize = true,
                    Padding = new Padding(5),
                    Text = $"Your current interest is {currentUserInterest}!"
                };
                FlowPanel.Controls.Add(userInterest);

                // Add document labels to FlowPanel
                foreach (var document in documents)
                {
                    Label documentLabel = new Label
                    {
                        Text = document,
                        Padding = new Padding(5),
                        AutoSize = true
                    };
                    FlowPanel.Controls.Add(documentLabel);
                }
            }
            catch (Exception)
            {
                return;
            }
        }


        // Event handler for viewing the user's booked events
        private void btViewEvents_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "Events";
            FlowPanel.Controls.Clear(); // Clear any previous content from the panel
            lbTitle.Visible = true;
            FlowPanel.Visible = true;
            FlowPanel.Controls.Clear();

            // Get the userID
            int currentUserId = Session.CurrentUser.UserId;

            // Retrieve the list of events for the current user
            List<string> userEvents = DbValidation.GetUserEvents(currentUserId);

            if (userEvents != null)
            {
                // Add event labels to the FlowPanel
                foreach (var eventDetail in userEvents)
                {
                    Label eventLabel = new Label
                    {
                        Text = eventDetail,
                        AutoSize = true,
                        Margin = new Padding(5)
                    };
                    FlowPanel.Controls.Add(eventLabel);
                }
            }       
        }

        // Event handler for managing the user's membership
        private void btManageMem_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "Manage Membership";
            FlowPanel.Controls.Clear(); // Clear any previous content from the panel
            lbTitle.Visible = true;
            FlowPanel.Visible = true;

            // Create a label displaying the current membership type
            Label lbCurrentMembership = new Label()
            {
                Text = $"Current Membership Type: {Session.CurrentUser.MembershipType}",
                Padding = new Padding(5),
                Width = 300,
                Height = 40,
                Visible = true
            };


            // Create a button for upgrading the membership type
            Button btUpgradeAccount = new Button
            {
                Text = "Upgrade Membership",
                BackColor = Color.LightGray,
                Cursor = Cursors.Hand,
                Margin = new Padding(80, 20, 0, 0),
                Width = 150,
                Height = 30
            };

            // Attach the event handler for upgrading the membership
            btUpgradeAccount.Click += btUpgradeAccount_Click; // Attach event handler

            // Add the buttons to the flow panel
            FlowPanel.Controls.Add(lbCurrentMembership);
            FlowPanel.Controls.Add(btUpgradeAccount);

        }


        // Event handler for upgrading the user's membership
        private void btUpgradeAccount_Click(object sender, EventArgs e)
        {
            // Check if the current membership type can be upgraded
            if (Session.CurrentUser.MembershipType == "Community Membership")
            {
                // Update the membership type
                Session.CurrentUser.MembershipType = "Key Access Membership";

                // Create an instance of DbValidation 
                var dbValidation = new DbValidation();
                bool isSuccess = dbValidation.AccountUpgrade(Session.CurrentUser.UserId, Session.CurrentUser.MembershipType);

                // Display a success or failure message 
                if (isSuccess)
                {
                    MessageBox.Show("Membership upgraded to Key Access Membership!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error upgrading membership. Please contact administrators if error persists.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You already have the highest membership!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Handles moving between pages from side menu
        private void menuDashboard_Click(object sender, EventArgs e)
        {
            UserDashboard userdashboard = new UserDashboard();
            userdashboard.Show();
            this.Hide();
        }

        private void menuEvents_Click(object sender, EventArgs e)
        {
            CalendarOfEvents events = new CalendarOfEvents();
            events.Show();
            this.Hide();
        }

        private void menuBenefits_Click(object sender, EventArgs e)
        {
            BenefitsHub benefitsHub = new BenefitsHub();
            benefitsHub.Show();
            this.Hide();
        }

        private void menuOnlineCourse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently not coded", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void menuConnBoard_Click(object sender, EventArgs e)
        {
            DigitalConnections digitalConnection = new DigitalConnections();
            digitalConnection.Show();
            this.Hide();
        }

        private void menuChat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently not coded", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void menuAccSettings_Click(object sender, EventArgs e)
        {
            // This is actually unclickable as the user is already on this page. 
        }

        private void menuLogOut_Click(object sender, EventArgs e)
        {
            // Clear instance of the person and take back to log in page.
            Session.CurrentUser.Clear();
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        // Method to set the profile picture depending on gender
        private void setProfilePic(string path)
        {
            // Check if there is an error with the path name
            if (string.IsNullOrEmpty(path))
            {
                return;
            }

            // Checking what their gender is and combining the path name with the image name
            if (Session.CurrentUser.Gender == "Female")
            {
                profilePic.Image = Image.FromFile(Path.Combine(path, "female.png"));
            }
            else if (Session.CurrentUser.Gender == "Male")
            {
                profilePic.Image = Image.FromFile(Path.Combine(path, "male.png"));
            }
            else
            {
                profilePic.Image = Image.FromFile(Path.Combine(path, "user.png"));
            }
        }
    }
}
