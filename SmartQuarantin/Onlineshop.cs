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
    public partial class Onlineshop : Form
    {
        public Onlineshop()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Onlinecoffee Onlin = new Onlinecoffee();
            Onlin.Show(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pizza Pi = new Pizza();
            Pi.Show(this);
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Food Fo = new Food();
            Fo.Show(this);
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clothes Clo = new Clothes();
            Clo.Show(this);
            this.Hide();
        }

        private void Onlineshop_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Πατήστε για να Παραγγείλετε Καφέ Online", button3);

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Πατήστε για να Παραγγείλετε Πίτσα Online", button2);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip3.Show("Πατήστε για να Παραγγείλετε Μαγειρευτό Φαγητό Online", button1);

        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            toolTip4.Show("Πατήστε για να Παραγγείλετε Ανδρικά και Γυναικεία Ρούχα Online", button4);
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "SmartQuarantineHelp/SmartQuarantineHelp.chm", HelpNavigator.TopicId, "16");

        }

        private void HelpButton_MouseHover(object sender, EventArgs e)
        {
            toolTip5.Show("Πατήστε για παροχή βοήθειας!!", HelpButton);

        }
    }
}
