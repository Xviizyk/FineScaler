using System;
using Avalonia;

namespace FineScaler.Desktop;

public static class Program
{
    public static void Main(string[] args)
    {
        try
        {
            AppBuilder.Configure<App>().UsePlatformDetect().LogToTrace().StartWithClassicDesktopLifetime(args);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"ERROR!\nSorry, but FineScaler couldn't open.\nError: {ex}");
        }
    }
}