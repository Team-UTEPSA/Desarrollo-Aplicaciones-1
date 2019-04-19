using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjt_CLI_proyecto5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> lista = new List<double>();
            Console.WriteLine("lista de numeros");
            Console.WriteLine();

           
            double LD;

            LD = Leerdecimales("Escriba un número en el rango [", 1, 10000);
            Listar(lista);
            lista= Cargarlista(lista, LD, 1.0, 120.0);
            Console.ReadKey();

        }
        static public double Leerdecimales(string msg, double vi, double vf)
        {
            string entrada;
            double n = 0.0;
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
        static public List<double> Cargarlista(List<double> l, double ne, double vi, double vf)
        {
            Random randomVentas = new Random();
            double nr = 0.0;
            double i = 1.0;

            while (i <= ne)
            {
                nr = double.Parse(randomVentas.Next(vi, vf));
                l.Add(i);
                i += 1;
            }

            return l;
        }
        static public void Listar(List<double> l)
        {
            double n =l.Count();
            double iEle = 0.0;
           
            for (int i = 0; i < n; i++)
            {
                
                iEle = l[i];
                
                Console.WriteLine(iEle.ToString());
            }

        }

        
    }
}
