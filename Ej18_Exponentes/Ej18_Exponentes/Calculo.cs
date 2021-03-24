using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej18_Exponentes
{
    class Calculo
    {
        public double Exponente (double x)
        {
            
            double suma = 0;
            for (double i = 1; i <= x; i++)
            {
                double a = 1;
                double b = Math.Pow(x, i);
                for (int j = 1; j <= i; j++)
                {
                    a = a * j;

                }
                double d = b / a;
                suma = suma + d;

            }
            suma = suma + 1;
            return suma;
        }
    }
}
