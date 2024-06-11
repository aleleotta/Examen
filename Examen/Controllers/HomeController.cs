using BL;
using Entities;
using Examen.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Examen.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Carga el listado completo de departamentos y lo manda a la vista.
        /// </summary>
        /// <returns>La vista SeleccionarDept con le modelo</returns>
        public IActionResult SeleccionarDept()
        {
            try
            {
                List<clsDepartamento> listadoDepartamentos = new List<clsDepartamento>(clsGetBL.getListadoCompletoDepartamentos());
                return View(listadoDepartamentos);
            }
            catch
            {
                return View("Results/ErrorGetDepartamentos");
            }
        }

        //No tuve el tiempo de implementar la ultima vista para confirmar y hacer la operacion.

        /// <summary>
        /// Pide de confirmar para poder borrar todas las personas
        /// </summary>
        /// <returns>La vista</returns>
        public IActionResult ConfirmarDelete()
        {
            try
            {
                clsDeleteBL.
                return View();
            }
            catch
            {
                return View();
            }
        }

        /// <summary>
        /// Manda el id de departamento a la BL para intentar el borrado.
        /// </summary>
        /// <param name="idDept"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult ConfirmarDelete(int idDept)
        {
            return View();
        }

    }
}
