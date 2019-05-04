using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta5
{
    class Program
    {
        struct CuentaUsuario
        {
            public string rol;
            public string Nombre;
            public string Apellido;
            public string NombreUsuario;
            public string Contraseña;
            
            public void SetUsuario(string n, string a, string contraseña, string r)
            {
                this.rol = r ;
                this.Nombre = n;
                this.Apellido = a;
                this.NombreUsuario = n.Substring(0,3) + a.Substring(0,3);
                this.Contraseña = contraseña;
            }


        }



        static List<CuentaUsuario> Lst_Usuarios = new List<CuentaUsuario>();


        static void Main(string[] args)
        {
            Console.WriteLine("----- Menu Usuario -----");
            Mostrar_Menu();
            Elegir_opcion();

        }

        static void Mostrar_Menu()
        {
            Console.WriteLine();
            Console.WriteLine("Numero de Usuarios en la Lista: {0}", Lst_Usuarios.Count);
            Console.WriteLine();
            Console.WriteLine("Selecciona una Opcion");
            Console.WriteLine("[A] Añadir un Usuario");
            Console.WriteLine("[B] Cantidad de Usuarios");
            Console.WriteLine("[E] Mostrar todos los Usuarios");
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
                switch (cOpcion)
                {
                    case 'A':
                        string nom, ape, con="", r = " ";
                        ConsoleKeyInfo key;
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Selecciona el Rol del Usuario");
                        Console.WriteLine("Administrador    [A]\nUsuario    [U]");
                        ConsoleKeyInfo Opcion1;
                        char cOpcion1;
                        Opcion1 = Console.ReadKey(true);
                        cOpcion1 = char.Parse(Opcion1.Key.ToString());
                        cOpcion1 = char.ToUpper(cOpcion1);
                        try
                        {
                            switch (cOpcion1)
                            {
                                case 'A':
                                    r = "Administrador";
                                    break;
                                case 'U':
                                    r = "Usuario";
                                    break;
                                default:
                                    break;
                            }
                        }
                        catch (Exception e)
                        {

                            throw e;
                        }
                        


                        Console.WriteLine("Ingresar Nombre: ");
                        nom = Console.ReadLine().ToString();
                        Console.WriteLine("Ingresar Apellidos: ");
                        ape = Console.ReadLine().ToString();
                        Console.WriteLine("Ingresar Contraseña: ");
                        //con = Console.ReadLine().ToString();
                        do
                        {
                            key = Console.ReadKey(true);

                            // Backspace Should Not Work
                            if (key.Key != ConsoleKey.Backspace)
                            {
                                con += key.KeyChar;
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write("\b");
                            }
                        }
                        // Stops Receving Keys Once Enter is Pressed
                        while (key.Key != ConsoleKey.Enter);




                        Console.ReadKey();
                        Console.Clear();
                        Cargar(nom,ape,con,r);
                        Mostrar_Menu();
                        Elegir_opcion();
                        break;
                    case 'B':
                        int administrador = 0, usuario = 0;
                        Console.Clear();
                        Console.WriteLine();
                        for (int i = 0; i < Lst_Usuarios.Count; i++)
                        {
                            if (Lst_Usuarios[i].rol == "Administrador")
                            {
                                administrador = administrador + 1;
                            }
                            else
                            {
                                usuario = usuario + 1;
                            }
                        }
                        Console.WriteLine("Existen {0} usuarios Administradores y {1} Usuarios Clientes y un total de {2} Usuarios Registrados", administrador, usuario, Lst_Usuarios.Count);
                        Console.ReadKey();
                        Console.Clear();
                        Mostrar_Menu();
                        Elegir_opcion();
                        break;
                    case 'E':
                        Console.Clear();
                        Console.WriteLine("{0} Usuarios", Lst_Usuarios.Count);
                        Console.WriteLine();

                        for (int e = 0; e < Lst_Usuarios.Count; e++)
                        {
                            Console.WriteLine(Lst_Usuarios[e].rol.ToString());
                            Console.WriteLine(Lst_Usuarios[e].Nombre.ToString());
                            Console.WriteLine(Lst_Usuarios[e].Apellido.ToString());
                            Console.WriteLine(Lst_Usuarios[e].NombreUsuario.ToString());
                        }
                        Console.ReadKey();
                        Console.Clear();
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
        static public void Cargar( string nom,string ape,string pass,string r)
        {
            CuentaUsuario a = new CuentaUsuario();
            a.SetUsuario(nom, ape, pass ,r );
            Console.WriteLine("Se introdujo el Objeto {0}\n{1}\n{2}\n{3}", a.Nombre,a.Apellido,a.NombreUsuario,a.Contraseña);
            Lst_Usuarios.Add(a);
        }

    }
}
