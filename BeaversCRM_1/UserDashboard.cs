using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BeaversCRM_1
{
    public partial class UserDashboard : Form
    {
        private MySQLDB mySqlDatabase; // Instance of MySQLDB for database connection
        private bool needRefresh = true; // Flag to track if event details need to be refreshed
        private List<TextBox> eventTextBoxes; // List of TextBoxes to display events
        private List<TextBox> recommendedTextBoxes;
        private static readonly object _dbLock = new object(); // Lock object for database operations

        public UserDashboard()
        {
            InitializeComponent();
            mySqlDatabase = MySQLDB.Instance(); // Initialize the singleton instance of MySQLDB

            // Check if the database connection is successful
            if (!mySqlDatabase.IsConnect())
            {
                MessageBox.Show("Error connecting to the database. Please try again.");
                return;
            }

            // Initialize the list of event TextBoxes
            eventTextBoxes = new List<TextBox> { Event2, Event3, Event4, Event5 };

            // Attach the click event handler to each TextBox for upcoming events
            foreach (var textBox in eventTextBoxes)
            {
                textBox.Click += EventTextBox_Click;
            }

            // Initialize the list of recommended TextBoxes (assuming these are added in the designer)
            recommendedTextBoxes = new List<TextBox> { recommendedTextBox1, recommendedTextBox2 };

            // Attach the click event handler to each TextBox for recommended events
            foreach (var textBox in recommendedTextBoxes)
            {
                textBox.Click += EventTextBox_Click;
            }
        }

        // This method is triggered when the UserDashboard loads
        private void UserDashboard_Load(object sender, EventArgs e)
        {
            // Execute database operations sequentially
            LoadEventDetails();        // Fetch and display event details
            LoadRecommendedEvents();   // Fetch and display recommended events
        }

        // This method is called when the form is activated
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);

            // Refresh event details only if necessary
            if (needRefresh)
            {
                LoadEventDetails();
                LoadRecommendedEvents(); // Ensure recommended events are also refreshed
                needRefresh = false; // Reset the refresh flag
            }
        }

        // Method to fetch and display event details synchronously
        private void LoadEventDetails()
        {
            lock (_dbLock)
            {
                try
                {
                    // Clear text boxes before reloading data
                    foreach (var textBox in eventTextBoxes)
                    {
                        textBox.Clear(); // Remove old data
                        textBox.Tag = null; // Clear any associated data
                    }

                    // Fetch event details
                    var eventDetailsList = mySqlDatabase.GetAllEventDetails();

                    // Ensure eventDetailsList is not null
                    if (eventDetailsList == null)
                    {
                        eventDetailsList = new List<(int EventID, DateTime EventStartTime, DateTime EventEndTime, string EventName, string EventDetails, string EventLocation)>();
                    }

                    // Check if any events were fetched
                    if (eventDetailsList.Count == 0)
                    {
                        // Optionally inform the user that no events were found
                        MessageBox.Show("No events found.");
                        return; // Exit the method if no events are found
                    }

                    // Populate text boxes with event details
                    for (int i = 0; i < eventTextBoxes.Count && i < eventDetailsList.Count; i++)
                    {
                        var eventDetails = eventDetailsList[i];

                        // Update UI controls
                        eventTextBoxes[i].Text = $"{eventDetails.EventName}{Environment.NewLine}" +
                                                 $"Start: {eventDetails.EventStartTime}{Environment.NewLine}" +
                                                 $"End: {eventDetails.EventEndTime}{Environment.NewLine}" +
                                                 $"Location: {eventDetails.EventLocation}{Environment.NewLine}" +
                                                 $"{eventDetails.EventDetails}";
                        eventTextBoxes[i].Tag = eventDetails;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading events: " + ex.Message);
                    // TODO: Implement logging here if needed
                }
            }
        }


        // Method to fetch and display recommended events synchronously
        private void LoadRecommendedEvents()
        {
            lock (_dbLock)
            {
                try
                {
                    // Assuming you have the user's ID. Replace `currentUserID` with the actual user's ID.
                    int currentUserID = Session.CurrentUser.UserId; // Placeholder for the current user's ID

                    // Clear recommended event text boxes before reloading data
                    foreach (var textBox in recommendedTextBoxes)
                    {
                        textBox.Clear(); // Remove old data
                        textBox.Tag = null; // Clear any associated data
                    }

                    // Fetch user tags
                    var userTags = mySqlDatabase.GetUserTags(currentUserID);

                    // Check if any tags were fetched
                    if (userTags == null || userTags.Count == 0)
                    {
                        MessageBox.Show("No tags found for the user.");
                        return; // Exit the method if no tags are found
                    }

                    // Fetch recommended event details based on user tags
                    var recommendedEvents = mySqlDatabase.GetRecommendedEvents(userTags);

                    // Check if any events were fetched
                    if (recommendedEvents == null || recommendedEvents.Count == 0)
                    {
                        MessageBox.Show("No recommended events found.");
                        return; // Exit the method if no events are found
                    }

                    // Populate text boxes with event details
                    for (int i = 0; i < recommendedTextBoxes.Count && i < recommendedEvents.Count; i++)
                    {
                        var eventDetails = recommendedEvents[i];

                        // Update UI controls to display all relevant event information
                        recommendedTextBoxes[i].Text = $"{eventDetails.EventName}{Environment.NewLine}" +
                                                       $"Start: {eventDetails.EventStartTime}{Environment.NewLine}" +
                                                       $"End: {eventDetails.EventEndTime}{Environment.NewLine}" +
                                                       $"Location: {eventDetails.EventLocation}{Environment.NewLine}" +
                                                       $"{eventDetails.EventDetails}";
                        recommendedTextBoxes[i].Tag = eventDetails; // Store the event details in the Tag property
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading recommended events: " + ex.Message);
                    // TODO: Implement logging here if needed
                }
            }
        }


        // Method to open the EventDetails form when a text box is clicked
        private void OpenEventDetails(TextBox textBox)
        {
            // Check if the text box has event details associated with it
            if (textBox.Tag == null)
            {
                MessageBox.Show("No event details found. Please try again.");
                return;
            }

            // Retrieve the event details from the Tag property
            var eventDetails = ((int EventID, DateTime EventStartTime, DateTime EventEndTime, string EventName, string EventDetails, string EventLocation))textBox.Tag;

            // Create a new instance of EventDetails form with the event information
            using (EventDetails detailsForm = new EventDetails(
                eventDetails.EventID,
                eventDetails.EventName,
                eventDetails.EventStartTime,
                eventDetails.EventDetails
            ))
            {
                // Show EventDetails as a modal dialog
                detailsForm.ShowDialog();
            }

            // Refresh event details after returning from the dialog
            LoadEventDetails();
            LoadRecommendedEvents();
        }



        // Redirect to the user benefits page when the button is clicked
        private void BenefitsButton_Click(object sender, EventArgs e)
        {
            using (BenefitsHub benefitsForm = new BenefitsHub())
            {
                benefitsForm.ShowDialog();
            }
        }


        // Event handler for clicking on an event text box
        private void EventTextBox_Click(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                OpenEventDetails(textBox); // Open the event details for the clicked text box
            }
        }

        // Ensure that the entire application is closed when this form is closed
        private void UserDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        // Unused event handlers for form elements (can be removed if not needed)

    }
}
