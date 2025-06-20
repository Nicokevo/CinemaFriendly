namespace CinemaFriendly.Domain.Entities;

using CinemaFriendly.Domain.Enums;

public class Trailer
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Title { get; private set; } = null!;
    public string Description { get; private set; } = null!;
    public string VideoUrl { get; private set; } = null!;
    public Guid UploadedByUserId { get; private set; }
    public DateTime UploadedAt { get; private set; } = DateTime.UtcNow;
    public TrailerStatus Status { get; private set; } = TrailerStatus.Published;
    public TrailerGenre Genre { get; private set; }

    private Trailer() { }

    public static Trailer Create(string title, string description, string videoUrl, Guid userId, TrailerGenre genre, TrailerStatus status = TrailerStatus.Published)
    {
        return new Trailer
        {
            Title = title,
            Description = description,
            VideoUrl = videoUrl,
            UploadedByUserId = userId,
            Genre = genre,
            Status = status
        };
    }
}
