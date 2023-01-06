using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Security.Policy;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WindowsBanking
{
    public partial class Form1 : Form
    {
        private FirestoreDb _db;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + @"banking-70155-firebase-adminsdk-3l81z-9166058a80.json";
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
                _db = FirestoreDb.Create("banking-70155");
                GetIBAN();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string msg = "";
            CreateAccount(out msg);
            MessageBox.Show(msg);
            GetIBAN();
        }

        private bool CreateAccount(out string msg)
        {
            if (!String.IsNullOrEmpty(txtIBAN.Text))
                { 
                DocumentReference collection = _db.Collection("account").Document(txtIBAN.Text);
                Dictionary<string, object> account = new Dictionary<string, object>()
                {
                    { "FamilyName",txtFamilyName.Text},
                    {"GivenName",txtGivenName.Text},
                    {"email",txtEmailAddress.Text}
                };
                collection.SetAsync(account);
                msg = "Account successfully created";
                return true;
            }
            else
            {
                msg = "Create account unsuccessful";
                return false;
            }
        }

        private void GetIBAN()
        {
            try
            {
                using (IWebDriver driver = new ChromeDriver())
                {
                    driver.Url = "http://randomiban.com/?country=Netherlands";
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(0));
                    IWebElement firstResult = wait.Until(e => e.FindElement(By.ClassName("ibandisplay")));
                    txtIBAN.Text = firstResult.Text;

                }
            }
            catch (Exception ex)
            {
                txtIBAN.Text = "";
                Console.WriteLine(ex.Message);
            }
        }
    }
}