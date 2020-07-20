using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
   public class Carre : Forme
    {
        public int Longueur { get; set; }

        public override double Aire => Longueur * Longueur;

        public override double Perimetre => Longueur * 4;

        public override string ToString()
        {
            return $"Carré de côté={Longueur}" + Environment.NewLine + base.ToString();
        }
    }
}
