using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartQuarantin
{
    public partial class Menu : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        public Menu()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Form2 regist = new Form2();
            regist.Show(this);
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sms sm = new Sms();
            sm.Show(this);
            this.Hide();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Πατώντας αυτό το κουμπί μπορείτε να δηλώσετε τους βασικούς προορισμούς της ημέρας σας με τα αντίστοιχα SMS στο 13033.", button1);

        }

        private void loginButtonPanel_Click(object sender, EventArgs e)
        {
            string usr = userNameTextBox.Text;
            string psw = PasswordTextBox.Text;
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Userap.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Userapp where Username='" + userNameTextBox.Text + "' AND Password='" + PasswordTextBox.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;

                MessageBox.Show("Έχετε Εισέλθει με Επιτυχία στην Εφαρμογή.");
            }
            else
            {
                MessageBox.Show("Username or password is incorrect");
            }

            con.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Smarthouse smarthou = new Smarthouse();
            smarthou.Show(this);
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Onlineshop Onlines = new Onlineshop();
            Onlines.Show(this);
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Socialservices Socialse = new Socialservices();
            Socialse.Show(this);
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Το τρίτο είναι το keyword 
           Help.ShowHelp(this, "SmartQuarantineHelp/SmartQuarantineHelp.chm", HelpNavigator.TopicId,"10");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η συγκεκριμένη εφαρμογή για την Έξυπνη Καραντίνα δημιουργήθηκε απο τους Φοιτητές: ΠΑΠΑΝΙΚΟΛΑ ΜΙΧΑΗΛ ΜΕ ΑΜ:ΜΠΠΛ20059 και ΠΟΥΛΑ ΘΕΟΔΟΣΙΟ ΜΕ ΑΜ:ΜΠΠΛ20067");

        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MailForm mailform = new MailForm();
            mailform.Show(this);
            this.Hide();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult1 = MessageBox.Show("Are you sure want exit from application?", "Smart Quarantine Exit", MessageBoxButtons.YesNo);
            if (dialogResult1 == DialogResult.Yes)
            {
                e.Cancel = false;


            }
            else if (dialogResult1 == DialogResult.No)
            {

                e.Cancel = true;
            }
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Πατώντας αυτό το κουμπί μπορείτε να αλληλεπιδράσετε με τις διάφορες συσκευές του Σπιτιού σας, ακόμα πραγματοποιείται θερμομέτρηση αν κάποιος επιθυμεί την είσοδο με φυσική παρουσία στο σπίτι.", button2);

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            toolTip3.Show("Πατώντας αυτό το κουμπί μπορείτε να συνδεθείτε στην Κοινωνική Υπηρεσία του Δήμου", button3);

        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            toolTip4.Show("Πατώντας αυτό το κουμπί μπορείτε να συνδεθείτε στο Online Σύστημα Παραγγελιών", button4);
        }

        private void Register_MouseHover(object sender, EventArgs e)
        {
            toolTip5.Show("Πατώντας αυτό το κουμπί μπορείτε να κάνετε εγγραφή", Register);
        }

        private void loginButtonPanel_MouseHover(object sender, EventArgs e)
        {
            toolTip6.Show("Πατώντας αυτό το κουμπί κάνετε Σύνδεση", loginButtonPanel);
        }

        private void userNameTextBox_MouseHover(object sender, EventArgs e)
        {
            toolTip7.Show("Πληκτρολογήστε το Όνομα Χρήστη", userNameTextBox);

        }

        private void PasswordTextBox_MouseHover(object sender, EventArgs e)
        {
            toolTip8.Show("Πληκτρολογήστε των Κωδικό σας", PasswordTextBox);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string usr = textBox2.Text;
            string psw = textBox1.Text;
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Userapps.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Userapp where Username='" + textBox2.Text + "' AND Password='" + textBox1.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                SocialServiceMunicipal SocialServiceMu = new SocialServiceMunicipal();
                SocialServiceMu.Show(this);
                this.Hide();


            }
            else
            {
                MessageBox.Show("Username or password is incorrect");
            }

            con.Close();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "SmartQuarantineHelp/SmartQuarantineHelp.chm", HelpNavigator.TopicId, "10");
        }

        private void HelpButton_MouseHover(object sender, EventArgs e)
        {
            toolTip9.Show("Πατήστε για παροχή βοήθειας!!", HelpButton);

        }
    }
}
