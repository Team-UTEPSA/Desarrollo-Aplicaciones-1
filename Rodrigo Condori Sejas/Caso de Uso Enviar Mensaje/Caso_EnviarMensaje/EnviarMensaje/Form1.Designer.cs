namespace EnviarMensaje
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.btn_CargarUsuario = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_telefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.pictureBox_imagen = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_whatsapp = new System.Windows.Forms.Button();
            this.btn_facebook = new System.Windows.Forms.Button();
            this.txtbox_mensaje = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox_ID);
            this.panel1.Controls.Add(this.btn_CargarUsuario);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox_telefono);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_usuario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_nombre);
            this.panel1.Controls.Add(this.pictureBox_imagen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 460);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "ID:";
            // 
            // textBox_ID
            // 
            this.textBox_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.textBox_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_ID.Location = new System.Drawing.Point(12, 379);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(175, 13);
            this.textBox_ID.TabIndex = 9;
            // 
            // btn_CargarUsuario
            // 
            this.btn_CargarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.btn_CargarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CargarUsuario.Location = new System.Drawing.Point(16, 424);
            this.btn_CargarUsuario.Name = "btn_CargarUsuario";
            this.btn_CargarUsuario.Size = new System.Drawing.Size(171, 23);
            this.btn_CargarUsuario.TabIndex = 8;
            this.btn_CargarUsuario.Text = "Cargar Usuario";
            this.btn_CargarUsuario.UseVisualStyleBackColor = false;
            this.btn_CargarUsuario.Click += new System.EventHandler(this.btn_CargarUsuario_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Telefono:";
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.textBox_telefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_telefono.Location = new System.Drawing.Point(12, 339);
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.Size = new System.Drawing.Size(175, 13);
            this.textBox_telefono.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Usuario:";
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.textBox_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_usuario.Location = new System.Drawing.Point(12, 292);
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(175, 13);
            this.textBox_usuario.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre:";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.textBox_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_nombre.Location = new System.Drawing.Point(12, 245);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(175, 13);
            this.textBox_nombre.TabIndex = 2;
            // 
            // pictureBox_imagen
            // 
            this.pictureBox_imagen.Location = new System.Drawing.Point(12, 48);
            this.pictureBox_imagen.Name = "pictureBox_imagen";
            this.pictureBox_imagen.Size = new System.Drawing.Size(175, 170);
            this.pictureBox_imagen.TabIndex = 2;
            this.pictureBox_imagen.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enviar Mensaje";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(206, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mensaje:";
            // 
            // btn_whatsapp
            // 
            this.btn_whatsapp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_whatsapp.BackgroundImage")));
            this.btn_whatsapp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_whatsapp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_whatsapp.FlatAppearance.BorderSize = 0;
            this.btn_whatsapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_whatsapp.Location = new System.Drawing.Point(256, 311);
            this.btn_whatsapp.Name = "btn_whatsapp";
            this.btn_whatsapp.Size = new System.Drawing.Size(40, 41);
            this.btn_whatsapp.TabIndex = 6;
            this.btn_whatsapp.UseVisualStyleBackColor = true;
            this.btn_whatsapp.Click += new System.EventHandler(this.btn_whatsapp_Click);
            // 
            // btn_facebook
            // 
            this.btn_facebook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_facebook.BackgroundImage")));
            this.btn_facebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_facebook.FlatAppearance.BorderSize = 0;
            this.btn_facebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_facebook.Location = new System.Drawing.Point(210, 311);
            this.btn_facebook.Name = "btn_facebook";
            this.btn_facebook.Size = new System.Drawing.Size(40, 41);
            this.btn_facebook.TabIndex = 7;
            this.btn_facebook.UseVisualStyleBackColor = true;
            this.btn_facebook.Click += new System.EventHandler(this.btn_facebook_Click);
            // 
            // txtbox_mensaje
            // 
            this.txtbox_mensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.txtbox_mensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_mensaje.Location = new System.Drawing.Point(210, 73);
            this.txtbox_mensaje.Name = "txtbox_mensaje";
            this.txtbox_mensaje.Size = new System.Drawing.Size(343, 232);
            this.txtbox_mensaje.TabIndex = 8;
            this.txtbox_mensaje.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(565, 460);
            this.Controls.Add(this.txtbox_mensaje);
            this.Controls.Add(this.btn_facebook);
            this.Controls.Add(this.btn_whatsapp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(565, 460);
            this.MinimumSize = new System.Drawing.Size(565, 460);
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_CargarUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_telefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.PictureBox pictureBox_imagen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_whatsapp;
        private System.Windows.Forms.Button btn_facebook;
        private System.Windows.Forms.RichTextBox txtbox_mensaje;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_ID;
    }
}

