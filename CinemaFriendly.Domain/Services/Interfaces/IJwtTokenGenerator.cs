namespace CinemaFriendly.Domain.Services;

public interface IJwtTokenGenerator
{
    string GenerateToken(Guid userId, string userName, string email);
}
