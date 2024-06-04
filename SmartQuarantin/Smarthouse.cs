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
    public partial class Smarthouse : Form
    {
        public Smarthouse()
        {
            InitializeComponent();
        }

        private void Smarthouse_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Temperature tm = new Temperature();
            tm.Show(this);
            this.Hide();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Πατήστε για να κάνετε Είσοδο (Απομακρυσμένος Έλεγχος - Κανονική Είσοδος στο Σπίτι).", button1);

        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "SmartQuarantineHelp/SmartQuarantineHelp.chm", HelpNavigator.TopicId, "11");

        }

        private void HelpButton_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Πατήστε για παροχή βοήθειας!!", HelpButton);

        }
    }
}
