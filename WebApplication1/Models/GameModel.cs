namespace WebApplication1.Models;

public class GameModel
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string ImageLink { get; set; }
};