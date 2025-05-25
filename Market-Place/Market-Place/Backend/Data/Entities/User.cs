namespace Market_Place.Backend.Models;

public class User
{
    // Свойства для юзера
    public required int Id { get; set; }
    public required string Username { get; set; }
    public string PasswordHash { get; set; }
    public required string Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? AvatarUrl { get; set; }
    public DateTime RegistrtionDateTime { get; set; } = DateTime.Now;
    
    // Навигационные свойтсва
    public List<Car> Cars { get; set; } = new (); // Car for sale
    public List<Favorite> Favorites { get; set; } = new (); // Favorite auto
    public List<Review> ReviewsReceived { get; set; } = new (); // отзывы о продавце
    public List<Review> ReviewsWritten { get; set; } = new (); // Отзывы которые он написал
}