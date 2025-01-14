using System;
using System.Windows.Forms;

namespace BeaversCRM_1.BurgerMenuButtons
{
    public partial class AdminSearchButton : UserControl
    {
        public AdminSearchButton()
        {
            InitializeComponent();
        }

        private void adminSearchBtn_Click(object sender, EventArgs e)
        {
            if (ParentForm.Name != "AdminSearch")
            {
                Form adminSearch = BurgerMenu.findOpenedForm("AdminSearch");
                if (adminSearch == null)
                {
                    adminSearch = new AdminSearch();
                }
                ParentForm.Hide();
                adminSearch.Show();
            }
        }
    }
}