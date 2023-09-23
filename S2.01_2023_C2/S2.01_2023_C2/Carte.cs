using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Diagnostics;

namespace S2._01_2023_C2
{
    public class Carte
    {
        //cet attribut sert a faire un foreach des autres dictionnaires quand ils sont modifiés(c'est un clone vide), il empeche une exception
        public static List<CarteCouleur> carteList = new List<CarteCouleur>();
        public static Dictionary<CarteCouleur, int> CartesTasParCouleur = new Dictionary<CarteCouleur, int>();
        public static Dictionary<CarteCouleur, int> CarteDefausseParCouleur = new Dictionary<CarteCouleur, int>();

        //la classe carte n'a pas de constructeur car il n'y a pas d'instances de cartes, on utilise seulement des méthodes statiques

        /// <summary>
        /// choisit une couleur aléatoire pondérée parmis les couleurs restantes dans le tas
        /// </summary>
        /// <returns></returns> une couleur de carte aleatoire
        public static CarteCouleur attribuerCouleurAleatoire()
        {
            int x;
            var rand = new Random();
            CarteCouleur res = CarteCouleur.JAUNE;
            if (CheckTasVide())
            {
                TransfererDefausseVersTas();
            }
            x = rand.Next(1, TotalCartesTas());
            foreach (CarteCouleur c in carteList)
            {
                if (CartesTasParCouleur[c] >= x)
                {
                    CartesTasParCouleur[c]--;
                    res = c;
                    x = 100000;
                }
                else
                {
                    x -= CartesTasParCouleur[c];
                }
            }
            return res;
        }

        /// <summary>
        /// initialise les dictionnaires de cartes CartesTasParCouleur et CarteDefausseParCouleur
        /// le premier avec cartes remplies (20, 20, 20, 20, 10, 8, 2
        /// le second avec cartes vides
        /// </summary>
        public static void RemplissageDebutPartie()
        {
            CartesTasParCouleur.Clear();
            carteList.Clear();
            CarteDefausseParCouleur.Clear();
            CartesTasParCouleur.Add(CarteCouleur.JAUNE, 20);
            carteList.Add(CarteCouleur.JAUNE);
            CarteDefausseParCouleur.Add(CarteCouleur.JAUNE, 0);
            CartesTasParCouleur.Add(CarteCouleur.BLEU, 20);
            carteList.Add(CarteCouleur.BLEU);
            CarteDefausseParCouleur.Add(CarteCouleur.BLEU, 0);
            CartesTasParCouleur.Add(CarteCouleur.ROUGE, 20);
            carteList.Add(CarteCouleur.ROUGE);
            CarteDefausseParCouleur.Add(CarteCouleur.ROUGE, 0);
            CartesTasParCouleur.Add(CarteCouleur.VERT, 20);
            carteList.Add(CarteCouleur.VERT);
            CarteDefausseParCouleur.Add(CarteCouleur.VERT, 0);
            CartesTasParCouleur.Add(CarteCouleur.VIOLET, 10);
            carteList.Add(CarteCouleur.VIOLET);
            CarteDefausseParCouleur.Add(CarteCouleur.VIOLET, 0);
            CartesTasParCouleur.Add(CarteCouleur.NOIR, 8);
            carteList.Add(CarteCouleur.NOIR);
            CarteDefausseParCouleur.Add(CarteCouleur.NOIR, 0);
            CartesTasParCouleur.Add(CarteCouleur.BLANC, 2);
            carteList.Add(CarteCouleur.BLANC);
            CarteDefausseParCouleur.Add(CarteCouleur.BLANC, 0);
        }

        /// <summary>
        /// transfere les cartes de la defausse vers le tas
        /// </summary>
        public static void TransfererDefausseVersTas()
        {
            foreach (CarteCouleur c in CarteDefausseParCouleur.Keys)
            {
                CartesTasParCouleur[c] += CarteDefausseParCouleur[c];
                CarteDefausseParCouleur[c] = 0;
            }
        }

        /// <summary>
        /// verifie si le tas est vide
        /// </summary>
        /// <returns></returns> un booleen
        private static bool CheckTasVide()
        {
            bool res = true;
            foreach(CarteCouleur c in CartesTasParCouleur.Keys) 
            {
                if (CartesTasParCouleur[c] != 0)
                {
                    res = false;
                }
            }
            return res;
        }
        /// <summary>
        /// renvoie le nombre total de cartes dans le tas de pioche
        /// </summary>
        /// <returns></returns> un int
        public static int TotalCartesTas()
        {
            int res = 0;
            foreach (CarteCouleur cc in Carte.carteList)
            {
                res += Carte.CartesTasParCouleur[cc];
            }
            return res;
        }

        /// <summary>
        /// renvoie le nombre total de cartes dans la defausse
        /// </summary>
        /// <returns></returns> un int
        public static int TotalCartesDefausse()
        {
            int res = 0;
            foreach (CarteCouleur cc in Carte.carteList)
            {
                res += Carte.CarteDefausseParCouleur[cc];
            }
            return res;
        }
    }
}
