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
               
             //.PrisijungtiElPastasAndSlaptazodis(elPastas, slaptazodis)
            

            // .PrisijungtiElPastasAndSlaptazodis(elPastas, slaptazodis)
            //.ClickButtonPrisijungti();
            _teidaManoPaskyraPage3.NavigateToDefaultPage();
            _teidaPagrindinisPage1.NavigateToDefaultPage();
               
            

        }

         /*[TestCase("donatakursai@gmail.com", "donatakursainuotolinis", TestName = "Test New User Prisijungimas")]

         public void TestNewUserPrisijungimas(string elPastas, string slaptazodis)
         {
             _teidaPrisijungtiPage2.NavigateToDefaultPage()
             .InsertElPastasAndSlaptazodis(elPastas, slaptazodis)
             .ClickButtonPrisijungti();
             //.CleckButtonPrisijungti();
         }*/
       /* [Test]
        public void TeidaManoPaskyraPage3()
        {

            _teidaManoPaskyraPage3.NavigateToDefaultPage();
        }*/

        
    }
}
