using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Security.Cryptography;
using System.Net;


namespace UDP
{
    public partial class UserLogin : Form
    {
        public event EventHandler ButtonFirstFormClicked;
        public UserLogin()
        {
            InitializeComponent();
        }
        public string username = string.Empty;
        public string password = string.Empty;
        public bool loginclicked = false;

        private void registerHereLabel_Click(object sender, EventArgs e)
        {
            UserRegistration userRegistration = new UserRegistration();
            userRegistration.ShowDialog();
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            loginclicked = true;
            XmlDocument doc = new XmlDocument();

            doc.Load("users.xml");

            foreach (XmlNode node in doc.SelectNodes("/users/user"))
            {
                String Username = node.SelectSingleNode("username").InnerText;
                String Password = node.SelectSingleNode("password").InnerText;

                if (String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("All Fields must be filled with information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string Salt = node.SelectSingleNode("salt").InnerText;

                string SaltedPassword = Salt + txtPassword.Text;
                string SaltedHashPassword = CalculateHash(SaltedPassword);

                if (Username == txtUsername.Text && Password == SaltedHashPassword)
                {
                    MessageBox.Show("OK", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    UserPage userPage = new UserPage(txtUsername.Text);
                    userPage.ShowDialog();
                }


                //MessageBox.Show("ERROR" , "Wrong",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }
        private String CalculateHash(string SaltedPassword)
        {
            byte[] byteSaltedPassword = Encoding.UTF8.GetBytes(SaltedPassword);

            SHA1CryptoServiceProvider objHash = new SHA1CryptoServiceProvider();
            byte[] byteSaltedHashPassword = objHash.ComputeHash(byteSaltedPassword);

            return Convert.ToBase64String(byteSaltedHashPassword);
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            
        }
        public string getUsername()
        {
            username = txtUsername.Text.ToString();
            return username;
        }
        public string getPassword()
        {
            username = txtUsername.Text.ToString();
            return username;
        }

        internal void btnLogin_Click()
        {
            throw new NotImplementedException();
        }
    }
}
