using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtCLI_1003_Lista_cargar_listar_proc_y_func
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lstEdad = new List<int>();
            List<int> lstPeso = new List<int>();

            //Lista Edad
            Console.WriteLine("Lista EDAD");
            lstEdad = Cargar(lstEdad);
            Listar(lstEdad);

            Console.WriteLine();

            //Lista Peso
            Console.WriteLine("Lista PESO");
            lstPeso = Cargar(lstPeso);
            Listar(lstPeso);

            //Salida
            Console.WriteLine();
            Console.Write("Presione una tecla para salir...");
            Console.ReadKey();
        }


        static public List<int> Cargar(List<int> l)
        {
            //Cargar la lista con elementos
            l.Add(15);
            l.Add(20);
            l.Add(17);
            l.Add(21);
            l.Add(60);
            l.Add(42);

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

    }
}
