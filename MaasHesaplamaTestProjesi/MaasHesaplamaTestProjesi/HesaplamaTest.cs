using System;
using Hesaplayici;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaasHesaplamaTestProjesi
{
    /*
     Saatlik kazanç için yıllığı 2080 e böl => 100,006.40 / 2080 = 48.08 saatlik
    
        

     Yıllık kazanç için saatlik kazancı 2080 ile çarp => 48.08 * 2080 = 100,006.40 
    */
    [TestClass]
    public class HesaplamaTest
    {
        [TestMethod]
        public void YillikKazancTesti()
        {
            //Arrange
            MaasHesaplayici mh = new MaasHesaplayici();

            //Act
            decimal yillikKazanc = mh.GetYillikKazanc(50);

            //Assert
            Assert.AreEqual(104000, yillikKazanc);
        }

        [TestMethod]
        public void SaatlikKazancTesti()
        {
            //Arrange
            MaasHesaplayici mh = new MaasHesaplayici();

            //Act
            decimal saatlikKazanc = mh.GetSaatlikKazanc(52000);

            //Assert
            Assert.AreEqual(25, saatlikKazanc);
        }
    }
}
