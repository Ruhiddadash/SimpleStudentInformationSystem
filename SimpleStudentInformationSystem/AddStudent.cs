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
    public partial class AddStudent : Form
    {
        List<User> StudentData = new List<User>();
        public AddStudent()
        {
            InitializeComponent();
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            Main page = new Main();
            page.Show();
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
           
            string name = tb_name.Text.Trim();
            string surname = tb_surName.Text.Trim();
            string mail = tb_email.Text.Trim();
            string addresss = tb_address.Text.Trim();
            string number = tb_number.Text.Trim();
            string birthday = mtb_birthday.Text.Trim();

            if (tb_name.Text == "")
            {
                MessageBox.Show("Please enter your name!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (tb_surName.Text == "" || tb_surName.Text == null)
            {
                MessageBox.Show("Please enter your Surname!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb_address.Text == "" || tb_address.Text == null)
            {
                MessageBox.Show("Please enter your address!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb_number.Text == "" || tb_number.Text == null)
            {
                MessageBox.Show("Please enter your valid Phone Number!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb_email.Text == "" || tb_email.Text == null)
            {
                MessageBox.Show("Please enter your valid Email!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string path = @"StudentList\" + name;
                string dataFilePath = path + @"\studentList.dll";

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    FileStream studentFile = File.Create(dataFilePath);
                    StreamWriter swStudentFile = new StreamWriter(studentFile);

                    swStudentFile.WriteLine(name);
                    swStudentFile.WriteLine(surname);
                    swStudentFile.WriteLine(mail);
                    swStudentFile.WriteLine(addresss);
                    swStudentFile.WriteLine(number);
                    swStudentFile.WriteLine(birthday);

                    string[] row = { tb_name.Text, tb_surName.Text, tb_email.Text, tb_number.Text, tb_address.Text, mtb_birthday.Text };  
                    var listItem = new ListViewItem(row);

                    student_list.Items.Add(listItem);
                    tb_name.Clear();
                    tb_surName.Clear();
                    tb_email.Clear();
                    tb_number.Clear();
                    tb_address.Clear();
                    mtb_birthday.Clear();

                    MessageBox.Show("Information added in the system!", "Information System", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    swStudentFile.Close();
                    studentFile.Close();
                }
            }
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

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

            foreach(User student in StudentData)
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
