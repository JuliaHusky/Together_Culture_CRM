using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BeaversCRM_1.BurgerMenuButtons;

namespace BeaversCRM_1
{
    public partial class BurgerMenu : UserControl
    {
        public BurgerMenu()
        {
            InitializeComponent();
        }
        
        private void popUpMenuBtn_Click(object sender, EventArgs e)
        {
            if (menuPanel.Visible)
            {
                menuBtnPanel.BackColor = Color.FromArgb(243, 30, 60);
                menuOuterPanel.BackColor = Color.White;
            }
            else
            {
                menuBtnPanel.BackColor = Color.FromArgb(217, 217, 217);
                menuOuterPanel.BackColor = Color.FromArgb(217, 217, 217);
            }
            menuPanel.Visible = !menuPanel.Visible;
        }

        public static Form findOpenedForm(string formName)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == formName)
                {
                    return form;
                }
            }
            return null;
        }

        private void BurgerMenuAdmin_Load(object sender, EventArgs e)
        {
            if (Session.CurrentUser != null) {
                nameLabel.Text = Session.CurrentUser.FirstName + " " + Session.CurrentUser.LastName;
                if (Session.CurrentUser.IsAdmin)
                {
                    setBurgerMenuForAdmin();
                }
                else
                {
                    setBurgerMenuForMember();
                }
            }
        }

        private void setBurgerMenuForAdmin()
        {
            nameLabel.Text = Session.CurrentUser.FirstName + " " + Session.CurrentUser.LastName + "(Admin)";
            Size = new Size(Size.Width, Size.Height + 177);
            menuOuterPanel.Size = new Size(menuOuterPanel.Size.Width, menuOuterPanel.Size.Height + 177);
            menuPanel.Size = new Size(menuPanel.Size.Width, menuPanel.Size.Height + 177);
            AdminDashboardButton adminDashboardBtn = new AdminDashboardButton();
            MembershipManagementButton membershipManagementBtn = new MembershipManagementButton();
            MembershipRequestsButton membershipReqBtn = new MembershipRequestsButton();
            AdminSearchButton adminSearchBtn = new AdminSearchButton();
            EventManagementButton eventManagementBtn = new EventManagementButton();
            LogOutButton logOutBtn = new LogOutButton();
            menuPanel.Controls.AddRange(new Control[]{adminDashboardBtn, adminSearchBtn, membershipReqBtn, eventManagementBtn, membershipManagementBtn, logOutBtn});
        }

        private void setBurgerMenuForMember()
        {
            nameLabel.Text = Session.CurrentUser.FirstName + " " + Session.CurrentUser.LastName;
            Size = new Size(Size.Width, Size.Height + 72);
            menuOuterPanel.Size = new Size(menuOuterPanel.Size.Width, menuOuterPanel.Size.Height + 72);
            menuPanel.Size = new Size(menuPanel.Size.Width, menuPanel.Size.Height + 72);
            UserDashboardButton userDashboardBtn = new UserDashboardButton();
            CalendarOfEventsButton calendarOfEventsBtn = new CalendarOfEventsButton();
            BenefitsHubButton benefitsHubBtn = new BenefitsHubButton();
            DigitalConnectionsButton digitalConnectionsBtn = new DigitalConnectionsButton();
            AccountSettingsButton accountSettingsBtn = new AccountSettingsButton();
            LogOutButton logOutBtn = new LogOutButton();
            menuPanel.Controls.AddRange(new Control[]{userDashboardBtn, calendarOfEventsBtn, benefitsHubBtn, digitalConnectionsBtn, accountSettingsBtn, logOutBtn});
        }
    }
}