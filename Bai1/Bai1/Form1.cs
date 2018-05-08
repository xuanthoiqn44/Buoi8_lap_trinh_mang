using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Bai1
{
    public partial class Form1 : Form
    {
        SmtpClient mailclient;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void buttonsend_Click(object sender, EventArgs e)
        {
            try
            {
                mailclient = new SmtpClient("smtp.gmail.com", 587);
                mailclient.EnableSsl = true;
                mailclient.Credentials = new NetworkCredential(textBoxsender.Text, textBoxPass.Text);
                MailMessage message = new MailMessage(textBoxsender.Text, textBoxto.Text);
                message.Subject = textBoxsubject.Text;
                message.Body = textBoxbody.Text;
                mailclient.Send(message);
                MessageBox.Show("Mail sent successfully!");
            }catch
            {
                MessageBox.Show("Không thể gửi được tin");
            }
        }
    }
}
