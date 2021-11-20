using NUnit.Framework;
using OpenQA.Selenium;
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
        private IWebElement ButtonPagrindinisPrisijungti => Driver.FindElement(By.Id("prisijungti"));
       // private IWebElement registruotas =>Driver.FindElement(By.Id("registerLink"));
        // private IWebElement Cookies => Driver.FindElement(By.Id("___$_11__close ___$_11__close"));

        //private IWebElement LaukeliIrasyti => Driver.FindElement(By.Id("searchParam"));
        //private IWebElement PrekesPaieska => Driver.FindElement(By.Id("search_icon"));
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
        // KAIP TA ASSERT PARASYTI
        /* public TeidaPagrindinisPage1 CheckButtonPsisijungti()
         {

             Assert.IsTrue(ButtonPagrindinisPrisijungti.Text.Contains(expectedResult), "Nepavyko prisijungti");
             return this;
         }
        */

       /* public TeidaPagrindinisPage1 CheckButtonAtsijungti()
        {

            OpenTeidaManoPaskyraPage3();
            ButtonAtsijungti.Click();
            return this;
        }*/





        }

}
