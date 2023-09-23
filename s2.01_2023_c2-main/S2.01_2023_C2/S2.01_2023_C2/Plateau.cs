using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace S2._01_2023_C2
{
    public class Plateau
    {
        private Rectangle salleMachine;
        private Rectangle CentreRecyclage;
        private Rectangle QuartierDEquipage;
        private Rectangle LaboratoireRecherche;
        private Brush couleurCouloirSecteur = Brushes.Gray;
        private Rectangle BarreAvancement;

        public Dictionary<int, Secteur> emplacementAvecSecteur;
        public Dictionary<int, Rectangle> emplacementAvecCoord;

        /// <summary>
        /// constructeur de plateau
        /// le plateau contient les secteurs et les coordonnees des emplacements
        /// </summary>
        public Plateau()
        {
            emplacementAvecSecteur = new Dictionary<int, Secteur>();
            emplacementAvecCoord = new Dictionary<int, Rectangle>();
            this.attribuerCoordonneePourEmplacement();
        }

        /// <summary>
        /// cree les rectangles pour les emplacements des secteurs et les mets dans un dictionnaire
        /// ils servent de selection lors du placement des pions
        /// </summary>
        private void attribuerCoordonneePourEmplacement()
        {
            int w = 120;
            int h = 115;
            salleMachine = new Rectangle(400, 350, w, h);
            CentreRecyclage = new Rectangle(660, 550, w, h);
            QuartierDEquipage = new Rectangle(910, 350, w, h);
            LaboratoireRecherche = new Rectangle(660, 120, w, h);



            emplacementAvecCoord.Add(1, salleMachine);
            emplacementAvecCoord.Add(2, LaboratoireRecherche);
            emplacementAvecCoord.Add(3, QuartierDEquipage);
            emplacementAvecCoord.Add(4, CentreRecyclage);
        }

        /// <summary>
        /// ajoute un secteur dans le dictionnaire des secteurs
        /// </summary>
        /// <param name="emplacement"></param>
        /// <param name="leSecteur"></param>
        public void placerSecteur(int emplacement, Secteur leSecteur)
        {
            this.emplacementAvecSecteur.Add(emplacement, leSecteur);
            leSecteur.Emplacement = emplacementAvecCoord[emplacement];
        }

        /// <summary>
        /// dessine une barre verte en haut a droite de l'ecran qui sert de barre d'avancement
        /// pose aussi en attribut le rectangle de la barre d'avancement
        /// </summary>
        /// <param name="g"></param>
        public void DessinerBarreAvancement(Graphics g)
        {
            BarreAvancement = new Rectangle(1100,40,300,30);
            g.FillRectangle(Brushes.Green, BarreAvancement);
        }

        /// <summary>
        /// renvoie le rectangle de la barre d'avancement
        /// </summary>
        /// <returns></returns>
        public Rectangle getBarreAvancement()
        {
            return BarreAvancement;
        }

        /// <summary>
        /// renvoie le dictionnaire des emplacements avec les secteurs
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, Secteur> getEmplacementAvecSecteur()
        {
            return emplacementAvecSecteur;
        }
    }
}
