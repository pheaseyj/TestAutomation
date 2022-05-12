using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace TestAutomation
{
    internal class Helper
    {
        private static object verificationErrors;

        internal static void ClickClearEnterTextByCss(string element, string text)
        {
            Browser.Driver.FindElement(By.CssSelector(element)).Click();
            Browser.Driver.FindElement(By.CssSelector(element)).Clear();
            Browser.Driver.FindElement(By.CssSelector(element)).SendKeys(text);
        }

        internal static void ClickById(string element)
        {
            Browser.Driver.FindElement(By.Id(element)).Click();
        }

        internal static void GotoSite(string site)
        {
            Browser.Goto(site);
        }

        internal static void ClickByCss(string element)
        {
            Browser.Driver.FindElement(By.CssSelector(element)).Click();
        }

        internal static void ClickByLinkText(string element)
        {
            Browser.Driver.FindElement(By.LinkText(element)).Click();
        }

        internal static void AssertTextOnCssElement(string text, string element)
        {
           
            Assert.AreEqual(text, Browser.Driver.FindElement(By.CssSelector(element)).Text);
           
        }

        internal static void WaitAssertTextOnCssElement(string text, string element)
        {
            Thread.Sleep(2000); //Very dirty, it's late!
            Assert.AreEqual(text, Browser.Driver.FindElement(By.CssSelector(element)).Text);
           
        }

        internal static void TryCatch(string element, string text)
        {
            //try
            //{
            Assert.AreEqual(text, Browser.Driver.FindElement(By.CssSelector(element)).Text);
            //}
            //catch (AssertionException e)
            //{
            //    object p = verificationErrors.Append(e.Message);
            //}
        }

        //internal static void AcceptCookies(string element)
        //{
        //    System.Thread.sleep(100);
        //    Browser.Driver.FindElement(By.CssSelector("#onetrust-accept-btn-handler")).Click();
        //}
        private bool IsElementPresent(By by)
        {
            try
            {
                Browser.Driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

       
    }
}
