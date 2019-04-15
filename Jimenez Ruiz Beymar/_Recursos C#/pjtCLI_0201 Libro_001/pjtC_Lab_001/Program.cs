using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtC_Lab_001
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num, Aux, Dec, Uni;
            string linea;

            System.Console.Write("Ingrese un número de dos dígitos: ");
            linea = System.Console.ReadLine();
            Num = int.Parse(linea);

            Dec = Num / 10;
            Uni = Num % 10;
            Aux = (Uni * 10) + Dec;

            System.Console.WriteLine("El número invertido es: " + Aux);
            System.Console.WriteLine("");
            System.Console.WriteLine("Pulse una tecla para continuar...");
            System.Console.ReadLine();

        }
    }
}
