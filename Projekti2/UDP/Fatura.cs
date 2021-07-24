using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace UDP
{
    public partial class Fatura : Form
    {
        public Fatura(string username)
        {
            InitializeComponent();
            userNameLabel.Text = username;
        }
        XmlDocument xml = new XmlDocument();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            xml.Load("users.xml");
            XmlNode userNode = xml.SelectSingleNode("users/user[@id='" + userNameLabel.Text + "']");

            XmlElement shpenzimetNode = xml.CreateElement("shpenzimet");
            XmlElement faturaNode = xml.CreateElement("fatura");
            XmlElement llojiFaturesNode = xml.CreateElement("llojiFatures");
            XmlElement nrFaturesNode = xml.CreateElement("nrFatures");
            XmlElement vitiNode = xml.CreateElement("viti");
            XmlElement muajiNode = xml.CreateElement("muaji");
            XmlElement vleraNode = xml.CreateElement("vleraNeEuro");

            if (String.IsNullOrEmpty(txtLlojiFatures.Text) || String.IsNullOrEmpty(txtNrFatures.Text) || String.IsNullOrEmpty(txtViti.Text) || String.IsNullOrEmpty(txtMuaji.Text) || String.IsNullOrEmpty(txtShuma.Text))
            {
                MessageBox.Show("All Fields must be filled with information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            llojiFaturesNode.InnerText = txtLlojiFatures.Text;
            nrFaturesNode.InnerText = txtNrFatures.Text;
            vitiNode.InnerText = txtViti.Text;
            muajiNode.InnerText = txtMuaji.Text;
            vleraNode.InnerText = txtShuma.Text;

            faturaNode.AppendChild(llojiFaturesNode);
            faturaNode.AppendChild(nrFaturesNode);
            faturaNode.AppendChild(vitiNode);
            faturaNode.AppendChild(muajiNode);
            faturaNode.AppendChild(vleraNode);
            shpenzimetNode.AppendChild(faturaNode);

            userNode.AppendChild(shpenzimetNode);

            xml.Save("users.xml");

        }
    }
    
}
