using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lstEdad = new List<int>();
            int ce;

            ce = LeerInt("Escriba un numero en el rango [", 1, 50);

            lstEdad = CargarRandom(lstEdad, ce, 1, 120);

            int e = lstEdad.BinarySearch(0);

            Console.WriteLine("\n-----EDAD-----");
            Listar(lstEdad);

            Console.WriteLine();
            Console.Write("Presione una Enter para continuar...");
            Console.ReadKey();
            Console.Clear();
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
                    Console.WriteLine(msg + vi.ToString() + " ; " + vf.ToString() + "]: ");
                    entrada = Console.ReadLine();
                    esNumero = int.TryParse(entrada, out n);
                } while (n < vi || n > vf || !esNumero);
            }
            catch
            {
                Console.WriteLine("ERROR:: Ingrese un numero en el rango (1 ; 50)");
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
