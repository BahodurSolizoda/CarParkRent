using Npgsql;
namespace Infrastructure.DataContext;

public class CarParkDbContext
{
    private readonly string _connectionString =
        "Host=localhost;Port=5432;Database=CarParkDb;Username=postgres;Password=7070";

    public NpgsqlConnection Connection()
    {
        return new NpgsqlConnection(_connectionString);
    }
}