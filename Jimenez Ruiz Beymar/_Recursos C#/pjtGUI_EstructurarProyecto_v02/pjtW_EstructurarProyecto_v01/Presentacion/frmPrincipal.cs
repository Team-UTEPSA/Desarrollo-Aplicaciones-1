using pjtW_EstructurarProyecto_v01.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjtW_EstructurarProyecto_v01
{
    

    public partial class frmPrincipal : Form
    {
        
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            frmVendedor frmV = new frmVendedor();
            //frmV.Show();
            frmV.ShowDialog();
        }
    }
}
