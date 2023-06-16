using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un valor numerico:");
            int num1 = int.Parse(Console.ReadLine());

            do
            {
                if (num1 % 2 == 0)
                {
                    Console.WriteLine("El numero: " + num1 + " es par");
                }
                else
                {
                    Console.WriteLine("El numero: " + num1 + " es impar");
                }
                Console.WriteLine("Ingrese otro valor numerico (0 para salir):");
                num1 = int.Parse(Console.ReadLine());

            } while (num1 != 0);

            Console.ReadKey();
        }
    }
}
