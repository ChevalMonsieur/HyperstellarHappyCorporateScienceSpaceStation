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
    public partial class ChoixNombreJoueur : Form
    {

        private int ChoixNbJoueur;

        /// <summary>
        /// constructeur, passe le fond du texte en transparent et la couleur du texte en blanc
        /// la fenetre sert a choisir le nombre de joueur dans la partie
        /// </summary>
        public ChoixNombreJoueur()
        {
            InitializeComponent();
            texteJoueur.BackColor = Color.FromArgb(0,Color.White);
            texteJoueur.ForeColor = Color.White;
        }

        /// <summary>
        /// passe l'attribut du nombre de joueur dans la partie à 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChoixJoueur2_Click(object sender, EventArgs e)
        {
            ChoixNbJoueur = 2;
        }

        /// <summary>
        /// passe l'attribut du nombre de joueur dans la partie à 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void choixJoueur3_Click(object sender, EventArgs e)
        {
            ChoixNbJoueur = 3;
        }

        /// <summary>
        /// passe l'attribut du nombre de joueur dans la partie à 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void choixJoueur4_Click(object sender, EventArgs e)
        {
            ChoixNbJoueur = 4;
        }

        /// <summary>
        /// renvoie l'attribut du nombre de joueur dans la partie
        /// </summary>
        /// <returns></returns>
        public int getChoixNbJoueur()
        {
            return ChoixNbJoueur;
        }

    }
}
