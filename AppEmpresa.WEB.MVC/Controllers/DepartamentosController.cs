using AppEmpresa.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AppEmpresa.ConsumeAPI;
using System.Runtime.InteropServices;

namespace AppEmpresa.WEB.MVC.Controllers
{
    public class DepartamentosController : Controller
    {
        private string urlApi;

        public DepartamentosController(IConfiguration configuration)
        {
            urlApi = configuration.GetValue("ApiUrlBase", "").ToString() + "/Departamentos";
        }

        // GET: DepartamentosController
        public ActionResult Index()
        {
            var data = Crud<Departamento>.Read(urlApi);
            return View(data);
        }

        // GET: DepartamentosController/Details/5
        public ActionResult Details(int id)
        {
            var data = Crud<Departamento>.Read_ById(urlApi, id);
            return View(data);
        }

        // GET: DepartamentosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartamentosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Departamento data)
        {
            try
            {
                var newData = Crud<Departamento>.Create(urlApi, data);

                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(data);
            }
        }

        // GET: DepartamentosController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = Crud<Departamento>.Read_ById(urlApi, id);
            return View(data);
        }

        // POST: DepartamentosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Departamento data)
        {
            try
            {
                Crud<Departamento>.Update(urlApi, id, data);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(data);
            }
        }

        // GET: DepartamentosController/Delete/5    
        public ActionResult Delete(int id)
        {
            var data = Crud<Departamento>.Read_ById(urlApi, id);
            return View(data);
        }

        // POST: DepartamentosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Departamento data)
        {
            try
            {
                Crud<Departamento>.Delete(urlApi, id);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(data);
            }
        }
    }
}
