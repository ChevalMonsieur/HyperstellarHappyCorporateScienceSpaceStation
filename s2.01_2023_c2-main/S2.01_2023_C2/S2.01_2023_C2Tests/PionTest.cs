global using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using S2._01_2023_C2;
using System.Drawing;

namespace S2._01_2023_C2Tests
{
    [TestClass]
    public class PionTest
    {
        [TestMethod]
        public void DeplacerPion()
        {
            Joueur testJoueur1 = new Joueur();
            Pion p = new Pion(testJoueur1);
            p.Deplacer(new Point(0, 0));
            Assert.IsTrue(new Point(0, 0).Equals(p.position));
        }
    }
}
