using System;
using System.Data;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace BeaversCRM_1
{
    // A singleton class for managing the MySQL database connections.
    internal class MySQLDB
    {
        // Private constructor to ensure only one instance of this class is created.
        private MySQLDB()
        {
            // Initialise the default database connection parameters.
            this.Server = "localhost";
            this.DatabaseName = "tc_crm";
            this.UserName = "root";
            this.Password = "";
        }

        // Properties to hold the database connection details.
        public string Server { get; set; }
        public string DatabaseName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        // Store the connection to the database.
        public MySqlConnection Connection { get; set; }

        // Static instance for the singleton pattern.
        private static MySQLDB _instance = null;

        // Method to get the single instance of MySQLDB
        public static MySQLDB Instance()
        {
            // Create the instance only if it doesn't already exist.
            if (_instance == null)
                _instance = new MySQLDB();
            return _instance;
        }

        // Method to get a connection to the database.
        public bool IsConnect()
        {
            // If the connection hasn't been initialised yet, create it.
            if (Connection == null)
            {
                // Build the connection string.
                string connstring = string.Format("Server={0}; database={1}; UID={2}; password={3}", Server, DatabaseName, UserName, Password);
                Connection = new MySqlConnection(connstring); // Create a new MySQL connection.
            }

            // If the connection isn't already open, try to open it.
            if (Connection.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    Connection.Open(); // Attempt to open the connection.
                }
                catch
                {
                    return false; // Return false if the connection fails.
                }
            }
            return true; // Return true if the connection is successful.
        }

        // Method to close the connection.
        public void Close()
        {
            if (Connection != null)
                Connection.Close();
        }

        // Method to get data from the database using a MySqlDataAdapter
        public DataSet getDataFromDb(MySqlDataAdapter adapter)
        {
            DataSet dataSet = new DataSet();
            try
            {
                // The connection is already managed by the IsConnect method
                if (IsConnect())
                {
                    adapter.Fill(dataSet);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting data from database: " + ex.Message);
            }
            return dataSet;
        }

        // New method to retrieve event details by EventID
        public List<(int EventID, DateTime EventStartTime, DateTime EventEndTime, string EventName, string EventDetails, string EventLocation)> GetAllEventDetails()
        {
            var events = new List<(int, DateTime, DateTime, string, string, string)>();
            if (!IsConnect())
            {
                Console.WriteLine("Database connection failed.");
                return events;
            }

            string query = "SELECT EventID, EventStartTime, EventEndTime, EventName, EventDetails, EventLocation FROM Event";
            MySqlCommand cmd = new MySqlCommand(query, Connection);

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int eventId = Convert.ToInt32(reader["EventID"]);
                    DateTime eventStartTime = Convert.ToDateTime(reader["EventStartTime"]);
                    DateTime eventEndTime = Convert.ToDateTime(reader["EventEndTime"]);
                    string eventName = reader["EventName"].ToString();
                    string eventDetails = reader["EventDetails"].ToString();
                    string eventLocation = reader["EventLocation"].ToString();

                    Console.WriteLine($"Fetched Event: ID={eventId}, Name={eventName}, Start={eventStartTime}, End={eventEndTime}, Location={eventLocation}, Details={eventDetails}");

                    events.Add((eventId, eventStartTime, eventEndTime, eventName, eventDetails, eventLocation));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return events;
        }


        // New method to retrieve UserTags details
        public List<int> GetUserTags(int userId)
        {
            // Query to get tag IDs associated with the user
            string query = $"SELECT TagID FROM UserTags WHERE UserID = {userId}";
            List<int> tagIds = new List<int>();

            MySqlCommand cmd = new MySqlCommand(query, this.Connection);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    tagIds.Add(reader.GetInt32(0));
                }
            }

            return tagIds;
        }

        // New method to retrieve RecommendedEvents by tag IDs
        public List<(int EventID, DateTime EventStartTime, DateTime EventEndTime, string EventName, string EventDetails, string EventLocation)> GetRecommendedEvents(List<int> tagIds)
        {
            var eventDetailsList = new List<(int, DateTime, DateTime, string, string, string)>();

            // Return an empty list if no tags are provided
            if (tagIds == null || tagIds.Count == 0) return eventDetailsList;

            // Join tag IDs into a comma-separated string
            string tagIdsString = string.Join(",", tagIds);

            // SQL query updated to match new database schema
            string query = $"SELECT EventID, EventStartTime, EventEndTime, EventName, EventDetails, EventLocation FROM Event WHERE TagID IN ({tagIdsString})";

            // Ensure connection is open
            if (!IsConnect())
            {
                Console.WriteLine("Database connection failed.");
                return eventDetailsList;
            }

            try
            {
                // Create and execute the MySQL command
                MySqlCommand cmd = new MySqlCommand(query, this.Connection);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        eventDetailsList.Add(
                            (
                                reader.GetInt32("EventID"),
                                reader.GetDateTime("EventStartTime"),
                                reader.GetDateTime("EventEndTime"),
                                reader.GetString("EventName"),
                                reader.GetString("EventDetails"),
                                reader.GetString("EventLocation")
                            )
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred in GetRecommendedEvents: " + ex.Message);
            }

            return eventDetailsList;
        }



    }
}
