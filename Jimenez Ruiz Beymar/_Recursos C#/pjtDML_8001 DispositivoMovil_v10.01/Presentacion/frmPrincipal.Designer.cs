namespace Presentacion
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.btnVaciarBaseDatos = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.btnGestionarLecturador = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrarLectura = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVaciarBaseDatos
            // 
            this.btnVaciarBaseDatos.Location = new System.Drawing.Point(32, 3);
            this.btnVaciarBaseDatos.Name = "btnVaciarBaseDatos";
            this.btnVaciarBaseDatos.Size = new System.Drawing.Size(161, 20);
            this.btnVaciarBaseDatos.TabIndex = 0;
            this.btnVaciarBaseDatos.Text = "Vaciar Base de Datos";
            this.btnVaciarBaseDatos.Click += new System.EventHandler(this.btnVaciarBaseDatos_Click);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(32, 29);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(161, 20);
            this.btnCargarDatos.TabIndex = 1;
            this.btnCargarDatos.Text = "Cargar datos...";
            // 
            // btnGestionarLecturador
            // 
            this.btnGestionarLecturador.Location = new System.Drawing.Point(32, 107);
            this.btnGestionarLecturador.Name = "btnGestionarLecturador";
            this.btnGestionarLecturador.Size = new System.Drawing.Size(161, 20);
            this.btnGestionarLecturador.TabIndex = 2;
            this.btnGestionarLecturador.Text = "Gestionar lecturador...";
            this.btnGestionarLecturador.Click += new System.EventHandler(this.btnGestionarLecturador_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(32, 133);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(161, 20);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegistrarLectura
            // 
            this.btnRegistrarLectura.Location = new System.Drawing.Point(32, 55);
            this.btnRegistrarLectura.Name = "btnRegistrarLectura";
            this.btnRegistrarLectura.Size = new System.Drawing.Size(161, 20);
            this.btnRegistrarLectura.TabIndex = 4;
            this.btnRegistrarLectura.Text = "Registrar lectura...";
            this.btnRegistrarLectura.Click += new System.EventHandler(this.btnRegistrarLectura_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "Descargar datos";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRegistrarLectura);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGestionarLecturador);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.btnVaciarBaseDatos);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPrincipal_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVaciarBaseDatos;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.Button btnGestionarLecturador;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrarLectura;
        private System.Windows.Forms.Button button1;
    }
}

