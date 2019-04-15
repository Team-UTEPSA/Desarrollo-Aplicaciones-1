namespace pjtW_EstructurarProyecto_v01
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVendedor = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVendedor
            // 
            this.btnVendedor.Location = new System.Drawing.Point(21, 21);
            this.btnVendedor.Name = "btnVendedor";
            this.btnVendedor.Size = new System.Drawing.Size(75, 23);
            this.btnVendedor.TabIndex = 0;
            this.btnVendedor.Text = "Vendedor";
            this.btnVendedor.UseVisualStyleBackColor = true;
            this.btnVendedor.Click += new System.EventHandler(this.btnVendedor_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(119, 21);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(75, 23);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(206, 108);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 143);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnVendedor);
            this.Name = "frmPrincipal";
            this.Text = "Group Bytes - Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVendedor;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnSalir;
    }
}

