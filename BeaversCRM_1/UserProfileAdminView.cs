using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BeaversCRM_1
{
    public partial class UserProfileAdminView : Form
    {
        public UserProfileAdminView()
        {
            InitializeComponent();
            initialiseBackgroundWorker();
        }

        public User user;
        public bool programmaticallyClosed = false;
        private BackgroundWorker worker;
        private List<EventAttendanceControl> attendanceControls;

        private void copyName_Click(object sender, EventArgs e)
        {
            copyToClipBoard(nameValue.Text);
        }

        private void copyEmail_Click(object sender, EventArgs e)
        {
            copyToClipBoard(emailValue.Text);
        }

        private void copyPhone_Click(object sender, EventArgs e)
        {
            copyToClipBoard(phoneValue.Text);
        }

        private void copyAddress_Click(object sender, EventArgs e)
        {
            copyToClipBoard(addressValue.Text);
        }

        private void copyPosition_Click(object sender, EventArgs e)
        {
            copyToClipBoard(positionValue.Text);
        }

        private void copyTags_Click(object sender, EventArgs e)
        {
            copyToClipBoard(tagsValue.Text);
        }

        private void copyMembership_Click(object sender, EventArgs e)
        {
            copyToClipBoard(membershipValue.Text);
        }

        private void copyUserType_Click(object sender, EventArgs e)
        {
            copyToClipBoard(userTypeValue.Text);
        }

        private void UserProfileAdminView_Shown(object sender, EventArgs e)
        {
            nameValue.Text = user.FirstName + " " + user.LastName;
            emailValue.Text = user.Email;
            phoneValue.Text = user.PhoneNumber;
            if (user.Tags != null && user.Tags.Count != 0)
            {
                tagsValue.Text = string.Join(", ", user.Tags);
            }
            membershipValue.Text = "Non-Member";
            userTypeValue.Text = user.IsAdmin ? "Admin" : "Basic";
            worker.RunWorkerAsync();
        }

        private void UserProfileAdminView_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!programmaticallyClosed && Session.isLoggedIn)
            {
                Application.Exit();
            }
        }
        
        private void initialiseBackgroundWorker()
        {
            worker = new BackgroundWorker
            {
                WorkerSupportsCancellation = true
            };
            worker.DoWork += workerCreateEventsAttendance;
            worker.RunWorkerCompleted += workerLoadEventsAttendance;
        }

        private void workerCreateEventsAttendance(object sender, DoWorkEventArgs e)
        {
            try
            {
                attendanceControls = new List<EventAttendanceControl>();
                foreach (DataRow attendance in EventAttendance.getFromDb(user.UserId))
                {
                    EventAttendanceControl ctrl = new EventAttendanceControl();
                    ctrl.setAttendanceProperties(attendance);
                    attendanceControls.Add(ctrl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating event attendance controls: " + ex.Message);
            }
        }

        private void workerLoadEventsAttendance(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Error == null && attendanceControls.Count != 0)
                {
                    foreach (EventAttendanceControl attendanceControl in attendanceControls)
                    {
                        userEventsHistory.Controls.Add(attendanceControl);
                    }
                }
                else if (attendanceControls.Count == 0)
                {
                    NoResultsControl ctrl = new NoResultsControl();
                    ctrl.Size = new Size(userEventsHistory.Width - 6, userEventsHistory.Height - 6);
                    ctrl.mainPanel.Size = new Size(userEventsHistory.Width - 6, userEventsHistory.Height - 6);
                    ctrl.mainPanel.BackColor = userEventsHistory.BackColor;
                    userEventsHistory.Controls.Add(ctrl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding event attendance controls to page: " + ex.Message);
            }
        }

        public static void copyToClipBoard(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                Clipboard.SetText(text);
            }
        }
    }
}