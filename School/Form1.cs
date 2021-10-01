using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace School
{
    public partial class Form1 : Form
    {
        private string Username { get; set; }
        private string Password { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        int lastID = 0;
        XmlDocument xmlauth = new XmlDocument();
        List<User> registeredUsers = new List<User>();

        public void loadRegisteredUsers()
        {
            xmlauth.Load("../../../XMLFile1.xml");
            //studentData.Load("../../../StudentList.xml");
            //teacherData.Load("../../../TeacherList.xml");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            xmlauth.Load("../../../XMLFile1.xml");

            foreach (XmlNode user in xmlauth.SelectSingleNode("Users").ChildNodes)
            {
                try
                {
                    User registeredUser = new User();
                    registeredUser.ID = int.Parse(user.SelectSingleNode("id").InnerText);
                    lastID = registeredUser.ID;
                    registeredUser.Username = user.SelectSingleNode("username").InnerText;
                    registeredUser.Password = user.SelectSingleNode("password").InnerText;
                    registeredUsers.Add(registeredUser);

                }
                catch
                {

                }
            }
            
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Username = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Password = textBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool usernameExists = false;
            for(int i=0; i<registeredUsers.Count; i++)
            {
                if (registeredUsers[i].Username == Username)
                {
                    if (registeredUsers[i].Password == Password) label9.Visible = true;  
                    else label11.Visible = true;
                    usernameExists = true;
                    break;
                }
            }
            if (usernameExists == false) label10.Visible = true; 
            Console.ReadLine();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_register_Click(object sender, EventArgs e)
        {
            bool success = true;
            foreach (User user in registeredUsers)
            {
                if(user.Username==textBox_usernameRegistration.Text)
                {
                    label_invalidUsername.Visible = true;
                    success = false;
                }
            }
            if (textBox_passwordRegistration != textBox_reenterPasswordRegistration)
            {
                label_passwordsDoNotMatch.Visible = true;
                success = false;
            }
            if (textBox_passwordRegistration.Text == string.Empty || textBox_reenterPasswordRegistration.Text == string.Empty)
            {
                label_someFieldsAreEmpty.Visible = true;
                success = false;
            }
            if (success)
            {

                XmlNode newUser = xmlauth.CreateElement("user");

                XmlNode newUserId = xmlauth.CreateElement("id");
                newUserId.InnerText = (lastID + 1).ToString();
                newUser.AppendChild(newUserId);

                XmlNode newUserUsername = xmlauth.CreateElement("username");
                newUserUsername.InnerText = textBox_usernameRegistration.Text;
                newUser.AppendChild(newUserUsername);

                XmlNode newUserPassword = xmlauth.CreateElement("password");
                newUserPassword.InnerText = textBox_passwordRegistration.Text;
                newUser.AppendChild(newUserPassword);

                XmlNode newUserName = xmlauth.CreateElement("name");
                newUserName.InnerText = textBox_passwordRegistration.Text;
                newUser.AppendChild(newUserName);

                XmlNode newUserSurname = xmlauth.CreateElement("surname");
                newUserSurname.InnerText = textBox_passwordRegistration.Text;
                newUser.AppendChild(newUserSurname);

                XmlNode newUserCourse = xmlauth.CreateElement("course");
                newUserCourse.InnerText = comboBox_courseRegistration.Text;
                newUser.AppendChild(newUserCourse);

                XmlNode newUserStatus = xmlauth.CreateElement("status");
                newUserStatus.InnerText = comboBox_statusRegistration.Text;
                newUser.AppendChild(newUserStatus);

                xmlauth.DocumentElement.AppendChild(newUser);
                xmlauth.Save(".. / .. / .. / XMLFile1.xml");

                textBox_passwordRegistration.Text = string.Empty;
                textBox_reenterPasswordRegistration.Text = string.Empty;
                textBox_usernameRegistration.Text = string.Empty;
                textBox_name.Text = string.Empty;
                textBox_surname.Text = string.Empty;
                comboBox_courseRegistration.Text = string.Empty;
                comboBox_statusRegistration.Text = string.Empty;
                loadRegisteredUsers();
            }
            label_registeredSuccessfully.Visible = true;
        }
    }
}
