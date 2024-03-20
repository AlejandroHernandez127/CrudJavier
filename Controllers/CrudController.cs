using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace OperadoresAplicacion.Controllers
{
    public class CrudController : Controller
    {
        // GET: Crud
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            ProjectMVC.Logica.Services.Empresa empresa = new ProjectMVC.Logica.Services.Empresa();
            ViewBag.ListEmpresa = empresa.GetEmpresas();


            return View();
        }
        [HttpPost]
        public ActionResult CreateOperadores()
        {
            ProjectMVC.Logica.Services.Empresa empresa = new ProjectMVC.Logica.Services.Empresa();
              ViewBag.ListEmpresa = empresa.GetEmpresas();

            ProjectMVC.Logica.Services.Operadores operadores = new ProjectMVC.Logica.Services.Operadores();

            var Nombre = Request.Form["Nombre"];
            var Edad = Convert.ToInt32(Request.Form["Edad"]);
            var Salario = Convert.ToInt32(Request.Form["Salario"]);
            var Fecha_Nacimiento = Convert.ToDateTime(Request.Form["Fecha_Nacimiento"]);
            var IdEmpresa= Convert.ToInt32(Request.Form["IdEmpresa"]);

            operadores.CreatedOperadores(Nombre,
                                         Edad,
                                         Salario,
                                         Fecha_Nacimiento,
                                         IdEmpresa);


            return View("Index");
        }
    }
}