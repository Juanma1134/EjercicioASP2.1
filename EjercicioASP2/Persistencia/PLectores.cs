using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace EjercicioASP2.Persistencia
{
    public class PLectores
    {
        private Persistencia.Conexion _conexión = new Persistencia.Conexion();

        public List<Dominio.Lectores> ListaLectores()
        {
            string sql = "SELECT * FROM Lector";
            DataSet datos = this._conexión.Selección(sql);
            List<Dominio.Lectores> lista = new List<Dominio.Lectores>();
            foreach (DataRow fila in datos.Tables[0].Rows)
            {
                Dominio.Lectores unLector = new Dominio.Lectores(
                    short.Parse(fila[0].ToString()),
                    fila[1].ToString(),
                    fila[2].ToString());


                lista.Add(unLector);
            }
            return lista;
        }

        public bool AltaLect(Dominio.Lectores pLector)
        {
            string sql = "INSERT INTO Lector (idLector,nombreLector,apellidoLector) VALUES("
                + pLector.Id.ToString() + ",'"
                + pLector.Nombre + "','"
                + pLector.Apellido + "')";
            return this._conexión.Consulta(sql);
        }
        public bool BajaLect(int pId)
        {
            string sql = "DELETE FROM Lector WHERE id=" + pId.ToString();
            return this._conexión.Consulta(sql);
        }

        public bool ModificarLect(Dominio.Lectores pLector)
        {
            string sql = "UPDATE Lector SET "
                + "nombreLector='" + pLector.Nombre + "',"
                + "apellidoLector='" + pLector.Apellido + "' "
                + "WHERE idLector=" + pLector.Id.ToString();
            return this._conexión.Consulta(sql);
        }
    }
}