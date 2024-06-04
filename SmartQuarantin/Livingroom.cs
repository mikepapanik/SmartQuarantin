using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartQuarantin
{
    public partial class Livingroom : Form
    {
        SoundPlayer soundtrack = new SoundPlayer();
        public Livingroom()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //on
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            button3.Visible = false;
            button5.Visible = true;
            MessageBox.Show("Τα φώτα του Σαλονιού είναι Ανοιχτά.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //off
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            button5.Visible = false;
            button3.Visible = true;
            MessageBox.Show("Τα φώτα του Σαλονιού είναι Κλειστά.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //off tv
            pictureBox4.Visible = false;
            pictureBox3.Visible = true;
            button4.Visible = false;
            button1.Visible = true;
            MessageBox.Show("Η τηλεόραση είναι εκτός λειτουργίας.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //on tv
            pictureBox4.Visible = true;
            pictureBox3.Visible = false;
            button1.Visible = false;
            button4.Visible = true;
            MessageBox.Show("Η τηλεόραση είναι Ενεργοποιημένη");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\tragoudi.wav";
            sp.PlayLooping();

            button2.Visible = false;
            button6.Visible = true;
            MessageBox.Show("Το Ράδιο μόλις άνοιξε.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //sound off
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\tragoudi.wav";
            sp.Stop();
            button6.Visible = false;
            button2.Visible = true;
            MessageBox.Show("Το Ράδιο Έκλεισε!!");
        }

        private void Livingroom_FormClosing(object sender, FormClosingEventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\tragoudi.wav";
            sp.Stop();
            this.Hide();
            Owner.Show();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Πατήστε για να ανάψουν τα φώτα του σαλονιού", button3);

        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Πατήστε για να σβήσουν τα φώτα του σαλονιού", button5);

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip3.Show("Πατήστε για να ανάψετε την τηλεόραση", button1);

        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            toolTip4.Show("Πατήστε για να σβήσετε την τηλεόραση", button4);

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip5.Show("Πατήστε για να ανάψετε το Ραδιόφωνο", button2);

        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            toolTip6.Show("Πατήστε για να σβήσετε το Ραδιόφωνο", button6);

        }
    }
}
