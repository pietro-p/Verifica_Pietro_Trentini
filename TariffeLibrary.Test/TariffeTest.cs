using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TariffeLibrary.Test
{
    [TestClass]
    public class TariffeTest
    {
        [DataTestMethod]
        [DataRow(10, "Un mese a 115.99")]
        [DataRow(48, "Tre mesi 99.99 al mese")]
        [DataRow(200, "Dodici mesi 79.99 al mese")]
        public void TestTariffeMesi(int giorni, string valore_aspettato)
        {         
            string prova = Gestione.VisualizzaTariffa(giorni);
            Assert.AreEqual(valore_aspettato, prova);
        }       
    }
}
