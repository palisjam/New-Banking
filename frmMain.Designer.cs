namespace WindowsBanking
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.tbAccountList = new System.Windows.Forms.DataGridView();
            this.IBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefreshData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbAccountList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(8, 24);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(144, 40);
            this.btnCreateAccount.TabIndex = 0;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(183, 24);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(144, 40);
            this.btnDeposit.TabIndex = 1;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(349, 24);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(144, 40);
            this.btnTransfer.TabIndex = 2;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // tbAccountList
            // 
            this.tbAccountList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.tbAccountList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbAccountList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IBAN,
            this.Balance});
            this.tbAccountList.Location = new System.Drawing.Point(12, 70);
            this.tbAccountList.Name = "tbAccountList";
            this.tbAccountList.RowHeadersWidth = 51;
            this.tbAccountList.RowTemplate.Height = 29;
            this.tbAccountList.Size = new System.Drawing.Size(481, 327);
            this.tbAccountList.TabIndex = 3;
            // 
            // IBAN
            // 
            this.IBAN.HeaderText = "IBAN";
            this.IBAN.MinimumWidth = 6;
            this.IBAN.Name = "IBAN";
            this.IBAN.ReadOnly = true;
            this.IBAN.Width = 200;
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Balance";
            this.Balance.MinimumWidth = 6;
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            this.Balance.Width = 200;
            // 
            // btnRefreshData
            // 
            this.btnRefreshData.Location = new System.Drawing.Point(399, 412);
            this.btnRefreshData.Name = "btnRefreshData";
            this.btnRefreshData.Size = new System.Drawing.Size(94, 29);
            this.btnRefreshData.TabIndex = 4;
            this.btnRefreshData.Text = "Refresh";
            this.btnRefreshData.UseVisualStyleBackColor = true;
            this.btnRefreshData.Click += new System.EventHandler(this.btnRefreshData_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 453);
            this.Controls.Add(this.btnRefreshData);
            this.Controls.Add(this.tbAccountList);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnCreateAccount);
            this.Name = "frmMain";
            this.Text = "New Banking";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbAccountList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCreateAccount;
        private Button btnDeposit;
        private Button btnTransfer;
        private DataGridView tbAccountList;
        private Button btnRefreshData;
        private DataGridViewTextBoxColumn IBAN;
        private DataGridViewTextBoxColumn Balance;
    }
}