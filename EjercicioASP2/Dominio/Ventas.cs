using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioASP2.Dominio
{
    public class Ventas
    {
        private short _id;
        private DateTime _fechaVenta;
        private Libros _tituloLibro;
        private Autores _autor;
        private Lectores _lector;
        private int _precio;

        #region METODO DE LOS ATRIBUTOS
        public short IdVenta
        {
            get { return _id; }
            set { _id = value; }
        }
        public DateTime FechaVenta
        {
            get { return _fechaVenta; }
            set { _fechaVenta = value; }
        }
        public Libros TituloLibro
        {
            get { return _tituloLibro; }
            set { _tituloLibro = value; }
        }
        public Autores Autor
        {
            get { return _autor; }
            set { _autor = value; }
        }
        public Lectores Lector
        {
            get { return _lector; }
            set { _lector = value; }
        }
        public int Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        #endregion

        public Ventas(short pId, DateTime pFechaVenta, Libros pTituloLibro, Autores pAutor, Lectores pLector, int pPrecio)
        {
            this.IdVenta = pId;
            this.FechaVenta = pFechaVenta;
            this.TituloLibro = pTituloLibro;
            this.Autor = pAutor;
            this.Lector = pLector;
            this.Precio = pPrecio;
        }
        public override string ToString()
        {
            return "Id: " + this.IdVenta + " Fecha venta: " + this.FechaVenta + " Titulo libro " + this.TituloLibro + " Autor: " + this.Autor + " Lector: " + this.Lector + " Precio: " + this.Precio;
        }
    }
}