using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtC_Vector003
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vEdad = { 8, 3, 2, 5, 1, 4, 7, 6, 9, 11 };
            double EdadSumatoria = 0;
            double EdadPromedio = 0;

            int k = vEdad.Length;

            System.Console.WriteLine("LISTA SIN ORDENAR");
            System.Console.WriteLine("-----------------");

            for (int i = 0; i < k; i++)
            {
                System.Console.WriteLine(vEdad[i]);
            }

            System.Console.WriteLine("\n");

            System.Console.WriteLine("LISTA ORDENADA");
            System.Console.WriteLine("--------------");
            Array.Sort(vEdad);

            for (int i = 0; i < k; i++)
            {
                System.Console.WriteLine(vEdad[i]);
                EdadSumatoria = EdadSumatoria + vEdad[i];
            }

            EdadPromedio = EdadSumatoria / k;

            System.Console.WriteLine("");
            System.Console.WriteLine("Primer elemento: {0}", vEdad[0]);
            System.Console.WriteLine("Último elemento: {0}", vEdad[k - 1]);
            System.Console.WriteLine("Cantidad elementos: {0}", k);
            System.Console.WriteLine("Sumatoria elementos: {0}", EdadSumatoria);
            System.Console.WriteLine("Promedio elementos: {0}", EdadPromedio);
            System.Console.ReadLine();
        }
    }
}
