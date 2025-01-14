using System;
using System.Windows.Forms;

namespace BeaversCRM_1.BurgerMenuButtons
{
    public partial class BenefitsHubButton : UserControl
    {
        public BenefitsHubButton()
        {
            InitializeComponent();
        }

        private void benefitsHubBtn_Click(object sender, EventArgs e)
        {
            if (ParentForm.Name != "BenefitsHub")
            {
                Form benefitsHub = BurgerMenu.findOpenedForm("BenefitsHub");
                if (benefitsHub == null)
                {
                    benefitsHub = new BenefitsHub();
                }
                ParentForm.Hide();
                benefitsHub.Show();
            }
        }
    }
}