using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeaversCRM_1
{
    public partial class EventDetails : Form
    {
        private int eventId; // Store EventID
        int userID = Session.CurrentUser.UserId;

        public EventDetails(int eventId, string eventName, DateTime eventDateTime, string eventDetails)
        {
            InitializeComponent();

            this.eventId = eventId; // Store the passed EventID

            // Display the event information on the form
            lblEventName.Text = eventName;
            lblEventDateTime.Text = eventDateTime.ToString();
            txtEventDetails.Text = eventDetails;
        }

        //labels
        private void txtEventDetails_Click(object sender, EventArgs e)
        {

        }
        private void lblEventDateTime_Click(object sender, EventArgs e)
        {

        }
        private void lblEventName_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            BookEvent(); // Call the booking method
        }
        private void BookEvent()
        {
            MySqlConnection dbConnection = null;

            try
            {
                dbConnection = MySQLDB.Instance().Connection;
                if (dbConnection.State != System.Data.ConnectionState.Open)
                {
                    dbConnection.Open();
                }

                // Insert booking into EventAttendance
                string query = "INSERT INTO EventAttendance (UserID, EventID) VALUES (@UserID, @EventID)";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                cmd.Parameters.AddWithValue("@UserID", userID); // Use hardcoded user ID for now
                cmd.Parameters.AddWithValue("@EventID", eventId); // Use the passed EventID

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Booking confirmed!");
                }
                else
                {
                    MessageBox.Show("Booking failed. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }


    }
}