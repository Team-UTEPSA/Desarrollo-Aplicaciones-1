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
using CAPA_DATOS;
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
            clear();
            this.cargarComboCancha();
            this.cargarComboCliente();
            this.cargarComboPersonal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // VALIDACTION DE FORMULARIO
            if (cmbCancha.Text.Trim() == "" || cmbPersonal.Text.Trim() == "" ||
                cmbCliente.Text.Trim() == "" || txtHoraFin.Text.Trim() == "" ||
                txtHoraInicio.Text.Trim() == "" || txtMontoPago.Text.Trim() == "" ||
                cmbTipo.Text.Trim() == "" || txtMontoDescuento.Text.Trim() == "")
            {
                MessageBox.Show("Debe llenar todos los campos", "Validaciòn", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                ComboboxItem cancha = (ComboboxItem)cmbCancha.SelectedItem;
                ComboboxItem personal = (ComboboxItem) cmbPersonal.SelectedItem;
                ComboboxItem cliente = (ComboboxItem) cmbCliente.SelectedItem;

                DateTime fecha = txtFechaReserva.Value;
                string horaEntrada = txtHoraInicio.Text;
                string horafin = txtHoraFin.Text;
                int idTipoPago = this.obtenerIdTipoPago(cmbTipo.Text.Trim());
                double monto = Double.Parse(txtMontoPago.Text);
                double descuento = Double.Parse(txtMontoDescuento.Text);
                this.reservas.guardar((int) personal.Value, (int) cliente.Value, (int)cancha.Value, fecha, horaEntrada, horafin, idTipoPago, monto, descuento);

                MessageBox.Show("Se guardo correctamente");
                clear();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void clear()
        {
            cmbCancha.Text = "";
            cmbPersonal.Text = "";
            cmbCliente.Text = "";
            txtHoraFin.Text = "";
            txtHoraInicio.Text = "";
            txtMontoPago.Text = "";
            cmbTipo.Text = "";
            txtMontoDescuento.Text = "";
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
            foreach (tblPersonal personal in  reservas.obtenerDatosPersonal())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = personal.tblPersona.Nombre;
                item.Value = personal.idPersonal;
                cmbPersonal.Items.Add(item);
            }
        }

        private void cargarComboCliente()
        {
            foreach (tblCliente cliente in reservas.obtenerDatosClientes())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = cliente.tblPersona.Nombre;
                item.Value = cliente.idCliente;
                cmbCliente.Items.Add(item);
            }
        }

        private void cargarComboCancha()
        {
            foreach (tblCancha cancha in reservas.obtenerDatosCancha())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = cancha.Nombre;
                item.Value = cancha.idCancha;
                cmbCancha.Items.Add(item);
            }
        }

        private void txtHoraInicio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
