using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OperadoresAplicacion.Controllers
{
    public class ExpressController : Controller
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

            return Json(new { data = Listaopera }, JsonRequestBehavior.AllowGet);
        }

        // Guardar Datos
        public ActionResult Guardar(Models.OperadoresApp opera)
        {

            services.Operadores _DbOpera = new services.Operadores();
            _DbOpera.AddOperador(opera);


            return Json(new { resultado = _DbOpera }, JsonRequestBehavior.AllowGet);

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

        public JsonResult Actualizar(int Id, Models.OperadoresApp operaDetails)
        {
            services.Operadores _DbOpera = new services.Operadores();
            _DbOpera.EditOperador(Id, operaDetails);

            return Json(new { resultado = _DbOpera }, JsonRequestBehavior.AllowGet);
        }


    }
}