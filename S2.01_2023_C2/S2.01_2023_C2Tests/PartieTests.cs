global using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using S2._01_2023_C2;

namespace S2._01_2023_C2Tests
{
    [TestClass]
    public class PartieTests
    {
        [TestMethod]
        public void DonnerJetonsEnergieTest()
        {
            Partie partie = new Partie(1);

            // Dons de 10 jetons energie au joueur 1
            partie.DonnerJetonsEnergie(Partie.Joueurs[0],10);

            // Test si le stock de jetons energie a bien diminué
            Assert.AreEqual(80,partie.StockJetonsEnergie);

            // Test si le joueur 1 a bien reçu les 10 jetons energie
            Assert.AreEqual(20, Partie.Joueurs[0].jetonsEnergie);

            // Dons de 90 jetons energie au joueur 1, soit plus que ce que contient actuellement le stock
            partie.DonnerJetonsEnergie(Partie.Joueurs[0],90);

            // Test si le stock de jetons energie est vide
            Assert.AreEqual(0, partie.StockJetonsEnergie);

            // Test si le joueur 1 reçoit les derniers jetons du stock
            Assert.AreEqual(100, Partie.Joueurs[0].jetonsEnergie);
        }

        [TestMethod]
        public void DonnerJetonsEauTest()
        {
            Partie partie = new Partie(1);

            // Nombre de jetons energie du joueur 1 avant de lui en retirer
            Assert.AreEqual(10, Partie.Joueurs[0].jetonsEnergie);

            // Dons de 10 jetons eau au joueur 1
            partie.DonnerJetonsEau(Partie.Joueurs[0], 10);

            // Test si le stock de jetons eau a bien diminué
            Assert.AreEqual(80, partie.StockJetonsEau);

            // Test si le joueur 1 a bien reçu les 10 jetons eau
            Assert.AreEqual(20, Partie.Joueurs[0].jetonsEau);

            // Dons de 90 jetons eau au joueur 1, soit plus que ce que contient actuellement le stock
            partie.DonnerJetonsEau(Partie.Joueurs[0], 90);

            // Test si le stock de jetons eau est vide
            Assert.AreEqual(0, partie.StockJetonsEau);

            // Test si le joueur 1 reçoit les derniers jetons du stock
            Assert.AreEqual(100, Partie.Joueurs[0].jetonsEau);
        }

        [TestMethod]
        public void RetirerJetonsEnergieTest()
        {
            Partie partie = new Partie(1);

            // Nombre de jetons energie du joueur 1 avant de lui en retirer
            Assert.AreEqual(10, Partie.Joueurs[0].jetonsEnergie);

            // On retire 5 jetons energie au joueur 1
            partie.RetirerJetonsEnergie(Partie.Joueurs[0], 5);

            // Test si le joueur a bien 5 jetons energie restant
            Assert.AreEqual(5, Partie.Joueurs[0].jetonsEnergie);

            // Test si le stock de jetons energie est à jour
            Assert.AreEqual(95, partie.StockJetonsEnergie);
        }

        [TestMethod]
        public void RetirerJetonsEauTest()
        {
            Partie partie = new Partie(1);

            // Nombre de jetons eau du joueur 1 avant de lui en retirer
            Assert.AreEqual(10, Partie.Joueurs[0].jetonsEau);

            // On retire 5 jetons eau au joueur 1
            partie.RetirerJetonsEau(Partie.Joueurs[0], 5);

            // Test si le joueur a bien 5 jetons eau restant
            Assert.AreEqual(5, Partie.Joueurs[0].jetonsEau);

            // Test si le stock de jetons eau est à jour
            Assert.AreEqual(95, partie.StockJetonsEau);
        }

        [TestMethod]
        public void ProchainJoueurTest()
        {
            // Test avec 2 joueurs
            Partie partie = new Partie(2);
            
            // Test si le joueur 1 est bien le premier 
            partie.ProchainJoueur();
            Assert.AreEqual(partie.JoueurEnCours, Partie.Joueurs[0]);

            // Test si le joueur 2 est bien le prochain 
            partie.ProchainJoueur();
            Assert.AreEqual(partie.JoueurEnCours, Partie.Joueurs[1]);

            // Test si le joueur 1 meurt
            Partie.Joueurs[0].mort = true;
            partie.ProchainJoueur();

            // Le prochain joueur doit être le joueur 2 qui vient de jouer
            Assert.AreEqual(partie.JoueurEnCours, Partie.Joueurs[1]);
        }

        [TestMethod]
        public void AjouterPionPartieTest()
        {
            // Test avec 2 joueurs
            Partie partie = new Partie(2);

            // Test s'il y a bien 4 pions
            Assert.AreEqual(4,Partie.Pions.Count());

            // On ajoute un pion au joueur 1 et donc la partie
            Pion p = new Pion(Partie.Joueurs[0]);
            partie.AjouterPion(Partie.Joueurs[0]);

            // Test s'il y a bien 5 pions
            Assert.AreEqual(5, Partie.Pions.Count());
        }

    }
}
