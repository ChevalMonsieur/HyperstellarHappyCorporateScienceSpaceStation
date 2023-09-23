using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace S2._01_2023_C2
{
    public class Joueur
    {
        public string Nom { get; set; }

        public CarteCouleur CouleurJoueur { get; set; }

        public List<Pion> Pions { get; set; }

        public int StockPions { get; set; }

        public Dictionary<CarteCouleur, int> CartesParCouleur;

        public int jetonsEau;

        public int jetonsEnergie;

        public int pointsVictoire;

        public bool mort;

        /// <summary>
        /// Constructeur de Joueur qui initialise les attributs
        /// les joueurs ont des noms et couleurs différentes
        /// ils ont un stock de jetons energie, jetons eau et points victoire
        /// les joueurs peuvent choisir des bonus, deplacer leur pions dans des secteurs et utiliser des cartes
        /// </summary>
        /// <param name="name"></param> le nom du joueur
        /// <param name="couleurJoueur"></param> sa couleur
        public Joueur(string name, CarteCouleur couleurJoueur)
        {
            Nom = name;
            CouleurJoueur = couleurJoueur;
            CartesParCouleur = new Dictionary<CarteCouleur, int>();
            AucuneCarte();
            Pions = new List<Pion>();
            pointsVictoire = 0;
            StockPions = 10;
            mort = false;
        }

        /// <summary>
        /// Utilisée lors de la mort d'ub joueur, elle vide ses cartes et les remet dans la défausse
        /// </summary>
        public void ViderCartes()
        {
            foreach (CarteCouleur cc in Carte.carteList)
            {
                Carte.CarteDefausseParCouleur[cc] += CartesParCouleur[cc];
                CartesParCouleur[cc] = 0;
            }
        }

        /// <summary>
        /// Crée un Joueur qui sert de test pour du debug et des ajouts de fonctionnalités
        /// </summary>
        public Joueur()
        {
            //Test Pour creer un joueur facilement
            Nom = "JoueurTest";
            CouleurJoueur = CarteCouleur.VERT;
            CartesParCouleur = new Dictionary<CarteCouleur, int>();
            CertainesCartes();
            Pions = new List<Pion>();
            jetonsEau = 10;
            jetonsEnergie = 10;
            pointsVictoire = 19;
        }

        /// <summary>
        /// retourne le nombre de cartes total du joueur
        /// </summary>
        /// <returns></returns>
        public int NombreCartesTotal()
        {
            int res = 0;
            foreach (CarteCouleur cc in CartesParCouleur.Keys)
            {
                res += CartesParCouleur[cc];
            }
            return res;
        }

        /// <summary>
        /// pioche 2 cartes de couleur aléatoire et les ajoute au joueur
        /// </summary>
        public void Piocher2Carte()
        {
            CarteCouleur cc = Carte.attribuerCouleurAleatoire();
            CartesParCouleur[cc]++;
            cc = Carte.attribuerCouleurAleatoire();
            CartesParCouleur[cc]++;
            
        }

        /// <summary>
        /// initialise le dictionnaire de cartes à 0 pour toutes les couleurs
        /// </summary>
        private void AucuneCarte()
        {
            CartesParCouleur.Clear();
            CartesParCouleur.Add(CarteCouleur.JAUNE, 0);
            CartesParCouleur.Add(CarteCouleur.BLEU, 0);
            CartesParCouleur.Add(CarteCouleur.ROUGE, 0);
            CartesParCouleur.Add(CarteCouleur.VERT, 0);
            CartesParCouleur.Add(CarteCouleur.VIOLET, 0);
            CartesParCouleur.Add(CarteCouleur.NOIR, 0);
            CartesParCouleur.Add(CarteCouleur.BLANC, 0);
        }

        /// <summary>
        /// Sert pour le debug et l'ajout de fonctionnalités, initialise le dictionnaire de cartes avec des valeures differentes de 0
        /// </summary>
        private void CertainesCartes()
        {
            CartesParCouleur.Clear();
            CartesParCouleur.Add(CarteCouleur.JAUNE, 2);
            CartesParCouleur.Add(CarteCouleur.BLEU, 2);
            CartesParCouleur.Add(CarteCouleur.ROUGE, 2);
            CartesParCouleur.Add(CarteCouleur.VERT, 2);
            CartesParCouleur.Add(CarteCouleur.VIOLET, 2);
            CartesParCouleur.Add(CarteCouleur.NOIR, 0);
            CartesParCouleur.Add(CarteCouleur.BLANC, 0);
        }

        /// <summary>
        /// renvoie le nombre de cartes (int) d'une couleur donnée pour le joueur
        /// </summary>
        /// <param name="couleurCarte"></param> la couleur a selectionner
        /// <returns></returns> 
        public int NombreCouleurCarteDuJoueur(CarteCouleur couleurCarte)
        {
            int nb = 0;
            int i = 0;
            if(this != null)
            {
                foreach (CarteCouleur c in this.CartesParCouleur.Keys)
                {
                    if (c.Equals(couleurCarte))
                    {
                        nb = this.CartesParCouleur[c];
                    }
                    i++;
                }
            }
            return nb;
        }
    }
}
