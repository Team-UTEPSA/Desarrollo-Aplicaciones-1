using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//Librerias necesarias
using Negocio;
using System.Data.SqlClient;
using System.Data.SqlServerCe; //Para definir DataTable, SqlDataReader


namespace Presentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                // Subir oscilador
                // Subir
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                // Bajar oscilador
                // Bajar
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                // Izquierda
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                // Derecha
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Entrar
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGestionarLecturador_Click(object sender, EventArgs e)
        {
            frmLecturador frmL = new frmLecturador();
            frmL.ShowDialog();
        }

        private void btnRegistrarLectura_Click(object sender, EventArgs e)
        {
            frmRegistroLectura frmRL = new frmRegistroLectura();
            frmRL.ShowDialog();
        }

        private void btnVaciarBaseDatos_Click(object sender, EventArgs e)
        {
            //neg_Consulta_Movil objM = new neg_Consulta_Movil();


        }
    }
}