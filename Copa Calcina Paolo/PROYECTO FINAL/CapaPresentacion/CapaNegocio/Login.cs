using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class Login
    {
        
        CapaDato.BDCanchaEntities cancha = new CapaDato.BDCanchaEntities();
       

        public bool ValidarUsuario(TextBox user, TextBox pass)
        {

            bool ok = true;
            var quser = (from q in this.cancha.tblPersona
                         where q.Usuario == user.Text && q.Contraseña == pass.Text
                         select q).ToList().FirstOrDefault();

            if (quser != null)
            {
                return ok;
            }
            else
            {
                return false;
            }
        }

        public void registrarPersona(TextBox nomb, TextBox ap, RadioButton genm, RadioButton genf, DateTimePicker fecnac,
                                     TextBox telf, TextBox alias, TextBox pass)
        {
            try
            {
                CapaDato.tblPersona pers = new CapaDato.tblPersona();
                pers.Nombre = nomb.Text;
                pers.Apellido = ap.Text;
                if (genm.Checked == true)
                {
                    pers.Sexo = 0;
                }
                else
                {
                    pers.Sexo = 1;
                }
                pers.FechaNacimiento = Convert.ToDateTime(fecnac.Text);
                pers.Telefono = telf.Text;
                pers.Usuario = alias.Text;
                pers.Contraseña = pass.Text;
                cancha.tblPersona.Add(pers);
                cancha.SaveChanges();
                MessageBox.Show("Usuario Registrado!!");
            }

            catch (Exception Ex)
            {
                MessageBox.Show("Error" + Ex);
            }
        }

        public Boolean validarAlias(TextBox user)
        {
            bool ok = true;
            var quser = (from q in this.cancha.tblPersona
                         where q.Usuario == user.Text
                         select q).ToList().FirstOrDefault();

            if (quser != null)
            {
                return ok;
            }
            else
            {
                return false;
            }

        }
        public Boolean validarTelefono(TextBox telf)
        {
            bool ok = true;
            var quser = (from q in this.cancha.tblPersona
                         where q.Telefono == telf.Text
                         select q).ToList().FirstOrDefault();

            if (quser != null)
            {
                return ok;
                //MessageBox.Show("El Usuario ya esta registrado");
            }
            else
            {
                return false;
            }
        }

        public void registrarTipoCuentaUsuario()
        {
            var quser = this.cancha.tblPersona
                        .OrderByDescending(x => x.idPersona)
                         .FirstOrDefault().idPersona;
            if (quser != 0)
            {
                CapaDato.tblCuentaUsuario cta = new CapaDato.tblCuentaUsuario();
                cta.fkPersona = quser;
                cta.TipoUsuario = 2;
                cta.FechaRegistro = DateTime.Now;
                cta.Estado = 1;
                cancha.tblCuentaUsuario.Add(cta);
                cancha.SaveChanges();
            }
        }
    }
}
