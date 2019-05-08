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
    public partial class agregarMensaje : Form
    {
        listadoMensajes formularioPadre;
        cls_mensajeria _cls_mensajeria = new cls_mensajeria();


        public agregarMensaje(listadoMensajes formupadre)//constructor defino variables
        {
            InitializeComponent();
            this.formularioPadre = formupadre;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if(tb_mensaje.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un mensaje antes de Guardar", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int filasAfectadas = _cls_mensajeria.guardarMensaje(tb_mensaje.Text.Trim());

            if(filasAfectadas > 0)
            {
                MessageBox.Show("El Mensaje se guardó Correctamente", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                formularioPadre.listarMensajes();
            }
            else
            {
                MessageBox.Show("Hubo un error al guardar el mensaje, intente de unevo más tarde", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void limpiar()
        {
            tb_mensaje.Clear();
            tb_mensaje.Focus();
        }

    }
}
