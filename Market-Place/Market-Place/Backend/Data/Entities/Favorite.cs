namespace Market_Place.Backend.Models;

public class Favorite
{
    public int Id { get; set; }
    
    // внешние ключи 
    public int UserId { get; set; }
    public required User User { get; set; }
    
    public int CarId { get; set; }
    public required Car Car { get; set; }
}