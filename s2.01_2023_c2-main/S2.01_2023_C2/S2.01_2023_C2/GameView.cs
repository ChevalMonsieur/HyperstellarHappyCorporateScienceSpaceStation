using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace S2._01_2023_C2
{
    public partial class GameView : Form
    {
        public Partie partie;
        private Plateau pl;
        private bool deplacement = false;
        private Point departDepl;
        private Pion sélectionPion;
        private Secteur sélectionSecteur;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
        private ToolTip toolTip4;
        private Point PosMouse;
        

        public GameView(int nbJoueur)
        {
            InitializeComponent();

            Joueur1.BackColor = Color.Transparent;

            Joueur2.BackColor = Color.Transparent;
            
      
            Joueur3.BackColor = Color.Transparent;

            Joueur4.BackColor = Color.Transparent;

            labelTexte.BackColor = Color.Transparent;
            labelTexte.ForeColor = Color.White;

            LabelPhaseEnCours.BackColor = Color.Transparent;
            LabelPhaseEnCours.ForeColor = Color.White;

            LabelStatJoueur.BackColor = Color.Transparent;
            LabelStatJoueur.ForeColor = Color.White;

            LabelJEnCours.BackColor = Color.Transparent;
            LabelJEnCours.ForeColor = Color.Transparent;

            CartesCouleur.BackColor = Color.Transparent;
            EauEnergie.BackColor = Color.Transparent;

            LabelEau.BackColor = Color.Transparent;
            LabelEnergie.BackColor = Color.Transparent;
            LabelEau.ForeColor = Color.White;
            LabelEnergie.ForeColor = Color.White;

            nbCarteBlanche.BackColor = Color.Transparent;
            nbCarteBleu.BackColor = Color.Transparent;
            nbCarteNoire.BackColor = Color.Transparent;
            nbCarteRouge.BackColor = Color.Transparent;
            nbCarteRouge.FlatStyle = FlatStyle.Flat;
            nbCartesJaune.BackColor = Color.Transparent;
            nbCarteVerte.BackColor = Color.Transparent;
            nbcarteViolette.BackColor = Color.Transparent;

            label0.BackColor = Color.Transparent;
            label150.BackColor = Color.Transparent;
            label0.ForeColor = Color.White;
            label150.ForeColor = Color.White;

            toolTip1 = new ToolTip();
            toolTip2 = new ToolTip();
            toolTip3 = new ToolTip();
            toolTip4 = new ToolTip();


            PosMouse = new Point(0, 0);

            AfficherLesBonJoueurs(nbJoueur);

            NumRevolution.BackColor = Color.Transparent;
            NumRevolution.ForeColor = Color.White;

            Refresh();
        }

        public void SetPartie(Partie partie)
        {
            this.partie = partie;
            pl = partie.plateau;
            Partie.Hub.Emplacement = new Rectangle(623, 300, 167, 136);
        }

        private void GameView_Paint(object sender, PaintEventArgs e)
        {
            MiseAJourCarteLabel();
            LabelPhaseEnCours.Text = partie.phase;
            e.Graphics.DrawString("Salle des machines", new Font("Microsoft Sans Serif", 16), Brushes.White, new Point(365, 312));
            e.Graphics.DrawString("Centre de Recyclage", new Font("Microsoft Sans Serif", 16), Brushes.White, new Point(615, 81));
            e.Graphics.DrawString("Quartier de l'équipage", new Font("Microsoft Sans Serif", 16), Brushes.White, new Point(868, 316));
            e.Graphics.DrawString("Laboratoire de recherche", new Font("Microsoft Sans Serif", 16), Brushes.White, new Point(590, 671));
            pl.DessinerBarreAvancement(e.Graphics);
            CalculPlaceDesJoueursSurLaBarreAvancement(e.Graphics);
            if (!deplacement)
            {
                AttribuerCoordPions(e.Graphics);
            }
            AfficherPictureJoueurEnCours();
            Partie.Hub.PlacerPionsPresents();
            if (deplacement && partie.placement)
            {
                int x = PosMouse.X - departDepl.X;
                int y = PosMouse.Y - departDepl.Y;
                Point current = sélectionPion.position;
                current.Offset(x, y);
                sélectionPion.Deplacer(current);
            }
            foreach (Pion p in Partie.Pions)
            {
                p.DessinerPion(e.Graphics);
            }
            NumRevolution.Text = "Révolution n°" + partie.numéroRévolution.ToString();
        }

        public static Color CouleurDepuisEnum(CarteCouleur Couleur)
        {
            switch (Couleur)
            {
                case CarteCouleur.BLEU:
                    return Color.FromArgb(255, 19, 49, 123);
                case CarteCouleur.ROUGE:
                    return Color.FromArgb(255, 123, 19, 19);
                case CarteCouleur.VERT:
                    return Color.FromArgb(255, 17, 102, 31);
                case CarteCouleur.JAUNE:
                    return Color.FromArgb(255, 139, 149, 14);
                default:
                    return Color.Black;
            }
        }

        private void GameView_MouseMove(object sender, MouseEventArgs e)
        {
            PosMouse = e.Location;
            Refresh();
        }

        private void GameView_MouseDown(object sender, MouseEventArgs e)
        {
            if (partie.placement)
            {
                sélectionPion = SélectionnerPion(e.Location);
                if (sélectionPion != null)
                {
                    deplacement = true;
                    departDepl = e.Location;
                }
            }
            Refresh();
        }

        private void GameView_MouseUp(object sender, MouseEventArgs e)
        {
            bool finPlacement = false;
            if (deplacement && partie.placement)
            {
                Point positionBase = sélectionPion.position;
                Secteur s = SélectionnerSecteur(e.Location);
                if (s != null && !s.Surchage())
                {
                    s.AjouterPion(sélectionPion);
                    Partie.Hub.RetirerPion(sélectionPion);
                    partie.ProchainJoueur();
                    //ajout nico mise a jour label
                    MiseAJourCarteLabel();
                    while (!Partie.Hub.JoueursPresents.Contains(partie.JoueurEnCours) && Partie.Hub.PionsPresents.Count != 0)
                    {
                        partie.JoueurEnCours.jetonsEnergie += 2;
                        partie.ProchainJoueur();
                        //ajout nico mise a jour label
                        MiseAJourCarteLabel();
                        Refresh();
                    }

                    if (Partie.Hub.PionsPresents.Count == 0)
                    {
                        finPlacement = true;
                    }
                }
                else
                {
                    sélectionPion.Deplacer(positionBase);
                }
            }
            deplacement = false;
            Refresh();
            if (partie.placement && finPlacement)
            {
                partie.PhaseAction();
            }
        }

        private Pion SélectionnerPion(Point p)
        {
            Pion res = null;
            foreach (Pion pion in Partie.Pions)
            {
                if (pion.Cercle.Contains(p) && pion.Joueur.Equals(partie.JoueurEnCours))
                {
                    res = pion;
                }
            }
            return res;
        }

        private Secteur SélectionnerSecteur(Point p)
        {
            Secteur res = null;
            foreach (Secteur s in pl.emplacementAvecSecteur.Values)
            {
                if (s.Emplacement.Contains(p))
                {
                    res = s;
                }
            }
            return res;
        }

        private void AfficherLesBonJoueurs(int nbJoueur)
        {
            StatJoueur1.BackColor = Color.Transparent;
            StatJoueur2.BackColor = Color.Transparent;
            StatJoueur3.BackColor = Color.Transparent;
            StatJoueur4.BackColor = Color.Transparent;

            switch (nbJoueur)
            {
                case 2:
                    StatJoueur3.Visible = false;
                    StatJoueur4.Visible = false;
                    break;
                case 3:
                    StatJoueur4.Visible = false;   
                    break;
            }
        }

        private void StatJoueur1_MouseHover(object sender, EventArgs e)
        {
            Joueur j = Partie.Joueurs[0];
            toolTip1.SetToolTip(StatJoueur1, TexteToolTip(j));
        }

        private void StatJoueur2_MouseHover(object sender, EventArgs e)
        {
            Joueur j = Partie.Joueurs[1];
            toolTip2.SetToolTip(StatJoueur2, TexteToolTip(j));
        }

        private void StatJoueur3_MouseHover(object sender, EventArgs e)
        {
            Joueur j = Partie.Joueurs[2];
            toolTip3.SetToolTip(StatJoueur3, TexteToolTip(j));
        }

        private void StatJoueur4_MouseHover(object sender, EventArgs e)
        {
            Joueur j = Partie.Joueurs[3];
            toolTip4.SetToolTip(StatJoueur4, TexteToolTip(j));
        }

        private string TexteToolTip(Joueur j)
        {
            string res;
            if (j.mort)
            {
                res = "Ce joueur est mort.";
            }
            else
            {
                res = "Couleur Joueur : " + j.CouleurJoueur + "\n" + "Jetons énergie : " + j.jetonsEnergie + "\n" + "Jetons eau : " + j.jetonsEau + "\n" +
                "Carte Bleu : " + j.NombreCouleurCarteDuJoueur(CarteCouleur.BLEU) + "\n" + "Carte Rouge : " + j.NombreCouleurCarteDuJoueur(CarteCouleur.ROUGE) + "\n" +
                "Carte Verte : " + j.NombreCouleurCarteDuJoueur(CarteCouleur.VERT) + "\n" + "Carte Noire : " + j.NombreCouleurCarteDuJoueur(CarteCouleur.NOIR) +
                "\n" + "Carte Blanche : " + j.NombreCouleurCarteDuJoueur(CarteCouleur.BLANC) + "\n" + "Carte Violette : " + j.NombreCouleurCarteDuJoueur(CarteCouleur.VIOLET)
                + "\n" + "Carte jaunes : " + j.NombreCouleurCarteDuJoueur(CarteCouleur.JAUNE);
            }
            return res;
        }

        private void MiseAJourCarteLabel()
        {
            nbCarteNoire.Text = partie.JoueurEnCours.NombreCouleurCarteDuJoueur(CarteCouleur.NOIR).ToString();
            nbCarteBlanche.Text = partie.JoueurEnCours.NombreCouleurCarteDuJoueur(CarteCouleur.BLANC).ToString();
            nbcarteViolette.Text = partie.JoueurEnCours.NombreCouleurCarteDuJoueur(CarteCouleur.VIOLET).ToString();
            nbCarteVerte.Text = partie.JoueurEnCours.NombreCouleurCarteDuJoueur(CarteCouleur.VERT).ToString();
            nbCartesJaune.Text = partie.JoueurEnCours.NombreCouleurCarteDuJoueur(CarteCouleur.JAUNE).ToString();
            nbCarteBleu.Text = partie.JoueurEnCours.NombreCouleurCarteDuJoueur(CarteCouleur.BLEU).ToString();
            nbCarteRouge.Text = partie.JoueurEnCours.NombreCouleurCarteDuJoueur(CarteCouleur.ROUGE).ToString();
            LabelEnergie.Text = partie.JoueurEnCours.jetonsEnergie.ToString();
            LabelEau.Text = partie.JoueurEnCours.jetonsEau.ToString();
        }

        private void AfficherPictureJoueurEnCours()
        {
            if(partie.JoueurEnCours != null)
            {
                switch (partie.JoueurEnCours.CouleurJoueur)
                {
                    case CarteCouleur.BLEU:
                        Joueur1.Visible = true;
                        Joueur2.Visible = false;
                        Joueur3.Visible = false;
                        Joueur4.Visible = false;
                        break;
                    case CarteCouleur.ROUGE:
                        Joueur1.Visible = false;
                        Joueur2.Visible = true;
                        Joueur3.Visible = false;
                        Joueur4.Visible = false;
                        break;
                    case CarteCouleur.VERT:
                        Joueur1.Visible = false;
                        Joueur2.Visible = false;
                        Joueur3.Visible = true;
                        Joueur4.Visible = false;
                        break;
                    case CarteCouleur.JAUNE:
                        Joueur1.Visible = false;
                        Joueur2.Visible = false;
                        Joueur3.Visible = false;
                        Joueur4.Visible = true;
                        break;
                }
            }


        }
        
        private void CalculPlaceDesJoueursSurLaBarreAvancement(Graphics g)
        {
            foreach(Joueur j in Partie.Joueurs)
            {
                int calcul1 = (pl.getBarreAvancement().Width * j.pointsVictoire) / 150;
                g.FillEllipse(new SolidBrush(CouleurDepuisEnum(j.CouleurJoueur)), new Rectangle(pl.getBarreAvancement().X - 10 + calcul1, pl.getBarreAvancement().Y - 20, 20, 20));
                float x1 = (float)pl.getBarreAvancement().X + calcul1 + 1;
                float y1 = (float)pl.getBarreAvancement().Y;

                float x2 = (float)pl.getBarreAvancement().X + calcul1 + 1;
                float y2 = (float)pl.getBarreAvancement().Y + pl.getBarreAvancement().Height;
                Pen p = new Pen(CouleurDepuisEnum(j.CouleurJoueur), 2);
                g.DrawLine(p, x1, y1, x2, y2);
                g.DrawEllipse(new Pen(Color.Black, 2), new Rectangle(pl.getBarreAvancement().X - 10 + calcul1, pl.getBarreAvancement().Y - 20, 20, 20));
                g.DrawString(j.Nom[j.Nom.Length - 1].ToString(), new Font("Arial", 12, FontStyle.Bold), new SolidBrush(Color.Black), new Rectangle(pl.getBarreAvancement().X - 7 + calcul1, pl.getBarreAvancement().Y - 18, 20, 20));
            }
        }

        private void AttribuerCoordPions(Graphics g)
        {
            foreach(Secteur s in pl.getEmplacementAvecSecteur().Values)
            {
                s.PlacerPionsPresents();
            }
        }

        private void ButtonAfficherStock_Click(object sender, EventArgs e)
        {
            labelPioche sh = new labelPioche(partie);
            sh.ShowDialog();
        }


        private void ButtonRegles_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jetons : \n" + "- les jetons énergies vous permettent d'accomplir certaines actions qui " +
                "necessitent plus ou moins de jetons énergies " + "\n" + "- les jetons eaux vous permettent d'approvisionner vos joueurs et de " +
                "les garder en vie. " + "\n" + "Si vous n'avez pas assez d'eau, un de vos pions mourra à la fin du tour"+"\n"+"\n"+ "Les cartes vous " +
                "permettent de réaliser des combos et récupérer des jetons énergies et des jetons eaux"+"\n"+"\n"+"Secteurs :"+"\n"+"-Salle machine : la salle machine permet de récupérer des " +
                "jetons énergies"+"\n"+"-Centre de recyclage:"+"\n"+"le centre de recyclage vous permet d'échanger des jetons énergies contre des jetons eaux"+"\n"+
                "-Quartier d'équipage:"+"\n"+"le quartier d'équipage vous permet d'avoir un nouveau pion"+"\n"+"-laboratoire de recherche:"+"\n"+"le laboratoire de recherche vous permet de piocher des cartes et d'éc" +
                "hanger ces cartes contres des jetons");
        }

        public void FinPartie()
        {
            Application.Exit();
        }
    }
}
