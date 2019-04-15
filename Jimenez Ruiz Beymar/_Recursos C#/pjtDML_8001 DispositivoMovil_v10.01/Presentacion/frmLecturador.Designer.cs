namespace Presentacion
{
    partial class frmLecturador
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
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuLecturador = new System.Windows.Forms.MenuItem();
            this.mnuGuardar = new System.Windows.Forms.MenuItem();
            this.mnuBuscar = new System.Windows.Forms.MenuItem();
            this.mnuActualizar = new System.Windows.Forms.MenuItem();
            this.mnuEliminar = new System.Windows.Forms.MenuItem();
            this.mnuMostrarTodos = new System.Windows.Forms.MenuItem();
            this.mnuCerrar = new System.Windows.Forms.MenuItem();
            this.dgvLecturador = new System.Windows.Forms.DataGrid();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.mnuLecturador);
            this.mainMenu1.MenuItems.Add(this.mnuCerrar);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(78, 92);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 21);
            this.txtTelefono.TabIndex = 38;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(67, 65);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(159, 21);
            this.txtApellido.TabIndex = 37;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(66, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 21);
            this.txtNombre.TabIndex = 36;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(41, 13);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(63, 21);
            this.txtId.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 14);
            this.label4.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 14);
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 14);
            this.label1.Text = "Id:";
            // 
            // mnuLecturador
            // 
            this.mnuLecturador.MenuItems.Add(this.mnuGuardar);
            this.mnuLecturador.MenuItems.Add(this.mnuBuscar);
            this.mnuLecturador.MenuItems.Add(this.mnuActualizar);
            this.mnuLecturador.MenuItems.Add(this.mnuEliminar);
            this.mnuLecturador.MenuItems.Add(this.mnuMostrarTodos);
            this.mnuLecturador.Text = "Lecturador";
            // 
            // mnuGuardar
            // 
            this.mnuGuardar.Text = "Guardar";
            this.mnuGuardar.Click += new System.EventHandler(this.mnuGuardar_Click);
            // 
            // mnuBuscar
            // 
            this.mnuBuscar.Text = "Buscar";
            this.mnuBuscar.Click += new System.EventHandler(this.mnuBuscar_Click);
            // 
            // mnuActualizar
            // 
            this.mnuActualizar.Text = "Actualizar";
            this.mnuActualizar.Click += new System.EventHandler(this.mnuActualizar_Click);
            // 
            // mnuEliminar
            // 
            this.mnuEliminar.Text = "Eliminar";
            this.mnuEliminar.Click += new System.EventHandler(this.mnuEliminar_Click);
            // 
            // mnuMostrarTodos
            // 
            this.mnuMostrarTodos.Text = "Mostrar todos";
            this.mnuMostrarTodos.Click += new System.EventHandler(this.mnuMostrarTodos_Click);
            // 
            // mnuCerrar
            // 
            this.mnuCerrar.Text = "Cerrar";
            this.mnuCerrar.Click += new System.EventHandler(this.mnuCerrar_Click);
            // 
            // dgvLecturador
            // 
            this.dgvLecturador.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvLecturador.Location = new System.Drawing.Point(3, 118);
            this.dgvLecturador.Name = "dgvLecturador";
            this.dgvLecturador.Size = new System.Drawing.Size(234, 147);
            this.dgvLecturador.TabIndex = 43;
            // 
            // frmLecturador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.dgvLecturador);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "frmLecturador";
            this.Text = "Lecturador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuItem mnuLecturador;
        private System.Windows.Forms.MenuItem mnuGuardar;
        private System.Windows.Forms.MenuItem mnuBuscar;
        private System.Windows.Forms.MenuItem mnuActualizar;
        private System.Windows.Forms.MenuItem mnuEliminar;
        private System.Windows.Forms.MenuItem mnuMostrarTodos;
        private System.Windows.Forms.MenuItem mnuCerrar;
        private System.Windows.Forms.DataGrid dgvLecturador;
    }
}