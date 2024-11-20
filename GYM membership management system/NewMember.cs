using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf;

namespace WindowsFormsApp1
{
    public partial class NewMember : Form
    {
        public NewMember()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NewMember_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            // Collect data from input fields
            string fname = txtFirstName.Text.Trim();
            string lname = txtLastName.Text.Trim();
            string gender = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;
            string dob = dateTimePickerDOB.Text;
            string joindate = dateTimePickerJoinDate.Text;
            string gymtime = comboBoxGYM.Text.Trim();
            string membershiptime = comboBoxMT.Text.Trim();
            string address = txtAddress.Text.Trim();

            // Validate mobile number
            if (!Int64.TryParse(txtMobileno.Text, out long mobile))
            {
                MessageBox.Show("Please enter a valid mobile number.");
                return;
            }

            string email = txtEmail.Text.Trim();

            // MySQL connection
            string connstring = "server=localhost;database=gym;uid=root;password=8310582021";
            using (MySqlConnection con = new MySqlConnection(connstring))
            {
                try
                {
                    con.Open();

                    // Insert query
                    string query = "INSERT INTO newmember (Fname, Lname, Gender, DOB, Mobile, Email, JoinDate, GymTime, Maddress, Membershiptime) " +
                                   "VALUES (@Fname, @Lname, @Gender, @DOB, @Mobile, @Email, @JoinDate, @GymTime, @Maddress, @Membershiptime)";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@Fname", fname);
                        cmd.Parameters.AddWithValue("@Lname", lname);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@DOB", dob);
                        cmd.Parameters.AddWithValue("@Mobile", mobile);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@JoinDate", joindate);
                        cmd.Parameters.AddWithValue("@GymTime", gymtime);
                        cmd.Parameters.AddWithValue("@Maddress", address);
                        cmd.Parameters.AddWithValue("@Membershiptime", membershiptime);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data saved successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to save data. Please try again.");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"MySQL Error: {ex.Number} - {ex.Message}");
                }
            }
        }

    private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtMobileno.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            comboBoxGYM.ResetText();
            comboBoxMT.ResetText();
            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJoinDate.Value = DateTime.Now;

            
        }
    }
}
