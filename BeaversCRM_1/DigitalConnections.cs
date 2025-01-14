using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BeaversCRM_1
{
    public partial class DigitalConnections : Form
    {
        private MySQLDB mySqlDatabase; // Declare an instance of the Database class

        public DigitalConnections()
        {
            InitializeComponent();
            mySqlDatabase = MySQLDB.Instance(); // Initialize the singleton instance of MySQLDB
            if (!mySqlDatabase.IsConnect())
            {
                MessageBox.Show("Error connecting to the database. Please try again.");
                return;
            }
            LoadBulletinBoardData(); // Load data into DataGridView
            LoadComboBoxTags(); // Load tags into ComboBox
        }

        private void LoadBulletinBoardData()
        {
            string query = "SELECT PostID, DigitalConnectionID, Skill, DatePosted, Description FROM BulletinBoard";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, mySqlDatabase.Connection);

            // Using the getDataFromDb method to get the dataset
            DataSet dataSet = mySqlDatabase.getDataFromDb(adapter);

            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            else
            {
                MessageBox.Show("No data found.");
            }
        }

        private void LoadComboBoxTags()
        {
            string query = "SELECT TagName FROM Tag";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, mySqlDatabase.Connection);

            // Using the getDataFromDb method to get the dataset
            DataSet dataSet = mySqlDatabase.getDataFromDb(adapter);

            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    comboBox1.Items.Add(row["TagName"].ToString());
                }

                comboBox1.Items.Insert(0, "All"); // Add an "All" option for no filter
                comboBox1.SelectedIndex = 0; // Default selection
            }
            else
            {
                MessageBox.Show("No tags found.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTag = comboBox1.SelectedItem.ToString();
            string query;

            if (selectedTag == "All")
            {
                // Fetch all records if "All" is selected
                query = "SELECT PostID, DigitalConnectionID, Skill, DatePosted, Description, TagID FROM BulletinBoard";
            }
            else
            {
                // Updated query to directly use the TagID from the BulletinBoard table
                query = @"SELECT b.PostID, b.DigitalConnectionID, b.Skill, b.DatePosted, b.Description
                  FROM BulletinBoard b
                  JOIN Tag tg ON b.TagID = tg.TagID
                  WHERE tg.TagName = @TagName";
            }

            MySqlDataAdapter adapter;

            if (selectedTag == "All")
            {
                adapter = new MySqlDataAdapter(query, mySqlDatabase.Connection);
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand(query, mySqlDatabase.Connection);
                cmd.Parameters.AddWithValue("@TagName", selectedTag);
                adapter = new MySqlDataAdapter(cmd);
            }

            // Using the getDataFromDb method to get the dataset
            DataSet dataSet = mySqlDatabase.getDataFromDb(adapter);

            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            else
            {
                MessageBox.Show("No data found for the selected tag.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Define behavior when clicking on a cell in DataGridView if necessary
        }

        private void postButton1_Click(object sender, EventArgs e)
        {

            // Open the PostCreationForm
            PostCreationForm postCreationForm = new PostCreationForm();
            postCreationForm.Show();

        }
    }
}
