global using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using S2._01_2023_C2;

namespace S2._01_2023_C2Tests
{
    [TestClass]
    public class JoueurTests
    {
        [TestMethod]
        public void ViderCartesTest()
        {
            Joueur testJoueur1 = new Joueur("matias", CarteCouleur.BLEU);
            // Test si le joueur a à sa disposition les 7 types de cartes
            Assert.AreEqual(testJoueur1.CartesParCouleur.Keys.Count(), 7);

            // Test si le joueur pose ses cartes dans la défausse
            Carte.RemplissageDebutPartie();

            //On donne 2 cartes bleues/3 cartes jaunes au joueur 
            testJoueur1.CartesParCouleur[CarteCouleur.JAUNE] = 3; 
            testJoueur1.CartesParCouleur[CarteCouleur.BLEU] = 2;

            //On met les cartes dans la défausse puis on les retirent au joueur
            testJoueur1.ViderCartes();

            // On vérifie que la défausse contient bien les cartes du joueur
            Assert.AreEqual(3, Carte.CarteDefausseParCouleur[CarteCouleur.JAUNE]);
            Assert.AreEqual(2, Carte.CarteDefausseParCouleur[CarteCouleur.BLEU]);

            // On vérifie que le joueur a bien perdu ses cartes
            Assert.AreEqual(0,testJoueur1.CartesParCouleur[CarteCouleur.JAUNE]);
            Assert.AreEqual(0, testJoueur1.CartesParCouleur[CarteCouleur.BLEU]);
        }

        [TestMethod] 
        public void NombreCouleurCarteDuJoueurTest()
        {
            Joueur testJoueur1 = new Joueur("matias", CarteCouleur.BLEU);
            Carte.RemplissageDebutPartie();

            // On donne 2 cartes bleues/3 cartes jaunes au joueur 
            testJoueur1.CartesParCouleur[CarteCouleur.JAUNE] = 3;
            testJoueur1.CartesParCouleur[CarteCouleur.BLEU] = 2;

            // Test si le joueur a bien 3 cartes jaunes
            Assert.AreEqual(3,testJoueur1.NombreCouleurCarteDuJoueur(CarteCouleur.JAUNE));

            // Test si le joueur a bien 2 cartes bleues
            Assert.AreEqual(2, testJoueur1.NombreCouleurCarteDuJoueur(CarteCouleur.BLEU));
        }

        [TestMethod]
        public void NombreCartesTotalTest()
        {
            Joueur testJoueur1 = new Joueur("matias", CarteCouleur.BLEU);
            Carte.RemplissageDebutPartie();

            // On donne 2 cartes bleues/3 cartes jaunes au joueur 
            testJoueur1.CartesParCouleur[CarteCouleur.JAUNE] = 10;
            testJoueur1.CartesParCouleur[CarteCouleur.BLEU] = 10;

            // Test si le nombre total de cartes du joueur
            Assert.AreEqual(20, testJoueur1.NombreCartesTotal());
        }


        [TestMethod]
        public void PiocherCarteTest()
        {
            Joueur testJoueur1 = new Joueur("matias", CarteCouleur.BLEU);
            Carte.RemplissageDebutPartie();
    
            // Avant de piocher
            foreach(CarteCouleur c in testJoueur1.CartesParCouleur.Keys)
            {
                Assert.AreEqual(0, testJoueur1.CartesParCouleur[c]);
            }
            Carte.RemplissageDebutPartie();
            Assert.AreEqual(100, Carte.TotalCartesTas());
            
            // Après avoir piocher
            testJoueur1.Piocher2Carte();
            Assert.AreEqual(98, Carte.TotalCartesTas());
        }
    }
}
    
