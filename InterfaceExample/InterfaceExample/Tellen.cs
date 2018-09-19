using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class Tellen : iTellen, iVermenigvuldigen
    {
        private double getal = 1;

        public double Optellen(double x)
        {
            getal += x;
            return getal;
        }

        public double Aftrekken(double x)
        {
            getal -= x;
            return getal;
        }

        public double Vermenigvuldigen(double x)
        {
            getal *= x;
            return getal;
        }

        public double Delen(double x)
        {
            if (x == 0)
            {
                throw new DivideByZeroException("Delen door nul is flauwekul");
            }
            else
            {
                getal /= x;
                return getal;
            }
        }
    }
}
