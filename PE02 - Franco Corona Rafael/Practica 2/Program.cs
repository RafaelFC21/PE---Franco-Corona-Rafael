using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant;
            Console.Write("¿Cuántos Numeros desea ingresar?: ");
            cant = Int32.Parse(Console.ReadLine());
            int[] numeros = new int[cant];
            for (int contador = 0; contador < cant; contador++)
            {
                Console.Write("Ingrese numero {0}: ", contador + 1);
                numeros[contador] = Int32.Parse(Console.ReadLine());
            }
            Array.Reverse(numeros);
            Console.WriteLine("Los numeros acomodados al reves son: ");
            for (int contador = 0; contador <cant; contador++)
            {
                Console.WriteLine(numeros[contador]);
            }
            Console.ReadKey();
        }
    }
}