namespace WebApplication1.Models;

public class GameLibraryModel
{
    public GameLibraryModel()
    {
        Games = new List<GameModel>{
            new GameModel {Id = 1, Name = "Minecraft" },
            new GameModel {Id = 2, Name = "Valorant" },
            new GameModel {Id = 3, Name = "Portal" }
        };
    }

    public List<GameModel> Games { get; set; }

}
