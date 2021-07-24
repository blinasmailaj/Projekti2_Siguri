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
namespace UDP
{
    public partial class UserPage : Form
    {
        public UserPage(string stringValue)
        {
            InitializeComponent();
            userNameLabel.Text = stringValue;
        }

        private void UserPage_Load(object sender, EventArgs e)
        {
            GetXMLData();
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            Fatura fatura = new Fatura(userNameLabel.Text);
            fatura.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetXMLData();
        }
        protected void GetXMLData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("LLoji i Fatures", typeof(string));
            dt.Columns.Add("Numri i Fatures", typeof(string));
            dt.Columns.Add("Viti", typeof(string));
            dt.Columns.Add("Muaji", typeof(string));
            dt.Columns.Add("Vlera", typeof(string));
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("users.xml");
            XmlNodeList nodeList = xmldoc.SelectNodes("/users/user[@id=\"" + userNameLabel.Text + "\"]/shpenzimet/fatura");
            foreach (XmlNode node in nodeList)
            {
                DataRow dtrow = dt.NewRow();
                dtrow["LLoji i Fatures"] = node["llojiFatures"].InnerText;
                dtrow["Numri i Fatures"] = node["nrFatures"].InnerText;
                dtrow["Viti"] = node["viti"].InnerText;
                dtrow["Muaji"] = node["muaji"].InnerText;
                dtrow["Vlera"] = node["vleraNeEuro"].InnerText;

                dt.Rows.Add(dtrow);
            }
            dataGridView.DataSource = dt;


            //gvDetails.DataBind();
        }
    }
}
