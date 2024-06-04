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
    public partial class Kitchen : Form
    {
        public Kitchen()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {//on kitchen
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            button5.Visible = false;
            button2.Visible = true;
            MessageBox.Show("Τα φώτα της Κουζίνας είναι Ανοιχτά.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //off kitchen
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            button2.Visible = false;
            button5.Visible = true;
            MessageBox.Show("Τα φώτα της Κουζίνας είναι Κλειστά.");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //ανοιξε πλυντ
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            button8.Visible = false;
            button1.Visible = true;
            MessageBox.Show("Το Πλυντήριο είναι σε λειτουργία και ο εκτιμώμενος χρόνος ολοκλήρωσης της πλύσης είναι τα 48 λπετά.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //κλεισε πλυντ
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
            button1.Visible = false;
            button8.Visible = true;
            MessageBox.Show("Το Πλυντήριο μόλις τέθηκε εκτός λειτουργίας");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //off
            pictureBox5.Visible = false;
            pictureBox6.Visible = true;
            button3.Visible = false;
            button6.Visible = true;
            textBox1.Visible = true;
            MessageBox.Show("Η Ηλεκτρική κουζίνα είναι Κλειστή");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //on
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please fill in required fields");
            }
            else
            {
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
                button6.Visible = false;
                button3.Visible = true;
                int number;
                if (int.TryParse(textBox1.Text, out number))
                {
                    if (number >= 5 && number <= 150)
                    {

                        MessageBox.Show("Η Ηλεκτρική κουζίνα είναι σε λειτουργία");
                    }
                    else
                    {

                        MessageBox.Show("Ξανά Δώστε τιμή");
                        Kitchen dew = new Kitchen();
                        dew.Show(this);
                        this.Hide();


                    }
                }
                textBox1.Clear();

                textBox1.Visible = false;
            }

        

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.MaxLength = 3;
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //off coffee
            pictureBox8.Visible = false;
            pictureBox7.Visible = true;
            button4.Visible = false;
            button7.Visible = true;
           
            MessageBox.Show("Ο βραστήρας μόλις απενεργοποιήθηκε");
        }

        private void button7_Click(object sender, EventArgs e)
        {//on coffee
            pictureBox8.Visible = true;
            pictureBox7.Visible = false;
            button7.Visible = false;
            button4.Visible = true;
            MessageBox.Show("Ο βραστήρας μόλις ενεργοποιήθηκε και θα σταματήσει αυτόματα σε 10΄ λεπτά!!");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Πατήστε για να σβήσετε τα φώτα της κουζίνας", button2);

        }

        private void Kitchen_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Πατήστε για να ανάψετε τα φώτα της κουζίνας", button5);

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip3.Show("Πατήστε για να σβήσετε το πλυντήριο ρούχων", button1);

        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            toolTip4.Show("Πατήστε για να ανάψετε το πλυντήριο ρούχων", button8);
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            toolTip5.Show("Πατήστε για να σβήσετε τον φούρνο", button3);
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            toolTip6.Show("Πατήστε για να ανάψετε τον φούρνο", button6);

        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip7.Show("Συμπληρώστε το χρόνο ψησίματος από 5΄ έως 150΄ λεπτά", textBox1);

        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            toolTip8.Show("Πατήστε για να ενεργοποιηθεί ο βραστήρας", button7);
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            toolTip9.Show("Πατήστε για να απενεργοποιηθεί ο βραστήρας", button4);

        }
    }
}
