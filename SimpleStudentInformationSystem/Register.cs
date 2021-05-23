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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text.Trim();
            string password = tb_password.Text.Trim();
            string confirmPassword = tb_confirm.Text.Trim();

            if (username != "" && password != "" && confirmPassword != "")
            {
                if (password == confirmPassword)
                {
                    string path = @"Data\" + username;
                    string dataFilePath = path + @"\data.dll";

                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                        FileStream dataFile = File.Create(dataFilePath);
                        StreamWriter swDataFile = new StreamWriter(dataFile);
                        swDataFile.WriteLine(username);
                        swDataFile.WriteLine(password);

                        Welcome loginPage = new Welcome();
                        loginPage.Show();
                        this.Hide();

                        swDataFile.Close();
                        dataFile.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username already exists!", "Information System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Passwords doesn`t match!", "Information System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (username == "" || password == "" || confirmPassword == "")
            {
                MessageBox.Show("Use valid data", "Information System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cb_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showPass.Checked)
            {
                tb_password.PasswordChar = '\0';
                tb_confirm.PasswordChar = '\0';
            }
            else
            {
                tb_password.PasswordChar = '•';
                tb_confirm.PasswordChar = '•';
            }
        }

        private void btn_go_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome page = new Welcome();
            page.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Are you sure you want to exit?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
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
    }
}
