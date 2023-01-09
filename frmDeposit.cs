using Account;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsBanking
{
    public partial class frmDeposit : Form
    {

        private AccountController _accountController = new AccountController();
        private TransactionModel _transaction = new TransactionModel();
        public frmDeposit()
        {
            InitializeComponent();
        }

        private void frmDeposit_Load(object sender, EventArgs e)
        {
            string msg;
            _accountController.CreateTransaction(_transaction,out msg);
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            Task<AccountModel> _account = _accountController.GetAccount(txtIBAN.Text);
            AccountModel i = await _account;
            txtFamilyName.Text = i.FamilyName;
            txtGivenName.Text = i.GivenName;
            txtEmail.Text = i.Email;
            
            
        }

        private void btnCalFee_Click(object sender, EventArgs e)
        {
            if (btnCalFee.Text == "Calculate Fee")
            {
                double _gross = double.Parse(txtGrossDeposit.Text);
                double _fee = _accountController.GetFee(_gross);
                txtFee.Text = _fee.ToString();
                txtNetDeposit.Text = (_gross - _fee).ToString();
                btnCalFee.Text = "Deposit";
            }
            else
            {
                btnCalFee.Text = "Calculate Fee";
                // Record transaction
            }
        }
    }
}
