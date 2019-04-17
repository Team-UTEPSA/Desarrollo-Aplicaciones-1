using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtCLI_1002_Lista_cagar_y_lista_con_procedimiento
{
    class Program
    {
        static List<int> lstEdad = new List<int>();

        static void Main(string[] args)
        {
            Cargar();
            Listar();

            Console.WriteLine();
            Console.Write("Presione una tecla para salir...");
            Console.ReadKey();
        }

        static public void Cargar()
        {
            //Cargar la lista con elementos
            lstEdad.Add(15);
            lstEdad.Add(20);
            lstEdad.Add(17);
            lstEdad.Add(21);
            lstEdad.Add(60);
        }

        static public void Listar()
        {
            //Listar los elementos de la lista
            int n = lstEdad.Count();
            int iEle = 0;

            for (int i = 0; i < n; i++)
            {
                iEle = lstEdad[i];
                Console.WriteLine(iEle.ToString());
            }
        }


    }
}
