using Microsoft.AspNetCore.Mvc;
using ZombieLab.Models;
using ZombieLab.Repositories;

namespace ZombieLab.Controllers
{
    public class HostController : Controller
    {
        private readonly IHostRepository _hostRepository;

        public HostController(IHostRepository hostRepository)
        {
            _hostRepository = hostRepository;
        }

        public IActionResult Index()
        {
            List<HostModel> contatos = _hostRepository.GetAll();
            return View(contatos);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Update(long id)
        {
            HostModel contato = _hostRepository.Get(id);
            return View(contato);
        }

        public IActionResult DeleteConfirmation(long id)
        {
            HostModel contato = _hostRepository.Get(id);
            return View(contato);
        }

        public IActionResult Delete(long id)
        {

            try
            {
                bool excluded = _hostRepository.Delete(id);

                if (excluded)
                {
                    TempData["SuccessMessage"] = "Hospedeiro excluído com sucesso";
                }
                else
                {
                    TempData["ErrorMessage"] = $"Erro: não foi possível apagar este hospedeiro";
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Erro: {ex.Message}";
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public IActionResult Create(HostModel host)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _hostRepository.Create(host);
                    TempData["SuccessMessage"] = "Hospedeiro cadastrado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(host);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Erro: {ex.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Update(HostModel host)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _hostRepository.Update(host);
                    TempData["SuccessMessage"] = "Hospedeiro alterado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(host);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Erro: {ex.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult ShowAttributes(long id)
        {
            HostModel host = _hostRepository.Get(id);
            return PartialView("_ShowAttributes", host);
        }
    }
}