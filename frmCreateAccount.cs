using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Security.Policy;
using System.Windows.Forms;
using IBAN;
using Account;

namespace WindowsBanking
{
    public partial class frmCreateAccount : Form
    {
        private IBANController _iban = new IBANController();
        private AccountController _accountController = new AccountController();

        public frmCreateAccount()
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
            _account.Set(txtFamilyName.Text,txtGivenName.Text,txtEmailAddress.Text);
            
            _accountController.CreateAccount(txtIBAN.Text,_account, out msg);
            MessageBox.Show(msg);
            txtIBAN.Text = _iban.GetIBAN();
            Clear();
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtIBAN.Text = _iban.GetIBAN();
        }

        private void Clear()
        {
            txtFamilyName.Text = null;
            txtGivenName.Text = null;
            txtEmailAddress.Text = null;
        }

    }
}