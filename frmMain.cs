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
            Form deposit = new frmDeposit();
            deposit.ShowDialog();
        }
    }
}
