using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportarExcelToDatagridview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region "Variables"
        String ruta = "";
        string loginPc = SystemInformation.UserName;
        DateTime fecha = DateTime.Now;

        OleDbConnection conn;
        OleDbDataAdapter q;
        DataTable dt;
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region "METODOS"
        public void CargarArchivo()
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Excel Files |*.xlsx";
                open.Title = "Seleccione el archivo de Excel";
                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (open.FileName.Equals("") == false)
                    {
                        ruta = open.FileName;
                        txbRuta.Text = ruta;
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error" + Ex);
            }
        }

        public void CargarDatosDGV()
        {

            String hoja = txbHoja.Text;
            try
            {
                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" + ruta + ";Extended Properties='Excel 12.0 Xml;HDR=Yes'");
                q = new OleDbDataAdapter("Select * from [" + hoja + "$]", conn);
                dt = new DataTable();
                q.Fill(dt);
                dgvDatosExcel.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        public bool ValidarDGV()
        {
            try
            {
                bool ok = true;
                eProvider.Clear();
                if (dgvDatosExcel.Rows.Count - 1 == 0)
                {
                    ok = false;
                    eProvider.SetError(dgvDatosExcel, "No se han cargado los datos");
                }
                return ok;
            }
            catch (Exception Ex)
            {

                MessageBox.Show("Error" + Ex);
                return false;
            }
        }
        public void limpiarControles()
        {
            txbRuta.Text = "";
            txbHoja.Text = "";
            dgvDatosExcel.DataSource = null;
        }


        #endregion

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            CargarArchivo();
            btnCargarDatos.Enabled = true;
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
                CargarDatosDGV();
            
        }
    }
}
