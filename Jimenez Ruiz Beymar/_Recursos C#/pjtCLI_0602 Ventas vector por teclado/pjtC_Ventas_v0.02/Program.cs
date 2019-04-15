using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtC_Ventas_v0._02
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            double sumatoriaVentas = 0;
            double venta;
            int k;

            Console.Write("Ingrese el número de ventas: ");
            entrada = Console.ReadLine();
            k = int.Parse(entrada);

            double[] vectorVentas = new double[k];

            for (int i = 0; i < k; i++)
            {
                Console.Write("Ingrese la venta: ");
                entrada = Console.ReadLine();
                venta = double.Parse(entrada);
                vectorVentas[i] = venta;
            }

            Console.WriteLine("\nLISTA DE VENTAS\n\n");

            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("[{0}]  {1}", i, vectorVentas[i]);
                sumatoriaVentas = sumatoriaVentas + vectorVentas[i];
            }

            Console.WriteLine("\nNúmero de Ventas: {0}", k);
            Console.WriteLine("\nTotal Ventas: {0}", sumatoriaVentas);
            Console.WriteLine("\nPromedio de Ventas: {0}", sumatoriaVentas / k);

            Console.Read();



        }
    }
}
