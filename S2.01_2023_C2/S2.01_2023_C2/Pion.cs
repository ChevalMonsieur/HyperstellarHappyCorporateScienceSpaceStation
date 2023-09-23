using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2._01_2023_C2
{
    public class Pion
    {
        public Point position;

        public Rectangle Cercle;

        CarteCouleur couleur { get; set; }

        public Joueur Joueur { get; set; }

        /// <summary>
        /// constructeur de la classe pion,
        /// les pions peuvent etre placés sur les secteurs,
        /// et disparaitre par manque d'eau d'un joueur
        /// </summary>
        /// <param name="joueur"></param>
        public Pion(Joueur joueur)
        {
            this.couleur = joueur.CouleurJoueur;
            this.Joueur = joueur;
            Cercle = new Rectangle();
            Cercle.Size = new Size(25, 25);
            joueur.Pions.Add(this);
        }

        /// <summary>
        /// affiche le pion sur le plateau en fonction de sa position sur l'ecran
        /// </summary>
        /// <param name="g"></param>
        public void DessinerPion(Graphics g)
        {
            string num = this.Joueur.Nom[this.Joueur.Nom.Length - 1].ToString();
            Cercle.Location = position;
            g.FillEllipse(new SolidBrush(GameView.CouleurDepuisEnum(couleur)), Cercle);
            g.DrawEllipse(new Pen(Color.Black, 2), Cercle);
            g.DrawString(num, new Font("Arial", 12, FontStyle.Bold), new SolidBrush(Color.Black), position.X + 5, position.Y + 4);
        }

        /// <summary>
        /// permet de déplacer un pion sur le plateau a une position donnée en parametre
        /// </summary>
        /// <param name="position"></param>
        public void Deplacer(Point position)
        {
            this.position = position;
        }

    }
}
