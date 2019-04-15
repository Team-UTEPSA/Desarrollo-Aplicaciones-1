using System;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    public class dat_Periodo : SQLSerializable
    {
        private int iId;
        private String sNombre;

        public dat_Periodo()
        {
            this.iId = 0;
            this.sNombre = "";

        }

        public dat_Periodo(int id, String nombre)
        {
            this.iId = id;
            this.sNombre = nombre;


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



        public String toInsert()
        {
            String sentencia = "INSERT INTO tblPeriodo VALUES (" + iId + ", '" + sNombre;
            return sentencia;
        }

        public String toUpdate()
        {
            String sentencia = "UPDATE tblPeriodo SET Nombre = '" + sNombre + "' WHERE Id = " + Id;
            return sentencia;
        }

        public String toDelete()
        {
            String sentencia = "DELETE FROM tblPeriodo WHERE Id = " + iId;
            return sentencia;
        }

        public String toSelect()
        {
            String sentencia = "SELECT * FROM tblPeriodo WHERE Id = " + iId;
            return sentencia;
        }

        public String toSelect_Parametrizado(String condicion)
        {
            String sentencia = "SELECT * FROM tblPeriodo WHERE " + condicion;
            return sentencia;
        }

        public String toSelectTodo()
        {
            String sentencia = "SELECT * FROM tblPeriodo";
            return sentencia;
        }

    }
}
