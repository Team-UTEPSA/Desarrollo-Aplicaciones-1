using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaLogica_Negocio
{
    public class CLogin
    {
        //CapaDatos.DBCanchaEntities cancha = new CapaDatos.DBCanchaEntities();
        CapaDatos.dbCancha2Entities cancha2 = new CapaDatos.dbCancha2Entities();
        
        public bool  ValidarUsuario(TextBox user, TextBox pass)
        {

            bool ok = true;
            var quser = (from q in this.cancha2.tblPersona
                        where q.Usuario == user.Text.Trim() && q.Contraseña == pass.Text.Trim()
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

        public void registrarPersona(TextBox nomb, TextBox ap, RadioButton genm, RadioButton genf, 
                                    DateTimePicker fecnac, TextBox telf, TextBox alias, TextBox pass)
        {
            try
            {
                CapaDatos.tblPersona pers = new CapaDatos.tblPersona();
                pers.Nombre = nomb.Text;
                pers.Apellido = ap.Text;
                if(genm.Checked== true)
                {
                    pers.Sexo = 0;
                }
                else
                {
                    pers.Sexo = 1;
                }
                pers.FechaNacimiento = Convert.ToDateTime(fecnac.Text);
                pers.Telefono = telf.Text;
                pers.Usuario = alias.Text.Trim();
                pers.Contraseña = pass.Text.Trim();
                cancha2.tblPersona.Add(pers);
                cancha2.SaveChanges();
                registrarTipoCuentaUsuario();
                MessageBox.Show("Usuario Registrado!!");
            }

            catch (Exception Ex)
            {
                MessageBox.Show("Error" + Ex);
            }
        }

        public Boolean  validarAlias(TextBox user)
        {
            bool ok = true;
            var quser = (from q in this.cancha2.tblPersona
                         where q.Usuario == user.Text
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
        public Boolean validarTelefono(TextBox telf)
        {
            bool ok = true;
            var quser = (from q in this.cancha2.tblPersona
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
        
        public void registrarTipoCuentaUsuario( )
        {
            var quser = this.cancha2.tblPersona
                        .OrderByDescending(x => x.idPersona)
                         .FirstOrDefault().idPersona;
            if(quser !=0)
            {
                CapaDatos.tblCuentaUsuario cta = new CapaDatos.tblCuentaUsuario();
                cta.fkPersona = quser;
                cta.TipoUsuario = 2;
                cta.FechaRegistro = DateTime.Now;
                cta.Estado = 1;
                cancha2.tblCuentaUsuario.Add(cta);
                cancha2.SaveChanges();
            }
        }
    }
}
