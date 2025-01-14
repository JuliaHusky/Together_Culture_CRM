using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BeaversCRM_1
{
    public partial class EditUserForm : Form
    {
        private MySQLDB mySqlDatabase;

        public EditUserForm(string userId, string firstName, string lastName, string phoneNumber, string email, string isAdmin, string membershipID, string isVerified, string membershipType)
        {
            InitializeComponent();
            mySqlDatabase = MySQLDB.Instance();

            // Check if the database connection is established
            if (!mySqlDatabase.IsConnect())
            {
                MessageBox.Show("Error connecting to the database. Please try again.");
                return;
            }

            // Populate form fields with trimmed user data
            userIdTextBox.Text = userId?.Trim() ?? string.Empty;
            nameTextBox.Text = firstName?.Trim() ?? string.Empty;
            lastNameTextBox.Text = lastName?.Trim() ?? string.Empty;
            phoneNumberTextBox.Text = phoneNumber?.Trim() ?? string.Empty;
            emailTextBox.Text = email?.Trim() ?? string.Empty;
            isAdminCheckBox.Checked = isAdmin?.Trim() == "1";
            membershipIDTextBox.Text = membershipID?.Trim() ?? string.Empty;
            isVerifiedCheckBox.Checked = isVerified?.Trim() == "1";
        }

        private async void saveButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields before saving
                if (string.IsNullOrWhiteSpace(nameTextBox.Text))
                {
                    MessageBox.Show("First name cannot be empty.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
                {
                    MessageBox.Show("Last name cannot be empty.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(phoneNumberTextBox.Text))
                {
                    MessageBox.Show("Phone number cannot be empty.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(emailTextBox.Text) || !IsValidEmail(emailTextBox.Text.Trim()))
                {
                    MessageBox.Show("Please enter a valid email address.");
                    return;
                }

                // Validate and parse User ID
                if (!int.TryParse(userIdTextBox.Text.Trim(), out int userId))
                {
                    MessageBox.Show("User ID must be a valid number.");
                    return;
                }

                // Validate and parse Membership ID if provided
                int? membershipId = null;
                if (!string.IsNullOrWhiteSpace(membershipIDTextBox.Text.Trim()))
                {
                    if (int.TryParse(membershipIDTextBox.Text.Trim(), out int tempMembershipId))
                    {
                        membershipId = tempMembershipId;
                    }
                    else
                    {
                        MessageBox.Show("Membership ID must be a valid number.");
                        return;
                    }
                }

                // Check if the database connection is still active
                if (!mySqlDatabase.IsConnect())
                {
                    MessageBox.Show("Database connection lost. Please try again.");
                    return;
                }

                // Use a new connection for the update operation
                using (var connection = new MySqlConnection(mySqlDatabase.Connection.ConnectionString))
                {
                    await connection.OpenAsync(); // Open the database connection asynchronously

                    // SQL query to update the user's information
                    string query = "UPDATE users SET FirstName = @firstName, LastName = @lastName, PhoneNumber = @phoneNumber, Email = @email, IsAdmin = @isAdmin, MembershipID = @membershipID, IsVerified = @isVerified, MembershipType = @membershipType WHERE UserId = @userId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters with specific types to the command
                        command.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = nameTextBox.Text.Trim();
                        command.Parameters.Add("@lastName", MySqlDbType.VarChar).Value = lastNameTextBox.Text.Trim();
                        command.Parameters.Add("@phoneNumber", MySqlDbType.VarChar).Value = phoneNumberTextBox.Text.Trim();
                        command.Parameters.Add("@email", MySqlDbType.VarChar).Value = emailTextBox.Text.Trim();
                        command.Parameters.Add("@isAdmin", MySqlDbType.Bit).Value = isAdminCheckBox.Checked ? 1 : 0;
                        command.Parameters.Add("@membershipID", MySqlDbType.Int32).Value = membershipId.HasValue ? (object)membershipId.Value : DBNull.Value;
                        command.Parameters.Add("@isVerified", MySqlDbType.Bit).Value = isVerifiedCheckBox.Checked ? 1 : 0;
                        command.Parameters.Add("@userId", MySqlDbType.Int32).Value = userId;

                        // Execute the command asynchronously and get the number of affected rows
                        int rowsAffected = await command.ExecuteNonQueryAsync();

                        // Check if the update was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No user record was updated. Please check the data.");
                        }

                        this.Close(); // Close the form after saving
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle MySQL-specific errors
                MessageBox.Show("MySQL Error: " + ex.Message);
                // TODO: Implement logging here if needed
            }
            catch (Exception ex)
            {
                // Handle general errors
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
                // TODO: Implement logging here if needed
            }
        }

        // Helper method to validate email format
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        // Remove empty event handlers if not used
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
