using WebApplication1.Models;

namespace WebApplication1.Infrastructure;

public class GameRepository
{
    private List<GameModel> _Games { get; set; } = new List<GameModel>{
            new GameModel {Id = 1, Name = "Minecraft", Description = "Mining and Crafting", ImageLink = "https://upload.wikimedia.org/wikipedia/fr/thumb/0/03/Minecraft_Logo.svg/langfr-2560px-Minecraft_Logo.svg.png"},
            new GameModel {Id = 2, Name = "Valorant", Description =" Valo and Ranting", ImageLink = " https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Valorant_logo_-_pink_color_version.svg/langfr-1920px-Valorant_logo_-_pink_color_version.svg.png"},
            new GameModel {Id = 3, Name = "Portal", Description = "Port and aling", ImageLink = "https://upload.wikimedia.org/wikipedia/fr/thumb/c/ce/Portal_(jeu_vidéo)_Logo.svg/langfr-2560px-Portal_(jeu_vidéo)_Logo.svg.png"},
            new GameModel {Id = 4, Name = "Trackmania", Description = "Traking and Maniaing", ImageLink = " https://upload.wikimedia.org/wikipedia/commons/thumb/d/d7/Logo_Trackmania.svg/langfr-2560px-Logo_Trackmania.svg.png"}
        };

    public List<GameModel> Get()
    {
        return _Games;
    }

    public GameModel? Get(int iGameId)
    {
        return _Games.FirstOrDefault((iGame) => { return iGame != null && iGame.Id == iGameId; }, null);
    }

}