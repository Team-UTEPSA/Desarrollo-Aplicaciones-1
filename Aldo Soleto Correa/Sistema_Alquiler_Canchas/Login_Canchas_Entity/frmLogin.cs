using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Canchas_Entity
{
    public partial class frmLogin : Form
    {
        CapaLogica_Negocio.CLogin clogin = new CapaLogica_Negocio.CLogin();
        CapaLogica_Negocio.cLimpiarValidaciones cClean = new CapaLogica_Negocio.cLimpiarValidaciones();
        public frmLogin()
        {
            InitializeComponent();
        }   

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(cClean.validarCamposVaciosLogin(eProvider, tbUsuario,tbPass))
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

        private void tbAlias_TextChanged(object sender, EventArgs e)
        {
            //if (clogin.validarAlias(tbAlias) == false)
            //{
            //    MessageBox.Show("El Usuario ya esta registrado");
            //    //if (lblEstado.Text == "")
            //    //{
            //    //    lblEstado.Visible = false;
            //    //}
            //}
            //else
            //{
            //    lblEstado.Visible = true;
            //    lblEstado.Text = "OK!";
            //    lblEstado.ForeColor = Color.Green;
            //}

            
            //else
            //{
            //    lblEstado.Visible = true;
            //    lblEstado.Text = "X";
            //    lblEstado.ForeColor = Color.Red;
            //}
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cClean.validarCamposVaciosRegistro(eProvider,tbNombre, tbApellido, rbGenMasculino, rbGenFemenino, dtpFecNacimiento,
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

        private void tbAlias_Validating(object sender, CancelEventArgs e)
        {
            //TextBox tb = (TextBox)sender;
            //if (tb.Text == "")
            //{
            //   // e.Cancel = true;
            //    //tb.Select(0, tb.Text.Length);
            //    lblEstado.Visible = false;
            //    //errorProvider1.SetError(tb, "Debe introducir el nombre");
            //}
        }

        private void brnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
           //cClean.limpiarFlogin(tbNombre, tbApellido, rbGenMasculino, rbGenFemenino, dtpFecNacimiento, tbTelefono, tbAlias, tbContraseña);
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblOlvidoContraseña_Click(object sender, EventArgs e)
        {

        }
    }
}
