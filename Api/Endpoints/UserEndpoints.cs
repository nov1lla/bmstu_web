using Api.Contracts;
using BL.Models;
using BL.Services;

namespace Api.Endpoints;

public static class UserEndpoints
{
    public static void MapUserEndpoints(this IEndpointRouteBuilder app, string prefix)
    {
        app.MapGet($"{prefix}/users", (UserService service) =>
        {
            var users = service.getAllUsers().Select(x => x.ToDto());
            return Results.Ok(users);
        });

        app.MapGet($"{prefix}/users/{{id:int}}", (int id, UserService service) =>
        {
            try
            {
                return Results.Ok(service.GetUser(id).ToDto());
            }
            catch (Exception ex)
            {
                return Results.NotFound(new ErrorDto(ex.Message));
            }
        });

        app.MapPost($"{prefix}/users", (CreateUserRequest request, UserService service) =>
        {
            try
            {
                var user = new User(
                    0,
                    request.Name,
                    request.Phone,
                    request.Address,
                    request.Email,
                    request.Login,
                    request.Password,
                    request.Role);

                service.AddUser(user);
                var created = service.getUserByLogin(request.Login);
                return created is null
                    ? Results.Created("/api/v1/users", null)
                    : Results.Created($"/api/v1/users/{created.Id}", created.ToDto());
            }
            catch (Exception ex)
            {
                return Results.BadRequest(new ErrorDto(ex.Message));
            }
        });

        app.MapPut($"{prefix}/users/{{id:int}}", (int id, UpdateUserRequest request, UserService service) =>
        {
            try
            {
                var user = new User(
                    id,
                    request.Name,
                    request.Phone,
                    request.Address,
                    request.Email,
                    request.Login,
                    request.Password,
                    request.Role);

                service.UpdateUser(user);
                return Results.Ok(user.ToDto());
            }
            catch (Exception ex)
            {
                return Results.BadRequest(new ErrorDto(ex.Message));
            }
        });

        app.MapDelete($"{prefix}/users/{{id:int}}", (int id, UserService service) =>
        {
            try
            {
                var user = service.GetUser(id);
                service.DeleteUser(user);
                return Results.NoContent();
            }
            catch (Exception ex)
            {
                return Results.NotFound(new ErrorDto(ex.Message));
            }
        });
    }
}
