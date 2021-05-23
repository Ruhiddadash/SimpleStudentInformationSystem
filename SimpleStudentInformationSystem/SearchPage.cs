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
    public partial class SearchPage : Form
    {
        List<User> StudentData = new List<User>();
        public SearchPage()
        {
            InitializeComponent();
        }

        public void LoadPage()
        {
            StudentData.Clear();
            List<string> Student = new List<string>();
            DirectoryInfo getUsernames = new DirectoryInfo(@".\StudentList");
            DirectoryInfo[] usernames = getUsernames.GetDirectories();
            foreach (DirectoryInfo username in usernames)
            {
                string path = @".\StudentList\" + username + @"\StudentList.dll";
                StreamReader sr = new StreamReader(path);
                string Name = sr.ReadLine();
                string Surname = sr.ReadLine();
                string Email = sr.ReadLine();
                string Number = sr.ReadLine();
                string Address = sr.ReadLine();
                string Birthday = sr.ReadLine();

                StudentData.Add(new User(Name, Surname, Email, Number, Address, Birthday));
            }

            foreach (User student in StudentData)
            {
                ListViewItem show = new ListViewItem();
                show.Text = student.Name;
                show.SubItems.Add(student.Surname);
                show.SubItems.Add(student.Email);
                show.SubItems.Add(student.Number);
                show.SubItems.Add(student.Address);
                show.SubItems.Add(student.Birthday);

                student_list.Items.Add(show);
            }
        }

        private void SearchPage_Load(object sender, EventArgs e)
        {
            LoadPage();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in student_list.Items)
            {
                if (!item.ToString().ToLower().Contains(textBox_search.Text.ToLower()))
                {
                    student_list.Items.Remove(item);
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Main page = new Main();
            page.Show();
            this.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            textBox_search.Clear();
            student_list.Items.Clear();
            LoadPage();
        }

        private void pictureBox_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
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

        private void pictureBox_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
