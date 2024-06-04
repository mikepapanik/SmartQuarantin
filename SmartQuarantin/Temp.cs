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
    public partial class Temp : Form
    {
        public Temp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rooms rde = new Rooms();
            rde.Show(this);
            this.Hide();
        }

        private void Temp_Load(object sender, EventArgs e)
        {

            Random rnd = new Random();
            var randomnum = rnd.Next(356, 415) / 10M;
            label1.Text = randomnum.ToString() + "°C";

            if (randomnum <= 366 / 10M)
            {
                label1.ForeColor = Color.Green;
                MessageBox.Show("Η θερμοκρασία σας είναι φυσιολογική μπορείτε να εισέλθετε στο Σπίτι.");
                Rooms rde = new Rooms();
                rde.Show(this);
                this.Hide();
                button1.Dispose();
            }
            else if (randomnum > 366 / 10M && randomnum <= 372 / 10M)
            {
                label1.ForeColor = Color.Green;
                MessageBox.Show("Σας προτείνουμε να ξεκουραστείτε για 5΄ λεπτά και να ξαναδοκιμάσετε να εισέλθετε στο Σπίτι αφού πρώτα κάνετε νέα θερμομέτρηση.");
                MessageBox.Show("Επιθυμείτε να Συνεχίσετε?" + Environment.NewLine + "Εάν Ναι πατήστε το πράσινο βελάκι");
            }
            else if (randomnum > 372 / 10M && randomnum <= 380 / 10M)
            {
                label1.ForeColor = Color.Red;
                MessageBox.Show("Προσοχή!!! Δέν μπορείτε να εισέλθετε στο Σπίτι λόγο αυξημένης θερμοκρασίας.");
                button1.Dispose();
            }
            else if (randomnum > 380 / 10M)
            {
                label1.ForeColor = Color.Red;
                MessageBox.Show("Προσοχή!!! Δέν μπορείτε να εισέλθετε στο Σπίτι λόγο αυξημένης θερμοκρασίας." + Environment.NewLine + "Επισκεφθείτε το κοντινότερο διαγνωστικό κέντρο για να κάνετε τεστ κορονοιού!!" + Environment.NewLine + "Ο χάρτης που θα εμφανιστεί θα σας δείξει το κοντινότερο διαγνωστικό κέντρο.");
                mapcovid eer = new mapcovid();
                eer.Show(this);
                this.Hide();
                button1.Dispose();
            }
        }

        private void Temp_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }
    }
}
