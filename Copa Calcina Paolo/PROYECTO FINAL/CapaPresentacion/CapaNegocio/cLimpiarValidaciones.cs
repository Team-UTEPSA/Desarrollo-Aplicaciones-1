using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class cLimpiarValidaciones
    {
        public void limpiarFlogin(TextBox nomb, TextBox ap, RadioButton genm, RadioButton genf,
                                    DateTimePicker fecnac, TextBox telf, TextBox alias, TextBox pass)
        {
            nomb.Text = "";
            ap.Text = "";
            genm.Checked = true;
            genf.Checked = false;
            fecnac.Value = DateTime.Now;
            telf.Text = "";
            alias.Text = "";
            pass.Text = "";
        }

        public bool validarCamposVaciosLogin(object eProvider, TextBox tbUsuario, TextBox tbPass)
        {
            throw new NotImplementedException();
        }

        public bool validarCamposVaciosRegistro(ErrorProvider eprov, TextBox nomb, TextBox ap, RadioButton genm, RadioButton genf,
                                    DateTimePicker fecnac, TextBox telf, TextBox alias, TextBox pass)
        {
            eprov.Clear();
            bool ok = true;
            if (nomb.Text == "")
            {
                ok = false;
                eprov.SetError(nomb, "Ingresar Nombre");
            }
            if (ap.Text == "")
            {
                ok = false;
                eprov.SetError(ap, "Ingresar Apellido");
            }
            if (genm.Checked == false && genf.Checked == false)
            {
                ok = false;
                eprov.SetError(genf, "Debe indicar género");
            }
            if (fecnac.Value > DateTime.Now.AddYears(-16))
            {
                ok = false;
                eprov.SetError(fecnac, "Debes ser mayor de 16 años");
            }
            if (telf.Text == "")
            {
                ok = false;
                eprov.SetError(telf, "Ingresa un Teléfono");
            }
            if (telf.Text.Trim().Length != 8)
            {
                ok = false;
                eprov.SetError(telf, "tu Nro. telefónico debe tener 8 dígitos");

            }
            if (alias.Text == "")
            {
                ok = false;
                eprov.SetError(alias, "Ingresa un alias de usuario");
            }
            if (pass.Text == "")
            {
                ok = false;
                eprov.SetError(pass, "Debes ingresar una contraseña");
            }
            return ok;

        }
        public bool validarCamposVaciosLogin(ErrorProvider eprov, TextBox user, TextBox pass)
        {
            eprov.Clear();
            bool ok = true;
            if (user.Text == "")
            {
                ok = false;
                eprov.SetError(user, "Ingresa un alias");
            }
            if (pass.Text == "")
            {
                ok = false;
                eprov.SetError(pass, "Ingresa unas contraseña");
            }
            return ok;

        }
    }
}
