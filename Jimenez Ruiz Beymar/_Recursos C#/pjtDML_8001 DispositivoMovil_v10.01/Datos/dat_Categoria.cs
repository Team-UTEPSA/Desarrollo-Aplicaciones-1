using System;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    public class dat_Categoria : SQLSerializable
    {
        private int iId;
        private String sServicio;
        private String sNombre;
        private String sUnidad;
        private float  fPrecio;

        public dat_Categoria()
        {
            this.iId = 0;
            this.sServicio = "";
            this.sNombre = "";
            this.sUnidad = "";
            this.fPrecio=0;
        }

        public dat_Categoria(int id,String servicio, String nombre, String unidad, float precio)
        {
            this.iId = id;
            this.sNombre = nombre;
            this.sServicio = servicio;
            this.sUnidad = unidad;
            this.fPrecio = precio;
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

        public string Servicio
        {
            get { return sServicio; }
            set { sServicio = value; }
        }

        public string Unidad
        {
            get { return sUnidad; }
            set { sUnidad = value; }
        }

        public float Precio
        {
            get { return fPrecio; }
            set { fPrecio = value; }
        }
        public String toInsert()
        {
            String sentencia = "INSERT INTO tblCategoria VALUES (" + iId + ", '" + sServicio + "', '" + sNombre + "', '" + sUnidad + "',"+ fPrecio;
            return sentencia;
        }

        public String toUpdate()
        {
            String sentencia = "UPDATE tblCategoria SET Servicio = '" + sServicio + "', Nombre = '" + sNombre + "', Unidad = '" + sUnidad + "', Precio= " + fPrecio + " WHERE Id = " + Id;
            return sentencia;
        }

        public String toDelete()
        {
            String sentencia = "DELETE FROM tblCategoria WHERE Id = " + iId;
            return sentencia;
        }

        public String toSelect()
        {
            String sentencia = "SELECT * FROM tblCategoria WHERE Id = " + iId;
            return sentencia;
        }

        public String toSelect_Parametrizado(String condicion)
        {
            String sentencia = "SELECT * FROM tblCategoria WHERE " + condicion;
            return sentencia;
        }

        public String toSelectTodo()
        {
            String sentencia = "SELECT * FROM tblCategoria";
            return sentencia;
        }

    }
}
