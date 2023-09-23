global using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using S2._01_2023_C2;

namespace S2._01_2023_C2Tests
{
    [TestClass]
    public class SecteurTests
    {
         
        [TestMethod]
        public void AjouterPionSecteurTest()
        {
            Secteur testSecteur = new Secteur(ListeSecteurs.SalleMachine, 2, null);
            Joueur testJoueur1 = new Joueur();

            // Ajout de deux pions du joueur au Secteur SalleMachine
            for (int i = 0; i < 5; i++)
            {
                if(!testSecteur.Surchage())
                {
                    testSecteur.AjouterPion(new Pion(testJoueur1));
                }
            }

            // Test si le nombre de pions est correct 
            Assert.AreEqual(testSecteur.PionsPresents.Count(),2);

            // Test si le nombre de joueurs est correct
            Assert.AreEqual(testSecteur.JoueursPresents.Count(), 1);

            // Test s'il n'y a pas 2 joueurs 
            Assert.AreNotEqual(testSecteur.JoueursPresents.Count(), 2);
        }

        [TestMethod]
        public void RetirerUnPionDuSecteurTest()
        {
            // Test avec un joueur
            Secteur testSecteur = new Secteur(ListeSecteurs.SalleMachine, 2, null);
            Joueur testJoueur1 = new Joueur("matias", CarteCouleur.BLEU);
            testSecteur.AjouterPion(new Pion(testJoueur1));
            testSecteur.AjouterPion(new Pion(testJoueur1));

            // Test si le nombre de pions et de joueurs est correct avant de retirer
            Assert.AreEqual(testSecteur.PionsPresents.Count(), 2);
            Assert.AreEqual(testSecteur.JoueursPresents.Count(), 1);


            // Test si le nombre de pions est diminué de 1 après avoir retirer
            testSecteur.RetirerPion(testJoueur1.Pions[0]);
            Assert.AreEqual(testSecteur.PionsPresents.Count(), 1);

            // Test si le joueur est toujours présent dans la liste du secteur SalleMachine
            Assert.AreEqual(testSecteur.JoueursPresents.Count(), 1);

            // Test si la liste de pions/joueurs du secteur SalleMachine est vide après avoir retiré le dernier pion présent
            testSecteur.RetirerPion(testJoueur1.Pions[1]);
            Assert.AreEqual(testSecteur.PionsPresents.Count(),testSecteur.JoueursPresents.Count());
            Assert.AreEqual(testSecteur.JoueursPresents.Count(),0);
            Assert.AreEqual(testSecteur.PionsPresents.Count(),0);

            // Test avec 2 joueurs
            Secteur testSecteur2 = new Secteur(ListeSecteurs.CentreRecyclage, 4, null);
            Joueur testJoueur2 = new Joueur("justin", CarteCouleur.ROUGE);
            Joueur testJoueur3 = new Joueur("nicolas", CarteCouleur.VERT);

            //Ajout des 4 pions 
            testSecteur2.AjouterPion(new Pion(testJoueur2));
            testSecteur2.AjouterPion(new Pion(testJoueur2));
            testSecteur2.AjouterPion(new Pion(testJoueur3));
            testSecteur2.AjouterPion(new Pion(testJoueur3));

            // Test s'il y'a bien 4 pions et 2 joueurs
            Assert.AreEqual(testSecteur2.PionsPresents.Count(), 4);
            Assert.AreEqual(testSecteur2.JoueursPresents.Count(), 2);

            // Test si on retire un pion de chaque joueurs au secteur
            testSecteur2.RetirerPion(testJoueur2.Pions[0]);
            testSecteur2.RetirerPion(testJoueur3.Pions[0]);
            Assert.AreEqual(testSecteur2.PionsPresents.Count(),2);
            Assert.AreEqual(testSecteur2.JoueursPresents.Count(), 2);

            // Test si le joueur et son pion disparaissent des listes du secteur si on retire le dernier pion pour un joueur
            testSecteur2.RetirerPion(testJoueur2.Pions[1]);
            Assert.AreEqual(testSecteur2.PionsPresents.Count(), 1);
            Assert.AreEqual(testSecteur2.JoueursPresents.Count(), 1);
        }

        [TestMethod]
        public void SurchageTest()
        {
            Secteur testSecteur = new Secteur(ListeSecteurs.SalleMachine, 2, null);
            Joueur testJoueur1 = new Joueur("matias", CarteCouleur.BLEU);

            //Test si le secteur n'est pas surchargé
            Assert.IsFalse(testSecteur.Surchage());

            //Test quand le secteur est surchargé
            testSecteur.AjouterPion(new Pion(testJoueur1));
            testSecteur.AjouterPion(new Pion(testJoueur1));
            Assert.IsTrue(testSecteur.Surchage());
        }

    }
}