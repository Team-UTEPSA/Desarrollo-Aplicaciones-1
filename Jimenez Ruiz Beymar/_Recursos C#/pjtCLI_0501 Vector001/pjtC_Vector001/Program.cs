using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtC_Vector001
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vNombre = { "Zenaida", "Rosario", "Andrea", "Lorena", "Esteban", "Ariel", "Pedro", "Carolina" };
            
            int k = vNombre.Length;

            System.Console.WriteLine("LISTA SIN ORDENAR");
            System.Console.WriteLine("-----------------");

            for (int i = 0; i < k; i++)
            {
                System.Console.WriteLine(vNombre[i]);
            }

            System.Console.WriteLine("\n");

            Array.Sort(vNombre);

            System.Console.WriteLine("LISTA ORDENADA");
            System.Console.WriteLine("--------------");

            for (int i = 0; i < k; i++)
            {
                System.Console.WriteLine(vNombre[i]);
            }

            System.Console.WriteLine("");
            System.Console.WriteLine("Primer elemento: " + vNombre[0]);
            System.Console.WriteLine("Último elemento: " + vNombre[k-1]);
            System.Console.WriteLine("Total elementos: " + k);
            System.Console.ReadLine();
        }
    }
}
