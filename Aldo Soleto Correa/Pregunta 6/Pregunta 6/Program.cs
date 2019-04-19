using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_6
{
    class Program
    {
        static List<double> lst = new List<double>();
        static void Main(string[] args)
        {

            Console.WriteLine("**********LISTA DE PRECIOS**************** ");
            //Lista Edad
            cargar();
            listar();
            Console.WriteLine("Suma total: " + suma(lst).ToString());
            Console.WriteLine("Promedio: " + promedio(lst).ToString());
            Console.WriteLine("Venta Maxima: " + maxVenta(lst).ToString());
            Console.WriteLine("Venta Minima: " + min(lst).ToString());
            //Salida
            Console.WriteLine();
            Console.Write("Presione una tecla para salir...");
            Console.ReadKey();
        }

        static public void cargar()
        {
            //Cargar lista con elementos
            lst.Add(15.5);
            lst.Add(30.5);
            lst.Add(5.2);
            lst.Add(6.2);
            lst.Add(0.2);

        }

        static public void listar()
        {
            double n = lst.Count();
            double iEle = 0;
            for (int i = 0; i < n; i++)
            {
                iEle = lst[i];
                Console.WriteLine(iEle.ToString());
            }

        }

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

            p =  suma(l) / n;

            return p;
        }

        static public double maxVenta(List<double> l)
        {
            l = l.OrderByDescending(i => i).ToList();  //Lista Ordenada Ascendentemente

            return l[0];
        }
        static public double min(List<double> l)
        {
            l = l.OrderBy(i => i).ToList();  //Lista Ordenada Ascendentemente

            return l[0];
        }
    }
}
