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
    public partial class frmServicios : Form
    {
        public frmServicios()
        {
            InitializeComponent();
        }

        private void eDITARPERFILToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                int id = int.Parse(label1.Text);
                int ci = int.Parse(label1.Text);
                string nombre = txtnombre.Text;
                string paterno = txtcontra.Text;
                string materno = txtalias.Text;
                string direccion = txttelefono.Text;
                int telefono = int.Parse(txttelefono.Text);


                objeto.modificar(id, ci, nombre, paterno, materno, direccion, telefono);
                MessageBox.Show("modificado correctamente!");
            }
            catch
            {
                MessageBox.Show("error!");
            }
            Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int id = int.Parse(label1.Text);
                int ci = int.Parse(label1.Text);
                string nombre = txtnombre.Text;
                string paterno = txtcontra.Text;
                string materno = txtalias.Text;
                string direccion = txttelefono.Text;
                int telefono = int.Parse(txttelefono.Text);



                objeto.modificar(id, ci, nombre, apellido, Genero, alias, contraceña);
                MessageBox.Show("modificado correctamente!");
            }
            catch
            {
                MessageBox.Show("error!");
            }
            Close();

        }
    }
}
