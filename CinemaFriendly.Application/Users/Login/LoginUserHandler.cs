using CinemaFriendly.Domain.Repositories;
using CinemaFriendly.Domain.Services.Interfaces;

namespace CinemaFriendly.Application.Users.Login;

public class LoginUserHandler
{
    private readonly IUserRepository _userRepository;
    private readonly IJwtTokenGenerator _tokenGenerator;

    public LoginUserHandler(IUserRepository userRepository, IJwtTokenGenerator tokenGenerator)
    {
        _userRepository = userRepository;
        _tokenGenerator = tokenGenerator;
    }

    public async Task<string> HandleAsync(LoginUserCommand command)
    {
        var user = await _userRepository.GetByEmailAsync(command.Email);
        if (user is null)
            throw new InvalidOperationException("Usuario no encontrado.");

        if (!BCrypt.Net.BCrypt.Verify(command.Password, user.PasswordHash))
            throw new InvalidOperationException("Contraseña incorrecta.");

        var token = _tokenGenerator.GenerateToken(user.Id, user.UserName, user.Email);
        return token;
    }
}
