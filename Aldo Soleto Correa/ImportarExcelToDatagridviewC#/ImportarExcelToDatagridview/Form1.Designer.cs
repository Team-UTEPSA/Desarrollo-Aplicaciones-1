namespace ImportarExcelToDatagridview
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbCargarArchivo = new System.Windows.Forms.GroupBox();
            this.txbHoja = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txbRuta = new System.Windows.Forms.TextBox();
            this.lbluserpc = new System.Windows.Forms.Label();
            this.lblmac = new System.Windows.Forms.Label();
            this.btnCargarArchivo = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDatosExcel = new System.Windows.Forms.DataGridView();
            this.eProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbCargarArchivo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(894, 554);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbCargarArchivo);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(886, 528);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Importar Planilla";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbCargarArchivo
            // 
            this.gbCargarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCargarArchivo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbCargarArchivo.Controls.Add(this.txbHoja);
            this.gbCargarArchivo.Controls.Add(this.lblUser);
            this.gbCargarArchivo.Controls.Add(this.txbRuta);
            this.gbCargarArchivo.Controls.Add(this.lbluserpc);
            this.gbCargarArchivo.Controls.Add(this.lblmac);
            this.gbCargarArchivo.Controls.Add(this.btnCargarArchivo);
            this.gbCargarArchivo.Controls.Add(this.btnImportar);
            this.gbCargarArchivo.Controls.Add(this.label2);
            this.gbCargarArchivo.Controls.Add(this.btnCancelar);
            this.gbCargarArchivo.Controls.Add(this.btnCargarDatos);
            this.gbCargarArchivo.Controls.Add(this.label1);
            this.gbCargarArchivo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbCargarArchivo.Location = new System.Drawing.Point(6, 6);
            this.gbCargarArchivo.Name = "gbCargarArchivo";
            this.gbCargarArchivo.Size = new System.Drawing.Size(873, 127);
            this.gbCargarArchivo.TabIndex = 8;
            this.gbCargarArchivo.TabStop = false;
            this.gbCargarArchivo.Text = "Cargar Archivo Excel";
            // 
            // txbHoja
            // 
            this.txbHoja.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txbHoja.Location = new System.Drawing.Point(359, 35);
            this.txbHoja.Name = "txbHoja";
            this.txbHoja.Size = new System.Drawing.Size(181, 21);
            this.txbHoja.TabIndex = 3;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblUser.Location = new System.Drawing.Point(755, 8);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(39, 17);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "USER";
            // 
            // txbRuta
            // 
            this.txbRuta.Enabled = false;
            this.txbRuta.Location = new System.Drawing.Point(131, 35);
            this.txbRuta.Name = "txbRuta";
            this.txbRuta.Size = new System.Drawing.Size(207, 21);
            this.txbRuta.TabIndex = 2;
            // 
            // lbluserpc
            // 
            this.lbluserpc.AutoSize = true;
            this.lbluserpc.Location = new System.Drawing.Point(404, 8);
            this.lbluserpc.Name = "lbluserpc";
            this.lbluserpc.Size = new System.Drawing.Size(48, 15);
            this.lbluserpc.TabIndex = 11;
            this.lbluserpc.Text = "USERPC";
            this.lbluserpc.Visible = false;
            // 
            // lblmac
            // 
            this.lblmac.AutoSize = true;
            this.lblmac.Location = new System.Drawing.Point(370, 8);
            this.lblmac.Name = "lblmac";
            this.lblmac.Size = new System.Drawing.Size(30, 15);
            this.lblmac.TabIndex = 10;
            this.lblmac.Text = "mac";
            this.lblmac.Visible = false;
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCargarArchivo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarArchivo.ForeColor = System.Drawing.Color.White;
            this.btnCargarArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarArchivo.ImageIndex = 5;
            this.btnCargarArchivo.Location = new System.Drawing.Point(11, 26);
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(108, 39);
            this.btnCargarArchivo.TabIndex = 1;
            this.btnCargarArchivo.Text = "AÑADIR";
            this.btnCargarArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarArchivo.UseVisualStyleBackColor = false;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnImportar.Enabled = false;
            this.btnImportar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.ForeColor = System.Drawing.Color.White;
            this.btnImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportar.ImageIndex = 6;
            this.btnImportar.Location = new System.Drawing.Point(144, 71);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(108, 40);
            this.btnImportar.TabIndex = 12;
            this.btnImportar.Text = "IMPORTAR";
            this.btnImportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "RUTA DEL ARCHIVO";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.ImageIndex = 1;
            this.btnCancelar.Location = new System.Drawing.Point(474, 71);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 40);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCargarDatos.Enabled = false;
            this.btnCargarDatos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarDatos.ForeColor = System.Drawing.Color.White;
            this.btnCargarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarDatos.ImageIndex = 0;
            this.btnCargarDatos.Location = new System.Drawing.Point(11, 71);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(108, 40);
            this.btnCargarDatos.TabIndex = 5;
            this.btnCargarDatos.Text = "MOSTRAR";
            this.btnCargarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarDatos.UseVisualStyleBackColor = false;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOMBRE DE LA HOJA";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgvDatosExcel);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 391);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS IMPORTADOS";
            // 
            // dgvDatosExcel
            // 
            this.dgvDatosExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatosExcel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatosExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosExcel.Location = new System.Drawing.Point(14, 15);
            this.dgvDatosExcel.Name = "dgvDatosExcel";
            this.dgvDatosExcel.Size = new System.Drawing.Size(846, 370);
            this.dgvDatosExcel.TabIndex = 0;
            // 
            // eProvider
            // 
            this.eProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(918, 571);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbCargarArchivo.ResumeLayout(false);
            this.gbCargarArchivo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbCargarArchivo;
        private System.Windows.Forms.TextBox txbHoja;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txbRuta;
        private System.Windows.Forms.Label lbluserpc;
        private System.Windows.Forms.Label lblmac;
        private System.Windows.Forms.Button btnCargarArchivo;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDatosExcel;
        private System.Windows.Forms.ErrorProvider eProvider;
    }
}

