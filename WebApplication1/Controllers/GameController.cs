using Microsoft.AspNetCore.Mvc;
using WebApplication1.Infrastructure;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class GameController : Controller
{
    private GameRepository _GameRepo = new GameRepository();

    public IActionResult Games()
    {
        return View(_GameRepo.Get());
    }

    public IActionResult Index()
    {
        return RedirectToAction("Games", "Game");
    }

    public IActionResult Details(int id)
    {
        return View(_GameRepo.Get(id));
    }

    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Add(GameModel iGame)
    {
        _GameRepo.Add(iGame);
        return RedirectToAction("Details", "Game", new { id = iGame.Id });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Delete(int id)
    {
        _GameRepo.Delete(id);
        return RedirectToAction("Games", "Game");
    }

}