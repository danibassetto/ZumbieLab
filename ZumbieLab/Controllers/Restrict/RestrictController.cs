using Microsoft.AspNetCore.Mvc;

namespace ZombieLab.Controllers.Restrict
{
    public class RestrictController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}