using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
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
            Console.WriteLine("La ultima ocurrencia del numero mayor es: {0}", numeros.ToList().LastIndexOf(numeros.Max())+1);
            Console.ReadKey();
        }
    }
}
