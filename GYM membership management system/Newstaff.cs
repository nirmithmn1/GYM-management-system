using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Newstaff : Form
    {
        public Newstaff()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Newstaff_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            String fname = txtfname.Text;
            String lname = txtlname.Text;

            String gender = "";
            bool isChecked = btnmale.Checked;
            if (isChecked)
            {
                gender = btnmale.Text;
            }
            else
            {
                gender = btnfemale.Text;   
            }
            String dob = datetimepickerDOB.Text;
            Int64 mobile = Int64.Parse(txtmobile.Text);
            String email = txtemail.Text;
            String joindate = Datetimepickerjoindate.Text;
            String state = txtstate.Text;
            String city = txtcity.Text;

            String connstring = "server=localhost;database=gym;uid=root;password=8310582021";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;

            try
            {
                con.Open(); // Open the connection

                // Prepare the SQL command with parameters
                string query = "INSERT INTO NewStaff (Fname, Lname, Gender, DOB, Mobile, Email, JoinDate, Statee, City) " +
                               "VALUES (@Fname, @Lname, @Gender, @DOB, @Mobile, @Email, @JoinDate, @Statee, @City)";

                // Create the MySqlCommand object
                MySqlCommand cmd = new MySqlCommand(query, con);

                // Add the parameters with the corresponding values
                cmd.Parameters.AddWithValue("@Fname", fname);
                cmd.Parameters.AddWithValue("@Lname", lname);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@DOB", dob);
                cmd.Parameters.AddWithValue("@Mobile", mobile);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@JoinDate", joindate);
                cmd.Parameters.AddWithValue("@Statee", state);
                cmd.Parameters.AddWithValue("@City", city);

                // Execute the command
                int rowsAffected = cmd.ExecuteNonQuery();


                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data saved successfully!");
                }
                else
                {
                    MessageBox.Show("Data not saved. Please try again.");
                }
            }
            catch (MySqlException ex)
            {
                // Handle SQL exceptions
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Close the connection
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtfname.Clear();
            txtlname.Clear();
            btnfemale.Checked = false;
            btnmale.Checked = false;
            txtmobile.Clear();
            txtemail.Clear();   
            txtcity.Clear();
            txtstate.Clear();

            datetimepickerDOB.Value = DateTime.Now;
            Datetimepickerjoindate.Value = DateTime.Now;

        }
    }
}
