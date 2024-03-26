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
            List<Models.OperadoresApp> Listaopera = new List<Models.OperadoresApp>();
            services.Operadores operadorRepository = new services.Operadores();

            Listaopera = operadorRepository.GetAllOperadores();

            return Json(new{data = Listaopera}, JsonRequestBehavior.AllowGet);
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

        public JsonResult ObtenerOperador(int Id)
        {
            Models.OperadoresApp opera = new Models.OperadoresApp();
            services.Operadores operadorRepository = new services.Operadores();

            opera = operadorRepository.GetOperadorById(Id);

            return Json(opera, JsonRequestBehavior.AllowGet);

        }

        public JsonResult Eliminar(int Id)
        {
            services.Operadores _DbOpera = new services.Operadores();
            _DbOpera.Elimina(Id);

                return Json(new { resultado = _DbOpera }, JsonRequestBehavior.AllowGet);


        }
            
        
    }

}