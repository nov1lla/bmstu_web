using BL.Models;

namespace Api.Contracts;

public record UserDto(
    int Id,
    string Name,
    string Phone,
    string Address,
    string Email,
    string Login,
    Role Role);

public record CreateUserRequest(
    string Name,
    string Phone,
    string Address,
    string Email,
    string Login,
    string Password,
    Role Role);

public record UpdateUserRequest(
    string Name,
    string Phone,
    string Address,
    string Email,
    string Login,
    string Password,
    Role Role);

public record LoginRequest(string Login, string Password);

public static class UserMapping
{
    public static UserDto ToDto(this User user) =>
        new(user.Id, user.Name, user.Phone, user.Address, user.Email, user.Login, user.Role);
}
