namespace Api.Infrastructure;

public class DatabaseSettings
{
    public string User { get; init; } = "postgres";
    public string Password { get; init; } = "postgres";
    public string Host { get; init; } = "localhost";
    public string Database { get; init; } = "postgres";
    public int Port { get; init; } = 5432;
}
