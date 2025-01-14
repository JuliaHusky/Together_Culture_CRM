using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net.Mime;
using System.Windows.Forms;

namespace BeaversCRM_1
{
    public partial class EventControl : UserControl
    {
        public EventControl()
        {
            InitializeComponent();
        }

        private Event eventDetails;

        private void eventNameLabel_Click(object sender, EventArgs e)
        {
            EventPage eventPage = findEventPageForm(eventDetails.id);
            if (eventPage == null)
            {
                eventPage = new EventPage();
                eventPage.eventDetails = eventDetails;
            }
            ParentForm.Hide();
            eventPage.Show();
        }

        public void setEventControlProperties(DataRow eventRecord)
        {
            try
            {
                eventDetails = new Event();
                eventDetails.id = (int)eventRecord["EventID"];
                eventDetails.image = eventRecord["EventImage"] as byte[];
                eventDetails.startDate = DateTime.Parse(eventRecord["EventStartTime"].ToString());
                eventDetails.endDate = DateTime.Parse(eventRecord["EventEndTime"].ToString());
                eventDetails.type = eventRecord["EventType"]as string;
                eventDetails.name = eventRecord["EventName"] as string;
                eventDetails.description = eventRecord["EventDescription"] as string;
                eventDetails.location = eventRecord["EventLocation"] as string;
                eventDetails.numberOfAttendees = int.Parse(eventRecord["NumberOfAttendees"].ToString());
                eventNameLabel.Text = eventDetails.name;
                eventDescriptionLabel.Text = eventDetails.description;
                if (eventDetails.image == null) return;
                using (MemoryStream imageStream = new MemoryStream(eventDetails.image))
                {
                    eventPicture.Image = Image.FromStream(imageStream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error setting event control details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
        private EventPage findEventPageForm(int id)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is EventPage eventForm && eventForm.eventDetails.id == id)
                {
                    return eventForm;
                }
            }
            return null;
        }
    }
}