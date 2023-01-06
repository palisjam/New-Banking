using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Security.Policy;
using System.Windows.Forms;
using IBAN;
using Account;

namespace WindowsBanking
{
    public partial class CreateAccount : Form
    {
        private IBANController _iban = new IBANController();
        private AccountController _accountController = new AccountController();
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
            AccountModel _account = new AccountModel();
            _account.Set(txtIBAN.Text,txtFamilyName.Text,txtGivenName.Text,txtEmailAddress.Text);
            
            _accountController.CreateAccount(_account, out msg);
            MessageBox.Show(msg);
            txtIBAN.Text = _iban.GetIBAN();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtIBAN.Text = _iban.GetIBAN();
        }
    }
}