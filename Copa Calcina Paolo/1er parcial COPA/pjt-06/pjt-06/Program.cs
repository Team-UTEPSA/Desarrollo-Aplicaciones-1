using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjt_06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> lstEdad = new List<double>();
            double ce;

            ce = LeerInt("Escriba un número en el rango [", 1, 10000);

            //Lista Edad
            lstEdad = CargarRandom(lstEdad, ce, 1, 120);

            lstEdad.Sort();  //Lista Ordenada Ascendentemente

            double e = lstEdad.BinarySearch(0);

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
        static public double LeerInt(string msg, double vi, double vf)
        {
            string entrada;
            double n = 0;
            bool esNumero = false;

            try
            {
                do
                {
                    Console.Write(msg + vi.ToString() + " ; " + vf.ToString() + "]: ");
                    entrada = Console.ReadLine();
                    esNumero = double.TryParse(entrada, out n);
                } while (n < vi || n > vf || !esNumero);
            }
            catch
            {
                Console.WriteLine("ERROR:: Ingrese un número en el rango [1 ; 10000]");
            }

            return n;
        }
        static public List<double> CargarRandom(List<double> l, double ne, int vi, int vf)
        {
            Random randomVentas = new Random();
            double nr = 0;
            double i = 1;

            while (i <= ne)
            {
                nr = randomVentas.Next(vi, vf);
                l.Add(nr);
                i += 1;
            }

            return l;
        }

        static public void Listar(List<double> l)
        {
            //Listar los elementos de la lista
            double n = l.Count();
            double iEle = 0;

            for (int i = 0; i < n; i++)
            {
                iEle = l[i];
                Console.WriteLine(iEle.ToString());
            }
        }
        //METODOS DE ESTADÍSTICA
        static public double suma(List<double> l)
        {
            double s = 0;
            double n = l.Count();

            for (int i = 0; i < n; i++)
            {
                s += l[i];
            }

            return s;
        }

        static public double promedio(List<double> l)
        {
            double n = l.Count();
            double p = 0;

            p = suma(l) / n;

            return p;
        }

        static public double min(List<double> l)
        {
            l = l.OrderBy(i => i).ToList();  //Lista Ordenada Ascendentemente

            return l[0];
        }


        static public double max(List<double> l)
        {
            l = l.OrderByDescending(i => i).ToList();  //Lista Ordenada Ascendentemente

            return l[0];
        }

    }
}
