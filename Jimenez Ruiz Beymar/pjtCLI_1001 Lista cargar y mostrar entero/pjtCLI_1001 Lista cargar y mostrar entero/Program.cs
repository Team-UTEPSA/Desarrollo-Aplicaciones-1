using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtCLI_1001_Lista_cargar_y_mostrar_entero
{
    class Program
    {
        static List<int> lstEdad = new List<int>();

        static void Main(string[] args)
        {
            //Cargar la lista con elementos
            lstEdad.Add(15);
            lstEdad.Add(20);
            lstEdad.Add(17);
            lstEdad.Add(21);
            lstEdad.Add(60);

            //Listar los elementos de la lista
            int n = lstEdad.Count();
            int iEle = 0;

            for (int i = 0; i < n; i++)
            {
                iEle = lstEdad[i];
                Console.WriteLine(iEle.ToString());
            }

            Console.WriteLine();
            Console.Write("Presione una tecla para salir...");
            Console.ReadKey();
        }



    }
}
