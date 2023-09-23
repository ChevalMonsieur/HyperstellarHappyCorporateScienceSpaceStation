using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S2._01_2023_C2
{
    public partial class labelPioche : Form
    {

        /// <summary>
        ///  constructeur de la classe Stock (nom de la classe à changer)
        ///  la classe stock permet de gerer l'affichage des cartes de la pioche, de la defausse,
        ///  des stocks des joueurs et des jetons eau et energie restants
        /// </summary>
        /// <param name="partie"></param> la partie en cours
        public labelPioche(Partie partie)
        {
            InitializeComponent();

            LabelPhrase.BackColor = Color.Transparent;
            LabelPhrase.ForeColor = Color.White;
            EauEnergie.BackColor = Color.Transparent;

            labelStockEnergie.BackColor = Color.Transparent;
            labelStockEnergie.ForeColor = Color.White;

            LabelStockEau.BackColor = Color.Transparent;
            LabelStockEau.ForeColor = Color.White;
            CarteDos.BackColor = Color.Transparent;

            StatJoueur1.BackColor = Color.Transparent;
            StatJoueur2.BackColor = Color.Transparent;
            StatJoueur3.BackColor = Color.Transparent;
            StatJoueur4.BackColor = Color.Transparent;

            CarteDefausse.BackColor = Color.Transparent;
            labelTexte2.BackColor = Color.Transparent;
            labelTexte2.ForeColor = Color.White;

            labelDefausseCarte.BackColor = Color.Transparent;
            labelDefausseCarte.ForeColor = Color.White;

            PiocheLabel.BackColor = Color.Transparent;
            PiocheLabel.ForeColor = Color.White;

            StockJ1.BackColor = Color.Transparent;
            StockJ1.ForeColor = Color.White;

            StockJ2.BackColor = Color.Transparent;
            StockJ2.ForeColor = Color.White;

            StockJ3.BackColor = Color.Transparent;
            StockJ3.ForeColor = Color.White;

            StockJ4.BackColor = Color.Transparent;
            StockJ4.ForeColor = Color.White;

            StockDefausse.BackColor = Color.Transparent;
            StockDefausse.ForeColor = Color.White;

            StockPioche.BackColor = Color.Transparent;
            StockPioche.ForeColor = Color.White;

            int nbJoueurs = Partie.Joueurs.Count();
            MiseAjourLabelStockJoueur(partie);
            AfficherLesBonsLabelPlayers(nbJoueurs);
        }

        /// <summary>
        /// affiche les label en fonction du nombre de joueurs dans la partie (2,3 ou 4)
        /// rend donc invisible les label des joueurs qui ne sont pas dans la partie
        /// </summary>
        /// <param name="nbJoueur"></param>
        private void AfficherLesBonsLabelPlayers(int nbJoueur)
        {
            switch (nbJoueur)
            {
                case 2:
                    StatJoueur1.Visible = true;
                    StatJoueur2.Visible = true;
                    StatJoueur3.Visible = false;
                    StockJ3.Visible = false;
                    StatJoueur4.Visible = false;
                    StockJ4.Visible = false;
                    break;
                case 3:
                    StatJoueur1.Visible = true;
                    StatJoueur2.Visible = true;
                    StatJoueur3.Visible = true;
                    StatJoueur4.Visible = false;
                    StockJ4.Visible = false;
                    break;
                case 4:
                    StatJoueur1.Visible = true;
                    StatJoueur2.Visible = true;
                    StatJoueur3.Visible = true;
                    StatJoueur4.Visible = true;
                    break;
            }
        }

        /// <summary>
        /// met a jour tous les labels des stocks (joueurs, pioche et defausse)
        /// </summary>
        /// <param name="p"></param> la partie en cours
        private void MiseAjourLabelStockJoueur(Partie p)
        {
            labelStockEnergie.Text = p.StockJetonsEnergie.ToString();
            LabelStockEau.Text = p.StockJetonsEau.ToString();
            StockDefausse.Text = Carte.TotalCartesDefausse().ToString();
            StockPioche.Text = Carte.TotalCartesTas().ToString();

            foreach(Joueur j in Partie.Joueurs)
            {
                switch (j.CouleurJoueur)
                {
                    case CarteCouleur.BLEU:
                        StockJ1.Text = j.StockPions.ToString();
                        break;
                    case CarteCouleur.ROUGE:
                        StockJ2.Text = j.StockPions.ToString();
                        break;
                    case CarteCouleur.VERT:
                        StockJ3.Text = j.StockPions.ToString();
                        break;
                    case CarteCouleur.JAUNE:
                        StockJ4.Text = j.StockPions.ToString();
                        break;
                }
            }
            
        }
    }
}
