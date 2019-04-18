using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtCLI_0103_Formatear_int_float
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum = 18;
            double dNum1 = 565161568.16561565;
            double dNum2 = 96526.35156;

            Console.WriteLine("FORMATO DE NÚMEROS CON Y SIN DÍGITOS DECIMALES");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("int: " + iNum.ToString());
            Console.WriteLine("double1: " + dNum1.ToString());
            Console.WriteLine("double2: " + dNum2.ToString());
            Console.WriteLine();
            Console.WriteLine("double1: {0:F0}", dNum1);
            Console.WriteLine("double1: {0:F2}", dNum1);
            Console.WriteLine();
            Console.WriteLine("double1: " + dNum1.ToString("#,##0.00"));
            Console.WriteLine("double1: {0:0,0.00}", dNum1);
            Console.WriteLine("double2: {0:#,###.##}", dNum2);
            Console.WriteLine();
            Console.WriteLine("double1: {0,25:0,0.00}", dNum1);
            Console.WriteLine("double2: {0,25:0,0.00}", dNum2);
            Console.WriteLine();
            
            Console.WriteLine("double1: {0:$us #,##0.00;($us #,##0.00);Zero}", dNum1);
            Console.WriteLine();
            Console.WriteLine("double1: {0,25:$us #,##0.00;($us #,##0.00);Zero}", dNum1);
            Console.WriteLine("double2: {0,25:$us #,##0.00;($us #,##0.00);Zero}", dNum2);

            Console.WriteLine();
            Console.Write("Pulse una tecla para salir...");
            Console.ReadKey();
        }
    }
}
