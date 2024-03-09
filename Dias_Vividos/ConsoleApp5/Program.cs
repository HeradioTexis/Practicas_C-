using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nombre, apellidoP, apellidoM, telefono, direccion, sexo;
            int A,diasV;
            //0128246
            //headio Abiram texis Virgen 
            //pedir datos 
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("cual es tu nombre?");
            nombre = Console.ReadLine();

            Console.WriteLine("cul es tu apellido paterno?");
            apellidoP= Console.ReadLine();

            Console.WriteLine("cul es tu apellido Materno?");
            apellidoM= Console.ReadLine();

            Console.WriteLine("dame tu año de nacimiento :");
            A= int.Parse(Console.ReadLine());
            
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - A;
            DateTime fechaNacimiento = new DateTime(A, 1, 1);
            diasV = (int)(fechaActual - fechaNacimiento).TotalDays;

            Console.WriteLine("dame tu numeo de telfono?");
            telefono= Console.ReadLine();
            Console.WriteLine("dame tu numeo de genero?");
            sexo= Console.ReadLine();
            Console.WriteLine("dame tu numeo de direccio?");
            direccion= Console.ReadLine();
            Console.ResetColor();
            //imprimir 


            Console.WriteLine("Tu nombre es : "+nombre);
            Console.WriteLine("Tu Apellido pateno es : " + apellidoP);
            Console.WriteLine("Tu Apelido matern es : " + apellidoM);
            Console.WriteLine("Tu direccion es : " + direccion);
            Console.WriteLine("Tu edad es : " + edad);
            Console.WriteLine("Tu genero es : " + sexo);
            Console.WriteLine("Tu telefono es : " + telefono);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ha vivido aproximadamente " +diasV +" días.");
            Console.ReadKey();
        }
    }
}
