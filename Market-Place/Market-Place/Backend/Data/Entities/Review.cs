namespace Market_Place.Backend.Models;

public class Review
{
    public int Id { get; set; }
    public string Content { get; set; }
    public int Rating { get; set; }
    public DateTime Created { get; set; } = DateTime.Now;
    
    // внешние ключи
    public int AuthorId { get; set; }
    public User User { get; set; }
    
    public int SellerId { get; set; }
    public User Seller { get; set; }
    
}