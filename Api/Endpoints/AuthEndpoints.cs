using Api.Contracts;
using BL.Services;

namespace Api.Endpoints;

public static class AuthEndpoints
{
    public static void MapAuthEndpoints(this IEndpointRouteBuilder app, string prefix)
    {
        app.MapPost($"{prefix}/auth/login", (LoginRequest request, UserService service) =>
        {
            try
            {
                var user = service.LogIn(request.Login, request.Password);
                return Results.Ok(user.ToDto());
            }
            catch (Exception ex)
            {
                return Results.BadRequest(new ErrorDto(ex.Message));
            }
        });

        app.MapPost($"{prefix}/auth/register", (CreateUserRequest request, UserService service) =>
        {
            try
            {
                var user = service.Register(
                    request.Name,
                    request.Phone,
                    request.Address,
                    request.Email,
                    request.Login,
                    request.Password,
                    request.Role);

                return Results.Created($"/api/v1/users/{user.Id}", user.ToDto());
            }
            catch (Exception ex)
            {
                return Results.BadRequest(new ErrorDto(ex.Message));
            }
        });
    }
}
