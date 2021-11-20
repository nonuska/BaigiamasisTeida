using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisTeida.Test
{
    public class TeidaTest : BaseTest
    {
        /* [Test]
        public void TeidaPagrindinis()
         {
             _teidaPagrindinisPage1.NavigateToDefaultPage()
             // pupOp() KAZKAIP APSIRASTTI
             //AcceptCookie();
             .ClickButtonPagrindinisPrisijungti();*/

        [TestCase("donatakursai@gmail.com", "donatakursainuotolinis", TestName = "Test New User Prisijungimas")]
        public void TestNewUserPrisijungimas(string elPastas, string slaptazodis)
        {
            _teidaPagrindinisPage1.NavigateToDefaultPage()
            // pupOp() KAZKAIP APSIRASTTI
            //AcceptCookie();
            .ClickButtonPagrindinisPrisijungti();
            _teidaPrisijungtiPage2.NavigateToDefaultPage()
             .ClickButtonPrisijungti();
            _teidaManoPaskyraPage3.NavigateToDefaultPage();
            _teidaPagrindinisPage1.NavigateToDefaultPage();



        }



        [Test]
        public void TestAtsijungti()
        {
            
            _teidaManoPaskyraPage3.NavigateToDefaultPage()
                
            .ClickButtonAtsijungti();
            //_teidaPagrindinisPage1.NavigateToDefaultPage();
            _teidaPrisijungtiPage2.NavigateToDefaultPage();


        }

    }
}
