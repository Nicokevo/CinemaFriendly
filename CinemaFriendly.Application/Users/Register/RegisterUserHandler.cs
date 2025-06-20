using CinemaFriendly.Domain.Entities;
using CinemaFriendly.Domain.Repositories;

namespace CinemaFriendly.Application.Users.Register;

public class RegisterUserHandler
{
    private readonly IUserRepository _userRepository;

    public RegisterUserHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task HandleAsync(RegisterUserCommand command)
    {
        var existingUser = await _userRepository.GetByEmailAsync(command.Email);
        if (existingUser != null)
            throw new InvalidOperationException("Ya existe un usuario con ese email.");

        var hashedPassword = BCrypt.Net.BCrypt.HashPassword(command.Password);

        var user = User.Create(command.UserName, command.Email, hashedPassword);

        await _userRepository.AddAsync(user);
    }
}
