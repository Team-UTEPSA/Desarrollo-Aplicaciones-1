using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtCLI_02_operaciones_aritmeticas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("operaciones aritmeticas");
            Console.WriteLine("-----------------------");
            Console.WriteLine("");

            int a, b, r;
            string entrada;
            Console.WriteLine("escriba el valor de a");
            entrada = Console.ReadLine();
            a = int.Parse(entrada);
            Console.WriteLine("escriba el valor de b");
            entrada = Console.ReadLine();
            b = int.Parse(entrada);
            r = a + b;
            Console.WriteLine("");
            Console.WriteLine("la suma de "+ a.ToString()+"+"+b.ToString()+" es "+ r.ToString());
             Console.WriteLine("");
            Console.WriteLine("pulse cualquier tecla para  salir");
            Console.ReadKey();

        }
    }
}
