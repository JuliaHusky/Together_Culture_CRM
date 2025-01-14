using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using Mysqlx.Expr;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Asn1.X509;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BeaversCRM_1
{
    internal class DbValidation
    {


        /* This method validates the user's credentials
           It returns true if the email and password match,
           otherwise returns false */
        public bool ValidateUserCredentials(string email, string password)
        {
            MySQLDB dbConn = MySQLDB.Instance(); // Get the database connection from the MySQLdb

            // Initialise result variable
            bool result = false;

            try
            {
                dbConn.IsConnect();

                // SQL command to fetch the stored hashed password for the given email
                using (MySqlCommand command = new MySqlCommand(Constants.CHECK_USER_LOGIN_DB, dbConn.Connection))
                {
                    // Add email value to SQL query
                    command.Parameters.AddWithValue("@Email", email);

                    // Execute the query and store the hashed password from the database
                    var storedPassword = command.ExecuteScalar()?.ToString();

                    // Hash the input password
                    string hashedInputPassword = ComputeSha256Hash(password);

                    // Compare the hashed input password with the stored hashed password
                    if (storedPassword != null && storedPassword == hashedInputPassword)
                    {
                        result = true; // Login success
                    }
                    else
                    {
                        result = false; // Invalid email or password
                    }
                }
            }
            catch (MySqlException)
            {
                result = false; // Catch any exceptions and return false
            }
            finally
            {
                dbConn.Close(); // Close connection to database
            }
            return result; // Return the result

        }

        // Method to hash the password
        public static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash returns byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                foreach (var t in bytes)
                {
                    builder.Append(t.ToString("x2")); // "x2" formats as hexadecimal
                }
                return builder.ToString();
            }
        }


        // Method to register a user and insert their payment details
        public bool RegisterUser(string firstName, string lastName, string gender, string email, string password,
                             string intention, bool marketingEmails, string cardNumber, string expiry, string cvv)
        {
            // Get the db connection from MySQLdb
            MySQLDB dbConn = MySQLDB.Instance();

            // Initialise result variable
            bool result = false;

            try
            {
                dbConn.IsConnect();
                // Sql command, query from Constants class to insert data into db
                var command = new MySqlCommand(Constants.INSERT_USER_DB, dbConn.Connection);

                // Define each parameter for the command
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@intention", intention);
                command.Parameters.AddWithValue("@marketingEmails", marketingEmails);


                // Execute the command to insert the user data into the database
                command.ExecuteNonQuery();

                // Get the userID 
                long userID = command.LastInsertedId;

                // Sql command, query from Constants class to insert payment into db
                var paymentCommand = new MySqlCommand(Constants.INSERT_PAYMENT_DB, dbConn.Connection);

                // Define each parameter for the command
                paymentCommand.Parameters.AddWithValue("@userID", userID);
                paymentCommand.Parameters.AddWithValue("@cardNumber", cardNumber);
                paymentCommand.Parameters.AddWithValue("@expiry", expiry);
                paymentCommand.Parameters.AddWithValue("@cvv", cvv);

                // Execute the command to insert payment data into the database
                paymentCommand.ExecuteNonQuery();

                result = true; // Everything was successful
            }
            catch (MySqlException)
            {
                result = false; // False if unsuccessful
            }
            finally
            {
                dbConn.Close(); // Close the connection to database
            }
            return result; // Return the result
        }



        /* This method retrieves the user data based on the 
           unique email address, it returns a user object with 
           the user's information */
        public User GetUserDataByEmail(string email)
        {
            // Initialise a user variable to hold the retrieved user data
            User user = null;
            MySQLDB dbConn = MySQLDB.Instance();

            try
            {
                dbConn.IsConnect();

                // Sql command, query from Constants class to fetch user data based on email 
                using (MySqlCommand command = new MySqlCommand(Constants.SELECT_USER_BY_EMAIL, dbConn.Connection))
                {
                    // Add email value to sql query
                    command.Parameters.AddWithValue("@Email", email);

                    // Execute the query and read data from db
                    using (var reader = command.ExecuteReader())
                    {
                        // If any records are returned
                        if (reader.Read())
                        {
                            // Populate the User object with data from the database
                            user = new User
                            {
                                // Store the User ID
                                UserId = reader.GetInt32("UserId"),
                                // Check for null values and store an empty string if so. If not empty we store the actual string
                                FirstName = reader.IsDBNull(reader.GetOrdinal("FirstName")) ? string.Empty : reader.GetString("FirstName"),
                                LastName = reader.IsDBNull(reader.GetOrdinal("LastName")) ? string.Empty : reader.GetString("LastName"),
                                Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? string.Empty : reader.GetString("Email"),
                                Gender = reader.IsDBNull(reader.GetOrdinal("Gender")) ? string.Empty : reader.GetString("Gender"),
                                Password = reader.IsDBNull(reader.GetOrdinal("Password")) ? string.Empty : reader.GetString("Password"),
                                Intention = reader.IsDBNull(reader.GetOrdinal("Intention")) ? string.Empty : reader.GetString("Intention"),
                                MembershipType = reader.IsDBNull(reader.GetOrdinal("MembershipType")) ? string.Empty : reader.GetString("MembershipType"),

                                // Boolean fields are checked for null and set to false if so
                                IsAdmin = reader.IsDBNull(reader.GetOrdinal("IsAdmin")) ? false : reader.GetBoolean("IsAdmin"),
                                IsVerified = reader.IsDBNull(reader.GetOrdinal("IsVerified")) ? false : reader.GetBoolean("IsVerified"),
                                MarketEmails = reader.IsDBNull(reader.GetOrdinal("MarketEmails")) ? false : reader.GetBoolean("MarketEmails")
                            };
                        }
                    }
                }
            }
            catch (MySqlException)
            {
                user = null; // Null if error occurs
            }
            finally
            {
                dbConn.Close(); // Close the connection
            }
            return user; // Return populated user
        }



        // Sign up to the newsletter on the homepage
        public bool NewsletterSignUp(string newsFName, string newsLName, string newsEmail)
        {
            // Get the db connection from MySQLdb
            MySQLDB dbConn = MySQLDB.Instance();

            // Initialise result variable
            bool result = false;

            try
            {
                dbConn.IsConnect();
                // Creates an SQL command to perform the query 
                var command = new MySqlCommand(Constants.INSERT_NEWSLETTER_USER, dbConn.Connection);

                // Define each parameter for the command
                command.Parameters.AddWithValue("@newsFName", newsFName);
                command.Parameters.AddWithValue("@newsLName", newsLName);
                command.Parameters.AddWithValue("@newsEmail", newsEmail);

                // Execute the command to insert the user data into the database
                command.ExecuteNonQuery();

                result = true; // If successful
            }
            catch (MySqlException)
            {
                result = false; // If unsuccessful
            }
            finally
            {
                dbConn.Close(); // Close the connection
            }
            return result; // Return the result
        }




        // Method to change the password in account settings
        public bool ChangePassword(int UserID, string newPassword)
        {
            // Get the db connection from MySQLdb
            MySQLDB dbConn = MySQLDB.Instance();

            // Initialise result variable
            bool result = false;

            try
            {
                // Check if the connection is open
                dbConn.IsConnect();

                // Prepares an SQL command to perform the query 
                using (var command = new MySqlCommand(Constants.UPDATE_PASSWORD, dbConn.Connection))
                {
                    // Define each parameter for the command 
                    command.Parameters.AddWithValue("@UserId", UserID); // Interested in the current userID
                    command.Parameters.AddWithValue("@newPassword", newPassword);

                    // Execute the query to insert new password into database
                    command.ExecuteNonQuery();

                    result = true; // If successful
                }
            }
            catch (MySqlException)
            {
                result = false; // If unsuccessful
            }
            finally
            {
                dbConn.Close(); // Close the connection
            }
            return result;
        }


        // Returns a list of document for the user
        public List<string> GetUserDocuments(int userId)
        {
            // Initialise a list to store the user's documents
            List<string> documents = new List<string>();

            // Get the db connection from MySQLdb
            MySQLDB dbConn = MySQLDB.Instance();

            try
            {
                // Check if the connection is open
                dbConn.IsConnect();

                // Prepare the SQL command to select the user's documents
                using (var command = new MySqlCommand(Constants.SELECT_USER_DOCUMENTS_BY_USERID, dbConn.Connection))
                {
                    // Add the user ID as a parameter to the SQL command
                    command.Parameters.AddWithValue("@UserId", userId);

                    // Execute the command and process the results
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Extract document name and type, format them, and add to the list 
                            string document = $"{reader["DocumentName"]} - {reader["DocumentType"]}";
                            documents.Add(document);
                        }
                    }
                }
            }
            catch (MySqlException)
            {
                documents = null; // Null if unsuccessful
            }
            finally
            {
                dbConn.Close(); // Close the connection
            }
            return documents; // Return list of documents
        }

        // Retrieves a list of events associated with the specified user
        public static List<string> GetUserEvents(int userID)
        {
            // Initialise a list to store the user's events
            List<string> eventsList = new List<string>();

            // Get the db connection from MySQLdb
            MySQLDB dbConn = MySQLDB.Instance();

            try
            {
                // Check if the connection is open
                dbConn.IsConnect();

                // Prepare the SQL command to select events for the given user ID
                using (var command = new MySqlCommand(Constants.VIEW_USER_EVENTS, dbConn.Connection))
                {
                    // Add the user ID as a parameter to the SQL command
                    command.Parameters.AddWithValue("@UserID", userID);

                    // Execute the command and process the results
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Extract event name and date, format them, and add to the list
                            string eventDetails = $"{reader["EventName"]} - {reader["EventStartTime"]}";
                            eventsList.Add(eventDetails);
                        }
                    }
                }
            }
            catch (MySqlException)
            {
                return null; // Null is unsuccessful
            }
            finally
            {
                dbConn.Close(); // Close the connection
            }
            return eventsList; // Return list of user's events
        }


        // Method to updgrade membership type
        public bool AccountUpgrade(int UserID, string newMembershipType)
        {
            // Get the db connection from MySQLdb
            MySQLDB dbConn = MySQLDB.Instance();

            // Initialise result variable
            bool result = false;

            try
            {
                // Check if the connection is open
                dbConn.IsConnect();

                // Prepare the SQL command to update the membership type 
                using (var command = new MySqlCommand(Constants.UPDATE_MEMBERSHIP, dbConn.Connection))
                {
                    // Define each parameter for the command 
                    command.Parameters.AddWithValue("@UserId", UserID); // Interested in the current userID
                    command.Parameters.AddWithValue("newMembershipType", newMembershipType);

                    // Execute the query to upgrade membership
                    command.ExecuteNonQuery();

                    result = true;

                }
            }
            catch (MySqlException)
            {
                result = false; // If unsuccessful
            }
            finally
            {
                dbConn.Close(); // Close the connection to the database
            }
            return result;
        }



        // Method to get the event names and dates to display in combo box in event management 
        public static List<string> GetEventNames()
        {
            // Create a new list to store the data in 
            List<string> eventList = new List<string>();

            // Get the database connection instance
            MySQLDB dbConn = MySQLDB.Instance(); 

            try
            {
                dbConn.IsConnect(); // Check if the connection is open

                // Prepare the SQL command to retrieve the event names and dates
                using (var command = new MySqlCommand(Constants.EVENT_MANAGEMENT_EVENT_LIST, dbConn.Connection))
                {
                    // Execute the query and read the results
                    using (var reader = command.ExecuteReader()) 
                    {
                        // Loop through the results
                        while (reader.Read()) 
                        {
                            // Combine the EventName and EventDateTime into a string
                            string eventName = reader["EventName"].ToString();
                            string eventStartTime = reader["EventStartTime"].ToString();

                            // Add the combined string to the list
                            eventList.Add($"{eventName}   |   {eventStartTime}");
                        }
                    }
                }
            }
            catch (MySqlException)
            {
                eventList = null; // Null if an error occurred
            }
            finally
            {
                dbConn.Close(); // Close the connection
            }
            return eventList; // Return the populated event list
        }



        // Retrieve the attendance data for a specific event
        public DataTable GetEventAttendance(string eventName, string eventStartTime)
        {
            MySQLDB dbConn = MySQLDB.Instance(); // Get the database connection instance

            // Prepare the DataTable to hold the query results
            DataTable dataTable = new DataTable();

            try
            {
                dbConn.IsConnect(); // Check if the connection is open

                // Prepare the SQL command to retrieve the event attendace data
                using (var command = new MySqlCommand(Constants.EVENT_ATTENDANCE, dbConn.Connection))
                {
                    // Add parameters to command and convert to DateTime otherwise sql query won't work
                    command.Parameters.AddWithValue("@EventName", eventName);
                    DateTime eventStartTimeParsed = DateTime.Parse(eventStartTime);
                    command.Parameters.AddWithValue("@EventStartTime", eventStartTimeParsed);

                    // Use a data adapter to fill the DataTable
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            catch (MySqlException)
            {
                dataTable = null; // Null if an error occurred
            }
            finally
            {
                dbConn.Close(); // Close the connection
            }
            return dataTable; // Return the DataTable
        }



        // Retrieve the data for all events stored in the database
        public DataTable GetAllEvents()
        {
            MySQLDB dbConn = MySQLDB.Instance(); // Get the database connection instance

            // Prepare the DataTable to hold the query results
            DataTable dataTable = new DataTable();

            try
            {
                dbConn.IsConnect(); // Check if the connection is open

                // Prepare the SQL command to retrieve the event data
                using (var command = new MySqlCommand(Constants.DISPLAY_ALL_EVENTS, dbConn.Connection))
                {
                    // Use a data adapter to fill the DataTable
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            catch (MySqlException)
            {
                dataTable = null; // Null if an error occurred
            }
            finally
            {
                dbConn.Close(); // Close the connection
            }
            return dataTable; // Return the DataTable
        }



        // Method to retrieve the event type for a specifc event name
        public string GetEventType(string eventName)
        {
            // Get the database connection instance
            MySQLDB dbConn = MySQLDB.Instance();

            // Initialise the event type variable
            string eventType = null;

            try
            {
                dbConn.IsConnect(); // Check if the connection is open

                // Prepare the SQL query to retrieve the event type based on the event name
                using (var command = new MySqlCommand(Constants.DISPLAY_EVENT_TAG, dbConn.Connection))
                {
                    // Add parameters to command
                    command.Parameters.AddWithValue("@EventName", eventName);

                    // Execute the query and retrieve the result as a string
                    eventType = command.ExecuteScalar().ToString();
                }
            }
            catch (MySqlException)
            {
                eventType = null; // Null if an error occurs
            }
            finally
            {
                dbConn.Close(); // Close the connection
            }
            return eventType; // Return the event type
        }



        // Method to get the number of attendees for a specific event
        public int GetNumberOfAttendees(string eventName, string eventStartTime)
        {
            // Get the database connection instance
            MySQLDB dbConn = MySQLDB.Instance();

            // Initialise variable to store the result 
            int result = 0;

            try
            {
                dbConn.IsConnect(); // Check if connection is open

                // Prepare the SQL query to retrieve the number of attendees based on an event
                using (var command = new MySqlCommand(Constants.EVENT_ATTENDANCE_SPECIFIC_EVENT, dbConn.Connection))
                {
                    // Add parameter to the SQL query
                    command.Parameters.AddWithValue("@EventName", eventName);

                    // Convert to DateTime otherwise sql query won't work with incorrect format
                    DateTime eventStartTimeParsed = DateTime.Parse(eventStartTime); 
                    command.Parameters.AddWithValue("@EventStartTime", eventStartTimeParsed);

                    // Return the value of the total number of attendees
                    result = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (MySqlException)
            {
                result = 0; // 0 if error occurred
            }
            finally
            {
                dbConn.Close(); // Close the connection
            }
            return result; // Return the result
        }



        // Method to retrieve events filtered by date
        public DataTable EventsFilteredByDate(DateTime startDate, DateTime endDate)
        {
            // Get the db connection from MySQLdb
            MySQLDB dbConn = MySQLDB.Instance();

            // Initialise the DataTable
            DataTable dataTable = new DataTable();

            try
            {
                dbConn.IsConnect(); // Check if the connection is open

                // Create the SQL command to execute the query 
                using (var command = new MySqlCommand(Constants.EVENTS_FILTERED_BY_DATE, dbConn.Connection))
                {
                    // Add the parameters to the command
                    command.Parameters.AddWithValue("@StartDate", startDate.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@EndDate", endDate.ToString("yyyy-MM-dd HH:mm:ss"));

                    // Execute the query and fill the DataTable
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            catch (MySqlException)
            {
                dataTable = null; // Null if an error occurs
            }
            finally
            {
                dbConn.Close(); // Close the connection
            }
            return dataTable; // Return the populated data table
        }




        // Method to create an event
        public bool CreateEvent(string eventName, string eventType, string eventDetails, string eventLocation, DateTime startDateTime, DateTime endDateTime)
        {
            // Get the db connection from MySQLdb
            MySQLDB dbConn = MySQLDB.Instance();

            // Initialise result variable
            bool result = false;

            try
            {
                // Check if the connection is open
                dbConn.IsConnect();

                // Sql command, query from Constants class to insert data into db
                var command = new MySqlCommand(Constants.INSERT_EVENT_INTO_DB, dbConn.Connection);

                // Define each parameter for the command
                command.Parameters.AddWithValue("@EventName", eventName);
                command.Parameters.AddWithValue("@EventType", eventType);
                command.Parameters.AddWithValue("@EventDetails", eventDetails);
                command.Parameters.AddWithValue("@EventLocation", eventLocation);
                command.Parameters.AddWithValue("@EventStartTime", startDateTime);
                command.Parameters.AddWithValue("@EventEndTime", endDateTime);

                // Execute the command to insert the user data into the database
                command.ExecuteNonQuery();

                result = true; // Successful
            }
            catch (MySqlException)
            {
                result = false; // If unsuccessful
            }
            finally
            {
                dbConn.Close(); // Close the connection to database
            }
            return result; // Return the result
        }
    }
}
