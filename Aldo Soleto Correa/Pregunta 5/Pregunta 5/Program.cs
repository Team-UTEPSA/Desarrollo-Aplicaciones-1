using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> lstEdad = new List<double>();
            //int ce;
            double ce;
            ce = leerDouble("Escriba la cantidad de datos que desea ingresar");
           // Listar(lstEdad);
            
            Console.WriteLine();
            Console.Write("Presione una tecla para salir...");
            Console.ReadKey();

        }
        static public void Listar(List<double> l)
        {
            string entrada;
            //int i = 1;
            double n=l.Count();
            double s = 0;
            double iEle = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Ingrese el valor N°" + s);
                entrada = Console.ReadLine();
                n = int.Parse(entrada);
                iEle = l[i];
            }
        }
        static public double leerDouble(string msg)
        {
            string entrada;
            double n = 0;
            bool esNumero = false;

            try
            {
                do
                {
                    Console.Write(msg);
                    entrada = Console.ReadLine();
                    esNumero = double.TryParse(entrada, out n);


                } while (!esNumero);
            }
            catch
            {
                Console.WriteLine("ERROR:: Ingrese un número decimal");
            }

            return n;
        }
        static public int entrada(int cant)
        {
            string n;
            Console.WriteLine("Escriba la cantidad de datos que desea ingresar");
            n = Console.ReadLine();
            return n;
        }
    }
}
