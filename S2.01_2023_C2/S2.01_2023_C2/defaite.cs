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
    public partial class defaite : Form
    {
        public defaite(string nomJoueur)
        {
            InitializeComponent();
            pictureBoxDefaite.BackColor = Color.Transparent;
            labelDefaite.BackColor = Color.Transparent;
            labelDefaite.ForeColor = Color.White;

            labelDefaite.Text = "Dommage ! "+nomJoueur+" vous êtes éléminé";
        }
    }
}
