using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtC_Vector002
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

            //string[] vNombreOrdenado = vNombre.ToArray();
            //string[] vNombreOrdenado = vNombre.OrderBy(i => i).ToArray();  //i=>i descripción de la función lambda, que describe como ordenar la matriz
            string[] vNombreOrdenado = (from element in vNombre orderby element ascending select element).ToArray();
            //string[] vNombreOrdenado = (from element in vNombre orderby element descending select element).ToArray();

            System.Console.WriteLine("LISTA ORDENADA");
            System.Console.WriteLine("--------------");

            foreach (var item in vNombreOrdenado)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("");
            System.Console.WriteLine("Primer elemento: " + vNombreOrdenado[0]);
            System.Console.WriteLine("Último elemento: " + vNombreOrdenado[k - 1]);
            System.Console.WriteLine("Total elementos: " + k);
            System.Console.ReadLine();
        }
    }
}
