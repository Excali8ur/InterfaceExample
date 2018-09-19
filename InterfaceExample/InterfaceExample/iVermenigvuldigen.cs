using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public interface iVermenigvuldigen
    {
        /// <summary>
        /// Vermenigvuldigd van 2 getallen en retouneert het antwoord
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Resultaat van berekening</returns>
        double Vermenigvuldigen(double x);

        /// <summary>
        /// Deelt 2 getallen en retouneert het antwoord
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Resultaat van berekening</returns>
        double Delen(double x);
    }
}
