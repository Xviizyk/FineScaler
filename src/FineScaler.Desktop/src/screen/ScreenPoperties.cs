using System;
using System.Reflection;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Platform;

namespace FineScaler.Desktop.Screen;

public class ScreenProperties
{
    #region AppProperties
    public static readonly string DefaultTitle = "FineScaler-v" + (Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion ?? "unknown");
    public const int DefaultWidth = 800;
    public const int DefaultHeight = 600;
    public static readonly WindowIcon DefaultIcon = new(AssetLoader.Open(new Uri("avares://FineScaler.Assets/assets/icon/icon.png")));
    #endregion

    #region ThemeColors
    public static readonly Color DefaultLightBackground = new(255, 255, 255, 255);
    public static readonly Color DefaultDarkBackground = new(255, 64, 64, 64);
    public Color DefaultCustomBackground = new(255, 128, 128, 128);
    #endregion

    #region ThemeState
    public ThemeMode CurrentTheme { get; set; } = ThemeMode.Dark;
    #endregion

    public enum ThemeMode
    {
        Light = 0,
        Dark = 1,
        Custom = 2
    }
}