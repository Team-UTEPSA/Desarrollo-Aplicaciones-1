using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtC_Struct_v01
{
    class Program
    {
        struct Producto{
            public string ID;
            public string Nombre;
            public string Marca;
            public string Modelo;
            public string Serie;
            public double PrecioCompra;
            public int TiempoGarantia;
            public int Stock;

            public void setProducto(string id, string no, string ma, string mo, string se, double pc, int tg, int st)
            {
                this.ID = id;
                this.Nombre = no;
                this.Marca = ma;
                this.Modelo = mo;
                this.Serie = se;
                this.PrecioCompra = pc;
                this.TiempoGarantia = tg;
                this.Stock = st;
            }
        }


        static void Main(string[] args)
        {
            Producto p = new Producto();

            p.setProducto("CEL4515", "Celular", "Sansumg", "J7 Prime", "1525125", 1488.15, 12, 84);

            Console.WriteLine("PRODUCTO DISPONIBLE");
            Console.WriteLine("-------------------");
            Console.WriteLine("ID: {0}", p.ID);
            Console.WriteLine("Nombre: {0}", p.Nombre);
            Console.WriteLine("Marca: {0}", p.Marca);
            Console.WriteLine("Modelo: {0}", p.Modelo);
            Console.WriteLine("Serie: {0}", p.Serie);
            Console.WriteLine("Precio Compra: {0}", p.PrecioCompra);
            Console.WriteLine("Tiempo Garantía: {0} Meses", p.TiempoGarantia);
            Console.WriteLine("Stock: {0}", p.Stock);
            Console.ReadLine();
            
        }
    }
}
