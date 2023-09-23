using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2._01_2023_C2
{
    public class Secteur
    {
        private Partie partie;

        public Rectangle Emplacement;

        public ListeSecteurs typeSecteur;

        private int pionsMax;

        public List<Pion> PionsPresents { get; set; }

        public List<Joueur> JoueursPresents { get; set; }

        /// <summary>
        /// Constructeur de secteurs où les joueurs peuvent placer des pions
        /// </summary>
        /// <param name="type"> Type du secteur </param>
        /// <param name="pionsMax"> Nombre maximun de pions qui peuvent être simultanément sur ce secteur </param>
        /// <param name="partie"> La partie </param>
        public Secteur(ListeSecteurs type, int pionsMax, Partie partie)
        {
            typeSecteur = type;
            this.pionsMax = pionsMax;
            PionsPresents = new List<Pion>();
            JoueursPresents = new List<Joueur>();
            this.partie = partie;
        }

        /// <summary>
        /// Activation du secteur, cette méthode va permette à tous les joueurs présents sur le secteur d'effectuer leur action de secteur
        /// dans l'odre du tour de jeu
        /// </summary>
        public void Activer()
        {
            foreach (Joueur joueur in Partie.Joueurs)
            {
                if (JoueursPresents.Contains(joueur) && !joueur.mort)
                {
                    partie.JoueurEnCours = joueur;
                    partie.GetView().Refresh();
                    ActionJoueur(joueur);
                    RetirerPionsDunJoueur(joueur);
                    partie.GetView().Refresh();
                }
            }
        }

        /// <summary>
        /// Ajoute un pion dans la liste des pions présents sur le secteur
        /// </summary>
        /// <param name="pion"> Le pion à ajouter </param>
        public void AjouterPion(Pion pion)
        {
            PionsPresents.Add(pion);
            if (!JoueursPresents.Contains(pion.Joueur))
            {
                JoueursPresents.Add (pion.Joueur);
            }
        }

        /// <summary>
        /// Retire un pion de la liste des pions présents sur le secteur
        /// </summary>
        /// <param name="pion"> Le pion à retirer </param>
        public void RetirerPion(Pion pion)
        {
            bool retirerJoueur = true;
            PionsPresents.Remove(pion);
            foreach (Pion p in PionsPresents)
            {
                if (pion.Joueur.Equals(p.Joueur))
                {
                    retirerJoueur = false;
                }
            }
            if (retirerJoueur)
            {
                JoueursPresents.Remove(pion.Joueur);
            }
        }

        /// <summary>
        /// Retire tous les pions d'un joueur de la liste des pions présents sur le secteur
        /// </summary>
        /// <param name="j"> Le joueur à qui on retire les pions </param>
        private void RetirerPionsDunJoueur(Joueur j)
        {
            HashSet<Pion> pionsARetirer = new HashSet<Pion>();
            foreach (Pion p in PionsPresents)
            {
                if (p.Joueur.Equals(j))
                {
                    pionsARetirer.Add(p);
                }
            }
            foreach (Pion p in pionsARetirer)
            {
                PionsPresents.Remove(p);
                Partie.Hub.AjouterPion(p);
            }
        }

        /// <summary>
        /// Permet de savoir si le secteur est surchargé
        /// </summary>
        /// <returns> True si le nombre de pions présent dans le secteur à atteint la limite </returns>
        public bool Surchage()
        {
            return this.PionsPresents.Count == this.pionsMax;
        }

        private void ActionJoueur(Joueur joueur)
        {
            switch (this.typeSecteur)
            {
                case ListeSecteurs.SalleMachine:
                    ActiverSalleMachine(joueur);
                    break;
                case ListeSecteurs.LaboratoireRecherche:
                    ActiverLaboratoire(joueur);
                    break;
                case ListeSecteurs.CentreRecyclage:
                    ActiverCentreRecyclage(joueur);
                    break;
                case ListeSecteurs.QuartiersDequipage:
                    ActiverQuartiersDequipage(joueur);
                    break;
            }
        }

        private void ActiverSalleMachine(Joueur joueur)
        {
            ChoixAction choixMachines = new ChoixAction(this.ToString(), joueur, 0, 0, "Jetons", 7, "Jetons d'énergie");
            if (choixMachines.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                partie.DonnerJetonsEnergie(joueur, choixMachines.GainFinal);
            }
        }

        private void ActiverLaboratoire(Joueur joueur)
        {
            ChoixAction choixLabo = new ChoixAction(this.ToString(), joueur, joueur.jetonsEnergie >= 2, (joueur.jetonsEnergie >= 2) && (joueur.NombreCartesTotal() > 0),
                        "Bonus 1 : Dépensez 2 jetons d'énergie pour piocher 2 cartes de couleur",
                        "Bonus 2 : Dépensez 2 jetons d'énergie pour échanger vos cartes contre des points");
            if (choixLabo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (choixLabo.premierChoix)
                {
                    partie.RetirerJetonsEnergie(joueur, 2);
                    joueur.Piocher2Carte();
                }
                else
                {
                    ChoixCarte cc = new ChoixCarte(joueur, partie);
                    cc.ShowDialog();
                }
            }
            partie.VérifierPoints(joueur);
        }

        private void ActiverCentreRecyclage(Joueur joueur)
        {
            ChoixAction choixCentre = new ChoixAction(this.ToString(), joueur, joueur.jetonsEnergie, 2, "Jetons d'énergie", 4, "Jetons Eau", 5, "Jetons d'énergie", 7, "Jetons Eau");
            if (choixCentre.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (choixCentre.premierChoix)
                {
                    partie.RetirerJetonsEnergie(joueur, choixCentre.PerteFinale);
                    partie.DonnerJetonsEau(joueur, choixCentre.GainFinal);

                    foreach (Joueur j in Partie.Joueurs)
                    {
                        if (!j.Equals(joueur))
                        {
                            ChoixAction eau = new ChoixAction(this.ToString(), j, j.jetonsEnergie, 1, "Jeton d'énergie", 1, "Jeton Eau");
                            if (eau.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                partie.RetirerJetonsEnergie(j, eau.PerteFinale);
                                partie.DonnerJetonsEau(j, eau.GainFinal);
                            }
                        }
                    }
                }
                else
                {
                    partie.RetirerJetonsEnergie(joueur, choixCentre.PerteFinale);
                    partie.DonnerJetonsEau(joueur, choixCentre.GainFinal);
                    foreach (Joueur j in Partie.Joueurs)
                    {
                        if (!j.Equals(joueur))
                        {
                            partie.DonnerJetonsEau(j, 1);
                        }
                    }
                }
            }
        }

        private void ActiverQuartiersDequipage(Joueur joueur)
        {
            int comp = 0;
            foreach (Pion p in PionsPresents)
            {
                if (p.Joueur.Equals(joueur))
                {
                    comp++;
                }
            }
            if (comp >= 2)
            {
                ChoixAction choixQuartier = new ChoixAction(this.ToString(), joueur, joueur.jetonsEnergie, 5, "Jetons d'énergie", 1, "Pion Chercheur");
                if (choixQuartier.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    joueur.jetonsEnergie -= choixQuartier.PerteFinale;
                    if (joueur.Pions.Count < 10)
                    {
                        Pion p = partie.AjouterPion(joueur);
                        if (p != null)
                        {
                            Partie.Hub.AjouterPion(p);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Permet de placer les pions présents dans le secteur en leur attibuant une position
        /// </summary>
        public void PlacerPionsPresents()
        {
            int margin = 10;
            int TaillePion = 25;
            int xPion;
            int yPion;
            if (this.PionsPresents != null)
            {
                Rectangle Base = this.Emplacement;
                xPion = Base.X;
                yPion = Base.Y + margin;
                foreach (Pion p in this.PionsPresents)
                {
                    if (xPion + TaillePion > Base.Right)
                    {
                        xPion = Base.X;
                        yPion = Base.Y + TaillePion + margin * 2;
                    }
                    p.Deplacer(new Point(xPion, yPion));
                    xPion += TaillePion + margin;
                }
            }
        }

        /// <summary>
        /// Redéfinition de la méthode ToString qui permet d'afficher le type du secteur
        /// </summary>
        /// <returns> Le type de ce secteur </returns>
        override
        public string ToString()
        {
            string str = "";
            switch (this.typeSecteur)
            {
                case ListeSecteurs.QuartiersDequipage:
                    str = "Quartier d'équipage";
                    break;
                case ListeSecteurs.SalleMachine:
                    str = "Salle des machines";
                    break;
                case ListeSecteurs.LaboratoireRecherche:
                    str = "Laboratoire de recherche";
                    break;
                case ListeSecteurs.CentreRecyclage:
                    str = " Centre de recyclage";
                    break;
            }
            return str;
        }

    }
}
