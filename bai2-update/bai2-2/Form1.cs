using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace bai2_2
{
    public partial class Form1 : Form
    {
        private class IgnoreBadCert : ICertificatePolicy
        {
            public bool CheckValidationResult(ServicePoint sp, X509Certificate cert, WebRequest request, int err)
            {
                return true;
            }
        }
        WebBrowser wb;
        public Form1()
        {
            InitializeComponent();
            wb = new WebBrowser();
            wb.Width = 800;
            wb.Height = 600;
            panelweb.Controls.Add(wb);
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            ServicePointManager.CertificatePolicy = new IgnoreBadCert();
            NetworkCredential cred = new NetworkCredential();
            cred.UserName = textBoxmail.Text;
            cred.Password = textBoxpass.Text;
            WebRequest webr =
            WebRequest.Create("https://mail.google.com/mail/feed/atom");
            webr.Credentials = cred;
            Stream stream = webr.GetResponse().GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string s = sr.ReadToEnd();
            s = s.Replace("<feed version=\"0.3\" xmlns=\"http://purl.org/atom/ns#\">", @"<feed>");
            StreamWriter sw = new StreamWriter("emaildata.txt");
            sw.Write(s);
            sr.Close();
            sw.Close();
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("emaildata.txt");
            string nr = xmldoc.SelectSingleNode(@"/feed/fullcount").InnerText;
            labelcount.Text = "Số tin nhắn chưa đọc: " + nr;
            //Console.WriteLine("Count: {0}", nr);
            //string[] names3 = xDoc.XPathSelectElement(@"/feed/entry").ChildrenNames();
            foreach (XmlNode node in xmldoc.SelectNodes(@"/feed/entry"))
            {
                string s1 = node.ChildNodes.Item(2).OuterXml;
                string regex = "href=\"(.*)\"";
                Match match = Regex.Match(s1, regex);
                if (match.Success)
                {
                    string link = match.Groups[1].Value;
                    wb.Navigate(link);
                }
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
