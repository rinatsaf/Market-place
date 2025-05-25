namespace Market_Place.Backend.Models;

public class CarImage
{
    public int Id { get; set; }
    public string ImageUrl { get; set; }
    public bool IsMainImage { get; set; }
    
    // внешний ключ
    public int CarId { get; set; }
    public required Car Car { get; set; }
}