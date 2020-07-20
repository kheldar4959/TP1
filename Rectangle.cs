using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
    public class Rectangle : Forme
    {
        public int Largeur { get; set; }
        public int Longueur { get; set; }

        public override double Aire => Largeur * Longueur;

        public override double Perimetre => 2 * (Largeur +  Longueur) ;

        public override string ToString()
        {
            return $"Rectancle de côté={Longueur} et largeur = { Largeur }" + Environment.NewLine + base.ToString();
        }
    }
}
