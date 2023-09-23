using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S2._01_2023_C2
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MenuEntre mn = new MenuEntre();
            if (mn.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            ChoixNombreJoueur ch = new ChoixNombreJoueur();
            if (ch.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            GameView gameView = new GameView(ch.getChoixNbJoueur());

            Partie partie = new Partie(ch.getChoixNbJoueur(), gameView);
            gameView.SetPartie(partie);

            partie.DebutPartie();
            Application.Run(gameView);
        }
    }
}
