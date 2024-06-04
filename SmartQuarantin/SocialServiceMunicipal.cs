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
    public partial class SocialServiceMunicipal : Form
    {
        sendmails msg;
        public SocialServiceMunicipal()
        {
            InitializeComponent();
        }

        private void SocialServiceMunicipal_Load(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            var randomnum = rnd.Next(1, 100);        
            
            if (randomnum >=1 && randomnum <=20)
            {
                MessageBox.Show("Ο πολίτης με Username: PAPANIKOLAS δεν έδωσε κάποια απάντηση στο σύστημα, παρακαλώ επικοινωνήστε μέσω Email με τους κοντινότερους συγγενείς και τους αρμόδιους φορείς!! ");
            }
            else if(randomnum >= 21 && randomnum <= 40)
            {
                MessageBox.Show("Ο πολίτης με Username: POULAS δεν έδωσε κάποια απάντηση στο σύστημα, παρακαλώ επικοινωνήστε μέσω Email με τους κοντινότερους συγγενείς και τους αρμόδιους φορείς!! ");
            }
            else if (randomnum >= 41 && randomnum <= 60)
            {
                MessageBox.Show("Ο πολίτης με Username: emiltonr δεν έδωσε κάποια απάντηση στο σύστημα, παρακαλώ επικοινωνήστε μέσω Email με τους κοντινότερους συγγενείς και τους αρμόδιους φορείς!! ");
            }
            else if (randomnum >= 61 && randomnum <= 80)
            {
                MessageBox.Show("Ο πολίτης με Username: btatersale18 δεν έδωσε κάποια απάντηση στο σύστημα, παρακαλώ επικοινωνήστε μέσω Email με τους κοντινότερους συγγενείς και τους αρμόδιους φορείς!! ");
            }
            else
            {
                MessageBox.Show("Ο πολίτης με Username: vtiesmanl δεν έδωσε κάποια απάντηση στο σύστημα, παρακαλώ επικοινωνήστε μέσω Email με τους κοντινότερους συγγενείς και τους αρμόδιους φορείς!! ");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendmails msender = new sendmails();

            msender.Sendmail(textBox1, textBox2);
        }

        private void SocialServiceMunicipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Στείλτε το μήνυμα σας ", button1);

        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "SmartQuarantineHelp/SmartQuarantineHelp.chm", HelpNavigator.TopicId, "19");

        }

        private void HelpButton_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Πατήστε για παροχή βοήθειας!!", HelpButton);

        }
    }
}
