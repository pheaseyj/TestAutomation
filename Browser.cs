using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Extensions;
using NUnit.Framework;
using System.Net.Mime;
using System.Threading;


namespace TestAutomation
{
    public static class Browser
    {

        private static IWebDriver webDriver = new ChromeDriver(@"D:\");


        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static ISearchContext Driver
        {
            get { return webDriver; }
        }

        public static void Goto(string url)
        {
            webDriver.Url = url;
        }

        public static void Close()
        {
            webDriver.Close();
            webDriver.Dispose();
        }


    }
}

