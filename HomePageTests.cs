using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using TestAutomation;

namespace SeleniumTests
{
    [TestFixture]
    public class HomePageTests
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true; 
        private string site = "https://www.proventeq.com/";

        [SetUp]
        public void Setup()
        {
            Browser.Goto(site);
        }

        [TearDown]
        public void TeardownTest()
        {
            try { driver.Quit(); }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
           // Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void CheckProductPageOpens()
        {
            Helper.ClickByLinkText("Products");

            Helper.AssertTextOnCssElement("Proventeq Products", ResourceCSS.Header);
            
        }

        [Test]
        public void CheckAboutUsPageOpens()
        {
            Helper.ClickByLinkText("About");
            Helper.ClickByLinkText("About Us");

            Helper.AssertTextOnCssElement("About us", ResourceCSS.Header);
            
        }

        [Test]
        public void CheckSupportPageOpens()
        {
            Helper.ClickByLinkText("Support");
            Helper.AssertTextOnCssElement("Proventeq Product Support", ResourceCSS.Header);

        }


        [Test]
        public void SubmitContactRequest()
        {
            Helper.ClickByLinkText("Contact");
            Helper.AssertTextOnCssElement("Contact Our Team", ResourceCSS.Header);
            Helper.ClickClearEnterTextByCss(ResourceCSS.ContactName, "Jon");
            Helper.ClickClearEnterTextByCss(ResourceCSS.ContactLastName, "Smith");
            Helper.ClickClearEnterTextByCss(ResourceCSS.ContactEmail, "test@test.jp");
            Helper.ClickClearEnterTextByCss(ResourceCSS.ContactOrg, "testing");
            Helper.ClickClearEnterTextByCss(ResourceCSS.ContactPhone, "01234567891");
            Helper.ClickClearEnterTextByCss(ResourceCSS.ContactMessage, "Hello");
            Helper.ClickByCss(ResourceCSS.ContactSubmit);
            Helper.WaitAssertTextOnCssElement("Thank you for contacting us", ResourceCSS.Header);

        }
        

    }
}
