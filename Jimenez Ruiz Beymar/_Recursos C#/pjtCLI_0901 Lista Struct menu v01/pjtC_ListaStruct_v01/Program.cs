using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtC_ListaStruct_v01
{
    struct Producto
    {
        public string Nombre;
        public double PrecioUnitario;
        public int Stock;

        public void setProducto(string no, double pu, int st)
        {
            this.Nombre = no;
            this.PrecioUnitario = pu;
            this.Stock = st;
        }
    }


    class Program
    {
        static List<Producto> lstP = new List<Producto>(); 

        static void Main(string[] args)
        {
            mostrar_menu();
            elegir_opcion();
        }

        static void mostrar_menu()
        {
            System.Console.Clear();
            System.Console.WriteLine("---- MENU INVENTARIO ----");
            System.Console.WriteLine("");
            System.Console.WriteLine("[C] Cargar");
            System.Console.WriteLine("[L] Listar");
            System.Console.WriteLine("[E] Estadistica");
            System.Console.WriteLine("[S] Salir");
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
                    case 'C':
                        Console.Clear();
                        Console.WriteLine("CARGAR PRODUCTO");
                        Console.WriteLine("");
                        Console.Write("Nombre: ");
                        sEntrada = Console.ReadLine();
                        string no = sEntrada;
                        Console.Write("Precio Unitario: ");
                        sEntrada = Console.ReadLine();
                        double pu = double.Parse(sEntrada);
                        Console.Write("Stock: ");
                        sEntrada = Console.ReadLine();
                        int st = int.Parse(sEntrada);
                        Cargar(no, pu, st);
                        break;
                    case 'L':
                        Console.Clear();
                        System.Console.WriteLine("LISTAR PRODUCTOS");
                        Console.WriteLine("");
                        Listar();
                        break;
                    case 'E':
                        Console.Clear();
                        System.Console.WriteLine("ESTADISTICA INVENTARIO");
                        Console.WriteLine("");
                        Estadistica();
                        break;
                    case 'S':
                        System.Console.Clear();
                        System.Environment.Exit(-1);
                        break;
                    default:
                        System.Console.Write("\n\nERROR:: Opción no disponible");
                        break;
                }
            }
            catch
            {
                System.Console.WriteLine("ERROR: Opción no válida");
            }

            ConsoleKeyInfo kParada = System.Console.ReadKey();
            Main(null);

        }

        static public void Cargar(string no, double pu, int st)
        {
            Producto p = new Producto();

            p.setProducto(no, pu, st);
            lstP.Add(p);
        }

        static public void Listar()
        {
            int k = lstP.Count();

            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("Nombre: {0}", lstP.ElementAt(i).Nombre);
                Console.WriteLine("Precio {0}", lstP.ElementAt(i).PrecioUnitario);
                Console.WriteLine("Stock {0}", lstP.ElementAt(i).Stock);
                Console.WriteLine("SubTotal {0}", lstP.ElementAt(i).PrecioUnitario * lstP.ElementAt(i).Stock);
                Console.WriteLine("-------------------------");
            }
        }

        static public void Estadistica()
        {
            int k = lstP.Count();
            double ti = 0;

            for (int i = 0; i < k; i++)
            {
                ti = ti + lstP.ElementAt(i).PrecioUnitario * lstP.ElementAt(i).Stock;
            }

            Console.WriteLine("Total Inventario: {0}", ti);
            Console.WriteLine("Promedio Inventario: {0}", ti/k);
            Console.WriteLine("Cantidad Productos : {0}", k);
        }

    }

}
