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

    public void Add(GameModel iGame)
    {
        _dbContext.Games.Add(iGame);
        ForceSave();
    }

    public void Delete(int iGameId)
    {
        GameModel? game = Get(iGameId);
        if (game is null)
        {
            Console.WriteLine($"Game id {iGameId} does not exist");
            return;
        }
        Delete(game);
    }

    public void Delete(GameModel iGame)
    {
        _dbContext.Games.Remove(iGame);
        ForceSave();
    }

    private void ForceSave()
    {
        _dbContext.SaveChanges();
    }

}