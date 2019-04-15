using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;  //MessageBox

namespace pjtW_EstructuraProyecto_v0._001.Datos
{
    class clsProducto
    {
        #region Atributos
        private int id;
        private string nombre;
        private int stock;
        private double precioventa;
        #endregion

        #region Constructor
        public clsProducto()
        {
            this.id = 0;
            this.nombre = "";
            this.stock = 0;
            this.precioventa = 0;
        }

        #endregion

        #region Set_Get Property
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                if ((value > 0) && (value < 1000))
                {
                    id = value;
                }
                else
                {
                    //MessageBox.Show("ERROR:: Texto", "Ventas - Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    //MessageBox.Show("The calculations are complete", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    Console.WriteLine("ERROR 123:: Descripción del error");
                }
            }
        }
        #endregion


        #region Metodos



        #endregion
    }


}
