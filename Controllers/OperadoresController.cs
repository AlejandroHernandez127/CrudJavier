using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OperadoresAplicacion.Models;

namespace OperadoresAplicacion.Controllers
{
    public class OperadoresController : Controller
    {
        private AppEntities db = new AppEntities();

        // GET: Operadores
        public ActionResult Index()
        {
            var operadores = db.Operadores.Include(o => o.Empresa);
            return View(operadores.ToList());
        }

        // GET: Operadores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Operadores operadores = db.Operadores.Find(id);
            if (operadores == null)
            {
                return HttpNotFound();
            }
            return View(operadores);
        }

        // GET: Operadores/Create
        public ActionResult Create()
        {
            ViewBag.IdEmpresa = new SelectList(db.Empresa, "Id", "Razon_Social");
            return View();
        }

        // POST: Operadores/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,Edad,Salario,Fecha_Nacimiento,Rowcreated_A,IdEmpresa")] Operadores operadores)
        {
            if (ModelState.IsValid)
            {
                db.Operadores.Add(operadores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdEmpresa = new SelectList(db.Empresa, "Id", "Razon_Social", operadores.IdEmpresa);
            return View(operadores);
        }

        // GET: Operadores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Operadores operadores = db.Operadores.Find(id);
            if (operadores == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdEmpresa = new SelectList(db.Empresa, "Id", "Razon_Social", operadores.IdEmpresa);
            return View(operadores);
        }

        // POST: Operadores/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,Edad,Salario,Fecha_Nacimiento,Rowcreated_A,IdEmpresa")] Operadores operadores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(operadores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdEmpresa = new SelectList(db.Empresa, "Id", "Razon_Social", operadores.IdEmpresa);
            return View(operadores);
        }

        // GET: Operadores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Operadores operadores = db.Operadores.Find(id);
            if (operadores == null)
            {
                return HttpNotFound();
            }
            return View(operadores);
        }

        // POST: Operadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Operadores operadores = db.Operadores.Find(id);
            db.Operadores.Remove(operadores);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
