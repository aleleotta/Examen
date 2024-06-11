using Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class clsDeleteDAL
    {
        /// <summary>
        /// Borrara todas las personas que coincidan con el id de departamento pasado por parametro.
        /// </summary>
        /// <param name="idDept">El id de departamento para tomar como referencia.</param>
        /// <returns>Devuelve un mensaje en conjunto con el numero de filas afectadas.</returns>
        public static string deletePersonasPorDepartamento(int idDept)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = clsConnection.GetConnection();
            SqlCommand cmd;
            int affectedRows = 0;
            string result = "";
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@idDept", idDept);
                cmd.CommandText = "DELETE Personas WHERE IDDepartamento = @idDept;";
                affectedRows = cmd.ExecuteNonQuery();
                result = $"Se han borrado todas las personas del departamento {idDept}\nLineas afectadas: {affectedRows}";
                conn.Close();
            }
            catch (Exception err)
            {
                result = $"No se pudieron borrar las personas del departamento de {idDept}.\nLineas afectadas: {affectedRows}";
                Console.WriteLine(err.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            return result;
        }

    }
}
