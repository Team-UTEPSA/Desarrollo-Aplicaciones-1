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
    public partial class frmRegistroLectura : Form
    {
        public frmRegistroLectura()
        {
            InitializeComponent();
        }

        private void cmbMedidor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbZona_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbLecturador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mnuCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuImprimir_Click(object sender, EventArgs e)
        {
            int iConsumoMes;
            float iPrecioConsumoMes;
            String sDetalle;

            iConsumoMes = int.Parse(txtLecturaActual.Text) - int.Parse(lblLecturaAnterior.Text);
            iPrecioConsumoMes = iConsumoMes * ObtenerPrecioServicioCategoria(); //Obtener precio de la categoria

            sDetalle = "Consumo actual: " + Convert.ToString(iConsumoMes) + "  Precio cosumo mes: " + Convert.ToString(iPrecioConsumoMes);
            MessageBox.Show(sDetalle, "Impresión - Aviso de Cobranza");

        }

        private void mnuGuardar_Click(object sender, EventArgs e)
        {
            neg_RegistroLectura_Movil objRL_M = new neg_RegistroLectura_Movil();
            neg_RegistroLectura_Servidor objRL_S = new neg_RegistroLectura_Servidor();

            int id = int.Parse(lblId.Text);
            DateTime fecha = Convert.ToDateTime(txtFecha.Text); //DateTime.Parse(dtpFecha.Text);
            //DateTime fecha = DateTime.Parse(txtFecha.Text); //DateTime.Parse(dtpFecha.Text);
            int lecturaActual = int.Parse(txtLecturaActual.Text);
            bool enviado = false; //bool.Parse(txtEnviado.Text);
            int idLecturador = int.Parse(cmbLecturador.Text);
            int periodo = int.Parse(cmbPeriodo.Text);
            int idMedidor = int.Parse(cmbMedidor.Text);
            //objRL_M.Insertar(id, fecha, lecturaActual, enviado, idLecturador, periodo, idMedidor);
            objRL_S.Insertar(id, fecha, lecturaActual, enviado, idLecturador, periodo, idMedidor);
        }

        private float ObtenerPrecioServicioCategoria()
        {
            float iPrecio;
            DataTable dtC = new DataTable();
            neg_Consulta_Servidor objSql = new neg_Consulta_Servidor("SELECT Precio FROM tblCategoria WHERE Id= (SELECT IdCategoria FROM tblMedidor WHERE Id=" + cmbMedidor.Text + ")");

            dtC = objSql.ObtenerConsulta();
            iPrecio = float.Parse(dtC.Rows[0][0].ToString());
            return iPrecio;
        }

        private void frmRegistroLectura_Load(object sender, EventArgs e)
        {
            lblId.Text = Convert.ToString(ObtenerIdRegistroLectura_Ultimo() + 1);
            String strFechaActual = DateTime.Now.ToShortDateString();
            //lblFecha.Text = DateTime.Now.ToLongTimeString();
            txtFecha.Text = DateTime.Now.ToShortDateString();
            CargarLecturador();
            CargarPeriodos();

        }

        private int ObtenerIdRegistroLectura_Ultimo()
        {
            DataTable dtRL = new DataTable();
            neg_Consulta_Servidor objSql = new neg_Consulta_Servidor("SELECT MAX(Id) FROM tblRegistroLectura");

            dtRL = objSql.ObtenerConsulta();
            return int.Parse(dtRL.Rows[0][0].ToString());
        }

        private void CargarPeriodos()
        {
            DataTable dtP = new DataTable();
            neg_Consulta_Servidor objP = new neg_Consulta_Servidor("Select * From tblPeriodo");

            dtP = objP.ObtenerConsulta();
            CargarComboBox(ref cmbPeriodo, dtP, "Id");
        }

        private void CargarLecturador()
        {
            DataTable dtL = new DataTable();
            neg_Lecturador_Servidor objL = new neg_Lecturador_Servidor();

            dtL = objL.Buscar_Todos();
            CargarComboBox(ref cmbLecturador, dtL, "Id");
        }

        private void CargarComboBox(ref ComboBox cmb, DataTable dt, String campo)
        {
            int k;

            k = dt.Rows.Count;
            cmb.Items.Clear();
            for (int i = 0; i < k; i++)
            {
                cmb.Items.Add(dt.Rows[i][campo].ToString());
            }
        }

        private void cmbLecturador_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            neg_Zona_Servidor objL = new neg_Zona_Servidor();

            dgvRegistroLectura.DataSource = null;
            String aux = cmbLecturador.Text;
            dt = objL.Buscar_Parametrizado("IdLecturador= " + aux);
            CargarComboBox(ref cmbZona, dt, "Id");
        }

        private void cmbZona_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataTable dtM = new DataTable();
            neg_Medidor_Servidor objM = new neg_Medidor_Servidor();

            dgvRegistroLectura.DataSource = null;
            dtM = objM.Buscar_Parametrizado("IdZona= " + cmbZona.Text);
            CargarComboBox(ref cmbMedidor, dtM, "Id");
        }

        private void cmbMedidor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataTable dtMmax = new DataTable();
            neg_RegistroLectura_Servidor objRL = new neg_RegistroLectura_Servidor();
            DataTable dt1 = new DataTable();

            String medidor = cmbMedidor.Text;
            dt1 = objRL.Buscar_Parametrizado("IdMedidor= " + medidor);
            dgvRegistroLectura.DataSource = dt1;
            neg_Consulta_Servidor cstMmax = new neg_Consulta_Servidor("select max(Lectura) from tblRegistroLectura where IdMedidor= " + cmbMedidor.Text);
            dtMmax = cstMmax.ObtenerConsulta();
            string strLecturaAnterior;
            strLecturaAnterior = dtMmax.Rows[0][0].ToString();
            if (strLecturaAnterior.Length < 1)
            {
                strLecturaAnterior = "0";
            }
            lblLecturaAnterior.Text = strLecturaAnterior;
        }



    }
}