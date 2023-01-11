using Account;
using Google.Protobuf.WellKnownTypes;
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
    public partial class frmTransfer : Form
    {
        private AccountController _accountController = new AccountController();
        private TransactionModel _transaction = new TransactionModel();
        public frmTransfer()
        {
            InitializeComponent();
        }

        private async void txtOriginIBAN_TextChanged(object sender, EventArgs e)
        {
            if(txtOriginIBAN.Text.Length == 18)
            {
                Task<AccountModel> _tAccount = _accountController.GetAccount(txtOriginIBAN.Text);
                AccountModel _account = await _tAccount;
                txtOriginFamilyName.Text = _account.FamilyName;
                txtOriginGivenName.Text = _account.GivenName;
                txtOriginEmail.Text = _account.Email;
                if (String.IsNullOrEmpty(_account.FamilyName) && String.IsNullOrEmpty(_account.GivenName) && String.IsNullOrEmpty(_account.Email))
                {
                    labelOriginIBANAlert.Visible = true;
                    txtOriginBalance.Text = "";
                }else
                {
                    labelOriginIBANAlert.Visible = false;
                    Task<double> _tAmount = _accountController.GetBalance(txtOriginIBAN.Text);
                    double _amount = await _tAmount;
                    txtOriginBalance.Text = _amount.ToString("#,##0.00");
                }
            }
        }

        private void frmTransfer_Load(object sender, EventArgs e)
        {

        }

        private async void txtDesIBAN_TextChanged(object sender, EventArgs e)
        {
            if (txtDesIBAN.Text.Length == 18)
            {
                Task<AccountModel> _tAccount = _accountController.GetAccount(txtDesIBAN.Text);
                AccountModel _account = await _tAccount;
                txtDesFamilyName.Text = _account.FamilyName;
                txtDesGivenName.Text = _account.GivenName;
                txtDesEmail.Text = _account.Email;
                if (String.IsNullOrEmpty(_account.FamilyName) && String.IsNullOrEmpty(_account.GivenName) && String.IsNullOrEmpty(_account.Email))
                {
                    labelDesIBANAlert.Visible = true;
                }
                else
                {
                    labelDesIBANAlert.Visible = false;
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransactionModel _transaction = new TransactionModel();
            string msg;

            _transaction.Destination = txtDesIBAN.Text;
            _transaction.Origin = txtOriginIBAN.Text;
            _transaction.Amount = double.Parse(txtTransAmount.Text);
            _transaction.Type = (int)CONSTANT.TransactionType.Type.TRANSFER;
            _accountController.CreateTransaction(_transaction, out msg);
            this.Dispose();
        }
    }
}
