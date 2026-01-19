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

            int op;
            bool opcionValida = false;
            do
            {
                Console.WriteLine("\nSELECCIONE TIPO DE OPERACION \n [ 1 ] SUMA \n [ 2 ] RESTA\n [ 3 ] MULTIPLICACION\n [ 4 ] DIVISION");

                // Intentamos convertir la entrada a entero
                if (int.TryParse(Console.ReadLine(), out op) && op >= 1 && op <= 4)
                {
                    opcionValida = true;
                }
                else
                {
                    Console.WriteLine("⚠️ Error: Ingrese un número válido (1, 2, 3 o 4).");
                }

            } while (!opcionValida);
            Console.WriteLine("Ingrese el Primer Numero:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Segundo Numero:");
            double num2 = double.Parse(Console.ReadLine());

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
                    // Validación extra para no dividir por cero
                    if (num2 != 0)
                    {
                        Division miDivision = new Division();
                        miDivision.Calcular(num1, num2);
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero.");
                    }
                    break;
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}