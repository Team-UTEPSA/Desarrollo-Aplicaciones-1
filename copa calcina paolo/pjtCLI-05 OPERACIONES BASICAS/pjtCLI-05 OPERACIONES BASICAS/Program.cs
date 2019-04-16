using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtCLI_05_OPERACIONES_BASICAS
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b,c,D;
            
            string entrada;
            Console.Write("INSERTE EL PRIMER NUMERO ");
            entrada = Console.ReadLine();
            a = int.Parse(entrada);

            Console.Write("INSERTE EL SEGUNDO NUMERO ");
            entrada = Console.ReadLine();
            b = int.Parse(entrada);

            Console.WriteLine();
            c = a + b;
            Console.WriteLine("LA SUMA ES= "+c);

            c = a - b;
            Console.WriteLine("LA RESTA ES= " + c);

            c = a * b;
            Console.WriteLine("LA MULTIPLICACION ES= " + c);

            D = a / b;
            Console.WriteLine("LA DIVICION ES= " +D);

            c = a % b;
            Console.WriteLine("EL RESIDUO ES= " + c);
            Console.WriteLine("PRECIONE UNA TECLA");
            Console.ReadLine();

        }
    }
}
