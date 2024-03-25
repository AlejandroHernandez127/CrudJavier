using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OperadoresAplicacion.Controllers
{
    public class AjaxController : Controller
    {
        // GET: Ajax
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult ObtenerOperadores()
        {
            List<Models.OperadoresApp> opera = new List<Models.OperadoresApp>();
            services.Operadores operadorRepository = new services.Operadores();

            opera = operadorRepository.GetAllOperadores();

            return Json(new{data = opera}, JsonRequestBehavior.AllowGet);
        }

        // Guardar Datos
        public ActionResult AddNewOpera(Models.OperadoresApp opera)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    services.Operadores _DbOpera = new services.Operadores();
                    if (_DbOpera.AddOperador(opera))
                    {
                        return RedirectToAction("Index");

                    }
                }

                return View();

            }
            catch
            {
                return View();
            }
        }
    }
}