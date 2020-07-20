using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
    public abstract class Forme
    {
        public abstract double Aire { get; }
        public abstract double Perimetre { get; }

        public override string ToString()
        {
            return $"Aire = {Aire}" + Environment.NewLine + $"Périmètre = {Perimetre}" + Environment.NewLine;
        }
    }


}
