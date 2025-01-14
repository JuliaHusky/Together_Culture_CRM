using System;
using System.Windows.Forms;

namespace BeaversCRM_1.BurgerMenuButtons
{
    public partial class EventManagementButton : UserControl
    {
        public EventManagementButton()
        {
            InitializeComponent();
        }

        private void eventManagementBtn_Click(object sender, EventArgs e)
        {
            if (ParentForm.Name != "EventManagementAdmin")
            {
                Form eventManagement = BurgerMenu.findOpenedForm("EventManagementAdmin");
                if (eventManagement == null)
                {
                    eventManagement = new EventManagementAdmin();
                }
                ParentForm.Hide();
                eventManagement.Show();
            }
        }
    }
}