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
    public partial class Sms : Form
    {
        int correctAnswer1;
        int correctAnswer3;
        int correctAnswer6;
        int correctAnswer5;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public Sms()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 4;
        }

        private void Sms_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void askQuestion(int qnum)
        {
            switch (qnum)
            {

                case 1:

                    pictureBox1.Image = SmartQuarantin.Properties.Resources.Fotografia;
                    lblQuestion.Text = "Που θα θέλατε να μετακινηθείτε επιλέξτε μια απο τις παρακάτω επιλογές?";

                    button1.Text = "Εργασία";
                    button2.Text = "Νοσοκομείο-Φαρμακείο";
                    button3.Text = "Τράπεζα";
                    button4.Text = "Αθλητικές Δραστηριότητες";
                    button5.Text = "Σχολείο-Συνοδός Ανήλικου";
                    button6.Text = "Σουπερ-Μαρκετ";

                    correctAnswer1 = 1;
                    correctAnswer3 = 3;
                    correctAnswer6 = 6;


                    break;
                case 2:

                    pictureBox1.Image = SmartQuarantin.Properties.Resources.foto;
                    lblQuestion.Text = "Ποιό μέσο μεταφοράς θα προτιμούσατε για την Μετακίνησή σας?";

                    button1.Text = "Μετρό-Ηλεκτρικός";
                    button2.Text = "Αυτοκίνητο";
                    button3.Text = "Λεωφορείο";
                    button4.Text = "Συνδυασμός των παραπάνω";
                    button5.Text = "Πόδια - Ποδήλατο";
                    button6.Text = "Τραμ";

                    correctAnswer1 = 1;
                    correctAnswer3 = 3;
                    correctAnswer6 = 6;
                    break;

                case 3:

                    pictureBox1.Image = SmartQuarantin.Properties.Resources.fotografiaa;

                    lblQuestion.Text = "Ποιές ώρες επιθυμείτε να μετακινηθείτε?";

                    button1.Text = "9  π.μ - 11 π.μ";
                    button2.Text = "11 π.μ - 1  μ.μ";
                    button3.Text = "1  μ.μ - 3  μ.μ";
                    button4.Text = "3  μ.μ - 5  μ.μ";
                    button5.Text = "7  μ.μ - 9  μ.μ";
                    button6.Text = "5  μ.μ - 7  μ.μ";

                    correctAnswer1 = 1;
                    correctAnswer3 = 3;
                    correctAnswer6 = 6;

                    break;

                case 4:

                    pictureBox1.Image = SmartQuarantin.Properties.Resources.fotos;

                    lblQuestion.Text = "Με την επιστροφή σας στο Σπίτι επιθυμείτε να πραγγγείλετε καφέ η φαγητό?";

                    button1.Text = "Καφε με Take away";
                    button2.Text = "Καφέ με Delivery";
                    button3.Text = "Φαγητό με Take away";
                    button4.Text = "Φαγητό με Delivery";
                    button5.Text = "Τίποτα απο τα παραπάνω";
                    button6.Text = "Καφές και Φαγητό με Take away";

                    correctAnswer1 = 1;
                    correctAnswer3 = 3;
                    correctAnswer6 = 6;
                    correctAnswer5 = 5;
                    break;

            }
        }

        private void ClickAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer1 || buttonTag == correctAnswer3 || buttonTag == correctAnswer6)
            {
                score++;
            }


            if (questionNumber == totalQuestions)
            {
                // work out the percentage here
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);
                if (score == 4)
                {
                    MessageBox.Show("*****************SOS*****************" + Environment.NewLine + "ΜΕΓΑΛΗ ΠΡΟΣΟΧΗ! Το ποσοστό επικυνδινότητας αγγίζει το  " + percentage + " % " + Environment.NewLine + "Ακολουθήστε την προτεινόμενη διαδρομή για να διασφαλίσετε την δική σας υγεία και των συνανθρώπων  σας." + Environment.NewLine + "*****************SOS*****************");
                    Map mp = new Map();
                    mp.Show(this);
                    if (buttonTag == correctAnswer5)
                    {
                        MessageBox.Show("Για την μετακίνηση αυτή μπορείτε να χρησιμοποιήσετε 45 λεπτά απο το χρονικό διάστημα που επιλέξατε");
                    }
                    else
                    {
                        MessageBox.Show("Για την μετακίνηση αυτή μπορείτε να χρησιμοποιήσετε 45 λεπτά απο το χρονικό διάστημα που επιλέξατε" + Environment.NewLine + "Εάν επιθυμείτε καφέ ή φαγητό  για την διαδρομή αυτή καλό θα ήταν να τον κάνετε Delivery για το σπίτι σας");
                    }

                }
                else if (score == 3)
                {
                    MessageBox.Show("ΠΡΟΣΟΧΗ! Η μετακίνηση που επιλέξατε την συγκεκριμένη ώρα  με το συγκεκριμένο μέσο εγκυμονεί κίνδυνο με ποσοστό επικινδυνότητας  " + percentage + " % " + Environment.NewLine + "για την εξάπλωση του Covid 19 και την ασφάλεια της υγείας σας" + Environment.NewLine + "Παρακαλώ κοιτάξτε την προτεινόμενη διαδρομή στον χάρτη");
                    Map1 mp1 = new Map1();
                    mp1.Show(this);
                    if (buttonTag == correctAnswer5)
                    {
                        MessageBox.Show("Για την μετακίνηση αυτή μπορείτε να χρησιμοποιήσετε 1 ώρα και 15 λεπτά απο το χρονικό διάστημα που επιλέξατε");
                    }
                    else
                    {
                        MessageBox.Show("Για την μετακίνηση αυτή μπορείτε να χρησιμοποιήσετε 1 ώρα και 15 λεπτά απο το χρονικό διάστημα που επιλέξατε" + Environment.NewLine + "Εάν επιθυμείτε καφέ για την διαδρομή αυτή καλό θα ήταν να τον κάνετε Delivery για το σπίτι σας");
                    }
                }
                else if (score == 2)
                {
                    MessageBox.Show("ΠΡΟΣΟΧΗ!  Δεν είστε αρκετά ασφλαλής να ακολουθήσετε αυτή την διαδρομή διότι το Ποσοστό επικινδυνότητας είναι  " + percentage + " % " + Environment.NewLine + "Παρακαλώ κοιτάξτε την προτεινόμενη διαδρομή στον χάρτη");
                    Map2 mp2 = new Map2();
                    mp2.Show(this);
                    if (buttonTag == correctAnswer5)
                    {
                        MessageBox.Show("Για την μετακίνηση αυτή μπορείτε να χρησιμοποιήσετε 1 ώρα και 30 λεπτά απο το χρονικό διάστημα που επιλέξατε");


                    }
                    else
                    {
                        MessageBox.Show("Για την μετακίνηση αυτή μπορείτε να χρησιμοποιήσετε 1 ώρα και 30 λεπτά απο το χρονικό διάστημα που επιλέξατε" + Environment.NewLine + "Εάν επιθυμείτε καφέ η φαγητό προτείνετε το Take away αλλα μπορείτε να το πάρετε και με Delivery Online");
                    }
                }
                else if (score == 1)
                {
                    MessageBox.Show("Είστε Ασφαλής να συνεχίσετε τον προορισμό σας μέσω της παρακάτω διαδρομής" + Environment.NewLine + "Ποσοστό επικινδυνότητας  " + percentage + " %");
                    Map3 mp3 = new Map3();
                    mp3.Show(this);
                    if (buttonTag == correctAnswer5)
                    {
                        MessageBox.Show("Για την μετακίνηση αυτή μπορείτε να χρησιμοποιήσετε 1 ώρα και 45 λεπτά απο το χρονικό διάστημα που επιλέξατε");
                    }
                    else
                    {
                        MessageBox.Show("Για την μετακίνηση αυτή μπορείτε να χρησιμοποιήσετε 1 ώρα και 45 λεπτά απο το χρονικό διάστημα που επιλέξατε" + Environment.NewLine + "Εάν επιθυμείτε καφέ η φαγητό μπορείτε να το πάρετε και με Take away");

                    }
                }
                else
                {
                    MessageBox.Show("Είστε Απολύτως Ασφαλής να συνεχίσετε τον προορισμό σας μέσω της παρακάτω διαδρομής" + Environment.NewLine + "Ποσοστό επικινδυνότητας  " + percentage + " %");
                    Map4 mp4 = new Map4();
                    mp4.Show(this);
                    if (buttonTag == correctAnswer5)
                    {
                        MessageBox.Show("Για την μετακίνηση αυτή μπορεί να χρησιμοποιηθεί όλος ο χρόνος απο τον χρόνο που επιλέξατε");

                    }
                    else
                    {
                        MessageBox.Show("Για την μετακίνηση αυτή μπορεί να χρησιμοποιηθεί όλος ο χρόνος απο τον χρόνο που επιλέξατε" + Environment.NewLine + " Εάν επιθυμείτε καφέ η φαγητό μπορείτε να το πάρετε και με Take away");

                    }

                }

                score = 0;
                questionNumber = 0;

                askQuestion(questionNumber);
            }

            questionNumber++;

            askQuestion(questionNumber);

        
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "SmartQuarantineHelp/SmartQuarantineHelp.chm", HelpNavigator.TopicId, "20");

        }

        private void HelpButton_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Πατήστε για παροχή βοήθειας!!", HelpButton);

        }
    }
}
