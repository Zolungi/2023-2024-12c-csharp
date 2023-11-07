using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Kor;

namespace KorUnitTest
{
    [TestClass]
    public class KorTeszteles
    {
        [TestMethod]
        public void TeruletTeszt()
        {
            // Arange - Környezet beállítása
            // példányosítom az osztályt
            KorClass kr = new KorClass(3);
            // kr.setKerulet();
            kr.setTerulet();
            
            // Act - futtatás
            double vartEredm = 28.26;
            double kapottEredm = kr.getTerulet();

            // Assert - Kiértékelés
            Assert.AreEqual(vartEredm, kapottEredm);
        }
    }
}
