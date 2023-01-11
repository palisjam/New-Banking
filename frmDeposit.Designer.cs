namespace WindowsBanking
{
    partial class frmDeposit
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
            this.txtIBAN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtGivenName = new System.Windows.Forms.TextBox();
            this.txtFamilyName = new System.Windows.Forms.TextBox();
            this.txtGrossDeposit = new System.Windows.Forms.TextBox();
            this.txtNetDeposit = new System.Windows.Forms.TextBox();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCalFee = new System.Windows.Forms.Button();
            this.labelIBANAlert = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIBAN
            // 
            this.txtIBAN.Location = new System.Drawing.Point(156, 30);
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(377, 27);
            this.txtIBAN.TabIndex = 0;
            this.txtIBAN.TextChanged += new System.EventHandler(this.txtIBAN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "IBAN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtGivenName);
            this.groupBox1.Controls.Add(this.txtFamilyName);
            this.groupBox1.Location = new System.Drawing.Point(47, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 199);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Given Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Family Name";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(109, 137);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(411, 27);
            this.txtEmail.TabIndex = 0;
            // 
            // txtGivenName
            // 
            this.txtGivenName.Location = new System.Drawing.Point(109, 92);
            this.txtGivenName.Name = "txtGivenName";
            this.txtGivenName.ReadOnly = true;
            this.txtGivenName.Size = new System.Drawing.Size(411, 27);
            this.txtGivenName.TabIndex = 0;
            // 
            // txtFamilyName
            // 
            this.txtFamilyName.Location = new System.Drawing.Point(109, 47);
            this.txtFamilyName.Name = "txtFamilyName";
            this.txtFamilyName.ReadOnly = true;
            this.txtFamilyName.Size = new System.Drawing.Size(411, 27);
            this.txtFamilyName.TabIndex = 0;
            // 
            // txtGrossDeposit
            // 
            this.txtGrossDeposit.Location = new System.Drawing.Point(156, 285);
            this.txtGrossDeposit.Name = "txtGrossDeposit";
            this.txtGrossDeposit.ReadOnly = true;
            this.txtGrossDeposit.Size = new System.Drawing.Size(369, 27);
            this.txtGrossDeposit.TabIndex = 4;
            this.txtGrossDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGrossDeposit.TextChanged += new System.EventHandler(this.txtGrossDeposit_TextChanged);
            // 
            // txtNetDeposit
            // 
            this.txtNetDeposit.Location = new System.Drawing.Point(156, 318);
            this.txtNetDeposit.Name = "txtNetDeposit";
            this.txtNetDeposit.ReadOnly = true;
            this.txtNetDeposit.Size = new System.Drawing.Size(369, 27);
            this.txtNetDeposit.TabIndex = 5;
            this.txtNetDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(345, 351);
            this.txtFee.Name = "txtFee";
            this.txtFee.ReadOnly = true;
            this.txtFee.Size = new System.Drawing.Size(180, 27);
            this.txtFee.TabIndex = 6;
            this.txtFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gross Deposit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Net Deposit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Deposit Fee";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(531, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "EUR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(531, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "EUR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(531, 358);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "EUR";
            // 
            // btnCalFee
            // 
            this.btnCalFee.Location = new System.Drawing.Point(379, 384);
            this.btnCalFee.Name = "btnCalFee";
            this.btnCalFee.Size = new System.Drawing.Size(146, 62);
            this.btnCalFee.TabIndex = 8;
            this.btnCalFee.Text = "Calculate Fee";
            this.btnCalFee.UseVisualStyleBackColor = true;
            this.btnCalFee.Click += new System.EventHandler(this.btnCalFee_Click);
            // 
            // labelIBANAlert
            // 
            this.labelIBANAlert.AutoSize = true;
            this.labelIBANAlert.ForeColor = System.Drawing.Color.Red;
            this.labelIBANAlert.Location = new System.Drawing.Point(156, 7);
            this.labelIBANAlert.Name = "labelIBANAlert";
            this.labelIBANAlert.Size = new System.Drawing.Size(112, 20);
            this.labelIBANAlert.TabIndex = 9;
            this.labelIBANAlert.Text = "IBAN not found";
            this.labelIBANAlert.Visible = false;
            // 
            // frmDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 485);
            this.Controls.Add(this.labelIBANAlert);
            this.Controls.Add(this.btnCalFee);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.txtNetDeposit);
            this.Controls.Add(this.txtGrossDeposit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIBAN);
            this.Name = "frmDeposit";
            this.Text = "frmDeposit";
            this.Load += new System.EventHandler(this.frmDeposit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtIBAN;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtEmail;
        private TextBox txtGivenName;
        private TextBox txtFamilyName;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox txtGrossDeposit;
        private TextBox txtNetDeposit;
        private TextBox txtFee;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnCalFee;
        private Label labelIBANAlert;
    }
}