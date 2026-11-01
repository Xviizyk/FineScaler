using Avalonia;

namespace FineScaler.Desktop;

public static class Program
{
    public static void Main(string[] args)
    {
        AppBuilder.Configure<App>().UsePlatformDetect().LogToTrace().StartWithClassicDesktopLifetime(args);
    }
}