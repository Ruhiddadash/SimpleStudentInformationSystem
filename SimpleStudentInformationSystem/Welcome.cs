using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleStudentInformationSystem
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text.Trim();
            string password = tb_password.Text.Trim();
            string path = @"Data\" + username;
            string dataFilePath = path + @"\data.dll";
            if (username != "" && password != "")
            {
                if (Directory.Exists(path))
                {
                    StreamReader srForPassword = new StreamReader(dataFilePath);
                    srForPassword.ReadLine();
                    string passwordSaved = srForPassword.ReadLine().Trim();
                    srForPassword.Close();
                    if(passwordSaved == password)
                    {
                        Main page = new Main();
                        page.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Wrong Username!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Use valid data!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cb_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showPass.Checked)
            {
                tb_password.PasswordChar = '\0';
            }
            else
            {
                tb_password.PasswordChar = '•';
            }
        }

        private void btn_go_regester_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register page = new Register();
            page.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Are you sure you want to exit?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
            
        }
        private void pictureBox_cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void pictureBox_maximize_Click_1(object sender, EventArgs e)
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

        private void pictureBox_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
