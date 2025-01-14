using Mysqlx.Expr;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BeaversCRM_1
{
    public partial class CreateEvent : Form
    {
        public CreateEvent()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btCreateEvent_Click(object sender, EventArgs e)
        {
            string eventName = tbEventName.Text.Trim();
            string eventType = tbEventType.Text.Trim();
            string eventDetails = tbEventDetails.Text.Trim();
            string eventLocation = tbEventLocation.Text.Trim();
            DateTime startDateTime = dtpStart.Value;
            DateTime endDateTime = dtpEnd.Value;

            // Check if any of the text boxes have been left empty 
            if (string.IsNullOrEmpty(eventName) | string.IsNullOrEmpty(eventType) || string.IsNullOrEmpty(eventDetails) || string.IsNullOrEmpty(eventLocation))
            {
                MessageBox.Show("Please ensure all fields are complete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var dbValidation = new DbValidation();
            // Call the create event method, passing in the user details to add the event to the database
            // This will return true if event creation was successful, otherwise false.
            bool isSuccess = dbValidation.CreateEvent(eventName,eventType, eventDetails, eventLocation, startDateTime, endDateTime);
            // Check if event creation was successful
            if (isSuccess)
            {
                MessageBox.Show("Event created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("An error occurred while creating the event.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
