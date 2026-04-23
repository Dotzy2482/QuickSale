using Microsoft.EntityFrameworkCore;

namespace QuickSale.DAL;

/// <summary>
/// Called once at application startup to create / migrate the SQLite database.
/// Keeps EF Core relational extension methods out of the UI project.
/// </summary>
public static class DatabaseInitializer
{
    public static void Initialize()
    {
        using var ctx = new AppDbContext();
        ctx.Database.Migrate();
    }
}
