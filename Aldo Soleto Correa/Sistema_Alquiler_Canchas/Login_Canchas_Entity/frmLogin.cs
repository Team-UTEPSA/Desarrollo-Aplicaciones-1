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
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
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

        private void tbAlias_TextChanged(object sender, EventArgs e)
        {
            if(clogin.validarAlias(tbAlias)==false)
            {
                if (lblEstado.Text == "")
                {
                    lblEstado.Visible = false;
                }
                else
                {
                    lblEstado.Visible = true;
                    lblEstado.Text = "OK!";
                    lblEstado.ForeColor = Color.Green;
                    
                }

            }
            else
            {
                lblEstado.Visible = true;
                lblEstado.Text = "X";
                lblEstado.ForeColor = Color.Red;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            clogin.registrarPersona(tbNombre, tbApellido, rbGenMasculino, rbGenFemenino, dtpFecNacimiento,
                                        tbTelefono, tbAlias, tbPass);
        }
    }
}
