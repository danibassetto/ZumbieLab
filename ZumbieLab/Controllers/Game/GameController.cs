using Microsoft.AspNetCore.Mvc;
using ZumbieLab.Models;
using ZumbieLab.Repositories;

namespace ZumbieLab.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameRepository _gameRepository;

        public GameController(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public IActionResult Index()
        {
            List<GameModel> game = _gameRepository.GetAll();
            return View(game);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Update(int id)
        {
            GameModel game = _gameRepository.Get(id);
            return View(game);
        }

        public IActionResult DeleteConfirmation(int id)
        {
            GameModel game = _gameRepository.Get(id);
            return View(game);
        }

        public IActionResult Delete(int id)
        {

            try
            {
                bool excluded = _gameRepository.Delete(id);

                if (excluded)
                {
                    TempData["SuccessMessage"] = "Jogo excluído com sucesso";
                }
                else
                {
                    TempData["ErrorMessage"] = $"Erro: não foi possível apagar este jogo";
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
        public IActionResult Create(GameModel game)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _gameRepository.Create(game);
                    TempData["SuccessMessage"] = "Jogo cadastrado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(game);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Erro: {ex.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Update(GameModel game)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _gameRepository.Update(game);
                    TempData["SuccessMessage"] = "Jogo alterado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(game);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Erro: {ex.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}