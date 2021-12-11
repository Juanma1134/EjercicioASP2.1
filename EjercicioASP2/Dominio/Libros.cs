using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioASP2.Dominio
{
    public class Libros
    {
        private short _id;
        private string _titulo;
        private string _genero;
        private DateTime _año;
        private Autores _autores;
        private int _precio;
        private string _comentario;

        #region METODOS DE LOS ATRIBUTOS
        public short Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }
        public string Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }
        public DateTime Año
        {
            get { return _año; }
            set { _año = value; }
        }
        public Autores Autores
        {
            get { return _autores; }
            set { _autores = value; }
        }
        public int Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        public string Comentario
        {
            get { return _comentario; }
            set { _comentario = value; }
        }
        #endregion

        public Libros(short pId, string pTitulo, string pGenero, DateTime pAño, Autores pAutores, int pPrecio, string pComentario)
        {
            this.Id = pId;
            this.Titulo = pTitulo;
            this.Genero = pGenero;
            this.Año = pAño;
            this.Autores = pAutores;
            this.Precio = pPrecio;
            this.Comentario = pComentario;
        }
        public override string ToString()
        {
            return "Id: " + this.Id + " Titulo: " + this.Titulo + " Genero: " + this.Genero + " Año: " + this.Año + " Autores: " + this.Autores + " Precio: " + this.Precio + " Comentario: " + this.Comentario;
        }
    }
}
