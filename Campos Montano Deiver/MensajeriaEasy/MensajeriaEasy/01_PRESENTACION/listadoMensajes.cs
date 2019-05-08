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
    public partial class listadoMensajes : Form
    {
        DataTable tablaMensajes;
        cls_mensajeria _cls_mensajeria = new cls_mensajeria();

        public listadoMensajes()
        {
            InitializeComponent();
        }

        private void listadoMensajes_Load(object sender, EventArgs e)
        {
            listarMensajes();
        }

        public void listarMensajes()
        {
            int indice = 0;
            string estado = "";

            dg_mensajes.Rows.Clear();

            tablaMensajes = _cls_mensajeria.listar();

            if (tablaMensajes.Rows.Count != 0)
            {
                foreach (DataRow row in tablaMensajes.Rows)
                {
                    //Se valida el estado
                    if (row["Estado"].ToString() == "0")
                    {
                        estado = "Sin Leer";
                    }
                    else
                    {
                        estado = "Leído";
                    }


                    dg_mensajes.Rows.Add(row["idMensaje"], row["Mensaje"], estado);

                    dg_mensajes.Rows[indice].Tag = row;
                    indice = indice + 1;
                }
            }

            dg_mensajes.ClearSelection();

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            agregarMensaje obj = new agregarMensaje(this);
            obj.ShowDialog();
        }

        private void btn_leer_Click(object sender, EventArgs e)
        {
            if(dg_mensajes.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Seleccione un Mensaje a Visualizar", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            DataTable datos;
            datos = _cls_mensajeria.buscarMensaje(dg_mensajes.SelectedRows[0].Cells[0].Value.ToString());

            leerMensaje obj = new leerMensaje(this, datos);
            obj.ShowDialog();

        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dg_mensajes.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Seleccione un Mensaje a Eliminar", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Seguro que quiere eliminar el Mensaje?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(resultado == DialogResult.Yes)
            {
                _cls_mensajeria.eliminarMensaje(dg_mensajes.SelectedRows[0].Cells[0].Value.ToString());
                listarMensajes();
                MessageBox.Show("Mensaje eliminado Correctamente", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
        }
    }
}
