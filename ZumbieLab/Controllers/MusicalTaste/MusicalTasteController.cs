using Microsoft.AspNetCore.Mvc;
using ZumbieLab.Models;
using ZumbieLab.Repositories;

namespace ZumbieLab.Controllers
{
    public class MusicalTasteController : Controller
    {
        private readonly IMusicalTasteRepository _musicalTasteRepository;

        public MusicalTasteController(IMusicalTasteRepository musicalTasteRepository)
        {
            _musicalTasteRepository = musicalTasteRepository;
        }

        public IActionResult Index()
        {
            List<MusicalTasteModel> musicalTaste = _musicalTasteRepository.GetAll();
            return View(musicalTaste);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Update(int id)
        {
            MusicalTasteModel musicalTaste = _musicalTasteRepository.Get(id);
            return View(musicalTaste);
        }

        public IActionResult DeleteConfirmation(int id)
        {
            MusicalTasteModel musicalTaste = _musicalTasteRepository.Get(id);
            return View(musicalTaste);
        }

        public IActionResult Delete(int id)
        {

            try
            {
                bool excluded = _musicalTasteRepository.Delete(id);

                if (excluded)
                {
                    TempData["SuccessMessage"] = "Gosto musical excluído com sucesso";
                }
                else
                {
                    TempData["ErrorMessage"] = $"Erro: não foi possível apagar este gosto musical";
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
        public IActionResult Create(MusicalTasteModel musicalTaste)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _musicalTasteRepository.Create(musicalTaste);
                    TempData["SuccessMessage"] = "Gosto musical cadastrado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(musicalTaste);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Erro: {ex.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Update(MusicalTasteModel musicalTaste)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _musicalTasteRepository.Update(musicalTaste);
                    TempData["SuccessMessage"] = "Gosto musical alterado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(musicalTaste);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Erro: {ex.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}