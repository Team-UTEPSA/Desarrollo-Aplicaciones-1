using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtCLI_04_invetir_numero_de_tres_cifras
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, dec, inv, cen, uni;
            string entrada;
            Console.Write("INVERTIR NUMERO DE TRES DIGITOS");
            Console.WriteLine();
            Console.WriteLine("INGRESE TRES NUMEROS");
            entrada = Console.ReadLine();
            num = int.Parse(entrada);
            cen = num / 100;
            num = num % 100;
            dec = num / 10;
            uni = num % 10;
            inv = (uni * 100) + (dec * 10) + cen;
            Console.WriteLine();
            Console.WriteLine("NUMERO INVERTIDO ES " + inv);
            Console.WriteLine();
            Console.WriteLine("pulse cualquier tecla para salir");
            Console.ReadLine();
            
        }
    }
}
