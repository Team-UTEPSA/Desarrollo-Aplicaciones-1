using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL2
{
   
    struct USUARIO
    {
        public string usuario;
        public int tipousuario;
        public int codigo;

        public void setProducto(string usu, int tp, int cod)
        {
            this.usuario = usu;
            this.tipousuario = tp;
            this.codigo = cod;
        }
    }


    class Program
    {
        static List<USUARIO> lstP = new List<USUARIO>();
        static void Main(string[] args)
        {
            mostrar_menu();
            elegir_opcion();
        }
        static void mostrar_menu()
        {
            System.Console.Clear();
            System.Console.WriteLine("---- CUENTAUSUARIO ----");
            System.Console.WriteLine("");
            System.Console.WriteLine("[N] NUEVA CUENTA");
            System.Console.WriteLine("[L] Listar");
            System.Console.WriteLine("[C] CANTIDAD DE USUARIOS");
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
                    case 'N':
                        Console.Clear();
                        Console.WriteLine("NUEVO USUARIO");
                        Console.WriteLine("------------------------------------------------------------------------------");
                        Console.WriteLine("--------------------------------TIPO DE USUARIO-------------------------------");
                        Console.WriteLine("1= ADMINISTRACION");
                        Console.WriteLine("2= CLIENTE");
                        Console.WriteLine("------------------------------------------------------------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.Write("USUARIO: ");

                        sEntrada = Console.ReadLine();
                        string usu = sEntrada;
                        Console.Write("TIPO USUARIO: ");
                        sEntrada = Console.ReadLine();
                        int tp = int.Parse(sEntrada);
                        Console.Write("CODIGO: ");
                        sEntrada = Console.ReadLine();
                        int cod = int.Parse(sEntrada);
                        Cargar(usu, tp, cod);
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


        static public void Cargar(string usu, int tp, int cod)
            {
                USUARIO p = new USUARIO();

                p.setProducto(usu, tp, cod);
                lstP.Add(p);
            }
            static public void Listar()
            {
           
            int k = lstP.Count();

                for (int i = 0; i < k; i++)
                {
                    Console.WriteLine("usuario: {0}", lstP.ElementAt(i).usuario);
                    Console.WriteLine("tipo usuario {0}", lstP.ElementAt(i).tipousuario);
                    Console.WriteLine("codigo {0}", lstP.ElementAt(i).codigo);
                    
                    Console.WriteLine("-------------------------");
                }
            }
        static public void CANTIDADUSUARIO(int tp)
        {
            /*
            int k = lstP.Count();
            int i = 0;
            if (i = 0;i > k;i++)
            {
               
            }
            
            Console.WriteLine("total administradores", ti);
            Console.WriteLine("total clientes: {0}", ti / k);
            Console.WriteLine("Cantidad total usuarios : {0}", k);
            */
        }

    }
    
}
