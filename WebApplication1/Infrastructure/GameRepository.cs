using WebApplication1.Models;

namespace WebApplication1.Infrastructure;

public class GameRepository
{
    private GameDbContext _dbContext = new GameDbContext();
    
    
    public List<GameModel> Get()
    {
        return _dbContext.Games.ToList();
    }

    public GameModel? Get(int iGameId)
    {
        return _dbContext.Games.Find(iGameId);
    }

}