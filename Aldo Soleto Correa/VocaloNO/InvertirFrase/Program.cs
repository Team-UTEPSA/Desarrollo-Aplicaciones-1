using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertirFrase
{
    class Program
    {
        static void Main(string[] args)
        {
            string NOM;
            Program ob = new Program();
            Console.WriteLine("DIGITE UNA FRASE");
            NOM = Console.ReadLine();
            Console.WriteLine("RESULTADO ES: " + ob.INVERTIR(NOM));
            Console.ReadKey();
        }
        public string INVERTIR(string FRASE)
        {
            string AUX;
            string cadena;
            Program ob = new Program();
            int POS = FRASE.Length;
            Console.WriteLine(POS);
            AUX = "";
            while (POS >= 1)
            {
                cadena = ob.Mid(FRASE, POS - 1);
                AUX = AUX + cadena;
                POS--;
            }
            return AUX;
        }
        public string Mid(string param, int startIndex)
        {
            return param.Substring(startIndex, 1);
        }
    }
}
