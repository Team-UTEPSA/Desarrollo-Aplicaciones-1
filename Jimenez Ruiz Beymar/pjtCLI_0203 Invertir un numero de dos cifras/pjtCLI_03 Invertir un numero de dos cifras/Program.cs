using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtCLI_03_Invertir_un_numero_de_dos_cifras
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, inv, dec, uni;
            string entrada;

            Console.WriteLine("INVERTIR UN NÚMERO DE DOS DÍGITOS");
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            Console.Write("Escriba un número de dos dígitos: ");
            entrada = Console.ReadLine();
            num = int.Parse(entrada);
            dec = num / 10;
            uni = num % 10;
            inv = (uni * 10) + dec;
            Console.WriteLine();
            Console.WriteLine("El número " + num.ToString() + " invertido es " + inv.ToString());
            Console.WriteLine();
            Console.Write("Pulse una tecla para salir... ");
            Console.ReadKey();
        }
    }
}
