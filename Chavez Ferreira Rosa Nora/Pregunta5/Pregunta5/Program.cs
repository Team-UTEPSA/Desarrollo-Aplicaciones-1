using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta5
{
    struct Cuenta
    {
        public string Nombre;
        public string FechaNacimiento;
        public string Genero;
        public int Telefono;
        public string usuario;

        public void setCuenta(string no, string FN, string ge, int tel, string usu)
        {
            this.Nombre = no;
            this.FechaNacimiento = FN;
            this.Genero = ge;
            this.Telefono = tel;
            this.usuario = usu;
        }
    }
    class Program
    {
        static List<Cuenta> lstC = new List<Cuenta>();
        static void Main(string[] args)
        {
            mostrar_menu();
            elegir_opcion();
        }
        static void mostrar_menu()
        {
            System.Console.Clear();
            System.Console.WriteLine("----LISTA USUARIOS ----");
            System.Console.WriteLine("");
            System.Console.WriteLine("[A] Adicionar");
            System.Console.WriteLine("[L] Listar");
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
                    case 'A':
                        Console.Clear();
                        Console.WriteLine("ADICIONAR USUARIO");
                        Console.WriteLine("");

                        Console.Write("Nombre: ");
                        sEntrada = Console.ReadLine();
                        string no = sEntrada;

                        Console.Write("Fecha de Nacimiento: ");
                        sEntrada = Console.ReadLine();
                        string FN = sEntrada;

                        Console.Write("Genero: ");
                        sEntrada = Console.ReadLine();
                        string ge = sEntrada;

                        Console.Write("telefono: ");
                        sEntrada = Console.ReadLine();
                        int tel = int.Parse(sEntrada);

                        Console.Write("Ususario: ");
                        sEntrada = Console.ReadLine();
                        string usu = sEntrada;

                        Adicionar(no, FN, ge, tel, usu);
                        break;
                    case 'L':
                        Console.Clear();
                        System.Console.WriteLine("LISTAR USUARIOS");
                        Console.WriteLine("");
                        Listar();
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
        static public void Adicionar(string no, string FN, string ge, int tel, string usu)
        {
            Cuenta c = new Cuenta();

            c.setCuenta(no, FN, ge, tel, usu);
            lstC.Add(c);
        }

        static public void Listar()
        {
            int k = lstC.Count();

            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("Nombre: {0}", lstC.ElementAt(i).Nombre);
                Console.WriteLine("fecha Nacimiento: {0}", lstC.ElementAt(i).FechaNacimiento);
                Console.WriteLine("genero: {0}", lstC.ElementAt(i).Genero);
                Console.WriteLine("Telefono: {0}", lstC.ElementAt(i).Telefono);
                Console.WriteLine("usuario: {0}", lstC.ElementAt(i).usuario);
                Console.WriteLine("-------------------------");
            }




        }
    }
}
