using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleStudentInformationSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void pb_addStudent_Click(object sender, EventArgs e)
        {
            AddStudent page = new AddStudent();
            page.Show();
            this.Close();
        }

        private void pb_information_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A student information system, student management system, school administration software or student administration system is a management information system for education establishments used to manage student data.", "Information System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pb_logOut_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            result =  MessageBox.Show("Are you sure you want to log out?","Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Welcome page = new Welcome();
                page.Show();
                this.Close();
            }
            
        }

        private void pictureBox_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox_maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }


        private void pb_search_Click(object sender, EventArgs e)
        {
            SearchPage page = new SearchPage();
            page.Show();
            this.Close();
        }
    }
}
