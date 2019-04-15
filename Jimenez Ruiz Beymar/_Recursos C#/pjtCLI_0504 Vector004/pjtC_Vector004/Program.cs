using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtC_Vector004
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            double EdadSumatoria = 0;
            double EdadPromedio = 0;
            int k;

            System.Console.Write("Número de ventas: ");
            entrada = System.Console.ReadLine();
            k = int.Parse(entrada);

            double[] vVentas = new double[k + 1];

            Random rnd = new Random();

            for (int i = 0; i < k; i++)
            {
                vVentas[i] = rnd.Next(1, 99);
            }

            System.Console.WriteLine("\n");
            System.Console.WriteLine("LISTA DE VENTAS");
            System.Console.WriteLine("---------------");

            for (int i = 0; i < k; i++)
            {
                System.Console.WriteLine("[{0}] {1}", i + 1, vVentas[i]);
                EdadSumatoria = EdadSumatoria + vVentas[i];
            }

            EdadPromedio = EdadSumatoria / k;

            System.Console.WriteLine("");
            System.Console.WriteLine("Cantidad elementos: {0}", k);
            System.Console.WriteLine("Sumatoria elementos: {0}", EdadSumatoria);
            System.Console.WriteLine("Promedio elementos: {0}", EdadPromedio);
            System.Console.WriteLine("Primer elemento: {0}", vVentas[0]);
            System.Console.WriteLine("Último elemento: {0}", vVentas[k - 1]);
            System.Console.ReadLine();
        }
    }
}
