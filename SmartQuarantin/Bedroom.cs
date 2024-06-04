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
    public partial class Bedroom : Form
    {
        public Bedroom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //off
            pictureBox1.Visible = false;
            pictureBox3.Visible = true;
            button1.Visible = false;
            button3.Visible = true;
            MessageBox.Show("Τα φώτα του δωματίου είναι Κλειστά.");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //on
            pictureBox1.Visible = true;
            pictureBox3.Visible = false;
            button3.Visible = false;
            button1.Visible = true;
            MessageBox.Show("Τα φώτα του δωματίου είναι Ανοιχτά.");
        }

        private void button2_Click(object sender, EventArgs e)
        {//on
           

            if (textBox1.Text == "")
            {
                MessageBox.Show("Please fill in required fields");
            }

            else
            {
                pictureBox2.Visible = true;
                pictureBox4.Visible = false;
                button2.Visible = false;
                button4.Visible = true;
                int number;
                if (int.TryParse(textBox1.Text, out number))
                {
                    if (number >= 13 && number <= 38)
                    {
                        MessageBox.Show("Το Air Condition μόλις Ενεργοποιήθηκε!!");
                    }
                    else
                    {

                        MessageBox.Show("Ξανά Δώστε τιμή");
                        Bedroom dw = new Bedroom();
                        dw.Show(this);
                        this.Hide();


                    }
                }
                textBox1.Clear();

                textBox1.Visible = false;
            }
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //off
            pictureBox2.Visible = false;
            pictureBox4.Visible = true;
            button4.Visible = false;
            button2.Visible = true;
            textBox1.Visible = true;
            MessageBox.Show("Το Air Condition είναι Κλειστό.");

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.MaxLength = 2;
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;


            }
          
            
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Πατήστε για σβήσετε τα φώτα του δωματίου", button1);

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Πατήστε για ανάψετε τα φώτα του δωματίου", button3);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip3.Show("Πατήστε για να ανάψετε το Air Condition.", button2);
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            toolTip4.Show("Πατήστε για σβήσετε το Air Condition", button4);
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip5.Show("Πληκτρολογήστε την θερμοκρασία που επιθυμείτε να δουλεύει το Air Condition. Επιτρεπτές θερμοκρασίες είναι από 13 βαθμούς έως 38 βαθμούς!!", textBox1);

        }

        private void Bedroom_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }
    }
}

