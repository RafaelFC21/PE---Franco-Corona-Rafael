using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[3];
            for (int contador = 0; contador < 3; contador++)
            {
                Console.Write("Ingrese numero {0}: ", contador+1);
                numeros[contador] = Console.ReadLine();
            }
            Console.WriteLine("El numero menor es: " + numeros.Min());
            Console.ReadKey();
        }
    }
}
