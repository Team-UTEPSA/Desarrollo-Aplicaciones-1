using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjt_CLI_proyecto6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> lista = new List<double>();
            Console.WriteLine("lista de numeros");
            Console.WriteLine();

            double nro = 0;
            while (nro > 0.1)
            { nro += 1;
                lista.Add(nro);
            }

            //nro = 12.9;

            //lista.Min();
            //lista.Max();

        }
             // return nro;   
         
        static public double suma(List<double> l)
        {
            double s = 0.0;
            int n = l.Count();
       
            for (int i = 0; i < n; i++)
            {
                s += l.Count();

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
