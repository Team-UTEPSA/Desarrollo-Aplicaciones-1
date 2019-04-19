using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtCLI_04_Invertir_numero_de_3_cifras
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, var, dec, uni, cen;
            string entrada;
            Console.WriteLine("Ingrese un numero de tres cifras");
            Console.WriteLine();
            entrada = Console.ReadLine();
            num = int.Parse(entrada);
            cen = num / 100;
            num = num % 100;
            dec = num / 10;
            uni = num % 10;
            var = (uni * 100) + (dec * 10) + cen;
            Console.WriteLine();
            Console.WriteLine ("El numero invertido es: " + var);
            Console.WriteLine();
            Console.WriteLine("Pulse una tecla: ");
            Console.ReadLine();
        }
    }
}
