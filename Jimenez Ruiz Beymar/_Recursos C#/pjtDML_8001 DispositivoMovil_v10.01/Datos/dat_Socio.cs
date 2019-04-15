using System;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    public class dat_Socio : SQLSerializable
    {
        private int iId;
        private String sNombre;
        private String sApellido;
        private String sTelefono;

        public dat_Socio()
        {
            this.iId = 0;
            this.sNombre = "";
            this.sApellido = "";
            this.sTelefono = "";
        }

        public dat_Socio(int id, String nombre, String apellido, String telefono)
        {
            this.iId = id;
            this.sNombre = nombre;
            this.sApellido = apellido;
            this.sTelefono = telefono;
        }

        public int Id
        {
            get { return iId; }
            set { iId = value; }
        }

        public String Nombre
        {
            get { return sNombre; }
            set { sNombre = value; }
        }

        public string Apellido
        {
            get { return sApellido; }
            set { sApellido = value; }
        }

        public string Telefono
        {
            get { return sTelefono; }
            set { sTelefono = value; }
        }

        public String toInsert()
        {
            String sentencia = "INSERT INTO tblSocio VALUES (" + iId + ", '" + sNombre + "', '" + sApellido + "', '" + sTelefono + "')";
            return sentencia;
        }

        public String toUpdate()
        {
            String sentencia = "UPDATE tblSocio SET Nombre = '" + sNombre + "', Apellido = '" + sApellido + "', Telefono = '" + sTelefono + "' WHERE Id = " + Id;
            return sentencia;
        }

        public String toDelete()
        {
            String sentencia = "DELETE FROM tblSocio WHERE Id = " + iId;
            return sentencia;
        }

        public String toSelect()
        {
            String sentencia = "SELECT * FROM tblSocio WHERE Id = " + iId;
            return sentencia;
        }

        public String toSelect_Parametrizado(String condicion)
        {
            String sentencia = "SELECT * FROM tblSocio WHERE " + condicion;
            return sentencia;
        }

        public String toSelectTodo()
        {
            String sentencia = "SELECT * FROM tblSocio";
            return sentencia;
        }

    }
}
