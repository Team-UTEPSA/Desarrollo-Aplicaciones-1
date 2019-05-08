using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _02_NEGOCIO;

namespace _01_PRESENTACION
{
    public partial class leerMensaje : Form
    {
        cls_mensajeria _cls_mensajeria = new cls_mensajeria();
        listadoMensajes formularioPadre;
        DataTable datosMensaje;        

        public leerMensaje(listadoMensajes formupadre, DataTable datos)
        {
            InitializeComponent();
            this.formularioPadre = formupadre;
            this.datosMensaje = datos;
        }

        private void leerMensaje_Load(object sender, EventArgs e)
        {
            if(datosMensaje.Rows.Count > 0)
            {
                tb_codigo.Text = datosMensaje.Rows[0][0].ToString();
                tb_mensaje.Text = datosMensaje.Rows[0][1].ToString();
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            _cls_mensajeria.actualizarEstado(tb_codigo.Text);
            formularioPadre.listarMensajes();
            this.Close();
        }

    }
}
