using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtCLI_1005_lista_validar_entradas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lstEdad = new List<int>();
            int ce;

            ce = LeerInt("Escriba un número en el rango [", 1, 10000);

            //Lista Edad
            lstEdad = CargarRandom(lstEdad, ce, 1, 120);
            
            lstEdad.Sort();  //Lista Ordenada Ascendentemente

            int e = lstEdad.BinarySearch(0);

            Console.WriteLine("\nEDAD");
            Console.WriteLine("----");
            Listar(lstEdad);

            //Estadistica
            Console.WriteLine("\nESTADÍSTICA GENERAL");
            Console.WriteLine("-------------------");
            Console.WriteLine("Suma total: " + suma(lstEdad).ToString());
            Console.WriteLine("Promedio: " + promedio(lstEdad).ToString());
            Console.WriteLine("Máximo: " + max(lstEdad).ToString());
            Console.WriteLine("Mínimo: " + min(lstEdad).ToString());
            Console.WriteLine("---------");
            Console.WriteLine("Existe? " + e.ToString());
            
            //Salida
            Console.WriteLine();
            Console.Write("Presione una tecla para salir...");
            Console.ReadKey();
        }

        static public int LeerInt(string msg, int vi, int vf)
        {
            string entrada;
            int n = 0;
            bool esNumero = false;
            
            try
            {
                do
                {
                    Console.Write(msg + vi.ToString() + " ; " + vf.ToString() + "]: ");
                    entrada = Console.ReadLine();
                    esNumero = int.TryParse(entrada, out n);
                } while (n < vi || n > vf || !esNumero);
            }
            catch
            {
                Console.WriteLine("ERROR:: Ingrese un número en el rango [1 ; 10000]");
            }           

            return n;
        }


        static public List<int> CargarRandom(List<int> l, int ne, int vi, int vf)
        {
            Random randomVentas = new Random();
            int nr = 0;
            int i = 1;

            while (i <= ne)
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

        
        //METODOS DE ESTADÍSTICA
        static public int suma(List<int> l)
        {
            int s = 0;
            int n = l.Count();

            for (int i=0; i<n; i++)
            {
                s += l[i];
            }

            return s;
        }

        static public float promedio(List<int> l)
        {
            int n = l.Count();
            float p = 0;

            p = suma(l) / n;

            return p;
        }

        static public int min(List<int> l)
        {
            l = l.OrderBy(i => i).ToList();  //Lista Ordenada Ascendentemente

            return l[0];
        }


        static public int max(List<int> l)
        {
            l = l.OrderByDescending(i => i).ToList();  //Lista Ordenada Ascendentemente

            return l[0];
        }


    }
}
