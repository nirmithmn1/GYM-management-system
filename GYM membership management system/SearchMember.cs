using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq; // Install via NuGet: Install-Package Newtonsoft.Json

namespace WindowsFormsApp1
{
    public partial class SearchMember : Form
    {
        public SearchMember()
        {
            InitializeComponent();
        }

        private void SearchMember_Load(object sender, EventArgs e)
        {
            string connString = "server=localhost;database=gym;uid=root;password=8310582021";
            using (MySqlConnection con = new MySqlConnection(connString))
            {
                try
                {
                    con.Open();

                    string query = "SELECT * FROM NewMember";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);

                    dataGridView1.DataSource = DS.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string connString = "server=localhost;database=gym;uid=root;password=8310582021";
            using (MySqlConnection con = new MySqlConnection(connString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT GetMemberByID(@MID)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@MID", txtSearch.Text);
                    string jsonResult = cmd.ExecuteScalar()?.ToString();
                    if (string.IsNullOrEmpty(jsonResult))
                    {
                        MessageBox.Show("Invalid MID. MID not found.");
                        dataGridView1.DataSource = null; // Clear the DataGridView
                    }
                    else
                    {
                        var jsonObject = JObject.Parse(jsonResult);
                        DataTable dataTable = new DataTable();
                        dataTable.Columns.Add("MID");
                        dataTable.Columns.Add("Fname");
                        dataTable.Columns.Add("Lname");
                        dataTable.Columns.Add("Gender");
                        dataTable.Columns.Add("DOB");
                        dataTable.Columns.Add("Mobile");
                        dataTable.Columns.Add("Email");
                        dataTable.Columns.Add("JoinDate");
                        dataTable.Columns.Add("GymTime");
                        dataTable.Columns.Add("Maddress");
                        dataTable.Columns.Add("Membershiptime");

                        dataTable.Rows.Add(
                            jsonObject["MID"],
                            jsonObject["Fname"],
                            jsonObject["Lname"],
                            jsonObject["Gender"],
                            jsonObject["DOB"],
                            jsonObject["Mobile"],
                            jsonObject["Email"],
                            jsonObject["JoinDate"],
                            jsonObject["GymTime"],
                            jsonObject["Maddress"],
                            jsonObject["Membershiptime"]
                        );

                        dataGridView1.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
