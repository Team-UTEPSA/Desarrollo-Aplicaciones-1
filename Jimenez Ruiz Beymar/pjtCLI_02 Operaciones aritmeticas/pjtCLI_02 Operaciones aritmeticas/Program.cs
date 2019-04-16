using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtCLI_02_Operaciones_aritmeticas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OPERACIONES ARITMÉTICAS");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            int a;
            int b;
            int r;
            string entrada;

            Console.Write("Escriba el valor de A: ");
            entrada = Console.ReadLine();
            a = int.Parse(entrada);

            Console.Write("Escriba el valor de B: ");
            entrada = Console.ReadLine();
            b = int.Parse(entrada);

            r = a + b;

            Console.WriteLine();
            Console.WriteLine("La suma de " + a.ToString() + " + " + b.ToString() + " es " + r.ToString());
            Console.WriteLine();
            Console.Write("Pulse una tecla para salir...");
            Console.ReadKey();
        }
    }
}
