using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesBásicas.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int ent1, ent2;
            double resul, dec1, dec2;

            Console.WriteLine();
            Console.WriteLine("OPERACIONES BÁSICAS CON NÚMEROS ENTEROS");
            Console.WriteLine("________________________________________");
            Console.WriteLine();
            Console.WriteLine("Escriba el primer número entero: ");
            ent1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el segundo número entero: ");
            ent2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            resul = ent1 + ent2;
            Console.WriteLine("El resultado de la suma de los dos números enteros es: " + resul);
            resul = ent1 - ent2;
            Console.WriteLine("El resultado de la resta de los dos números enteros es: " + resul);
            resul = ent1 * ent2;
            Console.WriteLine("El resultado de la multiplicación de los dos números enteros es: " + resul);
            resul = ent1 / ent2;
            Console.WriteLine("El resultado de la división de los dos números enteros es: " + resul);
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("OPERACIONES BÁSICAS CON NÚMEROS DECIMALES");
            Console.WriteLine("________________________________________");
            Console.WriteLine();
            Console.WriteLine("Escriba el primer número decimal: ");
            dec1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba el segundo número decimal: ");
            dec2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            resul = dec1 + dec2;
            Console.WriteLine("El resultado de la suma de los dos números decimales es: " +resul);
            resul = dec1 - dec2;
            Console.WriteLine("El resultado de la resta de los dos números decimales es: " + resul);
            resul = dec1 * dec2;
            Console.WriteLine("El resultado de la multiplicación de los dos números decimales es: " + resul);
            resul = dec1 / dec2;
            Console.WriteLine("El resultado de la división de los dos números decimales es: " + resul);
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Presione Enter para salir");
            Console.ReadKey();
        }
    }
}
