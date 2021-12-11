using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioASP2.Dominio
{
    public class Personas
    {
        /*Datos de las personas*/
        private short _id;
        private string _nombre;
        private string _apellido;

        #region METODOS DE LOS ATRIBUTOS

        public short Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        #endregion

        public Personas(short pId, string pNombre, string pApellido)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
        }
        public override string ToString()
        {
            return "Id: " + this.Id + " " + this.Nombre + " " + this.Apellido;
        }
    }
}
