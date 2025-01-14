using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;

namespace BeaversCRM_1
{
    public class MembershipRequest
    {
        public User user { get; set; }
        public MembershipType membership { get; set; }
        public string paymentStatus { get; set; }
        public string approvalStatus { get; set; }

        public static DataRowCollection getRequestsFromDb(string searchFilter, string dateFilter)
        {
            try
            {
                Database db = new Database();
                using (MySqlDataAdapter adapter = searchFilter == null ? new MySqlDataAdapter(Constants.GET_MEMBERSHIP_REQUESTS + " " + dateFilter, db.connection) : new MySqlDataAdapter(Constants.GET_MEMBERSHIP_REQUESTS + " " + searchFilter + " " + dateFilter, db.connection))
                {
                    return db.getDataFromDb(adapter).Tables[0].Rows;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting membership requests from database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public void accept()
        {
            try
            {
                Database db = new Database();
                using (MySqlCommand cmd = new MySqlCommand(Constants.APPROVE_REQUEST, db.connection))
                {
                    cmd.Parameters.AddWithValue("@userid", user.UserId);
                    db.putDataIntoDb(cmd);
                }
                
                db.initialiseConnection();
                using (MySqlCommand cmd = new MySqlCommand(Constants.INSERT_MEMBERSHIP, db.connection))
                {
                    cmd.Parameters.AddWithValue("@userid", user.UserId);
                    cmd.Parameters.AddWithValue("@typeid", membership.MembershipTypeID);
                    cmd.Parameters.AddWithValue("@expirydate", DateTime.Now.AddDays(30));
                    cmd.Parameters.AddWithValue("@joindate", DateTime.Now);
                    db.putDataIntoDb(cmd);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error accepting membership request: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void decline()
        {
            try
            {
                Database db = new Database();
                using (MySqlCommand cmd = new MySqlCommand(Constants.DECLINE_REQUEST, db.connection))
                {
                    cmd.Parameters.AddWithValue("@userid", user.UserId);
                    db.putDataIntoDb(cmd);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error declining membership request: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void insertIntoDb()
        {
            try
            {
                Database db = new Database();
                using (MySqlCommand cmd = new MySqlCommand(Constants.INSERT_MEMBERSHIP_REQUEST, db.connection))
                {
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@typename", membership.name);
                    cmd.Parameters.AddWithValue("@paymentstatus", paymentStatus);
                    cmd.Parameters.AddWithValue("@approvalstatus", approvalStatus);
                    cmd.Parameters.AddWithValue("@creationdate", DateTime.Now);
                    db.putDataIntoDb(cmd);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting membership request into database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}