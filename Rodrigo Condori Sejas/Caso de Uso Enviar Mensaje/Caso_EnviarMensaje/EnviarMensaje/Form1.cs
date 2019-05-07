using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Caso_EnviarMensaje;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace EnviarMensaje
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            TwilioClient.Init(
                "AC7db055a036706d847564d6d9f8db70a9",
                "29ab5c469dccc313b6ae998bff8b5cce"
                );
        }
        Caso_EnviarMensaje.Usuario obj = new Caso_EnviarMensaje.Usuario();

        private void btn_CargarUsuario_Click(object sender, EventArgs e)
        {
            List<object> Usuario;
            Usuario = obj.cargar_Usuario(int.Parse(textBox_ID.Text));
            textBox_nombre.Text = Usuario[0].ToString() +" "+ Usuario[1].ToString();
            textBox_usuario.Text = Usuario[0].ToString().Substring(0, 3);
            textBox_telefono.Text = Usuario[2].ToString();
        }

        private void btn_facebook_Click(object sender, EventArgs e)
        {

        }

        private void btn_whatsapp_Click(object sender, EventArgs e)
        {
            obj.Crear_Mensaje(txtbox_mensaje.Text,textBox_nombre.Text,textBox_usuario.Text,int.Parse(textBox_ID.Text));
            obj.Enviar_Mensaje(txtbox_mensaje.Text, textBox_telefono.Text);
        }
    }
}
