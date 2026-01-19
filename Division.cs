using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Division
    {
        public void Calcular(double a, double b)
        {
            if (a == 0 && b == 0)
            {
                Console.WriteLine("No se puede Realizar la operacion");
            }
            else
            {
                Console.WriteLine($"El Resultado de la Division es{a / b}");
            }
        }
    }
}
