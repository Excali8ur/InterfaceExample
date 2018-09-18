using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class Tellen : iTellen
    {
        public int Optellen(int x, int y)
        {
            return x + y;
        }

        public int Aftrekken(int x, int y)
        {
            return x - y;
        }

        public float Vermenigvuldigen(int x, int y)
        {
            return x * y;
        }

        public float Delen(int x, int y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Delen door nul is flauwekul");
            }
            else
            {
                return x / y;
            }
        }
    }
}
