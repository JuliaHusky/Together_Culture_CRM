using System;
using System.Windows.Forms;

namespace BeaversCRM_1.BurgerMenuButtons
{
    public partial class AccountSettingsButton : UserControl
    {
        public AccountSettingsButton()
        {
            InitializeComponent();
        }

        private void accSettingsBtn_Click(object sender, EventArgs e)
        {
            if (ParentForm.Name != "AccountSetting")
            {
                Form accountSettings = BurgerMenu.findOpenedForm("AccountSetting");
                if (accountSettings == null)
                {
                    accountSettings = new AccountSetting();
                }
                ParentForm.Hide();
                accountSettings.Show();
            }
        }
    }
}