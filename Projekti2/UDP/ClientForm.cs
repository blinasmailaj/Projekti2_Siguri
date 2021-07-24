using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDP
{
    public partial class ClientForm : Form
    {
        UdpClient client;
        IPEndPoint endPoint;

        public ClientForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Send Message to Server 

            int serverPort = int.Parse(txtServerPort.Text);
            int clientPort = int.Parse(txtClientPort.Text);
            string hostName = txtHostName.Text;

            // Message Formate => ClientPortNumber.hostName.Msg

            UserLogin user = new UserLogin();
           
            string usernameL = user.getUsername().Trim();
            string passwordL = user.getPassword().Trim();

            UserRegistration user1 = new UserRegistration();

            string usernameR = user1.getUsername().Trim();
            string passwordR = user1.getPassword().Trim();
            string firstname = user1.getFirstName().Trim();
            string lastname = user1.getLastName().Trim();
            string birthyear = user1.getBirthYear().Trim();
            string gender = user1.getGender().Trim();

            string logreg = txtMsg.Text.Trim();

            string msg = string.Format("{0}.{1}.{2}.{3}.{4}.{5}.{6}.{7}.{8}.{9}.{10}", clientPort, hostName,logreg, 
                usernameL, passwordL, usernameR, passwordR, firstname, lastname, birthyear, gender);
            byte[] buffer = Encoding.Unicode.GetBytes(msg);

            // Send Msg

            client.Send(buffer, buffer.Length, hostName, serverPort);

            // Receive Response from Server

            endPoint = new IPEndPoint(IPAddress.Any, 0);
            buffer = client.Receive(ref endPoint);
            msg = Encoding.Unicode.GetString(buffer);

            // Display Msg in Log area
            WriteLog(msg);
        }

        private void WriteLog(string msg)
        {
            MethodInvoker invoker = new MethodInvoker(delegate
            {
                txtLog.Text += string.Format(" {0}.{1}", msg, 
            Environment.NewLine);
                txtMsg.Text = string.Empty;
            });

            this.BeginInvoke(invoker);
        }

        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            // Create Client and Reserve Port Number for this Client Only
            int clientPort = int.Parse(txtClientPort.Text);
            client = new UdpClient(clientPort);
            WriteLog("Klienti u lidh me serverin!");
            btnCreateClient.Enabled = txtClientPort.Enabled = txtHostName.Enabled = txtServerPort.Enabled = false;
            btnSend.Enabled = true;
        }

        private void txtLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

