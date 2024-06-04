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
    public partial class Socialservices : Form
    {
        public Socialservices()
        {
            InitializeComponent();
        }

        private void Socialservices_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            this.Hide();
            Owner.Show();
        }

        private void Socialservices_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            MessageBox.Show("Οι υπηρεσίες του δήμου θα ενημερωθούνε αυτόματα επειδή δεν λάβαμε κάποια απάντηση!!");
            timer1.Stop();
            this.Hide();
            Owner.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ένας υπάλληλος του δήμου ενημερώθηκε, Θα λάβετε άμεσα βοήθεια!!");
            this.Hide();
            Owner.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ένας υπάλληλος του δήμου ενημερώθηκε,Και θα σας επισκεφθεί με σκοπό να του πείτε τι ψώνια χρειάζεστε. Επιπλέον μπορείτε να μπείτε στο Online Shop αν χρειάζεστε φαγητό.");
            this.Hide();
            Owner.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ένας υπάλληλος του δήμου ενημερώθηκε, ένας ψυχολόγος του δήμου θα επικοινωνήσει μαζί σας!!");
            this.Hide();
            Owner.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ένας υπάλληλος του δήμου ενημερώθηκε, Θα σας επισκεφθεί ένας υπάλληλος του δήμου απο κοντά ώστε να του πείτε τι φάρμακα χρειάζεστε!!");
            this.Hide();
            Owner.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Θα λάβετε άμεσα βοήθεια!!");
            this.Hide();
            Owner.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Σας ευχαριστούμε που μας ενημερώσατε.");
            this.Hide();
            Owner.Show();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "SmartQuarantineHelp/SmartQuarantineHelp.chm", HelpNavigator.TopicId, "18");

        }

        private void HelpButton_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Πατήστε για παροχή βοήθειας!!", HelpButton);

        }
    }
}
