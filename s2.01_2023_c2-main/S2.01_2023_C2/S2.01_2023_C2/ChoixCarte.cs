using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S2._01_2023_C2
{
    public partial class ChoixCarte : Form
    {
        static int jetonsPotentiels;
        public int perteJetons;
        private Partie partie;
        static List<Button> CartesMenu = new List<Button>();
        static List<Label> Labels = new List<Label>();
        static List<Label> Selections = new List<Label>();
        static Dictionary<CarteCouleur, int> CartesEchangees = new Dictionary<CarteCouleur, int>();
        Joueur j;

        /// <summary>
        /// constructeur de la fenetre de choix de carte
        /// la fenetre sert a valoriser des cartes, soit creer des combos prédefinis
        /// pour gagner des points victoire le moyen de gagner par defaut
        /// </summary>
        /// <param name="j"></param> le joueur qui vend ses cartes
        /// <param name="partie"></param> la partie en cours
        public ChoixCarte(Joueur j, Partie partie)
        {
            this.j = j;
            this.partie = partie;
            perteJetons = 0;
            InitializeComponent();
            InitialiserMenu();
            MAJDisponibilitésCartes();
        }

        /// <summary>
        /// initialise toutes les valeures, tous les labels et tous les boutons.
        /// Il les ajoute aussi dans des listes adaptées
        /// </summary>
        private void InitialiserMenu()
        {
            jetonsPotentiels = j.jetonsEnergie;
            CartesMenu.Clear();
            CartesMenu.Add(CarteJaune);
            CartesMenu.Add(CarteBleue);
            CartesMenu.Add(CarteRouge);
            CartesMenu.Add(CarteVerte);
            CartesMenu.Add(CarteViolette);
            CartesMenu.Add(CarteNoire);
            CartesMenu.Add(CarteBlanche);

            foreach (Button b in CartesMenu)
            {
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.BackColor = Color.FromArgb(0, Color.AliceBlue);
            }
            CartesEchangees.Clear();
            CartesEchangees.Add(CarteCouleur.JAUNE, 0);
            CartesEchangees.Add(CarteCouleur.BLEU, 0);
            CartesEchangees.Add(CarteCouleur.ROUGE, 0);
            CartesEchangees.Add(CarteCouleur.VERT, 0);
            CartesEchangees.Add(CarteCouleur.VIOLET, 0);
            CartesEchangees.Add(CarteCouleur.NOIR, 0);
            CartesEchangees.Add(CarteCouleur.BLANC, 0);
            Labels.Clear();
            Labels.Add(NBJaune);
            Labels.Add(NBBleu);
            Labels.Add(NBRouge);
            Labels.Add(NBVert);
            Labels.Add(NBViolet);
            Labels.Add(NBNoir);
            Labels.Add(NBBlanc);
            foreach (Label l in Labels)
            {
                l.BackColor = Color.FromArgb(0, Color.Black);
            }
            Selections.Clear();
            Selections.Add(SelectionJaune);
            Selections.Add(SelectionBleu);
            Selections.Add(SelectionRouge);
            Selections.Add(SelectionVert);
            Selections.Add(SelectionViolet);
            Selections.Add(SelectionNoir);
            Selections.Add(SelectionBlanc);
            foreach(Label l in Selections)
            {
                l.Visible = false;
                l.BackColor = Color.FromArgb(0, Color.Black);
            }
            Text.BackColor = Color.FromArgb(0, Color.Black);
            jetonsEnergie.BackColor = Color.FromArgb(0, Color.Black);
            PointsVictoire.BackColor = Color.FromArgb(0, Color.Black);
            CarteGrisee.Visible = false;
        }

        /// <summary>
        /// met a jour les disponibilités des cartes en fonction des cartes échangées :
        /// si le joueur a moins de 2 points d'energie, alors il ne peut plus échanger de cartes
        /// si une carte est a 0,  alors on ne peut plus l'échanger
        /// met a jour le texte des labels qui disent le nombre de points d'energie restants et les points victoires
        /// </summary>
        private void MAJDisponibilitésCartes()
        {
            int i = 0;
            foreach (CarteCouleur cc in j.CartesParCouleur.Keys)
            {
                if (j.CartesParCouleur[cc] <= 0)
                {
                    CartesMenu[i].Enabled = false;
                    Labels[i].Text = "0";
                } else if (jetonsPotentiels < 2)
                {
                    CartesMenu[i].Enabled = false;
                }
                else
                {
                    Labels[i].Text = j.CartesParCouleur[cc].ToString();
                    CartesMenu[i].Enabled = true;
                }
                i++;
            }
            jetonsEnergie.Text = "Jetons d'énergie restants : " + jetonsPotentiels;
            PointsVictoire.Text = "Points victoire : " + j.pointsVictoire.ToString();
        }

        /// <summary>
        /// lors du click sur la carte, si le joueur a selectionne 0 ou moins que le nombre de cartes Jaunes qu'il a, alors on ajoute une carte a la selection
        /// si il en a autant que le nombre de cartes qu'il a, alors on passe le nombre selectionne a 0
        /// appelle MAJDisponibiltesCartes() pour griser les cartes si besoin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CarteJaune_Click(object sender, EventArgs e)
        {
            if (CartesEchangees[CarteCouleur.JAUNE] == j.CartesParCouleur[CarteCouleur.JAUNE])
            {
                jetonsPotentiels += 2 * CartesEchangees[CarteCouleur.JAUNE];
                CartesEchangees[CarteCouleur.JAUNE] = 0;
                SelectionJaune.Visible = false;
            }
            else
            {
                CartesEchangees[CarteCouleur.JAUNE]++;
                SelectionJaune.Visible = true; 
                SelectionJaune.Text = "Sélectionnée(s) : " + CartesEchangees[CarteCouleur.JAUNE].ToString();
                jetonsPotentiels -= 2;
            }
            MAJDisponibilitésCartes();
        }

        /// <summary>
        /// pareil que CarteJaune_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CarteBleue_Click(object sender, EventArgs e)
        {
            if (CartesEchangees[CarteCouleur.BLEU] == j.CartesParCouleur[CarteCouleur.BLEU])
            {
                jetonsPotentiels += 2 * CartesEchangees[CarteCouleur.BLEU];
                CartesEchangees[CarteCouleur.BLEU] = 0;
                SelectionBleu.Visible = false;
            }
            else
            {
                CartesEchangees[CarteCouleur.BLEU]++;
                SelectionBleu.Visible = true;
                SelectionBleu.Text = "Sélectionnée(s) : " + CartesEchangees[CarteCouleur.BLEU].ToString();
                jetonsPotentiels -= 2;
            }
            MAJDisponibilitésCartes();
        }

        /// <summary>
        /// pareil que CarteJaune_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CarteRouge_Click(object sender, EventArgs e)
        {
            if (CartesEchangees[CarteCouleur.ROUGE] == j.CartesParCouleur[CarteCouleur.ROUGE])
            {
                jetonsPotentiels += 2 * CartesEchangees[CarteCouleur.ROUGE];
                CartesEchangees[CarteCouleur.ROUGE] = 0;
                SelectionRouge.Visible = false;
            }
            else
            {
                CartesEchangees[CarteCouleur.ROUGE]++;
                SelectionRouge.Visible = true;
                SelectionRouge.Text = "Sélectionnée(s) : " + CartesEchangees[CarteCouleur.ROUGE].ToString();
                jetonsPotentiels -= 2;
            }
            MAJDisponibilitésCartes();
        }

        /// <summary>
        /// pareil que CarteJaune_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CarteVerte_Click(object sender, EventArgs e)
        {
            if (CartesEchangees[CarteCouleur.VERT] == j.CartesParCouleur[CarteCouleur.VERT])
            {
                jetonsPotentiels += 2 * CartesEchangees[CarteCouleur.VERT];
                CartesEchangees[CarteCouleur.VERT] = 0;
                SelectionVert.Visible = false;
            }
            else
            {
                CartesEchangees[CarteCouleur.VERT]++;
                SelectionVert.Visible = true;
                SelectionVert.Text = "Sélectionnée(s) : " + CartesEchangees[CarteCouleur.VERT].ToString();
                jetonsPotentiels -= 2;
            }
            MAJDisponibilitésCartes();
        }

        /// <summary>
        /// pareil que CarteJaune_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CarteViolette_Click(object sender, EventArgs e)
        {
            if (CartesEchangees[CarteCouleur.VIOLET] == j.CartesParCouleur[CarteCouleur.VIOLET])
            {
                jetonsPotentiels += 2 * CartesEchangees[CarteCouleur.VIOLET];
                CartesEchangees[CarteCouleur.VIOLET] = 0;
                SelectionViolet.Visible = false;
            }
            else
            {
                CartesEchangees[CarteCouleur.VIOLET]++;
                SelectionViolet.Visible = true;
                SelectionViolet.Text = "Sélectionnée(s) : " + CartesEchangees[CarteCouleur.VIOLET].ToString();
                jetonsPotentiels -= 2;
            }
            MAJDisponibilitésCartes();
        }

        /// <summary>
        /// pareil que CarteJaune_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CarteNoire_Click(object sender, EventArgs e)
        {
            if (CartesEchangees[CarteCouleur.NOIR] == j.CartesParCouleur[CarteCouleur.NOIR])
            {
                jetonsPotentiels += 2 * CartesEchangees[CarteCouleur.NOIR];
                CartesEchangees[CarteCouleur.NOIR] = 0;
                SelectionNoir.Visible = false;
            }
            else
            {
                CartesEchangees[CarteCouleur.NOIR]++;
                SelectionNoir.Visible = true;
                SelectionNoir.Text = "Sélectionnée(s) : " + CartesEchangees[CarteCouleur.NOIR].ToString();
                jetonsPotentiels -= 2;
            }
            MAJDisponibilitésCartes();
        }

        /// <summary>
        /// pareil que CarteJaune_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CarteBlanche_Click(object sender, EventArgs e)
        {
            if (CartesEchangees[CarteCouleur.BLANC] == j.CartesParCouleur[CarteCouleur.BLANC])
            {
                jetonsPotentiels += 2 * CartesEchangees[CarteCouleur.BLANC];
                CartesEchangees[CarteCouleur.BLANC] = 0;
                SelectionBlanc.Visible = false;
            }
            else
            {
                CartesEchangees[CarteCouleur.BLANC]++;
                SelectionBlanc.Visible = true;
                SelectionBlanc.Text = "Sélectionnée(s) : " + CartesEchangees[CarteCouleur.BLANC].ToString();
                jetonsPotentiels -= 2;
            }
            MAJDisponibilitésCartes();
        }

        /// <summary>
        /// lors du click, il verifie si le joueur a sélectionné un combo valide,
        /// si oui, il lui donne les points victoires,
        /// sinon il lui dit qu'il n'a pas sélectionné de combo valide et ne lui donne pas de points
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Echanger_Click(object sender, EventArgs e)
        {
            int points = VerifCombo();
            if (points!=0)
            {
                j.pointsVictoire += points;
                perteJetons = j.jetonsEnergie - jetonsPotentiels;
                partie.RetirerJetonsEnergie(j,perteJetons);
                foreach (CarteCouleur cc in CartesEchangees.Keys)
                {
                    Carte.CarteDefausseParCouleur[cc] += CartesEchangees[cc];
                    j.CartesParCouleur[cc] -= CartesEchangees[cc];
                }
            } else
            {
                MessageBox.Show("Vous n'avez pas sélectionné de combo valide");
            }
            DesselectionnerCartesEchangees();
            MAJDisponibilitésCartes();
        }
        /// <summary>
        /// verifie si le joueur a sélectionné un combo valide et renvoie le nombre de points victoire qu'il gagne
        /// </summary>
        /// <returns></returns> (int) points victoire a gagner
        private int VerifCombo()
        {
            int res = 0;
            bool checkCouleurJoueur = false;
            int compteurDiff = 0;
            int compteurTot = 0;
            bool cinqCartesPourUneCouleur = false;
            foreach (CarteCouleur cc in CartesEchangees.Keys)
            {
                if (CartesEchangees[cc] != 0)
                {
                    compteurDiff++;
                    compteurTot += CartesEchangees[cc];
                    if (j.CouleurJoueur == cc)
                    {
                        checkCouleurJoueur=true;
                    }
                    if (CartesEchangees[cc] == 5)
                    {
                        cinqCartesPourUneCouleur = true;
                    }
                }
            }
            if (checkCouleurJoueur && compteurTot==1)
            {
                res = 3;
            } else if (cinqCartesPourUneCouleur && compteurTot==5)
            {
                res = 7;
            } else if (compteurDiff==4 && compteurTot==4)
            {
                res = 10;
            } else if (compteurDiff==6 && compteurTot==6)
            {
                res = 30;
            }
            else if (compteurDiff == 7 && compteurTot == 7)
            {
                res = 50;
            }
            return res;
        }

        /// <summary>
        /// desélectionne les cartes échangées et rend invisible les labels de sélection
        /// </summary>
        private void DesselectionnerCartesEchangees()
        {
            //foreach marche pas sur CartesEchangees
            CartesEchangees[CarteCouleur.JAUNE] = 0;
            CartesEchangees[CarteCouleur.BLEU] = 0;
            CartesEchangees[CarteCouleur.ROUGE] = 0;
            CartesEchangees[CarteCouleur.VERT] = 0;
            CartesEchangees[CarteCouleur.VIOLET] = 0;
            CartesEchangees[CarteCouleur.NOIR] = 0;
            CartesEchangees[CarteCouleur.BLANC] = 0;
            foreach (Label l in Selections)
            {
                l.Visible = false;
            }
        }

        /// <summary>
        /// Reinitialise la selection et met tout a jour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            InitialiserMenu();
            MAJDisponibilitésCartes();
        }
    }
}
