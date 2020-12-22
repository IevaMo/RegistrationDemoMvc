using Microsoft.AspNetCore.Mvc;

namespace RegistrationDemoMvc.WebApp.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Post(RegisrationModel model)
        {
            return View("Index", model);
        }
    }
}
