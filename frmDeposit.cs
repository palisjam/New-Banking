using Account;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility;

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
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCalFee_Click(object sender, EventArgs e)
        {
            if (btnCalFee.Text == "Calculate Fee")
            {
                Amount _amount;
                double _gross = double.Parse(txtGrossDeposit.Text);
                _accountController.GetFee(_gross,out _amount);
                txtFee.Text = _amount.Fee.ToString();
                txtNetDeposit.Text = _amount.Net.ToString();
                btnCalFee.Text = "Deposit";
            }
            else
            {
                string _msg;
                _transaction.Destination = txtIBAN.Text;
                _transaction.Amount = double.Parse(txtNetDeposit.Text);
                _transaction.Type = (int)CONSTANT.TransactionType.Type.DEPOSIT;
                _transaction.Fee = double.Parse(txtFee.Text);
                _transaction.Origin = "";

                _accountController.CreateTransaction(_transaction, out _msg);
                this.Dispose();
            }
        }

        private void txtGrossDeposit_TextChanged(object sender, EventArgs e)
        {
            btnCalFee.Text = "Calculate Fee";
        }

        private async void txtIBAN_TextChanged(object sender, EventArgs e)
        {
            if (txtIBAN.Text.Length == 18)
            {
                Task<AccountModel> _tAccount = _accountController.GetAccount(txtIBAN.Text);
                AccountModel _account = await _tAccount;
                txtFamilyName.Text = _account.FamilyName;
                txtGivenName.Text = _account.GivenName;
                txtEmail.Text = _account.Email;
                if (!String.IsNullOrEmpty(_account.FamilyName) && !String.IsNullOrEmpty(_account.GivenName) && !String.IsNullOrEmpty(_account.Email))
                {
                    txtGrossDeposit.ReadOnly = false;
                    labelIBANAlert.Visible = false;
                }
                else
                {
                    txtGrossDeposit.ReadOnly = true;
                    labelIBANAlert.Visible = true;
                }
            }
        }
    }
}
