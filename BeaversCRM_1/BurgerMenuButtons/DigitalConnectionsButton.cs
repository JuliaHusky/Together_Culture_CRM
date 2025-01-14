using System;
using System.Windows.Forms;

namespace BeaversCRM_1.BurgerMenuButtons
{
    public partial class DigitalConnectionsButton : UserControl
    {
        public DigitalConnectionsButton()
        {
            InitializeComponent();
        }

        private void digitalConnectionsBtn_Click(object sender, EventArgs e)
        {
            if (ParentForm.Name != "DigitalConnections")
            {
                Form digitalConnections = BurgerMenu.findOpenedForm("DigitalConnections");
                if (digitalConnections == null)
                {
                    digitalConnections = new DigitalConnections();
                }
                ParentForm.Hide();
                digitalConnections.Show();
            }
        }
    }
}