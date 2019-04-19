using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_05
{
    class Program
    {



        static List<double> Lst_Double = new List<double>();
        

        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa la cantidad de elementos que tendra la lista: ");
            try
            {
                int rango = int.Parse(Console.ReadLine());
                string entrada;
                bool validacion;
                double n;
                int n1;

                for (int i = 0; i < rango; i++)
                {
                    Console.WriteLine("Ingresa el {0} valor de la Lista",i);
                    entrada = Console.ReadLine();
                    validacion = double.TryParse(entrada, out n);
                    if (validacion == true)
                    {
                        Lst_Double.Add(n);
                    }
                    else
                    {
                        validacion = int.TryParse(entrada, out n1);
                        if (validacion == true)
                        {
                            Lst_Double.Add(n1);
                        }
                    }

                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.WriteLine("Ingresa un numero por favor");
            }



            Mostrar_Menu();
            Elegir_opcion();

        }

        static void Mostrar_Menu()
        {
            Console.Clear();
            Console.WriteLine("Lista de Objetos 1.0");
            Console.WriteLine();
            Console.WriteLine("Numero de Elementos en la Lista: {0}", Lst_Double.Count);
            Console.WriteLine();
            Console.WriteLine("[E] Mostrar los elementos en la lista");
            Console.WriteLine("[S] Salir");
        }

        static void Elegir_opcion()
        {
            ConsoleKeyInfo Opcion;
            char cOpcion;
            try
            {
                Opcion = Console.ReadKey(true);
                cOpcion = char.Parse(Opcion.Key.ToString());
                cOpcion = char.ToUpper(cOpcion);
                int i = 0;
                switch (cOpcion)
                {
                    case 'A':
                        double suma = 0;
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Existen {0} elementos en la Lista", Lst_Double.Count);
                        for (int o = 0; o < Lst_Double.Count; o++)
                        {
                            suma = suma + Lst_Double[o];
                        }
                        Console.WriteLine("La suma de los objetos es: {0}", suma);
                        Console.ReadKey();
                        Console.Clear();
                        Mostrar_Menu();
                        Elegir_opcion();
                        break;
                    case 'B':
                        double promedio = 0;
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Existen {0} elementos en la Lista", Lst_Double.Count);
                        for (int o = 0; o < Lst_Double.Count; o++)
                        {
                            promedio = promedio + Lst_Double[o];
                            if (o == Lst_Double.Count - 1)
                            {
                                promedio = promedio / Lst_Double.Count;
                            }
                        }
                        Console.WriteLine("El Promedio de los objetos es: {0}", promedio);
                        Console.ReadKey();
                        Console.Clear();
                        Mostrar_Menu();
                        Elegir_opcion();
                        break;
                    case 'C':
                        Console.Clear();
                        Lst_Double = Lst_Double.OrderByDescending(o => o).ToList();
                        for (int o = 0; o < Lst_Double.Count; o++)
                        {
                            Console.WriteLine(Lst_Double[o]);
                        }
                        Console.WriteLine("Lista Ordenada de Mayor a Menor");
                        Console.WriteLine("Numero Mayor {0}", Lst_Double.Max());
                        Console.ReadKey();
                        Console.Clear();
                        Mostrar_Menu();
                        Elegir_opcion();
                        break;
                    case 'D':
                        Console.Clear();
                        Lst_Double = Lst_Double.OrderByDescending(o => o).ToList();
                        for (int o = 0; o < Lst_Double.Count; o++)
                        {
                            Console.WriteLine(Lst_Double[o]);
                        }
                        Console.WriteLine("Lista Ordenada de Menor a Mayor");
                        Console.WriteLine("Numero Menor {0}", Lst_Double.Min());
                        Console.ReadKey();
                        Console.Clear();
                        Mostrar_Menu();
                        Elegir_opcion();
                        break;
                    case 'E':
                        Console.Clear();
                        Console.WriteLine("{0} Objetos", Lst_Double.Count);
                        Console.WriteLine();

                        for (int e = 0; e < Lst_Double.Count; e++)
                        {
                            Console.WriteLine(Lst_Double[e].ToString());
                        }
                        Console.ReadKey();
                        Mostrar_Menu();
                        Elegir_opcion();
                        break;
                    case 'S':
                        Console.Clear();
                        Environment.Exit(-1);
                        break;
                    default:
                        Console.WriteLine("\n\n ERROR : Selecciona una opcion ");
                        break;
                }
            }
            catch
            {
                System.Console.WriteLine("ERROR: Opción no válida");
            }

            ConsoleKeyInfo kParada = Console.ReadKey();
            Main(null);

        }
        static public List<double> Cargar(List<double> l)
        {
            double a = double.Parse(Console.ReadLine());
            l.Add(a);
            Console.WriteLine("Se introdujo el Objeto {0}", a);
            return l;
        }

        static public List<double> Cargar_Posicion(List<double> l, int posicion)
        {
            Console.WriteLine("Introduce un Objeto por favor");
            object b;
            b = l[posicion];
            double a = double.Parse(Console.ReadLine());
            l[posicion] = a;
            Console.WriteLine("Se Reemplazo el objeto el Objeto {0} por {1} en la posicion {2}", b, a, posicion);
            Console.ReadKey();
            return l;
        }

        static public List<double> Eliminar(List<double> l, int posicion)
        {
            Console.WriteLine("Se elimino el objeto {0} en la posicion {1}", l[posicion].ToString(), posicion);
            l.RemoveAt(posicion - 1);
            return l;
        }

        static public void Listar(List<int> l)
        {

            int n = l.Count();
            int iEle = 0;
            for (int i = 0; i < n; i++)
            {
                iEle = l[i];
                Console.WriteLine(iEle);
            }


        }

    }
}
