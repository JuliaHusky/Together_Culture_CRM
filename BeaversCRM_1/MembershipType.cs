using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BeaversCRM_1
{
    public class MembershipType
    {
        public int MembershipTypeID { get; set; }
        public string name { get; set; }
        public List<string> benefits { get; set; }
        public float price { get; set; }

        public static DataRowCollection getMembershipTypesPopularity()
        {
            try
            {
                Database db = new Database();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(Constants.GET_MEMBERSHIP_AMOUNT_SUMMARY, db.connection))
                {
                    return db.getDataFromDb(adapter).Tables[0].Rows;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while getting amount of each membership type: " + ex.Message);
            }
            return null;
        }
    }
}