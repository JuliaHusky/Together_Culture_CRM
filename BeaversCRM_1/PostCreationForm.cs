using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BeaversCRM_1
{
    public partial class PostCreationForm : Form
    {
        private MySQLDB mySqlDatabase;

        private int digitalConnectionID; // Hardcoded DigitalConnectionID for now

        public PostCreationForm()
        {
            InitializeComponent();
            mySqlDatabase = MySQLDB.Instance(); // Initialize the singleton instance of MySQLDB
            if (!mySqlDatabase.IsConnect())
            {
                MessageBox.Show("Error connecting to the database. Please try again.");
                return;
            }

            FetchDigitalConnectionID(); // Fetch DigitalConnectionID for the logged-in user
            LoadSkillsComboBox(); // Load skills into SkillComboBox
            LoadTagsComboBox(); // Load tags into TagComboBox1
        }

        private void FetchDigitalConnectionID()
        {
            if (Session.CurrentUser == null)
            {
                MessageBox.Show("User is not logged in.");
                return;
            }

            int userID = Session.CurrentUser.UserId; // Access the UserID property of the CurrentUser
            string query = "SELECT DigitalConnectionID FROM digitalConnectionProfile WHERE UserID = @UserID";
            MySqlCommand cmd = new MySqlCommand(query, mySqlDatabase.Connection);
            cmd.Parameters.AddWithValue("@UserID", userID);

            try
            {
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    digitalConnectionID = Convert.ToInt32(result);
                }
                else
                {
                    MessageBox.Show("Error fetching DigitalConnectionID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching DigitalConnectionID: " + ex.Message);
            }
        }


        private void LoadSkillsComboBox()
        {
            string query = "SELECT DISTINCT Skill FROM BulletinBoard";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, mySqlDatabase.Connection);

            // Using the getDataFromDb method to get the dataset
            DataSet dataSet = mySqlDatabase.getDataFromDb(adapter);

            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    SkillComboBox.Items.Add(row["Skill"].ToString());
                }
            }
            else
            {
                MessageBox.Show("No skills found.");
            }
        }

        private void LoadTagsComboBox()
        {
            string query = "SELECT TagID, TagName FROM Tag";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, mySqlDatabase.Connection);

            // Using the getDataFromDb method to get the dataset
            DataSet dataSet = mySqlDatabase.getDataFromDb(adapter);

            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    TagComboBox1.Items.Add(row["TagName"].ToString());
                }
            }
            else
            {
                MessageBox.Show("No tags found.");
            }
        }

        private void PostButton1_Click(object sender, EventArgs e)
        {
            // Validate that the necessary components are not null
            if (SkillComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a skill.");
                return;
            }

            if (TagComboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a tag.");
                return;
            }

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter a description.");
                return;
            }

            // Assign values from form controls
            string skill = SkillComboBox.SelectedItem.ToString();
            string description = textBox1.Text;
            string selectedTagName = TagComboBox1.SelectedItem.ToString();

            // Check if the DigitalConnectionID is set
            if (digitalConnectionID == 0)
            {
                MessageBox.Show("Error: DigitalConnectionID is not set properly.");
                return;
            }

            // Fetch the TagID based on the selected TagName
            string tagQuery = "SELECT TagID FROM Tag WHERE TagName = @TagName";
            MySqlCommand tagCmd = new MySqlCommand(tagQuery, mySqlDatabase.Connection);

            if (mySqlDatabase.Connection == null || mySqlDatabase.Connection.State != ConnectionState.Open)
            {
                MessageBox.Show("Database connection is not open. Please try again.");
                return;
            }

            tagCmd.Parameters.AddWithValue("@TagName", selectedTagName);
            int tagID = 0;

            try
            {
                var result = tagCmd.ExecuteScalar();
                if (result != null)
                {
                    tagID = Convert.ToInt32(result);
                }
                else
                {
                    MessageBox.Show("Error fetching TagID.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching TagID: " + ex.Message);
                return;
            }

            // Insert into BulletinBoard
            string query = "INSERT INTO BulletinBoard (Skill, Description, DatePosted, TagID, DigitalConnectionID) VALUES (@Skill, @Description, @DatePosted, @TagID, @DigitalConnectionID)";
            MySqlCommand cmd = new MySqlCommand(query, mySqlDatabase.Connection);
            cmd.Parameters.AddWithValue("@Skill", skill);
            cmd.Parameters.AddWithValue("@Description", description);
            cmd.Parameters.AddWithValue("@DatePosted", DateTime.Now);
            cmd.Parameters.AddWithValue("@TagID", tagID);
            cmd.Parameters.AddWithValue("@DigitalConnectionID", digitalConnectionID);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Post successfully created!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating post: " + ex.Message);
            }
        }


        private void SkillComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optionally handle any actions when a skill is selected
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Update the description field in the BulletinBoard entity when the text changes
            string description = textBox1.Text;
            if (!string.IsNullOrEmpty(description))
            {
                // Optionally handle the updated description, e.g., store it temporarily or perform validations
            }
        }

        private void TagComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optionally handle any actions when a tag is selected
        }
    }
}
