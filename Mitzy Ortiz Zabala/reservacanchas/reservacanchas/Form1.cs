using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_NEGOCIO;
namespace reservacanchas
{
    public partial class Form1 : Form
    {
        Reservas reservas = new Reservas();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cargarComboCancha();
            this.cargarComboCliente();
            this.cargarComboPersonal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbCancha.Text.Trim() == "" || cmbPersonal.Text.Trim() == "" ||
                cmbCliente.Text.Trim() == "" || txtHoraFin.Text.Trim() == "" ||
                txtHoraInicio.Text.Trim() == "" || txtMontoPago.Text.Trim() == "" ||
                cmbTipo.Text.Trim() == "")
            {
                MessageBox.Show("Validación", "Debe llenar todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            object cancha = cmbCancha.SelectedValue;
            object personal = cmbPersonal.SelectedValue;
            object cliente = cmbCliente.SelectedValue;

            DateTime fecha = txtFechaReserva.Value;
            string horaEntrada = txtHoraInicio.Text;
            string horafin = txtHoraFin.Text;
            int idTipoPago = this.obtenerIdTipoPago(cmbTipo.Text.Trim());
            double monto = Double.Parse(txtMontoPago.Text);
            this.reservas.guardar(1, 2, 3, fecha, horaEntrada, horafin, idTipoPago, monto);
        }

        private int obtenerIdTipoPago(string name)
        {
            if (name == "EFECTIVO")
                return 1;

            if (name == "TRANSFERENCIA")
                return 2;
 
            return 3;
        }

        private void cargarComboPersonal()
        {
            cmbPersonal.DataSource = reservas.obtenerDatosPersonal();
            cmbPersonal.DisplayMember = "nombre_personal";
            cmbPersonal.ValueMember = "idpersonal";
        }

        private void cargarComboCliente()
        {
            cmbPersonal.DataSource = reservas.obtenerDatosPersonal();
            cmbPersonal.DisplayMember = "nombre_cliente";
            cmbPersonal.ValueMember = "idcliente";
        }

        private void cargarComboCancha()
        {
            cmbPersonal.DataSource = reservas.obtenerDatosPersonal();
            cmbPersonal.DisplayMember = "descripcion";
            cmbPersonal.ValueMember = "idcancha";
        }
    }
}
