using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_5
{
   
    struct Usuario
    {
        public int id;
        public string Nombre;
        public int Contraseña;
        public int Perfil;

        public void setUsuario( int id, string nom, int pass, int pe)
        {
            this.id = id;
            this.Nombre = nom;
            this.Contraseña = pass;
            this.Perfil = pe;
        }
    }
    public class Program
    {
        static List<Usuario> lstP = new List<Usuario>();
        
        static void Main(string[] args)
        {
            mostrar_menu();
            elegir_opcion();
        }
        static public int adm = 0;
        static public int cli = 0;
        static void mostrar_menu()
        {
            System.Console.Clear();
            System.Console.WriteLine("---- GESTION DE USUARIOS ----");
            System.Console.WriteLine("");
            System.Console.WriteLine("[C] Cargar");
            System.Console.WriteLine("[L] Listar");
            System.Console.WriteLine("[R] REPORTES");
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
                        Console.WriteLine("REGISTRAR USUARIO");
                        Console.WriteLine("");
                        Console.Write("ID: ");
                        sEntrada = Console.ReadLine();
                        int id = Convert.ToInt32(sEntrada);
                        Console.WriteLine("");
                        Console.Write("Nombre Usuario: ");
                        sEntrada = Console.ReadLine();
                        string nom = sEntrada;
                        Console.Write("Contraseña: ");
                        sEntrada = Console.ReadLine();
                        int pass = Convert.ToInt32(sEntrada);
                        Console.Write("Perfil: ");
                        sEntrada = Console.ReadLine();
                        int pe = Convert.ToInt32(sEntrada);
                        contar(pe);
                        Cargar(id,nom, pass, pe);
                        break;
                    case 'L':
                        Console.Clear();
                        System.Console.WriteLine("LISTAR PRODUCTOS");
                        Console.WriteLine("");
                        Listar();
                        break;
                    case 'R':
                        Console.Clear();
                        System.Console.WriteLine("REPORTE DE USUARIOS");
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

        static public void Cargar(int id, string nom, int pass, int pe)
        {
            Usuario p = new Usuario();
            p.setUsuario(id, nom, pass, pe);
           
            lstP.Add(p);
            
        }
        static public void Listar()
        {
            int k = lstP.Count();

            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("Id: {0}", lstP.ElementAt(i).id);
                Console.WriteLine("Nombre: {0}", lstP.ElementAt(i).Nombre);
                Console.WriteLine("Contraseña {0}", lstP.ElementAt(i).Contraseña);
                Console.WriteLine("Perfil {0}", lstP.ElementAt(i).Perfil);
               // Console.WriteLine("SubTotal {0}", lstP.ElementAt(i).PrecioUnitario * lstP.ElementAt(i).Stock);
                Console.WriteLine("-------------------------");
            }
        }

        static public void contar(int pe)
        {
            if (pe == 1)
            {
                adm++;
            }
            else
            {
                cli++;
            }
        }

        static public void Estadistica()
        {
            
            //int k = lstP.Count();
            //int ti = 0;

            //for (int i = 0; i < k; i++)
            //{
            //   ti = ti + lstP.ElementAt(i).PrecioUnitario * lstP.ElementAt(i).Stock;
            //}
            Console.WriteLine("Total Administradores: {0}", adm);
            Console.WriteLine("Total Cliente: {0}", cli);
            //Console.WriteLine("Total Administradores: {0}", ti);
            //Console.WriteLine("Total Clientes: {0}", ti / k);
            ////Console.WriteLine("Cantidad Productos : {0}", k);
        }
    }
}
