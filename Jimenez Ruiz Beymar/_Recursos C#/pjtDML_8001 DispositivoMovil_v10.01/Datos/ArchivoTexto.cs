using System;
using System.Collections.Generic;
using System.Text;
//Libreria necesaria
using System.IO;
using System.Collections;

namespace Datos
{
    public class ArchivoTexto
    {
        public ArchivoTexto()
        {
        }

        public void Escribir(String NombArch, ArrayList lstCadena)
        {
            FileStream f = new FileStream(NombArch, FileMode.Create);
            StreamWriter s = new StreamWriter(f);
            foreach (Object obj in lstCadena)
            {
                s.WriteLine(Convert.ToString(obj));
                //Linea = Convert.ToString(obj);
            }
            s.Close();
            f.Close();
        }

        public ArrayList Leer(String NombArch)
        {
            ArrayList lstCadena = new ArrayList();

            FileStream f = new FileStream(NombArch, FileMode.Open);
            StreamReader s = new StreamReader(f);
            while (s.Peek() >= 0)
            {
                lstCadena.Add(s.ReadLine());
            }
            s.Close();
            f.Close();
            return lstCadena;
        }

        public String CadenaCnx()
        {
            String NombArch = @"E:\UAGRM\Semestre 06\Topicos Avanzados de Programacion +\Proyecto I - Dispositivo Movil\slnDispositivoMovil-10\Datos\Config.ini";
            //String NombArch = "Archivos de programa/Presentacion/Config.txt";

            return Convert.ToString((Leer(NombArch))[0]);
        }
    }
}
