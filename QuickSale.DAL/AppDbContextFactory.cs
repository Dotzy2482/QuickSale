using Microsoft.EntityFrameworkCore.Design;

namespace QuickSale.DAL;

/// <summary>
/// Allows "dotnet ef migrations" to discover AppDbContext from the DAL class library
/// without requiring a runnable startup project.
/// </summary>
public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args) => new AppDbContext();
}
