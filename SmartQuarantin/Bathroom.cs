using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartQuarantin
{
    public partial class Bathroom : Form
    {
        public Bathroom()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {//ON
            pictureBox1.Visible = true;
            pictureBox3.Visible = false;
            button2.Visible = false;
            button1.Visible = true;
            MessageBox.Show("Τα φώτα του Μπάνιου είναι Ανοιχτά");
        }

        private void button1_Click(object sender, EventArgs e)
        {//OFF
            pictureBox1.Visible = false;
            pictureBox3.Visible = true;
            button1.Visible = false;
            button2.Visible = true;
            MessageBox.Show("Τα φώτα του Μπάνιου είναι Κλειστά");
        }

        private void button4_Click(object sender, EventArgs e)
        {//OFF
            pictureBox4.Visible = false;
            pictureBox2.Visible = true;
            button4.Visible = false;
            button3.Visible = true;
            MessageBox.Show("Ο Θερμοσιφωνας είναι Κλειστός");
        }

        private void button3_Click(object sender, EventArgs e)
        {//ON
            pictureBox4.Visible = true;
            pictureBox2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            MessageBox.Show("Ο Θερμοσιφωνας είναι Ανοιχτός, το νερό θα είναι έτοιμο σε 10΄ Λεπτά!!");
        }

       

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Πατήστε για να σβήσετε τα φώτα).", button1);

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Πατήστε για να ανάψετε τα φώτα).", button2);
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            toolTip3.Show("Πατήστε για να σβήσετε τον θερμοσίφωνα).", button4);

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            toolTip4.Show("Πατήστε για να ανάψετε τον θερμοσίφωνα).", button3);
        }

        private void Bathroom_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }
    }
}
