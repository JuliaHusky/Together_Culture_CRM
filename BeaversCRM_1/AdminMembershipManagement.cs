using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeaversCRM_1
{
    public partial class AdminMembershipManagement : Form
    {
        public AdminMembershipManagement()
        {
            InitializeComponent();
        }

        private void BenefitsHubTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChangeMInterests_Click(object sender, EventArgs e)
        {

        }

        private void ChangeMInfo_Click(object sender, EventArgs e)
        {
            UserProfileAdminView userProfileAdminForm= new UserProfileAdminView();

            userProfileAdminForm.Show();

            this.Close();
        }

        private void PendingApplications_Click(object sender, EventArgs e)
        {

        }

        private void QuickSearchVScrollBar_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void MemberNameTitleLbl_Click(object sender, EventArgs e)
        {

        }

        private void QuickSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuickSearchBtn_Click(object sender, EventArgs e)
        {

        }

        private void QuickSearchTitle_Click(object sender, EventArgs e)
        {

        }

        private void MemberIDTitleLbl_Click(object sender, EventArgs e)
        {

        }

        private void MembershipTierTitleLbl_Click(object sender, EventArgs e)
        {

        }

        private void AdminMembershipManagement_Load(object sender, EventArgs e)
        {

        }

        private void ExpiryDateTitleLbl_Click(object sender, EventArgs e)
        {

        }

        private void MembershipTiers_Click(object sender, EventArgs e)
        {

        }

        private void burgerMenuAdmin1_Load(object sender, EventArgs e)
        {

        }
    }
}
