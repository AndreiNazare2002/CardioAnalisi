using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio.Test
{
    [TestClass]
    public class DataCardioTest
    {
        [DataTestMethod]
        [DataRow(-1, "Errore")]
        [DataRow(0, "Errore")]

        public void TestMethod_ControlloDati1(int Variabile1, string Variabile2)
        {
            string Risultato = CardioAnalisiLibrary.DataCardio.ControlloInserimenti(Variabile1);

            Assert.AreEqual(Risultato, Variabile2);
        }


        //Testo il metodo per il controllo dei dati double
        [DataTestMethod]
        [DataRow(-1.2, -2.8, -2.7, -7.9, "Errore")]

        public void TestMethod_ControlloDati2(double Variabile1, double Variabile2, double Variabile3, double Variabile4, string Variabile5)
        {
            string Risultato = CardioAnalisiLibrary.DataCardio.ControlloInserimenti2(Variabile1, Variabile2, Variabile3, Variabile4);

            Assert.AreEqual(Risultato, Variabile5);
        }


        //Testo il metodo sui controlli dei dati double2
        [DataTestMethod]
        [DataRow(-1, 0, "Errore")]
        [DataRow(0, -3, "Errore")]

        public void TestMethod_ControlloDati3(double Variabile1, double Variabile2, string Variabile3)
        {
            string Risultato = CardioAnalisiLibrary.DataCardio.ControlloInserimenti3(Variabile1, Variabile2);

            Assert.AreEqual(Risultato, Variabile3);
        }

  

        //Testo il metodo della frequenza max
        [DataTestMethod]
        [DataRow(18, 202)]
        [DataRow(90, 130)]
        [DataRow(5, 215)]

        public void TestMethod_FrequenzaMax(int Variabile1, int Variabile2)
        {
            int Risultato = CardioAnalisiLibrary.DataCardio.CalcoloFrequenzaMax(Variabile1);

            Assert.AreEqual(Risultato, Variabile2);
        }


        //Testo il metodo per i battiti efficaci massimi
        [DataTestMethod]
        [DataRow(18, 181)]
        [DataRow(90, 117)]
        [DataRow(5, 193)]

        public void TestMethod_BattitiMax(int Variabile1, double Variabile2)
        {
            double Risultato = CardioAnalisiLibrary.DataCardio.CalcoloBattitiEfficaciMassimi(Variabile1);

            Assert.AreEqual(Risultato, Variabile2);
        }


        //Testo il metodo per i battiti efficaci minimi
        [DataTestMethod]
        [DataRow(40, 126)]
        [DataRow(90, 91)]
        [DataRow(10, 147)]

        public void TestMethod_BattitiMin(int Variabile1, double Variabile2)
        {
            double Risultato = CardioAnalisiLibrary.DataCardio.CalcoloBattitiEfficaciMinimi(Variabile1);

            Assert.AreEqual(Risultato, Variabile2);
        }
    }
}
