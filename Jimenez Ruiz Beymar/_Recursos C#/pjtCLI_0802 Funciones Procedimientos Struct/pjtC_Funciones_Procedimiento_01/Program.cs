using System;
using System.Collections.Generic;
using System.IO;  //Leer archivo
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtC_Funciones_Procedimiento_01
{
    class Program
    {

        struct menu {
            public string codigo;
            public string nombre;
            public string ingredientes;
            public double precio;

            public void setMenu (string c, string n, string i, double p) {
                this.codigo = c;
                this.nombre = n;
                this.ingredientes = i;
                this.precio = p;
            }
        }

        static void Main(string[] args)
        {
            menu mn = new menu();
            mn.setMenu("LCR01", "Locro carretero", "Arroz, Yuca, Pollo", 25.56);

            menu[] mm = new menu[5];

            mm[0].setMenu("LCR02", "Locro beniano", "Arroz, Platano, lagarto", 96.15);

            
            int nro;

            nro = leerEntero();
            mostrarValor("Valor: ", nro);
            incrementarValor(ref nro);
            mostrarValor("Valor incrementado: ", nro);

            leerArchivo();

            Console.WriteLine("\n");
            Console.WriteLine("Codigo: {0}", mn.codigo);
            Console.WriteLine("Nombre: {0}", mn.nombre);
            Console.WriteLine("Ingredientes: {0}", mn.ingredientes);
            Console.WriteLine("Precio: {0}", mn.precio);
            Console.WriteLine("\n");

            Console.WriteLine("Codigo[0]: {0}", mm[0].codigo);
            Console.WriteLine("Nombre[0]: {0}", mm[0].nombre);
            Console.WriteLine("Ingredientes[0]: {0}", mm[0].ingredientes);
            Console.WriteLine("Precio[0]: {0}", mm[0].precio);

            Console.ReadLine();
        }


        static int leerEntero()
        {
            string entrada;
            int nro = 0;

            try
            {
                do
                {
                    Console.Write("Ingrese un número entero [0;4858]: ");
                    entrada = Console.ReadLine();
                    nro = int.Parse(entrada);
                } while (nro < 0 || nro > 100);
            }
            catch (Exception e)
            {
                Console.WriteLine("\nERROR: Excepción, argumento INDEFINIDO\n\n{0} ", e);
                return 0;
            }

            return nro;
        }


        static void mostrarValor(string msg, int valor)
        {
            Console.WriteLine("{0}{1}",msg, valor);
        }


        static void incrementarValor(ref int valor)
        {
            valor++;
        }

        static void leerArchivo()
        {
            try
            {
                StreamReader sr = File.OpenText("d://data.txt");
                Console.WriteLine("\n");
                Console.WriteLine("Linea [1]: {0}", sr.ReadLine());
                Console.WriteLine("Linea [2]: {0}", sr.ReadLine());
                Console.WriteLine("Linea [3]: {0}", sr.ReadLine());
                Console.WriteLine("Linea [4]: {0}", sr.ReadLine());
                Console.WriteLine("Linea [5]: {0}", sr.ReadLine());
                Console.WriteLine("\n");
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: No se puede leer el archivo: '{0}'", e);
            }
        }


    }
}
