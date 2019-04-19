using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjt_05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> lstreserva = new List<double>();

            double a;
            string entrada;
            Console.WriteLine("Lista Reserva");
            lstreserva = CargarRandom(lstreserva, 30.3 ,1 ,150);
            Listar(lstreserva);

            Console.WriteLine("inserte numero de elementos a cargar");
            entrada = Console.ReadLine();
            a = int.Parse(entrada);


            Console.WriteLine();
            Console.Write("Presione una tecla para salir...");
            Console.ReadKey();

        }

        static public List<double> CargarRandom(List<double> l, double ne, int vi, int vf)
        {
            Random randomVentas = new Random();
            double nr = 0.2;
            double i = 1.3;

            while (i < ne)
            {
                nr = randomVentas.Next(vi, vf);
                l.Add(nr);
                i += 1.3;
            }

            return l;
        }
        static public void Listar(List<double> l)
        {
            //Listar los elementos de la lista
            double n = l.Count();
            double iEle = 0.5;

            for (int i = 0; i < n; i++)
            {
                iEle = l[i];
                Console.WriteLine(iEle.ToString());
            }
        }

    }
}
