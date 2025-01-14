using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //Connects to XAMPP database

namespace BeaversCRM_1
{
    public partial class CalendarOfEvents : Form
    {
        private DateTime _currentStartDate;  //Tracks start date for currently selected week
        private MySQLDB mySqlDatabase; //Declare for instance below

        public CalendarOfEvents()
        {
            InitializeComponent();
            mySqlDatabase = MySQLDB.Instance(); //Connects to the database
            //initialize to the current week's start date (Monday)
            _currentStartDate = BeaversCRM_1.DateTimeExtensions.StartOfWeek(DateTime.Today, DayOfWeek.Monday);
            //Populates the dropdowns and updates the calendar
            PopulateDropdowns();
            UpdateWeekView();
        }

        public class EventInfo //Class to represent the event information
        {
            public string EventName { get; set; }
            public string EventLocation { get; set; }
            public DateTime EventStartTime { get; set; }
            public DateTime EventEndTime { get; set; }
        }
        //Populate day, month, year in the dropdown menus on calendar
        private void PopulateDropdowns()
        {   //Populate the year dropdown 
            for (int year = 2000; year <= 2100; year++)
            {
                CmbYearBox.Items.Add(year);
            }

            //Populate Month dropdown Jan-Dec
            for (int month = 1; month <= 12; month++)
            {
                CmbMonthBox.Items.Add(new DateTime(1, month, 1).ToString("MMMM"));
            }

            //Populate the Day dropdown (1-31)
            for (int day = 1; day <= 31; day++)
            {
                CmbDayBox.Items.Add(day);
            }

            //Set current date values into the dropdowns
            CmbYearBox.SelectedItem = _currentStartDate.Year;
            CmbMonthBox.SelectedIndex = _currentStartDate.Month - 1;
            CmbDayBox.SelectedItem = _currentStartDate.Day;

        }
        //Updates the week value within the GUI, Displays the week range, day lables and the current month/year.       
        private void UpdateWeekView()
        {
            DateTime endOfWeek = _currentStartDate.AddDays(6);

            //Update Week range & MonthYearShown label to display the current week range and month/year being displayed on the events calendar
            WeekRangeLbl.Text = $"{_currentStartDate:MMM dd} - {endOfWeek:MMM dd, yyyy}";

            //Update each days label within EventsCalendar
            MonDateLbl.Text = $"{_currentStartDate:ddd}\n{_currentStartDate:dd}";
            TuesDateLbl.Text = $"{_currentStartDate.AddDays(1):ddd}\n{_currentStartDate.AddDays(1):dd}";
            WedsDateLbl.Text = $"{_currentStartDate.AddDays(2):ddd}\n{_currentStartDate.AddDays(2):dd}";
            ThurDateLbl.Text = $"{_currentStartDate.AddDays(3):ddd}\n{_currentStartDate.AddDays(3):dd}";
            FriDateLbl.Text = $"{_currentStartDate.AddDays(4):ddd}\n{_currentStartDate.AddDays(4):dd}";
            SatDateLbl.Text = $"{_currentStartDate.AddDays(5):ddd}\n{_currentStartDate.AddDays(5):dd}";
            SunDateLbl.Text = $"{_currentStartDate.AddDays(6):ddd}\n{_currentStartDate.AddDays(6):dd}";

            MonEventsLbl.Text = "";
            TuesEventsLbl.Text = "";
            WedsEventLbl.Text = "";
            ThursEventLbl.Text = "";
            FriEventsLbl.Text = "";
            SatEventsLbl.Text = "";
            SunEventsLbl.Text = "";

            //Get events for week shown
            var eventsThisWeek = GetEventsForWeek(_currentStartDate);
            //Group eventx by the date component of EventStartTime
            var eventsByDay = eventsThisWeek.GroupBy(ev => ev.EventStartTime.Date).ToList();

            foreach (var dailyEvents in eventsByDay)
            {
                DateTime currentDay = dailyEvents.Key;
                string eventDetails = "";

                //Fill events for each day
                foreach (var ev in dailyEvents)
                {
                    eventDetails += $"- {ev.EventName} ({ev.EventStartTime:HH:mm} - {ev.EventEndTime:HH:mm}) @ {ev.EventLocation}\n";

                }
                int dayOffset = (int)(currentDay - _currentStartDate).TotalDays;

                switch (dayOffset)
                {
                    case 0: MonEventsLbl.Text = eventDetails; break;
                    case 1: TuesEventsLbl.Text = eventDetails; break;
                    case 2: WedsEventLbl.Text = eventDetails; break;
                    case 3: ThursEventLbl.Text = eventDetails; break;
                    case 4: FriEventsLbl.Text = eventDetails; break;
                    case 5: SatEventsLbl.Text = eventDetails; break;
                    case 6: SunEventsLbl.Text = eventDetails; break;
                }
            }

        }
        private void AdminMembershipTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void CalendarOfEvents_Load(object sender, EventArgs e)
        {

        }

        private void txtEvent_TextChanged(object sender, EventArgs e)
        {

        }

        private void addEventBtn_Click(object sender, EventArgs e)
        {

        }

        private void EventsCalandar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TuesdayLbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EveLbl_Click(object sender, EventArgs e)
        {

        }

        private void MonLbl_Click(object sender, EventArgs e)
        {

        }

        private void WedsLbl_Click(object sender, EventArgs e)
        {

        }

        private void ThurLbl_Click(object sender, EventArgs e)
        {

        }

        private void FriLbl_Click(object sender, EventArgs e)
        {

        }

        private void SatLbl_Click(object sender, EventArgs e)
        {

        }

        private void SunLbl_Click(object sender, EventArgs e)
        {

        }

        private void PrevMonthBtn_Click(object sender, EventArgs e)
        {

        }

        private void NextWeekBtn_Click(object sender, EventArgs e)
        {

        }

        private void PrevYearBtn_Click(object sender, EventArgs e)
        {

        }

        private void NextYearBtn_Click(object sender, EventArgs e)
        {

        }

        private void MonDateLbl_Click(object sender, EventArgs e)
        {

        }

        private void TuesDateLbl_Click(object sender, EventArgs e)
        {

        }

        private void WedsDateLbl_Click(object sender, EventArgs e)
        {

        }

        private void ThurDateLbl_Click(object sender, EventArgs e)
        {

        }

        private void FriDateLbl_Click(object sender, EventArgs e)
        {

        }

        private void SatDateLbl_Click(object sender, EventArgs e)
        {

        }
        //Handles the dropdown values & Changes - Updates calendar to reflect current date

        private List<EventInfo> GetEventsForWeek(DateTime startOfWeek)
        {
            List<EventInfo> eventsForWeek = new List<EventInfo>();
            DateTime endOfWeek = startOfWeek.AddDays(7);

            string query = "SELECT EventName, EventLocation, EventStartTime, EventEndTime " +
                           "FROM tc_crm.event " +
                           "WHERE EventStartTime >= @StartOfWeek AND EventStartTime < @EndOfWeek ";


            MySQLDB dbConn = MySQLDB.Instance();

            try
            {
                dbConn.IsConnect();

                using (MySqlCommand cmd = new MySqlCommand(query, dbConn.Connection))
                {
                    cmd.Parameters.AddWithValue("@StartOfWeek", startOfWeek);
                    cmd.Parameters.AddWithValue("@EndOfWeek", endOfWeek);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EventInfo eventInfo = new EventInfo
                            {
                                EventName = reader.GetString("EventName"),
                                EventLocation = reader.GetString("EventLocation"),
                                EventStartTime = reader.GetDateTime("EventStartTime"),
                                EventEndTime = reader.GetDateTime("EventEndTime")
                            };
                            eventsForWeek.Add(eventInfo);
                        }
                    }
                    return eventsForWeek;


                }

            }
            catch
            {
                return null;
            }
        }


                /*
                            using (MySqlConnection conn = mySqlDatabase.Connection)
                            {
                                if (conn == null || conn.State != ConnectionState.Open) //Tests the database is connected and working
                                {

                                    MessageBox.Show("Could not connect to the database.", "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return eventsForWeek; //Return empty list if no database connection
                                }

                                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@StartOfWeek", startOfWeek);
                                    cmd.Parameters.AddWithValue("@EndOfWeek", endOfWeek);

                                    using (MySqlDataReader reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            EventInfo eventInfo = new EventInfo
                                            {
                                                EventName = reader.GetString("EventName"),
                                                EventLocation = reader.GetString("EventLocation"),
                                                EventStartTime = reader.GetDateTime("EventStartTime"),
                                                EventEndTime = reader.GetDateTime("EventEndTime")
                                            };
                                            eventsForWeek.Add(eventInfo);
                                        }
                                    }
                                } */


            

        

        
        private void CmbdDateBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbYearBox.SelectedItem != null && CmbMonthBox.SelectedIndex >= 0 && CmbDayBox.SelectedItem != null)
            {
                int selectedYear = (int)CmbYearBox.SelectedItem;
                int selectedMonth = CmbMonthBox.SelectedIndex + 1;
                int selectedDay = (int)CmbDayBox.SelectedItem;

                if (DateTime.TryParse($"{selectedYear}-{selectedMonth}-{selectedDay}", out DateTime selectedDate))
                {
                    _currentStartDate = BeaversCRM_1.DateTimeExtensions.StartOfWeek(selectedDate, DayOfWeek.Monday);

                    UpdateWeekView();
                }
                else
                {
                    MessageBox.Show("Invalid Date selected, Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SunDateLbl_Click(object sender, EventArgs e)
        {

        }

        private void DayShown_Click(object sender, EventArgs e)
        {

        }

        private void SelectMonth_Click(object sender, EventArgs e)
        {

        }

        private void YearShown_Click(object sender, EventArgs e)
        {

        }

        private void TitleCal_Click(object sender, EventArgs e)
        {

        }

        private void MonEventsLbl_Click(object sender, EventArgs e)
        {

        }

        private void TuesEventsLbl_Click(object sender, EventArgs e)
        {

        }

        private void WedsEventLbl_Click(object sender, EventArgs e)
        {

        }

        private void ThursEventLbl_Click(object sender, EventArgs e)
        {

        }

        private void FriEventsLbl_Click(object sender, EventArgs e)
        {

        }

        private void SatEventsLbl_Click(object sender, EventArgs e)
        {

        }

        private void SunEventsLbl_Click(object sender, EventArgs e)
        {

        }
    }

    public static class DateTimeExtensions
    {
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }
    }
}
