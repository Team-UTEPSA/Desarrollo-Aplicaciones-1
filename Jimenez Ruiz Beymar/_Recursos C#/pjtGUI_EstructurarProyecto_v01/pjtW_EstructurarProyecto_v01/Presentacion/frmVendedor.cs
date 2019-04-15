using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjtW_EstructurarProyecto_v01.Presentacion
{
    public partial class frmVendedor : Form
    {
        public frmVendedor()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMensaje_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ERROR: Opción no habilitada",
                "Group Bytes:: Error...",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Error);
        }
    }
}
