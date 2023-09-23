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
    public partial class Victoire : Form
    {
        public Victoire(string nomJoueur, int pointGagnant)
        {
            InitializeComponent();
            labelJoueurGagnant.BackColor = Color.Transparent;

            labelJoueurGagnant.Text = "Bravo !! "+nomJoueur+"\n"+ "vous avez gagné avec"+"\n"+pointGagnant+" points" +"!!";

            pictureBoxVictory.BackColor = Color.Transparent;
        }
    }
}
