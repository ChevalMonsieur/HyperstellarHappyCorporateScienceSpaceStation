using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace S2._01_2023_C2
{
    public partial class ChoixAction : Form
    {

        public int Gain1 { get; set; }

        public int Gain2 { get; set; }

        public int Perte1 { get; set; }

        public int Perte2 { get; set; }

        public int GainFinal { get; set; }

        public int PerteFinale { get; set; }

        public bool premierChoix;

        private string typeSecteur;

        /// <summary>
        /// La classe ChoixAction permet au joueur de choisir le bonus qu'il souhaite obtenir en fonction du secteur dans lequel il se trouve.
        /// Ce constructeur est utilisé pour les secteurs qui ne donnent qu'un seul bonus.
        /// </summary>
        /// <param name="typeSecteur"> Le type du secteur à partir duquel le choix est crée </param>
        /// <param name="j"> Le joueur à qui on donne le choix </param>
        /// <param name="ressource"> La quantité de la ressource nécessaire pour ce choix que possède le joueur </param>
        /// <param name="perte"> La quantité de ressource que l'on va retirer au joueur après son choix </param>
        /// <param name="typePerte"> Le type de ressource que le joueur utilise pour ce choix </param>
        /// <param name="gain"> La quantité de ressource que l'on va ajouter au joueur après son choix </param>
        /// <param name="typeGain"> Le type de ressource que le joueur peut obtenir avec ce choix </param>
        public ChoixAction(string typeSecteur ,Joueur j, int ressource, int perte, string typePerte, int gain, string typeGain)
        {
            InitializeComponent();
            LabelChoix2.Visible = false;
            buttonAccepter2.Enabled = false;

            labelTypeSecteur.BackColor = Color.Transparent;
            Titre.BackColor = Color.Transparent;

            LabelChoix1.BackColor = Color.DeepSkyBlue;
            LabelChoix1.ForeColor = Color.White;
            LabelChoix2.BackColor = Color.DeepSkyBlue;
            LabelChoix2.ForeColor = Color.White;

            buttonAccepter1.BackColor = Color.DeepSkyBlue;
            buttonAccepter2.BackColor = Color.DeepSkyBlue;

            buttonAccepter1.ForeColor = Color.White;
            buttonAccepter2.ForeColor = Color.White;

            buttonRefuser.ForeColor = Color.DeepSkyBlue;

            this.typeSecteur = typeSecteur;

            Gain1 = gain;
            Perte1 = perte;
            if (perte > ressource)
            {
                buttonAccepter1.Enabled = false;
            }

            labelTypeSecteur.Text = this.typeSecteur;

            Titre.Text = j.Nom + " veuillez faire un choix :";

            LabelChoix1.Text = "Bonus 1 : Dépensez "+perte.ToString()+" "+typePerte+" pour récupérer "+gain.ToString()+" "+typeGain;
        }

        /// <summary>
        /// La classe ChoixAction permet au joueur de choisir le bonus qu'il souhaite obtenir en fonction du secteur dans lequel il se trouve.
        /// Ce constructeur est utilisé pour les secteurs qui donnent deux bonus différents.
        /// </summary>
        /// <param name="typeSecteur"> Le type du secteur à partir duquel le choix est crée </param>
        /// <param name="j"> Le joueur à qui on donne le choix </param>
        /// <param name="ressource"> La quantité de la ressource nécessaire pour ce choix que possède le joueur </param>
        /// <param name="perte1"> La quantité de ressource que l'on va retirer au joueur s'il choisit le premier choix </param>
        /// <param name="typePerte1"> Le type de ressource que le joueur utilise pour le premier choix </param>
        /// <param name="gain1"> La quantité de ressource que l'on va ajouter au joueur s'il choisit le premier choix </param>
        /// <param name="typeGain1"> Le type de ressource que le joueur peut obtenir s'il choisit le premier choix </param>
        /// <param name="perte2"> La quantité de ressource que l'on va retirer au joueur s'il choisit le deuxième choix </param>
        /// <param name="typePerte2"> Le type de ressource que le joueur utilise pour le deuxième choix </param>
        /// <param name="gain2"> La quantité de ressource que l'on va ajouter au joueur s'il choisit le deuxième choix </param>
        /// <param name="typeGain2"> Le type de ressource que le joueur peut obtenir s'il choisit le deuxième choix </param>
        public ChoixAction(string typeSecteur, Joueur j, int ressource, int perte1, string typePerte1, int gain1, string typeGain1, int perte2, string typePerte2, int gain2, string typeGain2)
        {
            InitializeComponent();
            LabelChoix2.Visible = true;
            buttonAccepter2.Enabled = true;

            this.typeSecteur = typeSecteur;

            labelTypeSecteur.BackColor = Color.Transparent;
            Titre.BackColor = Color.Transparent;

            LabelChoix1.BackColor = Color.DeepSkyBlue;
            LabelChoix1.ForeColor = Color.White;
            LabelChoix2.BackColor = Color.DeepSkyBlue;
            LabelChoix2.ForeColor = Color.White;

            buttonAccepter1.BackColor = Color.DeepSkyBlue;
            buttonAccepter2.BackColor = Color.DeepSkyBlue;

            buttonAccepter1.ForeColor = Color.White;
            buttonAccepter2.ForeColor = Color.White;

            buttonRefuser.ForeColor = Color.DeepSkyBlue;

            labelTypeSecteur.Text = this.typeSecteur;

            Gain1 = gain1;
            Gain2 = gain2;
            Perte1 = perte1;
            Perte2 = perte2;

            if (perte1 > ressource)
            {
                buttonAccepter1.Enabled = false;
            }

            if (perte2 > ressource)
            {
                buttonAccepter2.Enabled = false;
            }

            Titre.Text = j.Nom+" veuillez faire un choix :";

            LabelChoix1.Text = "Bonus 1 : Dépensez " + perte1.ToString() + " " + typePerte1 + " pour récupérer " + gain1.ToString() + " " + typeGain1;
            LabelChoix2.Text = "Bonus 2 : Dépensez " + perte2.ToString() + " " + typePerte2 + " pour récupérer " + gain2.ToString() + " " + typeGain2;
        }

        /// <summary>
        /// La classe ChoixAction permet au joueur de choisir le bonus qu'il souhaite obtenir en fonction du secteur dans lequel il se trouve.
        /// Ce constructeur est utilisé uniquement pour réaliser le choix du Laboratoire de recherche.
        /// </summary>
        /// <param name="typeSecteur"> Le type du secteur à partir duquel le choix est crée </param>
        /// <param name="j"> Le joueur à qui on donne le choix </param>
        /// <param name="bouton1"> booleen calculé à l'avance qui détermine si le bouton du choix 1 est acessible ou non </param>
        /// <param name="bouton2"> booleen calculé à l'avance qui détermine si le bouton du choix 2 est acessible ou non </param>
        /// <param name="premierChoix"> description du premier choix </param>
        /// <param name="secondChoix"> description du deuxième choix </param>
        public ChoixAction(string typeSecteur, Joueur j, bool bouton1, bool bouton2, string premierChoix, string secondChoix)
        {
            InitializeComponent();

            labelTypeSecteur.BackColor = Color.Transparent;
            Titre.BackColor = Color.Transparent;

            LabelChoix1.BackColor = Color.DeepSkyBlue;
            LabelChoix1.ForeColor = Color.White;
            LabelChoix2.BackColor = Color.DeepSkyBlue;
            LabelChoix2.ForeColor = Color.White;

            buttonAccepter1.BackColor = Color.DeepSkyBlue;
            buttonAccepter2.BackColor = Color.DeepSkyBlue;

            buttonAccepter1.ForeColor = Color.White;
            buttonAccepter2.ForeColor = Color.White;

            buttonRefuser.ForeColor = Color.DeepSkyBlue;

            this.typeSecteur = typeSecteur;
            LabelChoix2.Visible = true;
            buttonAccepter1.Enabled = bouton1;
            buttonAccepter2.Enabled = bouton2;

            Titre.Text = j.Nom + " veuillez faire un choix :";

            LabelChoix1.Text = premierChoix;
            LabelChoix2.Text = secondChoix;

            labelTypeSecteur.Text = this.typeSecteur;
        }

        private void ButtonAccepter1_Click(object sender, EventArgs e)
        {
            GainFinal = Gain1;
            PerteFinale = Perte1;
            premierChoix = true;
            DialogResult = DialogResult.OK;
        }

        private void ButtonAccepter2_Click(object sender, EventArgs e)
        {
            GainFinal = Gain2;
            PerteFinale = Perte2;
            premierChoix = false;
            DialogResult = DialogResult.OK;
        }
    }
}
