using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisTeida.Page
{
    public class TeidaManoPaskyraPage3 : BasePage
    {
        public const string PageAddressManoPaskyra = "https://www.teida.lt/index.php?force_sid=j89335da10gek1vv7a4446vof6&";
     

        private IWebElement ManoPaskyra => Driver.FindElement(By.CssSelector("#content > div.catTitleContent.bold"));

        public TeidaManoPaskyraPage3(IWebDriver webdriver) : base(webdriver)
        { }

        public TeidaManoPaskyraPage3 NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddressManoPaskyra)
                Driver.Url = PageAddressManoPaskyra;
            return this;
        }




    }
}
