using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                try
                {
                    int numero = 0;
                    int result, number = 0;
                    Console.Write("Ingrese numero: ");
                    numero = int.Parse(Console.ReadLine());
                    Console.Clear();
                    int copia_numero = numero;
                    int length = copia_numero.ToString().Length;
                    if (length != 5)
                        throw new IndexOutOfRangeException("Ingrese un numero de 5 digitos");
                    else
                    {
                        int Original = numero;
                        for (int contador = 0; contador < 4; contador++)
                        {
                            result = numero % 10;
                            numero = numero / 10;
                            number = (number + result) * 10;
                        }
                        int Reverse = number + numero;
                        if (Original == Reverse)
                            Console.WriteLine("El numero es un palíndromo");
                        else
                            Console.WriteLine("El numero no es un palíndromo");

                    }
                    Console.WriteLine("¿Desea ingresar otro número?" +
                        "\n1.- Si" +
                        "\n2.- No");
                    opcion = Int16.Parse(Console.ReadLine());
                    Console.Clear();
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            while (opcion == 1);
        }
    }
}
