using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant = 0;
            Console.Write("¿Cuántos Numeros desea ingresar?: ");
            cant = Int32.Parse(Console.ReadLine());
            int[] numeros = new int[cant];
            for (int contador = 0; contador < cant; contador++)
            {
                Console.Write("Ingrese numero {0}: ", contador + 1);
                numeros[contador] = Int32.Parse(Console.ReadLine());
            }
            for (int contador = 0; contador < cant; contador++)
            {
                if (contador >= 1)
                {
                    if (numeros[contador]>numeros[contador - 1])
                    {
                        Console.WriteLine("La posición del primer numero mayor que el anterior es: {0}", contador + 1);
                        break;
                    }
                    else if (contador + 1 == cant)
                    {
                        Console.WriteLine("El orden no es decendiente");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
