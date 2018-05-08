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

namespace Bai2
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
            XElement xDoc = XElement.Parse(xmldoc.SelectNodes(@"/feed").ToString());
            var results = xDoc.Descendants("entry").Elements().Select(x => new
            {
                city = x.Name.LocalName,
                houses = string.Join(",", x.Elements().Select(y => y.Name.LocalName).ToArray())
            }).ToList();
            //string[] names3 = xDoc.XPathSelectElement(@"/feed/entry").ChildrenNames();
            //foreach (XmlNode node in xmldoc.SelectNodes(@"/feed/entry"))
            //{
            //    string ss = node.Name;
            //    string s1 = (string)node.SelectSingleNode("entry").InnerXml;
            //    //string summary = node.SelectSingleNode("summary").InnerText;

            //    XDocument x = XDocument.Parse(s1);

            //    XElement link = x.Descendants("link").FirstOrDefault(a => a.Attribute("rel").Value == "next");

            //    String href = string.Empty;
            //    if (link != null)
            //    {
            //        href = link.Attribute("href").Value;
            //        wb.Navigate(href);
            //    }
            //    //Console.WriteLine("{0} \n{1}\n", title, summary);
            //}


        }
        public static string[] ChildrenNames(this XElement xElem)
        {
            return xElem.Elements().Select(e => e.Name.LocalName).ToArray();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
