using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeaversCRM_1
{
    public partial class EventManagementAdmin : Form
    {
        public EventManagementAdmin()
        {
            InitializeComponent();

            // Gets the path for the image location as it differs on different computers
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
            // Calls method with the specified path
            setProfilePic(path);


            dgvEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Disable filters to prevent errors occurring
            cbMemberships.Enabled = false;
            tbAttendeeSearch.Enabled = false;
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;

            dgvEvents.ClearSelection();

            // Define the array of membership types to populate the membership comboBox
            string[] memberships =
            {
                "Community Member",
                "Key Access Member",
                "Workspace Member",
                "Business Member"
            };
            // Add the array into the comboBox
            cbMemberships.Items.AddRange(memberships);


            // Display the user's name in top left corner
            lbName.AutoSize = true;
            lbName.Text = Session.CurrentUser.FirstName + " " + Session.CurrentUser.LastName;
            // Clear the event list comboBox
            cbEvents.Items.Clear();
            // Make the table read only
            dgvEvents.ReadOnly = true;

            // Retrieve the list of events from the database
            List<string> eventLists = DbValidation.GetEventNames();

            // Add the event names to the ComboBox
            foreach (string eventList in eventLists)
            {
                cbEvents.Items.Add(eventList);
            }
        }

        // Search is used for showing data for specific events.
        private void btSearch_Click(object sender, EventArgs e)
        {
            /* Search is used to display information about specific
             * events, some filter selections are not available for 
             * specific events, and only for all events. Membership
             * filering and attendee search is allowed for specific
             * event search. */
            cbMemberships.Enabled = true;
            tbAttendeeSearch.Enabled = true;
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;

            // Membership filter comboBox default
            cbMemberships.SelectedIndex = -1;
            cbMemberships.Text = "Membership Type";

            // Auto size the columns to fill the data grid view
            dgvEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (cbEvents.SelectedItem == null)
            {
                return; // If no event is selected just exit
            }
            else
            {
                string search = cbEvents.SelectedItem.ToString(); // Get the user's input from search box
                string[] nameDate = search.Split('|'); // Split to retrieve the event name and date
                string eventName = nameDate[0].Trim();
                string eventStartTime = nameDate[1].Trim();

                DbValidation dbValidation = new DbValidation(); // Create an instance of dbValidation

                // Get the attendance data for that selected event from database
                DataTable eventData = dbValidation.GetEventAttendance(eventName, eventStartTime);

                // Display the data into the data grid view
                dgvEvents.DataSource = eventData;

                // Get the event tag to display in the label
                string eventType = dbValidation.GetEventType(eventName);
                lbEventTag.Text = $"{eventType}";

                // Calculate the number of attendees and display in the label
                int numOfAttendees = dbValidation.GetNumberOfAttendees(eventName, eventStartTime);
                lbNumberOfAttendees.Text = $"{numOfAttendees}";
            }
            dgvEvents.ClearSelection(); // Clear the selection on the dgv
        }

        // Handles display of information about all events
        private void btAllEvents_Click(object sender, EventArgs e)
        {
            // Reset the filters and searches to null as not required 
            cbEvents.SelectedItem = null;
            lbEventTag.Text = null;
            lbNumberOfAttendees.Text = null;

            /* Disable filters for membership search and attendee search 
             * as it is not applicable for all events*/
            cbMemberships.Enabled = false;
            tbAttendeeSearch.Enabled = false;

            // Enable date pickers for filtering by date
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;


            DbValidation dbValidation = new DbValidation(); // Create an instance of dbValidation
            DataTable eventData = dbValidation.GetAllEvents(); // Get the event data from database

            // Display the data into the data grid view
            dgvEvents.DataSource = eventData;
            dgvEvents.ClearSelection();
        }

        // Methods and action handlers to manage the attendee search
        private void tbAttendeeSearch_Click(object sender, EventArgs e)
        {
            // Clear the search box
            tbAttendeeSearch.Clear();
            /* Reset the membership filter as it does not apply 
             * when you are searching for an attendee */
            cbMemberships.SelectedIndex = -1;
            cbMemberships.Text = "Membership Type";
        }

        private void tbAttendeeSearch_TextChanged(object sender, EventArgs e)
        {
            /* Triggered whenever the text is being altered in the attendee
             * search box. It dynamically filters the results in real time
             * based on the user input */
            string attendeeSearch = tbAttendeeSearch.Text.Trim();
            // Call the filter method to apply the search criteria
            FilterData(attendeeSearch);
        }

        private void tbAttendeeSearch_Leave(object sender, EventArgs e)
        {
            // Once the user leaves attendee search, set back to default
            tbAttendeeSearch.Text = " Attendee Search";
        }

        // Filters the data in the data grid view based on the attendee's name
        private void FilterData(string attendeeSearch)
        {
            // This holds the data to be filtered
            DataTable dataTable = (DataTable)dgvEvents.DataSource;

            /* Apply a filter to the first name column to match rows
             * similar to the attendee search */
            dataTable.DefaultView.RowFilter = $"FirstName LIKE '%{attendeeSearch}%'";
            dgvEvents.ClearSelection();
        }

        // Checks to see if the user has changed the membership type in the comboBox
        private void cbMemberships_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if a valid selection has been made
            if (cbMemberships.SelectedIndex != -1)
            {
                // Get the selected membership type from the comboBox
                string membershipSelected = cbMemberships.SelectedItem.ToString();

                // This holds the data to be filtered
                DataTable dataTable = (DataTable)dgvEvents.DataSource;

                // Apply a filter to the membershipType row depending on the selected membership type
                dataTable.DefaultView.RowFilter = $"MembershipType LIKE '%{membershipSelected}%'";
                dgvEvents.ClearSelection();
            }
        }
        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            ApplyDateFilter();
        }
        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            ApplyDateFilter();
        }

        // Method to filter events based on dates selected
        private void ApplyDateFilter()
        {
            // Check if the date time pickers have been set to a valid format
            if (dtpStartDate.CustomFormat != " " && dtpEndDate.CustomFormat != " ")
            {
                DateTime startDate = dtpStartDate.Value;
                DateTime endDate = dtpEndDate.Value;

                // Create an instance of DbValidation and fetch the filtered events
                DbValidation dbValidation = new DbValidation();
                DataTable filteredEvents = dbValidation.EventsFilteredByDate(startDate, endDate);
                dgvEvents.DataSource = filteredEvents;
                dgvEvents.ClearSelection();
            }
        }

        private void btCreateEvent_Click(object sender, EventArgs e)
        {
            CreateEvent createEvent = new CreateEvent();
            createEvent.Show();
        }

        // Handles navigating to new pages from side menu
        private void menuAdminDashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void menuManageAccounts_Click(object sender, EventArgs e)
        {
            AdminMembershipManagement adminMembershipManagement = new AdminMembershipManagement();
            adminMembershipManagement.Show();
            this.Hide();
        }

        private void menuMemRequests_Click(object sender, EventArgs e)
        {
            MembershipRequests adminMembershipRequests = new MembershipRequests();
            adminMembershipRequests.Show();
            this.Hide();
        }

        private void menuTagManager_Click(object sender, EventArgs e)
        {
            AdminSearch adminSearch = new AdminSearch();
            adminSearch.Show();
            this.Hide();
        }

        private void menuLogOut_Click(object sender, EventArgs e)
        {
            // Delete instance of admin and go back to log in page
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