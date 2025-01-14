using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BeaversCRM_1
{
    public partial class EventPage : Form
    {
        public EventPage()
        {
            InitializeComponent();
        }
        
        public Event eventDetails;

        private void EventPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Session.isLoggedIn)
            {
                Application.Exit();
            }
        }

        private void copyName_Click(object sender, EventArgs e)
        {
            UserProfileAdminView.copyToClipBoard(titleValue.Text);
        }

        private void copyType_Click(object sender, EventArgs e)
        {
            UserProfileAdminView.copyToClipBoard(typeValue.Text);
        }

        private void copyStartDate_Click(object sender, EventArgs e)
        {
            UserProfileAdminView.copyToClipBoard(startDateValue.Text);
        }

        private void copyEndDate_Click(object sender, EventArgs e)
        {
            UserProfileAdminView.copyToClipBoard(endDateValue.Text);
        }

        private void copyLocation_Click(object sender, EventArgs e)
        {
            UserProfileAdminView.copyToClipBoard(locationValue.Text);
        }

        private void copyTag_Click(object sender, EventArgs e)
        {
            UserProfileAdminView.copyToClipBoard(tagsValue.Text);
        }

        private void copyAttendees_Click(object sender, EventArgs e)
        {
            UserProfileAdminView.copyToClipBoard(peopleAttendedValue.Text);
        }

        private void copyLimit_Click(object sender, EventArgs e)
        {
            UserProfileAdminView.copyToClipBoard(limitValue.Text);
        }
        
        private void copyDescription_Click(object sender, EventArgs e)
        {
            UserProfileAdminView.copyToClipBoard(eventDescriptionValue.Text);
        }

        private void setEventPageProperties()
        {
            using (MemoryStream imageStream = new MemoryStream(eventDetails.image))
            {
                eventPicture.Image = Image.FromStream(imageStream);
            }

            titleValue.Text = eventDetails.name;
            typeValue.Text = eventDetails.type;
            startDateValue.Text = eventDetails.startDate.ToString();
            endDateValue.Text = eventDetails.endDate.ToString();
            locationValue.Text = eventDetails.location;
            peopleAttendedValue.Text = eventDetails.numberOfAttendees.ToString();
            eventDescriptionValue.Text = eventDetails.description;
        }

        private void EventPage_Shown(object sender, EventArgs e)
        {
            setEventPageProperties();
        }
    }
}