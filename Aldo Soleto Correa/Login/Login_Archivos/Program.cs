using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Archivos
{
    public class Program
    {
        static void Main(string[] args)
        {

            login();
          

        }

        static public void login()
        {
            string UsEntrada;
            string Uspass;
            System.Console.Clear();
            System.Console.WriteLine("---- LOGIN ----");
            System.Console.WriteLine("Usuario:");
            UsEntrada = Console.ReadLine();
            System.Console.WriteLine("Contraseña:");
            Uspass = Console.ReadLine();

            if (LoginHelper.Autenticar(UsEntrada.Trim(), Uspass.Trim()))
            {
                System.Console.WriteLine("Bienvenido..");
                System.Console.WriteLine("Presiona enter");
                Console.ReadKey();
                System.Console.Clear();
                mostrar_menu();
                Console.ReadKey();
            }
            else
            {
                System.Console.WriteLine("Datos incorrecos por favor ingrese nuevamente");
                System.Console.WriteLine("Presione enter para volver a ingresar....");
                Console.ReadKey();
                Main(null);
            }

        }
        static void mostrar_menu()
        {
           
            System.Console.WriteLine("************************RESERVA TU CANCHA*************************");
            System.Console.WriteLine("[1] Reservas");
            System.Console.WriteLine("[2] Pagos");
            System.Console.WriteLine("[3] Historial de visitas");
            //System.Console.WriteLine("[E] Potencia de a^b");
            //System.Console.WriteLine("[F] Raiz Cuadrada de a");
            //System.Console.WriteLine("[G] Raiz Cuadrada de b");
            //System.Console.WriteLine("[S] Salir del programa");
        }
    }

    public class LoginHelper
    {

        public static List<usuario> GetUsuarios()
        {
            List<usuario> lista = new List<usuario>();

            using (StreamReader sr = new StreamReader("prueba.txt"))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] infousu = line.Split(',');
                    usuario usu = new usuario(infousu[0], infousu[1]);
                    lista.Add(usu);
                }
            }

            return lista;

        }
        public static bool Autenticar(string nombre, string password)
        {
            bool result = false;
            List<usuario> lista = GetUsuarios();

            foreach (usuario usu in lista)
            {
                if (usu.Nombre == nombre && usu.Password == password)
                {
                    result = true;
                    break;
                }

            }

            return result;
        }
    }

    public class usuario
    {
        public usuario(string nombre, string password)
        {
            this.Nombre = nombre;
            this.Password = password;
        }

        public string Nombre { get; set; }
        public string Password { get; set; }
    }
}



