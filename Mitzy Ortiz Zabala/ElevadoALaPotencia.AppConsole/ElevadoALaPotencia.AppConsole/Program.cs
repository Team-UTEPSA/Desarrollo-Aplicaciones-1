using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevadoALaPotencia.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            double entrada, pot, resul;
            Console.WriteLine();
            Console.WriteLine("ELEVAR A LA POTENCIA UN NÚMERO");
            Console.WriteLine("_____________________________");
            Console.WriteLine();
            Console.WriteLine("Ingrese un número: ");
            entrada = double.Parse(Console.ReadLine());
            Console.WriteLine("Elevado a la potencia: ");
            pot = double.Parse(Console.ReadLine());
            resul = Math.Pow(entrada, pot);
            Console.WriteLine("El resultado es: " + resul);
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Presione Enter para salir");
            Console.ReadLine();
        }
    }
}
