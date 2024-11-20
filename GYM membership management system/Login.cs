using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtBoxUserName.Text=="admin" && txtPassword.Text=="admin")
            {
                Form1 fm= new Form1();
                fm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect User ID or Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
