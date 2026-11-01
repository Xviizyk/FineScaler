using Avalonia.Controls;
using Avalonia.Layout;

namespace FineScaler.Desktop.Screen;

public class MainScreen : Window
{
    public MainScreen()
    {
        Title = "FineScaler";
        Width = 800;
        Height = 600;

        Content = new TextBlock
        {
            Text = "Tetodayo!",
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center
        };
    }
}