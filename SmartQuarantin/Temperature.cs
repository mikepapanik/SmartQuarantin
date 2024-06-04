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
    public partial class Temperature : Form
    {
        public Temperature()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rooms rm = new Rooms();
            rm.Show(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Temp ttm = new Temp();
            ttm.Show(this);
            this.Hide();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Πατώντας αυτό το κουμπί κάνετε κανονική είσοδο στο σπίτι και αρχίζει η θερμομέτρηση ώστε να δείτε αν μπορείτε να περάσετε, θα σας εμφανιστούν τα κατάλληλα μηνύματα.", button2);

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Πατήστε για να ξεκινήσετε την απομακρυσμένη χρήση του Έξυπνου Σπιτιού", button1);

        }

        private void Temperature_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "SmartQuarantineHelp/SmartQuarantineHelp.chm", HelpNavigator.TopicId, "13");

        }

        private void Temperature_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Πατήστε για παροχή βοήθειας!!", HelpButton);

        }
    }
}
