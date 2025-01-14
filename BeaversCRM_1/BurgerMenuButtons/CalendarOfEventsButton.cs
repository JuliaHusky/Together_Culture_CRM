using System;
using System.Windows.Forms;

namespace BeaversCRM_1.BurgerMenuButtons
{
    public partial class CalendarOfEventsButton : UserControl
    {
        public CalendarOfEventsButton()
        {
            InitializeComponent();
        }

        private void calendarOfEventsBtn_Click(object sender, EventArgs e)
        {
            if (ParentForm.Name != "CalendarOfEvents")
            {
                Form calendarOfEvents = BurgerMenu.findOpenedForm("CalendarOfEvents");
                if (calendarOfEvents == null)
                {
                    calendarOfEvents = new CalendarOfEvents();
                }
                ParentForm.Hide();
                calendarOfEvents.Show();
            }
        }
    }
}