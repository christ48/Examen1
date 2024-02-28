using Fronend.Helpers.Interfaces;
using Fronend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fronend.Controllers
{
    public class DistritoController1 : Controller
    {

        IDistritoHelper DistritoHelper;

        public DistritoController1(IDistritoHelper distritoHelper)
        {
            DistritoHelper = distritoHelper;
        }


            // GET: DistritoController1
        public ActionResult Index()
        {
            List<DistritoViewModel> lista=DistritoHelper.GetDistritos();
            return View(lista);
        }

        // GET: DistritoController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DistritoController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DistritoController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DistritoController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DistritoController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DistritoController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DistritoController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
