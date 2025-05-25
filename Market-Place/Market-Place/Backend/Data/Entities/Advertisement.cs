namespace Market_Place.Backend.Models;

public class Advertisement
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public bool IsActive { get; set; } = true;
    public int ViewsCount { get; set; } = 0;
    
    // Внешние ключи
    public int CarId { get; set; }
    public required Car Car { get; set; }
    
    public int SellerId { get; set; }
    public required User Seller { get; set; }
}