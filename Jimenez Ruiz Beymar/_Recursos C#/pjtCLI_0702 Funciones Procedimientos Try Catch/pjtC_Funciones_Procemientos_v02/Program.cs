using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtC_Funciones_Procemientos_v02
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro;

            nro = leerEntero();
            mostrarValor("El valor es: ", nro);
            Console.ReadLine();
        }

        static int leerEntero()
        {
            string entrada;
            int valor = 0;

            try
            {
                do
                {
                    Console.Write("Escriba un número: ");
                    entrada = Console.ReadLine();
                    valor = int.Parse(entrada);
                } while (valor < 0 || valor > 100);
            }
            catch (Exception e)
            {
                Console.WriteLine("\nERROR: Número fuera de rango\n\n{0}", e);
            }

            return valor;
        }

        static void mostrarValor(string msg, int valor)
        {
            Console.WriteLine("{0}{1}", msg, valor);
        }
    }
}
