using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjt_Pregunta_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> examen = new List<double>();
            int ce;
           
            ce = LeerInt("Escriba un número en el rango [", 1, 100);
           // ce = LeerInt("Escriba un número para la lista");

            //Lista Examen
            examen = CargarRandom(examen, ce, 1, 120);

            examen.Sort(); 

            int e = examen.BinarySearch(0);

            Console.WriteLine("EXAMEN");
            Console.WriteLine("----");
            Listar(examen);

        

            Console.WriteLine("-------------------");
           
           

            //Para Salir
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
                Console.WriteLine("Ingrese un número en el rango [1 ; 100]");
            }

            return n;
        }


        static public List<int> CargarRandom(List<int> l, int ne, int vi, int vf)
        {
            Random randomVentas = new Random();
            double nr = 0;
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
            
            double n = l.Count();
            double iEle = 0;

            for (int i = 0; i < n; i++)
            {
                iEle = l[i];
                Console.WriteLine(iEle.ToString());
            }
        }
    }
    }

