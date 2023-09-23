global using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using S2._01_2023_C2;

namespace S2._01_2023_C2Tests
{
    [TestClass]
    public class CarteTests
    {
        [TestMethod]
        public void TotalCartesTasefausseTest()
        {
            Joueur testJoueur1 = new Joueur("matias", CarteCouleur.BLEU);
            Carte.RemplissageDebutPartie();

            // Test s'il y'a bien 15 cartes dans la défause
            Carte.CarteDefausseParCouleur[CarteCouleur.ROUGE] = 5;
            Carte.CarteDefausseParCouleur[CarteCouleur.VERT] = 10;
            Assert.AreEqual(15, Carte.TotalCartesDefausse());

            // Test s'il y'a bien 25 cartes dans la défause
            Carte.CarteDefausseParCouleur[CarteCouleur.JAUNE] = 10;
            Assert.AreEqual(25, Carte.TotalCartesDefausse());
        }

        [TestMethod]
        public void TotalCartesTasTest()
        {
            // Test si le nombre total de cartes se met à jour dans le tas total
            Joueur testJoueur1 = new Joueur("matias", CarteCouleur.BLEU);
            Carte.RemplissageDebutPartie();
            Assert.AreEqual(100, Carte.TotalCartesTas());
            Carte.CartesTasParCouleur[CarteCouleur.JAUNE] = 3;
            Assert.AreEqual(83, Carte.TotalCartesTas());
        }

        [TestMethod]
        public void RemplissageDebutPartiTest()
        {
            Carte.RemplissageDebutPartie();
            Assert.AreEqual(20, Carte.CartesTasParCouleur[CarteCouleur.JAUNE]);
            Assert.AreEqual(20, Carte.CartesTasParCouleur[CarteCouleur.BLEU]);
            Assert.AreEqual(20, Carte.CartesTasParCouleur[CarteCouleur.ROUGE]);
            Assert.AreEqual(8, Carte.CartesTasParCouleur[CarteCouleur.NOIR]);
            Assert.AreEqual(20, Carte.CartesTasParCouleur[CarteCouleur.VERT]);
            Assert.AreEqual(10, Carte.CartesTasParCouleur[CarteCouleur.VIOLET]);
            Assert.AreEqual(2, Carte.CartesTasParCouleur[CarteCouleur.BLANC]);
        }

        [TestMethod]
        public void attribuerCouleurAleatoireTest()
        {
            Carte.RemplissageDebutPartie();
            Carte.CartesTasParCouleur[CarteCouleur.JAUNE] = 0;
            Carte.CartesTasParCouleur[CarteCouleur.BLEU] = 0;
            Carte.CartesTasParCouleur[CarteCouleur.ROUGE] = 0;
            Carte.CartesTasParCouleur[CarteCouleur.NOIR] = 0;
            Carte.CartesTasParCouleur[CarteCouleur.VERT] = 0;
            Carte.CartesTasParCouleur[CarteCouleur.VIOLET] = 0;
            Carte.CartesTasParCouleur[CarteCouleur.BLANC] = 1;
            Assert.AreEqual(CarteCouleur.BLANC, Carte.attribuerCouleurAleatoire());
            Assert.AreEqual(0, Carte.TotalCartesTas());
        }

        [TestMethod]
        public void TransfererDefausseVersTasTest()
        {
            Carte.RemplissageDebutPartie();
            Carte.CartesTasParCouleur[CarteCouleur.JAUNE] = 0;
            Carte.CartesTasParCouleur[CarteCouleur.BLEU] = 0;
            Carte.CartesTasParCouleur[CarteCouleur.ROUGE] = 0;
            Carte.CartesTasParCouleur[CarteCouleur.NOIR] = 0;
            Carte.CartesTasParCouleur[CarteCouleur.VERT] = 0;
            Carte.CartesTasParCouleur[CarteCouleur.VIOLET] = 0;
            Carte.CartesTasParCouleur[CarteCouleur.BLANC] = 0;
            Carte.CarteDefausseParCouleur[CarteCouleur.JAUNE] = 15;
            Carte.CarteDefausseParCouleur[CarteCouleur.BLEU] = 6;
            Carte.CarteDefausseParCouleur[CarteCouleur.ROUGE] = 12;
            Carte.CarteDefausseParCouleur[CarteCouleur.NOIR] = 6;
            Carte.CarteDefausseParCouleur[CarteCouleur.VERT] = 12;
            Carte.CarteDefausseParCouleur[CarteCouleur.VIOLET] = 2;
            Carte.CarteDefausseParCouleur[CarteCouleur.BLANC] = 2;
            Carte.TransfererDefausseVersTas();
            Assert.AreEqual(15, Carte.CartesTasParCouleur[CarteCouleur.JAUNE]);
            Assert.AreEqual(6, Carte.CartesTasParCouleur[CarteCouleur.BLEU]);
            Assert.AreEqual(12, Carte.CartesTasParCouleur[CarteCouleur.ROUGE]);
            Assert.AreEqual(6, Carte.CartesTasParCouleur[CarteCouleur.NOIR]);
            Assert.AreEqual(12, Carte.CartesTasParCouleur[CarteCouleur.VERT]);
            Assert.AreEqual(2, Carte.CartesTasParCouleur[CarteCouleur.VIOLET]);
            Assert.AreEqual(2, Carte.CartesTasParCouleur[CarteCouleur.BLANC]);
        }
    }
}