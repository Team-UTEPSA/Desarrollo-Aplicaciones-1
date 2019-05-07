using System;
using System.Collections.Generic;
using System.Linq;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using System.Text;
using System.Threading.Tasks;


namespace Caso_EnviarMensaje
{
    public class Usuario
    {
        static List<object> Persona = new List<object>();
        public string Nombre  { get; set; }
        public string User { get; set; }
        public string telefono { get; set; }
        public int id { get; set; }
        public string mensaje { get; set; }
        public void Crear_Mensaje(string msj, string nom,string usuario,int key)
        {
            this.Nombre = nom;
            this.User = usuario;
            this.telefono = telefono;
            this.id = key;
            this.mensaje = msj;
        }
        public List<object> cargar_Usuario (int id)
        {
            string nombre, apellido, telefono;
            using (dbCanchaV01Entities1 db = new dbCanchaV01Entities1())
            {
                var query = (from a in db.tblPersona
                             where a.idPersona == id
                             select a
                            ).ToList().FirstOrDefault();
                nombre = query.Nombre;
                apellido = query.Apellido;
                telefono = query.Telefono;
            };
            Persona.Add(nombre);
            Persona.Add(apellido);
            Persona.Add(telefono);
            return Persona;
        }
        public void Enviar_Mensaje(string msj , string telefono)
        {

            var message1 = MessageResource.Create(
            body: "Twilio trial account.",
            from: new Twilio.Types.PhoneNumber("+15017122661"),
            to: new Twilio.Types.PhoneNumber("+59160856818")
        );
            var message = MessageResource.Create(
                from: new PhoneNumber("whatsapp:+12074069564"),
                to: new PhoneNumber("whatsapp:+591" + telefono),
                body: msj
                );


        }
    }
}
