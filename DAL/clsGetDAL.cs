using Entities;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class clsGetDAL
    {
        /// <summary>
        /// Devuelve un listado de personas filtrado de personas.
        /// Precondicion: NUNCA se devolveran todas las personas de toda la tabla. Hay que utilizar el WHERE en la sentencia SQL.
        /// <param name="idDept">El id de departamento para tomar como referencia.</param>
        /// </summary>
        /// <returns>El listado de personas filtrado por departamento</returns>
        public static List<clsPersona> getListadoPersonasFiltradoPorDepartamento(int idDept)
        {
            List<clsPersona> listadoPersonas = new List<clsPersona>();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = clsConnection.GetConnection();
            SqlCommand cmd;
            SqlDataReader reader;
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@idDept", idDept);
                cmd.CommandText = "SELECT * FROM Personas WHERE IDDepartamento = @idDept";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        clsPersona persona = new clsPersona((int)reader["ID"], (string)reader["Nombre"], (string)reader["Apellidos"], (int)reader["IDDepartamento"]);
                        listadoPersonas.Add(persona);
                    }
                }
                conn.Close();
            }
            catch (Exception err)
            {
                listadoPersonas = new List<clsPersona>();
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
            return listadoPersonas;
        }

        /// <summary>
        /// Devuelve el listado completo de departamentos.
        /// </summary>
        /// <returns>El listado completo de departamentos</returns>
        public static List<clsDepartamento> getListadoCompletoDepartamentos()
        {
            List<clsDepartamento> listadoDepartamentos = new List<clsDepartamento>();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = clsConnection.GetConnection();
            SqlCommand cmd;
            SqlDataReader reader;
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM Departamentos";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        clsDepartamento departamento = new clsDepartamento((int)reader["ID"], (string)reader["Nombre"]);
                        listadoDepartamentos.Add(departamento);
                    }
                }
                conn.Close();
            }
            catch (Exception err)
            {
                listadoDepartamentos = new List<clsDepartamento>();
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
            return listadoDepartamentos;
        }

    }
}
