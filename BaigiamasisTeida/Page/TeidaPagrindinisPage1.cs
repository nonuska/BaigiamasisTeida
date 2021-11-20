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
        private IWebElement ButtonPrisijungti => Driver.FindElement(By.Id("prisijungti"));
        
        // private IWebElement PopUp => Driver.FindElement(By.Id("___$_11__close ___$_11__close"));

        //private IWebElement LaukeliIrasyti => Driver.FindElement(By.Id("searchParam"));
        //private IWebElement PrekesPaieska => Driver.FindElement(By.Id("search_icon"));
        public TeidaPagrindinisPage1(IWebDriver webdriver) : base(webdriver)
        {
           
        }
        public TeidaPagrindinisPage1 NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddressPagrindinis)
                Driver.Url = PageAddressPagrindinis;
            return this;
        }

        /*public TeidaPagrindinisPage1 ClosePopUp()
        {
            PopUp.Click();
            return this;
        }*/
        
        public TeidaPagrindinisPage1 ClickButtonPrisijungti()
        {
            ButtonPrisijungti.Click();
            return this;
        }






    }

}
