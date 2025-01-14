using System;
using System.Windows.Forms;

namespace BeaversCRM_1.BurgerMenuButtons
{
    public partial class AdminDashboardButton : UserControl
    {
        public AdminDashboardButton()
        {
            InitializeComponent();
        }

        private void adminDashboardBtn_Click(object sender, EventArgs e)
        {
            if (ParentForm.Name != "AdminDashboard")
            {
                Form adminDashboard = BurgerMenu.findOpenedForm("AdminDashboard");
                if (adminDashboard == null)
                {
                    adminDashboard = new AdminDashboard();
                }
                ParentForm.Hide();
                adminDashboard.Show();
            }
        }
    }
}