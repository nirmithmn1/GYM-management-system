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
    public partial class DeleteMember : Form
    {
        public DeleteMember()
        {
            InitializeComponent();
        }
        private void DeleteMember_Load(object sender, EventArgs e)
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
     
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete your data.Confirm?", "Delete data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string connString = "server=localhost;database=gym;uid=root;password=8310582021";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    try
                    {
                        con.Open();

                        string query = "delete from NewMember where Mid =@MID";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@MID", txtsearch.Text);

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
            else
            {
                this.Activate();
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
        }
    }
}
