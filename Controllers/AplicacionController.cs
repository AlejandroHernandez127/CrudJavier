using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OperadoresAplicacion.Controllers
{
    public class AplicacionController : Controller
    {
        // GET: Aplicacion
        public ActionResult Index()
        {
            List<Models.OperadoresApp> leads = new List<Models.OperadoresApp>();
            services.Operadores operadorRepository = new services.Operadores();

            leads = operadorRepository.GetAllOperadores();
            return View(leads);
        }

        public ActionResult EditLead(int Id)
        {
            Models.OperadoresApp leads = new Models.OperadoresApp();
            services.Operadores operadorRepository = new services.Operadores();

            leads = operadorRepository.GetOperadorById(Id);
            return View(leads);
        }

        public ActionResult EditLeadDetails(int Id, Models.OperadoresApp operaDetails)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    services.Operadores _DbOpera = new services.Operadores();
                    if (_DbOpera.EditOperador(Id,operaDetails))
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
  

        public ActionResult AddOperador()
        {
            return View();
        }
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

        public ActionResult DeleteOpera(int Id)
        {
            Models.OperadoresApp leads = new Models.OperadoresApp();
            services.Operadores operadorRepository = new services.Operadores();

            leads = operadorRepository.GetOperadorById(Id);
            return View(leads);
        }

        public ActionResult DeleteDetails(int Id, Models.OperadoresApp operaDetails)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    services.Operadores _DbOpera = new services.Operadores();
                    if (_DbOpera.DeleteOperador(Id, operaDetails))
                    {
                        return RedirectToAction("Index");

                    }
                }

                return RedirectToAction("Index");

            }
            catch
            {
                return RedirectToAction("Index");
            }
        }




    }
        
}