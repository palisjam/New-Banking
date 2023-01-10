namespace WindowsBanking
{
    partial class frmTransfer
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
            this.txtOriginIBAN = new System.Windows.Forms.TextBox();
            this.txtOriginFamilyName = new System.Windows.Forms.TextBox();
            this.txtOriginGivenName = new System.Windows.Forms.TextBox();
            this.txtOriginEmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelOriginIBANAlert = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelDesIBANAlert = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDesIBAN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDesEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDesFamilyName = new System.Windows.Forms.TextBox();
            this.txtDesGivenName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOriginIBAN
            // 
            this.txtOriginIBAN.Location = new System.Drawing.Point(185, 37);
            this.txtOriginIBAN.Name = "txtOriginIBAN";
            this.txtOriginIBAN.Size = new System.Drawing.Size(269, 27);
            this.txtOriginIBAN.TabIndex = 0;
            this.txtOriginIBAN.TextChanged += new System.EventHandler(this.txtOriginIBAN_TextChanged);
            // 
            // txtOriginFamilyName
            // 
            this.txtOriginFamilyName.Location = new System.Drawing.Point(185, 70);
            this.txtOriginFamilyName.Name = "txtOriginFamilyName";
            this.txtOriginFamilyName.ReadOnly = true;
            this.txtOriginFamilyName.Size = new System.Drawing.Size(269, 27);
            this.txtOriginFamilyName.TabIndex = 1;
            // 
            // txtOriginGivenName
            // 
            this.txtOriginGivenName.Location = new System.Drawing.Point(185, 103);
            this.txtOriginGivenName.Name = "txtOriginGivenName";
            this.txtOriginGivenName.ReadOnly = true;
            this.txtOriginGivenName.Size = new System.Drawing.Size(269, 27);
            this.txtOriginGivenName.TabIndex = 2;
            // 
            // txtOriginEmail
            // 
            this.txtOriginEmail.Location = new System.Drawing.Point(185, 136);
            this.txtOriginEmail.Name = "txtOriginEmail";
            this.txtOriginEmail.ReadOnly = true;
            this.txtOriginEmail.Size = new System.Drawing.Size(269, 27);
            this.txtOriginEmail.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelOriginIBANAlert);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOriginIBAN);
            this.groupBox1.Controls.Add(this.txtOriginEmail);
            this.groupBox1.Controls.Add(this.txtOriginFamilyName);
            this.groupBox1.Controls.Add(this.txtOriginGivenName);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 180);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Origin";
            // 
            // labelOriginIBANAlert
            // 
            this.labelOriginIBANAlert.AutoSize = true;
            this.labelOriginIBANAlert.ForeColor = System.Drawing.Color.Red;
            this.labelOriginIBANAlert.Location = new System.Drawing.Point(185, 14);
            this.labelOriginIBANAlert.Name = "labelOriginIBANAlert";
            this.labelOriginIBANAlert.Size = new System.Drawing.Size(112, 20);
            this.labelOriginIBANAlert.TabIndex = 10;
            this.labelOriginIBANAlert.Text = "IBAN not found";
            this.labelOriginIBANAlert.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Given Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Family Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "IBAN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelDesIBANAlert);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDesIBAN);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDesEmail);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDesFamilyName);
            this.groupBox2.Controls.Add(this.txtDesGivenName);
            this.groupBox2.Location = new System.Drawing.Point(12, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 180);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination";
            // 
            // labelDesIBANAlert
            // 
            this.labelDesIBANAlert.AutoSize = true;
            this.labelDesIBANAlert.ForeColor = System.Drawing.Color.Red;
            this.labelDesIBANAlert.Location = new System.Drawing.Point(185, 14);
            this.labelDesIBANAlert.Name = "labelDesIBANAlert";
            this.labelDesIBANAlert.Size = new System.Drawing.Size(112, 20);
            this.labelDesIBANAlert.TabIndex = 10;
            this.labelDesIBANAlert.Text = "IBAN not found";
            this.labelDesIBANAlert.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(133, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Email";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDesIBAN
            // 
            this.txtDesIBAN.Location = new System.Drawing.Point(185, 37);
            this.txtDesIBAN.Name = "txtDesIBAN";
            this.txtDesIBAN.Size = new System.Drawing.Size(269, 27);
            this.txtDesIBAN.TabIndex = 0;
            this.txtDesIBAN.TextChanged += new System.EventHandler(this.txtDesIBAN_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Given Name";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Family Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDesEmail
            // 
            this.txtDesEmail.Location = new System.Drawing.Point(185, 136);
            this.txtDesEmail.Name = "txtDesEmail";
            this.txtDesEmail.ReadOnly = true;
            this.txtDesEmail.Size = new System.Drawing.Size(269, 27);
            this.txtDesEmail.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "IBAN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDesFamilyName
            // 
            this.txtDesFamilyName.Location = new System.Drawing.Point(185, 70);
            this.txtDesFamilyName.Name = "txtDesFamilyName";
            this.txtDesFamilyName.ReadOnly = true;
            this.txtDesFamilyName.Size = new System.Drawing.Size(269, 27);
            this.txtDesFamilyName.TabIndex = 1;
            // 
            // txtDesGivenName
            // 
            this.txtDesGivenName.Location = new System.Drawing.Point(185, 103);
            this.txtDesGivenName.Name = "txtDesGivenName";
            this.txtDesGivenName.ReadOnly = true;
            this.txtDesGivenName.Size = new System.Drawing.Size(269, 27);
            this.txtDesGivenName.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 416);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 27);
            this.textBox1.TabIndex = 5;
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 563);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTransfer";
            this.Text = "frmTransfer";
            this.Load += new System.EventHandler(this.frmTransfer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtOriginIBAN;
        private TextBox txtOriginFamilyName;
        private TextBox txtOriginGivenName;
        private TextBox txtOriginEmail;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label8;
        private TextBox txtDesIBAN;
        private Label label7;
        private Label label6;
        private TextBox txtDesEmail;
        private Label label5;
        private TextBox txtDesFamilyName;
        private TextBox txtDesGivenName;
        private TextBox textBox1;
        private Label labelOriginIBANAlert;
        private Label labelDesIBANAlert;
    }
}