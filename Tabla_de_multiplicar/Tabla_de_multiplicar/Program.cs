using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabla_de_multiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Heradio Abiram Texis Virgen 
            //01282456
            int flag = 0, number;
            Console.WriteLine("Bienvenido!!!");
            Console.WriteLine("Tabla de multiplicar del 0 al 10");
            Console.WriteLine("Ingresa un numero:");
            number = int.Parse(Console.ReadLine());
            while (flag <= 10)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(number + " x " + flag + " = " + (number * flag));
                flag++;
            }
            Console.ReadLine();

        }
    }
}
