using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationDemoMvc.WebApp.Controllers
{
    public class RegistrationScaffoldController : Controller
    {
        // GET: RegistrationScaffoldController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RegistrationScaffoldController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RegistrationScaffoldController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegistrationScaffoldController/Create
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

        // GET: RegistrationScaffoldController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RegistrationScaffoldController/Edit/5
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

        // GET: RegistrationScaffoldController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RegistrationScaffoldController/Delete/5
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
