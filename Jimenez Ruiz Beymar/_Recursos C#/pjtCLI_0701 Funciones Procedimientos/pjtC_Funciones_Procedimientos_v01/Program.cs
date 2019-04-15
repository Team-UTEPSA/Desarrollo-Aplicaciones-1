using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtC_Funciones_Procedimientos_v01
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro;

            nro = leerEntero();
            mostrarValor(nro);
            Console.ReadLine();
        }

        static int leerEntero()
        {
            string entrada;
            int valor = 0;

            Console.Write("Escriba un número: ");
            entrada = Console.ReadLine();
            valor = int.Parse(entrada);

            return valor;
        }

        static void mostrarValor(int valor)
        {
            Console.Write("Valor: {0}", valor);
        }

    }
}
