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
        [Test]
        public void TeidaPagrindinis()
        {
            _teidaPagrindinisPage1.NavigateToDefaultPage()
            // pupOp() KAZKAIP APSIRASTTI
            .ClickButtonPrisijungti();
        }

        [TestCase("donatakursai@gmail.com", "donatakursainuotolinis", TestName = "Test New User Prisijungimas")]

        public void TestNewUserPrisijungimas(string elPastas, string slaptazodis)
        {
            _teidaPrisijungtiPage2.NavigateToDefaultPage()
            .InsertElPastasAndSlaptazodis(elPastas, slaptazodis)
            .ClickButtonPrisijungti();
            //.CleckButtonPsisijungti();
        }
        [Test]
        public void TeidaManoPaskyraPage3()
        {

            _teidaManoPaskyraPage3.NavigateToDefaultPage();
        }

        
    }
}
