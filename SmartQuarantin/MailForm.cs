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
using System.Net.Mail;

namespace SmartQuarantin
{
    public partial class MailForm : Form
    {
        sendmails msg;
        public MailForm()
        {
            InitializeComponent();
        }

        private void MailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendmails msender = new sendmails();

            msender.Sendmail(textBox1, textBox2);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Στείλτε το μήνυμα σας ", button1);
        }
    }
}
