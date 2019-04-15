using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtC_Struct_v02
{
    class Program
    {
        struct Producto
        {
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
            Producto[] p = new Producto[5];

            p[0].setProducto("CEL4515", "Celular", "Sansumg", "J7 Prime", "1525125", 1488.15, 12, 84);
            p[1].setProducto("CEL5163", "Celular", "Nokia", "1000", "512153", 88.36, 3, 41);
            p[2].setProducto("CEL1825", "Celular", "Huawei", "P9", "96516", 24515.48, 24, 452);
            p[3].setProducto("CEL9351", "Celular", "LG", "T815", "115155", 152.36, 6, 362);

            Console.WriteLine("PRODUCTO DISPONIBLE");
            Console.WriteLine("-------------------");

            for (int i=0; i<4; i++)
            {
                Console.WriteLine("ID: {0}", p[i].ID);
                Console.WriteLine("Nombre: {0}", p[i].Nombre);
                Console.WriteLine("Marca: {0}", p[i].Marca);
                Console.WriteLine("Modelo: {0}", p[i].Modelo);
                Console.WriteLine("Serie: {0}", p[i].Serie);
                Console.WriteLine("Precio Compra: {0}", p[i].PrecioCompra);
                Console.WriteLine("Tiempo Garantía: {0} Meses", p[i].TiempoGarantia);
                Console.WriteLine("Stock: {0}", p[i].Stock);
                Console.WriteLine("--------------------------");
            }

            Console.ReadLine();

        }
    }
}
