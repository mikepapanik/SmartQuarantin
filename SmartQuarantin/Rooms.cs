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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        private void Rooms_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bathroom bt = new Bathroom();
            bt.Show(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bedroom be = new Bedroom();
            be.Show(this);
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kitchen ki = new Kitchen();
            ki.Show(this);
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Livingroom liv = new Livingroom();
            liv.Show(this);
            this.Hide();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Πατήστε για να εισέλθετε στο Μπάνιο", button1);

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Πατήστε για να εισέλθετε στο Δωμάτιο", button2);

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            toolTip3.Show("Πατήστε για να εισέλθετε στην Κουζίνα", button3);

        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            toolTip4.Show("Πατήστε για να εισέλθετε στην Κουζίνα", button4);

        }
    }
}
