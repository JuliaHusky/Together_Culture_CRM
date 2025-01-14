using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BeaversCRM_1
{
    public partial class MembershipRequestControl : UserControl
    {
        public MembershipRequestControl()
        {
            InitializeComponent();
        }

        public MembershipRequest request;

        private void requestAvatar_Click(object sender, EventArgs e)
        {
            UserProfileAdminView userProfile = findUserProfileForm(request.user.Email);
            if (userProfile == null)
            {
                userProfile = new UserProfileAdminView();
                userProfile.user = request.user;
            }
            ParentForm.Hide();
            userProfile.Show();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            UserProfileAdminView userProfileForm = findUserProfileForm(request.user.Email);
            if (userProfileForm != null)
            {
                userProfileForm.programmaticallyClosed = true;
                userProfileForm.Close();
            }
            request.accept();
            MembershipRequests parent = ParentForm as MembershipRequests;
            parent.requestControls.Remove(this);
            Parent.Controls.Remove(this);
            MessageBox.Show("Request accepted!");
        }

        private void declineButton_Click(object sender, EventArgs e)
        {
            UserProfileAdminView userProfileForm = findUserProfileForm(request.user.Email);
            if (userProfileForm != null)
            {
                userProfileForm.programmaticallyClosed = true;
                userProfileForm.Close();
            }
            request.decline();
            MembershipRequests parent = ParentForm as MembershipRequests;
            parent.requestControls.Remove(this);
            Parent.Controls.Remove(this);
            MessageBox.Show("Request declined!");
        }

        private UserProfileAdminView findUserProfileForm(string email)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is UserProfileAdminView profileForm && profileForm.user.Email == email)
                {
                    return profileForm;
                }
            }
            return null;
        }

        public void setRequestProperties(DataRow requestRecord)
        {
            request = new MembershipRequest();
            request.user = new User();
            request.membership = new MembershipType();
            request.paymentStatus = requestRecord[0] as string;
            request.approvalStatus = requestRecord[1] as string;
            request.membership.name = requestRecord[2] as string;
            request.user.FirstName = requestRecord[3] as string;
            request.user.LastName = requestRecord[4] as string;
            request.user.Email = requestRecord[5] as string;
            request.user.PhoneNumber = Convert.ToString(requestRecord[6]);
            request.user.IsAdmin = requestRecord[7] as string == "1";
            request.user.Tags = new List<string>();
            request.user.Tags.Add(requestRecord[8] as string);
            request.user.UserId = (int)requestRecord[9];
            request.membership.MembershipTypeID = (int)requestRecord[10];
            nameLabel.Text = nameLabel.Text + request.user.FirstName + " " + request.user.LastName;
            emailLabel.Text += request.user.Email;
            membershipLabel.Text += request.membership.name;
            paymentLabel.Text += request.paymentStatus;
            paymentLabel.BackColor = request.paymentStatus == "Pending" ? Color.Yellow : Color.Green;
            statusLabel.Text += request.approvalStatus;
            statusLabel.BackColor = request.approvalStatus == "Pending" ? Color.Yellow : Color.Green;
        }
    }
}