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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean b = true; 
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                menuStrip2.Dock = DockStyle.Left;
                b = false;
                toolStripMenuItem1.Image = Image.FromFile(@"E:\GYM\download (1).png");
            }
            else
            {
                menuStrip2.Dock = DockStyle.Top;
                b = true;
                toolStripMenuItem1.Image = Image.FromFile(@"E:\GYM\download (2).png");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripMenuItem1.Image = Image.FromFile(@"E:\GYM\download (2).png");
        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMember nm = new NewMember();
            nm.Show();
        }

        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Newstaff ns = new Newstaff();
            ns.Show();
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipment eq = new Equipment();
            eq.Show();       
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchMember sm = new SearchMember();
            sm.Show();
        }
        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteMember dm = new DeleteMember();
            dm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("This will close Your application, Confirm?","Close",MessageBoxButtons.YesNo,MessageBoxIcon.Error)==DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("welcome Back", "welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Log Out !! Confirm ?","LOG OUT",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                this.Close();
                Login lg=new Login();
                lg.Show();
            }
        }

        private void reviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Review rm = new Review();
            rm.Show();
        }
    }
}
