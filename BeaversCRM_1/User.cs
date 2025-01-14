using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BeaversCRM_1
{
    // The User class contains properties related to the user
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Intention { get; set; }
        public string MembershipType {  get; set; }
        public string PhoneNumber { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsVerified { get; set; }
        public bool MarketEmails { get; set; }
        public List<string> Tags { get; set; }


        // Method to clear the instance of the user
        public void Clear()
        {
            UserId = 0;
            FirstName = null;
            LastName = null;
            Email = null;
            Password = null;
            Gender = null;
            Intention = null;
            MembershipType = null;
            PhoneNumber = null;
            IsAdmin = false;
            IsVerified = false;
            MarketEmails = false;
            Tags = new List<string>();
        }

        // Method to insert user's tag into database
        public void insertTag()
        {
            try
            {
                // Creating instance of a database, setting and passing the command to insert user's tag
                Database db = new Database();
                using (MySqlCommand cmd = new MySqlCommand(Constants.INSERT_USER_TAG, db.connection))
                {
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@tagName", Tags[0]);
                    db.putDataIntoDb(cmd);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting user's tag into database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }

    // The Session class holds the user information from
    // the current log in session
    public static class Session
    {
        // This holds the current logged in user object 
        // and can be accessed globally
        public static bool isLoggedIn = false;
        public static User CurrentUser { get; set; }
    }



}