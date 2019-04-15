namespace Presentacion
{
    partial class frmRegistroLectura
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
            this.mnuRegistroLectura = new System.Windows.Forms.MenuItem();
            this.mnuImprimir = new System.Windows.Forms.MenuItem();
            this.mnuGuardar = new System.Windows.Forms.MenuItem();
            this.mnuCerrar = new System.Windows.Forms.MenuItem();
            this.lblId = new System.Windows.Forms.Label();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.lblLecturaAnterior = new System.Windows.Forms.Label();
            this.txtLecturaActual = new System.Windows.Forms.TextBox();
            this.cmbMedidor = new System.Windows.Forms.ComboBox();
            this.cmbZona = new System.Windows.Forms.ComboBox();
            this.cmbLecturador = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRegistroLectura = new System.Windows.Forms.DataGrid();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.mnuRegistroLectura);
            this.mainMenu1.MenuItems.Add(this.mnuCerrar);
            // 
            // mnuRegistroLectura
            // 
            this.mnuRegistroLectura.MenuItems.Add(this.mnuImprimir);
            this.mnuRegistroLectura.MenuItems.Add(this.mnuGuardar);
            this.mnuRegistroLectura.Text = "Registro lectura";
            // 
            // mnuImprimir
            // 
            this.mnuImprimir.Text = "Imprimir";
            this.mnuImprimir.Click += new System.EventHandler(this.mnuImprimir_Click);
            // 
            // mnuGuardar
            // 
            this.mnuGuardar.Text = "Guardar";
            this.mnuGuardar.Click += new System.EventHandler(this.mnuGuardar_Click);
            // 
            // mnuCerrar
            // 
            this.mnuCerrar.Text = "Cerrar";
            this.mnuCerrar.Click += new System.EventHandler(this.mnuCerrar_Click);
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(41, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(60, 13);
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.Location = new System.Drawing.Point(107, 120);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(69, 22);
            this.cmbPeriodo.TabIndex = 29;
            // 
            // lblLecturaAnterior
            // 
            this.lblLecturaAnterior.Location = new System.Drawing.Point(107, 150);
            this.lblLecturaAnterior.Name = "lblLecturaAnterior";
            this.lblLecturaAnterior.Size = new System.Drawing.Size(69, 13);
            // 
            // txtLecturaActual
            // 
            this.txtLecturaActual.Location = new System.Drawing.Point(107, 166);
            this.txtLecturaActual.Name = "txtLecturaActual";
            this.txtLecturaActual.Size = new System.Drawing.Size(69, 21);
            this.txtLecturaActual.TabIndex = 28;
            // 
            // cmbMedidor
            // 
            this.cmbMedidor.Location = new System.Drawing.Point(107, 93);
            this.cmbMedidor.Name = "cmbMedidor";
            this.cmbMedidor.Size = new System.Drawing.Size(69, 22);
            this.cmbMedidor.TabIndex = 27;
            this.cmbMedidor.SelectedIndexChanged += new System.EventHandler(this.cmbMedidor_SelectedIndexChanged_1);
            // 
            // cmbZona
            // 
            this.cmbZona.Location = new System.Drawing.Point(107, 65);
            this.cmbZona.Name = "cmbZona";
            this.cmbZona.Size = new System.Drawing.Size(69, 22);
            this.cmbZona.TabIndex = 26;
            this.cmbZona.SelectedIndexChanged += new System.EventHandler(this.cmbZona_SelectedIndexChanged_1);
            // 
            // cmbLecturador
            // 
            this.cmbLecturador.Location = new System.Drawing.Point(107, 38);
            this.cmbLecturador.Name = "cmbLecturador";
            this.cmbLecturador.Size = new System.Drawing.Size(69, 22);
            this.cmbLecturador.TabIndex = 25;
            this.cmbLecturador.SelectedIndexChanged += new System.EventHandler(this.cmbLecturador_SelectedIndexChanged_1);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(7, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 14);
            this.label8.Text = "Lectura actual:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(7, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 14);
            this.label7.Text = "Periodo:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.Text = "Medidor:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.Text = "Zona:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.Text = "Lectura anterior:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.Text = "Lecturador:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.Text = "Id:";
            // 
            // dgvRegistroLectura
            // 
            this.dgvRegistroLectura.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvRegistroLectura.Location = new System.Drawing.Point(7, 193);
            this.dgvRegistroLectura.Name = "dgvRegistroLectura";
            this.dgvRegistroLectura.Size = new System.Drawing.Size(230, 72);
            this.dgvRegistroLectura.TabIndex = 39;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(107, 14);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(69, 21);
            this.txtFecha.TabIndex = 51;
            // 
            // frmRegistroLectura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.dgvRegistroLectura);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.cmbPeriodo);
            this.Controls.Add(this.lblLecturaAnterior);
            this.Controls.Add(this.txtLecturaActual);
            this.Controls.Add(this.cmbMedidor);
            this.Controls.Add(this.cmbZona);
            this.Controls.Add(this.cmbLecturador);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "frmRegistroLectura";
            this.Text = "frmRegistroLectura";
            this.Load += new System.EventHandler(this.frmRegistroLectura_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.Label lblLecturaAnterior;
        private System.Windows.Forms.TextBox txtLecturaActual;
        private System.Windows.Forms.ComboBox cmbMedidor;
        private System.Windows.Forms.ComboBox cmbZona;
        private System.Windows.Forms.ComboBox cmbLecturador;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuItem mnuRegistroLectura;
        private System.Windows.Forms.MenuItem mnuGuardar;
        private System.Windows.Forms.DataGrid dgvRegistroLectura;
        private System.Windows.Forms.MenuItem mnuImprimir;
        private System.Windows.Forms.MenuItem mnuCerrar;
        private System.Windows.Forms.TextBox txtFecha;
    }
}