using System;
using System.Windows.Forms;

namespace BeaversCRM_1.BurgerMenuButtons
{
    public partial class MembershipRequestsButton : UserControl
    {
        public MembershipRequestsButton()
        {
            InitializeComponent();
        }

        private void membershipRequestsBtn_Click(object sender, EventArgs e)
        {
            if (ParentForm.Name != "MembershipRequests")
            {
                Form membershipReq = BurgerMenu.findOpenedForm("MembershipRequests");
                if (membershipReq == null)
                {
                    membershipReq = new MembershipRequests();
                }
                ParentForm.Hide();
                membershipReq.Show();
            }
        }
    }
}