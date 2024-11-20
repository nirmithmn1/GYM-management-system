using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Review : Form
    {
        public Review()
        {
            InitializeComponent();
        }

        private string connectionString = "server=localhost;database=gym;uid=root;password=8310582021";

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtid.Text) || string.IsNullOrWhiteSpace(txtfeedback.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (!int.TryParse(txtid.Text, out int MID))
            {
                MessageBox.Show("Please enter a valid MID.");
                return;
            }
            string feedback = txtfeedback.Text;
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Validate if MID exists in the newmember table
                    string checkMIDQuery = "SELECT COUNT(*) FROM newmember WHERE MID = @MID";
                    MySqlCommand checkMIDCmd = new MySqlCommand(checkMIDQuery, con);
                    checkMIDCmd.Parameters.AddWithValue("@MID", MID);
                    int count = Convert.ToInt32(checkMIDCmd.ExecuteScalar());
                    if (count == 0)
                    {
                        MessageBox.Show("Invalid MID: MID not found.");
                        return;
                    }
                    string insertQuery = "INSERT INTO review (MID, feedback) VALUES (@MID, @feedback)";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, con);
                    insertCmd.Parameters.AddWithValue("@MID", MID);
                    insertCmd.Parameters.AddWithValue("@feedback", feedback);
                    int rowsAffected = insertCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Review saved successfully!");
                        ClearInputFields();
                        Review_Load_1(sender , e); // Refresh the data grid
                    }
                    else
                    {
                        MessageBox.Show("Failed to save review. Please try again.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


        private void ClearInputFields()
        {
            txtid.Text = string.Empty;
            txtfeedback.Text = string.Empty;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Add functionality if needed, such as editing or deleting rows
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Optional: Handle label click if necessary
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Review_Load_1(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Load equipment data into DataGridView
                    string query = @" SELECT 
                                        review.reviewID,
                                        review.MID,
                                        (SELECT CONCAT(Fname, ' ', Lname) 
                                         FROM newmember 
                                         WHERE newmember.MID = review.MID) AS FullName,
                                        (SELECT Mobile 
                                         FROM newmember 
                                         WHERE newmember.MID = review.MID) AS Mobile,
                                        (SELECT Email 
                                         FROM newmember 
                                         WHERE newmember.MID = review.MID) AS Email,
                                        review.feedback
                                    FROM 
                                        review
                                    ORDER BY 
                                        review.reviewID ASC";


                    MySqlCommand cmd = new MySqlCommand(query, con);

                    MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);

                    // Set the data source for the DataGridView
                    dataGridView1.DataSource = DS.Tables[0];

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            
          
        }
    }
}
