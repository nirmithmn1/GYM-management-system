using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String EquipName = txtEquipName.Text;
            String Description = txtDescription.Text;
            String MUsed = txtMusclesUsed.Text;
            String DDate = dateTimePickerDeliveryDate.Text;
            Int64 cost = Int64.Parse(txtCost.Text);

            String connstring = "server=localhost;database=gym;uid=root;password=8310582021";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            try
            {
                con.Open(); 
                string query = "INSERT INTO Equipment (EquipName, EDescription, MUsed, DDate, Cost) " +
                "VALUES (@EquipName, @EDescription, @MUsed, @DDate, @Cost)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@EquipName", EquipName);
                cmd.Parameters.AddWithValue("@EDescription", Description);
                cmd.Parameters.AddWithValue("@MUsed", MUsed);
                cmd.Parameters.AddWithValue("@DDate", DDate);
                cmd.Parameters.AddWithValue("@Cost", cost);
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEquipName.Clear();
            txtDescription.Clear();
            txtCost.Clear();
            txtMusclesUsed.Clear();
            dateTimePickerDeliveryDate.Value = DateTime.Now;
        }

        private void btnViewEq_Click(object sender, EventArgs e)
        {
            ViewEquipment ve= new ViewEquipment();
            ve.Show();

        }

        private void Equipment_Load(object sender, EventArgs e)
        {

        }
    }
}
