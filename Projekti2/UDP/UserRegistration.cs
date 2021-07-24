using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Xml;
using System.IO;
using System.Text.RegularExpressions;

namespace UDP
{
    public partial class UserRegistration : Form
    {
        public bool registerclick = false;
        public UserRegistration()
        {
            InitializeComponent();
        }
        public string firstname = string.Empty;
        public string lastname = string.Empty;
        public string birthyear = string.Empty;
        public string gender = string.Empty;
        public string username = string.Empty;
        public string password = string.Empty;


        private void UserRegistration_Load(object sender, EventArgs e)
        {

        }
        XmlDocument objXml = new XmlDocument();

        private void btnRegister_Click(object sender, EventArgs e)
        {

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            registerclick = true;
            string Salt = new Random().Next(100000, 1000000).ToString();
            string SaltedPassword = Salt + txtPassword.Text;

            string SaltedHashPassword = CalculateHash(SaltedPassword);
            if (File.Exists("users.xml") == false)
            {
                XmlTextWriter xmlTw = new XmlTextWriter("users.xml", Encoding.UTF8);
                xmlTw.WriteStartElement("users");
                xmlTw.Close();
            }
            objXml.Load("users.xml");
            XmlElement rootNode = objXml.DocumentElement;

            XmlElement userNode = objXml.CreateElement("user");
            XmlElement firstNameNode = objXml.CreateElement("firstName");
            XmlElement lastNameNode = objXml.CreateElement("lastName");
            XmlElement genderNode = objXml.CreateElement("gender");
            XmlElement birthYearNode = objXml.CreateElement("birthYear");
            XmlElement usernameNode = objXml.CreateElement("username");
            XmlElement passwordNode = objXml.CreateElement("password");
            XmlElement saltNode = objXml.CreateElement("salt");

            XmlNodeList nodes = rootNode.SelectNodes("user/username");

            foreach (XmlNode node in nodes)
            {
                if (node.InnerText == txtUsername.Text)
                {
                    MessageBox.Show("User already exists!");
                    return;
                }
            }

            if (txtPassword.Text != txtCPassword.Text)
            {
                MessageBox.Show("Passwords do not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (String.IsNullOrEmpty(txtFirstName.Text) || String.IsNullOrEmpty(txtGender.Text) || String.IsNullOrEmpty(txtLastName.Text) || String.IsNullOrEmpty(txtBirthYear.Text) || String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(txtCPassword.Text))
            {
                MessageBox.Show("All Fields must be filled with information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!hasLowerChar.IsMatch(txtPassword.Text))
            {
                MessageBox.Show("Password should contain At least one lower case letter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (!hasUpperChar.IsMatch(txtPassword.Text))
            {
                MessageBox.Show("Password should contain At least one upper case letter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (!hasMiniMaxChars.IsMatch(txtPassword.Text))
            {
                MessageBox.Show("Password should not be less than or greater than 12 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!hasSymbols.IsMatch(txtPassword.Text))
            {
                MessageBox.Show("Password should contain At least one special case characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            




            firstNameNode.InnerText = txtFirstName.Text;
            lastNameNode.InnerText = txtLastName.Text;
            genderNode.InnerText = txtGender.Text;
            birthYearNode.InnerText = txtBirthYear.Text;
            usernameNode.InnerText = txtUsername.Text;
            passwordNode.InnerText = SaltedHashPassword;
            saltNode.InnerText = Salt;
            userNode.SetAttribute("id", txtUsername.Text);
            userNode.AppendChild(firstNameNode);
            userNode.AppendChild(lastNameNode);
            userNode.AppendChild(birthYearNode);
            userNode.AppendChild(genderNode);
            userNode.AppendChild(usernameNode);
            userNode.AppendChild(passwordNode);
            userNode.AppendChild(saltNode);

            rootNode.AppendChild(userNode);

            objXml.Save("users.xml");
            MessageBox.Show("OK", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);







        }

        private String CalculateHash(string SaltedPassword)
        {
            byte[] byteSaltedPassword = Encoding.UTF8.GetBytes(SaltedPassword);

            SHA1CryptoServiceProvider objHash = new SHA1CryptoServiceProvider();
            byte[] byteSaltedHashPassword = objHash.ComputeHash(byteSaltedPassword);

            return Convert.ToBase64String(byteSaltedHashPassword);
        }

        public string getUsername()
        {
            username = txtUsername.Text.ToString();
            return username;
        }
        public string getPassword()
        {
            password = txtPassword.Text.ToString();
            return username;
        }
        public string getBirthYear()
        {
            birthyear = txtBirthYear.Text.ToString();
            return username;
        }
        public string getGender()
        {
            gender = txtGender.Text.ToString();
            return username;
        }
        public string getFirstName()
        {
            firstname = txtFirstName.Text.ToString();
            return username;
        }
        public string getLastName()
        {
            lastname = txtLastName.Text.ToString();
            return username;
        }

    }
}

