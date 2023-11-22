using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class GameModel
{
    [Key]
    public int Id { get; set; }
    
    [MaxLength(50)]
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string ImageLink { get; set; }
};