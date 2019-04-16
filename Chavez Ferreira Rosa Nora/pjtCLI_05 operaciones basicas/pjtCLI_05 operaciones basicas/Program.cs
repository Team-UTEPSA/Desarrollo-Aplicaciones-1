using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtCLI_05_operaciones_basicas
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, resultado;     
            string entrada;

            Console.WriteLine("OPERACIONES BASICAS");
            Console.WriteLine(); 
            Console.Write("PRIMER NÚMERO :");     
            entrada = Console.ReadLine();         
            n1 = double.Parse(entrada);   
            Console.Write("SEGUNDO NÚMERO :"); 
            entrada = Console.ReadLine();         
            n2= double.Parse(entrada);          
            Console.WriteLine();           
            resultado = n1 + n2;         
            Console.WriteLine("LA SUMA ES {0}: ", resultado);
            Console.WriteLine();
            resultado = n1 - n2;         
            Console.WriteLine("LA RESTA ES: {0} - {1} = {2} ", n1, n2, resultado);
            Console.WriteLine();
            resultado = n1 * n2;
            Console.WriteLine();
            Console.WriteLine("LA MULTIPLICACIÓN ES: " + resultado);    
            resultado = n1 / n2;       
            Console.WriteLine("LA DIVISIÓN ES: " + resultado);
            Console.WriteLine();
            resultado = n1 % n2;
            Console.WriteLine("EL RESIDUO ES: " + resultado);
            Console.WriteLine();
            Console.Write("Pulse una Tecla para salir:");
            Console.ReadKey();     
        }    
    } 
}


