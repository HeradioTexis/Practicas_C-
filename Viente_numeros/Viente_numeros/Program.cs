using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viente_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //heradio Abiram texis virgen 
            //01282456
            int cantidadNumeros = 20;
            int[] numeros = new int[cantidadNumeros];

            for (int i = 0; i < cantidadNumeros; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Ingrese el número {0}: ", i + 1);
                numeros[i] = int.Parse(Console.ReadLine());
            }

            
            int mayor = numeros[0];
            int menor = numeros[0];
            for (int i = 1; i < cantidadNumeros; i++)
            {
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                }

                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("El número mayor es: {0}", mayor);
           

            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
