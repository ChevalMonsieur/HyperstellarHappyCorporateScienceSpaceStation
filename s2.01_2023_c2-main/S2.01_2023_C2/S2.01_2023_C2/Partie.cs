using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S2._01_2023_C2
{
    public class Partie
    {
        public int numéroRévolution { get; set; }
        public static List<Joueur> Joueurs { get; set; }
        public int StockJetonsEau { get; set; }
        public int StockJetonsEnergie { get; set; }
        public static List<Pion> Pions { get; set; }
        public Joueur JoueurEnCours;
        public Plateau plateau;
        public static Secteur Hub;
        int nbJoueurs;
        public bool placement;
        public string phase;
        private GameView view;
        private bool finPartie;

        /// <summary>
        /// Constructeur de partie
        /// La classe partie est la classe principale du jeu, elle contient tous les joueurs, le plateau et les secteurs
        /// elle gere aussi les stocks totaux des pions du jeu
        /// ici dans le constructeur on initialise les emplacements des secteurs et on les places sur le plateau,
        /// on cree aussi les pions qu'on attribue aux joueurs et on les mets dans le hub
        /// </summary>
        /// <param name="nbJoueur"></param> le nombre de joueur dans la partie
        /// <param name="view"></param>
        public Partie(int nbJoueur, GameView view)
        {
            this.nbJoueurs = nbJoueur;
            this.view = view;
            finPartie = false;
            this.plateau = new Plateau();
            Pions = new List<Pion>();
            StockJetonsEau = 100;
            StockJetonsEnergie = 100;
            Hub = new Secteur(ListeSecteurs.HUB, 999, this);

            Secteur sec1 = new Secteur(ListeSecteurs.SalleMachine, 2, this);
            Secteur sec2 = new Secteur(ListeSecteurs.CentreRecyclage, 5, this);
            Secteur sec3 = new Secteur(ListeSecteurs.LaboratoireRecherche, 2, this);
            Secteur sec4 = new Secteur(ListeSecteurs.QuartiersDequipage, 4, this);
            plateau.placerSecteur(1, sec1);
            plateau.placerSecteur(2, sec2);
            plateau.placerSecteur(4, sec3);
            plateau.placerSecteur(3, sec4);
            numéroRévolution = 0;
            Joueurs = CreerJoueurs();
            foreach (Joueur j in Joueurs)
            {
                Pion p1 = this.AjouterPion(j);
                Pion p2 = this.AjouterPion(j);
                Hub.AjouterPion(p1);
                Hub.AjouterPion(p2);
                DonnerJetonsEnergie(j, 10);
                DonnerJetonsEau(j, 10);
            }
        }
        // Constructeur TEST (sans lien avec GameView pour les Tests)
        public Partie(int nbJoueur)
        {
            this.nbJoueurs = nbJoueur;
            Pions = new List<Pion>();
            StockJetonsEau = 100;
            StockJetonsEnergie = 100;
            numéroRévolution = 1;
            Joueurs = CreerJoueurs();
            foreach (Joueur j in Joueurs)
            {
                Pion p1 = this.AjouterPion(j);
                Pion p2 = this.AjouterPion(j);
                DonnerJetonsEnergie(j, 10);
                DonnerJetonsEau(j, 10);
            }
        }

        /// <summary>
        /// renvoie la view de cette insance de partie
        /// </summary>
        /// <returns></returns>
        public GameView GetView()
        {
            return this.view;
        }

        /// <summary>
        /// enleve des jetonsEnergie du stock de la partie et les ajoute au joueur
        /// si le stock passe en dessous de 0, le joueur ne recoit que le nombre de jetons restant et pas la quantite souhaitée
        /// </summary>
        /// <param name="j"></param> le joueur qui recoit des jetons
        /// <param name="nbJetons"></param> le nombres de jetons qu'il recoit
        public void DonnerJetonsEnergie(Joueur j, int nbJetons)
        {
            StockJetonsEnergie -= nbJetons;
            j.jetonsEnergie += nbJetons;
            if (StockJetonsEnergie < 0)
            {
                j.jetonsEnergie += StockJetonsEnergie;
                StockJetonsEnergie = 0;
            }
        }

        /// <summary>
        /// ajoute des jetonsEnergie au stock de la partie et les enleve au joueur
        /// </summary>
        /// <param name="j"></param> le joueur qui donne des jetons
        /// <param name="nbJetons"></param> le nombre de jetons qu'il donne
        public void RetirerJetonsEnergie(Joueur j, int nbJetons)
        {
            StockJetonsEnergie += nbJetons;
            j.jetonsEnergie -= nbJetons;
        }

        /// <summary>
        /// enleve des jetonsEau du stock de la partie et les ajoute au joueur
        /// si le stock passe en dessous de 0, le joueur ne recoit que le nombre de jetons restant et pas la quantite souhaitée
        /// </summary>
        /// <param name="j"></param> le joueur qui recoit des jetons
        /// <param name="nbJetons"></param> le nombres de jetons qu'il recoit
        public void DonnerJetonsEau(Joueur j, int nbJetons)
        {
            StockJetonsEau -= nbJetons;
            j.jetonsEau += nbJetons;
            if (StockJetonsEau < 0)
            {
                j.jetonsEau += StockJetonsEau;
                StockJetonsEau = 0;
            }
        }

        /// <summary>
        /// ajoute des jetonsEau au stock de la partie et les enleve au joueur
        /// </summary>
        /// <param name="j"></param> le joueur qui donne des jetons
        /// <param name="nbJetons"></param> le nombre de jetons qu'il donne
        public void RetirerJetonsEau(Joueur j, int nbJetons)
        {
            StockJetonsEau += nbJetons;
            j.jetonsEau -= nbJetons;
        }

        /// <summary>
        /// cree  les joueurs de la partie et les ajoute a la liste des joueurs
        /// avec une couleur differente pour chacun et se limite au nombre de joueurs choisi grace a  nbJoueurs
        /// </summary>
        /// <returns></returns> la list dew joueurs
        private List<Joueur> CreerJoueurs()
        {
            CarteCouleur[] couleursJoueurs = new CarteCouleur[4] { CarteCouleur.BLEU, CarteCouleur.ROUGE, CarteCouleur.VERT, CarteCouleur.JAUNE };
            List<Joueur> joueurs = new List<Joueur>();
            for (int i = 0; i < nbJoueurs; i++)
            {
                Joueur j = new Joueur("Joueur " + (i + 1), couleursJoueurs[i]);
                joueurs.Add(j);
            }
            return joueurs;
        }

        /// <summary>
        /// Initialise le tas de carte et lance la 1ere revolution
        /// </summary>
        public void DebutPartie()
        {
            Carte.RemplissageDebutPartie();
            NouvelleRévolution();
        }

        /// <summary>
        /// Lance une nouvelle revolution
        /// verifie que le premier joueur n'est pas mort, et passe au joueur suivant si c'est le cas
        /// </summary>
        private void NouvelleRévolution()
        {
            JoueurEnCours = Joueurs[0];
            if (JoueurEnCours.mort)
            {
                ProchainJoueur();
            }
            numéroRévolution++;
            PhasePlacement();
        }

        /// <summary>
        /// 
        /// </summary>
        private void PhasePlacement()
        {
            phase = "Phase de placement";
            view.Refresh();
            placement = true;
        }

        /// <summary>
        /// passe au joueur suivant et s'il est mort, rappelle la fonction
        /// </summary>
        public void ProchainJoueur()
        {
            if (!finPartie)
            {
                JoueurEnCours = Joueurs[(Joueurs.IndexOf(JoueurEnCours) + 1) % nbJoueurs];
                if (JoueurEnCours.mort)
                {
                    ProchainJoueur();
                }
            }
        }

        /// <summary>
        /// passe a la phase d'action
        /// active tous les secteurs et vide la liste des pions presents dans chaque secteur pour les remettre dans le hub
        /// </summary>
        public void PhaseAction()
        {
            phase = "Phase d'action";
            foreach (Secteur s in plateau.emplacementAvecSecteur.Values)
            {
                s.Activer();
            }

            foreach(Secteur s in plateau.emplacementAvecSecteur.Values)
            {
                s.JoueursPresents.Clear();
            }
            view.Refresh();
            PhaseEntretien();
        }

        /// <summary>
        /// fin de la revolution, pour chaque joueur non mort, on appelle la fonction EntretienJoueur du joueur
        /// et apres on lance une nouvelle revolution
        /// </summary>
        private void PhaseEntretien()
        {
            phase = "Phase d'entretien";
            foreach (Joueur j in Joueurs)
            {
                if (!j.mort)
                {
                    EntretienJoueur(j);
                }
            }
            view.Refresh();
            NouvelleRévolution();
        }

        /// <summary>
        /// soustrait au joueur autant de jetonsEau qu'il a de pions 
        /// et s'il n'en a pas assez, lui retire un pion et passe les jetonsEau a 0
        /// Si le joueur n'a plus de pions, il est mort, on le previens de sa mort et on vide toutes ses cartes
        /// Finalement on appelle la fonction VerifierNombreJoueurs
        /// </summary>
        /// <param name="j"></param>
        private void EntretienJoueur(Joueur j)
        {
            RetirerJetonsEau(j, j.Pions.Count);
            if (j.jetonsEau < 0)
            {
                StockJetonsEau += j.jetonsEau;
                j.jetonsEau = 0;
                RetirerUnPion(j);
                if (j.Pions.Count == 0)
                {
                    defaite d = new defaite(j.Nom);
                    d.ShowDialog();
                    j.mort = true;
                    j.ViderCartes();
                }
            }
            VerifierNombreJoueurs();
        }

        /// <summary>
        /// verifie le nombre de joueurs en vie, si il n'y en a qu'un, on appelle la fonction FinDePartie
        /// </summary>
        private void VerifierNombreJoueurs()
        {
            int joueursEnVie = 0;
            Joueur Gagnant = null;
            foreach (Joueur joueur in Joueurs)
            {
                if (!joueur.mort)
                {
                    joueursEnVie++;
                    Gagnant = joueur;
                }
            }
            if (joueursEnVie == 1)
            {
                FinDePartie(Gagnant);
            }
        }

        /// <summary>
        /// pour un joueur donné, si le stock de pion du joueur est supérieur a 0, on lui ajoute un pion
        /// </summary>
        /// <param name="j"></param> le joueur en question
        /// <returns></returns> le pion ajouté
        public Pion AjouterPion(Joueur j)
        {
            if (j.StockPions > 0)
            {
                Pion p = new Pion(j);
                Pions.Add(p);
                j.StockPions--;
                return p;
            }
            else return null;
            
        }

        /// <summary>
        /// retire un pion au joueur, le retire de la liste des pions et de l'affichage
        /// </summary>
        /// <param name="j"></param> le joueur en question
        public void RetirerUnPion(Joueur j)
        {
            Pion p = j.Pions[0];
            j.Pions.Remove(p);
            Hub.RetirerPion(p);
            Pions.Remove(p);
            j.StockPions++;
        }

        /// <summary>
        /// verifie pour un joueur donné s'il a passé les 150 points de victoire et a donc gagné
        /// si oui
        /// </summary>
        /// <param name="j"></param>
        public void VérifierPoints(Joueur j)
        {
            if (j.pointsVictoire >= 150)
            {
                FinDePartie(j);
            }
        }

        /// <summary>
        /// fait une messageBox pour afficher le gagnant de la partie et ferme l'application
        /// </summary>
        /// <param name="Gagnant"></param> le joueur qui a gagné la partie
        public void FinDePartie(Joueur Gagnant)
        {
            Victoire v = new Victoire(Gagnant.Nom, Gagnant.pointsVictoire);
            v.ShowDialog();
            finPartie = true;
            view.FinPartie();
        }

    }
}
