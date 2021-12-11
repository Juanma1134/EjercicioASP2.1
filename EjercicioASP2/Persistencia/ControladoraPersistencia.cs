using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioASP2.Persistencia
{
    public class ControladoraPersistencia
    {
        #region PERSISTENCIA AUTORES
        public List<Dominio.Autores> ListaAutores()
        {
            return new PAutores().ListaAutores();
        }
        public bool AltaAutor(Dominio.Autores pAutor)
        {
            return new PAutores().AltaAut(pAutor);
        }

        public bool BajaAutor(int pId)
        {
            return new PAutores().BajaAut(pId);
        }

        public bool ModificarAutor(Dominio.Autores pAutor)
        {
            return new PAutores().ModificarAut(pAutor);
        }
        #endregion

        #region PERSISTENCIA LECTORES
        public List<Dominio.Lectores> ListaLectores()
        {
            return new PLectores().ListaLectores();
        }
        public bool AltaLector(Dominio.Lectores pLector)
        {
            return new PLectores().AltaLect(pLector);
        }

        public bool BajaLector(int pId)
        {
            return new PLectores().BajaLect(pId);
        }

        public bool ModificarLector(Dominio.Lectores pLector)
        {
            return new PLectores().ModificarLect(pLector);
        }
        #endregion
        
        #region PERSISTENCIA


        #endregion
    }
}