using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioASP2.Dominio
{
    public class Autores:Personas
    {
        private DateTime _fechaNac;
        private DateTime _fechaFall;
        private string _nacionalidad;

        #region METODO DE LOS ATRIBUTOS
        public DateTime FechaNac
        {
            get { return _fechaNac; }
            set { _fechaNac = value; }
        }
        public DateTime FechaFall
        {
            get { return _fechaFall; }
            set { _fechaFall = value; }
        }
        public string Nacionalidad
        {
            get { return _nacionalidad; }
            set { _nacionalidad = value; }
        }
        #endregion

        public Autores(short pId, string pNombre, string pApellido, DateTime pFechaNac, DateTime pFechaFall, string pNacionalidad) : base(pId, pNombre, pApellido)
        /*Autores tiene todo los atributos de la clase, luego se pone los datos que hereda de la clase madre, se deben colocar en el mismo orden*/
        {
            this.FechaNac = pFechaNac;
            this.FechaFall = pFechaFall;
            this.Nacionalidad = pNacionalidad;
        }
        public override string ToString()
        {
            return base.ToString() + " Fecha Nacimiento: " + this.FechaNac.ToShortDateString() + " Fecha Fallecimiento: " + this.FechaFall.ToShortDateString() + " Nacionalidad: " + this.Nacionalidad;
        }
    }
}