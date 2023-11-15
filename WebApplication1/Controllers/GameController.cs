using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class GameController : Controller
{
    public IActionResult Games()
    {

        var games = new List<GamesModel>();
        games.Add(new GamesModel
        {
            GameName = "Minecraft"
        });
        
        
        return View(games);
    }
}