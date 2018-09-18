using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public interface iTellen
    {
        /// <summary>
        /// Telt 2 getallen bij elkaar op en retouneert het antwoord
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Resultaat van berekening</returns>
        int Optellen(int x, int y);
        
        /// <summary>
        /// Trekt 2 getallen van elkaar af en retouneert het antwoord
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Resultaat van berekening</returns>
        int Aftrekken(int x, int y);

        /// <summary>
        /// Vermenigvuldigd van 2 getallen en retouneert het antwoord
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Resultaat van berekening</returns>
        float Vermenigvuldigen(int x, int y);

        /// <summary>
        /// Deelt 2 getallen en retouneert het antwoord
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Resultaat van berekening</returns>
        float Delen(int x, int y);

    }
}
