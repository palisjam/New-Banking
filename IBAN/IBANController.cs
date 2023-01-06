using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace IBAN
{
    public class IBANController
    {
        private WebDriverWait wait;
        private IWebDriver driver;
        public IBANController() {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments(new List<string>() {
                "--silent-launch",
                "--no-startup-window",
                "no-sandbox",
                "headless",});

            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;

            driver = new ChromeDriver(chromeDriverService, chromeOptions);
            driver.Url = "http://randomiban.com/?country=Netherlands";
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(0));
        }
        public string GetIBAN()
        {
            try
            {                
                IWebElement firstResult = wait.Until(e => e.FindElement(By.ClassName("ibandisplay")));
                var gen_button = driver.FindElement(By.Id("gen_button"));
                gen_button.Click();
                return firstResult.Text;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

    }
}