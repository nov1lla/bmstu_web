using Api.Endpoints;
using Api.Infrastructure;
using System.Text.Json.Serialization;
using BL.RepositoryInterfaces;
using BL.Services;
using DA;
using Microsoft.AspNetCore.Http.Json;

var builder = WebApplication.CreateBuilder(args);

var dbSettings = new DatabaseSettings
{
    User = builder.Configuration["DB_USER"] ?? "postgres",
    Password = builder.Configuration["DB_PASSWORD"] ?? "postgres",
    Host = builder.Configuration["DB_HOST"] ?? "localhost",
    Database = builder.Configuration["DB_NAME"] ?? "postgres",
    Port = int.TryParse(builder.Configuration["DB_PORT"], out var port) ? port : 5432
};

builder.Services.AddSingleton(dbSettings);
builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.Converters.Add(new JsonStringEnumConverter());
});

builder.Services.AddScoped(_ =>
    new Connector(dbSettings.User, dbSettings.Password, dbSettings.Host, dbSettings.Database, dbSettings.Port));
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IPromoRepository, PromoRepository>();
builder.Services.AddScoped<ICartRepository, CartRepository>();
builder.Services.AddScoped<IItemCartRepository, ItemCartRepository>();
builder.Services.AddScoped<IItemOrderRepository, ItemOrderRepository>();
builder.Services.AddScoped<IUserPromoRepository, UserPromoRepository>();

builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<OrderService>();
builder.Services.AddScoped<PromoService>();
builder.Services.AddScoped<CartService>();
builder.Services.AddScoped<ItemCartService>();
builder.Services.AddScoped<ItemOrderService>();

var app = builder.Build();

app.UseMiddleware<ReadOnlyGuardMiddleware>();

app.Use(async (context, next) =>
{
    if (context.Request.Path.StartsWithSegments("/api/v2"))
    {
        context.Response.OnStarting(() =>
        {
            context.Response.Headers["X-Api-Version"] = "2";
            return Task.CompletedTask;
        });
    }
    await next();
});

app.MapGet("/status", () => Results.Ok(new
{
    status = "ok",
    service = "bmstu-web-api",
    readOnly = string.Equals(app.Configuration["APP_READ_ONLY"], "true", StringComparison.OrdinalIgnoreCase),
    timeUtc = DateTime.UtcNow
}));

app.MapAuthEndpoints("/api/v1");
app.MapProductEndpoints("/api/v1");
app.MapUserEndpoints("/api/v1");
app.MapOrderEndpoints("/api/v1");

app.MapAuthEndpoints("/api/v2");
app.MapProductEndpoints("/api/v2");
app.MapUserEndpoints("/api/v2");
app.MapOrderEndpoints("/api/v2");
app.MapGet("/api/v2/version", () => Results.Ok(new { version = "v2" }));

var specV1Path = Path.Combine(app.Environment.ContentRootPath, "openapi.v1.yaml");
var specV2Path = Path.Combine(app.Environment.ContentRootPath, "openapi.v2.yaml");

app.MapGet("/api/v1", () => Results.Content(
    SwaggerUiPage.Build("/api/v1/openapi.yaml", "BMSTU Web API v1"),
    "text/html"));

app.MapGet("/api/v2", () => Results.Content(
    SwaggerUiPage.Build("/api/v2/openapi.yaml", "BMSTU Web API v2"),
    "text/html"));

app.MapGet("/api/v1/openapi.yaml", () => Results.File(specV1Path, "application/yaml"));
app.MapGet("/api/v2/openapi.yaml", () => Results.File(specV2Path, "application/yaml"));

app.Run();
