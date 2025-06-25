namespace CinemaFriendly.Shared.Models;

public class TrailerDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string Genre { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string VideoUrl { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}
