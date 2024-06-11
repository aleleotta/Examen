using DAL;
using Entities;

namespace BL
{
    public class clsGetBL
    {
        /// <summary>
        /// Devuelve un listado de personas filtrado por departamento llamando a la DAL.
        /// </summary>
        /// <param name="idDept">El id de departamento al que se quiere indicar.</param>
        /// <returns>Listado de personas filtrado por departamento</returns>
        public static List<clsPersona> getListadoPersonasFiltradoPorDepartamento(int idDept)
        {
            List<clsPersona> listadoPersonas;
            try
            {
                listadoPersonas = new List<clsPersona>(clsGetDAL.getListadoPersonasFiltradoPorDepartamento(idDept));
            }
            catch
            {
                listadoPersonas = new List<clsPersona>();
            }
            return listadoPersonas;
        }

        /// <summary>
        /// Devuelve el listado completo de departamentos llamando a la DAL.
        /// </summary>
        /// <returns>Listado completo de departamentos</returns>
        public static List<clsDepartamento> getListadoCompletoDepartamentos()
        {
            List<clsDepartamento> listadoDepartamentos;
            try
            {
                listadoDepartamentos = new List<clsDepartamento>(clsGetDAL.getListadoCompletoDepartamentos());
            }
            catch
            {
                listadoDepartamentos = new List<clsDepartamento>();
            }
            return listadoDepartamentos;
        }

    }
}
