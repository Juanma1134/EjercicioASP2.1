using System;
using System.Data;
using System.Data.SqlClient;

namespace EjercicioASP2.Persistencia
{
    public class Conexion
    {
        private string _cadenaConexión = @"data source=DELLINSPIRON550\SQLEXPRESS" +
                                        "Initial Catalog=feriaLibro;Integrated Security=SSPI";

        public bool Consulta(string sql)
        {
            try
            {
                SqlConnection conexión = new SqlConnection(this._cadenaConexión);
                SqlCommand comando = new SqlCommand(sql, conexión);
                conexión.Open();
                comando.ExecuteNonQuery();
                comando.Dispose();
                conexión.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Error en Conexión.Consulta, sql = " + sql, e);
            }
        }
        public DataSet Selección(string sql)
        {
            try
            {
                SqlConnection conexión = new SqlConnection(this._cadenaConexión);
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, conexión);
                DataSet resultado = new DataSet();
                conexión.Open();
                adaptador.Fill(resultado);
                adaptador.Dispose();
                conexión.Close();
                return resultado;
            } 
            catch (Exception e)
            {
                throw new Exception("Error en Conexión.Selección, sql = " + sql, e);
            }
        }
    }
}