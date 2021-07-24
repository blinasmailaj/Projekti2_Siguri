using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace UDP
{
    public partial class ServerForm : Form
    {
        UdpClient server;
        IPEndPoint endPoint;

        public ServerForm()
        {
            InitializeComponent();
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            server = new UdpClient(int.Parse(txtServerPort.Text));
            endPoint = new IPEndPoint(IPAddress.Any, 0);

            // Start Server in Seprated Thread to Avoid User Inteface Blocking
            Thread thr = new Thread(new ThreadStart(ServerStart));
            thr.Start();
            btnStartServer.Enabled = false;
            btnNewClient.Enabled = true;

            // Write Server Started
            WriteLog("Status : Server Started Successfully...");

        }

        private void ServerStart()
        {
            // Keep Server Listening

            while (true)
            {
                byte[] buffer = server.Receive(ref endPoint);

                string[] msg = Encoding.Unicode.GetString(buffer).Split('.');


                int clientPort = int.Parse(msg[0]);
                string clientHostName = msg[1];


                string request = msg[2].ToLower().Trim();
                string usernameL = msg[3].ToLower().Trim();
                string passwordL = msg[4].ToLower().Trim();
                string usernameR = msg[5].ToLower().Trim();
                string passwordR = msg[6].ToLower().Trim();
                string firstname = msg[7].ToLower().Trim();
                string lastname = msg[8].ToLower().Trim();
                string birthyear = msg[9].ToLower().Trim();
                string gender = msg[10].ToLower().Trim();

                if (request == "login")
                {
                    WriteLog(string.Format("Klienti ne portin {0} kerkon sherbimin : {1}", clientPort, request));
                    UserLogin userLogin = new UserLogin();
                    userLogin.ShowDialog();
                    if(userLogin.loginclicked == true)
                    {
                        if(string.IsNullOrEmpty(usernameL) || string.IsNullOrEmpty(passwordL))
                        {
                            string response = string.Format("Te dhenat nuk duhet te jene te zbrazeta!");
                            buffer = Encoding.Unicode.GetBytes(response);
                            server.Send(buffer, buffer.Length, clientHostName, clientPort);
                        }
                    }

                }
                else if (request == "register")
                {
                    WriteLog(string.Format("Klienti ne portin {0} kerkon sherbimin : {1}", clientPort, request));
                    UserRegistration userRegistration = new UserRegistration();
                    userRegistration.ShowDialog();
                    if(userRegistration.registerclick == true)
                    {
                        if(string.IsNullOrEmpty(usernameR) || string.IsNullOrEmpty(passwordR) || string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(birthyear) || string.IsNullOrEmpty(gender))
                        {
                            //MessageBox.Show("Te dhenat nuk duhet te jene te zbrazeta", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            string response = string.Format("Te dhenat nuk duhet te jene te zbrazeta!");
                            buffer = Encoding.Unicode.GetBytes(response);
                            server.Send(buffer, buffer.Length, clientHostName, clientPort);
                        }
                    }
                }
                else if (string.IsNullOrEmpty(request))
                {
                    WriteLog(string.Format("Kerkesa ne portin {0} eshte e zbrazet!",clientPort));
                    string response = string.Format("Kerkesa eshte e zbrazet...");
                    buffer = Encoding.Unicode.GetBytes(response);
                    server.Send(buffer, buffer.Length, clientHostName, clientPort);
                }
                else
                {
                    WriteLog(string.Format("Kerkesa nga klienti {0} nuk eshte valide!", clientPort));
                    string response = string.Format("Kerkesa nga klienti {0} nuk eshte valide!", clientPort);
                    buffer = Encoding.Unicode.GetBytes(response);
                    server.Send(buffer, buffer.Length, clientHostName, clientPort);

                }
            }
        }
    
        private void WriteLog(string msg)
        {
            MethodInvoker invoker = new MethodInvoker(delegate
            {
                txtLog.Text += string.Format("{0}.{1}", msg, Environment.NewLine);
            });

            this.BeginInvoke(invoker);
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            ClientForm client = new ClientForm();
            client.Show();

        }

        private void ServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            server.Close();
            Application.Exit();
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private String CalculateHash(string SaltedPassword)
        {
            byte[] byteSaltedPassword = Encoding.UTF8.GetBytes(SaltedPassword);

            SHA1CryptoServiceProvider objHash = new SHA1CryptoServiceProvider();
            byte[] byteSaltedHashPassword = objHash.ComputeHash(byteSaltedPassword);

            return Convert.ToBase64String(byteSaltedHashPassword);
        }
    }
}
