namespace Market_Place.Backend.Models;

public class Car
{
    public required int Id { get; set; }
    public required string Brand { get; set; }
    public required string Model { get; set; }
    public required int Year { get; set; }
    public required decimal Price { get; set; }
    public required int Mileage { get; set; } // Пробег
    public required float EngineVolume { get; set; }
    public required TransmissionType TypeOfTransmission { get; set; }
    public required FuelType TypeOfFuel { get; set; }
    public string? Description { get; set; }
    public required bool isSold { get; set; }
    
    // Внешний ключ на пользователя (продавца)
    public int SellerId { get; set; }
    public required User Seller { get; set; }
    
    // Навигационные свойства
    public List<CarImage> Images { get; set; } = new();
    public List<User> FavoritedBy { get; set; } = new();
}

public enum TransmissionType
{
    auto,
    manual
}

public enum FuelType
{
    petrol,
    diesel,
    gasoline,
    electric
}
