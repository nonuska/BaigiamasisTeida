using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using BaigiamasisTeida.Drivers;
using BaigiamasisTeida.Page;
using BaigiamasisTeida.Tools;

namespace BaigiamasisTeida.Test
{
    public class BaseTest
    {
        public static IWebDriver driver;
        public static TeidaPagrindinisPage1 _teidaPagrindinisPage1;
        public static TeidaPrisijungtiPage2 _teidaPrisijungtiPage2;
        public static TeidaManoPaskyraPage3 _teidaManoPaskyraPage3;

      // public static AlertPage _alertPage;



        [OneTimeSetUp]
        public static void SetUp()
        {
            driver = CustomDriver.GetChromeDriver();
            //driver = CustomDriver.GetIncognitoChrome();

            _teidaPagrindinisPage1 = new TeidaPagrindinisPage1(driver);
            _teidaPrisijungtiPage2 = new TeidaPrisijungtiPage2(driver);
            _teidaManoPaskyraPage3 = new TeidaManoPaskyraPage3(driver);

           
            //_alertPage = new AlertPage(driver);
        }

        [TearDown]

        public static void TakeScreenshot()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
                MyScreenshot.MakeScreenshot(driver);
        }

        [OneTimeTearDown]

        public static void TearDown()
        {
            driver.Quit();
        }
    }
}