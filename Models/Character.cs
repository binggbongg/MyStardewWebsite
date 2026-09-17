namespace MyWebsite.Models;

public class Character
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Birthday { get; set; } = string.Empty; // e.g., "Spring 14"
    public string FavoriteGift { get; set; } = string.Empty;
    public string FavoriteSeason { get; set; } = string.Empty; // e.g., "Fall"
    public string FavoriteFood { get; set; } = string.Empty;
    public List<string> Hobbies { get; set; } = new();
    public List<string> Family { get; set; } = new();
    public string ShortDescription { get; set; } = string.Empty;

    // Helpful helper properties for UI & logic:
    public string ImageUrl { get; set; } = string.Empty; 
    public string DetailedDescription { get; set; } = string.Empty; // For the unlocked view
}