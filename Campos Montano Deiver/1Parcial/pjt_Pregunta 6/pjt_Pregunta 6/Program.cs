using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjt_Pregunta_6
{
    class Program
    {
        static void Main(string[] args)
        
        {
            List<double> Examen = new List<double>();
            int ce;

            ce = LeerDouble("Escriba un número para su lista");

            //Lista Edad
            Examen = CargarRandom(Examen, ce, 1, 120);

            Examen.Sort();  

            int e = Examen.BinarySearch(0);

            Console.WriteLine("Examen");
            Console.WriteLine("----");
            Listar(Examen);

            //Estadistica
            Console.WriteLine("ESTADÍSTICA");
            Console.WriteLine("-------------------");
            Console.WriteLine("Suma total: " + suma(Examen).ToString());
            Console.WriteLine("Promedio: " + promedio(Examen).ToString());
            Console.WriteLine("Máximo: " + max(Examen).ToString());
            Console.WriteLine("Mínimo: " + min(Examen).ToString());
            Console.WriteLine("---------");
    

            //Salida
            Console.WriteLine();
            Console.Write("Presione una tecla para salir...");
            Console.ReadKey();
        }

        static public int LeerDouble(string msg, int vi, int vf)
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
                Console.WriteLine("ERROR:: Ingrese un nuevo número");
            }

            return n;
        }


        static public List<double> CargarRandom(List<double> l, int ne, int vi, int vf)
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


        static public void Listar(List<double> l)
        {
            //Listar los elementos de la lista
            int n = l.Count();
            int abc = 0;

            for (int i = 0; i < n; i++)
            {
                abc = l[i];
                Console.WriteLine(abc.ToString());
            }
        }


        //ESTADÍSTICA
        static public int suma(List<double> l)
        {
            int s = 0;
            int n = l.Count();

            for (int i = 0; i < n; i++)
            {
               s += l[i];
            }

            return s;
        }

        static public float promedio(List<double> l)
        {
            int n = l.Count();
            float p = 0;

            p = suma(l) / n;

            return p;
        }

        static public int min(List<double> l)
        {
            l = l.OrderBy(i => i).ToList();  //Ascendentemente

            return l[0];
        }


        static public int max(List<double> l)
        {
            l = l.OrderByDescending(i => i).ToList();  //descendente

            return l[0];
        }
    }



        }
    

