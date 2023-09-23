using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2._01_2023_C2
{
    /// <summary>
    /// simple enumeration des couleurs des cartes
    /// contient les 7 couleurs de base et une couleur NONE qui servait pour attribuer une couleur aléatoire
    /// </summary>

    //NONE a garder on risque d'en avoir re besoin
    public enum CarteCouleur
    {
        JAUNE,
        BLEU,
        ROUGE,
        VERT,
        VIOLET,
        NOIR,
        BLANC,
        NONE
    }
}