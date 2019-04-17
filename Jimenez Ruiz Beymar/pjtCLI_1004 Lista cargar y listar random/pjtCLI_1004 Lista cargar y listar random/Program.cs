using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtCLI_1004_Lista_cargar_y_listar_random
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lstEdad = new List<int>();
            string entrada;
            int ce;

            Console.Write("Ingrese la cantidad de elementos de la lista: ");
            entrada = Console.ReadLine();
            ce = int.Parse(entrada);
            
            //Lista Edad
            lstEdad = CargarRandom(lstEdad, ce, 1, 120);

            Console.WriteLine("\nEDAD");
            Console.WriteLine("----");
            Listar(lstEdad);

            //Salida
            Console.WriteLine();
            Console.Write("Presione una tecla para salir...");
            Console.ReadKey();
        }


        static public List<int> CargarRandom(List<int> l, int ne, int vi, int vf)
        {
            Random randomVentas = new Random();
            int nr = 0;
            int i = 1;

            while (i<ne)
            {
                nr = randomVentas.Next(vi, vf);
                l.Add(nr);
                i += 1;
            }

            return l;
        }


        static public void Listar(List<int> l)
        {
            //Listar los elementos de la lista
            int n = l.Count();
            int iEle = 0;

            for (int i = 0; i < n; i++)
            {
                iEle = l[i];
                Console.WriteLine(iEle.ToString());
            }
        }

    }
}
