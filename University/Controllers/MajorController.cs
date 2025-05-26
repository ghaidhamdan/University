using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;
using University.Models;

namespace University.Controllers
{
    public class MajorController : Controller
    {
        // GET: MajorController
        public ActionResult Index()
        {
            // This is a sample data source for demonstration purposes.
            List<Major> majors;
            majors = new List<Major>();

            majors = new List<Major>
            {
               new Major{MajorId=1 , MajorName="Computer Science"},
           };

            var data = majors.ToList();
            return View(data);
        }

        // GET: MajorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MajorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MajorController/Create
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

        // GET: MajorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MajorController/Edit/5
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

        // GET: MajorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MajorController/Delete/5
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
