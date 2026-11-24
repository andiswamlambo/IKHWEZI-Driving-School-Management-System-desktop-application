using System;
using System.Windows.Forms;

namespace Driving_school_login_form
{
    public partial class FrontPageForm : Form
    {
        public FrontPageForm()
        {
            InitializeComponent();
        }

        // ==========================================
        // MAIN LOGIN BUTTON
        // ==========================================
        private void btnLogin_Click(object sender, EventArgs e)
        {
            CurrentUser.PendingFeature = ""; // No specific feature, just normal login
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        // ==========================================
        // SIGN UP BUTTON
        // ==========================================
        private void btnSignUp_Click(object sender, EventArgs e)
        {
           
        }

        // ==========================================
        // UNIVERSAL FEATURES (Requires Login)
        // ==========================================
        private void btnQuickBook_Click(object sender, EventArgs e)
        {
            CurrentUser.PendingFeature = "BookSession";
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
            
        }

        private void btnQuickVerify_Click(object sender, EventArgs e)
        {
            CurrentUser.PendingFeature = "VerifyPayment";
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }    

        // ==========================================
        // INFORMATIONAL LINKS
        // ==========================================
        private void lnkAboutUs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string aboutText = @"
Ikhwezi Driving School
⭐ 5/5 Google Reviews

Located in: University of KwaZulu-Natal
Address: UKZN Concourse, Student Union, 269 Mazisi Kunene Rd, Glenwood, Durban, 4001
Phone: 083 544 8544
Hours: Mon-Fri: 9am - 6pm | Sat: 9am - 1pm

Khwezi Driving School is a trusted driving academy based in Durban, offering comprehensive training for Code 8, Code 10, automatic vehicles, and learner’s license preparation. Our experienced and patient instructors provide personalized lessons to ensure you pass your test with confidence.
";
            MessageBox.Show(aboutText, "About Ikhwezi Driving School", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lnkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            CurrentUser.PendingFeature = "Help";
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();

        }

        private void lnkIntelTech_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string teamText = @"
Development Team - IntelTech

No   | Student Number   | Group Member's Name       
---------------------------------------------
1.   | 223028466        | Andiswa Mlambo            
2.   | 223114199        | Sphesihle Fihlela        
3.   | 222020158        | Andile Hlatshwayo        
4.   | 222076412        | Noxolo Mlondo            
5.   | 223004085        | Mcebo Ngubane             
6.   | 223055111        | Asibonge Marhwa          
";
            MessageBox.Show(teamText, "Our Team - intelTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {

        }
    }
}