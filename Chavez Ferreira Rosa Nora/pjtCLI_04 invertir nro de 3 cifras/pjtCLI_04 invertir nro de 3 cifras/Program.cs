using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtCLI_04_invertir_nro_de_3_cifras
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, inv, dec, uni, cen;
            string entrada;

            Console.WriteLine("INVERTIR NUMEROS DE TRES CIFRAS ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            Console.WriteLine("ingrese  numero de 3 cifras");
            entrada = Console.ReadLine();
            num = int.Parse(entrada);
            cen = num / 100;
            num = num % 10;
            uni = num % 100;
            dec = num / 10;

            inv = (uni * 100) + (dec / 10) + cen;

            Console.WriteLine();
            Console.WriteLine("el numero "+ num.ToString() + " es invertido " + inv.ToString());
            Console.WriteLine();
            Console.WriteLine("pulse una tecla para salir...");
            Console.ReadKey();
        }
    }
}
