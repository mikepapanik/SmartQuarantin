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
    public partial class Clothes : Form
    {
        public Clothes()
        {
            InitializeComponent();
        }

        private void Clothes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Small Ανδρικό");
                    item.SubItems.Add("1");
                    item.SubItems.Add("0,00");
                    listView1.Items.Add(item);

                }
                else if (radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Small Γυναικείο");
                    item.SubItems.Add("1");
                    item.SubItems.Add("0,00");
                    listView1.Items.Add(item);

                }
             

            }

            else if (radioButton2.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Medium Ανδρικό");
                    item.SubItems.Add("1");
                    item.SubItems.Add("0,00");
                    listView1.Items.Add(item);

                }
                else if (radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Medium Γυναικείο");
                    item.SubItems.Add("1");
                    item.SubItems.Add("0,00");
                    listView1.Items.Add(item);

                }
          
            }

            else if (radioButton3.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Large Ανδρικό");
                    item.SubItems.Add("1");
                    item.SubItems.Add("0,00");
                    listView1.Items.Add(item);

                }
                else if (radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Large Γυναικείο");
                    item.SubItems.Add("1");
                    item.SubItems.Add("0,00");
                    listView1.Items.Add(item);

                }
        
            }

            else if (radioButton4.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Extra Large Ανδρικό");
                    item.SubItems.Add("1");
                    item.SubItems.Add("0,00");
                    listView1.Items.Add(item);

                }
                else if (radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Extra Large Γυναικείο");
                    item.SubItems.Add("1");
                    item.SubItems.Add("0,00");
                    listView1.Items.Add(item);

                }             
             }




            if (checkBox1.Checked == true)
            {
                ListViewItem item = new ListViewItem("Μπλούζα Καλοκαιρινή ");
                item.SubItems.Add("");
                item.SubItems.Add("15,00");
                listView1.Items.Add(item);

            }

            if (checkBox2.Checked == true)
            {
                ListViewItem item = new ListViewItem("Παντελόνι Καλοκαιρινό ");
                item.SubItems.Add("");
                item.SubItems.Add("23,00");
                listView1.Items.Add(item);

            }

            if (checkBox3.Checked == true)
            {
                ListViewItem item = new ListViewItem("Πουκάμισο Καλοκαίρινο ");
                item.SubItems.Add("");
                item.SubItems.Add("30,00");
                listView1.Items.Add(item);

            }

            if (checkBox4.Checked == true)
            {
                ListViewItem item = new ListViewItem("Φόρμα άθλησης");
                item.SubItems.Add("");
                item.SubItems.Add("16,00");
                listView1.Items.Add(item);

            }
            

            if (checkBox5.Checked == true)
            {
                ListViewItem item = new ListViewItem("Αμάνικο Μπλουζάκι");
                item.SubItems.Add("");
                item.SubItems.Add("10,00");
                listView1.Items.Add(item);

            }


            if (checkBox15.Checked == true)
            {
                ListViewItem item = new ListViewItem("Μπλούζα Καλοκαιρινή ");
                item.SubItems.Add(textBox1.Text);
                int qty = Convert.ToInt32(textBox1.Text);
                double cost = qty * 15.00;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                textBox1.Text = "";
            }

            if (checkBox16.Checked == true)
            {
                ListViewItem item = new ListViewItem("Παντελόνι Καλοκαιρινό ");
                item.SubItems.Add(textBox2.Text);
                int qty = Convert.ToInt32(textBox2.Text);
                double cost = qty * 23.00;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                textBox2.Text = "";
            }

            if (checkBox17.Checked == true)
            {
                ListViewItem item = new ListViewItem("Πουκάμισο Καλοκαίρινο ");
                item.SubItems.Add(textBox3.Text);
                int qty = Convert.ToInt32(textBox3.Text);
                double cost = qty * 30.00;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                textBox3.Text = "";
            }

            if (checkBox18.Checked == true)
            {
                ListViewItem item = new ListViewItem("Φόρμα άθλησης ");
                item.SubItems.Add(textBox4.Text);
                int qty = Convert.ToInt32(textBox4.Text);
                double cost = qty * 16.00;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox4.Text = "";
            }

            if (checkBox19.Checked == true)
            {
                ListViewItem item = new ListViewItem("Αμάνικο Μπλουζάκι ");
                item.SubItems.Add(textBox5.Text);
                int qty = Convert.ToInt32(textBox5.Text);
                double cost = qty * 10.00;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox5.Text = "";
            }

            if (checkBox22.Checked == true)
            {
                ListViewItem item = new ListViewItem("Ανδρικό Μαγιό ");
                item.SubItems.Add(textBox6.Text);
                int qty = Convert.ToInt32(textBox6.Text);
                double cost = qty * 20.00;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox6.Text = "";
            }


            if (checkBox23.Checked == true)
            {
                ListViewItem item = new ListViewItem("Γυναικείο Μαγιό ");
                item.SubItems.Add(textBox7.Text);
                int qty = Convert.ToInt32(textBox7.Text);
                double cost = qty * 25.00;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox7.Text = "";
            }



            double total = 0 + 1 * 0.001;
            double hst = 0;
            double totaldue = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                total += Convert.ToDouble(item.SubItems[2].Text);
            }

            hst = total * 0.13;
            totaldue = hst + total;

            string amount = total.ToString("c2");

            textBox8.Text = amount;
            tabControl1.SelectTab("tabPage2");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage3");
            textBox19.Text = textBox8.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            textBox8.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage1");
        }

        private void Clothes_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton5.Checked = true;
            textBox8.Enabled = false;
            textBox19.Enabled = false;

            comboBox1.Items.Add("Athens");
            comboBox1.Items.Add("Thessaloniki");
            comboBox1.Items.Add("Rhodes");
            comboBox1.Items.Add("Nauplio");
            comboBox1.Items.Add("Piraeus");


            comboBox2.Items.Add("Credit Card");
            comboBox2.Items.Add("Debit Card");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || textBox15.Text == "" || textBox18.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Please fill in required fields");
            }

            else
            {
                string money = textBox19.Text;
                MessageBox.Show("Η παραγγελία σου ολοκληρώθηκε επιτυχώς. Σύντομα θα είναι κοντά σου!");

                this.Close();


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage2");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox18.MaxLength = 16;
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Πατήστε για να έξοδο απο την φόρμα", button5);

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Πατήστε για να Επιβεβαίωση Παραγγελίας", button1);

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip5.Show("Πατήστε για να Ξανά Παραγγείλετε", button2);

        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            toolTip4.Show("Πατήστε για να Διαγράψετε την υπάρχουσα παραγγελία", button4);

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            toolTip3.Show("Πατήστε για να Ολοκληρώσετε την αγορά", button3);

        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            toolTip7.Show("Πατήστε για να Πάτε Πίσω", button6);

        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            toolTip6.Show("Πατήστε για να Πληρώσετε", button7);

        }

        private void textBox18_MouseHover(object sender, EventArgs e)
        {
            toolTip8.Show("Πληκτρολογήστε τον 16 ψήφιο αριθμό της κάρτας σας", textBox18);

        }
    }
}
