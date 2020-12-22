using Microsoft.AspNetCore.Mvc;
using RegistrationDemoMvc.WebApp.Models;

namespace RegistrationDemoMvc.WebApp.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Post(RegistrationModel model)
        {
            return View("Index", model);
        }
    }
}
