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
            ProjectMVC.Logica.Services.Operadores operadores = new ProjectMVC.Logica.Services.Operadores();
            ViewBag.ListOperadores = operadores.GetOperadores();

            var operadorEdit = operadores.GetOperadores().FirstOrDefault();


            var operadorEditBindingModel = new ProjectMVC.Logica.Models.BindingModels.OperadoresCreateBindingModel
            {
                Id = operadorEdit.Id,
                Nombre = operadorEdit.Nombre,
                Edad = operadorEdit.Edad,
                Salario = operadorEdit.Salario,
                Fecha_Nacimiento = operadorEdit.Fecha_Nacimiento,
                IdEmpresa = operadorEdit.IdEmpresa
            };

            return View(operadores.GetOperadores());
        }

        public ActionResult Create()
        {
            ProjectMVC.Logica.Services.Empresa empresa = new ProjectMVC.Logica.Services.Empresa();
            ViewBag.ListEmpresa = empresa.GetEmpresas();


            return View();
        }
        [HttpPost]
        public ActionResult CreateOperadores(ProjectMVC.Logica.Models.BindingModels.OperadoresCreateBindingModel model)
        {
            ProjectMVC.Logica.Services.Empresa empresa = new ProjectMVC.Logica.Services.Empresa();
              ViewBag.ListEmpresa = empresa.GetEmpresas();

            ProjectMVC.Logica.Services.Operadores operadores = new ProjectMVC.Logica.Services.Operadores();

            /*
            var Nombre = Request.Form["Nombre"];
            var Edad = Convert.ToInt32(Request.Form["Edad"]);
            var Salario = Convert.ToInt32(Request.Form["Salario"]);
            var Fecha_Nacimiento = Convert.ToDateTime(Request.Form["Fecha_Nacimiento"]);
            var IdEmpresa= Convert.ToInt32(Request.Form["IdEmpresa"]);
            */

            operadores.CreatedOperadores(model.Nombre,
                                         model.Edad,
                                         model.Salario,
                                         model.Fecha_Nacimiento,
                                         model.IdEmpresa);

            
            return RedirectToAction("Index");
        }

       
           public ActionResult Delete(int Id)
            {
                ProjectMVC.Logica.Services.Operadores operadores = new ProjectMVC.Logica.Services.Operadores();
                var operador = operadores.DeleteOperador(Id);

                return View(operador);

            }




        
        public ActionResult Edit(ProjectMVC.Logica.Models.BindingModels.OperadoresCreateBindingModel
             model) {
          
            ProjectMVC.Logica.Services.Operadores operadores = new ProjectMVC.Logica.Services.Operadores();
            ProjectMVC.Logica.Services.Empresa empresa = new ProjectMVC.Logica.Services.Empresa();

            ViewBag.ListOperadores = operadores.GetOperadores();
            ViewBag.ListEmpresa = empresa.GetEmpresas();

            if (ModelState.IsValid)
            {
                operadores.EditOperadores(
                    model.Id,
                    model.Nombre,
                    model.Edad,
                    model.Salario,
                    model.Fecha_Nacimiento,
                    model.IdEmpresa);
            }

           
            return View(model);
        }

     /*   public ActionResult Update(int Id)
        {
            ProjectMVC.Logica.Services.Operadores operadores = new ProjectMVC.Logica.Services.Operadores();
            var operadores.GetById(Id);
        }*/

       


       
    }
}