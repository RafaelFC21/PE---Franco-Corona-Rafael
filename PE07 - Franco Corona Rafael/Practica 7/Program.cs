using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant = 0;
            Console.Write("?Cuantos Numeros random del 1 al 100 desea obtener?: ");
            cant = Int32.Parse(Console.ReadLine());
            Random Numeros = new Random();
            int[] Centenar = new int[cant];
            Console.WriteLine("Numeros Random: ");
            for (int contador = 0; contador < cant; contador++)
            {
                int centenar = Numeros.Next(1, 100);
                Centenar[contador] = centenar;
                Console.WriteLine(centenar);
            }
            Array.Sort(Centenar);
            Console.WriteLine("Numeros Random acomodados en orden acendente: ");
            for (int contador = 0; contador < cant; contador++)
            {
                Console.WriteLine(Centenar[contador]);
            }
            Console.ReadKey();
        }
    }
}
