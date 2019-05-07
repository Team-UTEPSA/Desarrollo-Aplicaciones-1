using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pgta_5_2_Parcial
{
    struct CuentaUsuario
    {
        static void cuenta(string[] args)
        { } 
        public string Nombre;
        public double Adicionar;
        public int Informe;

        public void Usuario(string no, string ad, string inf)
        {
            this.Nombre = no;
            this.Adicionar   = ad;
            this.Informe = inf;
        }
    }


    class Program
    {
        static List<CuentaUsuario> lstP = new List<CuentaUsuario>();

        static void Main(string[] args)
        {
            mostrar_menu();
            elegir_opcion();
        }

        static void mostrar_menu()
        {
            System.Console.Clear();
            System.Console.WriteLine("---- MENU DE USUARIOS ----");
            System.Console.WriteLine("");
            System.Console.WriteLine("[C] Añadir Usuarios");
            System.Console.WriteLine("[L] Listar Usuarios");
            System.Console.WriteLine("[I] INFORME de Usuarios");
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
                        Console.WriteLine("CARGAR USUARIO");
                        Console.WriteLine("");
                        Console.Write("Nombre: ");
                        sEntrada = Console.ReadLine();
                        string no = sEntrada;
                        Console.Write("ANADIR: ");
                        sEntrada = Console.ReadLine();
                        double pu = double.Parse(sEntrada);
                        Console.Write("Informe: ");
                        sEntrada = Console.ReadLine();
                        int st = int.Parse(sEntrada);
                        Cargar(no, ad, inf);
                        break;
                    case 'L':
                        Console.Clear();
                        System.Console.WriteLine("LISTAR USUARIOS");
                        Console.WriteLine("");
                        Listar();
                        break;
                    case 'E':
                        Console.Clear();
                        System.Console.WriteLine(" LISTAR USUARIOS");
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

        static public void Cargar(string no, string ad, string inf)
        {
            CuentaUsuario CU = new CuentaUsuario();

            CU.Usuario(no, ad, inf);
            lstP.Add(CU);
        }

        static public void Listar()
        {
            int k = lstP.Count();

            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("Nombre: {0}", lstP.ElementAt(i).Nombre);
                Console.WriteLine("Adicion {0}", lstP.ElementAt(i).Adicionar);
                Console.WriteLine("Reporte {0}", lstP.ElementAt(i).Informe);
                Console.WriteLine("SubTotal {0}", lstP.ElementAt(i).Adicionar * lstP.ElementAt(i).Informe);
                Console.WriteLine("-------------------------");
            }
        }

        static public void Estadistica()
        {
            int k = lstP.Count();
            double ti = 0;

            for (int i = 0; i < k; i++)
            {
                ti = ti + lstP.ElementAt(i).Adicionar * lstP.ElementAt(i).Informe;
            }

            Console.WriteLine("Total Inventario: {0}", ti);
            Console.WriteLine("Promedio Inventario: {0}", ti / k);
            Console.WriteLine("Cantidad Usuarios : {0}", k);
        }
    }
}
