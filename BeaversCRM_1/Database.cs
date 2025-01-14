using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BeaversCRM_1
{
    internal class Database
    {

        public MySqlConnection connection = new MySqlConnection("Server=localhost;Database=tc_crm;User=root;");

        public void initialiseConnection()
        {
            connection = new MySqlConnection("Server=localhost;Database=tc_crm;User=root;");
        }

        public DataSet getDataFromDb(MySqlDataAdapter adapter)
        {
            DataSet dataset = new DataSet();
            try
            {
                using (connection)
                {
                    connection.Open();
                    using (adapter)
                    {
                       adapter.Fill(dataset);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting data from database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataset;
        }

        public void putDataIntoDb(MySqlCommand cmd)
        {
            try
            {
                using (connection)
                {
                    connection.Open();
                    using (cmd)
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error putting data into database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public object getScalarValueFromDb(MySqlCommand cmd)
        {
            object value = null;
            try
            {
                using (connection)
                {
                    connection.Open();
                    using (cmd)
                    {
                        value = cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting scalar value from database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return value;
        }
    }
}