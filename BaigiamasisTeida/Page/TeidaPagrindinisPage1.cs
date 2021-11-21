using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisTeida.Page
{
    public class TeidaPagrindinisPage1: BasePage

    {
        private const string PageAddressPagrindinis = "https://www.teida.lt/";

      //  private IWebElement popUp => Driver.FindElement(By.CssSelector("body > div.cc-window.cc-banner.cc-type-opt-in.cc-theme-block.cc-bottom.cc-color-override--1214213648 > div > a.cc-btn.cc-allow"));
       // WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));


        private IWebElement ButtonPagrindinisPrisijungti => Driver.FindElement(By.Id("prisijungti"));
       
        public TeidaPagrindinisPage1(IWebDriver webdriver) : base(webdriver)   //kontruktorius
         { }  
        
        public TeidaPagrindinisPage1 NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddressPagrindinis)
                Driver.Url = PageAddressPagrindinis;
            return this;
        }

        /*ARBA TAIP
         public void TeidaPagrindinisPage1 ClickCookiesSutinku()
        {
           Cookies.Click();
            return this;
        }

        /*public TeidaPagrindinisPage1 AcceptCookie()
        {
           Cookie myCookie = new Cookie("Cookiesent", "{"www.teida.lt", "/"
        DateTime
        Driver.Manage().Cookies.AddCookie(myCookie);
        Driver.Navigate().Refresh();
         return this;

        }*/

        public TeidaPagrindinisPage1 ClickButtonPagrindinisPrisijungti()
        {
            ButtonPagrindinisPrisijungti.Click();
            return this;
        }





        }

}
