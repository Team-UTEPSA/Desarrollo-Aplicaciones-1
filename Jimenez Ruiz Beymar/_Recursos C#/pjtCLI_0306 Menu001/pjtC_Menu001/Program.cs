using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtC_Menu001
{
    class Program
    {
        static public double a = 0;
        static public double b = 0;
        

        static void Main(string[] args)
        {
            mostrar_menu();
            elegir_opcion();
        }
        
        static void mostrar_menu()
        {
            System.Console.Clear();
            System.Console.WriteLine("---- MENÚ ----");
            System.Console.WriteLine("[Z] Cargar A y B");
            System.Console.WriteLine("[A] Sumar");
            System.Console.WriteLine("[B] Restar");
            System.Console.WriteLine("[C] Multiplicar");
            System.Console.WriteLine("[D] Dividir");
            System.Console.WriteLine("[E] Potencia de a^b");
            System.Console.WriteLine("[F] Raiz Cuadrada de a");
            System.Console.WriteLine("[G] Raiz Cuadrada de b");
            System.Console.WriteLine("[S] Salir del programa");
        }


        static void elegir_opcion()
        {
            ConsoleKeyInfo kEntrada;
            char cEntrada;
            string sEntrada;

            try
            {
                System.Console.WriteLine("");
                System.Console.Write("Elija una opción: ");
                kEntrada = System.Console.ReadKey();
                cEntrada = char.Parse(kEntrada.Key.ToString());
                cEntrada = char.ToUpper(cEntrada);

                switch (cEntrada)
                {
                    case 'Z':
                        System.Console.WriteLine("");
                        System.Console.Write("Ingrese el valor de A: ");
                        sEntrada = Console.ReadLine();
                        a = double.Parse(sEntrada);
                        System.Console.Write("Ingrese el valor de B: ");
                        sEntrada = Console.ReadLine();
                        b = double.Parse(sEntrada);
                        break;
                    case 'A':
                        System.Console.WriteLine("La suma de {0} + {1} es {2}", a, b, Sumar(a,b));
                        break;
                    case 'B':
                        System.Console.WriteLine("\n-- RESTAR --");
                        break;
                    case 'C':
                        System.Console.WriteLine("\n-- MULTIPLICAR --");
                        break;
                    case 'D':
                        System.Console.WriteLine("\n-- DIVIDIR --");
                        break;
                    case 'E':
                        System.Console.WriteLine("\n-- POTENCIA de A^B --");
                        break;
                    case 'F':
                        System.Console.WriteLine("\nRAIZ CUADRADA de A");
                        break;
                    case 'G':
                        System.Console.WriteLine("\nRAIZ CUADRADA de B");
                        break;
                    case 'S':
                        System.Console.Clear();
                        System.Environment.Exit(-1);
                        break;
                    default:
                        System.Console.Write("\nERROR:: Opción no válida");
                        break;
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine("ERROR: Caracter no válida {0}\n\n", e);
            }

            ConsoleKeyInfo kParada = System.Console.ReadKey();
            Main(null);

        }

        static public double Sumar(double a, double b)
        {
            return a + b;
        }




    }
}
