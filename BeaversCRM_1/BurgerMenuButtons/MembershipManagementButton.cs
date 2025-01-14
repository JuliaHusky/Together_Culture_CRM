using System;
using System.Windows.Forms;

namespace BeaversCRM_1.BurgerMenuButtons
{
    public partial class MembershipManagementButton : UserControl
    {
        public MembershipManagementButton()
        {
            InitializeComponent();
        }

        private void membershipManagementBtn_Click(object sender, EventArgs e)
        {
            if (ParentForm.Name != "AdminMembershipManagement")
            {
                Form membershipManagement = BurgerMenu.findOpenedForm("AdminMembershipManagement");
                if (membershipManagement == null)
                {
                    membershipManagement = new AdminMembershipManagement();
                }
                ParentForm.Hide();
                membershipManagement.Show();
            }
        }
    }
}