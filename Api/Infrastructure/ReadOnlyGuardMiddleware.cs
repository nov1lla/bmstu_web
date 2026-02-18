using System.Net;
using System.Text.Json;

namespace Api.Infrastructure;

public class ReadOnlyGuardMiddleware
{
    private readonly RequestDelegate _next;
    private readonly bool _readOnly;

    public ReadOnlyGuardMiddleware(RequestDelegate next, IConfiguration configuration)
    {
        _next = next;
        _readOnly = string.Equals(configuration["APP_READ_ONLY"], "true", StringComparison.OrdinalIgnoreCase);
    }

    public async Task Invoke(HttpContext context)
    {
        if (_readOnly &&
            context.Request.Path.StartsWithSegments("/api") &&
            !HttpMethods.IsGet(context.Request.Method) &&
            !HttpMethods.IsHead(context.Request.Method) &&
            !HttpMethods.IsOptions(context.Request.Method))
        {
            context.Response.StatusCode = (int)HttpStatusCode.MethodNotAllowed;
            context.Response.ContentType = "application/json";
            var payload = JsonSerializer.Serialize(new { error = "This backend is read-only." });
            await context.Response.WriteAsync(payload);
            return;
        }

        await _next(context);
    }
}
