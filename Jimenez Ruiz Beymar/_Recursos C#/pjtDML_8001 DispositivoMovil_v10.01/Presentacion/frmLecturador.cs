using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//Librerias necesarias
using System.Data.SqlClient;
using System.Data.SqlServerCe; //Para definir DataTable, SqlDataReader
using Negocio; 

namespace Presentacion
{
    public partial class frmLecturador : Form
    {
        public frmLecturador()
        {
            InitializeComponent();
        }

        private void mnuCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuGuardar_Click(object sender, EventArgs e)
        {
            neg_Lecturador_Movil objLM = new neg_Lecturador_Movil();
            objLM.Insertar(int.Parse(txtId.Text), txtNombre.Text, txtApellido.Text, txtTelefono.Text);

            neg_Lecturador_Servidor objLS = new neg_Lecturador_Servidor();
            objLS.Insertar(int.Parse(txtId.Text), txtNombre.Text, txtApellido.Text, txtTelefono.Text);
        }

        private void mnuBuscar_Click(object sender, EventArgs e)
        {
            DataTable dt;

            //neg_Lecturador_Movil objL = new neg_Lecturador_Movil();

            neg_Lecturador_Servidor objL = new neg_Lecturador_Servidor();

            dt = objL.Buscar(int.Parse(txtId.Text));
            if (dt.Rows.Count < 1)
            {
                txtId.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtTelefono.Text = "";
            }
            else
            {
                txtId.Text = dt.Rows[0]["Id"].ToString();
                txtNombre.Text = dt.Rows[0]["Nombre"].ToString();
                txtApellido.Text = dt.Rows[0]["Apellido"].ToString();
                txtTelefono.Text = dt.Rows[0]["Telefono"].ToString();
            }
        }

        private void mnuActualizar_Click(object sender, EventArgs e)
        {
            neg_Lecturador_Movil objLM = new neg_Lecturador_Movil();
            objLM.Actualizar(int.Parse(txtId.Text), txtNombre.Text, txtApellido.Text, txtTelefono.Text);

            neg_Lecturador_Servidor objLS = new neg_Lecturador_Servidor();
            objLS.Actualizar(int.Parse(txtId.Text), txtNombre.Text, txtApellido.Text, txtTelefono.Text);
        }

        private void mnuEliminar_Click(object sender, EventArgs e)
        {
            neg_Lecturador_Movil objLM = new neg_Lecturador_Movil();
            objLM.Eliminar(int.Parse(txtId.Text));

            neg_Lecturador_Servidor objLS = new neg_Lecturador_Servidor();
            objLS.Eliminar(int.Parse(txtId.Text));
        }

        private void mnuMostrarTodos_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            //neg_Lecturador_Movil objL = new neg_Lecturador_Movil();

            neg_Lecturador_Servidor objL = new neg_Lecturador_Servidor();

            dt = objL.Buscar_Todos();
            dgvLecturador.DataSource = dt;
        }
    }
}