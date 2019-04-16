using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtCLI_03__invertir_nro_de_2cifras
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM, inv, DEC, UNI;
            string entrada;

            Console.WriteLine("INEVERTIR UN NUMERO DE DOS DIGITOS");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();
            Console.Write("escriba un numero de dos digitos:");
            entrada = Console.ReadLine();
            NUM = int.Parse(entrada);
            DEC = NUM / 10;
            UNI = NUM % 10;
            inv = (UNI * 10) +DEC;

            Console.WriteLine("");
            Console.WriteLine("el numero "+ NUM.ToString() + " invertido es " + inv.ToString());
            Console.WriteLine();
            Console.WriteLine("pulse una tecla para salir...");
            Console.ReadKey();
        }
    }
}
