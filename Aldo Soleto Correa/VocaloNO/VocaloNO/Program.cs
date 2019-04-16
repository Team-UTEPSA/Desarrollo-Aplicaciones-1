using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocaloNO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que pide una letra y dice si es vocal o no
            string letra;
            Console.WriteLine("Digite una letra");
            letra = Console.ReadLine();

            if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
            {
                Console.WriteLine("La letra \"{0}\" es vocal", letra);
            }
            else
            {
                Console.WriteLine("La letra \"{0}\" NO! es vocal", letra);
            }
            Console.ReadKey();
        }
    }
}
