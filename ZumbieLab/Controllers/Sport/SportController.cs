using Microsoft.AspNetCore.Mvc;
using ZumbieLab.Models;
using ZumbieLab.Repositories;

namespace ZumbieLab.Controllers
{
    public class SportController : Controller
    {
        private readonly ISportRepository _sportRepository;

        public SportController(ISportRepository sportRepository)
        {
            _sportRepository = sportRepository;
        }

        public IActionResult Index()
        {
            List<SportModel> sport = _sportRepository.GetAll();
            return View(sport);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Update(int id)
        {
            SportModel sport = _sportRepository.Get(id);
            return View(sport);
        }

        public IActionResult DeleteConfirmation(int id)
        {
            SportModel sport = _sportRepository.Get(id);
            return View(sport);
        }

        public IActionResult Delete(int id)
        {

            try
            {
                bool excluded = _sportRepository.Delete(id);

                if (excluded)
                {
                    TempData["SuccessMessage"] = "Esporte excluído com sucesso";
                }
                else
                {
                    TempData["ErrorMessage"] = $"Erro: não foi possível apagar este esporte";
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
        public IActionResult Create(SportModel sport)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _sportRepository.Create(sport);
                    TempData["SuccessMessage"] = "Esporte cadastrado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(sport);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Erro: {ex.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Update(SportModel sport)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _sportRepository.Update(sport);
                    TempData["SuccessMessage"] = "Esporte alterado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(sport);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Erro: {ex.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}