using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtCLI_06_compra_restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(); 
            Console.WriteLine("REGISTRAR COMPRA RESTAURANT");
            Console.WriteLine();
            byte CANB, CANH, CANP;
            double A_PAGAR;
            string entrada;
            const double precioB = 0.8;
            const double precioH = 2;
            const double precioP = 1.2;
            Console.WriteLine("cantidad de hamburguesas: ");
            entrada = Console.ReadLine();
            CANH = byte.Parse(entrada);
            Console.Write("cantidad de papas :");
            entrada = Console.ReadLine();
            CANP = byte.Parse(entrada);
            Console.Write("cantidad  de  bebidas :");
            entrada = Console.ReadLine();
            CANB = byte.Parse(entrada);
            Console.WriteLine();
            A_PAGAR = (CANH * precioH) + (CANP * precioP) + (CANB * precioB);
            Console.WriteLine("VALOR A PAGAR: " + A_PAGAR);
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}
