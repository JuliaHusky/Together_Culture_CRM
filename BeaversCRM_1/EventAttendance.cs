using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BeaversCRM_1
{
    public class EventAttendance
    {
        public User attendee { get; set; }
        public Event attendedEvent  { get; set; }
        public string attendanceStatus { get; set; }
        public string checkInDate { get; set; }
        public string checkOutDate { get; set; }

        public static DataRowCollection getFromDb(int userid)
        {
            try
            {
                Database db = new Database();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(Constants.GET_EVENT_ATTENDANCE, db.connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@userid", userid);
                    return db.getDataFromDb(adapter).Tables[0].Rows;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting event attendance data from database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}