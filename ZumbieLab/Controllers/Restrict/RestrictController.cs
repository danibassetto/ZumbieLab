using Microsoft.AspNetCore.Mvc;

namespace ZumbieLab.Controllers.Restrict
{
    public class RestrictController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}