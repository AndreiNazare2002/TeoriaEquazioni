using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
                    [TestMethod]
        public void Determinato1()
        {
            double a = 1;
            double b = 0;
            bool resultato = true;
            bool determinate = EquazioniLibrary.Equazioni.IsDetermined(a, b);
            Assert.AreEqual(resultato, determinate);
        }
        [TestMethod]
        public void Determinato2()
        {
            double a = 0;
            double b = 0;
            bool resultato = false;
            bool determinate = EquazioniLibrary.Equazioni.IsDetermined(a, b);
            Assert.AreEqual(resultato, determinate);
        }
        [TestMethod]
        public void Determinato3()
        {
            double a = -1;
            double b = 0;
            bool resultato = true;
            bool determinate = EquazioniLibrary.Equazioni.IsDetermined(a, b);
            Assert.AreEqual(resultato, determinate);
        }

        [TestMethod]
        public void Impossibile1()
        {
            double a = 1;
            double b = 0;
            bool resultato = false;
            bool determinate = EquazioniLibrary.Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(resultato, determinate);
        }
        [TestMethod]
        public void Impossibile3()
        {
            double a = -1;
            double b = 0;
            bool resultato = false;
            bool determinate = EquazioniLibrary.Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(resultato, determinate);
        }

        [TestMethod]
        public void Impossibile2()
        {
            double a = 0;
            double b = 0;
            bool resultato = true;
            bool determinate = EquazioniLibrary.Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(resultato, determinate);
        }
        [TestMethod]
        public void Secondogrado1()
        {
            double a = 0;
            bool resultato = false;
            bool determinate = EquazioniLibrary.Equazioni.IsDegree2(a);
            Assert.AreEqual(resultato, determinate);
        }
        [TestMethod]
        public void Secondogrado2()
        {
            double a = 1;
            bool resultato = true;
            bool determinate = EquazioniLibrary.Equazioni.IsDegree2(a);
            Assert.AreEqual(resultato, determinate);
        }
        [TestMethod]
        public void Secondogrado3()
        {
            double a = -1;
            bool resultato = true;
            bool determinate = EquazioniLibrary.Equazioni.IsDegree2(a);
            Assert.AreEqual(resultato, determinate);
        }
        [TestMethod]
        public void Delta1()
        {
            double a = 4;
            double b = 6;
            double c = 8;
            double resultato = -92;
            double determinate = EquazioniLibrary.Equazioni.Delta(a, b, c);
            Assert.AreEqual(resultato, determinate);
        }
        [TestMethod]
        public void Delta2()
        {
            double a = 0;
            double b = 0;
            double c = 0;
            double resultato = 0;
            double determinate = EquazioniLibrary.Equazioni.Delta(a, b, c);
            Assert.AreEqual(resultato, determinate);
        }
        [TestMethod]
        public void Delta3()
        {
            double a = 0;
            double b = 4;
            double c = 2;
            double resultato = 16;
            double determinate = EquazioniLibrary.Equazioni.Delta(a, b, c);
            Assert.AreEqual(resultato, determinate);
        }
        [TestMethod]
        public void Delta4()
        {
            double a = 1;
            double b = 0;
            double c = 2;
            double resultato = -8;
            double determinate = EquazioniLibrary.Equazioni.Delta(a, b, c);
            Assert.AreEqual(resultato, determinate);
        }
        [TestMethod]
        public void DeltanulloA()
        {
            double b = 4;
            double c = 2;
            string resultato = "Errore !! A non eziste";
            string testresultato = "";
            double determinate = EquazioniLibrary.Equazioni.Deltanullo(b, c);
            if (determinate == 0) testresultato = "Errore !! A non eziste";
            Assert.AreEqual(resultato, testresultato);
        }
        [TestMethod]

        public void EquationDegree2()
        {
            double a = 0, b = 3;
            string risposta_attesa = "Impossibile";
            string test = EquazioniLibrary.Equazioni.EquationDegree(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]

        public void EquationDegree3()
        {
            double a = 1, b = 3;

            string risposta_attesa = "Indeterminato";
            string test = EquazioniLibrary.Equazioni.EquationDegree(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }

        [TestMethod]

        public void EquationDegree4()
        {
            double a = 1, b = -3;

            string risposta_attesa = "Indeterminato";
            string test = EquazioniLibrary.Equazioni.EquationDegree(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }





    }
}

        
    

