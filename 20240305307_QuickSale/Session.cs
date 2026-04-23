using QuickSale.DAL.Models;

namespace _20240305307_QuickSale;

/// <summary>Holds the currently authenticated user for the lifetime of the application.</summary>
public static class Session
{
    public static User? CurrentUser { get; set; }
    public static bool IsAdmin => CurrentUser?.Role == "Admin";

    public static void Clear() => CurrentUser = null;
}
