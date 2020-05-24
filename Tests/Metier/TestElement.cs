using Microsoft.VisualStudio.TestTools.UnitTesting;
using Metier.Classes;
using Metier.Communs;
//using Metier.Interfaces;

namespace Tests.Metier
{
    [TestClass]
    public class TestElement
    {
        [TestMethod]
        public void Tester_Element_nom()
        {
            string nomAttendu = "ELEMENT";

            //act
            Element element = new Element(TypeElement.Element, nomAttendu, TypeNiveau.Normal,0);

            //assert
            string nomActuel = element.Nom;
            StringAssert.Contains(nomAttendu, nomActuel, "Erreur sur le nom");
        }

        [TestMethod]
        public void Tester_Element_Rang()
        {
            int rangAttendu = 10;

            //act
            Element element = new Element(TypeElement.Element, "", TypeNiveau.Normal, rangAttendu);

            //assert
            int rangActuel = element.Rang;
            Assert.AreEqual(rangAttendu, rangActuel, 0, "Erreur sur le rang");
        }

        [TestMethod]
        public void Tester_Element_AugmenterRang()
        {
            int rangAttendu = 15;

            //act
            Element element = new Element(TypeElement.Element, "", TypeNiveau.Normal, 10);

            //assert
            element.AugmenterRang(5);
            int rangActuel = element.Rang;
            Assert.AreEqual(rangAttendu, rangActuel, 0, "Erreur sur le rang");
        }

        [TestMethod]
        public void Tester_Element_AugmenterRang_echec()
        {
            int rangAttendu = 15;

            //act
            Element element = new Element(TypeElement.Element, "", TypeNiveau.Normal, 10);

            //assert
            element.AugmenterRang(1);
            int rangActuel = element.Rang;
            Assert.AreEqual(rangAttendu, rangActuel, 0, "Erreur sur le rang");
        }
    }
}
