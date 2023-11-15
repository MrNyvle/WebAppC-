using Microsoft.AspNetCore.Mvc;
using WebApplication1.Infrastructure;

namespace WebApplication1.Controllers;

public class GameController : Controller
{
    private GameRepository _GameRepo = new GameRepository();

    public IActionResult Games()
    {
        return View(_GameRepo.Get());
    }

    public IActionResult Details(int id)
    {
        return View(_GameRepo.Get(id));
    }

    public IActionResult Add()
    {
        return View();
    }
}