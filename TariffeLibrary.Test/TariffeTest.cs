using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TariffeLibrary.Test
{
    [TestClass]
    public class TariffeTest
    {
        [DataTestMethod]
        [DataRow(10, "115.99 al mese")]
        [DataRow(48, "99.99 al mese")]
        [DataRow(200, "79.99 al mese")]
        public void TestTariffeMesi(int giorni, string valore_aspettato)
        {         
            string prova = Gestione.VisualizzaTariffa(giorni);
            Assert.AreEqual(valore_aspettato, prova);
        }       
    }
}
