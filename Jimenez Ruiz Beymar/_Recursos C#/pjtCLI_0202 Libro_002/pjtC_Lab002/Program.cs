using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtC_Lab002
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num, Aux, Dec, Uni, Cen;
            string linea;
            System.Console.WriteLine("Ingrese un número de tres dígitos");
            linea = System.Console.ReadLine();
            Num = int.Parse(linea);
			
            Cen = Num / 100;
            Num = Num % 100;
            Dec = Num / 10;
            Uni = Num % 10;
            Aux = (Uni * 100) + (Dec * 10) + Cen;
			
            System.Console.WriteLine("El número invertido es: " + Aux);
            System.Console.WriteLine("Pulse una tecla para finalizar");
        }
    }
}
