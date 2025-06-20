public class User
{
    public Guid Id { get; private set; } = Guid.NewGuid();

    public string UserName { get; private set; } = null!;
    public string Email { get; private set; } = null!;
    public string PasswordHash { get; private set; } = null!;

    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;

    private User() { }

    public static User Create(string userName, string email, string passwordHash)
    {
        return new User
        {
            UserName = userName,
            Email = email,
            PasswordHash = passwordHash
        };
    }
}
