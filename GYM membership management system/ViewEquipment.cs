using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class ViewEquipment : Form
    {
        public ViewEquipment()
        {
            InitializeComponent();
        }

        private void ViewEquipment_Load(object sender, EventArgs e)
        {
            // MySQL connection setup
            string connString = "server=localhost;database=gym;uid=root;password=8310582021";
            using (MySqlConnection con = new MySqlConnection(connString))
            {
                try
                {
                    con.Open();

                    // Load equipment data into DataGridView
                    string query = "SELECT * FROM Equipment";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);

                    // Set the data source for the DataGridView
                    dataGridView1.DataSource = DS.Tables[0];

                    // Query to calculate the total number of equipment items
                    string sumQuery = "SELECT COUNT(EID) FROM Equipment";
                    MySqlCommand sumCmd = new MySqlCommand(sumQuery, con);

                    // Execute the sum query and retrieve the result
                    object result = sumCmd.ExecuteScalar();
                    int totalQuantity = result != DBNull.Value ? Convert.ToInt32(result) : 0;

                    // Display the total quantity in a label
                    lblTotalQuantity.Text = "Total Equipment Quantity: " + totalQuantity.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click events if needed
        }

        private void lblTotalQuantity_Click(object sender, EventArgs e)
        {

        }
    }
}
