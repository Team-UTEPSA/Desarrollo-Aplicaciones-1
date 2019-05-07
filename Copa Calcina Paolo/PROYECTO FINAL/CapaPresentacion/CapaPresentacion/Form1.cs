using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        CapaNegocio.Login clogin = new CapaNegocio.Login();
        CapaNegocio.cLimpiarValidaciones cClean = new CapaNegocio.cLimpiarValidaciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cClean.validarCamposVaciosLogin(eProvider, tbUsuario, tbPass))
            {
                if (clogin.ValidarUsuario(tbUsuario, tbPass))
                {
                    MessageBox.Show("Bienvenido");
                    frmServicios f = new frmServicios();
                    //registro.lblUser.Text = tbUsuario.Text;
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Credenciales Incorrectas");
                    lblOlvidoContraseña.Visible = true;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(cClean.validarCamposVaciosRegistro(eProvider, tbNombre, tbApellido, rbGenMasculino, rbGenFemenino, dtpFecNacimiento,
                                                tbTelefono, tbAlias, tbContraseña))
            {
                if (clogin.validarAlias(tbAlias))
                {
                    MessageBox.Show("El Usuario " + tbAlias.Text + " ya esta registrado");
                }
                else
                {
                    if (clogin.validarTelefono(tbTelefono))
                    {
                        MessageBox.Show("El teléfono " + tbTelefono.Text + " ya esta registrado");
                    }
                    else
                    {

                        clogin.registrarPersona(tbNombre, tbApellido, rbGenMasculino, rbGenFemenino, dtpFecNacimiento,
                                                    tbTelefono, tbAlias, tbContraseña);
                        cClean.limpiarFlogin(tbNombre, tbApellido, rbGenMasculino, rbGenFemenino, dtpFecNacimiento,
                                                    tbTelefono, tbAlias, tbContraseña);
                        tabControl1.SelectedIndex = 0;
                    }
                }
            }
        }

        private void brnCancelar_Click(object sender, EventArgs e)
        {
            cClean.limpiarFlogin(tbNombre, tbApellido, rbGenMasculino, rbGenFemenino, dtpFecNacimiento, tbTelefono, tbAlias, tbContraseña);

        }

        private void lblOlvidoContraseña_Click(object sender, EventArgs e)
        {

        }
    }
}
