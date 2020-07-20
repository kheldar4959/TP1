using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
   public class Cercle : Forme
    {
        public int Rayon { get; set; }

        public override double Aire => Math.PI * 2 * Rayon;

        public override double Perimetre => 2 * Math.PI * Rayon;

        public override string ToString()
        {
            return $"Cercle de rayon {Rayon}" + Environment.NewLine + base.ToString();
        }
    }

}
