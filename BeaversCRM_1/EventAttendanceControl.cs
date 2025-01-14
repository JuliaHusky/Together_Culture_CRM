using System;
using System.Data;
using System.Windows.Forms;

namespace BeaversCRM_1
{
    public partial class EventAttendanceControl : UserControl
    {
        public EventAttendanceControl()
        {
            InitializeComponent();
        }

        private EventAttendance eventAttendanceData;

        public void setAttendanceProperties(DataRow attendanceRecord)
        {
            eventAttendanceData = new EventAttendance();
            eventAttendanceData.attendedEvent = new Event();
            eventAttendanceData.attendanceStatus = attendanceRecord[0] as string;
            eventAttendanceData.checkInDate = attendanceRecord[1].ToString();
            eventAttendanceData.checkOutDate = attendanceRecord[2].ToString();
            eventAttendanceData.attendedEvent.name = attendanceRecord[3] as string;
            nameLabel.Text = eventAttendanceData.attendedEvent.name;
            attendeeStatusValueLabel.Text = eventAttendanceData.attendanceStatus;
            checkInDateValueLabel.Text = eventAttendanceData.checkInDate;
            checkOutDateValueLabel.Text = eventAttendanceData.checkOutDate;
        }
    }
}