using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ZombieLab.Models;
using ZombieLab.Repositories;

namespace ZombieLab.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostRepository _hostRepository;
        public HomeController(IHostRepository hostRepository) 
        { 
            _hostRepository = hostRepository;
        }

        public IActionResult Index()
        {
            int host = _hostRepository.GetAll().Count;
            return View(host);
        }

        public IActionResult Info() 
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}