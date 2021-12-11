using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioASP2.Dominio
{
    public class ControladoraFeria
    {
        public ControladoraFeria() 
        {
            this._persistencia = new Persistencia.ControladoraPersistencia();
            this._listaAutores = _persistencia.ListaAutores();    
            this._listaLectores = _persistencia.ListaLectores();
            //this._listaPaises = _persistencia.ListaPaises(); CREAR LISTA EN PERSISTENCIA
            //this._listaGenero = _persistencia.ListaGenero(); CREAR LISTA EN PERSISTENCIA
        }

        private Persistencia.ControladoraPersistencia _persistencia;

        private List<Autores> _listaAutores;
        private List<Lectores> _listaLectores;
        //private List<Paises> _listaPaises; CREAR CLASE
        //private List<Genero> _listaGenero; CREAR CLASE
        private static List<Libros> _listaLibros = new List<Libros>();
        private static List<Ventas> _listaVentas = new List<Ventas>();

        #region ABM de AUTORES y Metodos Auxiliares
        public List<Autores> ListaAutores()
        {
            return _listaAutores;
        }

        //Busca en la _listaAutores si coincide el ID ingresado con los ID de la lista
        public Autores BuscarAutor(short pId)
        {
            if (_listaAutores.Count > 0)
            {
                foreach (Autores unAutor in _listaAutores)
                {
                    if (unAutor.Id == pId)
                    {
                        return unAutor;
                    }
                }
            }
            return null;
        }
        public bool AltaAutor(Autores pAutor)
        {
            Autores unAutor = BuscarAutor(pAutor.Id);
            if (unAutor == null)
            {
                _listaAutores.Add(pAutor);
                return true;
                //Acá lo que se da de alta es el parametro que yo ingreso, osea el objeto.
            }
            return false;
        }
        public bool BajaAutor(short pId)
        {
            Autores unAutor = BuscarAutor(pId);
            if (unAutor != null)
            {
                _listaAutores.Remove(unAutor);
                return true;
            }
            return false;
        }
        public bool ModificarAutor(short pId, string pNombre, string pApellido, DateTime pFechaNac, DateTime pFechaFall, string pNacionalidad)
        {
            Autores unAutor = BuscarAutor(pId);
            if (unAutor != null)
            {
                unAutor.Nombre = pNombre;
                unAutor.Apellido = pApellido;
                unAutor.FechaNac = pFechaNac;
                unAutor.FechaFall = pFechaFall;
                unAutor.Nacionalidad = pNacionalidad;
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region ABM de LECTORES y Metodos Auxiliares
        public List<Lectores> ListaLectores()
        {
            return _listaLectores;
        }

        /* Busca en la _listaLectores si coincide el ID ingresado con los ID de la lista*/
        public Lectores BuscarLector(short pId)
        {
            if (_listaLectores.Count > 0)
            {
                foreach (Lectores unLector in _listaLectores)
                {
                    if (unLector.Id == pId)
                    {
                        return unLector;
                    }
                }
            }
            return null;
        }
        public bool AltaLector(Lectores pLector)
        {
            Lectores unLector = BuscarLector(pLector.Id);
            if (unLector == null)
            {
                _listaLectores.Add(pLector);
                return true;
            }
            return false;
        }
        public bool BajaLector(short pId)
        {
            Lectores unLector = BuscarLector(pId);
            if (unLector != null)
            {
                _listaLectores.Remove(unLector);
                return true;
            }
            return false;
        }
        public bool ModificarLector(short pId, string pNombre, string pApellido)
        {
            Lectores unLector = BuscarLector(pId);
            if (unLector != null)
            {
                unLector.Nombre = pNombre;
                unLector.Apellido = pApellido;
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region ABM de LIBROS y Metodos Auxiliares
        public List<Libros> ListaLibros()
        {
            return _listaLibros;
        }
        public Libros BuscarLibro(short pId)
        {
            if (_listaLibros.Count > 0)
            {
                foreach (Libros unLibro in _listaLibros)
                {
                    if (unLibro.Id == pId)
                    {
                        return unLibro;
                    }
                }
            }
            return null;
        }
        public bool AltaLibro(Libros pLibro)
        {
            Libros unLibro = BuscarLibro(pLibro.Id);
            if (unLibro == null)
            {
                _listaLibros.Add(pLibro);
                return true;
            }
            return false;
        }
        public bool BajaLibro(short pId)
        {
            Libros unLibro = BuscarLibro(pId);
            if (unLibro != null)
            {
                _listaLibros.Remove(unLibro);
                return true;
            }
            return false;
        }
        public bool ModificarLibro(short pId, string pTitulo, string pGenero, DateTime pAño, Autores pAutor, int pPrecio, string pComentario)
        {
            Libros unLibro = BuscarLibro(pId);
            if (unLibro != null)
            {
                unLibro.Titulo = pTitulo;
                unLibro.Genero = pGenero;
                unLibro.Año = pAño;
                unLibro.Autores = pAutor;
                unLibro.Precio = pPrecio;
                unLibro.Comentario = pComentario;
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region VENTAS Emitir y Devolución
        public List<Ventas> ListaVentas()
        {
            return _listaVentas;
        }
        public Ventas BuscarVenta(short pId)
        {
            if (_listaVentas.Count > 0)
            {
                foreach (Ventas unVenta in _listaVentas)
                {
                    if (unVenta.IdVenta == pId)
                    {
                        return unVenta;
                    }
                }
            }
            return null;
        }
        public bool Vender(Ventas pVenta)
        {
            Ventas unVenta = BuscarVenta(pVenta.IdVenta);
            if (unVenta == null)
            {
                _listaVentas.Add(pVenta);
                return true;
            }
            return false;
        }
        public bool DevolucionVenta(short pIdVenta)
        {
            Ventas unVenta = BuscarVenta(pIdVenta);
            if (unVenta != null)
            {
                _listaVentas.Remove(unVenta);
                return true;
            }
            return false;
        }
        #endregion
    }
}