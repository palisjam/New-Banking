using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Security.Policy;
using System.Windows.Forms;
using IBAN;

namespace WindowsBanking
{
    public partial class CreateAccount : Form
    {
        private IBANController _iban = new IBANController();
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtIBAN.Text = _iban.GetIBAN();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string msg = "";
            //CreateAccount(out msg);
            MessageBox.Show(msg);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtIBAN.Text = _iban.GetIBAN();
        }
    }
}