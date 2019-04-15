using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtC_Funciones_Procedimientos_v03
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;

            edad = leerEntero("Escriba la edad: ");
            incrementarEdad(ref edad);
            mostrarValor("La nueva edad es: ", edad);
            Console.ReadLine();
        }

        static void incrementarEdad(ref int valor)
        {
            valor++;
            valor++;
        }

        static int leerEntero(string msg)
        {
            string entrada;
            int valor = 0;

            try
            {
                do
                {
                    Console.Write("{0}",msg);
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
