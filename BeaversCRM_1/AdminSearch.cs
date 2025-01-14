using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Use MySQL library for XAMPP MySQL connection

// Things to add to the form:
// 1. Add an Event list control to the EditUserForm
// 2. Add better error handling to the EditUserForm
// 3. Add better error handling to the AdminSearch form

namespace BeaversCRM_1
{
    public partial class AdminSearch : Form
    {
        private MySQLDB mySqlDatabase; // Declare MySQLDB instance

        // Create a list of valid filter options
        private readonly List<string> validFilters = new List<string>
        {
            "FirstName",
            "LastName",
            "Email",
            "PhoneNumber",
            "userID",
            "Gender",
            "Intention",
            "MembershipID",
            "IsVerified",
            "IsAdmin"
        };

        public AdminSearch()
        {
            InitializeComponent();
            mySqlDatabase = MySQLDB.Instance(); // Initialize the singleton instance of MySQLDB

            // Check if the database connection is successful
            if (!mySqlDatabase.IsConnect())
            {
                MessageBox.Show("Error connecting to the database. Please try again.");
                return;
            }

            LoadFilterOptions(); // Load filter options into the combo box

            // Set the DataGridView to read-only and full-row select mode
            usersDataGridView.ReadOnly = true;
            usersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadFilterOptions()
        {
            // Bind the filterComboBox to the list of valid filters
            filterComboBox.DataSource = validFilters;
        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            string filter = filterComboBox.SelectedItem?.ToString(); // Get selected filter
            string searchText = searchTextBox.Text; // Get search text
            SearchUsers(filter, searchText); // Call the search function
        }

        private async void SearchUsers(string filter, string searchText)
        {
            try
            {
                // Check if the database is still connected
                if (!mySqlDatabase.IsConnect())
                {
                    MessageBox.Show("Database connection lost. Please try again.");
                    return;
                }

                // Use a separate connection for data retrieval
                using (var connection = new MySqlConnection(mySqlDatabase.Connection.ConnectionString))
                {
                    await connection.OpenAsync(); // Open the connection asynchronously

                    // Base query to select user data
                    string query = "SELECT UserID, FirstName, LastName, PhoneNumber, Email, IsAdmin, MembershipID, IsVerified, MembershipType FROM users";

                    // Check if filter and search text are provided
                    bool hasFilter = !string.IsNullOrEmpty(filter) && !string.IsNullOrEmpty(searchText);

                    if (hasFilter)
                    {
                        // Validate the filter to prevent SQL injection
                        if (validFilters.Contains(filter))
                        {
                            query += $" WHERE {filter} LIKE @searchText";
                        }
                        else
                        {
                            MessageBox.Show("Invalid filter selected.");
                            return;
                        }
                    }

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameter to prevent SQL injection
                        if (hasFilter)
                        {
                            command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                        }

                        // Execute the query and fill the DataTable asynchronously
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        await Task.Run(() => adapter.Fill(dataTable)); // Run in a separate task

                        // Update the DataGridView on the UI thread
                        usersDataGridView.Invoke(new Action(() =>
                        {
                            usersDataGridView.DataSource = dataTable;
                        }));
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle database-specific exceptions
                MessageBox.Show("Database error: " + ex.Message);
                // TODO: Implement logging here if needed
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
                // TODO: Implement logging here if needed
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (usersDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = usersDataGridView.SelectedRows[0]; // Get the selected row

                // Convert IsVerified to a string value ("1" or "0")
                bool isVerifiedValue = (row.Cells["IsVerified"].Value as bool?) == true;
                string isVerified = isVerifiedValue ? "1" : "0";

                // Convert IsAdmin to a string value ("1" or "0")
                bool isAdminValue = (row.Cells["IsAdmin"].Value as bool?) == true;
                string isAdmin = isAdminValue ? "1" : "0";

                // Create the EditUserForm with the user's details
                EditUserForm editForm = new EditUserForm(
                    row.Cells["UserID"].Value?.ToString() ?? string.Empty,
                    row.Cells["FirstName"].Value?.ToString() ?? string.Empty,
                    row.Cells["LastName"].Value?.ToString() ?? string.Empty,
                    row.Cells["PhoneNumber"].Value?.ToString() ?? string.Empty,
                    row.Cells["Email"].Value?.ToString() ?? string.Empty,
                    isAdmin, // Pass the IsAdmin value
                    row.Cells["MembershipID"].Value?.ToString() ?? string.Empty,
                    isVerified, // Pass the IsVerified value
                    row.Cells["MembershipType"].Value?.ToString() ?? string.Empty
                );

                editForm.ShowDialog(); // Show the EditUserForm

                // Refresh the data grid view after editing
                searchButton_Click_1(null, null);
            }
            else
            {
                // Prompt the user to select a row
                MessageBox.Show("Please select a row to edit.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
