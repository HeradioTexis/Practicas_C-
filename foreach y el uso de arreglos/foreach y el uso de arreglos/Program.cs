using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach_y_el_uso_de_arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Ingrese el tamaño del vector: ");
            int n = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Gray;
            //01282456
            //Heradio Abiram Texis Virgen 
            int[] vector = new int[n];

            
            for (int i = 0; i < n; i++)
            {   
               
                Console.Write($"Ingrese el valor para el elemento {i + 1}: ");
                vector[i] =int.Parse(Console.ReadLine());
            }

           
            int contador = 0;
            foreach (int elemento in vector)
            {
                if (elemento > 100)
                {
                    contador++;
                }
            }
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine($"El número de elementos superiores a 100 es: {contador}");
         Console.ReadKey();
        }
    }
}
