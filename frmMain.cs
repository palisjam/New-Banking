using Account;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsBanking
{
    public partial class frmMain : Form
    {
        Form createAccount = new frmCreateAccount();
        AccountController _accountController = new AccountController();
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createAccount.ShowDialog();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Form _frmDeposit = new frmDeposit();
            _frmDeposit.ShowDialog();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            Form _frmTransfer = new frmTransfer();
            _frmTransfer.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            loadAccountSum();
        }

        private void btnRefreshData_Click(object sender, EventArgs e)
        {
            loadAccountSum();
        }

        private async void loadAccountSum()
        {
            Task<List<AccountSummaryModel>> _tAccSumModel = _accountController.GetAccountSummary();
            List<AccountSummaryModel> _accSumModel = await _tAccSumModel;
            tbAccountList.Rows.Clear();
            foreach (AccountSummaryModel model in _accSumModel)
            {
                tbAccountList.Rows.Add(model.IBAN,model.Balance);
            }
        }
    }
}
