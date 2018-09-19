using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public interface iTellen
    {
        double Getal { get;}

        /// <summary>
        /// Telt 2 getallen bij elkaar op en retouneert het antwoord
        /// </summary>
        /// <param name="x"></param>
        /// <returns>Resultaat van berekening</returns>
        double Optellen(double x);

        /// <summary>
        /// Trekt 2 getallen van elkaar af en retouneert het antwoord
        /// </summary>
        /// <param name="x"></param>
        /// <returns>Resultaat van berekening</returns>
        double Aftrekken(double x);
    }
}
