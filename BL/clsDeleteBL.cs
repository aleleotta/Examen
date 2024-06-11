using DAL;

namespace BL
{
    public class clsDeleteBL
    {
        /// <summary>
        /// Comprueba que la hora no sea entre las 18:00 hasta las 8:00 y si esta permitido se llama la funcion de borrar en la base de datos.
        /// </summary>
        /// <param name="idDept">El id de departamento para tomar como referencia.</param>
        /// <returns>Mensaje que informa si se ha podido hacer el borrado.</returns>
        public static string deletePersonasPorDepartamento(int idDept)
        {
            string result = "";
            if (DateTime.Now.Hour > 18 || DateTime.Now.Hour < 8)
            {
                try
                {
                    result = clsDeleteDAL.deletePersonasPorDepartamento(idDept);
                }
                catch
                {
                    result = $"No se pudo hacer el borrado de todas las personas.";
                }
            }
            else
            {
                result = "No se pueden borrar personas desde algun departamento entre las horas 18:00 hasta 8:00.";
            }
            return result;
        }
    }
}
