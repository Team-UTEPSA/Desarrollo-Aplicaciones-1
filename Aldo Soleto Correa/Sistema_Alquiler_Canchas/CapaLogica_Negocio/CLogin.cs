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
        CapaDatos.DBCanchaEntities cancha = new CapaDatos.DBCanchaEntities();
        public bool  ValidarUsuario(TextBox user, TextBox pass)
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

        public Boolean  validarAlias(TextBox user)
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
    }
}
