using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace EjercicioASP2.Persistencia
{
    public class PAutores
    {
        private Persistencia.Conexion _conexión = new Persistencia.Conexion();

        public List<Dominio.Autores> ListaAutores()
        {
            string sql = "SELECT * FROM Autor";
            DataSet datos = this._conexión.Selección(sql);
            List<Dominio.Autores> lista = new List<Dominio.Autores>();
            foreach (DataRow fila in datos.Tables[0].Rows)
            {
                Dominio.Autores unAutor = new Dominio.Autores(
                    short.Parse(fila[0].ToString()),
                    fila[1].ToString(),
                    fila[2].ToString(),
                    Convert.ToDateTime(fila[3].ToString()),
                    Convert.ToDateTime(fila[4].ToString()),
                    fila[5].ToString());
                lista.Add(unAutor);
            }
            return lista;
        }

        public bool AltaAut(Dominio.Autores pAutor)
        {
            string sql = "INSERT INTO Autor (idAutor,nombreAutor,apellidoAutor,fechaNac,fechaFall,nacionalidad) VALUES("
                + pAutor.Id.ToString() + ",'"
                + pAutor.Nombre + "','"
                + pAutor.Apellido + "','"
                + pAutor.FechaNac + "','"
                + pAutor.FechaFall + "','"
                + pAutor.Nacionalidad + "')";
            return this._conexión.Consulta(sql);
        }
        public bool BajaAut(int pId)
        {
            string sql = "DELETE FROM Autor WHERE id=" + pId.ToString();
            return this._conexión.Consulta(sql);
        }

        public bool ModificarAut(Dominio.Autores pAutor)
        {
            string sql = "UPDATE Autor SET "
                + "nombreAutor='" + pAutor.Nombre + "',"
                + "apellidoAutor='" + pAutor.Apellido + "',"
                + "fechaNac='" + pAutor.FechaNac + "',"
                + "fechaFall='" + pAutor.FechaFall + "',"
                + "nacionalidad='" + pAutor.Nacionalidad + "' "
                + "WHERE idAutor=" + pAutor.Id.ToString();
            return this._conexión.Consulta(sql);
        }
    }
}