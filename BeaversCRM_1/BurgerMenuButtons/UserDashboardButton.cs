using System;
using System.Windows.Forms;

namespace BeaversCRM_1.BurgerMenuButtons
{
    public partial class UserDashboardButton : UserControl
    {
        public UserDashboardButton()
        {
            InitializeComponent();
        }

        private void userDashboardBtn_Click(object sender, EventArgs e)
        {
            if (ParentForm.Name != "UserDashboard")
            {
                Form userDashboard = BurgerMenu.findOpenedForm("UserDashboard");
                if (userDashboard == null)
                {
                    userDashboard = new UserDashboard();
                }
                ParentForm.Hide();
                userDashboard.Show();
            }
        }
    }
}