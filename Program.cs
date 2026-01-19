using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo XD ");
            Console.WriteLine("------------Calculadora------------");
            
            Console.WriteLine("SELECCIONE TIPO DE OPERCION \n [ 1 ] SUMA \n [ 2 ] RESTA\n [ 3 ] MULTIPLICACION\n [ 4 ] DIVISION");
            int op = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Primer Numero");
            double num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Segundo Numero");
            double num2 = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Suma miSuma = new Suma();
                    miSuma.Calcular(num1, num2);
                    break;
                case 2:
                    Resta miResta = new Resta();
                    miResta.Calcular(num1, num2);
                    break;
                case 3:
                    Multiplicacion miMulti = new Multiplicacion();
                    miMulti.Calcular(num1, num2);
                    break;
                case 4:
                    Division miDivision = new Division();
                    miDivision.Calcular(num1, num2);
                    break;
            }
        }
    }
}