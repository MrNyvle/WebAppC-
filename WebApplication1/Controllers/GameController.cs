using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class GameController : Controller
{
    public IActionResult Games()
    {
        return View(new GameLibraryModel());
    }

    public IActionResult Details(int id)
    {
        var library = new GameLibraryModel();

        return View(library.Games.FirstOrDefault((iGame) => { return iGame != null && iGame.Id == id; }, null));
    }
}