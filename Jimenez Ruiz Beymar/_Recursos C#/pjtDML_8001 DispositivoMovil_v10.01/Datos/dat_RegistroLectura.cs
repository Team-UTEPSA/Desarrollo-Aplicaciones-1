using System;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    public class dat_RegistroLectura : SQLSerializable
    {
        private int iId;
        private DateTime dFecha;
        private int iLectura;
        private bool bEnviado;
        private int iIdLecturador;
        private int iIdPeriodo;
        private int iIdMedidor;

        public dat_RegistroLectura()
        {
            this.iId = 0;
            this.dFecha = Convert.ToDateTime("01/01/1900");
            this.iLectura = 0;
            this.bEnviado = false;
            this.iIdLecturador = 0;
            this.iIdPeriodo = 0;
            this.iIdMedidor = 0;
        }

        public dat_RegistroLectura(int id, DateTime fecha, int lectura, bool enviado, int lecturador, int idPeriodo, int idMedidor)
        {
            this.iId = id;
            this.dFecha = fecha;
            this.iLectura = lectura;
            this.bEnviado = enviado;
            this.iIdLecturador = lecturador;
            this.iIdPeriodo = idPeriodo;
            this.iIdMedidor = idMedidor;
        }

        public int Id
        {
            get { return iId; }
            set { iId = value; }
        }

        public DateTime Fecha
        {
            get { return dFecha; }
            set { dFecha = value; }
        }

        public int Lectura
        {
            get { return iLectura; }
            set { iLectura = value; }
        }

        public bool Enviado
        {
            get { return bEnviado; }
            set { bEnviado = value; }
        }

        public int IdLecturador
        {
            get { return iIdLecturador; }
            set { iIdLecturador = value; }
        }

        public int IdPeriodo
        {
            get { return iIdPeriodo; }
            set { iIdPeriodo = value; }
        }

        public int IdMedidor
        {
            get { return iIdMedidor; }
            set { iIdMedidor = value; }
        }

        public String toInsert()
        {
            String sentencia = "INSERT INTO tblRegistroLectura VALUES (" + iId + ", '" + dFecha + "', " + iLectura + ", '" + bEnviado + "', " + IdLecturador + ", " + IdPeriodo + ", " + IdMedidor + ")";
            //String sentencia = "INSERT INTO tblRegistroLectura VALUES (" + iId + ", '13/05/2010'," + iLectura + ", '" + bEnviado + "', " + IdLecturador + ", " + IdPeriodo + ", " + IdMedidor + ")";
            return sentencia;
        }

        public String toUpdate()
        {
            String sentencia = "UPDATE tblRegistroLectura SET Fecha = '" + dFecha + "', Lectura = " + iLectura + ", Enviado = '" + bEnviado + "', IdLecturador = " + iIdLecturador + ", IdPeriodo = " + iIdPeriodo + ", IdMedidor = " + iIdMedidor + " WHERE Id = " + Id;
            return sentencia;
        }

        public String toDelete()
        {
            String sentencia = "DELETE FROM tblRegistroLectura WHERE Id = " + iId;
            return sentencia;
        }

        public String toSelect()
        {
            String sentencia = "SELECT * FROM tblRegistroLectura WHERE Id = " + iId;
            return sentencia;
        }

        public String toSelect_Parametrizado(String condicion)
        {
            String sentencia = "SELECT * FROM tblRegistroLectura WHERE " + condicion;
            return sentencia;
        }

        public String toSelectTodo()
        {
            String sentencia = "SELECT * FROM tblRegistroLectura";
            return sentencia;
        }


    }
}
